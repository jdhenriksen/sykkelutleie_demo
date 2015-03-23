Public Class Customer
    Inherits Person

    Private customerID As String
    Private dbutil As DBUtility
    Sub New(firstname As String, lastname As String, phone As String, email As String)
        MyBase.New(firstname, lastname, phone, email)
    End Sub
    'Testkonstruktør
    Sub New()
        MyBase.New()
    End Sub
    Public Sub createCustomer()
        dbutil = New DBUtility()
        Dim sql As String = "INSERT INTO  kunde(`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`aktivert`)" _
                            & "VALUES ('" & getFirstname() & "',  '" & getLastname() & "', '" & getPhone() _
                            & "', '" & getEmail() & "',  '1')"
        dbutil.updateQuery(sql)
    End Sub
    Public Sub editCustomer(CmrId As String)
        'Endre relevante variabler - hent fra DB og skriv ny verdi til DB (mellomlagre som variabler)
        'Send variabler til tekstbokser for endring
        'UPDATE på id for å endre i DB
        dbutil = New DBUtility()
        Dim sql As String = "UPDATE kunde SET brukernavn = (`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`aktivert`)" _
                            & "VALUES ('" & getFirstname() & "',  '" & getLastname() & "', '" & getPhone() _
                            & "', '" & getEmail() & "', aktivert = '" & getActive() _
                            & "' WHERE kid = " & CmrId & ";"
        dbutil.updateQuery(sql)
    End Sub
    Public Sub deleteCustomer()
        'Sett 'active'/aktivert til 0
    End Sub

    'Midlertidig hjelpemetode for å hente ut ansatt basert på id
    'Mulig at settes til Private senere
    Public Function selectCustomerById(id As String) As DataTable
        'kall til isActive() her...
        dbutil = New DBUtility()
        Dim sql As String = "SELECT * FROM kunde WHERE kid LIKE'" & id & "';"
        Dim table As DataTable = dbutil.selectQuery(sql)
        Return table
    End Function

    'Hjelpemetode for å sjekke om en kunde er satt til aktiv
    Public Function isActive() As Boolean
        If getActive() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getCustomerID() As String
        Return customerID
    End Function
End Class
