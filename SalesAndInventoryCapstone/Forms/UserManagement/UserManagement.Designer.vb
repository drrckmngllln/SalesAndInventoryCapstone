﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        pnlGrid.SuspendLayout()
        pnlData.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
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
        pnlData.Controls.Add(Label5)
        pnlData.Controls.Add(Label4)
        pnlData.Dock = DockStyle.Fill
        pnlData.Location = New Point(0, 30)
        pnlData.Name = "pnlData"
        pnlData.Size = New Size(1160, 561)
        pnlData.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1160, 30)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(658, 209)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(5, 0, 0, 0)
        Label5.Size = New Size(316, 30)
        Label5.TabIndex = 6
        Label5.Text = "Username"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(429, 290)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(5, 0, 0, 0)
        Label4.Size = New Size(330, 30)
        Label4.TabIndex = 5
        Label4.Text = "First Name"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5, 0, 0, 0)
        Label2.Size = New Size(330, 30)
        Label2.TabIndex = 4
        Label2.Text = "Last Name"
        Label2.TextAlign = ContentAlignment.MiddleLeft
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
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(38, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(976, 30)
        Panel4.TabIndex = 2
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
        pnlData.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
End Class
