Public Class CategoryDbHelper
    Shared Async Function GetCategories(Optional search As String = Nothing) As Task(Of List(Of Category))
        Dim sql As String = "SELECT * FROM categories"

        If Not String.IsNullOrEmpty(search) Then
            sql &= " WHERE Name LIKE '%" & search.Replace("'", "''") & "%'"
        End If

        Dim categoriesDataSet As DataSet = Await DBHelper.Fetch(sql)
        Dim categories As New List(Of Category)()

        If categoriesDataSet.Tables.Count > 0 Then
            For Each row As DataRow In categoriesDataSet.Tables(0).Rows
                Dim category As New Category With {
                .Id = Convert.ToInt32(row("Id")),
                .Name = row("Name").ToString()
            }
                categories.Add(category)
            Next
        End If
        Return categories
    End Function

    Shared Async Function GetCategoryById(categoryId As Integer) As Task(Of Category)
        Dim sql As String = $"SELECT * FROM categories WHERE Id = {categoryId}"
        Dim categoryDataSet As DataSet = Await DBHelper.Fetch(sql)
        If categoryDataSet.Tables.Count > 0 AndAlso categoryDataSet.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = categoryDataSet.Tables(0).Rows(0)
            Return New Category With {
                .Id = Convert.ToInt32(row("Id")),
                .Name = row("Name").ToString()
            }
        End If
        Return Nothing
    End Function

    Shared Async Function AddCategory(category As Category) As Task(Of Boolean)
        Dim result = Await DBHelper.CreateAsync("categories", category)
        Return result
    End Function

    Shared Async Function UpdateCategory(category As Category) As Task(Of Boolean)
        Dim result = Await DBHelper.UpdateAsync("categories", category, $"Id={category.Id}")
        Return result
    End Function

    Shared Async Function DeleteCategory(categoryId As Integer) As Task(Of Boolean)
        Dim result = Await DBHelper.DeleteAsync("categories", categoryId)
        Return result
    End Function
End Class
