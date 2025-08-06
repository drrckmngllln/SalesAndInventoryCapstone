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
        Dim frm As New CategoryAEForm
        frm.category = data
        frm.Text = "Edit Category"
        frm.ShowDialog(Me)
        Await HandleRefetch()
    End Sub

    Async Sub HandleDeleteCategory()
        If MsgBox("Are you sure you want to delete this category?", MsgBoxStyle.YesNo, "Delete Category") = MsgBoxResult.Yes Then
            Dim result = Await CategoryDbHelper.DeleteCategory(data.Id)
            If Not result Then
                MsgBox("Failed to delete category.", MsgBoxStyle.Critical, "Error")
                Return
            End If
            MsgBox("Category deleted successfully!")
            Me.Dispose()
        End If
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
