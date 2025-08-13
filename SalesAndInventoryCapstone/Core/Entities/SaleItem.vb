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
End Class
