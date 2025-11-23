<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecurityQuestion
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
        tUsername = New TextBox()
        Label1 = New Label()
        btnSearch = New Button()
        GroupBox1 = New GroupBox()
        cmbSecurityQuestion = New Krypton.Toolkit.KryptonComboBox()
        pnlMain = New Panel()
        GroupBox2 = New GroupBox()
        tAnswer = New Krypton.Toolkit.KryptonTextBox()
        GroupBox3 = New GroupBox()
        tNewPassword = New Krypton.Toolkit.KryptonTextBox()
        btnSubmit = New Button()
        GroupBox1.SuspendLayout()
        CType(cmbSecurityQuestion, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tUsername
        ' 
        tUsername.Location = New Point(111, 9)
        tUsername.Name = "tUsername"
        tUsername.Size = New Size(298, 23)
        tUsername.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter Username:"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(415, 9)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(167, 23)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbSecurityQuestion)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(570, 55)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Security Question"
        ' 
        ' cmbSecurityQuestion
        ' 
        cmbSecurityQuestion.DropDownWidth = 552
        cmbSecurityQuestion.Location = New Point(6, 22)
        cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        cmbSecurityQuestion.Size = New Size(558, 28)
        cmbSecurityQuestion.StateActive.ComboBox.Border.Rounding = 10F
        cmbSecurityQuestion.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        cmbSecurityQuestion.TabIndex = 0
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(GroupBox2)
        pnlMain.Controls.Add(GroupBox3)
        pnlMain.Controls.Add(btnSubmit)
        pnlMain.Controls.Add(GroupBox1)
        pnlMain.Location = New Point(12, 38)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(570, 265)
        pnlMain.TabIndex = 4
        pnlMain.Visible = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tAnswer)
        GroupBox2.Dock = DockStyle.Top
        GroupBox2.Location = New Point(0, 55)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(570, 95)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Answer"
        ' 
        ' tAnswer
        ' 
        tAnswer.Dock = DockStyle.Fill
        tAnswer.Location = New Point(3, 19)
        tAnswer.Multiline = True
        tAnswer.Name = "tAnswer"
        tAnswer.Size = New Size(564, 73)
        tAnswer.StateActive.Border.Rounding = 10F
        tAnswer.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(tNewPassword)
        GroupBox3.Location = New Point(0, 156)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(570, 59)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "New Password"
        ' 
        ' tNewPassword
        ' 
        tNewPassword.Dock = DockStyle.Top
        tNewPassword.Location = New Point(3, 19)
        tNewPassword.Name = "tNewPassword"
        tNewPassword.PasswordChar = "●"c
        tNewPassword.Size = New Size(564, 29)
        tNewPassword.StateActive.Border.Rounding = 10F
        tNewPassword.TabIndex = 0
        tNewPassword.UseSystemPasswordChar = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSubmit.Location = New Point(343, 221)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(224, 40)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' frmSecurityQuestion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 315)
        Controls.Add(pnlMain)
        Controls.Add(btnSearch)
        Controls.Add(Label1)
        Controls.Add(tUsername)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSecurityQuestion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSecurityQuestion"
        GroupBox1.ResumeLayout(False)
        CType(cmbSecurityQuestion, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbSecurityQuestion As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents tAnswer As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tNewPassword As Krypton.Toolkit.KryptonTextBox
End Class
