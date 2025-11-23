Imports System.Text.Json
Imports Microsoft.EntityFrameworkCore

Public Class Products
    'Dim products As New DataSet

    Private Async Sub Products_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await LoadData()
    End Sub

    'this function is called when the user clicks on the search button
    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.Text.Length > 0 Then
            Await LoadData(tSearch.Text.Trim())
        Else
            Await LoadData()
        End If
    End Sub

    Async Function LoadData(Optional search As String = "") As Task
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgv.RowTemplate.Height = 30

        dgv.Columns.Add("Id", "Id")
        dgv.Columns("Id").Visible = False

        dgv.Columns.Add("ProductName", "Product Name")
        dgv.Columns("ProductName").Width = 200

        dgv.Columns.Add("ProductDescription", "Description")
        dgv.Columns("ProductDescription").Width = 300

        dgv.Columns.Add("Category", "Category")
        dgv.Columns("Category").Width = 150

        dgv.Columns.Add("OriginalPrice", "Original Price")
        dgv.Columns("OriginalPrice").Width = 120

        dgv.Columns.Add("SellingPrice", "Selling Price")
        dgv.Columns("SellingPrice").Width = 120

        ' Add Edit button column
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = "btnEdit"
        editButton.HeaderText = ""
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        editButton.Width = 80
        dgv.Columns.Add(editButton)

        ' Add Delete button column
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = "btnDelete"
        deleteButton.HeaderText = ""
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        deleteButton.Width = 80
        dgv.Columns.Add(deleteButton)

        ' Make columns not resizable by user (optional)
        For Each col As DataGridViewColumn In dgv.Columns
            col.Resizable = DataGridViewTriState.False
        Next



        Dim products = Await GetProducts(search)
        For Each product In products
            Dim originalPriceText As String
            If product.OriginalPrice Is Nothing OrElse
               String.IsNullOrEmpty(product.OriginalPrice.ToString()) OrElse
               Val(product.OriginalPrice) = 0 Then

                originalPriceText = "Price Not Set"
            Else
                Dim priceValue As Decimal
                If Decimal.TryParse(product.OriginalPrice.ToString(), priceValue) Then
                    originalPriceText = priceValue.ToString("C2")
                Else
                    originalPriceText = product.OriginalPrice.ToString()
                End If
            End If

            Dim sellingPriceText As String
            If product.SellingPrice Is Nothing OrElse
               String.IsNullOrEmpty(product.SellingPrice.ToString()) OrElse
               Val(product.SellingPrice) = 0 Then

                sellingPriceText = "Price Not Set"
            Else
                Dim sellValue As Decimal
                If Decimal.TryParse(product.SellingPrice.ToString(), sellValue) Then
                    sellingPriceText = sellValue.ToString("C2")
                Else
                    sellingPriceText = product.SellingPrice.ToString()
                End If
            End If

            ' --- Add row ---
            dgv.Rows.Add(
                product.Id,
                product.ProductName,
                product.ProductDescription,
                product.Category,
                originalPriceText,
                sellingPriceText
            )
        Next

    End Function

    Async Function GetProducts(Optional search As String = "") As Task(Of List(Of Product))
        Using db As New DataContext()
            Dim query = db.Products.AsNoTracking.AsQueryable()
            If Not String.IsNullOrWhiteSpace(search) Then
                query = query.Where(Function(p) p.ProductName.StartsWith(search) Or p.ProductDescription.StartsWith(search))
            End If
            Return Await query.ToListAsync()
        End Using
    End Function

    Async Function DeleteProduct(id As String) As Task
        Using db As New DataContext()
            Dim product = Await db.ProductInputs.FirstOrDefaultAsync(Function(p) p.Id = id)
            If product IsNot Nothing Then
                db.ProductInputs.Remove(product)
                Dim res = Await db.SaveChangesAsync() > 0
                If res = False Then
                    MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Await LoadData()
            Else
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Function

    'this function is called when the user clicks on the new button
    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New ProductAddEditForm
        frm.ShowDialog(Me)
        Await LoadData()
    End Sub

    Private Async Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex < 0 Then Return ' Ignore header clicks

        Dim id As String = dgv.Rows(e.RowIndex).Cells("Id").Value.ToString()
        Dim product As String = dgv.Rows(e.RowIndex).Cells("ProductName").Value.ToString()

        If dgv.Columns(e.ColumnIndex).Name = "btnEdit" Then
            ' === Handle Edit ===
            Dim frm As New ProductAddEditForm()
            frm.productId = id
            frm.Text = "Edit User"
            frm.ShowDialog(Me)
            Await LoadData()

        ElseIf dgv.Columns(e.ColumnIndex).Name = "btnDelete" Then
            ' === Handle Delete ===
            Dim confirm = MessageBox.Show($"Are you sure you want to delete {product}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                Await DeleteProduct(id)
            End If
        End If
    End Sub
End Class