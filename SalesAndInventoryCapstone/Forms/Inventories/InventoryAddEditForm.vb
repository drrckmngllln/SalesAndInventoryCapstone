Public Class InventoryAddEditForm
    Public product As Product
    Public inventory As Inventory

    Sub OpenProductSelector()
        Dim frm As New ProductSelector()
        If frm.ShowDialog() = DialogResult.OK Then
            product = frm.SelectedProduct
            LoadProduct()
        Else
            product = Nothing
        End If
    End Sub

    Private Sub btnSelectProduct_Click(sender As Object, e As EventArgs) Handles btnSelectProduct.Click
        OpenProductSelector()
        LoadProduct()
    End Sub

    Private Sub InventoryAddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProduct()

    End Sub

    Sub LoadProduct()
        If product IsNot Nothing Then
            lProductName.Text = product.ProductName
            lProductDescription.Text = product.ProductDescription
            lProductCategory.Text = product.Category
            ToggleControls(True)
        End If
        If inventory IsNot Nothing And product IsNot Nothing Then
            lProductName.Text = If(product Is Nothing, "...", product.ProductName)
            lProductDescription.Text = If(product Is Nothing, "...", product.ProductDescription)
            lProductCategory.Text = If(product Is Nothing, "...", product.Category)
            tCode.Text = If(inventory Is Nothing, "...", inventory.Code)
            tCurrentStock.Text = inventory.CurrentStock.ToString()
            tOriginalPrice.Text = inventory.OriginalPrice.ToString("F2")
            tSellingPrice.Text = inventory.SellingPrice.ToString("F2")
            tRemarks.Text = inventory.Remarks
            ToggleControls(True)
        Else
            ' Clear fields for new inventory item
            tCode.Clear()
            tCurrentStock.Clear()
            tOriginalPrice.Clear()
            tSellingPrice.Clear()
            tRemarks.Clear()
            'ToggleControls(False)
        End If
    End Sub

    Async Function OnSubmit() As Task
        If product Is Nothing Then
            MessageBox.Show("Please select a product first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim inventoryItem As New InventoryInput With {
            .Code = tCode.Text.Trim(),
            .ProductId = product.Id,
            .CurrentStock = CInt(tCurrentStock.Text),
            .OriginalPrice = Decimal.Parse(tOriginalPrice.Text),
            .SellingPrice = Decimal.Parse(tSellingPrice.Text),
            .Remarks = tRemarks.Text.Trim()
        }
        If inventory IsNot Nothing Then
            ' Update existing inventory item
            inventoryItem.Id = inventory.Id
            Await InventoryDbHelper.UpdateInventory(inventoryItem)
        Else
            ' Add new inventory item
            Await InventoryDbHelper.AddInventory(inventoryItem)
        End If
        MessageBox.Show($"Inventory {If(inventory Is Nothing, "Saved", "Updated")} Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Function

    Sub ToggleControls(enabled As Boolean)
        If (Not enabled) Then
            tCode.Enabled = False
            tCurrentStock.Enabled = False
            tOriginalPrice.Enabled = False
            tSellingPrice.Enabled = False
            tRemarks.Enabled = False
            btnSave.Enabled = False
        Else
            tCode.Enabled = True
            tCurrentStock.Enabled = True
            tOriginalPrice.Enabled = True
            tSellingPrice.Enabled = True
            tRemarks.Enabled = True
            btnSave.Enabled = True
        End If
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Await OnSubmit()
    End Sub
End Class