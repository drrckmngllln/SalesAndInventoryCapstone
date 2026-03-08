<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSecurityQuestion
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
        cmbSecurityQuestion = New Krypton.Toolkit.KryptonComboBox()
        Label4 = New Label()
        tSecurityAnswer = New Krypton.Toolkit.KryptonRichTextBox()
        Label5 = New Label()
        btnCancel = New Krypton.Toolkit.KryptonButton()
        btnSave = New Krypton.Toolkit.KryptonButton()
        CType(cmbSecurityQuestion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbSecurityQuestion
        ' 
        cmbSecurityQuestion.DropDownWidth = 552
        cmbSecurityQuestion.Location = New Point(12, 30)
        cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        cmbSecurityQuestion.Size = New Size(418, 28)
        cmbSecurityQuestion.StateActive.ComboBox.Border.Rounding = 10F
        cmbSecurityQuestion.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        cmbSecurityQuestion.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 26
        Label4.Text = "Security Question"
        ' 
        ' tSecurityAnswer
        ' 
        tSecurityAnswer.Location = New Point(12, 79)
        tSecurityAnswer.Name = "tSecurityAnswer"
        tSecurityAnswer.Size = New Size(418, 83)
        tSecurityAnswer.StateActive.Border.Rounding = 10F
        tSecurityAnswer.TabIndex = 29
        tSecurityAnswer.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 28
        Label5.Text = "Security Answer"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(304, 168)
        btnCancel.Name = "btnCancel"
        btnCancel.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.OverrideDefault.Border.Color1 = SystemColors.Control
        btnCancel.OverrideDefault.Border.Color2 = SystemColors.Control
        btnCancel.Size = New Size(126, 33)
        btnCancel.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateCommon.Border.Rounding = 10F
        btnCancel.StateCommon.Border.Width = 2
        btnCancel.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnCancel.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnCancel.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateDisabled.Border.Color1 = SystemColors.Control
        btnCancel.StateDisabled.Border.Color2 = SystemColors.Control
        btnCancel.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateNormal.Border.Color1 = SystemColors.Control
        btnCancel.StateNormal.Border.Color2 = SystemColors.Control
        btnCancel.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StatePressed.Border.Color1 = SystemColors.Control
        btnCancel.StatePressed.Border.Color2 = SystemColors.Control
        btnCancel.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnCancel.TabIndex = 31
        btnCancel.Values.DropDownArrowColor = Color.Empty
        btnCancel.Values.Text = "Cancel"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(172, 168)
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
        btnSave.TabIndex = 30
        btnSave.Values.DropDownArrowColor = Color.Empty
        btnSave.Values.Text = "Save"
        ' 
        ' frmAddSecurityQuestion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(443, 210)
        ControlBox = False
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(tSecurityAnswer)
        Controls.Add(Label5)
        Controls.Add(cmbSecurityQuestion)
        Controls.Add(Label4)
        Name = "frmAddSecurityQuestion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Security Question"
        CType(cmbSecurityQuestion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbSecurityQuestion As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tSecurityAnswer As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As Krypton.Toolkit.KryptonButton
End Class
