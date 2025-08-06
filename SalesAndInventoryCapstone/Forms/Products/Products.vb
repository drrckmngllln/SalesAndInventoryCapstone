Public Class Products
    Dim products As New DataSet

    Private Async Sub Products_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await GetProducts()
    End Sub

    'this function is called when the user clicks on the search button
    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.Text.Length > 2 Then
            pnlData.Controls.Clear()
            Await GetProducts(tSearch.Text.Trim())
        ElseIf tSearch.Text.Length <= 0 Then
            pnlData.Controls.Clear()
            Await GetProducts()
        End If
    End Sub

    'this function fetches the products from the database and displays them in the panel
    Async Function GetProducts(Optional search As String = Nothing) As Task
        Dim products = Await ProductDbHelper.GetProducts(search)

        For Each data As Product In products
            Dim card As New ProductCard()
            card.data = data
            pnlData.Controls.Add(card)
        Next
    End Function

    'this function is called when the user clicks on the new button
    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New ProductAddEditForm
        frm.ShowDialog(Me)
        pnlData.Controls.Clear()
        Await GetProducts()
    End Sub
End Class