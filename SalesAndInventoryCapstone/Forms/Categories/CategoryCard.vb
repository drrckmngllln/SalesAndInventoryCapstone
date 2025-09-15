Public Class CategoryCard
    Public data As Category
    Dim db As New DBHelper()

    Async Function HandleRefetch() As Task
        Dim category = Await CategoryDbHelper.GetCategoryById(data.Id)
        If category IsNot Nothing Then
            data = category
            lblDescription.Text = data.Name
        Else
            MsgBox("Category not found.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Function

    Async Sub HandleEditCategory()
        Dim frm As New CategoryAEForm()
        frm.id = data.Id
        frm.Text = "Edit Category"
        frm.ShowDialog()
        Await HandleRefetch()
    End Sub

    Async Sub HandleDeleteCategory()
        Using context As New DataContext()
            Try
                If MsgBox("Are you sure you want to delete this category?", MsgBoxStyle.YesNo, "Delete Category") = MsgBoxResult.Yes Then
                    Dim category = Await context.Categories.FindAsync(data.Id)
                    If category Is Nothing Then
                        MsgBox("Category not found.", MsgBoxStyle.Exclamation, "Error")
                        Return
                    End If

                    context.Categories.Remove(category)
                    Dim result = Await context.SaveChangesAsync() > 0

                    If Not result Then
                        MsgBox("Failed to delete category.", MsgBoxStyle.Critical, "Error")
                        Return
                    End If
                    MsgBox("Category deleted successfully!")
                    Me.Dispose()
                End If
            Catch ex As Exception
                MsgBox("Delete Operation not allowed, Current Category is being used", MsgBoxStyle.Critical, "Error")
            End Try
        End Using

    End Sub

    Private Sub CategoryCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescription.Text = data.Name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HandleEditCategory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HandleDeleteCategory()
    End Sub
End Class
