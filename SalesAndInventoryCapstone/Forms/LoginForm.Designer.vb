<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits Krypton.Toolkit.KryptonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        tUsername = New Krypton.Toolkit.KryptonTextBox()
        tPassword = New Krypton.Toolkit.KryptonTextBox()
        btnLogin = New Krypton.Toolkit.KryptonButton()
        btnExit = New Krypton.Toolkit.KryptonButton()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tUsername
        ' 
        tUsername.CueHint.CueHintText = "Username"
        tUsername.Location = New Point(152, 216)
        tUsername.Name = "tUsername"
        tUsername.Size = New Size(355, 31)
        tUsername.StateActive.Border.Rounding = 10F
        tUsername.StateActive.Border.Width = 2
        tUsername.TabIndex = 0
        ' 
        ' tPassword
        ' 
        tPassword.CueHint.CueHintText = "Password"
        tPassword.Location = New Point(152, 253)
        tPassword.Name = "tPassword"
        tPassword.PasswordChar = "●"c
        tPassword.Size = New Size(355, 31)
        tPassword.StateActive.Border.Rounding = 10F
        tPassword.StateActive.Border.Width = 2
        tPassword.TabIndex = 1
        tPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(190, 290)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 33)
        btnLogin.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnLogin.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnLogin.StateCommon.Border.Rounding = 10F
        btnLogin.StateCommon.Border.Width = 2
        btnLogin.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnLogin.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnLogin.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.TabIndex = 2
        btnLogin.Values.DropDownArrowColor = Color.Empty
        btnLogin.Values.Text = "Login"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(322, 290)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(126, 33)
        btnExit.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnExit.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnExit.StateCommon.Border.Rounding = 10F
        btnExit.StateCommon.Border.Width = 2
        btnExit.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnExit.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnExit.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.TabIndex = 3
        btnExit.Values.DropDownArrowColor = Color.Empty
        btnExit.Values.Text = "Exit"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(255, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(287, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 37)
        Label1.TabIndex = 5
        Label1.Text = "Login"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(650, 355)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(tPassword)
        Controls.Add(tUsername)
        KeyPreview = True
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        StateActive.Back.Color1 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Back.Color2 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Border.Color1 = SystemColors.Control
        StateActive.Border.Color2 = SystemColors.Control
        StateActive.Border.Rounding = 10F
        StateActive.Header.Back.Color1 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Header.Back.Color2 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Header.Border.Color1 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Header.Border.Color2 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Header.Content.ShortText.Color1 = Color.White
        StateActive.Header.Content.ShortText.Color2 = Color.White
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExit As Krypton.Toolkit.KryptonButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
