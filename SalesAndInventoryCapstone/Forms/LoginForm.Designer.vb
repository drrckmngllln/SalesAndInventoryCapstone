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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        tUsername = New Krypton.Toolkit.KryptonTextBox()
        tPassword = New Krypton.Toolkit.KryptonTextBox()
        btnLogin = New Krypton.Toolkit.KryptonButton()
        btnExit = New Krypton.Toolkit.KryptonButton()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        chkShowPassword = New CheckBox()
        lblLockoutTimer = New Label()
        lockoutTimer = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tUsername
        ' 
        tUsername.CueHint.CueHintText = "Username"
        tUsername.Location = New Point(11, 308)
        tUsername.Name = "tUsername"
        tUsername.Size = New Size(374, 31)
        tUsername.StateActive.Border.Rounding = 10F
        tUsername.StateActive.Border.Width = 2
        tUsername.TabIndex = 0
        ' 
        ' tPassword
        ' 
        tPassword.CueHint.CueHintText = "Password"
        tPassword.Location = New Point(11, 345)
        tPassword.Name = "tPassword"
        tPassword.PasswordChar = "●"c
        tPassword.Size = New Size(374, 31)
        tPassword.StateActive.Border.Rounding = 10F
        tPassword.StateActive.Border.Width = 2
        tPassword.TabIndex = 1
        tPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(64, 437)
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
        btnExit.Location = New Point(196, 437)
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
        PictureBox1.Location = New Point(134, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(146, 261)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 37)
        Label1.TabIndex = 5
        Label1.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(92, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 21)
        Label2.TabIndex = 6
        Label2.Text = "Sales and Inventory System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(180, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 21)
        Label3.TabIndex = 7
        Label3.Text = "of"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(68, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(264, 21)
        Label4.TabIndex = 8
        Label4.Text = "Repear Parts and Farm Machineries"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(180, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 21)
        Label5.TabIndex = 9
        Label5.Text = "at"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(81, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(241, 28)
        Label6.TabIndex = 10
        Label6.Text = "Agri Top Solana, Cagayan"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.ForeColor = SystemColors.Control
        chkShowPassword.Location = New Point(146, 382)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 11
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblLockoutTimer
        ' 
        lblLockoutTimer.ForeColor = SystemColors.Control
        lblLockoutTimer.Location = New Point(11, 404)
        lblLockoutTimer.Name = "lblLockoutTimer"
        lblLockoutTimer.Size = New Size(374, 30)
        lblLockoutTimer.TabIndex = 13
        lblLockoutTimer.Text = "30"
        lblLockoutTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lockoutTimer
        ' 
        lockoutTimer.Interval = 1000
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(409, 501)
        ControlBox = False
        Controls.Add(lblLockoutTimer)
        Controls.Add(chkShowPassword)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblLockoutTimer As Label
    Friend WithEvents lockoutTimer As Timer
End Class
