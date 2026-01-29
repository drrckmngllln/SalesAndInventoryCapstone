Imports Microsoft.EntityFrameworkCore

Public Class LoginForm
    Dim lockoutSeconds As Integer = 30
    Dim remainingLockout As Integer = 5
    Private Const MaxFailedAttempts As Integer = 3

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Async Sub Login()
        Dim username As String = tUsername.Text.Trim()
        Dim password As String = tPassword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("Please fill in all fields.")
            Return
        End If

        Using context As New DataContext()
            Dim user = Await context.Users.FirstOrDefaultAsync(Function(u) u.Username = username)

            If user Is Nothing Then
                MsgBox("Username not found.")
                Return
            End If

            If user.IsLockedOut AndAlso user.LastLockedOut.HasValue Then
                Dim lockoutEnd = user.LastLockedOut.Value.AddSeconds(lockoutSeconds)
                If DateTime.Now >= lockoutEnd Then
                    user.IsLockedOut = False
                    user.FailedAttempt = MaxFailedAttempts
                    user.LastLockedOut = Nothing
                    Await context.SaveChangesAsync()
                End If
            End If

            If user.IsLockedOut Then
                Dim remaining = user.LastLockedOut.Value.AddSeconds(lockoutSeconds) - DateTime.Now
                Dim secondsLeft = CInt(Math.Max(remaining.TotalSeconds, 0))
                MsgBox($"Your account is locked for {secondsLeft} more seconds.")
                Return
            End If

            If user.FailedAttempt <= 0 Then
                user.FailedAttempt = MaxFailedAttempts
            End If

            Dim result As Boolean = BCrypt.Net.BCrypt.Verify(password, user.Password)
            If Not result Then

                user.FailedAttempt -= 1

                If user.FailedAttempt <= 0 Then
                    user.LockOut()
                    Await context.SaveChangesAsync()
                    MsgBox("Your account has been locked due to multiple failed login attempts.")
                    StartLockout()
                    Return
                End If

                Await context.SaveChangesAsync()

                MsgBox($"Invalid password. Remaining attempts: {user.FailedAttempt}")
                Return
            End If

            user.FailedAttempt = MaxFailedAttempts
            Await context.SaveChangesAsync()
            MsgBox("Access Granted")

            If user.Role = "Admin" Then
                Me.Hide()
                MainForm.Show()
            Else
                Dim frm As New Sales()
                frm.Text = "Sales"
                frm.Show()
                Me.Hide()
            End If
        End Using
    End Sub

    Private Sub StartLockout()
        tUsername.Enabled = False
        tPassword.Enabled = False
        btnLogin.Enabled = False
        remainingLockout = lockoutSeconds
        lblLockoutTimer.Text = $"Too many failed attempts. Please wait {remainingLockout} seconds."
        lblLockoutTimer.Visible = True
        lockoutTimer.Start()
    End Sub

    Private Async Sub lockoutTimer_Tick(sender As Object, e As EventArgs) Handles lockoutTimer.Tick
        remainingLockout -= 1
        lblLockoutTimer.Text = $"Too many failed attempts. Please wait {remainingLockout} seconds."

        If remainingLockout <= 0 Then
            lockoutTimer.Stop()
            lblLockoutTimer.Visible = False

            tUsername.Enabled = True
            tPassword.Enabled = True
            btnLogin.Enabled = True

            Dim username As String = tUsername.Text.Trim()
            If Not String.IsNullOrEmpty(username) Then
                Using context As New DataContext()
                    Dim user = Await context.Users.FirstOrDefaultAsync(Function(u) u.Username = username)
                    If user IsNot Nothing Then
                        user.IsLockedOut = False
                        user.FailedAttempt = MaxFailedAttempts
                        user.LastLockedOut = Nothing
                        Await context.SaveChangesAsync()
                    End If
                End Using
            End If

            remainingLockout = lockoutSeconds
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLockoutTimer.Visible = False
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            tPassword.UseSystemPasswordChar = False
            tPassword.PasswordChar = Nothing
        Else
            tPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim frm As New frmSecurityQuestion
        frm.ShowDialog()
    End Sub
End Class
