Imports Microsoft.EntityFrameworkCore
Public Class InventoryCard
    Public data As Inventory

    Sub DataInit()
        If data IsNot Nothing Then
            lCode.Text = data.Code
            lblProductName.Text = data.ProductName
            lProductName.Text = data.ProductName
            lCategory.Text = data.CategoryName
            lProductDescription.Text = data.ProductDescription
            lCurrentStock.Text = data.CurrentStock.ToString()
            lStockIn.Text = data.StockIn.ToString()
            lStockOut.Text = data.StockOut.ToString()
            lOriginalPrice.Text = data.OriginalPrice.ToString("C2")
            lSellingPrice.Text = data.SellingPrice.ToString("C2")
            lRemarks.Text = If(String.IsNullOrWhiteSpace(data.Remarks), "(No Remarks)", data.Remarks)
        End If
    End Sub

    Private Sub InventoryCard_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataInit()
    End Sub

    Async Function RefetchData() As Task
        Using context As New DataContext()
            Dim productData = Await context.Inventories.FirstOrDefaultAsync(Function(i) i.Id = data.Id)

            If productData IsNot Nothing Then
                data = productData
                DataInit()
            Else
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

    End Function

    Private Async Sub HandleEdit()
        Dim product = Await ProductDbHelper.GetProductById(data.ProductId)

        Dim frm As New InventoryAddEditForm()
        frm.product = product
        frm.inventory = data
        frm.ShowDialog()
        Await RefetchData()
    End Sub

    Private Async Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Dim frm As New AddStockForm()
        frm.productId = data.Id.ToString()
        frm.ShowDialog(Me)
        Await RefetchData()
    End Sub

    Private Async Sub HandleDelete()
        Await InventoryDbHelper.DeleteInventory(data.Id)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        HandleEdit()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this inventory item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            HandleDelete()
            Me.Dispose()
        End If
    End Sub


End Class
