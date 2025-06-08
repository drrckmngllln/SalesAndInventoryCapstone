Public Class Categories
    Dim categories As New DataSet
    Dim db As New DBHelper()

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCategories()
    End Sub

    Async Sub GetCategories(Optional search As String = "")
        If (Not String.IsNullOrEmpty(search)) Then
            categories = Await db.Fetch("select * from categories where name like '%" & search & "%' order by id asc")
        Else
            categories = Await db.Fetch("select * from categories order by id asc")
        End If

        If categories.Tables.Count > 0 Then
            For Each row As DataRow In categories.Tables(0).Rows
                Dim card As New CategoryCard
                card.data = row
                card.Dock = DockStyle.Top
                pnlData.Controls.Add(card)
            Next
        End If
    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If (tSearch.Text.Length > 2) Then
            pnlData.Controls.Clear()
            GetCategories(tSearch.Text)
        Else
            pnlData.Controls.Clear()
            GetCategories()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New CategoryAEForm
        frm.Text = "Add Category"
        frm.ShowDialog(Me)
        pnlData.Controls.Clear()
        GetCategories()
    End Sub
End Class