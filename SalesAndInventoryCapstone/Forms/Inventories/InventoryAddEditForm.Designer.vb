<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryAddEditForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        tCode = New Krypton.Toolkit.KryptonTextBox()
        Label3 = New Label()
        tCurrentStock = New Krypton.Toolkit.KryptonTextBox()
        Label5 = New Label()
        tOriginalPrice = New Krypton.Toolkit.KryptonTextBox()
        Label7 = New Label()
        tSellingPrice = New Krypton.Toolkit.KryptonTextBox()
        Label8 = New Label()
        tRemarks = New Krypton.Toolkit.KryptonTextBox()
        GroupBox1 = New GroupBox()
        lProductDescription = New Label()
        Label11 = New Label()
        lProductCategory = New Label()
        Label9 = New Label()
        lProductName = New Label()
        Label2 = New Label()
        btnSelectProduct = New Krypton.Toolkit.KryptonButton()
        btnSave = New Krypton.Toolkit.KryptonButton()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 12
        Label1.Text = "Code"
        ' 
        ' tCode
        ' 
        tCode.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tCode.Location = New Point(12, 27)
        tCode.Name = "tCode"
        tCode.Size = New Size(370, 31)
        tCode.StateActive.Border.Rounding = 10F
        tCode.StateActive.Border.Width = 2
        tCode.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 24
        Label3.Text = "Current Stock"
        ' 
        ' tCurrentStock
        ' 
        tCurrentStock.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tCurrentStock.Location = New Point(12, 79)
        tCurrentStock.Name = "tCurrentStock"
        tCurrentStock.Size = New Size(370, 31)
        tCurrentStock.StateActive.Border.Rounding = 10F
        tCurrentStock.StateActive.Border.Width = 2
        tCurrentStock.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 28
        Label5.Text = "Original Price"
        ' 
        ' tOriginalPrice
        ' 
        tOriginalPrice.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tOriginalPrice.Location = New Point(12, 131)
        tOriginalPrice.Name = "tOriginalPrice"
        tOriginalPrice.Size = New Size(370, 31)
        tOriginalPrice.StateActive.Border.Rounding = 10F
        tOriginalPrice.StateActive.Border.Width = 2
        tOriginalPrice.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 165)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 32
        Label7.Text = "Selling Price"
        ' 
        ' tSellingPrice
        ' 
        tSellingPrice.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tSellingPrice.Location = New Point(12, 183)
        tSellingPrice.Name = "tSellingPrice"
        tSellingPrice.Size = New Size(370, 31)
        tSellingPrice.StateActive.Border.Rounding = 10F
        tSellingPrice.StateActive.Border.Width = 2
        tSellingPrice.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 15)
        Label8.TabIndex = 34
        Label8.Text = "Remarks"
        ' 
        ' tRemarks
        ' 
        tRemarks.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tRemarks.Location = New Point(12, 235)
        tRemarks.Multiline = True
        tRemarks.Name = "tRemarks"
        tRemarks.Size = New Size(370, 85)
        tRemarks.StateActive.Border.Rounding = 10F
        tRemarks.StateActive.Border.Width = 2
        tRemarks.TabIndex = 33
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lProductDescription)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(lProductCategory)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(lProductName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(388, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(292, 204)
        GroupBox1.TabIndex = 35
        GroupBox1.TabStop = False
        GroupBox1.Text = "Product Detail"
        ' 
        ' lProductDescription
        ' 
        lProductDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lProductDescription.Location = New Point(34, 103)
        lProductDescription.Name = "lProductDescription"
        lProductDescription.Size = New Size(252, 98)
        lProductDescription.TabIndex = 18
        lProductDescription.Text = "..."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 85)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 15)
        Label11.TabIndex = 17
        Label11.Text = "Description"
        ' 
        ' lProductCategory
        ' 
        lProductCategory.AutoSize = True
        lProductCategory.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lProductCategory.Location = New Point(76, 51)
        lProductCategory.Name = "lProductCategory"
        lProductCategory.Size = New Size(16, 15)
        lProductCategory.TabIndex = 16
        lProductCategory.Text = "..."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 51)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 15)
        Label9.TabIndex = 15
        Label9.Text = "Category"
        ' 
        ' lProductName
        ' 
        lProductName.AutoSize = True
        lProductName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lProductName.Location = New Point(76, 19)
        lProductName.Name = "lProductName"
        lProductName.Size = New Size(16, 15)
        lProductName.TabIndex = 14
        lProductName.Text = "..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 13
        Label2.Text = "Name"
        ' 
        ' btnSelectProduct
        ' 
        btnSelectProduct.Location = New Point(554, 238)
        btnSelectProduct.Name = "btnSelectProduct"
        btnSelectProduct.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.OverrideDefault.Border.Color1 = SystemColors.Control
        btnSelectProduct.OverrideDefault.Border.Color2 = SystemColors.Control
        btnSelectProduct.Size = New Size(126, 33)
        btnSelectProduct.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateCommon.Border.Rounding = 10F
        btnSelectProduct.StateCommon.Border.Width = 2
        btnSelectProduct.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnSelectProduct.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnSelectProduct.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelectProduct.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateDisabled.Border.Color1 = SystemColors.Control
        btnSelectProduct.StateDisabled.Border.Color2 = SystemColors.Control
        btnSelectProduct.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateNormal.Border.Color1 = SystemColors.Control
        btnSelectProduct.StateNormal.Border.Color2 = SystemColors.Control
        btnSelectProduct.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StatePressed.Border.Color1 = SystemColors.Control
        btnSelectProduct.StatePressed.Border.Color2 = SystemColors.Control
        btnSelectProduct.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSelectProduct.TabIndex = 36
        btnSelectProduct.Values.DropDownArrowColor = Color.Empty
        btnSelectProduct.Values.Text = "Select Product"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(282, 348)
        btnSave.Name = "btnSave"
        btnSave.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.OverrideDefault.Border.Color1 = SystemColors.Control
        btnSave.OverrideDefault.Border.Color2 = SystemColors.Control
        btnSave.Size = New Size(126, 40)
        btnSave.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateCommon.Border.Rounding = 10F
        btnSave.StateCommon.Border.Width = 2
        btnSave.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnSave.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnSave.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateDisabled.Border.Color1 = SystemColors.Control
        btnSave.StateDisabled.Border.Color2 = SystemColors.Control
        btnSave.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateNormal.Border.Color1 = SystemColors.Control
        btnSave.StateNormal.Border.Color2 = SystemColors.Control
        btnSave.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StatePressed.Border.Color1 = SystemColors.Control
        btnSave.StatePressed.Border.Color2 = SystemColors.Control
        btnSave.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.TabIndex = 37
        btnSave.Values.DropDownArrowColor = Color.Empty
        btnSave.Values.Text = "Save Inventory"
        ' 
        ' InventoryAddEditForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(692, 400)
        Controls.Add(btnSave)
        Controls.Add(btnSelectProduct)
        Controls.Add(GroupBox1)
        Controls.Add(Label8)
        Controls.Add(tRemarks)
        Controls.Add(Label7)
        Controls.Add(tSellingPrice)
        Controls.Add(Label5)
        Controls.Add(tOriginalPrice)
        Controls.Add(Label3)
        Controls.Add(tCurrentStock)
        Controls.Add(Label1)
        Controls.Add(tCode)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "InventoryAddEditForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InventoryAddEditForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tCode As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tCurrentStock As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tOriginalPrice As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tSellingPrice As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tRemarks As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lProductDescription As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lProductCategory As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lProductName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelectProduct As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As Krypton.Toolkit.KryptonButton
End Class
