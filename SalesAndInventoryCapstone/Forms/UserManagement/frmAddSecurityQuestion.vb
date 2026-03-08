Public Class frmAddSecurityQuestion
    Private ReadOnly securityQuestions As Dictionary(Of String, String) = Items
    Public ReadOnly Property SelectedSecurityQuestion As String
        Get
            If cmbSecurityQuestion.SelectedItem Is Nothing Then
                Return String.Empty
            End If

            Dim selectedPair = DirectCast(cmbSecurityQuestion.SelectedItem, KeyValuePair(Of String, String))
            Return selectedPair.Key
        End Get
    End Property

    Public ReadOnly Property SecurityAnswer As String
        Get
            Return tSecurityAnswer.Text.Trim()
        End Get
    End Property

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Sub LoadSecurityQuestions()
        cmbSecurityQuestion.DataSource = New BindingSource(securityQuestions, Nothing)
        cmbSecurityQuestion.DisplayMember = "Key"
        cmbSecurityQuestion.ValueMember = "Value"
    End Sub

    Private Sub frmAddSecurityQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSecurityQuestions()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(cmbSecurityQuestion.Text) OrElse
           String.IsNullOrWhiteSpace(tSecurityAnswer.Text) Then
            MsgBox("Security question and answer are required.")
            Return
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class