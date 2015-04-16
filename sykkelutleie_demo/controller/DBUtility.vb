Imports MySql.Data.MySqlClient
Imports System.Configuration
''' <summary>
''' Klasse som holder funksjoner som går til Databasen
''' </summary>
''' <remarks></remarks>
Public Class DBUtility
    Private SQLParameters As New List(Of MySqlParameter)

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

