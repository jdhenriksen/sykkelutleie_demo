Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Klasse for å administrere kontoinformasjon. Knyttes til en ansatt i systemet.
''' </summary>
''' <remarks></remarks>

Public Class Account
    Property username As String
    Private password As String

    Sub New(username As String, password As String)
        Me.username = username
        Me.password = password
    End Sub

    Sub New()

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

    Public Function setPassword(password As String) As Boolean
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
    ''' <returns>Hashverdi basert på passord (MD5)</returns>
    ''' <remarks></remarks>
    Public Function generateHash(password As String) As String
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

    Public Function login() As DataTable
        password = generateHash(password)
        Dim dao As New EmployeeDao
        Dim table As DataTable = dao.login(getUsername(), getPassword())
        Return table
    End Function

    'ERSTATT MED Shared Var
    Public Function getEmployee() As Employee
        Dim dbutil As New DBUtility
        Dim sql As String
        Dim result As DataTable
        Dim row As DataRow

        sql = "SELECT ansatt.fornavn, ansatt.etternavn, stilling, ansatt.epost, ansatt.telefon FROM ansatt WHERE brukernavn = '" & username & "';"
        result = dbutil.paramQuery(sql)

        If result.Rows.Count <> 1 Then
            Return Nothing
        Else

            row = result.Rows(0)

            Dim employee As New Employee(row("fornavn"), row("etternavn"), row("telefon"), row("epost"), row("stilling"), "", "", username, "aaaaaaaa")

            Return employee

        End If
    End Function
End Class
