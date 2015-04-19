Imports MySql.Data.MySqlClient
Imports System.Configuration

''' <summary>
''' Klasse som håndterer oppkobling og kommunikasjon mot database.
''' </summary>
''' <remarks></remarks>
Public Class DBUtility
    'Liste som holder parametere som skal brukes i spørringer.
    'Må tømmes etter hver spørring, ettersom det oppstår feil hvis en
    'parameter som allerede ligger i listen forsøkes lagt til på nytt.
    Private SQLParameters As New List(Of MySqlParameter)

    ''' <summary>
    ''' Hovedfunksjon for å sende spørringer. Håndterer parameteriserte spørringer.
    ''' </summary>
    ''' <param name="sql">Tekstrepresentasjon av SQL-setning som skal sendes.</param>
    ''' <returns>En datatabell som representerer resultatet av spørringen.</returns>
    ''' <remarks></remarks>
    Public Function query(sql As String) As DataTable
        Dim data As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim connection As MySqlConnection = New MySqlConnection
        connection.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            connection.Open()

            'Går gjennom parameterene i listen og bytter dem ut med deres verdier.
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
            'Lukker tilkobling og tømmer listen med parametere.
            connection.Close()
            SQLParameters.Clear()
        End Try
        Return data
    End Function

    ''' <summary>
    ''' Metode som legger til elementer i listen med parametere.
    ''' Må brukes i alle parameteriserte spørringer.
    ''' </summary>
    ''' <param name="name">Navn på parameter. Benytt "@variabelnavn".</param>
    ''' <param name="value">Parameterens verdi.</param>
    ''' <param name="dataType">Datatypen som DbType. Dette bestemmer hvordan
    ''' verdien sendes til databasen. Default er tekst.</param>
    ''' <remarks>Alle verdier som ikke er String eller Integer-varianter må også spesifisere datatype.</remarks>
    Public Sub addParametersToQuery(name As String, value As Object, Optional dataType As DbType = DbType.String)
        Dim param As New MySqlParameter With {.ParameterName = name, .Value = value, .DbType = dataType}
        SQLParameters.Add(param)
    End Sub

    ''' <summary>
    ''' Gir standardisert feilmelding.
    ''' </summary>
    ''' <param name="ex">Feilmeldingsobjekt fra system.</param>
    ''' <remarks></remarks>
    Private Sub errorMessage(ex As MySqlException)
        MessageBox.Show("Feil ved oppkobling til database: " & ex.Message)
    End Sub
End Class

