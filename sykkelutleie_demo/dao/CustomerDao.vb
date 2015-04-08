Public Class CustomerDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createCustomer(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateCustomer)
    End Sub

    Public Sub editCustomer(list As List(Of String), id As String)
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditCustomer)
    End Sub

    Public Sub deleteCustomer(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlDeleteCustomer)
    End Sub

    Public Sub selectCustomerById(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlSelectCustomerById)
    End Sub

    Public Function selectAllCustomers() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllCustomers)
        Return table
    End Function

    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@firstname", list(0))
            .addParametersToQuery("@lastname", list(1))
            .addParametersToQuery("@phone", list(2))
            .addParametersToQuery("@email", list(3))
            .addParametersToQuery("@active", list(4))
            .addParametersToQuery("@id", list(5))
        End With
    End Sub

    'SKAL INN I CUSTOMER
    'Private Function makeList() As List(Of String)
    '    Dim list As New List(Of String)
    '    list.Add(getFirstname())
    '    list.Add(getLastname())
    '    list.Add(getPhone())
    '    list.Add(getEmail())
    '    list.Add(getActive())
    '    list.Add(getCustomerID())
    'End Function
End Class
