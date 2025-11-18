Imports System.ComponentModel.DataAnnotations.Schema

<Table("sales")>
Public Class Sale
    <Column("Id")>
    Public Property Id As Integer
    <Column("ReferenceNumber")>
    Public Property ReferenceNumber As String
    <Column("TotalSales")>
    Public Property TotalSales As Decimal
    <Column("CashGiven")>
    Public Property CashGiven As Decimal
    <Column("LastName")>
    Public Property LastName As String
    <Column("FirstName")>
    Public Property FirstName As String
    <Column("MiddleName")>
    Public Property MiddleName As String
    <Column("CreatedAt")>
    Public Property CreatedAt As DateTime
    <Column("OriginalPrice")>
    Public Property OriginalPrice As Decimal
    <Column("SellingPrice")>
    Public Property SellingPrice As Decimal
    <Column("Profit")>
    Public Property Profit As Decimal
End Class

