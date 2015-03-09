''' <summary>
''' Klasse for å administrere kontoinformasjon. Knyttes til en ansatt i systemet.
''' </summary>
''' <remarks></remarks>
Public Class Account
    Private username As String
    Private password As String

    Sub New(username As String, password As String)
        Me.username = username
        If validatePassword(password) Then
            Me.password = password
        Else
            Me.password = "defPwd15"
        End If
    End Sub

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getPassword() As String
        Return password
    End Function

    Public Sub setUsername(username As String)
        Me.username = username
    End Sub

    Public Function setPassword(password As String) As Boolean
        If validatePassword(password) Then
            Me.password = password
            'Skriv passord til database
            Return True
        End If
        Return False
    End Function

    Public Function login(username As String, password As String) As Boolean
        'hent brukernavn og passord fra database
        Return True
    End Function

    Public Sub logout()
        'Utloggingsfunksjonalitet
    End Sub

    Public Overrides Function toString() As String
        Return "Brukernavn: " & username & ", passord: " & password
    End Function

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
End Class
