Imports Microsoft.EntityFrameworkCore
Imports System.Linq

Public Class frmSecurityQuestion
    Private _currentUser As User

    Async Function GetUser(username As String) As Task(Of User)
        Using context As New DataContext()
            Dim user = Await context.Users.Include(Function(x) x.SecurityQuestions).FirstOrDefaultAsync(Function(u) u.Username = username)

            If user IsNot Nothing Then
                Return user
            End If
        End Using

        Return Nothing
    End Function

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim user = Await GetUser(tUsername.Text)

        If user Is Nothing Then
            MsgBox("Username not found.")
            pnlMain.Visible = False
            _currentUser = Nothing
            Return
        End If

        _currentUser = user
        pnlMain.Visible = True

        Dim questions = user.SecurityQuestions _
            .Select(Function(q) q.SecurityQuestion) _
            .Where(Function(q) Not String.IsNullOrWhiteSpace(q)) _
            .Distinct() _
            .ToList()

        If questions.Count = 0 AndAlso Not String.IsNullOrWhiteSpace(user.SecurityQuestion) Then
            questions.Add(user.SecurityQuestion)
        End If

        cmbSecurityQuestion.DataSource = questions
        cmbSecurityQuestion.Enabled = True

        If questions.Count > 0 Then
            cmbSecurityQuestion.SelectedIndex = 0
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim user = _currentUser
        If user Is Nothing Then
            MsgBox("Search a username first.")
            Return
        End If

        Dim selectedQuestion = If(cmbSecurityQuestion.SelectedItem, String.Empty).ToString().Trim()
        If selectedQuestion = String.Empty Then
            MsgBox("Please select a security question.")
            Return
        End If

        If String.IsNullOrWhiteSpace(tAnswer.Text) Then
            MsgBox("Please provide an answer.")
            Return
        End If

        If String.IsNullOrWhiteSpace(tNewPassword.Text) Then
            MsgBox("Please provide a new password.")
            Return
        End If

        Dim matchedQuestion = user.SecurityQuestions _
            .FirstOrDefault(Function(q) String.Equals(q.SecurityQuestion, selectedQuestion, StringComparison.OrdinalIgnoreCase))

        Dim expectedAnswer As String = Nothing
        If matchedQuestion IsNot Nothing Then
            expectedAnswer = matchedQuestion.SecurityAnswer
        ElseIf String.Equals(user.SecurityQuestion, selectedQuestion, StringComparison.OrdinalIgnoreCase) Then
            expectedAnswer = user.SecurityAnswer
        End If

        If String.IsNullOrWhiteSpace(expectedAnswer) OrElse
           Not String.Equals(expectedAnswer.Trim(), tAnswer.Text.Trim(), StringComparison.OrdinalIgnoreCase) Then
            MsgBox("Security answer is incorrect.")
            Return
        End If

        Using context As New DataContext()
            Dim userToUpdate = Await context.Users.FirstOrDefaultAsync(Function(u) u.Username = user.Username)
            If userToUpdate IsNot Nothing Then
                'Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(tNewPassword.Text)
                userToUpdate.Password = tNewPassword.Text
                Dim res = Await context.SaveChangesAsync() > 0

                If res Then
                    MsgBox("Password updated successfully.")
                    Me.Close()
                Else
                    MsgBox("Failed to update password.")
                End If
            Else
                MsgBox("Username not found.")
            End If
        End Using
    End Sub

    Private Sub frmSecurityQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
