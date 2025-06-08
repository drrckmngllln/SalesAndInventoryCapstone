Public Class AddEditForm
    Public data As DataRow
    Dim db As New DBHelper()

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

            Dim newData As New Dictionary(Of String, Object) From {
                {"LastName", tLastName.Text.Trim()},
                {"FirstName", tFirstName.Text.Trim()},
                {"Username", tUsername.Text.Trim()},
                {"Password", tPassword.Text.Trim()}
            }
            Dim result = Await db.CreateAsync("users", newData)
            If result Then
                MsgBox("User created successfully!")
                Me.Close()
            Else
                MsgBox("Error creating user, please try again.")
                Return
            End If
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

            Dim updatedData As New Dictionary(Of String, Object) From {
                {"LastName", tLastName.Text.Trim()},
                {"FirstName", tFirstName.Text.Trim()},
                {"Username", tUsername.Text.Trim()}
            }
            If Not String.IsNullOrEmpty(tPassword.Text.Trim()) Then
                updatedData("Password") = tPassword.Text.Trim()
            End If
            Await db.UpdateAsync("users", updatedData, "id = " & data("id").ToString())
            MsgBox("User updated successfully!")
            Me.Close()
        End If

    End Sub

    Private Sub AddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If data IsNot Nothing Then
            tLastName.Text = data("LastName").ToString()
            tFirstName.Text = data("FirstName").ToString()
            tUsername.Text = data("Username").ToString()
            lblPassword.Visible = False
            chkShowPassword.Visible = False
            tPassword.Visible = False
        End If
    End Sub

    Private Sub AddEditForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Enter Then
            OnSubmit(data Is Nothing)
        ElseIf e.KeyValue = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        OnSubmit(data Is Nothing)
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            tPassword.UseSystemPasswordChar = False
            tPassword.PasswordChar = Nothing
        Else
            tPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class