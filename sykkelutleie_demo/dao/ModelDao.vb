Public Class ModelDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createModel(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateModel)
    End Sub

    Public Sub editModel(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditModel)
    End Sub

    Public Function searchModel(list As List(Of String)) As DataTable
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.paramQuery(SQLRes.sqlSearchModel)
        Return table
    End Function

    Public Function getPrice(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.paramQuery(SQLRes.sqlGetModelPrice)
        Return table
    End Function

    Public Function getProducer(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.paramQuery(SQLRes.sqlGetModelProducer)
        Return table
    End Function

    Public Function getCategory(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.paramQuery(SQLRes.sqlGetModelCategory)
        Return table
    End Function

    Public Function selectAllModels() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllModels)
        Return table
    End Function

    Public Function getModelById(ByVal model As String)
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.paramQuery(SQLRes.sqlGetModelById)
        Return table
    End Function

    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@model", list(0))
            .addParametersToQuery("@price", list(1))
            .addParametersToQuery("@producer", list(2))
            .addParametersToQuery("@category", list(3))
        End With
    End Sub

    Private Function prepareForSearch(inputList As List(Of String)) As String()
        Dim i As Integer
        Dim listItemLength As Integer
        Dim list(inputList.Count - 1) As String
        For i = 0 To inputList.Count - 1
            If String.IsNullOrEmpty(inputList(i)) Or inputList(i) = Nothing Then
                list(i) = String.Format("%{0}%", inputList(i))
            Else
                listItemLength = inputList(i).Length
                list(i) = String.Format("%{0," & listItemLength & "}%", inputList(i))
            End If
        Next
        Return list
    End Function
End Class
