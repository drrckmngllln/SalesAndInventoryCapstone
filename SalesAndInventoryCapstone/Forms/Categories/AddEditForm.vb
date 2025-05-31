Public Class CategoryAEForm
    Public categoryRow As DataRow
    Dim db As New DBHelper()

    Sub OnSubmit(isCreate As Boolean)
        If String.IsNullOrEmpty(tName.Text) Then
            MsgBox("Error, required fields is missing")
            Return
        End If

        If isCreate Then
            Dim data As New Dictionary(Of String, Object) From {
                {"Name", tName.Text.Trim()}
            }
            Dim result = db.Create("categories", data)

            If result Then
                MsgBox("Category created successfully!")
            Else
                MsgBox("Error creating category, please try again.")
                Return
            End If
            Me.Close()
        Else
            Dim data As New Dictionary(Of String, Object) From {
                {"Name", tName.Text.Trim()}
            }
            db.Update("categories", data, "id = " & categoryRow("id").ToString())
            MsgBox("Category updated successfully!")
            Me.Close()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        OnSubmit(categoryRow Is Nothing)
    End Sub

    Private Sub CategoryAEForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If categoryRow Is Nothing Then
            Me.Text = "New Category"
        Else
            Me.Text = "Edit Category"
            tName.Text = categoryRow("name").ToString()
        End If
    End Sub

    Private Sub CategoryAEForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            OnSubmit(categoryRow Is Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class