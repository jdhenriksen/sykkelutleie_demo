Public Class EmployeeDao
    Private dbutil As New DBUtility
    Private sql As String
    Private table As New DataTable

    Public Sub createEmployee(list As List(Of String))
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

        sql = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)" _
                & "VALUES (@username, @password, @firstname, @lastname, @phone, @email, @address, @job, @zip, @active)"
        dbutil.paramQuery(sql)
    End Sub

    Public Sub editEmployee(list As List(Of String), id As String)
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
            .addParametersToQuery("@id", id)
        End With

        sql = "UPDATE ansatt SET brukernavn = @username, passord = @password, fornavn = @firstname, etternavn = @lastname " _
            & ", telefon = @phone, epost = @email, adresse = @address, stilling = @job, postnr = @zip, aktivert = @active " _
            & "WHERE ansattid = @id;"
        dbutil.paramQuery(sql)
    End Sub

    Public Sub deleteEmployee(id As String)
        dbutil.addParametersToQuery("@id", id)
        sql = "UPDATE ansatt SET aktivert = 0 WHERE ansattid = @id;"
        dbutil.paramQuery(sql)
    End Sub

    Public Function getAllEmployees() As DataTable
        sql = "SELECT * FROM ansatt"
        Return dbutil.selectQuery(sql)
    End Function

    Public Function selectEmployeeById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        sql = "SELECT * FROM ansatt WHERE ansattid = @id;"
        table = dbutil.paramQuery(sql)
        Return table
    End Function

    Public Function isActive(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        sql = "SELECT aktivert FROM ansatt WHERE ansattid = @id;"
        table = dbutil.paramQuery(sql)
        Return table
    End Function

    Public Function getAreaByZipCode(zipcode As String) As String
        dbutil.addParametersToQuery("@zipcode", zipcode)
        sql = "SELECT poststed FROM poststed WHERE postnr = @zipcode"
        table = dbutil.paramQuery(sql)
        Return table.Rows(0)(0)
    End Function

    Public Function usernameCheck(username As String) As Boolean
        dbutil.addParametersToQuery("@username", username)
        sql = "SELECT brukernavn FROM ansatt WHERE brukernavn = @username"
        table = dbutil.paramQuery(sql)
        If table.Rows.Count > 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function login(username As String, password As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        dbutil.addParametersToQuery("@password", password)
        sql = "SELECT stilling FROM ansatt WHERE brukernavn = @username AND passord = @password"
        table = dbutil.paramQuery(sql)
        Return table
    End Function
End Class
