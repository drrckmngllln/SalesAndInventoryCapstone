Public Class Products
    Dim products As New DataSet
    Dim db As New DBHelper()

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
    Async Function GetProducts(Optional search As String = "") As Task
        Dim sql As String = ""

        If search.Length > 2 Then
            sql = $"
                SELECT 
                    a.Id,
                    a.ProductName,
                    b.`Name` as `Category`,
                    b.`Id` as `CategoryId`,
                    a.InStock,
                    a.BuyingPrice,
                    a.SellingPrice
                FROM products AS a
                    LEFT JOIN `categories` AS `b` ON a.CategoryId = b.Id
                WHERE a.ProductName LIKE '%{search}%' OR b.Name LIKE '%{search}%'"
        Else
            sql = "
                SELECT 
                    a.Id,
                    a.ProductName,
                    b.`Name` as `Category`,
                    b.`Id` as `CategoryId`,
                    a.InStock,
                    a.BuyingPrice,
                    a.SellingPrice
                FROM products AS a
                    LEFT JOIN `categories` AS `b` ON a.CategoryId = b.Id"
        End If

        products = Await db.Fetch(sql)

        For Each row As DataRow In products.Tables(0).Rows
            Dim card As New ProductCard()
            card.data = row
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