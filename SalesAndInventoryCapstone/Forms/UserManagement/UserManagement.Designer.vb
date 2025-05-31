<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Panel3 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
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
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 0
        Label1.Text = "User Management"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGrid.AutoScroll = True
        pnlGrid.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        pnlGrid.Controls.Add(pnlData)
        pnlGrid.Controls.Add(Panel1)
        pnlGrid.Location = New Point(12, 95)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(1160, 591)
        pnlGrid.TabIndex = 2
        ' 
        ' pnlData
        ' 
        pnlData.AutoScroll = True
        pnlData.Dock = DockStyle.Fill
        pnlData.Location = New Point(0, 30)
        pnlData.Name = "pnlData"
        pnlData.Size = New Size(1160, 561)
        pnlData.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1160, 30)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1014, 0)
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
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(38, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(330, 30)
        Panel4.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(368, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(330, 30)
        Panel5.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(698, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(330, 30)
        Panel6.TabIndex = 4
        ' 
        ' UserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 698)
        Controls.Add(pnlGrid)
        Controls.Add(Label1)
        Name = "UserManagement"
        Text = "UserManagement"
        pnlGrid.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents pnlData As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
End Class
