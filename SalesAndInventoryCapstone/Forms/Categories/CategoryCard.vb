Public Class CategoryCard
    Public data As DataRow
    Dim db As New DBHelper()

    Async Function HandleRefetch() As Task
        Dim category = Await db.Fetch("SELECT * FROM categories WHERE id = " & data("id").ToString())
        If category.Tables.Count > 0 AndAlso category.Tables(0).Rows.Count > 0 Then
            data = category.Tables(0).Rows(0)
            lblDescription.Text = data.Item("Name").ToString()
        Else
            MsgBox("Category not found.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Function

    Async Sub HandleEditCategory()
        Dim frm As New CategoryAEForm
        frm.categoryRow = data
        frm.Text = "Edit Category"
        frm.ShowDialog(Me)
        Await HandleRefetch()
    End Sub

    Async Sub HandleDeleteCategory()
        If MsgBox("Are you sure you want to delete this category?", MsgBoxStyle.YesNo, "Delete Category") = MsgBoxResult.Yes Then
            Dim db As New DBHelper()
            Await db.DeleteAsync("categories", "id = " & data("id").ToString())
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
