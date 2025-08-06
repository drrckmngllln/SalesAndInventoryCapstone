Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics.X86

Public Class UserCard
    Public data As DataRow
    Dim db As New DBHelper()

    Async Function HandleRefetch() As Task
        Dim user = Await DBHelper.Fetch($"select * from users where id={data("Id").ToString()}")
        If user.Tables.Count > 0 AndAlso user.Tables(0).Rows.Count > 0 Then
            data = user.Tables(0).Rows(0)
            DataInit()
        Else
            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Function

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

    Async Sub HandleEdit()
        Dim frm As New AddEditForm
        frm.data = data
        frm.Text = "Edit User"
        frm.btnSave.Text = "Update User"
        frm.ShowDialog(Me)
        Await HandleRefetch()
    End Sub

    Async Sub HandleDelete()
        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Await db.DeleteAsync("users", data("id").ToString())
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
