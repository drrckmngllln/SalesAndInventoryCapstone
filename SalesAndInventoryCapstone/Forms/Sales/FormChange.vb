Public Class FormChange
    Public Sub New(total As Decimal, cashGiven As Decimal)
        InitializeComponent()
        lblTotal.Text = total.ToString("C2")
        lblCash.Text = cashGiven.ToString("C2")
        lblChange.Text = (cashGiven - total).ToString("C2")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class