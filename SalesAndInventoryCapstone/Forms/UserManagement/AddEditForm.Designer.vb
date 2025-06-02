<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditForm
    'Inherits System.Windows.Forms.Form
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
        Label1 = New Label()
        btnSave = New Krypton.Toolkit.KryptonButton()
        tLastName = New Krypton.Toolkit.KryptonTextBox()
        Label2 = New Label()
        tFirstName = New Krypton.Toolkit.KryptonTextBox()
        Label3 = New Label()
        tUsername = New Krypton.Toolkit.KryptonTextBox()
        lblPassword = New Label()
        tPassword = New Krypton.Toolkit.KryptonTextBox()
        chkShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 8
        Label1.Text = "Last Name"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(313, 259)
        btnSave.Name = "btnSave"
        btnSave.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.OverrideDefault.Border.Color1 = SystemColors.Control
        btnSave.OverrideDefault.Border.Color2 = SystemColors.Control
        btnSave.Size = New Size(126, 33)
        btnSave.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateCommon.Border.Rounding = 10F
        btnSave.StateCommon.Border.Width = 2
        btnSave.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnSave.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnSave.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateDisabled.Border.Color1 = SystemColors.Control
        btnSave.StateDisabled.Border.Color2 = SystemColors.Control
        btnSave.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateNormal.Border.Color1 = SystemColors.Control
        btnSave.StateNormal.Border.Color2 = SystemColors.Control
        btnSave.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StatePressed.Border.Color1 = SystemColors.Control
        btnSave.StatePressed.Border.Color2 = SystemColors.Control
        btnSave.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnSave.TabIndex = 6
        btnSave.Values.DropDownArrowColor = Color.Empty
        btnSave.Values.Text = "Save"
        ' 
        ' tLastName
        ' 
        tLastName.CueHint.CueHintText = "Username"
        tLastName.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tLastName.Location = New Point(19, 27)
        tLastName.Name = "tLastName"
        tLastName.Size = New Size(420, 31)
        tLastName.StateActive.Border.Rounding = 10F
        tLastName.StateActive.Border.Width = 2
        tLastName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 10
        Label2.Text = "First Name"
        ' 
        ' tFirstName
        ' 
        tFirstName.CueHint.CueHintText = "Username"
        tFirstName.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tFirstName.Location = New Point(19, 79)
        tFirstName.Name = "tFirstName"
        tFirstName.Size = New Size(420, 31)
        tFirstName.StateActive.Border.Rounding = 10F
        tFirstName.StateActive.Border.Width = 2
        tFirstName.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 12
        Label3.Text = "Username"
        ' 
        ' tUsername
        ' 
        tUsername.CueHint.CueHintText = "Username"
        tUsername.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tUsername.Location = New Point(19, 131)
        tUsername.Name = "tUsername"
        tUsername.Size = New Size(420, 31)
        tUsername.StateActive.Border.Rounding = 10F
        tUsername.StateActive.Border.Width = 2
        tUsername.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(19, 165)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 14
        lblPassword.Text = "Password"
        lblPassword.Visible = False
        ' 
        ' tPassword
        ' 
        tPassword.CueHint.CueHintText = "Username"
        tPassword.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tPassword.Location = New Point(19, 183)
        tPassword.Name = "tPassword"
        tPassword.PasswordChar = "●"c
        tPassword.Size = New Size(420, 31)
        tPassword.StateActive.Border.Rounding = 10F
        tPassword.StateActive.Border.Width = 2
        tPassword.TabIndex = 4
        tPassword.UseSystemPasswordChar = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(331, 220)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 5
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' AddEditForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 314)
        ControlBox = False
        Controls.Add(chkShowPassword)
        Controls.Add(lblPassword)
        Controls.Add(tPassword)
        Controls.Add(Label3)
        Controls.Add(tUsername)
        Controls.Add(Label2)
        Controls.Add(tFirstName)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(tLastName)
        KeyPreview = True
        Name = "AddEditForm"
        StartPosition = FormStartPosition.CenterScreen
        StateActive.Back.Color1 = SystemColors.Control
        StateActive.Back.Color2 = SystemColors.Control
        StateActive.Border.Color1 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Border.Color2 = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        StateActive.Border.Rounding = 10F
        StateActive.Border.Width = 1
        StateActive.Header.Back.Color1 = SystemColors.Control
        StateActive.Header.Back.Color2 = SystemColors.Control
        Text = "AddEditForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Friend WithEvents tLastName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tFirstName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents tPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkShowPassword As CheckBox
End Class
