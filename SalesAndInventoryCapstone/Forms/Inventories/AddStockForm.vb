Public Class AddStockForm
    Public productId As String

    Async Function GetStock() As Task(Of Inventory)
        Dim sql As String = $"SELECT * FROM inventoriesview WHERE Id={productId}"
        Dim result = Await DBHelper.Fetch(sql)
        If result.Tables.Count > 0 AndAlso result.Tables(0).Rows.Count > 0 Then
            Dim row = result.Tables(0).Rows(0)
            Return New Inventory With {
                .Id = productId,
                .Code = row("Code").ToString(),
                .ProductName = row("ProductName").ToString(),
                .ProductDescription = row("ProductDescription").ToString(),
                .CurrentStock = Convert.ToInt32(row("CurrentStock")),
                .CategoryName = row("CategoryName").ToString(),
                .OriginalPrice = Convert.ToDecimal(row("OriginalPrice")),
                .SellingPrice = Convert.ToDecimal(row("SellingPrice")),
                .Remarks = row("Remarks").ToString()
            }
        End If

        Return Nothing
    End Function

    Async Function HandleAddStock() As Task
        If Not IsNumeric(tStock.Text) Then
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim stock = Await GetStock()


        If String.IsNullOrEmpty(productId) OrElse stock.CurrentStock <= 0 Then
            MessageBox.Show("Please enter a valid product ID and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim success = Await InventoryDbHelper.AddCurrentStock(productId, CInt(tStock.Text))

        If success Then
            MessageBox.Show("Stock added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Failed to add stock. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Async Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Await HandleAddStock()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Async Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stock = Await GetStock()
        lProductName.Text = stock.ProductName
    End Sub

    Private Async Sub AddStockForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Await HandleAddStock()
        ElseIf (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class

Public Class StockDto
    Public Property Id As String
    Public Property ProductName As String
    Public Property CurrentStock As Integer
End Class