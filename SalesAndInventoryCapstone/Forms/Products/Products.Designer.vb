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
        Label1 = New Label()
        pnlData = New FlowLayoutPanel()
        tSearch = New Krypton.Toolkit.KryptonTextBox()
        btnNew = New Krypton.Toolkit.KryptonButton()
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
        ' pnlData
        ' 
        pnlData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlData.AutoScroll = True
        pnlData.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        pnlData.Location = New Point(12, 85)
        pnlData.Name = "pnlData"
        pnlData.Padding = New Padding(3)
        pnlData.Size = New Size(973, 506)
        pnlData.TabIndex = 1
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
        ' Products
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 603)
        Controls.Add(tSearch)
        Controls.Add(btnNew)
        Controls.Add(pnlData)
        Controls.Add(Label1)
        Name = "Products"
        Text = "Products"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlData As FlowLayoutPanel
    Friend WithEvents tSearch As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnNew As Krypton.Toolkit.KryptonButton
End Class
