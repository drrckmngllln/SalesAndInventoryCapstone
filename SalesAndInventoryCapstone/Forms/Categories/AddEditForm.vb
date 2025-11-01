Imports Microsoft.EntityFrameworkCore

Public Class CategoryAEForm
    Public id As Integer
    Dim db As New DBHelper()

    Async Function OnSubmit(isCreate As Boolean) As Task
        If String.IsNullOrEmpty(tName.Text) Then
            MsgBox("Error, required fields is missing")
            Return
        End If

        Using context As New DataContext()
            If isCreate Then
                Dim data As New Category() With {
                .Name = tName.Text.Trim()
                }

                context.Categories.Add(data)

                Dim result = Await context.SaveChangesAsync() > 0

                If result Then
                    MsgBox("Category created successfully!")
                Else
                    MsgBox("Error creating category, please try again.")
                    Return
                End If
                Me.Close()
            Else
                Dim update = Await context.Categories.FindAsync()

                If update Is Nothing Then
                    MsgBox("Category not found, please try again.")
                    Return
                End If

                update.Name = tName.Text.Trim()

                Dim result = Await context.SaveChangesAsync() > 0

                If result Then
                    MsgBox("Category updated successfully!")
                Else
                    MsgBox("Error updating category, please try again.")
                    Return
                End If
                Me.Close()
            End If
        End Using

    End Function

    Async Function CreateAsync() As Task
        If String.IsNullOrEmpty(tName.Text) Then
            MsgBox("Error, required fields is missing")
            Return
        End If
        Using context As New DataContext()
            Dim validated = Await context.Categories.AnyAsync(Function(c) c.Name = tName.Text.Trim())

            If validated Then
                MsgBox("Category already exists, please try again.")
                Return
            End If

            Dim data As New Category() With {
                .Name = tName.Text.Trim()
            }
            context.Categories.Add(data)
            Dim result = Await context.SaveChangesAsync() > 0
            If result Then
                MsgBox("Category created successfully!")
            Else
                MsgBox("Error creating category, please try again.")
                Return
            End If
            Me.Close()
        End Using
    End Function

    Async Function UpdateAsync() As Task
        If String.IsNullOrEmpty(tName.Text) Then
            MsgBox("Error, required fields is missing")
            Return
        End If
        Using context As New DataContext()
            Dim update = Await context.Categories.FindAsync(id)
            If update Is Nothing Then
                MsgBox("Category not found, please try again.")
                Return
            End If
            update.Name = tName.Text.Trim()
            Dim result = Await context.SaveChangesAsync() > 0
            If result Then
                MsgBox("Category updated successfully!")
            Else
                MsgBox("Error updating category, please try again.")
                Return
            End If
            Me.Close()
        End Using
    End Function

    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Me.Text = "New Category" Then
            Await CreateAsync()
        ElseIf Me.Text = "Edit Category" Then
            Await UpdateAsync()
        End If

    End Sub

    Private Async Sub CategoryAEForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id <> 0 Then
            Using context As New DataContext()
                Dim category = Await context.Categories.FindAsync(id)
                If category Is Nothing Then
                    MsgBox("Category not found, please try again.")
                    Me.Close()
                    Return
                End If

                tName.Text = category.Name
            End Using
        End If
    End Sub

    Private Async Sub CategoryAEForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Text = "New Category" Then
                Await CreateAsync()
            ElseIf Me.Text = "Edit Category" Then
                Await UpdateAsync()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class