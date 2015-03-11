''' <summary>
''' Klasse for å administrere kontoinformasjon. Knyttes til en ansatt i systemet.
''' </summary>
''' <remarks></remarks>
Public Class Account
    Public Property username As String
    Private userPassword As String

    Sub New(username As String, password As String)
        Me.username = username
        If validatePassword(password) Then
            userPassword = password
        Else
            userPassword = "defPwd15"
        End If
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
                password = "defPwd15"
            End If
        End Set
    End Property

    Public Function login(username As String, password As String) As Boolean
        'hent brukernavn og passord fra database
        Return True
    End Function

    Public Overrides Function toString() As String
        Return "Brukernavn: " & username & ", passord: " & userPassword
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
