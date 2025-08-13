Imports Microsoft.EntityFrameworkCore

Public Class ManualSalesAdd
    Public Property SelectedInventory As Inventory

    Private _context As New DataContext()
    Private _inventoryList As List(Of Inventory) ' store all inventory in memory

    Private Async Sub ManualSalesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadInventory()
    End Sub

    Private Async Function LoadInventory() As Task
        _inventoryList = Await _context.Inventories.ToListAsync()
        BindGrid(_inventoryList)
    End Function

    Private Sub BindGrid(data As List(Of Inventory))
        dgv.DataSource = Nothing
        dgv.DataSource = data
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Hide unwanted columns
        dgv.Columns("Id").Visible = False
        dgv.Columns("CategoryName").Visible = False
        dgv.Columns("ProductId").Visible = False
        dgv.Columns("OriginalPrice").Visible = False
        dgv.Columns("Remarks").Visible = False
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.RowIndex >= 0 Then
            SelectedInventory = CType(dgv.Rows(e.RowIndex).DataBoundItem, Inventory)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Dim keyword = tSearch.Text.Trim().ToLower()
        If String.IsNullOrEmpty(keyword) Then
            BindGrid(_inventoryList) ' show all
        Else
            Dim filtered = _inventoryList.Where(Function(i) i.ProductName.ToLower().Contains(keyword) OrElse
                                                 i.Code.ToLower().Contains(keyword)).ToList()
            BindGrid(filtered)
        End If
    End Sub
End Class
