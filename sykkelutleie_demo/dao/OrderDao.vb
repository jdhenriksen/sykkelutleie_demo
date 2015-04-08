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
            .addParametersToQuery("@sum", list(4))
        End With
    End Sub

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
