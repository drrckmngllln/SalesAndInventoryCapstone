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
        Panel2 = New Panel()
        dgv = New DataGridView()
        tSearch = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(GroupBox1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(928, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(416, 762)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(tSearch)
        Panel2.Controls.Add(dgv)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(928, 762)
        Panel2.TabIndex = 2
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 12)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.Size = New Size(899, 677)
        dgv.TabIndex = 0
        ' 
        ' tSearch
        ' 
        tSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tSearch.Location = New Point(12, 695)
        tSearch.Name = "tSearch"
        tSearch.Size = New Size(776, 25)
        tSearch.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(794, 695)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 25)
        Button1.TabIndex = 2
        Button1.Text = "Manual Enter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(6, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(398, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detail"
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1344, 762)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Sales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tSearch As TextBox
End Class
