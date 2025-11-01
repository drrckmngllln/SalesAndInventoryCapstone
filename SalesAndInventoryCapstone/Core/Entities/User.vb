Imports System.ComponentModel.DataAnnotations.Schema

<Table("users")>
Public Class User
    Public Property Id As Integer
    Public Property LastName As String
    Public Property FirstName As String
    Public Property Username As String
    Public Property Password As String
    Public Property Role As String
    Public Property IsEnabled As Boolean
    Public Property FailedAttempt As Integer
    Public Property IsLockedOut As Integer
    Public Property LastLockedOut As DateTime?
    Public Property SecurityQuestion As String
    Public Property SecurityAnswer As String

    Public Sub AddFailedAttempt()
        Me.FailedAttempt += 1
    End Sub

    Public Sub ResetFailedAttempts()
        Me.FailedAttempt = 0
    End Sub

    Public Sub LockOut()
        Me.IsLockedOut = 1
        Me.LastLockedOut = DateTime.Now
    End Sub
End Class
