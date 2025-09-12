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
        pnlSaleReport = New Panel()
        Button1 = New Button()
        Label3 = New Label()
        pnlSaleIemReport = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        btnSIFilter = New Button()
        Label4 = New Label()
        Label5 = New Label()
        dateSIStart = New DateTimePicker()
        cmbCategory = New ComboBox()
        dateSIEnd = New DateTimePicker()
        Label6 = New Label()
        pnlSIReport = New Panel()
        pnlSaleIemReport.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dateFrom
        ' 
        dateFrom.Location = New Point(50, 4)
        dateFrom.Name = "dateFrom"
        dateFrom.Size = New Size(212, 23)
        dateFrom.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 2
        Label1.Text = "From:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(295, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 15)
        Label2.TabIndex = 4
        Label2.Text = "To:"
        ' 
        ' dateTo
        ' 
        dateTo.Location = New Point(324, 4)
        dateTo.Name = "dateTo"
        dateTo.Size = New Size(224, 23)
        dateTo.TabIndex = 3
        ' 
        ' pnlSaleReport
        ' 
        pnlSaleReport.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSaleReport.Location = New Point(6, 33)
        pnlSaleReport.Name = "pnlSaleReport"
        pnlSaleReport.Size = New Size(1425, 551)
        pnlSaleReport.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(618, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 23)
        Button1.TabIndex = 6
        Button1.Text = "Filter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(554, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 8
        Label3.Text = "Category:"
        ' 
        ' pnlSaleIemReport
        ' 
        pnlSaleIemReport.Controls.Add(TabPage1)
        pnlSaleIemReport.Controls.Add(TabPage2)
        pnlSaleIemReport.Dock = DockStyle.Fill
        pnlSaleIemReport.Location = New Point(0, 0)
        pnlSaleIemReport.Name = "pnlSaleIemReport"
        pnlSaleIemReport.SelectedIndex = 0
        pnlSaleIemReport.Size = New Size(1447, 620)
        pnlSaleIemReport.TabIndex = 9
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(dateFrom)
        TabPage1.Controls.Add(dateTo)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(pnlSaleReport)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1439, 592)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Sale Reports"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnSIFilter)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(dateSIStart)
        TabPage2.Controls.Add(cmbCategory)
        TabPage2.Controls.Add(dateSIEnd)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(pnlSIReport)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1439, 592)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Sale Item Reports"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnSIFilter
        ' 
        btnSIFilter.Location = New Point(852, 6)
        btnSIFilter.Name = "btnSIFilter"
        btnSIFilter.Size = New Size(79, 23)
        btnSIFilter.TabIndex = 14
        btnSIFilter.Text = "Filter"
        btnSIFilter.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 10
        Label4.Text = "From:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(555, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 16
        Label5.Text = "Category:"
        ' 
        ' dateSIStart
        ' 
        dateSIStart.Location = New Point(51, 6)
        dateSIStart.Name = "dateSIStart"
        dateSIStart.Size = New Size(212, 23)
        dateSIStart.TabIndex = 9
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(619, 6)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(227, 23)
        cmbCategory.TabIndex = 15
        ' 
        ' dateSIEnd
        ' 
        dateSIEnd.Location = New Point(325, 6)
        dateSIEnd.Name = "dateSIEnd"
        dateSIEnd.Size = New Size(224, 23)
        dateSIEnd.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(296, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(23, 15)
        Label6.TabIndex = 12
        Label6.Text = "To:"
        ' 
        ' pnlSIReport
        ' 
        pnlSIReport.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSIReport.Location = New Point(7, 35)
        pnlSIReport.Name = "pnlSIReport"
        pnlSIReport.Size = New Size(1425, 551)
        pnlSIReport.TabIndex = 13
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1447, 620)
        Controls.Add(pnlSaleIemReport)
        Name = "ReportForm"
        Text = "Report"
        pnlSaleIemReport.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents pnlSaleReport As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlSaleIemReport As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnSIFilter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dateSIStart As DateTimePicker
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents dateSIEnd As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlSIReport As Panel
End Class
