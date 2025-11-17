Imports Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryAEForm
    'Inherits System.Windows.Forms.Form
    Inherits KryptonForm


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
        tName = New KryptonTextBox()
        btnNew = New KryptonButton()
        Label1 = New Label()
        btnCancel = New KryptonButton()
        SuspendLayout()
        ' 
        ' tName
        ' 
        tName.CueHint.Hint = PaletteTextHint.ClearTypeGridFit
        tName.Location = New Point(12, 27)
        tName.Name = "tName"
        tName.Size = New Size(420, 31)
        tName.StateActive.Border.Rounding = 10F
        tName.StateActive.Border.Width = 2
        tName.TabIndex = 1
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(174, 64)
        btnNew.Name = "btnNew"
        btnNew.OverrideDefault.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.OverrideDefault.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.OverrideDefault.Border.Color1 = SystemColors.Control
        btnNew.OverrideDefault.Border.Color2 = SystemColors.Control
        btnNew.Size = New Size(126, 33)
        btnNew.StateCommon.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateCommon.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateCommon.Border.Rounding = 10F
        btnNew.StateCommon.Border.Width = 2
        btnNew.StateCommon.Content.ShortText.Color1 = SystemColors.Control
        btnNew.StateCommon.Content.ShortText.Color2 = SystemColors.Control
        btnNew.StateCommon.Content.ShortText.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.StateDisabled.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateDisabled.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateDisabled.Border.Color1 = SystemColors.Control
        btnNew.StateDisabled.Border.Color2 = SystemColors.Control
        btnNew.StateNormal.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateNormal.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateNormal.Border.Color1 = SystemColors.Control
        btnNew.StateNormal.Border.Color2 = SystemColors.Control
        btnNew.StatePressed.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StatePressed.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StatePressed.Border.Color1 = SystemColors.Control
        btnNew.StatePressed.Border.Color2 = SystemColors.Control
        btnNew.StateTracking.Back.Color1 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.StateTracking.Back.Color2 = Color.FromArgb(CByte(0), CByte(0), CByte(50))
        btnNew.TabIndex = 4
        btnNew.Values.DropDownArrowColor = Color.Empty
        btnNew.Values.Text = "Save"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 15)
        Label1.TabIndex = 5
        Label1.Text = "Category Name"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(306, 64)
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
        btnCancel.TabIndex = 6
        btnCancel.Values.DropDownArrowColor = Color.Empty
        btnCancel.Values.Text = "Cancel"
        ' 
        ' CategoryAEForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(448, 93)
        ControlBox = False
        Controls.Add(btnCancel)
        Controls.Add(Label1)
        Controls.Add(btnNew)
        Controls.Add(tName)
        KeyPreview = True
        Name = "CategoryAEForm"
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

    Friend WithEvents tName As KryptonTextBox
    Friend WithEvents btnNew As KryptonButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As KryptonButton
End Class
