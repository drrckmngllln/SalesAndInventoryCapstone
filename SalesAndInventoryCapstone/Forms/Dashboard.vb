Public Class Dashboard
    Dim db As New DBHelper()

    Private Async Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await CheckForLowStock()

        lProducts.Text = Await GetProductsCount()
        lSales.Text = Await GetSalesCount()

        Dim inventoryData = Await GetInventoryCount()
        lCurrentStock.Text = inventoryData.CurrentStock.ToString()
        lStockIn.Text = inventoryData.StockIn.ToString()
        lStockOut.Text = inventoryData.StockOut.ToString()

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


    '' 🛒 Get Products Count
    Async Function GetProductsCount() As Task(Of String)
        Dim products = Await db.Fetch("SELECT SUM(InStock * SellingPrice) AS TotalPrice FROM products")

        Dim total As Decimal = 0

        If products.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(products.Tables(0).Rows(0)("TotalPrice")) Then
            total = Convert.ToDecimal(products.Tables(0).Rows(0)("TotalPrice"))
        End If

        Return CurrencyFormatter.FormatAsPeso(total)
    End Function

    '' 💰 Get Sales Count
    Async Function GetSalesCount() As Task(Of String)
        Dim sales = Await db.Fetch("SELECT SUM(TotalSales) AS TotalSales FROM sales")
        Dim total As Decimal = 0
        If sales.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(sales.Tables(0).Rows(0)("TotalSales")) Then
            total = Convert.ToDecimal(sales.Tables(0).Rows(0)("TotalSales"))
        End If
        Return CurrencyFormatter.FormatAsPeso(total)
    End Function

    '' 📦 Get Inventory Count
    Async Function GetInventoryCount() As Task(Of InventorySummary)
        Dim inventories = Await db.Fetch("
            SELECT 
	            SUM(CurrentStock) AS CurrentStock, 
	            SUM(StockIn) AS StockIn,
	            SUM(StockOut) AS StockOut
            FROM inventories
            ")

        Dim summary As New InventorySummary()
        If inventories.Tables(0).Rows.Count > 0 Then
            summary.CurrentStock = If(IsDBNull(inventories.Tables(0).Rows(0)("CurrentStock")), 0, Convert.ToInt32(inventories.Tables(0).Rows(0)("CurrentStock")))
            summary.StockIn = If(IsDBNull(inventories.Tables(0).Rows(0)("StockIn")), 0, Convert.ToInt32(inventories.Tables(0).Rows(0)("StockIn")))
            summary.StockOut = If(IsDBNull(inventories.Tables(0).Rows(0)("StockOut")), 0, Convert.ToInt32(inventories.Tables(0).Rows(0)("StockOut")))
        End If

        Return summary
    End Function

    '' 🔔 Get Notifications
    Async Function GetNotifications() As Task(Of List(Of Notifcations))
        Dim notifications = Await db.Fetch("
            SELECT 
	            a.Id AS Id,
                b.Id AS InventoryId,
	            b.`Code` AS InventoryCode,
	            b.CurrentStock AS CurrentStock,
	            a.Message AS Message,
	            a.IsRead AS IsRead,
	            a.CreatedAt AS `CreatedAt` 
            FROM notifications AS a
            INNER JOIN inventories AS b ON a.InventoryId = b.Id
            WHERE	a.IsRead = 0
        ")
        Dim notificationList As New List(Of Notifcations)()
        For Each row As DataRow In notifications.Tables(0).Rows
            Dim notif As New Notifcations With {
                .Id = Convert.ToInt32(row("Id")),
                .InventoryId = Convert.ToInt32(row("InventoryId")),
                .InventoryCode = Convert.ToString(row("InventoryCode")),
                .CurrentStock = Convert.ToInt32(row("CurrentStock")),
                .Message = Convert.ToString(row("Message")),
                .CreatedAt = Convert.ToDateTime(row("CreatedAt"))
            }
            notificationList.Add(notif)
        Next
        Return notificationList
    End Function

    '' 📬 Mark Notification as Read
    Async Function MarkNotificationAsRead(id As Integer) As Task
        Await db.UpdateAsync("notifications", New Dictionary(Of String, Object) From {
            {"IsRead", True}
        }, $"Id = {id}")

    End Function

    '' 📦 Check for Low Stock
    Async Function CheckForLowStock() As Task
        Dim lowStockThreshold As Integer = 10
        Dim inventories = Await db.Fetch("SELECT * FROM inventories WHERE CurrentStock <= '" & lowStockThreshold & "'")

        Dim dbNotifications = Await GetNotifications()
        Dim existingCodes = dbNotifications.Select(Function(n) n.InventoryId).ToHashSet()

        For Each row As DataRow In inventories.Tables(0).Rows
            Dim currentStock = Convert.ToInt32(row("CurrentStock"))
            Dim inventoryCode = Convert.ToString(row("Code"))
            Dim inventoryId = Convert.ToInt32(row("Id"))

            If existingCodes.Contains(inventoryId) Then Continue For

            Dim message = $"Low stock alert for {inventoryCode}. Current stock is {currentStock}."

            ' Insert new notification
            Await db.CreateAsync("notifications", New Dictionary(Of String, Object) From {
                {"InventoryId", inventoryId},
                {"Message", message},
                {"IsRead", False},
                {"CreatedAt", DateTime.Now}
            })
        Next
    End Function



End Class


Public Class InventorySummary
    Public Property CurrentStock As Integer
    Public Property StockIn As Integer
    Public Property StockOut As Integer
End Class

Public Class Notifcations
    Public Property Id As Integer
    Public Property InventoryId As Integer
    Public Property InventoryCode As String
    Public Property CurrentStock As Integer
    Public Property Message As String
    Public Property CreatedAt As DateTime
End Class