Imports System.ComponentModel.DataAnnotations.Schema

<Table("productsview")>
Public Class Product
    <Column("Id")>
    Public Property Id As Integer
    <Column("ProductName")>
    Public Property ProductName As String
    <Column("ProductDescription")>
    Public Property ProductDescription As String
    <Column("CategoryId")>
    Public Property CategoryId As Integer
    <Column("Category")>
    Public Property Category As String
End Class

Public Class ProductInput
    Public Property Id As Integer
    Public Property CreatedAt As DateTime = DateTime.UtcNow
    Public Property ProductName As String
    Public Property ProductDescription As String
    Public Property CategoryId As Integer
End Class