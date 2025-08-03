<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnAddStock = New Krypton.Toolkit.KryptonButton()
        btnDelete = New Krypton.Toolkit.KryptonButton()
        btnEdit = New Krypton.Toolkit.KryptonButton()
        lblSellingPrice = New Label()
        lblBuyingPrice = New Label()
        lblInStock = New Label()
        lblCategory = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        lblProductName = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(btnAddStock)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(lblSellingPrice)
        Panel1.Controls.Add(lblBuyingPrice)
        Panel1.Controls.Add(lblInStock)
        Panel1.Controls.Add(lblCategory)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(325, 200)
        Panel1.TabIndex = 0
        ' 
        ' btnAddStock
        ' 
        btnAddStock.Location = New Point(92, 164)
        btnAddStock.Name = "btnAddStock"
        btnAddStock.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.OverrideDefault.Border.Color1 = SystemColors.Control
        btnAddStock.OverrideDefault.Border.Color2 = SystemColors.Control
        btnAddStock.Size = New Size(75, 33)
        btnAddStock.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateCommon.Border.Rounding = 10F
        btnAddStock.StateCommon.Border.Width = 2
        btnAddStock.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnAddStock.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnAddStock.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStock.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateDisabled.Border.Color1 = SystemColors.Control
        btnAddStock.StateDisabled.Border.Color2 = SystemColors.Control
        btnAddStock.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateNormal.Border.Color1 = SystemColors.Control
        btnAddStock.StateNormal.Border.Color2 = SystemColors.Control
        btnAddStock.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StatePressed.Border.Color1 = SystemColors.Control
        btnAddStock.StatePressed.Border.Color2 = SystemColors.Control
        btnAddStock.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnAddStock.TabIndex = 11
        btnAddStock.Values.DropDownArrowColor = Color.Empty
        btnAddStock.Values.Text = "Add Stock"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(249, 164)
        btnDelete.Name = "btnDelete"
        btnDelete.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.OverrideDefault.Border.Color1 = SystemColors.Control
        btnDelete.OverrideDefault.Border.Color2 = SystemColors.Control
        btnDelete.Size = New Size(70, 33)
        btnDelete.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateCommon.Border.Rounding = 10F
        btnDelete.StateCommon.Border.Width = 2
        btnDelete.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnDelete.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnDelete.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateDisabled.Border.Color1 = SystemColors.Control
        btnDelete.StateDisabled.Border.Color2 = SystemColors.Control
        btnDelete.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateNormal.Border.Color1 = SystemColors.Control
        btnDelete.StateNormal.Border.Color2 = SystemColors.Control
        btnDelete.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StatePressed.Border.Color1 = SystemColors.Control
        btnDelete.StatePressed.Border.Color2 = SystemColors.Control
        btnDelete.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnDelete.TabIndex = 10
        btnDelete.Values.DropDownArrowColor = Color.Empty
        btnDelete.Values.Text = "Delete"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(173, 164)
        btnEdit.Name = "btnEdit"
        btnEdit.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.OverrideDefault.Border.Color1 = SystemColors.Control
        btnEdit.OverrideDefault.Border.Color2 = SystemColors.Control
        btnEdit.Size = New Size(70, 33)
        btnEdit.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateCommon.Border.Rounding = 10F
        btnEdit.StateCommon.Border.Width = 2
        btnEdit.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnEdit.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnEdit.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateDisabled.Border.Color1 = SystemColors.Control
        btnEdit.StateDisabled.Border.Color2 = SystemColors.Control
        btnEdit.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateNormal.Border.Color1 = SystemColors.Control
        btnEdit.StateNormal.Border.Color2 = SystemColors.Control
        btnEdit.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StatePressed.Border.Color1 = SystemColors.Control
        btnEdit.StatePressed.Border.Color2 = SystemColors.Control
        btnEdit.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnEdit.TabIndex = 9
        btnEdit.Values.DropDownArrowColor = Color.Empty
        btnEdit.Values.Text = "Edit"
        ' 
        ' lblSellingPrice
        ' 
        lblSellingPrice.AutoSize = True
        lblSellingPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSellingPrice.ForeColor = Color.DimGray
        lblSellingPrice.Location = New Point(125, 129)
        lblSellingPrice.Name = "lblSellingPrice"
        lblSellingPrice.Size = New Size(22, 15)
        lblSellingPrice.TabIndex = 8
        lblSellingPrice.Text = "---"
        ' 
        ' lblBuyingPrice
        ' 
        lblBuyingPrice.AutoSize = True
        lblBuyingPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBuyingPrice.ForeColor = Color.DimGray
        lblBuyingPrice.Location = New Point(125, 99)
        lblBuyingPrice.Name = "lblBuyingPrice"
        lblBuyingPrice.Size = New Size(22, 15)
        lblBuyingPrice.TabIndex = 7
        lblBuyingPrice.Text = "---"
        ' 
        ' lblInStock
        ' 
        lblInStock.AutoSize = True
        lblInStock.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInStock.ForeColor = Color.DimGray
        lblInStock.Location = New Point(125, 70)
        lblInStock.Name = "lblInStock"
        lblInStock.Size = New Size(22, 15)
        lblInStock.TabIndex = 6
        lblInStock.Text = "---"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCategory.ForeColor = Color.DimGray
        lblCategory.Location = New Point(125, 42)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(22, 15)
        lblCategory.TabIndex = 5
        lblCategory.Text = "---"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(3, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 4
        Label4.Text = "Selling Price:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(3, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 3
        Label3.Text = "Buying Price:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(3, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 2
        Label2.Text = "In Stock:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(3, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 1
        Label1.Text = "Category:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Panel2.Controls.Add(lblProductName)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(325, 25)
        Panel2.TabIndex = 0
        ' 
        ' lblProductName
        ' 
        lblProductName.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblProductName.Dock = DockStyle.Fill
        lblProductName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblProductName.ForeColor = SystemColors.Control
        lblProductName.Location = New Point(0, 0)
        lblProductName.Name = "lblProductName"
        lblProductName.Padding = New Padding(10, 0, 0, 0)
        lblProductName.Size = New Size(325, 25)
        lblProductName.TabIndex = 0
        lblProductName.Text = "Product Name"
        lblProductName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ProductCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "ProductCard"
        Size = New Size(325, 200)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblSellingPrice As Label
    Friend WithEvents lblBuyingPrice As Label
    Friend WithEvents lblInStock As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEdit As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAddStock As Krypton.Toolkit.KryptonButton

End Class
