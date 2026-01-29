Imports System.ComponentModel.DataAnnotations.Schema

<Table("productsview")>
Public Class Product
    <Column("Id")>
    Public Property Id As Integer
    <Column("Code")>
    Public Property Code As String
    <Column("ProductName")>
    Public Property ProductName As String
    <Column("ProductDescription")>
    Public Property ProductDescription As String
    <Column("CategoryId")>
    Public Property CategoryId As Integer?
    <Column("Category")>
    Public Property Category As String
    <Column("OriginalPrice")>
    Public Property OriginalPrice As Decimal?
    <Column("SellingPrice")>
    Public Property SellingPrice As Decimal?
End Class

<Table("products")>
Public Class ProductInput
    Public Property Id As Integer
    Public Property CreatedAt As DateTime = DateTime.UtcNow
    Public Property ProductName As String
    Public Property ProductDescription As String
    Public Property CategoryId As Integer
End Class
