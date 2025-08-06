Public Class ProductSelector
    Public Property SelectedProduct As Product

    Private Async Sub ProductSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadProductsAsync()
    End Sub

    Async Function LoadProductsAsync(Optional search As String = Nothing) As Task
        Dim products = Await ProductDbHelper.GetProducts(search)
        dgv.DataSource = products
        dgv.Columns("Id").Visible = False
        dgv.Columns("ProductName").HeaderText = "Name"
        dgv.Columns("ProductDescription").HeaderText = "Description"
        dgv.Columns("Category").HeaderText = "Category"
        dgv.Columns("CategoryId").Visible = False
    End Function

    Private Sub dgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentDoubleClick
        SelectedProduct = CType(dgv.Rows(e.RowIndex).DataBoundItem, Product)
        Me.DialogResult = DialogResult.OK ' Triggers return in calling form
        Me.Close()
    End Sub

    Private Async Sub tCode_TextChanged(sender As Object, e As EventArgs) Handles tCode.TextChanged
        If (tCode.Text.Length < 3) Then
            Await LoadProductsAsync(tCode.Text)
        Else
            Await LoadProductsAsync()
        End If
    End Sub
End Class
