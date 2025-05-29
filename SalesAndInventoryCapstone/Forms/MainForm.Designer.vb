<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        KryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(KryptonGroup1, ComponentModel.ISupportInitialize).BeginInit()
        CType(KryptonGroup1.Panel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1397, 30)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 10.0F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(30, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 5, 0, 0)
        Label1.Size = New Size(926, 30)
        Label1.TabIndex = 1
        Label1.Text = "SALES AND INVENTORY SYSTEM OF REAPER PARTS AND FARM MACHINERIES" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = My.Resources.Resources.tractor
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' KryptonGroup1
        ' 
        KryptonGroup1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone
        KryptonGroup1.Location = New Point(327, 182)
        KryptonGroup1.Size = New Size(613, 349)
        KryptonGroup1.TabIndex = 1
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(1397, 796)
        Controls.Add(KryptonGroup1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainForm"
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(KryptonGroup1.Panel, ComponentModel.ISupportInitialize).EndInit()
        CType(KryptonGroup1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KryptonGroup1 As Krypton.Toolkit.KryptonGroup
End Class
