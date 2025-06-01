Public Class UserManagement
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim card As New UserCard


        For i As Integer = 1 To 20
            Dim userCard As New UserCard
            'userCard.lblName.Text = "User " & i.ToString()
            userCard.Dock = DockStyle.Top
            pnlData.Controls.Add(userCard)
        Next
    End Sub
End Class