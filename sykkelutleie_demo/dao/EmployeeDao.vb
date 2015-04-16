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

    Public Function searchEmployee(list As List(Of String)) As DataTable
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.paramQuery(SQLRes.sqlSearchEmployee)
        Return table
    End Function

    Public Function getAllEmployees() As DataTable
        Return dbutil.paramQuery(SQLRes.sqlGetAllEmployees)
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

    Public Function getPasswordHashByUsername(username As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        table = dbutil.paramQuery(SQLRes.sqlGetPasswordHashByUsername)
        Return table
    End Function

    Public Function getAreaByZipCode(zipcode As String) As String
        dbutil.addParametersToQuery("@zipcode", zipcode)
        table = dbutil.paramQuery(SQLRes.sqlGetAreaByZipCode)
        If table.Rows.Count > 0 Then
            Return table.Rows(0)(0)
        End If
        Return ""
    End Function

    Public Function usernameCheck(username As String) As Integer
        dbutil.addParametersToQuery("@username", username)
        table = dbutil.paramQuery(SQLRes.sqlUsernameCheck)
        Return table.Rows.Count
    End Function

    Public Function login(username As String, password As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        dbutil.addParametersToQuery("@password", password)
        table = dbutil.paramQuery(SQLRes.sqlLogin)
        Return table
    End Function

    Public Sub createZipCode(zip As String, area As String)
        dbutil.addParametersToQuery("@zip", zip)
        dbutil.addParametersToQuery("@area", area)
        dbutil.paramQuery(SQLRes.sqlCreateZipCode)
    End Sub

    Public Function zipCodeExists(zip As String) As Boolean
        dbutil.addParametersToQuery("@zip", zip)
        Dim exists As Boolean = False
        table = dbutil.paramQuery(SQLRes.sqlZipCodeExists)
        If table.Rows.Count > 0 Then
            exists = True
        End If
        Return exists
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
