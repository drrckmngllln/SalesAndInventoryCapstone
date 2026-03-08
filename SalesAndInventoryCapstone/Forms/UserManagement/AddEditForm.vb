Imports System.ComponentModel
Imports Microsoft.EntityFrameworkCore

Public Class AddEditForm
    Public id As Integer?
    Dim db As New DBHelper()

    Private ReadOnly securityQuestions As Dictionary(Of String, String) = Items

    Async Sub OnSubmit(isCreate As Boolean)
        If isCreate Then
            Dim textBoxes As New List(Of Krypton.Toolkit.KryptonTextBox) From {tLastName, tFirstName, tUsername, tPassword}

            For Each tb As Krypton.Toolkit.KryptonTextBox In textBoxes
                If String.IsNullOrEmpty(tb.Text.Trim()) Then
                    MsgBox("Error, required fields are missing")
                    Return
                End If
            Next

            If MsgBox("Are you sure you want to create this user?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Return
            End If

            Using context As New DataContext()
                Dim user = Await context.Users _
                .AnyAsync(Function(u) u.Username = tUsername.Text.Trim() _
                    Or (u.LastName = tLastName.Text _
                    AndAlso u.FirstName = tFirstName.Text))
                If user Then
                    MsgBox("Error, user already exists")
                    Return
                End If

                Dim newUser As New User With {
                    .LastName = tLastName.Text.Trim(),
                    .FirstName = tFirstName.Text.Trim(),
                    .Username = tUsername.Text.Trim(),
                    .Password = tPassword.Text.Trim(),
                    .Role = "User",
                    .IsEnabled = True,
                    .IsLockedOut = False,
                    .FailedAttempt = 0
                }

                For Each row As DataGridViewRow In dgv.Rows
                    If row.IsNewRow Then Continue For

                    Dim question As String = row.Cells("sq").Value?.ToString()
                    Dim answer As String = row.Cells("sa").Value?.ToString()

                    newUser.AddSecurityQuestion(question, answer)

                Next

                context.Users.Add(newUser)

                Dim result = Await context.SaveChangesAsync() > 0

                If result Then
                    MsgBox("User created successfully!")
                    Me.Close()
                Else
                    MsgBox("Error creating user, please try again.")
                    Return
                End If
            End Using
        Else
            Dim textBoxes As New List(Of Krypton.Toolkit.KryptonTextBox) From {tLastName, tFirstName, tUsername}

            For Each tb As Krypton.Toolkit.KryptonTextBox In textBoxes
                If String.IsNullOrEmpty(tb.Text.Trim()) Then
                    MsgBox("Error, required fields are missing")
                    Return
                End If
            Next

            If MsgBox("Are you sure you want to update this user?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Return
            End If

            Using context As New DataContext()
                Dim user = Await context.Users.FindAsync(id)
                If user Is Nothing Then
                    MsgBox("Error, user not found")
                    Return
                End If

                user.LastName = tLastName.Text.Trim()
                user.FirstName = tFirstName.Text.Trim()
                user.Username = tUsername.Text.Trim()
                If Not String.IsNullOrEmpty(tPassword.Text.Trim()) Then
                    user.Password = HashPassword(tPassword.Text.Trim())
                End If

                Dim result = Await context.SaveChangesAsync() > 0

                If result Then
                    MsgBox("User updated successfully!")
                    Me.Close()
                Else
                    MsgBox("Error updating user, please try again.")
                    Return
                End If
            End Using
            Me.Close()
        End If

    End Sub

    Private Async Sub AddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If id IsNot Nothing Then
            Using context As New DataContext()
                Dim user = Await context.Users.IgnoreQueryFilters().FirstOrDefaultAsync(Function(u) u.Id = id)
                If user Is Nothing Then
                    MsgBox("Error, user not found")
                    Me.Close()
                    Return
                End If

                tLastName.Text = user.LastName
                tFirstName.Text = user.FirstName
                tUsername.Text = user.Username
                lblPassword.Visible = False
                chkShowPassword.Visible = False
                tPassword.Visible = False
            End Using
        End If

        dgv.Columns.Add("sq", "Security Question")
        dgv.Columns.Add("sa", "Security Answer")
    End Sub

    Private Sub AddEditForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Enter Then
            OnSubmit(id Is Nothing)
        ElseIf e.KeyValue = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        OnSubmit(id Is Nothing)
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            tPassword.UseSystemPasswordChar = False
            tPassword.PasswordChar = Nothing
        Else
            tPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddSecurityQuestion_Click(sender As Object, e As EventArgs) Handles btnAddSecurityQuestion.Click
        Dim frm As New frmAddSecurityQuestion
        If frm.ShowDialog() = DialogResult.OK Then
            dgv.Rows.Add(frm.SelectedSecurityQuestion, frm.SecurityAnswer)
        End If
    End Sub
End Class
