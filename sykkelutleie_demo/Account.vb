''' <summary>
''' Klasse for å administrere kontoinformasjon. Knyttes til en ansatt i systemet.
''' </summary>
''' <remarks></remarks>
Public Class Account
    Private username As String
    Private userPassword As String
    Private dbutil As DBUtility

    Sub New(username As String, password As String)
        Me.username = username
        If validatePassword(password) Then
            userPassword = password
        Else
            userPassword = "defaultPassword"
        End If
        dbutil = New DBUtility
    End Sub

    Property password() As String
        Get
            Return userPassword
        End Get
        Set(password As String)
            If validatePassword(password) Then
                userPassword = password
                'Skriv passord til database.
            Else
                password = "defaultPassword"
            End If
        End Set
    End Property


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

    Public Overrides Function toString() As String
        Return "Brukernavn: " & username & vbCrLf & "Passord: " & password
    End Function
End Class
