Imports Krypton.Toolkit
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Inherits KryptonForm

    Dim failedAttempts As Integer = 0
    Dim lockoutSeconds As Integer = 30

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'This is a function that initializes the login form by seeding roles and users if there is no data in the database
    Sub LoginInitialize()
        RoleSeeder.SeedRoles()
        UserSeeder.RoleSeeder()
    End Sub

    'This is a function that handles the login process
    Sub Login()
        Dim username As String = tUsername.Text
        Dim password As String = tPassword.Text
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Please fill in all fields.")
            Return
        End If

        da = New MySqlDataAdapter("select * from users where username='" & username & "'", con)
        ds = New DataSet
        da.Fill(ds, "users")

        If ds.Tables(0).Rows.Count <= 0 Then
            failedAttempts += 1
            MsgBox($"Username not found. Invalid Attempts: {failedAttempts}")

            If failedAttempts >= 3 Then
                StartLockout()
            End If

            'This is to prevent further execution if the username is not found
            Return
        End If

        Dim result As Boolean = BCrypt.Net.BCrypt.Verify(password, ds.Tables(0).Rows(0).Item("Password").ToString())

        If result Then
            MsgBox("Access Granted")
            Me.Hide()
            MainForm.Show()
        Else
            failedAttempts += 1
            MsgBox($"Invalid Password. Invalid Attempts: {failedAttempts}")
        End If

        If failedAttempts >= 3 Then
            StartLockout()
        End If

    End Sub

    'This is a function that starts the lockout timer and disables the login fields
    Sub StartLockout()
        tUsername.Enabled = False
        tPassword.Enabled = False
        btnLogin.Enabled = False
        lockoutSeconds = 30
        lblLockoutTimer.Text = $"Too many failed attempts. Please wait {lockoutSeconds} seconds."
        lblLockoutTimer.Visible = True
        lockoutTimer.Start()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginInitialize()
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
            failedAttempts = 0
        End If
    End Sub
End Class