Imports System.ComponentModel.DataAnnotations.Schema

<Table("SaleItemView")>
Public Class SaleItemView
    Public Property Id As Integer
    Public Property CreatedAt As DateTime
    Public Property ReferenceNo As String
    Public Property ProductName As String
    Public Property Category As String
    Public Property Quantity As Integer
    Public Property Price As Decimal
    Public Property OriginalPrice As Decimal
    Public Property SellingPrice As Decimal
    Public Property Profit As Decimal
End Class
