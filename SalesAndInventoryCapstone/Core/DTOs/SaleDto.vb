Imports System.ComponentModel.DataAnnotations.Schema

Public Class SaleDto
    Public Property Id As Integer
    Public Property ReferenceNumber As String
    Public Property TotalSales As Decimal
    Public Property CashGiven As Decimal
    Public Property LastName As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property CreatedAt As DateTime
    Public Property OriginalPrice As Decimal
    Public Property SellingPrice As Decimal
    Public Property Profit As Decimal
End Class
