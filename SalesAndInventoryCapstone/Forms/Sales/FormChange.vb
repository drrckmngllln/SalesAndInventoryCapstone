Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Reporting.WinForms

Public Class FormChange
    Private referenceNo As String

    Private Property ReportViewer1 As ReportViewer

    Private ReadOnly DataSetName As String = "ReportDs"

    Private ReadOnly ReceiptRpt As String =
        IO.Path.Combine(Application.StartupPath, "Forms/Sales", "Receipt.rdlc")

    Public Sub New(total As Decimal, cashGiven As Decimal, saleReferenceNo As String)
        InitializeComponent()
        lblTotal.Text = total.ToString("C2")
        lblCash.Text = cashGiven.ToString("C2")
        lblChange.Text = (cashGiven - total).ToString("C2")

        referenceNo = saleReferenceNo
    End Sub

    'Async Function PrintReceipt() As Task
    '    Using ctx As New DataContext()
    '        Dim sale = Await ctx.Sales.FirstOrDefaultAsync(Function(s) s.ReferenceNumber = referenceNo)
    '        Dim saleItems = Await ctx.SaleItems.Where(Function(si) si.SaleId = sale.Id).ToListAsync()


    '        Dim rdsSale As New ReportDataSource(DataSetName, sale)
    '        Dim rdsSaleItems As New ReportDataSource(DataSetName, saleItems)

    '        ReportViewer1.LocalReport.DataSources.Clear()
    '        ReportViewer1.LocalReport.DataSources.Add(rdsSale)
    '        ReportViewer1.LocalReport.DataSources.Add(rdsSaleItems)
    '        ReportViewer1.LocalReport.ReportPath = ReceiptRpt

    '        ReportViewer1.RefreshReport()
    '        ReportViewer1.PrintDialog()
    '    End Using
    'End Function

    Async Function PrintReceipt() As Task
        Using ctx As New DataContext()
            Dim sale = Await ctx.Sales.
            FirstOrDefaultAsync(Function(s) s.ReferenceNumber = referenceNo)

            Dim saleItems = Await ctx.SaleItems.
            Where(Function(si) si.SaleId = sale.Id).
            ToListAsync()

            Dim rdsSale As New ReportDataSource("SaleReportDs", New List(Of Sale) From {sale})
            Dim rdsSaleItems As New ReportDataSource("SaleItemReportDs", saleItems)

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rdsSale)
            ReportViewer1.LocalReport.DataSources.Add(rdsSaleItems)

            ReportViewer1.LocalReport.ReportPath = ReceiptRpt

            ReportViewer1.RefreshReport()

            If (ReportViewer1.IsHandleCreated) Then
                AddHandler ReportViewer1.RenderingComplete, AddressOf ReportViewer1_RenderingComplete
            Else
                ' Handle the case where the handle is not created
                MessageBox.Show("ReportViewer handle is not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Using
    End Function


    Private Sub ReportViewer1_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs)
        RemoveHandler ReportViewer1.RenderingComplete, AddressOf ReportViewer1_RenderingComplete
        ReportViewer1.PrintDialog()
        ' Or if you want dialog:
        ' ReportViewer1.PrintDialog()
    End Sub



    Public Sub InitializeReport(hostPanel As Panel)
        Dim rptViewer As New ReportViewer()
        With rptViewer
            .Dock = DockStyle.Fill
            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = ReceiptRpt
        End With

        hostPanel.Controls.Clear()
        hostPanel.Controls.Add(rptViewer)

        ReportViewer1 = rptViewer
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Async Sub FormChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeReport(pnlRpt)
        Await PrintReceipt()
    End Sub

    Private Async Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        Await PrintReceipt()
    End Sub
End Class