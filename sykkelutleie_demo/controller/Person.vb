''' <summary>
''' Klasse som lagrer generell personinformasjon. Brukes av Employee og Customer.
''' </summary>
''' <remarks></remarks>
Public Class Person
    Property firstname As String
    Property lastname As String
    Property phone As String
    Property email As String
    Property active As Integer

    ''' <summary>
    ''' Konstruktør som setter alle objektvariabler.
    ''' </summary>
    ''' <param name="firstname">Fornavn.</param>
    ''' <param name="lastname">Etternavn.</param>
    ''' <param name="phone">Telefonnummer.</param>
    ''' <param name="email">Epost-adresse.</param>
    ''' <remarks></remarks>
    Sub New(firstname As String, lastname As String, phone As String, email As String)
        Me.firstname = firstname
        Me.lastname = lastname
        setPhone(phone)
        setEmail(email)
        active = 1
    End Sub

    ''' <summary>
    ''' Standardkonstruktør. Brukes implisitt i standardkonstruktører til Employee og Customer.
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()

    End Sub

    'GET- og SET-metoder for Person.
    Public Function getFirstname() As String
        Return firstname
    End Function

    Public Sub setFirstname(name As String)
        firstname = name
    End Sub

    Public Function getLastname() As String
        Return lastname
    End Function

    Public Sub setLastname(name As String)
        lastname = name
    End Sub

    Public Function getPhone() As String
        Return phone
    End Function

    ''' <summary>
    ''' Setter telefonnummer for person eller subklasser.
    ''' </summary>
    ''' <param name="phone">Telefonnummer som skal settes.</param>
    ''' <remarks>Godtar telefonnummer hvis det er 8 siffer og det har en tallverdi.
    ''' Settes til tom tekststreng hvis ikke.</remarks>
    Public Sub setPhone(phone As String)
        If IsNumeric(phone) And phone.Trim.Length = 8 Then
            Me.phone = phone
        Else
            Me.phone = ""
        End If
    End Sub

    Public Function getEmail() As String
        Return email
    End Function

    ''' <summary>
    ''' Setter epost-adresse for person eller subklasser.
    ''' </summary>
    ''' <param name="email">Epost-adresse som skal settes.</param>
    ''' <remarks>Godtar epost hvis det inneholder en '@'. Settes til tom tekststreng hvis ikke.</remarks>
    Public Sub setEmail(email As String)
        If email.Contains("@") Then
            Me.email = email
        Else
            Me.email = ""
        End If
    End Sub

    Public Function getActive() As Integer
        Return active
    End Function

    ''' <summary>
    ''' Setter aktivert-attributtet for en person eller subklasser.
    ''' </summary>
    ''' <param name="active">Aktivert-verdi som skal settes.</param>
    ''' <remarks>Godtar 0 eller 1 som verdi. Attributtet forblir uendret ellers.</remarks>
    Public Sub setActive(active As Integer)
        If active = 0 Then
            Me.active = active
        ElseIf active = 1 Then
            Me.active = active
        End If
    End Sub
End Class
