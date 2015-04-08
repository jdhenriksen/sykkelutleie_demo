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

    Public Sub deleteModel(model As String)
        dbutil.addParametersToQuery("@model", model)
        dbutil.paramQuery(SQLRes.sqlDeleteModel)
    End Sub

    'INCOMPLETE: Samme problem som i BikeDao
    Public Function searchModel(list As List(Of String))
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

    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@model", list(0))
            .addParametersToQuery("@price", list(1))
            .addParametersToQuery("@producer", list(2))
            .addParametersToQuery("@category", list(3))
        End With
    End Sub

    'SKAL BRUKES I MODEL
    'Private Function makeList() As List(Of String)
    '    Dim list As New List(Of String)
    '    list.Add(getModel())
    '    list.Add(getPrice())
    '    list.Add(getProducer())
    '    list.Add(getCategory())
    '    Return list
    'End Function
End Class
