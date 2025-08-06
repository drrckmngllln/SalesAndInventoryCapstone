Public Class ProductCard
    Public data As Product

    'when the card if first loaded, it initializes the product card with data from the DataRow
    Sub DataInit()
        If data IsNot Nothing Then
            lblProductName.Text = data.ProductName
            lblCategory.Text = data.Category
            lblDescription.Text = data.ProductDescription
        End If
    End Sub

    'this function initializes the product card with data from the DataRow and serve as a refetch when editing a product
    Async Function RefetchData() As Task
        Dim productData = Await ProductDbHelper.GetProductById(data.Id)
        If productData IsNot Nothing Then
            data = productData
            DataInit()
        Else
            MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    'this function handles the edit button click event, opens the ProductAddEditForm, and refetches the data after closing the form
    Async Function HandleEdit() As Task
        Dim frm As New ProductAddEditForm()
        frm.data = data
        frm.ShowDialog(Me)
        Await RefetchData()
    End Function

    'this function handles the delete button click event, confirms the deletion, and deletes the product from the database
    Async Function HandleDelete() As Task
        Dim id As String = data.Id

        If id Is Nothing Then
            MsgBox("No id found")
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim success = Await ProductDbHelper.DeleteProduct(data.Id)
            If success Then
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Function

    Async Function HandleAddStock() As Task
        Dim frm As New AddStockForm()
        frm.productId = data.Id
        frm.ShowDialog(Me)
        Await RefetchData()
    End Function

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Await HandleEdit()
    End Sub

    Private Sub ProductCard_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataInit()
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Await HandleDelete()
    End Sub

    Private Async Sub btnAddStock_Click(sender As Object, e As EventArgs)
        Await HandleAddStock()
    End Sub
End Class
