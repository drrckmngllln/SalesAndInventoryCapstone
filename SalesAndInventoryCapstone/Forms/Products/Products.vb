Imports System.Text.Json
Imports Microsoft.EntityFrameworkCore

Public Class Products
    'Dim products As New DataSet

    Private Async Sub Products_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await LoadData()
    End Sub

    'this function is called when the user clicks on the search button
    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.Text.Length > 2 Then
            Await LoadData(tSearch.Text.Trim())
        Else
            Await LoadData()
        End If
    End Sub

    Async Function LoadData(Optional search As String = "") As Task
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgv.Columns.Add("Id", "Id")
        dgv.Columns.Add("ProductName", "Product Name")
        dgv.Columns.Add("ProductDescription", "Description")
        dgv.Columns.Add("Category", "Category")

        dgv.Columns("Id").Visible = False
        dgv.Columns("ProductName").Width = 200
        dgv.Columns("ProductDescription").Width = 500
        dgv.Columns("Category").Width = 200

        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = "btnEdit"
        editButton.HeaderText = ""
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        editButton.Width = 100
        dgv.Columns.Add(editButton)

        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = "btnDelete"
        deleteButton.HeaderText = ""
        deleteButton.Text = "Delete"
        deleteButton.Width = 100
        deleteButton.UseColumnTextForButtonValue = True
        dgv.Columns.Add(deleteButton)

        Dim products = Await GetProducts(search)
        For Each product In products
            Dim rowIndex = dgv.Rows.Add(product.Id, product.ProductName, product.ProductDescription, product.Category)
        Next
    End Function

    Async Function GetProducts(Optional search As String = "") As Task(Of List(Of Product))
        Using db As New DataContext()
            Dim query = db.Products.AsNoTracking.AsQueryable()
            If Not String.IsNullOrWhiteSpace(search) Then
                query = query.Where(Function(p) p.ProductName.Contains(search) Or p.ProductDescription.Contains(search))
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