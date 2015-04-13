Public Class Customer
    Inherits Person

    Property customerID As String
    Private dbutil As DBUtility
    Private id As String

    Sub New(firstname As String, lastname As String, phone As String, email As String)
        MyBase.New(firstname, lastname, phone, email)
    End Sub

    Sub New(id As String)
        customerID = id
    End Sub
    Sub New()

    End Sub

    Public Sub createCustomer()
        dbutil = New DBUtility()
        Dim sql As String = "INSERT INTO kunde(`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`aktivert`)" _
                            & "VALUES ('" & getFirstname() & "',  '" & getLastname() & "', '" & getPhone() _
                            & "', '" & getEmail() & "',  '1')"
        dbutil.updateQuery(sql)
    End Sub
    Public Sub editCustomer(id As String)
        dbutil = New DBUtility()
        Dim sql As String = "UPDATE kunde SET aktivert = '" & getActive() & "', fornavn = '" & getFirstname() & "', etternavn = '" & getLastname() _
                            & "', telefon = '" & getPhone() & "', epost = '" & getEmail() & "' WHERE kid = '" & id & "';"
        dbutil.updateQuery(sql)
    End Sub

    Public Sub deleteCustomer()
        setActive(0)
        dbutil = New DBUtility
        dbutil.updateQuery("UPDATE kunde SET aktivert = 0 WHERE kid = " & getCustomerID() & ";")
    End Sub


    Public Function searchCustomer(customer As Customer) As DataTable
        dbutil = New DBUtility()
        Dim table As DataTable
        Dim sql As String

        sql = "SELECT kid, fornavn, etternavn, telefon, epost FROM kunde WHERE (kid LIKE '%" & customer.customerID & "%') AND (fornavn LIKE '%" & customer.firstname & "%') AND (etternavn LIKE '%" & customer.lastname & "%') AND (telefon LIKE '%" & customer.phone & "%') AND (epost LIKE '%" & customer.email & "%')"
        table = dbutil.selectQuery(sql)

        Return table
    End Function

    'Midlertidig hjelpemetode for å hente ut ansatt basert på id
    'Mulig at settes til Private senere
    Public Function selectCustomerById(id As String) As DataTable
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

    Public Sub setCustomerID(tempCustomerID As String)
        Me.customerID = tempCustomerID
    End Sub

End Class
