Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Options

Public Class DataContext
    Inherits DbContext

    Public Sub New()
    End Sub

    Public Sub New(options As DbContextOptions(Of DataContext))
        MyBase.New(options)
    End Sub

    Public Property Products As DbSet(Of Product)
    Public Property Categories As DbSet(Of Category)
    Public Property Sales As DbSet(Of Sale)
    Public Property SaleItems As DbSet(Of SaleItem)
    Public Property Inventories As DbSet(Of Inventory)
    Public Property InventoryInputs As DbSet(Of InventoryInput)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            optionsBuilder.UseMySql(Connstring, ServerVersion.AutoDetect(Connstring))
        End If
    End Sub
End Class
