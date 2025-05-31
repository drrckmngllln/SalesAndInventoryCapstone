Public Class Categories
    Dim categories As New DataSet

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCategories()
    End Sub

    Sub GetCategories(Optional search As String = "")
        If (Not String.IsNullOrEmpty(search)) Then
            categories = Fetch("select * from categories where name like '" & search & "' order by id asc")
        Else
            categories = Fetch("select * from categories order by id asc")
        End If

        If categories.Tables.Count > 0 Then
            For Each row As DataRow In categories.Tables(0).Rows
                Dim card As New CategoryCard
                card.data = row
                card.Dock = DockStyle.Top
                pnlGrid.Controls.Add(card)
            Next
        End If
    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If (tSearch.Text.Length > 2) Then
            pnlGrid.Controls.Clear()
            GetCategories(tSearch.Text)
        Else
            pnlGrid.Controls.Clear()
            GetCategories()
        End If
    End Sub
End Class