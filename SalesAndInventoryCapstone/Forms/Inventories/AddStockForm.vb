Imports Microsoft.EntityFrameworkCore
Public Class AddStockForm
    Public productId As String

    Async Function GetStock() As Task(Of Inventory)
        Using ctx As New DataContext()
            Dim inventory = Await ctx.Inventories.FirstOrDefaultAsync(Function(i) i.Id.ToString() = productId)
            If inventory IsNot Nothing Then
                Return inventory
            End If
            Return inventory
        End Using
    End Function

    Async Function HandleAddStock() As Task
        If Not IsNumeric(tStock.Text) Then
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Dim stock = Await GetStock()
        Using context As New DataContext()
            Dim stock = Await context.Inventories.FirstOrDefaultAsync(Function(i) i.Id = productId)

            If stock Is Nothing Then
                MessageBox.Show("Please enter a valid product ID and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim stockInput = Await context.InventoryInputs.FirstOrDefaultAsync(Function(i) i.Id.ToString() = productId)

            stockInput.CurrentStock += CInt(tStock.Text)
            stockInput.StockIn += CInt(tStock.Text)

            Dim sucess = Await context.SaveChangesAsync() > 0

            If sucess Then
                MessageBox.Show("Stock added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to add stock. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Function

    Private Async Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Await HandleAddStock()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Async Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stock = Await GetStock()
        lProductName.Text = stock.ProductName
    End Sub

    Private Async Sub AddStockForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Await HandleAddStock()
        ElseIf (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class

Public Class StockDto
    Public Property Id As String
    Public Property ProductName As String
    Public Property CurrentStock As Integer
End Class