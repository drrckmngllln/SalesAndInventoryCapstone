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
        pnlData = New Panel()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        btnNew = New Krypton.Toolkit.KryptonButton()
        tSearch = New Krypton.Toolkit.KryptonTextBox()
        pnlGrid.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
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
        pnlGrid.Controls.Add(pnlData)
        pnlGrid.Controls.Add(Panel1)
        pnlGrid.Location = New Point(12, 83)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(1018, 544)
        pnlGrid.TabIndex = 1
        ' 
        ' pnlData
        ' 
        pnlData.AutoScroll = True
        pnlData.Dock = DockStyle.Fill
        pnlData.Location = New Point(0, 30)
        pnlData.Name = "pnlData"
        pnlData.Size = New Size(1018, 514)
        pnlData.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1018, 30)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(38, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(834, 30)
        Label2.TabIndex = 2
        Label2.Text = "Category Name"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(872, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(146, 30)
        Panel3.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5, 0, 0, 0)
        Label3.Size = New Size(146, 30)
        Label3.TabIndex = 3
        Label3.Text = "Actions"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 30)
        Panel2.TabIndex = 0
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(12, 44)
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
        KeyPreview = True
        Name = "Categories"
        Text = "Categories"
        pnlGrid.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents btnNew As Krypton.Toolkit.KryptonButton
    Friend WithEvents tSearch As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlData As Panel
End Class
