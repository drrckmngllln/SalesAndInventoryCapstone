<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        dateFrom = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        dateTo = New DateTimePicker()
        pnlReport = New Panel()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' dateFrom
        ' 
        dateFrom.Location = New Point(56, 15)
        dateFrom.Name = "dateFrom"
        dateFrom.Size = New Size(224, 23)
        dateFrom.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 2
        Label1.Text = "From:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(301, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 15)
        Label2.TabIndex = 4
        Label2.Text = "To:"
        ' 
        ' dateTo
        ' 
        dateTo.Location = New Point(330, 15)
        dateTo.Name = "dateTo"
        dateTo.Size = New Size(224, 23)
        dateTo.TabIndex = 3
        ' 
        ' pnlReport
        ' 
        pnlReport.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlReport.Location = New Point(12, 44)
        pnlReport.Name = "pnlReport"
        pnlReport.Size = New Size(989, 564)
        pnlReport.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(560, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(215, 23)
        Button1.TabIndex = 6
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1013, 620)
        Controls.Add(Button1)
        Controls.Add(pnlReport)
        Controls.Add(Label2)
        Controls.Add(dateTo)
        Controls.Add(Label1)
        Controls.Add(dateFrom)
        Name = "ReportForm"
        Text = "Report"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents pnlReport As Panel
    Friend WithEvents Button1 As Button
End Class
