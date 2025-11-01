Imports Microsoft.EntityFrameworkCore

Public Class frmSecurityQuestion
    Async Function GetUser(username As String) As Task(Of User)
        Using context As New DataContext()
            Dim user = Await context.Users.FirstOrDefaultAsync(Function(u) u.Username = username)

            If user IsNot Nothing Then
                Return user
            End If
        End Using
    End Function

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim user = Await GetUser(tUsername.Text)

        If user Is Nothing Then
            MsgBox("Username not found.")
            pnlMain.Visible = False
            Return
        End If

        pnlMain.Visible = True
        tSecurityQuestion.Text = user.SecurityQuestion
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim user = Await GetUser(tUsername.Text)
        If user Is Nothing Then
            MsgBox("Username not found.")
            Return
        End If

        If tAnswer.Text = String.Empty Then
            MsgBox("Please provide an answer.")
            Return
        End If

        If tNewPassword.Text = String.Empty Then
            MsgBox("Please provide a new password.")
            Return
        End If

        If user.SecurityAnswer = tAnswer.Text Then
            Using context As New DataContext()
                Dim userToUpdate = Await context.Users.FirstOrDefaultAsync(Function(u) u.Username = tUsername.Text)
                If userToUpdate IsNot Nothing Then
                    Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(tNewPassword.Text)
                    userToUpdate.Password = hashedPassword
                    Dim res = Await context.SaveChangesAsync() > 0

                    If res Then
                        MsgBox("Password updated successfully.")
                        Me.Close()
                    Else
                        MsgBox("Failed to update password.")
                    End If
                End If
            End Using
        End If
    End Sub
End Class