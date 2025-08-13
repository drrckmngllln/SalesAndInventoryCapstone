<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditQuantity
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
        tQuantity = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' tQuantity
        ' 
        tQuantity.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        tQuantity.Location = New Point(12, 40)
        tQuantity.Name = "tQuantity"
        tQuantity.Size = New Size(356, 34)
        tQuantity.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 28)
        Label1.TabIndex = 1
        Label1.Text = "Set Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(206, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 19)
        Label2.TabIndex = 2
        Label2.Text = "Press Enter to Complete"
        ' 
        ' EditQuantity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 108)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tQuantity)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "EditQuantity"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditQuantity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
