<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserCard
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
        pnlHeader = New Panel()
        lblUsername = New Label()
        lblFirstName = New Label()
        lblLastName = New Label()
        Panel3 = New Panel()
        btnDelete = New Button()
        btnEdit = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        pnlHeader.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(pnlHeader)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(843, 36)
        Panel1.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblUsername)
        pnlHeader.Controls.Add(lblFirstName)
        pnlHeader.Controls.Add(lblLastName)
        pnlHeader.Dock = DockStyle.Fill
        pnlHeader.Location = New Point(38, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(600, 36)
        pnlHeader.TabIndex = 9
        ' 
        ' lblUsername
        ' 
        lblUsername.Dock = DockStyle.Left
        lblUsername.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblUsername.ForeColor = SystemColors.Control
        lblUsername.Location = New Point(400, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Padding = New Padding(5, 0, 0, 0)
        lblUsername.Size = New Size(200, 36)
        lblUsername.TabIndex = 10
        lblUsername.Text = "Username"
        lblUsername.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Dock = DockStyle.Left
        lblFirstName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblFirstName.ForeColor = SystemColors.Control
        lblFirstName.Location = New Point(200, 0)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Padding = New Padding(5, 0, 0, 0)
        lblFirstName.Size = New Size(200, 36)
        lblFirstName.TabIndex = 9
        lblFirstName.Text = "First Name"
        lblFirstName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblLastName
        ' 
        lblLastName.Dock = DockStyle.Left
        lblLastName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblLastName.ForeColor = SystemColors.Control
        lblLastName.Location = New Point(0, 0)
        lblLastName.Name = "lblLastName"
        lblLastName.Padding = New Padding(5, 0, 0, 0)
        lblLastName.Size = New Size(200, 36)
        lblLastName.TabIndex = 8
        lblLastName.Text = "Last Name"
        lblLastName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnEdit)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(638, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20, 0, 0, 0)
        Panel3.Size = New Size(205, 36)
        Panel3.TabIndex = 8
        ' 
        ' btnDelete
        ' 
        btnDelete.Dock = DockStyle.Left
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDelete.Location = New Point(95, 0)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 36)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Dock = DockStyle.Left
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEdit.Location = New Point(20, 0)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 36)
        btnEdit.TabIndex = 0
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 36)
        Panel2.TabIndex = 0
        ' 
        ' UserCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "UserCard"
        Padding = New Padding(0, 2, 0, 2)
        Size = New Size(843, 40)
        Panel1.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label

End Class
