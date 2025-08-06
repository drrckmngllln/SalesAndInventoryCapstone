Public Class Product
    Public Property Id As Integer
    Public Property ProductName As String
    Public Property ProductDescription As String
    Public Property CategoryId As Integer
    Public Property Category As String
End Class

Public Class ProductInput
    Public Property Id As Integer
    Public Property CreatedAt As DateTime = DateTime.UtcNow
    Public Property ProductName As String
    Public Property ProductDescription As String
    Public Property CategoryId As Integer
End Class