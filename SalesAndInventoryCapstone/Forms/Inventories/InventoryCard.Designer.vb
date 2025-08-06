<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryCard
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
        lblProductName = New Label()
        Panel1 = New Panel()
        KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        lRemarks = New Label()
        Label19 = New Label()
        lSellingPrice = New Label()
        Label17 = New Label()
        lOriginalPrice = New Label()
        Label15 = New Label()
        lCurrentStock = New Label()
        Label9 = New Label()
        lCategory = New Label()
        Label7 = New Label()
        lProductDescription = New Label()
        Label5 = New Label()
        lProductName = New Label()
        Label3 = New Label()
        btnDelete = New Krypton.Toolkit.KryptonButton()
        btnEdit = New Krypton.Toolkit.KryptonButton()
        lCode = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(KryptonButton1)
        Panel1.Controls.Add(lRemarks)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(lSellingPrice)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(lOriginalPrice)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(lCurrentStock)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lCategory)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lProductDescription)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(lProductName)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(lCode)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(325, 249)
        Panel1.TabIndex = 1
        ' 
        ' KryptonButton1
        ' 
        KryptonButton1.Location = New Point(86, 213)
        KryptonButton1.Name = "KryptonButton1"
        KryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.OverrideDefault.Border.Color1 = SystemColors.Control
        KryptonButton1.OverrideDefault.Border.Color2 = SystemColors.Control
        KryptonButton1.Size = New Size(84, 33)
        KryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateCommon.Border.Rounding = 10F
        KryptonButton1.StateCommon.Border.Width = 2
        KryptonButton1.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        KryptonButton1.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        KryptonButton1.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonButton1.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateDisabled.Border.Color1 = SystemColors.Control
        KryptonButton1.StateDisabled.Border.Color2 = SystemColors.Control
        KryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateNormal.Border.Color1 = SystemColors.Control
        KryptonButton1.StateNormal.Border.Color2 = SystemColors.Control
        KryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StatePressed.Border.Color1 = SystemColors.Control
        KryptonButton1.StatePressed.Border.Color2 = SystemColors.Control
        KryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        KryptonButton1.TabIndex = 29
        KryptonButton1.Values.DropDownArrowColor = Color.Empty
        KryptonButton1.Values.Text = "Add Stock"
        ' 
        ' lRemarks
        ' 
        lRemarks.AutoSize = True
        lRemarks.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lRemarks.ForeColor = Color.DimGray
        lRemarks.Location = New Point(126, 132)
        lRemarks.Name = "lRemarks"
        lRemarks.Size = New Size(22, 15)
        lRemarks.TabIndex = 28
        lRemarks.Text = "---"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.ForeColor = Color.DimGray
        Label19.Location = New Point(4, 132)
        Label19.Name = "Label19"
        Label19.Size = New Size(52, 15)
        Label19.TabIndex = 27
        Label19.Text = "Remarks"
        ' 
        ' lSellingPrice
        ' 
        lSellingPrice.AutoSize = True
        lSellingPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lSellingPrice.ForeColor = Color.DimGray
        lSellingPrice.Location = New Point(126, 117)
        lSellingPrice.Name = "lSellingPrice"
        lSellingPrice.Size = New Size(22, 15)
        lSellingPrice.TabIndex = 26
        lSellingPrice.Text = "---"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.ForeColor = Color.DimGray
        Label17.Location = New Point(4, 117)
        Label17.Name = "Label17"
        Label17.Size = New Size(71, 15)
        Label17.TabIndex = 25
        Label17.Text = "Selling Price"
        ' 
        ' lOriginalPrice
        ' 
        lOriginalPrice.AutoSize = True
        lOriginalPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lOriginalPrice.ForeColor = Color.DimGray
        lOriginalPrice.Location = New Point(126, 102)
        lOriginalPrice.Name = "lOriginalPrice"
        lOriginalPrice.Size = New Size(22, 15)
        lOriginalPrice.TabIndex = 24
        lOriginalPrice.Text = "---"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.ForeColor = Color.DimGray
        Label15.Location = New Point(4, 102)
        Label15.Name = "Label15"
        Label15.Size = New Size(78, 15)
        Label15.TabIndex = 23
        Label15.Text = "Original Price"
        ' 
        ' lCurrentStock
        ' 
        lCurrentStock.AutoSize = True
        lCurrentStock.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lCurrentStock.ForeColor = Color.DimGray
        lCurrentStock.Location = New Point(125, 87)
        lCurrentStock.Name = "lCurrentStock"
        lCurrentStock.Size = New Size(22, 15)
        lCurrentStock.TabIndex = 18
        lCurrentStock.Text = "---"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(3, 87)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 15)
        Label9.TabIndex = 17
        Label9.Text = "Current Stock"
        ' 
        ' lCategory
        ' 
        lCategory.AutoSize = True
        lCategory.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lCategory.ForeColor = Color.DimGray
        lCategory.Location = New Point(125, 72)
        lCategory.Name = "lCategory"
        lCategory.Size = New Size(22, 15)
        lCategory.TabIndex = 16
        lCategory.Text = "---"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(3, 72)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 15
        Label7.Text = "Category"
        ' 
        ' lProductDescription
        ' 
        lProductDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lProductDescription.ForeColor = Color.DimGray
        lProductDescription.Location = New Point(36, 162)
        lProductDescription.Name = "lProductDescription"
        lProductDescription.Size = New Size(286, 48)
        lProductDescription.TabIndex = 14
        lProductDescription.Text = "---"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(4, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 15)
        Label5.TabIndex = 13
        Label5.Text = "Product Description"
        ' 
        ' lProductName
        ' 
        lProductName.AutoSize = True
        lProductName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lProductName.ForeColor = Color.DimGray
        lProductName.Location = New Point(125, 57)
        lProductName.Name = "lProductName"
        lProductName.Size = New Size(22, 15)
        lProductName.TabIndex = 12
        lProductName.Text = "---"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(3, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 11
        Label3.Text = "Product Name"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(252, 213)
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
        btnEdit.Location = New Point(176, 213)
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
        ' lCode
        ' 
        lCode.AutoSize = True
        lCode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lCode.ForeColor = Color.DimGray
        lCode.Location = New Point(125, 42)
        lCode.Name = "lCode"
        lCode.Size = New Size(22, 15)
        lCode.TabIndex = 5
        lCode.Text = "---"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(3, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 1
        Label1.Text = "Code"
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
        ' InventoryCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "InventoryCard"
        Size = New Size(325, 249)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblProductName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEdit As Krypton.Toolkit.KryptonButton
    Friend WithEvents lCode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lProductName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lRemarks As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lSellingPrice As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lOriginalPrice As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lCurrentStock As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lCategory As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lProductDescription As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton

End Class
