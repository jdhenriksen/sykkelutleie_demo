Public Class EmployeeDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createEmployee(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateEmployee)
    End Sub

    Public Sub editEmployee(list As List(Of String), id As String)
        populateList(list)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlEditEmployee)
    End Sub

    Public Sub deleteEmployee(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlDeleteEmployee)
    End Sub

    Public Function getAllEmployees() As DataTable
        Return dbutil.selectQuery(SQLRes.sqlGetAllEmployees)
    End Function

    Public Function selectEmployeeById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.paramQuery(SQLRes.sqlSelectEmployeeById)
        Return table
    End Function

    Public Function isActive(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.paramQuery(SQLRes.sqlIsActive)
        Return table
    End Function

    Public Function getAreaByZipCode(zipcode As String) As String
        dbutil.addParametersToQuery("@zipcode", zipcode)
        table = dbutil.paramQuery(SQLRes.sqlGetAreaByZipCode)
        Return table.Rows(0)(0)
    End Function

    Public Function usernameCheck(username As String) As Boolean
        dbutil.addParametersToQuery("@username", username)
        table = dbutil.paramQuery(SQLRes.sqlUsernameCheck)
        If table.Rows.Count > 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function login(username As String, password As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        dbutil.addParametersToQuery("@password", password)
        table = dbutil.paramQuery(SQLRes.sqlLogin)
        Return table
    End Function

    Public Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@username", list(0))
            .addParametersToQuery("@password", list(1))
            .addParametersToQuery("@firstname", list(2))
            .addParametersToQuery("@lastname", list(3))
            .addParametersToQuery("@phone", list(4))
            .addParametersToQuery("@email", list(5))
            .addParametersToQuery("@address", list(6))
            .addParametersToQuery("@job", list(7))
            .addParametersToQuery("@zip", list(8))
            .addParametersToQuery("@active", list(9))
        End With
    End Sub
End Class
