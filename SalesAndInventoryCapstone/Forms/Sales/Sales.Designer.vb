<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        pnlCheckout = New Panel()
        GroupBox3 = New GroupBox()
        lReferenceNo = New Label()
        GroupBox7 = New GroupBox()
        tCash = New TextBox()
        GroupBox4 = New GroupBox()
        tLastName = New TextBox()
        GroupBox5 = New GroupBox()
        tFirstName = New TextBox()
        GroupBox6 = New GroupBox()
        tMiddleName = New TextBox()
        btnConfirmCheckout = New Button()
        btnCheckout = New Button()
        GroupBox1 = New GroupBox()
        ltotal = New Label()
        Panel2 = New Panel()
        btnManualAdd = New Button()
        tSearch = New TextBox()
        dgv = New DataGridView()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        pnlCheckout.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(pnlCheckout)
        Panel1.Controls.Add(btnConfirmCheckout)
        Panel1.Controls.Add(btnCheckout)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(928, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(416, 671)
        Panel1.TabIndex = 1
        ' 
        ' pnlCheckout
        ' 
        pnlCheckout.Controls.Add(GroupBox3)
        pnlCheckout.Controls.Add(GroupBox7)
        pnlCheckout.Controls.Add(GroupBox4)
        pnlCheckout.Controls.Add(GroupBox5)
        pnlCheckout.Controls.Add(GroupBox6)
        pnlCheckout.Location = New Point(9, 118)
        pnlCheckout.Name = "pnlCheckout"
        pnlCheckout.Size = New Size(395, 304)
        pnlCheckout.TabIndex = 7
        pnlCheckout.Visible = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lReferenceNo)
        GroupBox3.ForeColor = SystemColors.Control
        GroupBox3.Location = New Point(6, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(386, 54)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Reference Number"
        GroupBox3.UseWaitCursor = True
        ' 
        ' lReferenceNo
        ' 
        lReferenceNo.Dock = DockStyle.Fill
        lReferenceNo.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lReferenceNo.Location = New Point(3, 19)
        lReferenceNo.Name = "lReferenceNo"
        lReferenceNo.Size = New Size(380, 32)
        lReferenceNo.TabIndex = 1
        lReferenceNo.Text = "---"
        lReferenceNo.TextAlign = ContentAlignment.BottomRight
        lReferenceNo.UseWaitCursor = True
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(tCash)
        GroupBox7.ForeColor = SystemColors.Control
        GroupBox7.Location = New Point(6, 243)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(386, 54)
        GroupBox7.TabIndex = 6
        GroupBox7.TabStop = False
        GroupBox7.Text = "Cash"
        ' 
        ' tCash
        ' 
        tCash.Dock = DockStyle.Fill
        tCash.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tCash.Location = New Point(3, 19)
        tCash.Name = "tCash"
        tCash.Size = New Size(380, 25)
        tCash.TabIndex = 2
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(tLastName)
        GroupBox4.ForeColor = SystemColors.Control
        GroupBox4.Location = New Point(6, 63)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(386, 54)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Last Name"
        ' 
        ' tLastName
        ' 
        tLastName.Dock = DockStyle.Fill
        tLastName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tLastName.Location = New Point(3, 19)
        tLastName.Name = "tLastName"
        tLastName.Size = New Size(380, 25)
        tLastName.TabIndex = 2
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(tFirstName)
        GroupBox5.ForeColor = SystemColors.Control
        GroupBox5.Location = New Point(6, 123)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(386, 54)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "First Name"
        ' 
        ' tFirstName
        ' 
        tFirstName.Dock = DockStyle.Fill
        tFirstName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tFirstName.Location = New Point(3, 19)
        tFirstName.Name = "tFirstName"
        tFirstName.Size = New Size(380, 25)
        tFirstName.TabIndex = 2
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(tMiddleName)
        GroupBox6.ForeColor = SystemColors.Control
        GroupBox6.Location = New Point(6, 183)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(386, 54)
        GroupBox6.TabIndex = 5
        GroupBox6.TabStop = False
        GroupBox6.Text = "Middle Name"
        ' 
        ' tMiddleName
        ' 
        tMiddleName.Dock = DockStyle.Fill
        tMiddleName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tMiddleName.Location = New Point(3, 19)
        tMiddleName.Name = "tMiddleName"
        tMiddleName.Size = New Size(380, 25)
        tMiddleName.TabIndex = 2
        ' 
        ' btnConfirmCheckout
        ' 
        btnConfirmCheckout.Font = New Font("Segoe UI", 12F)
        btnConfirmCheckout.Location = New Point(15, 428)
        btnConfirmCheckout.Name = "btnConfirmCheckout"
        btnConfirmCheckout.Size = New Size(386, 38)
        btnConfirmCheckout.TabIndex = 4
        btnConfirmCheckout.Text = "Confirm Checkout"
        btnConfirmCheckout.UseVisualStyleBackColor = True
        btnConfirmCheckout.Visible = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Font = New Font("Segoe UI", 12F)
        btnCheckout.Location = New Point(9, 74)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(392, 38)
        btnCheckout.TabIndex = 3
        btnCheckout.Text = "Proceed to Checkout"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ltotal)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(6, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(398, 56)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total"
        ' 
        ' ltotal
        ' 
        ltotal.Dock = DockStyle.Fill
        ltotal.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        ltotal.Location = New Point(3, 19)
        ltotal.Name = "ltotal"
        ltotal.Size = New Size(392, 34)
        ltotal.TabIndex = 0
        ltotal.Text = "00.0"
        ltotal.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(GroupBox2)
        Panel2.Controls.Add(btnManualAdd)
        Panel2.Controls.Add(tSearch)
        Panel2.Controls.Add(dgv)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(928, 671)
        Panel2.TabIndex = 2
        ' 
        ' btnManualAdd
        ' 
        btnManualAdd.Location = New Point(794, 472)
        btnManualAdd.Name = "btnManualAdd"
        btnManualAdd.Size = New Size(117, 25)
        btnManualAdd.TabIndex = 2
        btnManualAdd.Text = "Manual Enter"
        btnManualAdd.UseVisualStyleBackColor = True
        ' 
        ' tSearch
        ' 
        tSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tSearch.Location = New Point(92, 472)
        tSearch.Name = "tSearch"
        tSearch.Size = New Size(696, 25)
        tSearch.TabIndex = 1
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 12)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.Size = New Size(899, 454)
        dgv.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(12, 587)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 74)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hints"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 15)
        Label1.TabIndex = 0
        Label1.Text = "- Press Enter when Entering Code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 477)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 4
        Label2.Text = "Enter Code:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(260, 15)
        Label3.TabIndex = 1
        Label3.Text = "- Double Click the Data Grid To Update Quantity"
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1344, 671)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Sales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales"
        Panel1.ResumeLayout(False)
        pnlCheckout.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnManualAdd As Button
    Friend WithEvents tSearch As TextBox
    Friend WithEvents ltotal As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents tCash As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents tMiddleName As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tFirstName As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tLastName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lReferenceNo As Label
    Friend WithEvents btnConfirmCheckout As Button
    Friend WithEvents pnlCheckout As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
