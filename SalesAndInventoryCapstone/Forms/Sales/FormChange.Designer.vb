<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChange
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblTotal = New Label()
        lblCash = New Label()
        lblChange = New Label()
        btnClose = New Button()
        btnPrintReceipt = New Button()
        pnlRpt = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 21)
        Label1.TabIndex = 0
        Label1.Text = "Total"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(12, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 21)
        Label2.TabIndex = 1
        Label2.Text = "Cash Tendered"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(12, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 2
        Label3.Text = "Change"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F)
        lblTotal.Location = New Point(166, 9)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(19, 21)
        lblTotal.TabIndex = 3
        lblTotal.Text = "..."
        ' 
        ' lblCash
        ' 
        lblCash.AutoSize = True
        lblCash.Font = New Font("Segoe UI", 12F)
        lblCash.Location = New Point(166, 40)
        lblCash.Name = "lblCash"
        lblCash.Size = New Size(19, 21)
        lblCash.TabIndex = 4
        lblCash.Text = "..."
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Segoe UI", 12F)
        lblChange.Location = New Point(166, 72)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(19, 21)
        lblChange.TabIndex = 5
        lblChange.Text = "..."
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 12F)
        btnClose.Location = New Point(12, 197)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(505, 42)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPrintReceipt
        ' 
        btnPrintReceipt.Font = New Font("Segoe UI", 12F)
        btnPrintReceipt.Location = New Point(12, 149)
        btnPrintReceipt.Name = "btnPrintReceipt"
        btnPrintReceipt.Size = New Size(505, 42)
        btnPrintReceipt.TabIndex = 7
        btnPrintReceipt.Text = "Print Receipt"
        btnPrintReceipt.UseVisualStyleBackColor = True
        ' 
        ' pnlRpt
        ' 
        pnlRpt.Location = New Point(641, 14)
        pnlRpt.Name = "pnlRpt"
        pnlRpt.Size = New Size(435, 225)
        pnlRpt.TabIndex = 8
        ' 
        ' FormChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(530, 251)
        ControlBox = False
        Controls.Add(pnlRpt)
        Controls.Add(btnPrintReceipt)
        Controls.Add(btnClose)
        Controls.Add(lblChange)
        Controls.Add(lblCash)
        Controls.Add(lblTotal)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "FormChange"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormChange"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents pnlRpt As Panel
End Class
