Imports Microsoft.EntityFrameworkCore

Public Class Dashboard
    Dim db As New DBHelper()

    Private Async Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await CheckForLowStock()

        lProducts.Text = Await ProductDbHelper.GetProductsCount()
        lSales.Text = Await SaleDbHelper.GetSalesCount()

        Dim inventoryData = Await GetInventoryCount()
        lCurrentStock.Text = inventoryData.CurrentStock.ToString()

        Dim notifications = Await GetNotifications()

        With dgvNotifications
            .Columns.Clear()
            .Columns.Add("Id", "Id")
            .Columns("Id").Visible = False
            .Columns.Add("CurrentStock", "Current Stock")
            .Columns.Add("Message", "Message")
            .Columns("Message").Width = 800
            .Columns.Add("CreatedAt", "Date")
        End With

        Dim btnEdit As New DataGridViewButtonColumn()
        With btnEdit
            .Name = "Mark As Read"
            .HeaderText = "Mark As Read"
            .Text = "Mark As Read"
            .UseColumnTextForButtonValue = True
        End With
        dgvNotifications.Columns.Add(btnEdit)

        For Each notification In notifications
            dgvNotifications.Rows.Add(
            notification.Id,
            notification.CurrentStock,
            notification.Message,
            notification.CreatedAt.ToString("MMMM dd, yyyy")
        )
        Next
    End Sub

    '' 📋 DataGridView Cell Content Click Event
    Private Async Sub dgvNotifications_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotifications.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvNotifications.Columns(e.ColumnIndex).Name = "Mark As Read" Then
            Dim id = Convert.ToInt32(dgvNotifications.Rows(e.RowIndex).Cells("Id").Value)
            Await MarkNotificationAsRead(id)
            dgvNotifications.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    '' 📦 Get Inventory Count
    Async Function GetInventoryCount() As Task(Of InventorySummary)
        Dim inventories = Await DBHelper.Fetch("
            SELECT SUM(CurrentStock) AS CurrentStock FROM inventories
        ")

        Dim summary As New InventorySummary()
        If inventories.Tables(0).Rows.Count > 0 Then
            summary.CurrentStock = If(IsDBNull(inventories.Tables(0).Rows(0)("CurrentStock")), 0, Convert.ToInt32(inventories.Tables(0).Rows(0)("CurrentStock")))
        End If

        Return summary
    End Function

    '' 🔔 Get Notifications
    Async Function GetNotifications() As Task(Of List(Of Notifcations))
        Using ctx As New DataContext()
            Dim notifications = Await (
                From n In ctx.Notifications
                Join i In ctx.Inventories On n.InventoryId Equals i.Id
                Where n.IsRead = False
                Select New Notifcations With {
                    .Id = n.Id,
                    .InventoryId = i.Id,
                    .InventoryCode = i.Code,
                    .CurrentStock = i.CurrentStock,
                    .Message = n.Message,
                    .CreatedAt = n.CreatedAt
                }
            ).ToListAsync()

            Return notifications
        End Using

    End Function

    '' 📬 Mark Notification as Read
    Async Function MarkNotificationAsRead(id As Integer) As Task
        Using ctx As New DataContext()
            Dim notification = Await ctx.Notifications.FindAsync(id)
            If notification IsNot Nothing Then
                notification.IsRead = True
                Await ctx.SaveChangesAsync()
            End If
        End Using
    End Function

    '' 📦 Check for Low Stock
    Async Function CheckForLowStock() As Task
        Const lowStockThreshold As Integer = 10

        Using ctx As New DataContext()
            Dim lowStockInventories = Await ctx.Inventories _
            .Where(Function(i) i.CurrentStock <= lowStockThreshold) _
            .ToListAsync()

            Dim unreadNotifications = Await ctx.Notifications _
            .Where(Function(n) Not n.IsRead) _
            .ToListAsync()

            Dim lowStockIds = lowStockInventories _
            .Select(Function(i) i.Id) _
            .ToHashSet()

            Dim notificationsToRemove = unreadNotifications _
            .Where(Function(n) Not lowStockIds.Contains(n.InventoryId)) _
            .ToList()

            If notificationsToRemove.Any() Then
                ctx.Notifications.RemoveRange(notificationsToRemove)
            End If

            Dim existingNotifInventoryIds = unreadNotifications _
            .Where(Function(n) lowStockIds.Contains(n.InventoryId)) _
            .Select(Function(n) n.InventoryId) _
            .ToHashSet()

            For Each inv In lowStockInventories
                If Not existingNotifInventoryIds.Contains(inv.Id) Then
                    Dim message As String

                    If inv.CurrentStock <= 0 Then
                        message = $"Out of stock: {inv.Code}. Current stock is {inv.CurrentStock}."
                    Else
                        message = $"Low stock alert for {inv.Code}. Current stock is {inv.CurrentStock} (threshold: {lowStockThreshold})."
                    End If

                    Dim notif As New Notification With {
                    .InventoryId = inv.Id,
                    .Message = message,
                    .IsRead = False,
                    .CreatedAt = DateTime.Now
                }

                    Await ctx.Notifications.AddAsync(notif)
                End If
            Next

            Await ctx.SaveChangesAsync()
        End Using
    End Function

End Class


Public Class InventorySummary
    Public Property CurrentStock As Integer
End Class

Public Class Notifcations
    Public Property Id As Integer
    Public Property InventoryId As Integer
    Public Property InventoryCode As String
    Public Property CurrentStock As Integer
    Public Property Message As String
    Public Property CreatedAt As DateTime
End Class