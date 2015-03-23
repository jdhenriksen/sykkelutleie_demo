''' <summary>
''' Håndterer oppgaver i forbindelse med ansatte (brukere) i systemet.
''' </summary>
''' <remarks></remarks>
Public Class Employee
    Inherits Person
    Private employeeID As String
    Private jobTitle As String
    'Private address As String
    'Private zipcode As String
    Private account As Account
    Private dbutil As DBUtility


    Sub New(fn As String, ln As String, phone As String, email As String, job As String, username As String, password As String)
        MyBase.New(fn, ln, phone, email)
        jobTitle = job
        account = New Account(username, password)
    End Sub

    Sub New(id As String)
        employeeID = id
    End Sub

    Public Sub createEmployee()
        dbutil = New DBUtility()
        Dim sql As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)" _
                            & "VALUES ('" & account.getUsername() & "',  '" & account.getPassword & "',  '" & getFirstname() & "',  '" & getLastname() & "',  '" & getPhone() & "',  '" & getEmail() _
                            & "',  '" & "testvegen 43" & "',  '" & getJobTitle() & "',  '" & "7020" & "',  '1')"
        dbutil.updateQuery(sql)
    End Sub

    Public Sub editEmployee(id As Integer)
        'Endre relevante variabler - hent fra DB og skriv ny verdi til DB (mellomlagre som variabler)
        'Send variabler til tekstbokser for endring
        'UPDATE på id for å endre i DB
        dbutil = New DBUtility()
        Dim sql As String = "UPDATE ansatt SET brukernavn = '" & account.getUsername() & "', passord = '" & account.getPassword & "', fornavn = '" & getFirstname() & "', etternavn = '" & getLastname() _
                            & "', telefon = '" & getPhone() & "', epost = '" & getEmail() & "', adresse = 'adresseIkkeTilgjengelig', stilling = '" & getJobTitle() & "', postnr = 7020, aktivert = '" & getActive() _
                            & "' WHERE ansattid = " & id & ";"
        dbutil.updateQuery(sql)
    End Sub

    Public Sub deleteEmployee()
        setActive(0)
        dbutil = New DBUtility
        dbutil.updateQuery("UPDATE ansatt SET aktivert = 0 WHERE ansattid = " & getEmployeeID() & ";")
    End Sub

    'Midlertidig hjelpemetode for å hente ut ansatt basert på id
    'Mulig at settes til Private senere
    Public Function selectEmployeeById(id As String) As DataTable
        'kall til isActive() her...
        dbutil = New DBUtility()
        Dim sql As String = "SELECT * FROM ansatt WHERE ansattid LIKE'" & id & "';"
        Dim table As DataTable = dbutil.selectQuery(sql)
        Return table
    End Function

    'Hjelpemetode for å sjekke om en ansatt er satt til aktiv
    Public Function isActive() As Boolean
        If getActive() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getEmployeeID() As String
        Return employeeID
    End Function

    Public Function getJobTitle() As String
        Return jobTitle
    End Function

    Public Sub setJobTitle(title As String)
        jobTitle = title
    End Sub

    Public Function getAccountInfo() As String
        Return account.toString()
    End Function

    Public Overrides Function toString() As String
        Return MyBase.toString() & "Jobbtittel: " & getJobTitle() & vbCrLf & "Brukernavn: " _
            & account.toString()
    End Function
End Class
