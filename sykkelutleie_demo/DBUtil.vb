Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class DBUtility
    Public Function query(sql As String) As DataTable 'ConnectionString "mySql" ligger i App.config for lettere forandre DB tilkopling
        Dim data As New DataTable
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, connection)
            adapter.Fill(data)
            connection.Close()

        Catch ex As Exception
            errorMessage(ex)
        Finally
            connection.Dispose()
        End Try

        Return data

    End Function

    Private Sub errorMessage(ex As Exception)
        MessageBox.Show("Feil ved oppkobling til database: " & ex.Message)
    End Sub
End Class

