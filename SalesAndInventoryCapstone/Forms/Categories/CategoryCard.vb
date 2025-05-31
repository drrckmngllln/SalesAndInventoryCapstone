Public Class CategoryCard
    Public data As DataRow

    Sub HandleEditCategory()
        Dim frm As New CategoryAEForm
        frm.categoryRow = data
        frm.Text = "Edit Category"
        frm.ShowDialog(Me)
    End Sub

    Sub HandleDeleteCategory()
        If MsgBox("Are you sure you want to delete this category?", MsgBoxStyle.YesNo, "Delete Category") = MsgBoxResult.Yes Then
            Dim db As New DBHelper()
            db.Delete("categories", "id = " & data("id").ToString())
            MsgBox("Category deleted successfully!")
            Me.Dispose()
        End If
    End Sub

    Private Sub CategoryCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescription.Text = data.Item("Name")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HandleEditCategory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HandleDeleteCategory()
    End Sub
End Class
