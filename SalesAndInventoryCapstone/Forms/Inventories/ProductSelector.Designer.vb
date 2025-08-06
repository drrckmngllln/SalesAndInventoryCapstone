<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSelector
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
        tCode = New Krypton.Toolkit.KryptonTextBox()
        dgv = New DataGridView()
        Label1 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tCode
        ' 
        tCode.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        tCode.Location = New Point(12, 12)
        tCode.Name = "tCode"
        tCode.Size = New Size(404, 31)
        tCode.StateActive.Border.Rounding = 10F
        tCode.StateActive.Border.Width = 2
        tCode.TabIndex = 12
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 49)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.Size = New Size(404, 333)
        dgv.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 385)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 15)
        Label1.TabIndex = 14
        Label1.Text = "Note: Double Click to select"
        ' 
        ' ProductSelector
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 411)
        Controls.Add(Label1)
        Controls.Add(dgv)
        Controls.Add(tCode)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ProductSelector"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProductSelector"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tCode As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
End Class
