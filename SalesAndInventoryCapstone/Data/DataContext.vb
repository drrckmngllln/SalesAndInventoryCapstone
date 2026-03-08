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
    Public Property ProductsViews As DbSet(Of Product)
    Public Property ProductInputs As DbSet(Of ProductInput)
    Public Property SaleItemViews As DbSet(Of SaleItemView)
    Public Property Users As DbSet(Of User)
    Public Property Notifications As DbSet(Of Notification)
    Public Property SecurityQuestions As DbSet(Of SecurityQuestion)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            optionsBuilder.UseMySql(Connstring, ServerVersion.AutoDetect(Connstring))
        End If
    End Sub

    Protected Overrides Sub OnModelCreating(builder As ModelBuilder)
        MyBase.OnModelCreating(builder)
        ' Configure entity properties and relationships here if needed

        builder.Entity(Of User)().HasQueryFilter(Function(u) u.IsEnabled)

        builder.Entity(Of SecurityQuestion)(
            Sub(b)
                b.HasKey(Function(key) key.Id)
                b.Property(Function(p) p.UserId)
                b.Property(Function(p) p.SecurityQuestion)
                b.Property(Function(p) p.SecurityAnswer)
                b.HasOne(Function(x) x.User).WithMany(Function(x) x.SecurityQuestions)
            End Sub)
    End Sub
End Class
