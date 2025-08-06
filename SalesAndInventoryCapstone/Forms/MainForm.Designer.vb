Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel2 = New Panel()
        btnLogout = New Button()
        ImageList1 = New ImageList(components)
        btnReport = New Button()
        btnSales = New Button()
        btnProducts = New Button()
        btnUserManagement = New Button()
        btnCategories = New Button()
        btnDashboard = New Button()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        lblTitle = New Label()
        pnlMain = New Panel()
        btnInventory = New Button()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnInventory)
        Panel2.Controls.Add(btnLogout)
        Panel2.Controls.Add(btnReport)
        Panel2.Controls.Add(btnSales)
        Panel2.Controls.Add(btnProducts)
        Panel2.Controls.Add(btnUserManagement)
        Panel2.Controls.Add(btnCategories)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(238, 769)
        Panel2.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnLogout.ForeColor = SystemColors.Control
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.ImageKey = "exit.png"
        btnLogout.ImageList = ImageList1
        btnLogout.Location = New Point(0, 737)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(30, 0, 0, 0)
        btnLogout.Size = New Size(238, 32)
        btnLogout.TabIndex = 8
        btnLogout.Text = "     Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "dashboard.png")
        ImageList1.Images.SetKeyName(1, "report.png")
        ImageList1.Images.SetKeyName(2, "discount.png")
        ImageList1.Images.SetKeyName(3, "engine.png")
        ImageList1.Images.SetKeyName(4, "user.png")
        ImageList1.Images.SetKeyName(5, "file.png")
        ImageList1.Images.SetKeyName(6, "exit.png")
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnReport.Dock = DockStyle.Top
        btnReport.FlatAppearance.BorderSize = 0
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnReport.ForeColor = SystemColors.Control
        btnReport.ImageAlign = ContentAlignment.MiddleLeft
        btnReport.ImageKey = "report.png"
        btnReport.ImageList = ImageList1
        btnReport.Location = New Point(0, 387)
        btnReport.Name = "btnReport"
        btnReport.Padding = New Padding(30, 0, 0, 0)
        btnReport.Size = New Size(238, 32)
        btnReport.TabIndex = 7
        btnReport.Text = "     Report"
        btnReport.TextAlign = ContentAlignment.MiddleLeft
        btnReport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' btnSales
        ' 
        btnSales.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnSales.Dock = DockStyle.Top
        btnSales.FlatAppearance.BorderSize = 0
        btnSales.FlatStyle = FlatStyle.Flat
        btnSales.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSales.ForeColor = SystemColors.Control
        btnSales.ImageAlign = ContentAlignment.MiddleLeft
        btnSales.ImageKey = "discount.png"
        btnSales.ImageList = ImageList1
        btnSales.Location = New Point(0, 355)
        btnSales.Name = "btnSales"
        btnSales.Padding = New Padding(30, 0, 0, 0)
        btnSales.Size = New Size(238, 32)
        btnSales.TabIndex = 6
        btnSales.Text = "     Sales"
        btnSales.TextAlign = ContentAlignment.MiddleLeft
        btnSales.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSales.UseVisualStyleBackColor = False
        ' 
        ' btnProducts
        ' 
        btnProducts.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnProducts.Dock = DockStyle.Top
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnProducts.ForeColor = SystemColors.Control
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft
        btnProducts.ImageKey = "engine.png"
        btnProducts.ImageList = ImageList1
        btnProducts.Location = New Point(0, 323)
        btnProducts.Name = "btnProducts"
        btnProducts.Padding = New Padding(30, 0, 0, 0)
        btnProducts.Size = New Size(238, 32)
        btnProducts.TabIndex = 4
        btnProducts.Text = "     Products"
        btnProducts.TextAlign = ContentAlignment.MiddleLeft
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProducts.UseVisualStyleBackColor = False
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnUserManagement.Dock = DockStyle.Top
        btnUserManagement.FlatAppearance.BorderSize = 0
        btnUserManagement.FlatStyle = FlatStyle.Flat
        btnUserManagement.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUserManagement.ForeColor = SystemColors.Control
        btnUserManagement.ImageAlign = ContentAlignment.MiddleLeft
        btnUserManagement.ImageKey = "user.png"
        btnUserManagement.ImageList = ImageList1
        btnUserManagement.Location = New Point(0, 291)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Padding = New Padding(30, 0, 0, 0)
        btnUserManagement.Size = New Size(238, 32)
        btnUserManagement.TabIndex = 3
        btnUserManagement.Text = "     User Management"
        btnUserManagement.TextAlign = ContentAlignment.MiddleLeft
        btnUserManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUserManagement.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnCategories.Dock = DockStyle.Top
        btnCategories.FlatAppearance.BorderSize = 0
        btnCategories.FlatStyle = FlatStyle.Flat
        btnCategories.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCategories.ForeColor = SystemColors.Control
        btnCategories.ImageAlign = ContentAlignment.MiddleLeft
        btnCategories.ImageKey = "file.png"
        btnCategories.ImageList = ImageList1
        btnCategories.Location = New Point(0, 259)
        btnCategories.Name = "btnCategories"
        btnCategories.Padding = New Padding(30, 0, 0, 0)
        btnCategories.Size = New Size(238, 32)
        btnCategories.TabIndex = 2
        btnCategories.Text = "     Categories"
        btnCategories.TextAlign = ContentAlignment.MiddleLeft
        btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCategories.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDashboard.ForeColor = SystemColors.Control
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.ImageKey = "dashboard.png"
        btnDashboard.ImageList = ImageList1
        btnDashboard.Location = New Point(0, 227)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(30, 0, 0, 0)
        btnDashboard.Size = New Size(238, 32)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "     Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(lblTitle)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(238, 227)
        Panel3.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.tractor
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(229, 114)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTitle.ForeColor = SystemColors.Control
        lblTitle.Location = New Point(3, 120)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(232, 59)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Label1"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlMain
        ' 
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(238, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1045, 769)
        pnlMain.TabIndex = 2
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnInventory.Dock = DockStyle.Top
        btnInventory.FlatAppearance.BorderSize = 0
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnInventory.ForeColor = SystemColors.Control
        btnInventory.ImageAlign = ContentAlignment.MiddleLeft
        btnInventory.ImageKey = "engine.png"
        btnInventory.ImageList = ImageList1
        btnInventory.Location = New Point(0, 419)
        btnInventory.Name = "btnInventory"
        btnInventory.Padding = New Padding(30, 0, 0, 0)
        btnInventory.Size = New Size(238, 32)
        btnInventory.TabIndex = 5
        btnInventory.Text = "     Inventories"
        btnInventory.TextAlign = ContentAlignment.MiddleLeft
        btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(1283, 769)
        ControlBox = False
        Controls.Add(pnlMain)
        Controls.Add(Panel2)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales and Inventory System of Repear Parts and Machineries at Agri Top Solana, Cagayan"
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)



    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCategories As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInventory As Button
End Class
