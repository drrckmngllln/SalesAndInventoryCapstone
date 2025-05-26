Imports Krypton.Toolkit
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Inherits KryptonForm

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
            MsgBox("Username not found.")
        End If

        Dim result As Boolean = BCrypt.Net.BCrypt.Verify(password, ds.Tables(0).Rows(0).Item("Password").ToString())

        If result Then
            MsgBox("Access Granted")
            Me.Hide()
            MainForm.Show()
        Else
            MsgBox("Invalid Password")
        End If

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
End Class