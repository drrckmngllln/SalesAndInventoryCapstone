Public Class Inventory
    Public Property Id As Integer
    Public Property Code As String
    Public Property ProductId As Integer
    Public Property ProductName As String
    Public Property ProductDescription As String
    Public Property CategoryName As String
    Public Property CurrentStock As Integer
    Public Property OriginalPrice As Decimal
    Public Property SellingPrice As Decimal
    Public Property Remarks As String
End Class

Public Class InventoryInput
    Public Property Id As Integer
    Public Property Code As String
    Public Property ProductId As Integer
    Public Property CurrentStock As Integer
    Public Property OriginalPrice As Decimal
    Public Property SellingPrice As Decimal
    Public Property Remarks As String
End Class