<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualSalesAdd
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
        dgv = New DataGridView()
        tSearch = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 52)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.Size = New Size(788, 386)
        dgv.TabIndex = 0
        ' 
        ' tSearch
        ' 
        tSearch.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        tSearch.Location = New Point(12, 12)
        tSearch.Name = "tSearch"
        tSearch.Size = New Size(788, 34)
        tSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 441)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 15)
        Label1.TabIndex = 2
        Label1.Text = "- Double click the grid to select"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 456)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 15)
        Label2.TabIndex = 3
        Label2.Text = "- Start typing to text box to search"
        ' 
        ' ManualSalesAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 493)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tSearch)
        Controls.Add(dgv)
        KeyPreview = True
        Name = "ManualSalesAdd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManualSalesAdd"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents tSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
