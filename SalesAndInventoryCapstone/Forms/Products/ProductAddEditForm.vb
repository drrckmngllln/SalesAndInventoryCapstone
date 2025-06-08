Imports Krypton.Toolkit

Public Class ProductAddEditForm
    Dim db As New DBHelper()
    Public data As DataRow

    Async Function GetCategories() As Task
        Dim categories = Await db.Fetch("SELECT Id, `Name` FROM categories")

        cmbCategory.Items.Clear()
        cmbCategory.DisplayMember = "Name"
        cmbCategory.ValueMember = "Id"
        cmbCategory.DataSource = categories.Tables(0)

        If data IsNot Nothing Then
            cmbCategory.SelectedValue = data("CategoryId").ToString()
        End If

    End Function

    Sub DataInit()
        If data IsNot Nothing Then
            tProductName.Text = data("ProductName").ToString()
            tInStock.Text = data("InStock").ToString()
            tBuyingPrice.Text = data("BuyingPrice").ToString()
            tSellingPrice.Text = data("SellingPrice").ToString()
            cmbCategory.SelectedValue = data("CategoryId").ToString()

            Me.Text = "Edit Product"
            btnSave.Text = "Update Product"

        Else
            Me.Text = "New Product"
            btnSave.Text = "Create Product"
        End If
    End Sub

    Async Function OnSubmit(isCreate As Boolean) As Task
        Dim productName = tProductName.Text.Trim()
        Dim categoryId = cmbCategory.SelectedValue

        Dim inStock As Integer
        Dim buyingPrice As Decimal
        Dim sellingPrice As Decimal

        Dim isInStockValid = Integer.TryParse(tInStock.Text.Trim(), inStock)
        Dim isBuyingPriceValid = Decimal.TryParse(tBuyingPrice.Text.Trim(), buyingPrice)
        Dim isSellingPriceValid = Decimal.TryParse(tSellingPrice.Text.Trim(), sellingPrice)

        If String.IsNullOrWhiteSpace(productName) OrElse categoryId Is Nothing OrElse
        Not isInStockValid OrElse Not isBuyingPriceValid OrElse Not isSellingPriceValid Then

            MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim product = New Dictionary(Of String, Object) From {
            {"CreatedAt", DateTime.UtcNow},
            {"ProductName", productName},
            {"InStock", inStock},
            {"BuyingPrice", buyingPrice},
            {"SellingPrice", sellingPrice},
            {"CategoryId", categoryId}
        }



        If isCreate Then
            Dim result = Await db.CreateAsync("products", product)
            If result Then
                MessageBox.Show("Product created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to create product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim result = Await db.UpdateAsync("products", product, "id = " & data("id").ToString())
            If result Then
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Function

    Private Async Sub ProductAddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetCategories()
        DataInit()
    End Sub

    Private Async Sub ProductAddEditForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Await OnSubmit(data Is Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Await OnSubmit(data Is Nothing)
    End Sub
End Class