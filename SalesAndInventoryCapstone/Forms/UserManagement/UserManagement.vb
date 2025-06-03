Public Class UserManagement
    Dim users As New DataSet
    Dim db As New DBHelper()

    Async Function GetUsers(Optional search As String = "") As Task
        pnlData.Controls.Clear()
        If (Not String.IsNullOrEmpty(search)) Then
            users = Await db.Fetch("select * from users where LastName like '%" & search & "%' 
                or FirstName like '%" & search & "%'
                or Username like '%" & search & "%'
                order by id asc")
        Else
            users = Await db.Fetch("select * from users order by id asc")
        End If
        If users.Tables.Count > 0 Then
            For Each row As DataRow In users.Tables(0).Rows
                Dim card As New UserCard
                card.data = row
                card.Dock = DockStyle.Top
                pnlData.Controls.Add(card)
            Next
        End If
    End Function

    Private Async Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetUsers()
    End Sub

    Private Sub pnlHeader_Resize(sender As Object, e As EventArgs) Handles pnlHeader.Resize
        Dim labels = pnlHeader.Controls.OfType(Of Label)().ToList()
        If labels.Count = 0 Then Return

        Dim totalWidth As Integer = pnlHeader.Width
        Dim labelWidth As Integer = totalWidth \ labels.Count

        For i As Integer = 0 To labels.Count - 1
            Dim lbl = labels(i)
            lbl.Width = labelWidth
            lbl.Left = i * labelWidth
            lbl.Top = 0
        Next
    End Sub

    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New AddEditForm
        frm.Text = "Add New User"
        frm.ShowDialog(Me)
        pnlData.Controls.Clear()
        Await GetUsers()
    End Sub

    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.TextLength > 2 Then
            pnlData.Controls.Clear()
            Await GetUsers(tSearch.Text.Trim())
        ElseIf tSearch.TextLength = 0 Then
            pnlData.Controls.Clear()
            Await GetUsers()
        End If
    End Sub
End Class