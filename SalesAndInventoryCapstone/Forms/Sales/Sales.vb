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

        Dim colOriginalPrice As New DataGridViewTextBoxColumn()
        colOriginalPrice.Name = "OriginalPrice"
        colOriginalPrice.HeaderText = "Original Price"
        colOriginalPrice.DataPropertyName = "OriginalPrice"
        colOriginalPrice.Visible = False

        Dim colSellingPrice As New DataGridViewTextBoxColumn()
        colSellingPrice.Name = "SellingPrice"
        colSellingPrice.HeaderText = "Selling Price"
        colSellingPrice.DataPropertyName = "SellingPrice"
        colSellingPrice.Visible = False

        dgv.Columns.AddRange({colCode, colDesc, colQty, colPrice, colOriginalPrice, colSellingPrice})
    End Sub



    Private Function CalculateTotal() As Decimal
        Return inventoryItems.Sum(Function(i) i.Price)
    End Function

    Private Sub UpdateTotalLabel()
        ltotal.Text = "Total: " & CalculateTotal().ToString("C2")
    End Sub


    Private Async Function HandleAddInventory(code As String) As Task
        Dim normalizedCode = code?.Trim().ToUpper()
        If String.IsNullOrWhiteSpace(normalizedCode) Then Return

        Dim inventory = Await _context.Inventories _
        .AsNoTracking() _
        .FirstOrDefaultAsync(Function(x) x.Code = normalizedCode)

        If inventory Is Nothing Then
            MessageBox.Show("Item not found!")
            Return
        End If

        If inventory.CurrentStock <= 0 Then
            MessageBox.Show("Item is out of stock!")
            Return
        End If

        Dim existingItem = inventoryItems.FirstOrDefault(Function(i) i.Code = normalizedCode)
        If existingItem IsNot Nothing Then
            ' Update existing item
            existingItem.Quantity += 1
            existingItem.Price = existingItem.SellingPrice * existingItem.Quantity
            dgv.Refresh()
        Else
            ' Add new row with OriginalPrice + SellingPrice
            inventoryItems.Add(New SaleItemGrid With {
            .Code = inventory.Code,
            .Description = inventory.ProductName,
            .Quantity = 1,
            .Price = inventory.SellingPrice,
            .OriginalPrice = inventory.OriginalPrice,
            .SellingPrice = inventory.SellingPrice
        })
        End If

        ' Clear search box
        tSearch.Clear()

        ' Update total
        UpdateTotalLabel()

        ' Select latest row
        Dim lastRowIndex As Integer = dgv.Rows.Count - 1
        If lastRowIndex >= 0 Then
            dgv.ClearSelection()
            dgv.Rows(lastRowIndex).Selected = True
            dgv.FirstDisplayedScrollingRowIndex = lastRowIndex
        End If
    End Function

    Private Async Sub tSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                Await HandleAddInventory(tSearch.Text)
            Catch ex As Exception
                MessageBox.Show("Inventory not found or error encountered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = dgv.Rows(e.RowIndex)
            Dim code = selectedRow.Cells("Code").Value.ToString()
            Dim qty = CInt(selectedRow.Cells("Quantity").Value)

            Dim editForm As New EditQuantity(code, qty)
            If editForm.ShowDialog() = DialogResult.OK Then
                Dim item = inventoryItems.FirstOrDefault(Function(i) i.Code = code)
                If item IsNot Nothing Then
                    item.Quantity = editForm.NewQuantity

                    Dim price = _context.Inventories.FirstOrDefault(Function(x) x.Code = code)?.SellingPrice
                    If price.HasValue Then
                        item.Price = price.Value * item.Quantity
                    End If

                    dgv.Refresh()
                    UpdateTotalLabel()
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
                .Price = inv.SellingPrice,
                .OriginalPrice = inv.OriginalPrice,
                .SellingPrice = inv.SellingPrice
            })
            End If

            dgv.Refresh()
            UpdateTotalLabel()
        End If
    End Sub


    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        pnlCheckout.Visible = Not pnlCheckout.Visible
        btnConfirmCheckout.Visible = Not btnConfirmCheckout.Visible
    End Sub

    Private Async Sub btnConfirmCheckout_Click(sender As Object, e As EventArgs) Handles btnConfirmCheckout.Click
        If String.IsNullOrWhiteSpace(tFirstName.Text) OrElse String.IsNullOrWhiteSpace(tLastName.Text) Then
            MessageBox.Show("Please enter customer name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If inventoryItems.Count = 0 Then
            MessageBox.Show("Cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Await ValidateStockBeforeCheckout(inventoryItems.ToList()) Then
            Return
        End If

        If MsgBox("Confirm Proceed checkout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ' Calculate total + payment validation
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

            Await SaveSaleAsync(lReferenceNo.Text, totalAmount, cashGiven,
                                tLastName.Text.Trim(),
                                tFirstName.Text.Trim(),
                                tMiddleName.Text.Trim(),
                                inventoryItems.ToList())

        End If

    End Sub


    Private Async Function SaveSaleAsync(referenceNo As String, totalSales As Decimal, cashGiven As Decimal,
                                     lastName As String, firstName As String, middleName As String,
                                     items As List(Of SaleItemGrid)) As Task
        Using ctx As New DataContext()
            Dim sale As New Sale() With {
            .CreatedAt = DateTime.UtcNow,
            .ReferenceNumber = referenceNo,
            .TotalSales = totalSales,
            .CashGiven = cashGiven,
            .LastName = lastName,
            .FirstName = firstName,
            .MiddleName = middleName,
            .OriginalPrice = 0D,
            .SellingPrice = 0D,
            .Profit = 0D
        }

            ctx.Sales.Add(sale)
            Await ctx.SaveChangesAsync()

            Dim totalOriginal As Decimal = 0D
            Dim totalSelling As Decimal = 0D
            Dim totalProfit As Decimal = 0D

            For Each item In items
                Dim invEntity = Await ctx.InventoryInputs.FirstOrDefaultAsync(Function(x) x.Code = item.Code)
                If invEntity Is Nothing Then Continue For

                Dim lineOriginal As Decimal = item.OriginalPrice * item.Quantity
                Dim lineSelling As Decimal = item.SellingPrice * item.Quantity
                Dim lineProfit As Decimal = lineSelling - lineOriginal

                ctx.SaleItems.Add(New SaleItem() With {
                .SaleId = sale.Id,
                .InventoryId = invEntity.Id,
                .Quantity = item.Quantity,
                .Price = item.Price,
                .OriginalPrice = lineOriginal,
                .SellingPrice = lineSelling,
                .Profit = lineProfit
            })

                invEntity.CurrentStock -= item.Quantity

                totalOriginal += lineOriginal
                totalSelling += lineSelling
                totalProfit += lineProfit
            Next

            sale.OriginalPrice = totalOriginal
            sale.SellingPrice = totalSelling
            sale.Profit = totalProfit

            Dim result = Await ctx.SaveChangesAsync() > 0

            If result Then
                Dim frm As New FormChange(totalSales, cashGiven, referenceNo)
                frm.ShowDialog()
            End If

        End Using
    End Function

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Logout()
    End Sub

    Private Sub tCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCash.KeyPress
        Dim textBox = DirectCast(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            Return
        ElseIf Char.IsDigit(e.KeyChar) Then
            Return
        ElseIf e.KeyChar = "."c Then
            If textBox.Text.Contains(".") Then
                e.Handled = True
            End If
            Return
        Else
            e.Handled = True
        End If
    End Sub

    Private Async Function ValidateStockBeforeCheckout(items As List(Of SaleItemGrid)) As Task(Of Boolean)
        Using ctx As New DataContext()
            For Each item In items
                Dim inv = Await ctx.Inventories.FirstOrDefaultAsync(Function(x) x.Code = item.Code)

                If inv Is Nothing Then
                    MessageBox.Show($"Item '{item.Code}' no longer exists in inventory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If inv.CurrentStock <= 0 Then
                    MessageBox.Show($"Item '{inv.ProductName}' is OUT OF STOCK!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If

                If item.Quantity > inv.CurrentStock Then
                    MessageBox.Show($"Not enough stock for '{inv.ProductName}'. Available: {inv.CurrentStock}, Requested: {item.Quantity}", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            Next
        End Using

        Return True
    End Function

    Private Sub ResetSaleForm()
        inventoryItems.Clear()
        dgv.Refresh()

        tLastName.Clear()
        tFirstName.Clear()
        tMiddleName.Clear()
        tCash.Clear()

        UpdateTotalLabel()
        lReferenceNo.Text = Guid.NewGuid().ToString().ToUpper()

        pnlCheckout.Visible = False
        btnConfirmCheckout.Visible = False
    End Sub


End Class

Public Class SaleItemGrid
    Public Property Code As String
    Public Property Description As String
    Public Property Quantity As Integer
    Public Property Price As Decimal
    Public Property OriginalPrice As Decimal
    Public Property SellingPrice As Decimal
End Class

