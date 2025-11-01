Imports Microsoft.EntityFrameworkCore

Public Class Inventories
    Private Async Sub Inventories_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await LoadAsync()
    End Sub

    Async Function LoadAsync(Optional search As String = Nothing) As Task
        Using context As New DataContext()
            Dim inventories = context.Inventories.AsQueryable()

            If (Not String.IsNullOrEmpty(search)) Then
                inventories = inventories.Where(
                    Function(i) i.ProductName.Contains(search) OrElse
                                i.Code.Contains(search) OrElse
                                i.ProductDescription.Contains(search) OrElse
                                i.CategoryName.Contains(search)
                )
            End If
            Dim inventoriesList = Await inventories.ToListAsync()

            dgv.Rows.Clear()
            dgv.Columns.Clear()

            dgv.Columns.Add("Id", "Id")
            dgv.Columns.Add("Code", "Code")
            dgv.Columns.Add("ProductName", "Product Name")
            dgv.Columns.Add("ProductDescription", "Product Description")
            dgv.Columns.Add("CategoryName", "Category Name")
            dgv.Columns.Add("CurrentStock", "Current Stock")
            dgv.Columns.Add("StockIn", "Stock In")
            dgv.Columns.Add("StockOut", "Stock Out")
            dgv.Columns.Add("OriginalPrice", "Original Price")
            dgv.Columns.Add("SellingPrice", "Selling Price")
            dgv.Columns.Add("Remarks", "Remarks")

            dgv.Columns("Id").Visible = False

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

            For Each inventory In inventoriesList
                dgv.Rows.Add(
                    inventory.Id,
                    inventory.Code,
                    inventory.ProductName,
                    inventory.ProductDescription,
                    inventory.CategoryName,
                    inventory.CurrentStock,
                    inventory.StockIn,
                    inventory.StockOut,
                    inventory.OriginalPrice,
                    inventory.SellingPrice,
                    inventory.Remarks
                )
            Next
        End Using
    End Function

    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New InventoryAddEditForm()
        frm.Text = "Add Inventory"
        frm.ShowDialog(Me)
        Await LoadAsync()
    End Sub

    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.TextLength > 2 Then
            Await LoadAsync(tSearch.Text)
        Else
            Await LoadAsync()
        End If
    End Sub

    Private Async Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex < 0 Then Return ' Ignore header clicks

        Dim id As String = dgv.Rows(e.RowIndex).Cells("Id").Value.ToString()
        Dim product As String = dgv.Rows(e.RowIndex).Cells("ProductName").Value.ToString()

        If dgv.Columns(e.ColumnIndex).Name = "btnEdit" Then
            ' === Handle Edit ===
            Dim frm As New InventoryAddEditForm()
            frm.inventoryId = id
            frm.Text = "Edit User"
            frm.ShowDialog(Me)
            Await LoadAsync()

        ElseIf dgv.Columns(e.ColumnIndex).Name = "btnDelete" Then
            ' === Handle Delete ===
            Dim confirm = MessageBox.Show($"Are you sure you want to delete {product}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                'Await DeleteProduct(id)
            End If
        End If
    End Sub
End Class