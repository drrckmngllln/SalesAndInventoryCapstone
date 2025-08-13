Public Class EditQuantity
    ' Will hold the quantity after editing
    Public Property NewQuantity As Integer
    Public Property CurrentCode As String

    Public Sub New(currentCode As String, currentQty As Integer)
        InitializeComponent()
        tQuantity.Text = currentQty.ToString()
        currentCode = currentCode
    End Sub


    Private Sub EditQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewQuantity = CInt(tQuantity.Text)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
