<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Label1 = New Label()
        tSearch = New Krypton.Toolkit.KryptonTextBox()
        btnNew = New Krypton.Toolkit.KryptonButton()
        dgv = New DataGridView()
        ImageList1 = New ImageList(components)
        Button1 = New Button()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 0
        Label1.Text = "Products"
        ' 
        ' tSearch
        ' 
        tSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        tSearch.CueHint.CueHintText = "Search"
        tSearch.Location = New Point(707, 48)
        tSearch.Name = "tSearch"
        tSearch.Size = New Size(278, 31)
        tSearch.StateActive.Border.Rounding = 10F
        tSearch.StateActive.Border.Width = 2
        tSearch.TabIndex = 8
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(12, 46)
        btnNew.Name = "btnNew"
        btnNew.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.OverrideDefault.Border.Color1 = SystemColors.Control
        btnNew.OverrideDefault.Border.Color2 = SystemColors.Control
        btnNew.Size = New Size(126, 33)
        btnNew.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateCommon.Border.Rounding = 10F
        btnNew.StateCommon.Border.Width = 2
        btnNew.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnNew.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnNew.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateDisabled.Border.Color1 = SystemColors.Control
        btnNew.StateDisabled.Border.Color2 = SystemColors.Control
        btnNew.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateNormal.Border.Color1 = SystemColors.Control
        btnNew.StateNormal.Border.Color2 = SystemColors.Control
        btnNew.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StatePressed.Border.Color1 = SystemColors.Control
        btnNew.StatePressed.Border.Color2 = SystemColors.Control
        btnNew.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.TabIndex = 7
        btnNew.Values.DropDownArrowColor = Color.Empty
        btnNew.Values.Text = "Add Products"
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 85)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.Size = New Size(973, 506)
        dgv.TabIndex = 9
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "search-interface-symbol.png")
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ImageKey = "search-interface-symbol.png"
        Button1.ImageList = ImageList1
        Button1.Location = New Point(665, 48)
        Button1.Name = "Button1"
        Button1.Size = New Size(36, 31)
        Button1.TabIndex = 10
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Products
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 603)
        Controls.Add(Button1)
        Controls.Add(dgv)
        Controls.Add(tSearch)
        Controls.Add(btnNew)
        Controls.Add(Label1)
        Name = "Products"
        Text = "Products"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tSearch As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnNew As Krypton.Toolkit.KryptonButton
    Friend WithEvents dgv As DataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
End Class
