Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Reporting.WinForms

Public Class Report

    Async Function LoadSalesDataAsync(fromDate As DateTime, toDate As DateTime) As Task(Of List(Of Sale))

        Using ctx As New DataContext()
            Dim salesInRange = Await ctx.Sales _
            .Where(Function(s) s.CreatedAt >= fromDate AndAlso s.CreatedAt <= toDate) _
            .Select(Function(s) New With {
                .ReferenceNumber = s.ReferenceNumber,
                .CreatedAt = s.CreatedAt,
                .TotalSales = s.TotalSales,
                .OriginalPrice = s.OriginalPrice,
                .SellingPrice = s.SellingPrice,
                .Profit = s.Profit
            }) _
            .OrderBy(Function(s) s.CreatedAt) _
            .ToListAsync()

            ' Bind to ReportViewer
            Dim rds As New ReportDataSource("SalesDataSet", salesInRange)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.ReportPath = "SalesReport.rdlc"

            ' Pass the date range to report as parameters (optional)
            Dim parameters As New List(Of ReportParameter) From {
            New ReportParameter("FromDate", fromDate.ToString("yyyy-MM-dd")),
            New ReportParameter("ToDate", toDate.ToString("yyyy-MM-dd"))
        }
            ReportViewer1.LocalReport.SetParameters(parameters)

            ReportViewer1.RefreshReport()
        End Using
    End Function

End Class