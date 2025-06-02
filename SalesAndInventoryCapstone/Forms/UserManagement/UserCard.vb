Public Class UserCard
    Public data As DataRow
    Dim db As New DBHelper()

    Sub DisplayInit()
        Dim labels = pnlHeader.Controls.OfType(Of Label)().ToList()
        If labels.Count = 0 Then Return

        Dim totalWidth As Integer = pnlHeader.Width
        Dim labelWidth As Integer = totalWidth \ labels.Count

        For i As Integer = 0 To labels.Count - 1
            Dim lbl = labels(i)
            lbl.Width = labelWidth
            lbl.Left = i * labelWidth
            lbl.Top = 0 ' Optional: align to top
        Next
    End Sub

    Sub DataInit()
        If data Is Nothing Then Return

        lblLastName.Text = data("LastName").ToString()
        lblFirstName.Text = data("FirstName").ToString()
        lblUsername.Text = data("Username").ToString()
    End Sub

    Sub HandleEdit()

    End Sub

    Sub HandleDelete()
        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            db.Delete("users", data("id").ToString())
            Me.Dispose()
        End If
    End Sub

    Private Sub UserCard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DisplayInit()
    End Sub

    Private Sub UserCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataInit()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        HandleDelete()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        HandleEdit()
    End Sub
End Class
