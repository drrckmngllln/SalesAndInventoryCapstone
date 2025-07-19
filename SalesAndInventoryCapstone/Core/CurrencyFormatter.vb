Public Class CurrencyFormatter
    Public Shared Function FormatAsPeso(ByVal amount As Decimal) As String
        Dim culture As New Globalization.CultureInfo("en-PH")
        Return String.Format(culture, "{0:C}", amount)
    End Function
End Class