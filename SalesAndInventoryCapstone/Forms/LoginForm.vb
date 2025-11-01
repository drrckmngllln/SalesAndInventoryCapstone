Imports Krypton.Toolkit
Imports Microsoft.EntityFrameworkCore
Imports MySql.Data.MySqlClient

Public Class LoginForm


    Dim lockoutSeconds As Integer = 30

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Async Sub Login()
        Dim username As String = tUsername.Text
        Dim password As String = tPassword.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("Please fill in all fields.")
            Return
        End If

        Using context As New DataContext()
            Dim user = Await context.Users _
            .AsNoTracking() _
            .FirstOrDefaultAsync(Function(u) u.Username = username)

            If user Is Nothing OrElse Not user.Username.Equals(username, StringComparison.Ordinal) Then
                MsgBox("Username not found")
                Return
            End If


            If user Is Nothing Then
                MsgBox("Username not found.")
                Return
            End If

            ' Handle lockout
            If user.IsLockedOut Then
                Dim remaining = user.LastLockedOut.Value.AddSeconds(lockoutSeconds) - DateTime.Now
                Dim secondsLeft = CInt(Math.Max(remaining.TotalSeconds, 0))

                If secondsLeft > 0 Then
                    MsgBox($"Your account is locked for {secondsLeft} more seconds.")
                    Return
                Else
                    user.ResetFailedAttempts()
                    Await context.SaveChangesAsync()
                End If
            End If

            ' Password check
            Dim result As Boolean = BCrypt.Net.BCrypt.Verify(password, user.Password)

            If Not result Then
                user.AddFailedAttempt()
                Await context.SaveChangesAsync()

                MsgBox($"Invalid Password. Invalid Attempts: {user.FailedAttempt}")

                If user.FailedAttempt >= 5 Then
                    user.LockOut()
                    Await context.SaveChangesAsync()
                    MsgBox("Your account has been locked due to multiple failed login attempts.")
                    StartLockout()
                    Return
                End If
            Else
                user.ResetFailedAttempts()
                Await context.SaveChangesAsync()
                MsgBox("Access Granted")

                If (user.Role = "Admin") Then
                    Me.Hide()
                    MainForm.Show()
                Else
                    Dim frm As New Sales()
                    frm.Text = "Sales"
                    frm.Show()
                    Me.Hide()
                End If



            End If
        End Using
    End Sub

    Sub StartLockout()
        tUsername.Enabled = False
        tPassword.Enabled = False
        btnLogin.Enabled = False
        lblLockoutTimer.Text = $"Too many failed attempts. Please wait {lockoutSeconds} seconds."
        lblLockoutTimer.Visible = True
        lockoutTimer.Start()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'This is a function that handles the key down event for the login form
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

    'This is a function that handles the toggle of the password visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            tPassword.UseSystemPasswordChar = False
            tPassword.PasswordChar = Nothing
        Else
            tPassword.UseSystemPasswordChar = True
        End If
    End Sub

    'This is a function that handles the lockout timer tick event
    Private Sub lockoutTimer_Tick(sender As Object, e As EventArgs) Handles lockoutTimer.Tick
        lockoutSeconds -= 1
        lblLockoutTimer.Text = $"Too many failed attempts. Please wait {lockoutSeconds} seconds."

        If lockoutSeconds <= 0 Then
            lockoutTimer.Stop()
            tUsername.Enabled = True
            tPassword.Enabled = True
            btnLogin.Enabled = True
            lblLockoutTimer.Visible = False
            'failedAttempts = 0
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim frm As New frmSecurityQuestion
        frm.ShowDialog()
    End Sub
End Class