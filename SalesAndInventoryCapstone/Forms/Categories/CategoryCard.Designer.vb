<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryCard
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
        pnlActions = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        lblDescription = New Label()
        pnlActions.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(38, 36)
        Panel1.TabIndex = 0
        ' 
        ' pnlActions
        ' 
        pnlActions.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        pnlActions.Controls.Add(Button2)
        pnlActions.Controls.Add(Button1)
        pnlActions.Dock = DockStyle.Right
        pnlActions.Location = New Point(383, 2)
        pnlActions.Name = "pnlActions"
        pnlActions.Padding = New Padding(1, 1, 5, 1)
        pnlActions.Size = New Size(146, 36)
        pnlActions.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Right
        Button2.Location = New Point(66, 1)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 34)
        Button2.TabIndex = 1
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Left
        Button1.Location = New Point(1, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(65, 34)
        Button1.TabIndex = 0
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblDescription
        ' 
        lblDescription.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDescription.Dock = DockStyle.Fill
        lblDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDescription.ForeColor = SystemColors.Control
        lblDescription.Location = New Point(38, 2)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(345, 36)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Label1"
        lblDescription.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CategoryCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Controls.Add(lblDescription)
        Controls.Add(pnlActions)
        Controls.Add(Panel1)
        Name = "CategoryCard"
        Padding = New Padding(0, 2, 0, 2)
        Size = New Size(529, 40)
        pnlActions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlActions As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
