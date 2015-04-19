Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Klasse for å administrere kontoinformasjon. Knyttes til en ansatt i systemet.
''' </summary>
''' <remarks></remarks>

Public Class Account
    Property username As String
    'Delt variabel som holder på ansattID. Settes ved innlogging i systemet.
    Public Shared Property userID As String
    Private password As String
    Private table As New DataTable
    Private dao As New EmployeeDao

    ''' <summary>
    ''' Konstruktør som setter verdier på alle objektvariabler.
    ''' </summary>
    ''' <param name="username">Brukernavn.</param>
    ''' <param name="password">Passord.</param>
    ''' <remarks></remarks>
    Sub New(username As String, password As String)
        Me.username = username
        Me.password = password
    End Sub

    ''' <summary>
    ''' Standardkonstruktør. Brukes hvis det trengs et objekt, men konkret informasjon ikke foreligger.
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()

    End Sub

    ''' <summary>
    ''' Hjelpemetode: Foretar passordvalidering etter gitte premisser.
    ''' </summary>
    ''' <param name="password">Passord som skal valideres.</param>
    ''' <returns>True hvis passord er godkjent, False hvis ikke.</returns>
    ''' <remarks>For enkelhets skyld sjekkes kun lengden (passord må ha minimum 8 tegn).</remarks>
    Private Function validatePassword(password As String) As Boolean
        If password.Length > 7 Then
            Me.password = generateHash(password)
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Hjelpefunksjon for å lage hash til passord.
    ''' </summary>
    ''' <param name="password">Passord som skal hashes.</param>
    ''' <returns>Tekstrepresentasjon av hashverdi (MD5) basert på passord.</returns>
    ''' <remarks></remarks>
    Public Function generateHash(password As String) As String
        'Sette et kodingsobjekt som UnicodeEncoding.
        Dim encoding As New UnicodeEncoding()

        'Lage en byte-matrise basert på opprinnelig tekst.
        Dim byteSourceText() As Byte = encoding.GetBytes(password)

        'Sette et MD5-tilbyderobjekt.
        Dim md5 As New MD5CryptoServiceProvider()

        'Utforme en hash-verdi basert på byte-representasjon av opprinnelig tekst.
        Dim byteHash() As Byte = md5.ComputeHash(byteSourceText)

        'Konvertere byte-matrisen til en tekstlig representasjon.
        Return Convert.ToBase64String(byteHash)
    End Function

    ''' <summary>
    ''' Håndterer innlogging i systemet.
    ''' </summary>
    ''' <returns>En datatabell bestående av stillingsbeskrivelsen til brukeren som logget inn.</returns>
    ''' <remarks>Hasher passord fra Login-skjerm, sender brukernavn og passord til DAO
    ''' og setter delt variabel.</remarks>
    Public Function login() As DataTable
        password = generateHash(password)
        table = dao.login(getUsername(), getPassword())
        setUserId()
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Setter delt variabel.
    ''' </summary>
    ''' <remarks>Sender melding til DAO for å finne ansattID til innlogget bruker.</remarks>
    Private Sub setUserId()
        table = dao.setUserId(username)
        userID = table.Rows(0)(0)
    End Sub

    'GET- og SET-metoder for Account.
    Public Function getUsername() As String
        Return username
    End Function

    Public Sub setUsername(name As String)
        username = name
    End Sub

    Public Function getPassword() As String
        Return password
    End Function

    Public Function setPassword(password As String) As Boolean
        Return validatePassword(password)
    End Function
End Class
