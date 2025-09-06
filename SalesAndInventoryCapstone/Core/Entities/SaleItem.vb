Imports System.ComponentModel.DataAnnotations.Schema

<Table("saleitem")>
Public Class SaleItem
    <Column("Id")>
    Public Property Id As Integer
    <Column("SalesId")>
    Public Property SaleId As Integer
    <Column("InventoryId")>
    Public Property InventoryId As Integer
    <Column("Quantity")>
    Public Property Quantity As Integer
    <Column("Price")>
    Public Property Price As Decimal
    <Column("OriginalPrice")>
    Public Property OriginalPrice As Decimal
    <Column("SellingPrice")>
    Public Property SellingPrice As Decimal
    <Column("Profit")>
    Public Property Profit As Decimal
End Class
