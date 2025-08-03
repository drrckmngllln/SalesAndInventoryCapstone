<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStockForm
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
        tStock = New TextBox()
        btnAdd = New Button()
        btnCancel = New Button()
        lProductName = New Label()
        SuspendLayout()
        ' 
        ' tStock
        ' 
        tStock.Location = New Point(12, 57)
        tStock.Name = "tStock"
        tStock.Size = New Size(244, 23)
        tStock.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 86)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(72, 28)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add Stock"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(184, 86)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(72, 28)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lProductName
        ' 
        lProductName.AutoSize = True
        lProductName.Location = New Point(12, 9)
        lProductName.Name = "lProductName"
        lProductName.Size = New Size(16, 15)
        lProductName.TabIndex = 3
        lProductName.Text = "..."
        ' 
        ' AddStockForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(268, 126)
        ControlBox = False
        Controls.Add(lProductName)
        Controls.Add(btnCancel)
        Controls.Add(btnAdd)
        Controls.Add(tStock)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "AddStockForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Enter Stock"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tStock As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lProductName As Label
End Class
