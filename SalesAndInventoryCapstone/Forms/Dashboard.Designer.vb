<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        lSales = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        lInventory = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        lProducts = New Label()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(lSales)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(327, 175)
        Panel1.TabIndex = 0
        ' 
        ' lSales
        ' 
        lSales.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lSales.ForeColor = SystemColors.Control
        lSales.Location = New Point(15, 141)
        lSales.Name = "lSales"
        lSales.Size = New Size(298, 21)
        lSales.TabIndex = 1
        lSales.Text = "00"
        lSales.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(15, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 26)
        Label1.TabIndex = 0
        Label1.Text = "Sales"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel2.Controls.Add(lInventory)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(352, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(327, 175)
        Panel2.TabIndex = 1
        ' 
        ' lInventory
        ' 
        lInventory.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lInventory.ForeColor = SystemColors.Control
        lInventory.Location = New Point(15, 141)
        lInventory.Name = "lInventory"
        lInventory.Size = New Size(298, 21)
        lInventory.TabIndex = 1
        lInventory.Text = "00"
        lInventory.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(15, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(298, 26)
        Label4.TabIndex = 0
        Label4.Text = "Inventory"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel3.Controls.Add(lProducts)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(690, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(327, 175)
        Panel3.TabIndex = 2
        ' 
        ' lProducts
        ' 
        lProducts.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lProducts.ForeColor = SystemColors.Control
        lProducts.Location = New Point(15, 141)
        lProducts.Name = "lProducts"
        lProducts.Size = New Size(298, 21)
        lProducts.TabIndex = 1
        lProducts.Text = "00"
        lProducts.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(15, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(298, 26)
        Label6.TabIndex = 0
        Label6.Text = "Products"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 730)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lSales As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lInventory As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lProducts As Label
    Friend WithEvents Label6 As Label
End Class
