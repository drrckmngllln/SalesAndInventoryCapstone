<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        pnlGrid = New Panel()
        btnNew = New Krypton.Toolkit.KryptonButton()
        tSearch = New Krypton.Toolkit.KryptonTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 0
        Label1.Text = "Categories"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGrid.AutoScroll = True
        pnlGrid.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        pnlGrid.Location = New Point(12, 83)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(1018, 544)
        pnlGrid.TabIndex = 1
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(12, 44)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(126, 33)
        btnNew.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateCommon.Border.Rounding = 10F
        btnNew.StateCommon.Border.Width = 2
        btnNew.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnNew.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnNew.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.TabIndex = 3
        btnNew.Values.DropDownArrowColor = Color.Empty
        btnNew.Values.Text = "Add Category"
        ' 
        ' tSearch
        ' 
        tSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        tSearch.CueHint.CueHintText = "Search"
        tSearch.Location = New Point(752, 46)
        tSearch.Name = "tSearch"
        tSearch.Size = New Size(278, 31)
        tSearch.StateActive.Border.Rounding = 10F
        tSearch.StateActive.Border.Width = 2
        tSearch.TabIndex = 4
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1042, 639)
        Controls.Add(tSearch)
        Controls.Add(btnNew)
        Controls.Add(pnlGrid)
        Controls.Add(Label1)
        Name = "Categories"
        Text = "Categories"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents btnNew As Krypton.Toolkit.KryptonButton
    Friend WithEvents tSearch As Krypton.Toolkit.KryptonTextBox
End Class
