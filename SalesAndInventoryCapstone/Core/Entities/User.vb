Imports System.ComponentModel.DataAnnotations.Schema

<Table("users")>
Public Class User
    Public Property Id As Integer
    Public Property LastName As String
    Public Property FirstName As String
    Public Property Username As String
    Public Property Password As String
End Class
