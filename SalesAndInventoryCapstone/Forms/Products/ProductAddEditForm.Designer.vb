<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductAddEditForm
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
        tProductName = New Krypton.Toolkit.KryptonTextBox()
        Label2 = New Label()
        Label3 = New Label()
        tInStock = New Krypton.Toolkit.KryptonTextBox()
        Label4 = New Label()
        tBuyingPrice = New Krypton.Toolkit.KryptonTextBox()
        Label5 = New Label()
        tSellingPrice = New Krypton.Toolkit.KryptonTextBox()
        btnSave = New Krypton.Toolkit.KryptonButton()
        cmbCategory = New Krypton.Toolkit.KryptonComboBox()
        CType(cmbCategory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 10
        Label1.Text = "Product Name:"
        ' 
        ' tProductName
        ' 
        tProductName.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tProductName.Location = New Point(12, 27)
        tProductName.Name = "tProductName"
        tProductName.Size = New Size(370, 31)
        tProductName.StateActive.Border.Rounding = 10F
        tProductName.StateActive.Border.Width = 2
        tProductName.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 12
        Label2.Text = "Category:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 14
        Label3.Text = "In Stock:"
        ' 
        ' tInStock
        ' 
        tInStock.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tInStock.Location = New Point(12, 131)
        tInStock.Name = "tInStock"
        tInStock.Size = New Size(370, 31)
        tInStock.StateActive.Border.Rounding = 10F
        tInStock.StateActive.Border.Width = 2
        tInStock.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 16
        Label4.Text = "Buying Price:"
        ' 
        ' tBuyingPrice
        ' 
        tBuyingPrice.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tBuyingPrice.Location = New Point(12, 183)
        tBuyingPrice.Name = "tBuyingPrice"
        tBuyingPrice.Size = New Size(370, 31)
        tBuyingPrice.StateActive.Border.Rounding = 10F
        tBuyingPrice.StateActive.Border.Width = 2
        tBuyingPrice.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 15)
        Label5.TabIndex = 18
        Label5.Text = "Selling Price:"
        ' 
        ' tSellingPrice
        ' 
        tSellingPrice.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tSellingPrice.Location = New Point(12, 235)
        tSellingPrice.Name = "tSellingPrice"
        tSellingPrice.Size = New Size(370, 31)
        tSellingPrice.StateActive.Border.Rounding = 10F
        tSellingPrice.StateActive.Border.Width = 2
        tSellingPrice.TabIndex = 17
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(250, 273)
        btnSave.Name = "btnSave"
        btnSave.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.OverrideDefault.Border.Color1 = SystemColors.Control
        btnSave.OverrideDefault.Border.Color2 = SystemColors.Control
        btnSave.Size = New Size(126, 33)
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
        btnSave.TabIndex = 19
        btnSave.Values.DropDownArrowColor = Color.Empty
        btnSave.Values.Text = "Add Products"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.DropDownWidth = 356
        cmbCategory.Location = New Point(12, 79)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(370, 28)
        cmbCategory.StateActive.ComboBox.Border.Rounding = 10F
        cmbCategory.StateActive.ComboBox.Border.Width = 2
        cmbCategory.StateActive.ComboBox.Content.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbCategory.StateActive.ComboBox.Content.Padding = New Padding(1)
        cmbCategory.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        cmbCategory.TabIndex = 20
        ' 
        ' ProductAddEditForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(394, 318)
        ControlBox = False
        Controls.Add(cmbCategory)
        Controls.Add(btnSave)
        Controls.Add(Label5)
        Controls.Add(tSellingPrice)
        Controls.Add(Label4)
        Controls.Add(tBuyingPrice)
        Controls.Add(Label3)
        Controls.Add(tInStock)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tProductName)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "ProductAddEditForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProductAddEditForm"
        CType(cmbCategory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tProductName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tInStock As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tBuyingPrice As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tSellingPrice As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Friend WithEvents cmbCategory As Krypton.Toolkit.KryptonComboBox
End Class
