Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Reporting.WinForms

Public Class FormChange
    Private referenceNo As String
    Private _transactionCompleted As Boolean

    Private Property ReportViewer1 As ReportViewer
    Public ReadOnly Property TransactionCompleted As Boolean
        Get
            Return _transactionCompleted
        End Get
    End Property

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

    Async Function PrintReceipt() As Task
        Using ctx As New DataContext()
            Dim sale = Await ctx.Sales.
            FirstOrDefaultAsync(Function(s) s.ReferenceNumber = referenceNo)

            Dim saleItems = Await ctx.SaleItemViews.
            Where(Function(si) si.SaleId = sale.Id).Select(Function(s) New With {
                .Id = s.Id,
                .SaleId = s.SaleId,
                .ReferenceNo = s.ReferenceNo,
                .ProductName = s.ProductName,
                .Quantity = s.Quantity,
                .Price = s.Price,
                .OriginalPrice = s.OriginalPrice,
                .SellingPrice = s.SellingPrice,
                .Profit = s.Profit,
                .Total = (s.Price * s.Quantity).ToString("F2")
            }) _
            .ToListAsync()

            Dim rdsSale As New ReportDataSource("SaleReportDs", New List(Of Object) From {sale})
            Dim rdsSaleItems As New ReportDataSource("SaleItemReportDs", saleItems)

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rdsSale)
            ReportViewer1.LocalReport.DataSources.Add(rdsSaleItems)

            ReportViewer1.LocalReport.ReportPath = ReceiptRpt

            RemoveHandler ReportViewer1.RenderingComplete, AddressOf ReportViewer1_RenderingComplete
            AddHandler ReportViewer1.RenderingComplete, AddressOf ReportViewer1_RenderingComplete

            ReportViewer1.RefreshReport()

            If Not ReportViewer1.IsHandleCreated Then
                ' Handle the case where the handle is not created
                MessageBox.Show("ReportViewer handle is not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Using
    End Function


    Private Sub ReportViewer1_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs)
        RemoveHandler ReportViewer1.RenderingComplete, AddressOf ReportViewer1_RenderingComplete
        BeginInvoke(New Action(AddressOf ShowPrintDialogAndCompleteTransaction))
    End Sub

    Private Sub ShowPrintDialogAndCompleteTransaction()
        If IsDisposed OrElse ReportViewer1 Is Nothing OrElse ReportViewer1.IsDisposed Then Return

        Try
            ReportViewer1.PrintDialog()
            CompleteTransaction()
        Catch ex As InvalidOperationException
            MessageBox.Show("The receipt is not ready to print yet. Please try again.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CompleteTransaction()
        If _transactionCompleted Then Return

        _transactionCompleted = True
        MessageBox.Show("Transaction complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub



    Public Sub InitializeReport(hostPanel As Panel)
        Dim rptViewer As New ReportViewer()
        With rptViewer
            .Dock = DockStyle.Fill
            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = ReceiptRpt
            .SetDisplayMode(DisplayMode.PrintLayout)
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
