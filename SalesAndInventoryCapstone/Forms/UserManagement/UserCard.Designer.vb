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
        Panel3 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1237, 36)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(1014, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20, 0, 0, 0)
        Panel3.Size = New Size(223, 36)
        Panel3.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(698, 0)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(5, 0, 0, 0)
        Label5.Size = New Size(316, 36)
        Label5.TabIndex = 7
        Label5.Text = "Username"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(368, 0)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(5, 0, 0, 0)
        Label4.Size = New Size(330, 36)
        Label4.TabIndex = 6
        Label4.Text = "First Name"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(38, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5, 0, 0, 0)
        Label2.Size = New Size(330, 36)
        Label2.TabIndex = 5
        Label2.Text = "Last Name"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 36)
        Panel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Left
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(20, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 36)
        Button1.TabIndex = 0
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Left
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(95, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 1
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' UserCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "UserCard"
        Padding = New Padding(0, 2, 0, 2)
        Size = New Size(1237, 40)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
