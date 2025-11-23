Imports Microsoft.EntityFrameworkCore

Public Class UserManagement
    Dim users As New DataSet
    Dim db As New DBHelper()

    Async Function GetUsers(Optional search As String = "") As Task(Of List(Of User))
        Dim userList As New List(Of User)
        Using context As New DataContext()
            Dim users = context.Users.AsNoTracking().IgnoreQueryFilters().AsQueryable()

            If String.IsNullOrEmpty(search) Then
                users = users.Where(Function(u) u.LastName.Contains(search) OrElse u.FirstName.Contains(search) OrElse u.Username.Contains(search))
            End If

            userList = Await users.ToListAsync()
        End Using

        Return userList
    End Function

    Async Function InitializeUsers() As Task
        dgv.Rows.Clear()
        dgv.Columns.Clear()

        dgv.Columns.Add("id", "Id")
        dgv.Columns("id").Visible = False
        dgv.Columns.Add("name", "Name")
        dgv.Columns.Add("username", "Username")
        dgv.Columns.Add("role", "Role")
        dgv.Columns.Add("activated", "Activated")

        ' === ADD BUTTON COLUMNS ===
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = "btnEdit"
        editButton.HeaderText = ""
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        dgv.Columns.Add(editButton)

        'Dim deleteButton As New DataGridViewButtonColumn()
        'deleteButton.Name = "btnDelete"
        'deleteButton.HeaderText = ""
        'deleteButton.Text = "Delete"
        'deleteButton.UseColumnTextForButtonValue = True
        'dgv.Columns.Add(deleteButton)

        Dim toggleButton As New DataGridViewButtonColumn()
        toggleButton.Name = "btnToggle"
        toggleButton.HeaderText = ""
        ' 🚀 Do NOT use UseColumnTextForButtonValue here
        toggleButton.UseColumnTextForButtonValue = False
        dgv.Columns.Add(toggleButton)

        ' === LOAD USERS ===
        Dim users = Await GetUsers()
        For Each user In users
            Dim isEnabledText As String = If(user.IsEnabled, "Yes", "No")
            Dim toggleText As String = If(user.IsEnabled, "Deactivate", "Activated")
            Dim rowIndex = dgv.Rows.Add(user.Id, $"{user.LastName}, {user.FirstName}", user.Username, user.Role, isEnabledText)

            ' ✅ Assign toggle button text per row
            dgv.Rows(rowIndex).Cells("btnToggle").Value = toggleText
        Next

        ' === OPTIONAL STYLING ===
        dgv.Columns("btnEdit").Width = 60
        'dgv.Columns("btnDelete").Width = 70
        dgv.Columns("btnToggle").Width = 80
    End Function



    Private Async Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await InitializeUsers()
    End Sub

    Async Function DeleteUser(id As String) As Task
        Using context As New DataContext()
            Dim user = Await context.Users.IgnoreQueryFilters().FirstOrDefaultAsync(Function(u) u.Id = id)
            If user IsNot Nothing Then
                context.Users.Remove(user)
                Await context.SaveChangesAsync()
                MsgBox($"User {user.LastName}, {user.FirstName} has been deleted.")
                Await InitializeUsers()
            Else
                MsgBox("User not found.")
            End If
        End Using
    End Function


    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New AddEditForm
        frm.Text = "Add New User"
        frm.ShowDialog(Me)
        Await GetUsers()
    End Sub

    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.TextLength > 2 Then
            Await GetUsers(tSearch.Text.Trim())
        ElseIf tSearch.TextLength = 0 Then
            Await GetUsers()
        End If
    End Sub

    Private Async Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex < 0 Then Return ' Ignore header clicks

        Dim id As String = dgv.Rows(e.RowIndex).Cells("id").Value.ToString()
        Dim username As String = dgv.Rows(e.RowIndex).Cells("username").Value.ToString()

        If dgv.Columns(e.ColumnIndex).Name = "btnEdit" Then
            ' === Handle Edit ===
            Dim frm As New AddEditForm()
            frm.id = id
            frm.Text = "Edit User"
            frm.ShowDialog(Me)
            Await InitializeUsers()

        ElseIf dgv.Columns(e.ColumnIndex).Name = "btnDelete" Then
            ' === Handle Delete ===
            Dim confirm = MessageBox.Show($"Are you sure you want to delete {username}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                Await DeleteUser(id)
            End If

        ElseIf dgv.Columns(e.ColumnIndex).Name = "btnToggle" Then
            ' === Handle Enable/Disable ===
            Using context As New DataContext()
                Dim user = Await context.Users.IgnoreQueryFilters().FirstOrDefaultAsync(Function(u) u.Id = id)
                If user Is Nothing Then
                    MsgBox("User not found.")
                    Return
                End If

                user.IsEnabled = Not user.IsEnabled
                Await context.SaveChangesAsync()

                Dim actionText As String = If(user.IsEnabled, "enabled", "disabled")
                MsgBox($"User '{user.Username}' has been {actionText}.")

                Await InitializeUsers()
            End Using
        End If
    End Sub

End Class