Imports Microsoft.EntityFrameworkCore

Public Class Categories
    Dim categories As New DataSet
    Dim db As New DBHelper()

    Private Async Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetCategories()
    End Sub

    Async Function GetCategories(Optional search As String = "") As Task
        'Dim categories = Await CategoryDbHelper.GetCategories(search)
        Using context As New DataContext()
            Dim query = context.Categories _
                .AsQueryable()

            If Not String.IsNullOrWhiteSpace(search) Then
                query = query.Where(Function(c) c.Name.Contains(search))
            End If

            Dim categories = Await query.ToListAsync()

            If categories IsNot Nothing AndAlso categories.Count > 0 Then
                For Each category As Category In categories
                    Dim card As New CategoryCard
                    card.data = category
                    card.Dock = DockStyle.Top
                    pnlData.Controls.Add(card)
                Next
            End If
        End Using

    End Function

    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If (tSearch.Text.Length > 2) Then
            pnlData.Controls.Clear()
            Await GetCategories(tSearch.Text)
        Else
            pnlData.Controls.Clear()
            Await GetCategories()
        End If
    End Sub

    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New CategoryAEForm
        frm.Text = "New Category"
        frm.ShowDialog(Me)
        pnlData.Controls.Clear()
        Await GetCategories()
    End Sub

    Private Async Sub Categories_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New CategoryAEForm
            frm.Text = "Add Category"
            frm.ShowDialog(Me)
            pnlData.Controls.Clear()
            Await GetCategories()
        End If

    End Sub
End Class