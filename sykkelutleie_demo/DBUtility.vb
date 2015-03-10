Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class DBUtility
    ''' <summary>
    ''' Database funksjon som håndterer alle meldinger til DB
    ''' </summary>
    ''' <param name="sql"> Skrives som en mySQL setning As String. SELECT, ALTER eller INSERT</param>
    ''' <returns> Returnerer en DataTable på alle treff</returns>
    ''' <remarks>ConnectionString "mySql" ligger i App.config for å lettere forandre DB tilkopling</remarks>
    Public Function selectQuery(sql As String) As DataTable
        Dim data As New DataTable
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, connection)
            adapter.Fill(data)
            connection.Close()

        Catch ex As MySqlException
            errorMessage(ex)
        Finally
            connection.Dispose()
        End Try

        Return data

    End Function

    Public Function updateQuary(sql As String) As Boolean
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.UpdateCommand = New MySqlCommand(sql, connection)
            connection.Close()

        Catch ex As MySqlException
            errorMessage(ex)
        Finally
            connection.Dispose()
        End Try

        Return True

    End Function

    Private Sub errorMessage(ex As MySqlException)
        MessageBox.Show("Feil ved oppkobling til database: " & ex.Message)

    End Sub
End Class

