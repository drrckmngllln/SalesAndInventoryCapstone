Imports System.ComponentModel.DataAnnotations.Schema

<Table("inventoriesview")>
Public Class Inventory
    <Column("Id")>
    Public Property Id As Integer
    <Column("Code")>
    Public Property Code As String
    <Column("ProductId")>
    Public Property ProductId As Integer
    <Column("ProductName")>
    Public Property ProductName As String
    <Column("ProductDescription")>
    Public Property ProductDescription As String
    <Column("CategoryName")>
    Public Property CategoryName As String
    <Column("CurrentStock")>
    Public Property CurrentStock As Integer
    <Column("OriginalPrice")>
    Public Property OriginalPrice As Decimal
    <Column("SellingPrice")>
    Public Property SellingPrice As Decimal
    <Column("Remarks")>
    Public Property Remarks As String
End Class

<Table("inventories")>
Public Class InventoryInput
    <Column("Id")>
    Public Property Id As Integer
    <Column("Code")>
    Public Property Code As String
    <Column("ProductId")>
    Public Property ProductId As Integer
    <Column("CurrentStock")>
    Public Property CurrentStock As Integer
    <Column("OriginalPrice")>
    Public Property OriginalPrice As Decimal
    <Column("SellingPrice")>
    Public Property SellingPrice As Decimal
    <Column("Remarks")>
    Public Property Remarks As String
End Class