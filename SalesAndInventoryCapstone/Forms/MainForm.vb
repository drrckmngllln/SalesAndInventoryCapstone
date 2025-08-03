Public Class MainForm
#Region "Custom Functions"
    'This function loads initially then the main form is loaded
    Sub DefaultLoad()
        LoadUI(pnlMain, New Dashboard)
        ButtonSelector("dashboard")
        lblTitle.Text = appTitle
    End Sub

    'This function modifies the color of the sidebar menu when selected
    Sub ButtonSelector(Optional selectedButton As String = "dashboard")
        Dim defaultColor As Color = Color.FromArgb(30, 30, 30)
        Dim selectedColor As Color = Color.FromArgb(80, 80, 80)

        btnDashboard.BackColor = defaultColor
        btnCategories.BackColor = defaultColor
        btnUserManagement.BackColor = defaultColor
        btnProducts.BackColor = defaultColor
        btnSales.BackColor = defaultColor
        btnReport.BackColor = defaultColor

        Select Case selectedButton.ToLower()
            Case "dashboard"
                btnDashboard.BackColor = selectedColor
            Case "categories"
                btnCategories.BackColor = selectedColor
            Case "usermanagement"
                btnUserManagement.BackColor = selectedColor
            Case "products"
                btnProducts.BackColor = selectedColor
            Case "sales"
                btnSales.BackColor = selectedColor
            Case "report"
                btnReport.BackColor = selectedColor
        End Select
    End Sub
#End Region

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefaultLoad()
    End Sub

    'This function loads the dashboard form
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadUI(pnlMain, New Dashboard)
        ButtonSelector("dashboard")
    End Sub

    'this function loads the categories form
    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        LoadUI(pnlMain, New Categories)
        ButtonSelector("categories")
    End Sub

    'this function loads the user management form
    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        LoadUI(pnlMain, New UserManagement)
        ButtonSelector("usermanagement")
    End Sub

    'this function loads the products form
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        LoadUI(pnlMain, New Products)
        ButtonSelector("products")
    End Sub

    'this function loads the sales form
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        'LoadUI(pnlMain, New Sales)
        'ButtonSelector("sales")
        Dim frm As New Sales()
        frm.Text = "Sales"
        frm.ShowDialog()
    End Sub

    'this function loads the report form
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        LoadUI(pnlMain, New Report)
        ButtonSelector("report")
    End Sub

    'this function logs out the session and go back to the login form
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub
End Class