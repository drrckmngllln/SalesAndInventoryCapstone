Imports Microsoft.EntityFrameworkCore

Public Class Inventories
    Private Async Sub Inventories_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await LoadAsync()
    End Sub

    Async Function LoadAsync(Optional search As String = Nothing) As Task
        Using context As New DataContext()
            Dim inventories = context.Inventories.AsQueryable()

            If (Not String.IsNullOrEmpty(search)) Then
                inventories = inventories.Where(
                    Function(i) i.ProductName.Contains(search) OrElse
                                i.Code.Contains(search) OrElse
                                i.ProductDescription.Contains(search) OrElse
                                i.CategoryName.Contains(search)
                )
            End If
            Dim inventoriesList = Await inventories.ToListAsync()
            pnlData.Controls.Clear()
            If inventoriesList IsNot Nothing AndAlso inventories.Count > 0 Then
                For Each inventory As Inventory In inventories
                    Dim card As New InventoryCard()
                    card.data = inventory
                    pnlData.Controls.Add(card)
                Next
            End If
        End Using
    End Function

    Private Async Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New InventoryAddEditForm()
        frm.Text = "Add Inventory"
        frm.ShowDialog(Me)
        Await LoadAsync()
    End Sub

    Private Async Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        If tSearch.TextLength > 2 Then
            Await LoadAsync(tSearch.Text)
        Else
            Await LoadAsync()
        End If
    End Sub
End Class