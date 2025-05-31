Public Class CategoryCard
    Public data As DataRow

    Private Sub CategoryCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescription.Text = data.Item("Name")
    End Sub
End Class
