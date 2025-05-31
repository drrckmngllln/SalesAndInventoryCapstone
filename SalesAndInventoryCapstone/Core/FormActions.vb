Module FormActions
    Public appTitle As String = "Sales and Inventory System of Repear Parts and Machineries at Agri Top Solana, Cagayan"

    Public Sub LoadUI(parentForm As Panel, childForm As Form)
        parentForm.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        parentForm.Controls.Add(childForm)
        childForm.Show()
    End Sub

End Module
