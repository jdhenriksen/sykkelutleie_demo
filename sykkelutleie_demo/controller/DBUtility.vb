Imports MySql.Data.MySqlClient
Imports System.Configuration
''' <summary>
''' Klasse som holder funksjoner som går til Databasen
''' </summary>
''' <remarks></remarks>
Public Class DBUtility
    Private SQLParameters As New List(Of MySqlParameter)

    ''' <summary>
    ''' Database funksjon som håndterer alle SELECT setninger til DB
    ''' </summary>
    ''' <param name="sql">Skrives som en mySQL setning As String</param>
    ''' <returns> Returnerer en DataTable på alle treff</returns>
    ''' <remarks>ConnectionString "mySql" ligger i App.config for å lettere forandre DB tilkopling</remarks>
    Public Function selectQuery(sql As String) As DataTable
        Dim data As New DataTable
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(Sql, connection)
            adapter.Fill(data)
            connection.Close()

        Catch ex As MySqlException
            errorMessage(ex)
        Finally
            connection.Dispose()
        End Try

        Return data

    End Function
    ''' <summary>
    ''' Funksjon som håndterer INSERT, DELETE og UPDATE setnigner til DB
    ''' </summary>
    ''' <param name="sql">Skrives som en mySQL setning As String</param>
    ''' <returns>True om kommandoen ble gjennomført uten error. False med error</returns>
    ''' <remarks></remarks>
    Public Function updateQuery(sql As String) As Boolean 'Fungerer... vet ikke hva enkelte av linjene gjør....
        Dim data As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()
            adapter.SelectCommand = New MySqlCommand(sql, connection)
            adapter.Fill(data)
            connection.Close()
        Catch ex As MySqlException
            errorMessage(ex)
        Finally
            connection.Dispose()
        End Try

        Return True

    End Function

    Public Function paramQuery(sql As String) As DataTable
        Dim data As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()

            Dim command = New MySqlCommand(sql, connection)
            For Each var As MySqlParameter In SQLParameters
                command.Parameters.Add(var)
                command.Parameters(var.ParameterName).Value = var.Value
            Next

            adapter.SelectCommand = command
            adapter.Fill(data)
        Catch ex As Exception
            errorMessage(ex)
        Finally
            connection.Close()
            SQLParameters.Clear()
        End Try
        Return data
    End Function

    Public Sub addParametersToQuery(name As String, value As Object, Optional dataType As DbType = DbType.String)
        Dim param As New MySqlParameter With {.ParameterName = name, .Value = value, .DbType = dataType}
        SQLParameters.Add(param)
    End Sub

    Private Sub errorMessage(ex As MySqlException)
        MessageBox.Show("Feil ved oppkobling til database: " & ex.Message)
    End Sub
End Class

