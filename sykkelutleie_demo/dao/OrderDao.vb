Public Class OrderDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createOrder(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateOrder)
    End Sub

    Public Sub createBikeOrder(orderID As String, frameNumber As String)
        dbutil.addParametersToQuery("@orderID", orderID)
        dbutil.addParametersToQuery("@frameNumber", frameNumber)
        dbutil.paramQuery(SQLRes.sqlCreateBikeOrder)
    End Sub

    Public Function getLatestOrder() As String
        table = dbutil.paramQuery(SQLRes.sqlGetLatestOrder)
        Return table.Rows(0)(0)
    End Function

    Public Sub createEquipmentOrder(orderID As String, equipmentID As String)
        dbutil.addParametersToQuery("@orderID", orderID)
        dbutil.addParametersToQuery("@equipmentID", equipmentID)
        dbutil.paramQuery("INSERT INTO `utstyr_bestilling` (`bestillingsid`, `varenr`) VALUES (@orderID, @equipmentID);")
    End Sub

    Public Sub editOrder(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditOrder)
    End Sub

    Public Function getBikeJoinModel(framenumber As String) As DataTable
        dbutil.addParametersToQuery("@framenumber", framenumber)
        table = dbutil.paramQuery(SQLRes.sqlGetBikeJoinModel)
        Return table
    End Function

    Public Function searchOrder(list As List(Of String)) As DataTable
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.paramQuery(SQLRes.sqlSearchOrder)
        Return table
    End Function

    Public Function selectOrderById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.paramQuery(SQLRes.sqlSelectOrderById)
        Return table
    End Function

    Public Function selectAllOrders() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllOrders)
        Return table
    End Function

    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@from", list(0))
            .addParametersToQuery("@to", list(1))
            .addParametersToQuery("@employeeID", list(2))
            .addParametersToQuery("@customerID", list(3))
            .addParametersToQuery("@sum", list(4), DbType.Decimal)
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
