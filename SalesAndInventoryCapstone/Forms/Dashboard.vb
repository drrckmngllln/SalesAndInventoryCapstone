Public Class Dashboard
    Dim db As New DBHelper()

    Private Async Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lProducts.Text = Await GetProductsCount()
        lSales.Text = Await GetSalesCount()
        lInventory.Text = Await GetInventoryCount() & " In Stock"
    End Sub


    '' 🛒 Get Products Count
    Async Function GetProductsCount() As Task(Of String)
        Dim products = Await db.Fetch("SELECT SUM(InStock * SellingPrice) AS TotalPrice FROM products")

        Dim total As Decimal = 0

        If products.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(products.Tables(0).Rows(0)("TotalPrice")) Then
            total = Convert.ToDecimal(products.Tables(0).Rows(0)("TotalPrice"))
        End If

        Return CurrencyFormatter.FormatAsPeso(total)
    End Function

    '' 💰 Get Sales Count
    Async Function GetSalesCount() As Task(Of String)
        Dim sales = Await db.Fetch("SELECT SUM(TotalSales) AS TotalSales FROM sales")
        Dim total As Decimal = 0
        If sales.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(sales.Tables(0).Rows(0)("TotalSales")) Then
            total = Convert.ToDecimal(sales.Tables(0).Rows(0)("TotalSales"))
        End If
        Return CurrencyFormatter.FormatAsPeso(total)
    End Function

    '' 📦 Get Inventory Count
    Async Function GetInventoryCount() As Task(Of String)
        Dim customers = Await db.Fetch("SELECT SUM(Quantity) AS Quantity FROM inventories")
        Dim total As Integer = 0
        If customers.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(customers.Tables(0).Rows(0)("Quantity")) Then
            total = Convert.ToInt32(customers.Tables(0).Rows(0)("Quantity"))
        End If
        Return total.ToString()
    End Function
End Class