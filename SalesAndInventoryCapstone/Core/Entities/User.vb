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
    Public Property SecurityQuestions As ICollection(Of SecurityQuestion)

    Public Sub AddSecurityQuestion(question As String, answer As String)
        If Me.SecurityQuestions Is Nothing Then
            Me.SecurityQuestions = New List(Of SecurityQuestion)
        End If

        Me.SecurityQuestions.Add(
            New SecurityQuestion With {
            .UserId = Id,
            .SecurityQuestion = question,
            .SecurityAnswer = answer
            })
    End Sub

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
