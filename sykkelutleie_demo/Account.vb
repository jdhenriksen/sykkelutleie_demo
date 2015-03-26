Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Klasse for å administrere kontoinformasjon. Knyttes til en ansatt i systemet.
''' </summary>
''' <remarks></remarks>

Public Class Account
    Private username As String
    Private password As String
    Private dbutil As DBUtility

    Sub New(username As String, password As String)
        Me.username = username
        If validatePassword(password) Then
            Me.password = generateHash(password)
        Else
            MsgBox("Passord ugyldig.")
        End If
        dbutil = New DBUtility
    End Sub

    Public Function getUsername() As String
        Return username
    End Function

    Public Sub setUsername(name As String)
        username = name
    End Sub

    Public Function getPassword() As String
        Return password
    End Function

    Public Sub setPassword(password)
        If validatePassword(password) Then
            password = generateHash(password)
            'Skriv passord/hash til database i Employee.
        Else
            MsgBox("Passord ugyldig.")
        End If
    End Sub

    ''' <summary>
    ''' Hjelpemetode for å sjekke passord.
    ''' </summary>
    ''' <param name="password">Passord som skal sjekkes.</param>
    ''' <returns>True hvis passord er godt nok, false hvis ikke.</returns>
    ''' <remarks></remarks>
    Private Function validatePassword(password As String) As Boolean
        If password.Length > 7 Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Hjelpefunksjon for å lage hash til passord.
    ''' </summary>
    ''' <param name="password">Passord som skal hashes.</param>
    ''' <returns>Hashverdi basert på passord (MD5)</returns>
    ''' <remarks></remarks>
    Private Function generateHash(password As String) As String
        'Create encoding object to ensure encoding standard
        Dim encoding As New UnicodeEncoding()
        'Retrieve byte array based on source text
        Dim byteSourceText() As Byte = encoding.GetBytes(password)
        'Instantiate MD5 Provider Object
        Dim md5 As New MD5CryptoServiceProvider()
        'Compute hash
        Dim byteHash() As Byte = md5.ComputeHash(byteSourceText)
        'Convert to String
        Return Convert.ToBase64String(byteHash)
    End Function

    'TODO
    Public Function login(id As String, username As String, password As String) As Boolean
        Return True
    End Function

    Public Overrides Function toString() As String
        Return "Brukernavn: " & username & vbCrLf & "Passord: " & password
    End Function
End Class
