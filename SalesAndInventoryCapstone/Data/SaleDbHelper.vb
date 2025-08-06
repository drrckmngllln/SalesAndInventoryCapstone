Public Class SaleDbHelper
    '' 💰 Get Sales Count
    Shared Async Function GetSalesCount() As Task(Of String)
        Dim sales = Await DBHelper.Fetch("SELECT SUM(TotalSales) AS TotalSales FROM sales")
        Dim total As Decimal = 0
        If sales.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(sales.Tables(0).Rows(0)("TotalSales")) Then
            total = Convert.ToDecimal(sales.Tables(0).Rows(0)("TotalSales"))
        End If
        Return CurrencyFormatter.FormatAsPeso(total)
    End Function
End Class
