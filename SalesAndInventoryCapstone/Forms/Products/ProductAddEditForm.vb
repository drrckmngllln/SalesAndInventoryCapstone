Imports Krypton.Toolkit
Imports Microsoft.EntityFrameworkCore

Public Class ProductAddEditForm
    Public data As Products
    Public productId As Integer

    ' Initialize the form and set up the controls
    Async Function GetCategories() As Task
        Using context As New DataContext()
            Dim categories = Await context.Categories.ToListAsync
            cmbCategory.Items.Clear()
            cmbCategory.DisplayMember = "Name"
            cmbCategory.ValueMember = "Id"
            cmbCategory.DataSource = categories


            If productId Then
                cmbCategory.SelectedValue = data
            End If
        End Using

    End Function

    Async Function GetProductById(id As Integer) As Task(Of Product)
        Using context As New DataContext()
            Dim productData = Await context.Products.FindAsync(id)
            If productData IsNot Nothing Then
                Return productData
            Else
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End Using
    End Function

    ' Initialize the form with data if available, otherwise set it for creating a new product
    Async Sub DataInit()
        Dim product = Await GetProductById(productId)

        If product IsNot Nothing Then


            tProductName.Text = product.ProductName
            tProductDescription.Text = product.ProductDescription
            cmbCategory.SelectedValue = product.CategoryId

            Me.Text = "Edit Product"
            btnSave.Text = "Update Product"

        Else
            Me.Text = "New Product"
            btnSave.Text = "Create Product"
        End If
    End Sub

    ' Handle the submission of the form, either creating or updating a product
    Async Function OnSubmit(isCreate As Boolean) As Task
        Dim productName = tProductName.Text.Trim()
        Dim categoryId = cmbCategory.SelectedValue

        If String.IsNullOrWhiteSpace(productName) OrElse categoryId Is Nothing Then

            MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim product As New ProductInput With {
            .ProductName = productName,
            .ProductDescription = tProductDescription.Text,
            .CategoryId = Convert.ToInt32(categoryId)
        }



        If isCreate Then
            'Dim result = Await db.CreateAsync("products", product)
            Dim result = Await ProductDbHelper.AddProduct(product)
            If result Then
                MessageBox.Show("Product created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to create product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'Dim result = Await db.UpdateAsync("products", product, "id = " & data.Id)
            Dim result = Await ProductDbHelper.UpdateProduct(product)
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