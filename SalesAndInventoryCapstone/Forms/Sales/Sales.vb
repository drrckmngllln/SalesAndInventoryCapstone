Imports Microsoft.EntityFrameworkCore
Imports System.ComponentModel

Public Class Sales
    Private _context As New DataContext() ' Keep alive until form closes
    Private inventoryItems As New BindingList(Of SaleItemGrid) ' BindingList auto-updates the grid

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridInit()
        dgv.DataSource = inventoryItems
        lReferenceNo.Text = Guid.NewGuid().ToString().ToUpper()
    End Sub

    Sub DataGridInit()
        dgv.Columns.Clear()
        dgv.AutoGenerateColumns = False

        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "Id"
        colId.HeaderText = "ID"
        colId.DataPropertyName = "Id"
        colId.Visible = False ' Hide ID column

        Dim colCode As New DataGridViewTextBoxColumn()
        colCode.Name = "Code"
        colCode.HeaderText = "Code"
        colCode.DataPropertyName = "Code"

        Dim colDesc As New DataGridViewTextBoxColumn()
        colDesc.Name = "Description"
        colDesc.HeaderText = "Description"
        colDesc.Width = 700
        colDesc.DataPropertyName = "Description"

        Dim colQty As New DataGridViewTextBoxColumn()
        colQty.Name = "Quantity"
        colQty.HeaderText = "Quantity"
        colQty.Width = 100
        colQty.DataPropertyName = "Quantity"

        Dim colPrice As New DataGridViewTextBoxColumn()
        colPrice.Name = "Price"
        colPrice.HeaderText = "Price"
        colPrice.DataPropertyName = "Price"

        dgv.Columns.AddRange({colCode, colDesc, colQty, colPrice})
    End Sub

    Private Function CalculateTotal() As Decimal
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgv.Rows
            total += Convert.ToDecimal(row.Cells("Price").Value)
        Next
        Return total
    End Function

    Async Sub HandleAddInventory(code As String)
        Dim inventory = Await _context.Inventories.FirstOrDefaultAsync(Function(x) x.Code = code.ToUpper())
        If inventory Is Nothing Then
            MessageBox.Show("Item not found!")
            Return
        End If

        Dim existingItem = inventoryItems.FirstOrDefault(Function(i) i.Code = code.ToUpper())
        If existingItem IsNot Nothing Then
            existingItem.Quantity += 1
            existingItem.Price = inventory.SellingPrice * existingItem.Quantity
            dgv.Refresh() ' Refresh to see updated quantity/price
        Else
            inventoryItems.Add(New SaleItemGrid With {
                .Code = inventory.Code,
                .Description = inventory.ProductName,
                .Quantity = 1,
                .Price = inventory.SellingPrice
            })
        End If

        ' Clear search box
        tSearch.Clear()

        ' Update total
        ltotal.Text = inventoryItems.Sum(Function(i) i.Price).ToString("C2")

        ' Select latest row
        Dim lastRowIndex As Integer = dgv.Rows.Count - 1
        If lastRowIndex >= 0 Then
            dgv.ClearSelection()
            dgv.Rows(lastRowIndex).Selected = True
            dgv.FirstDisplayedScrollingRowIndex = lastRowIndex
        End If
    End Sub


    Private Sub tSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                HandleAddInventory(tSearch.Text)
            Catch ex As Exception
                MsgBox("Inventory not found.", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = dgv.Rows(e.RowIndex)
            Dim code = selectedRow.Cells("Code").Value.ToString()
            Dim qty = CInt(selectedRow.Cells("Quantity").Value)

            ' Open edit form
            Dim editForm As New EditQuantity(code, qty)
            If editForm.ShowDialog() = DialogResult.OK Then
                ' Update quantity in BindingList
                Dim item = inventoryItems.FirstOrDefault(Function(i) i.Code = code)
                If item IsNot Nothing Then
                    item.Quantity = editForm.NewQuantity

                    ' Get price from DB again (optional)
                    Dim price = _context.Inventories.FirstOrDefault(Function(x) x.Code = code)?.SellingPrice
                    If price.HasValue Then
                        item.Price = price.Value * item.Quantity
                    End If

                    dgv.Refresh()
                    ltotal.Text = "Total: " & inventoryItems.Sum(Function(i) i.Price).ToString("C2")
                End If
            End If
        End If
    End Sub

    Private Sub btnManualAdd_Click(sender As Object, e As EventArgs) Handles btnManualAdd.Click
        Dim picker As New ManualSalesAdd
        If picker.ShowDialog = DialogResult.OK AndAlso picker.SelectedInventory IsNot Nothing Then
            Dim inv = picker.SelectedInventory

            Dim existingItem = inventoryItems.FirstOrDefault(Function(i) i.Code = inv.Code)
            If existingItem IsNot Nothing Then
                existingItem.Quantity += 1
                existingItem.Price = inv.SellingPrice * existingItem.Quantity
            Else
                inventoryItems.Add(New SaleItemGrid With {
                    .Code = inv.Code,
                    .Description = inv.ProductName,
                    .Quantity = 1,
                    .Price = inv.SellingPrice
                })
            End If

            dgv.Refresh()
            ltotal.Text = "Total: " & inventoryItems.Sum(Function(i) i.Price).ToString("C2")
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        pnlCheckout.Visible = Not pnlCheckout.Visible
        btnConfirmCheckout.Visible = Not btnConfirmCheckout.Visible
    End Sub

    Private Async Sub btnConfirmCheckout_Click(sender As Object, e As EventArgs) Handles btnConfirmCheckout.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(tFirstName.Text) OrElse String.IsNullOrWhiteSpace(tLastName.Text) Then
            MessageBox.Show("Please enter customer name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalAmount As Decimal = CalculateTotal()
        Dim cashGiven As Decimal

        If Not Decimal.TryParse(tCash.Text, cashGiven) Then
            MessageBox.Show("Invalid cash amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cashGiven < totalAmount Then
            MessageBox.Show("Cash given is less than total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save sale to database
        Await SaveSaleAsync(lReferenceNo.Text,
                        totalAmount,
                        cashGiven,
                        tLastName.Text.Trim(),
                        tFirstName.Text.Trim(),
                        tMiddleName.Text.Trim(),
                        inventoryItems.ToList())

        MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Open change form
        Dim changeForm As New FormChange(totalAmount, cashGiven)
        If changeForm.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Change given: " & (cashGiven - totalAmount).ToString("C2"), "Change", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset form only after confirming change given
            ResetSaleForm()
        End If
    End Sub


    Private Async Function SaveSaleAsync(referenceNo As String, totalSales As Decimal, cashGiven As Decimal,
                                     lastName As String, firstName As String, middleName As String,
                                     items As List(Of SaleItemGrid)) As Task
        Using ctx As New DataContext()
            ' Create sale record
            Dim sale As New Sale() With {
                .ReferenceNumber = referenceNo,
                .TotalSales = totalSales,
                .CashGiven = cashGiven,
                .LastName = lastName,
                .FirstName = firstName,
                .MiddleName = middleName
            }

            ctx.Sales.Add(sale)
            Await ctx.SaveChangesAsync()

            ' Add sale items and update inventory stock
            For Each item In items
                ' Get inventory ID
                Dim invEntity = Await ctx.InventoryInputs.FirstOrDefaultAsync(Function(x) x.Code = item.Code)
                If invEntity Is Nothing Then Continue For

                ctx.SaleItems.Add(New SaleItem() With {
                    .SaleId = sale.Id,
                    .InventoryId = invEntity.Id,
                    .Quantity = item.Quantity,
                    .Price = item.Price
                })

                ' Deduct stock
                invEntity.CurrentStock -= item.Quantity
            Next

            Await ctx.SaveChangesAsync()
        End Using
    End Function

    Private Sub ResetSaleForm()
        ' Clear DataGridView
        dgv.DataSource = Nothing
        dgv.Rows.Clear()

        ' Reset textboxes
        tLastName.Clear()
        tFirstName.Clear()
        tMiddleName.Clear()
        tCash.Clear()

        ' Reset totals
        ltotal.Text = "0.00"
        lReferenceNo.Text = Guid.NewGuid().ToString() ' or your 5-digit code generator

        ' Hide checkout group if visible
        pnlCheckout.Visible = False
        btnConfirmCheckout.Visible = False
    End Sub



End Class

Public Class SaleItemGrid
    Public Property Id As Integer
    Public Property Code As String
    Public Property Description As String
    Public Property Quantity As Integer = 1
    Public Property Price As Decimal
End Class
