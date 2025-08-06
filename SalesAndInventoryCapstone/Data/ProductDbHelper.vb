Public Class ProductDbHelper
    Public Shared Async Function GetProducts(Optional search As String = Nothing) As Task(Of List(Of Product))
        Dim sql As String = "SELECT * FROM productsview"

        If Not String.IsNullOrEmpty(search) Then
            sql &= " WHERE ProductName LIKE '%" & search.Replace("'", "''") & "%'"
        End If

        Dim productsDataSet As DataSet = Await DBHelper.Fetch(sql)
        Dim products As New List(Of Product)()
        If productsDataSet.Tables.Count > 0 Then
            For Each row As DataRow In productsDataSet.Tables(0).Rows
                Dim product As New Product With {
                    .Id = Convert.ToInt32(row("Id")),
                    .ProductName = row("ProductName").ToString(),
                    .ProductDescription = If(String.IsNullOrWhiteSpace(row("ProductDescription").ToString()), "(No Product Description)", row("ProductDescription").ToString()),
                    .Category = row("Category").ToString(),
                    .CategoryId = Convert.ToInt32(row("CategoryId"))
                }
                products.Add(product)
            Next
        End If
        Return products
    End Function

    Public Shared Async Function GetProductById(productId As Integer) As Task(Of Product)
        Dim sql As String = $"SELECT * FROM productsview WHERE Id ={productId}"
        Dim productDataSet As DataSet = Await DBHelper.Fetch(sql)

        If productDataSet.Tables.Count > 0 AndAlso productDataSet.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = productDataSet.Tables(0).Rows(0)

            Return New Product With {
                .Id = Convert.ToInt32(row("Id")),
                .ProductName = row("ProductName").ToString(),
                .ProductDescription = row("ProductDescription").ToString(),
                .Category = row("Category").ToString(),
                .CategoryId = Convert.ToInt32(row("CategoryId"))
            }
        End If

        Return Nothing
    End Function

    '' 🛒 Get Products Count
    Shared Async Function GetProductsCount() As Task(Of String)
        Dim products = Await DBHelper.Fetch("SELECT SUM(CurrentStock * SellingPrice) AS ProductTotal FROM inventories")

        Dim total As Decimal = 0

        If products.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(products.Tables(0).Rows(0)("ProductTotal")) Then
            total = Convert.ToDecimal(products.Tables(0).Rows(0)("ProductTotal"))
        End If

        Return CurrencyFormatter.FormatAsPeso(total)
    End Function


    Public Shared Async Function AddProduct(product As ProductInput) As Task(Of Boolean)
        Dim result = Await DBHelper.CreateAsync("products", product)
        Return result
    End Function

    Shared Async Function UpdateProduct(product As ProductInput) As Task(Of Boolean)
        Dim result = Await DBHelper.UpdateAsync("products", product, $"Id = {product.Id}")
        Return result
    End Function

    Shared Async Function DeleteProduct(productId As Integer) As Task(Of Boolean)
        Dim result = Await DBHelper.DeleteAsync("products", productId)
        Return result
    End Function


End Class