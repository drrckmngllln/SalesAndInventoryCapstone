Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Reporting.WinForms
Imports ZstdSharp.Unsafe

Public Class ReportForm

    Private ReadOnly DataSetName As String = "ReportDs"
    Private ReadOnly SaleReportPath As String =
        IO.Path.Combine(Application.StartupPath, "Forms/Reports", "MonthlyReport.rdlc")
    Private ReadOnly SaleItemReportPath As String =
        IO.Path.Combine(Application.StartupPath, "Forms/Reports", "SaleItemReport.rdlc")

    ' Keep only this - don’t create another ReportForm inside itself
    Private Property ReportViewer1 As ReportViewer

    ' Initialize and embed ReportViewer inside a Panel
    Public Sub InitializeReport(hostPanel As Panel)
        Dim rptViewer As New ReportViewer()
        With rptViewer
            .Dock = DockStyle.Fill
            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = SaleReportPath
            .SetDisplayMode(DisplayMode.PrintLayout)
        End With

        hostPanel.Controls.Clear()
        hostPanel.Controls.Add(rptViewer)

        ReportViewer1 = rptViewer
    End Sub

    Private Async Sub ReportForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await GetCategoriesAsync()
    End Sub

    ' Async loader for sales data
    Public Async Function LoadSalesDataAsync(fromDate As DateTime, toDate As DateTime) As Task
        Using ctx As New DataContext()
            Dim salesInRange = Await ctx.Sales _
                .Where(Function(s) s.CreatedAt >= fromDate AndAlso s.CreatedAt <= toDate) _
                .Select(Function(s) New With {
                    .ReferenceNumber = s.ReferenceNumber,
                    .CreatedAt = s.CreatedAt,
                    .TotalSales = s.TotalSales,
                    .CashGiven = s.CashGiven,
                    .LastName = s.LastName,
                    .FirstName = s.FirstName,
                    .MiddleName = s.MiddleName,
                    .OriginalPrice = s.OriginalPrice,
                    .SellingPrice = s.SellingPrice,
                    .Profit = s.Profit
                }) _
                .OrderBy(Function(s) s.CreatedAt) _
                .ToListAsync()

            Dim rds As New ReportDataSource(DataSetName, salesInRange)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.ReportPath = SaleReportPath

            ReportViewer1.RefreshReport()
        End Using
    End Function

    Async Function LoadSaleItemsAsync(fromDate As DateTime, toDate As DateTime, category As String) As Task
        Using ctx As New DataContext()
            Dim saleItemsInRange = Await ctx.SaleItemViews _
                .Where(Function(si) si.CreatedAt >= fromDate AndAlso si.CreatedAt <= toDate AndAlso category = si.Category) _
                .Select(Function(si) New With {
                    .Id = si.Id,
                    .CreatedAt = si.CreatedAt,
                    .ReferenceNo = si.ReferenceNo,
                    .ProductName = si.ProductName,
                    .Category = si.Category,
                    .Quantity = si.Quantity,
                    .Price = si.Price,
                    .OriginalPrice = si.OriginalPrice,
                    .SellingPrice = si.SellingPrice,
                    .Profit = si.Profit
                }) _
                .OrderBy(Function(si) si.ReferenceNo) _
                .ToListAsync()
            Dim rds As New ReportDataSource(DataSetName, saleItemsInRange)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.ReportPath = SaleItemReportPath
            ReportViewer1.RefreshReport()
        End Using
    End Function

    Async Function GetCategoriesAsync() As Task
        Using ctx As New DataContext()
            Dim categories = Await ctx.Categories.ToListAsync()

            cmbCategory.DisplayMember = "Name"
            cmbCategory.ValueMember = "Id"
            cmbCategory.DataSource = categories
        End Using
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitializeReport(pnlSaleReport)

        Await LoadSalesDataAsync(dateFrom.Value.Date, dateTo.Value.Date)
    End Sub

    Private Async Sub btnSIFilter_Click(sender As Object, e As EventArgs) Handles btnSIFilter.Click
        InitializeReport(pnlSIReport)

        Await LoadSaleItemsAsync(dateFrom.Value.Date, dateTo.Value.Date, cmbCategory.Text)
    End Sub
End Class
