Public Class OrderDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createOrder(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateOrder)
    End Sub

    Public Sub editOrder(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditOrder)
    End Sub

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

    'SKAL INN I ORDER
    'Private Function makeList() As List(Of String)
    '    Dim list As New List(Of String)
    '    With list
    '        .Add(getFromDate())
    '        .Add(getToDate())
    '        .Add(Employee.getEmployeeID())
    '        .Add(Customer.getCustomerID())
    '        .Add(getSumTotal())
    '    End With
    '    Return list
    'End Function
End Class
