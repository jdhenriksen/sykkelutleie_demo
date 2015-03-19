Public Class Person
    Private firstname As String
    Private lastname As String
    Private phone As String
    Private email As String
    Private active As Integer
    'Private type As Person ---> Identifiserer om objektet er Employee eller Customer
    Private argException As ArgumentOutOfRangeException 'TEST
    Private dbutil As DBUtility

    Sub New(fn As String, ln As String, phone As String, email As String)
        firstname = fn
        lastname = ln
        setPhone(phone)
        setEmail(email)
        active = 1
        dbutil = New DBUtility
    End Sub

    'Testkonstruktør
    Sub New()
        firstname = "Testperson"
        lastname = "Testesen"
        phone = "11221122"
        email = "testperson@test.net"
        active = 1
        dbutil = New DBUtility
    End Sub

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

    Public Sub setPhone(phone As String)
        If IsNumeric(phone) And phone.Trim.Length = 8 Then
            Me.phone = phone
        Else
            'argException = New ArgumentOutOfRangeException("phone", "Telefonnummer må være et tall på 8 tegn.")
            'Throw argException
            MsgBox("Telefonnummer er ugyldig.")
        End If
    End Sub

    Public Function getEmail() As String
        Return email
    End Function

    Public Sub setEmail(email As String)
        If email.Contains("@") Then
            Me.email = email
        Else
            MsgBox("Ugyldig epostadresse.")
        End If
    End Sub

    Public Function getActive() As Integer
        Return active
    End Function

    Public Sub setActive(active As Integer)
        If active = 0 Then
            Me.active = active
        ElseIf active = 1 Then
            Me.active = active
        Else
            MsgBox("Aktivert kan kun være 1 eller 0.")
        End If
    End Sub

    Public Overrides Function toString() As String
        Return "Fornavn: " & getFirstname() & vbCrLf & "Etternavn: " & getLastname() & vbCrLf _
            & "Telefonnummer: " & getPhone() & vbCrLf & "Epost: " & getEmail() & vbCrLf
    End Function
End Class
