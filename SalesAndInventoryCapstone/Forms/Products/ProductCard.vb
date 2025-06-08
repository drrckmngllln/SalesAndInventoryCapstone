Public Class ProductCard
    Public data As DataRow
    Dim db As New DBHelper()

    Sub DataInit()
        If data IsNot Nothing Then
            lblProductName.Text = data.Item("ProductName").ToString()
            lblCategory.Text = data.Item("Category").ToString()
            lblInStock.Text = data.Item("InStock").ToString()
            lblBuyingPrice.Text = $"Php {data.Item("BuyingPrice").ToString()}"
            lblSellingPrice.Text = $"Php {data.Item("SellingPrice").ToString()}"
        End If
    End Sub

    Async Function RefetchData() As Task
        Dim sql As String = $"
            SELECT 
                a.Id,
                a.ProductName,
                b.`Name` as `Category`,
                b.`Id` as `CategoryId`,
                a.InStock,
                a.BuyingPrice,
                a.SellingPrice
            FROM products AS a
            LEFT JOIN `categories` AS `b` ON a.CategoryId = b.Id
            WHERE a.Id={data.Item("Id").ToString()}"

        Dim product = Await db.Fetch(sql)
        If product.Tables.Count > 0 AndAlso product.Tables(0).Rows.Count > 0 Then
            data = product.Tables(0).Rows(0)
            DataInit()
        Else
            MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Async Function HandleEdit() As Task
        Dim frm As New ProductAddEditForm()
        frm.data = data
        frm.ShowDialog(Me)
        Await RefetchData()
    End Function

    Async Function HandleDelete() As Task
        Dim id As String = data.Item(0).ToString()

        If id Is Nothing Then
            MsgBox("No id found")
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim success = Await db.DeleteAsync("products", "id= " & data.Item("Id").ToString())
            If success Then
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
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
End Class
