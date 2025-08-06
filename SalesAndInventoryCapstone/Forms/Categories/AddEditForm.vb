Public Class CategoryAEForm
    Public category As New Category()
    Dim db As New DBHelper()

    Async Function OnSubmit(isCreate As Boolean) As Task
        If String.IsNullOrEmpty(tName.Text) Then
            MsgBox("Error, required fields is missing")
            Return
        End If

        If isCreate Then
            Dim data As New Category() With {
                .Name = tName.Text.Trim()
            }

            Dim result = Await CategoryDbHelper.AddCategory(data)

            If result Then
                MsgBox("Category created successfully!")
            Else
                MsgBox("Error creating category, please try again.")
                Return
            End If
            Me.Close()
        Else
            Dim data As New Category() With {
                .Id = category.Id,
                .Name = tName.Text.Trim()
            }
            Dim result = Await CategoryDbHelper.UpdateCategory(data)
            If result Then
                MsgBox("Category updated successfully!")
            Else
                MsgBox("Error updating category, please try again.")
                Return
            End If
            Me.Close()
        End If
    End Function

    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Await OnSubmit(category IsNot Nothing)
    End Sub

    Private Sub CategoryAEForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If category IsNot Nothing Then
            Me.Text = "New Category"
        Else
            Me.Text = "Edit Category"
            tName.Text = category.Name
        End If
    End Sub

    Private Async Sub CategoryAEForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Await OnSubmit(category IsNot Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class