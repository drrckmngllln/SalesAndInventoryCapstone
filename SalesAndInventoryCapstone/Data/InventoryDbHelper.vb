Imports MySql.Data.MySqlClient

Public Class InventoryDbHelper
    Shared Async Function GetInventoryAsync(Optional search As String = Nothing) As Task(Of List(Of Inventory))
        Dim sql As String = "SELECT * FROM inventoriesview"
        Dim parameters As New Dictionary(Of String, Object)

        If Not String.IsNullOrWhiteSpace(search) Then
            sql &= $" WHERE ProductName LIKE '%{search}%' OR ProductDescription LIKE '%{search}%' OR CategoryName LIKE '%{search}%'"
        End If

        Dim inventories = Await DBHelper.Fetch(sql)
        Dim inventoryList As New List(Of Inventory)()

        If inventories.Tables.Count > 0 AndAlso inventories.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In inventories.Tables(0).Rows
                Dim inventoryItem As New Inventory With {
                .Id = If(IsDBNull(row("Id")), 0, Convert.ToInt32(row("Id"))),
                .Code = If(IsDBNull(row("Code")), String.Empty, row("Code").ToString()),
                .ProductId = If(IsDBNull(row("ProductId")), 0, Convert.ToInt32(row("ProductId"))),
                .ProductName = If(IsDBNull(row("ProductName")), "(No Name)", row("ProductName").ToString()),
                .ProductDescription = If(IsDBNull(row("ProductDescription")) OrElse String.IsNullOrWhiteSpace(row("ProductDescription").ToString()), "(No Product Description)", row("ProductDescription").ToString()),
                .CategoryName = If(IsDBNull(row("CategoryName")), "(No Category)", row("CategoryName").ToString()),
                .CurrentStock = If(IsDBNull(row("CurrentStock")), 0, Convert.ToInt32(row("CurrentStock"))),
                .OriginalPrice = If(IsDBNull(row("OriginalPrice")), 0D, Convert.ToDecimal(row("OriginalPrice"))),
                .SellingPrice = If(IsDBNull(row("SellingPrice")), 0D, Convert.ToDecimal(row("SellingPrice"))),
                .Remarks = If(IsDBNull(row("Remarks")), String.Empty, row("Remarks").ToString())
            }
                inventoryList.Add(inventoryItem)
            Next
        End If

        Return inventoryList
    End Function




    Shared Async Function GetInventoryByIdAsync(inventoryId As Integer) As Task(Of Inventory)
        Dim sql As String = $"SELECT * FROM inventoriesview WHERE Id = {inventoryId}"
        Dim inventoryDataSet As DataSet = Await DBHelper.Fetch(sql)
        If inventoryDataSet.Tables.Count > 0 AndAlso inventoryDataSet.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = inventoryDataSet.Tables(0).Rows(0)
            Return New Inventory With {
                .Id = Convert.ToInt32(row("Id")),
                .Code = row("Code").ToString(),
                .ProductName = row("ProductName").ToString(),
                .ProductDescription = row("ProductDescription").ToString(),
                .CategoryName = row("CategoryName").ToString(),
                .CurrentStock = Convert.ToInt32(row("CurrentStock")),
                .OriginalPrice = Convert.ToDecimal(row("OriginalPrice")),
                .SellingPrice = Convert.ToDecimal(row("SellingPrice")),
                .Remarks = If(IsDBNull(row("Remarks")), String.Empty, row("Remarks").ToString())
            }
        End If
        Return Nothing
    End Function

    Shared Async Function AddInventory(inventory As InventoryInput) As Task(Of Boolean)
        Dim result = Await DBHelper.CreateAsync("inventories", inventory)
        Return result
    End Function

    Shared Async Function UpdateInventory(inventory As InventoryInput) As Task(Of Boolean)
        'Dim result = Await DBHelper.UpdateAsync("inventories", inventory, inventory.Id)
        'Return result
        Try
            Await con.OpenAsync()
            cmd = New MySqlCommand("UPDATE inventories SET Code = @code, ProductId = @productId, CurrentStock = @currentStock, OriginalPrice = @originalPrice, SellingPrice = @sellingPrice, Remarks = @remarks WHERE Id = @id", con)
            cmd.Parameters.AddWithValue("@code", inventory.Code)
            cmd.Parameters.AddWithValue("@productId", inventory.ProductId)
            cmd.Parameters.AddWithValue("@currentStock", inventory.CurrentStock)
            cmd.Parameters.AddWithValue("@originalPrice", inventory.OriginalPrice)
            cmd.Parameters.AddWithValue("@sellingPrice", inventory.SellingPrice)
            cmd.Parameters.AddWithValue("@remarks", inventory.Remarks)
            cmd.Parameters.AddWithValue("@id", inventory.Id)
            Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()
            Await con.CloseAsync()
            Return rowsAffected > 0
        Catch ex As Exception
            MsgBox("An error has occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Shared Async Function DeleteInventory(inventoryId As Integer) As Task(Of Boolean)
        Dim result = Await DBHelper.DeleteAsync("inventories", inventoryId)
        Return result
    End Function

    Shared Async Function AddCurrentStock(inventoryId As Integer, stock As Integer) As Task(Of Boolean)
        Try
            Await con.OpenAsync()
            cmd = New MySqlCommand("UPDATE inventories SET CurrentStock = CurrentStock + @stock WHERE Id = @id", con)
            cmd.Parameters.AddWithValue("@stock", stock)
            cmd.Parameters.AddWithValue("@id", inventoryId)
            Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()
            If rowsAffected > 0 Then
                Return True
            End If
            Await con.CloseAsync()
        Catch ex As Exception
            MsgBox("An error has occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return False
    End Function
End Class
