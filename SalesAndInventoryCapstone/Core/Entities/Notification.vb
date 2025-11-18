Imports System.ComponentModel.DataAnnotations.Schema

<Table("notifications")>
Public Class Notification
    Public Property Id As Integer
    Public Property InventoryId As Integer
    Public Property Message As String
    Public Property IsRead As Boolean
    Public Property CreatedAt As DateTime
End Class
