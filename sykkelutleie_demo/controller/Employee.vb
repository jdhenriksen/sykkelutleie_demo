''' <summary>
''' Håndterer oppgaver i forbindelse med ansatte (brukere) i systemet.
''' Kommuniserer ut mot aktuelt Form og inn mot EmployeeDAO for databaseoperasjoner.
''' </summary>
''' <remarks></remarks>
Public Class Employee
    Inherits Person
    Private employeeID As String
    Private job As String
    Private address As String
    Private zip As String
    Private account As Account
    Private dao As New EmployeeDao

    Sub New(fn As String, ln As String, phone As String, email As String, job As String, address As String, zip As String, username As String, password As String)
        MyBase.New(fn, ln, phone, email)
        Me.job = job
        Me.address = address
        Me.zip = zip
        account = New Account(username, password)
    End Sub

    Sub New(id As String)
        employeeID = id
    End Sub

    Sub New()

    End Sub

    Public Sub createEmployee()
        dao.createEmployee(makeList())
    End Sub

    Public Sub editEmployee(id As String)
        dao.editEmployee(makeList(), id)
    End Sub

    Public Sub deleteEmployee()
        setActive(0)
        dao.deleteEmployee(getEmployeeID())
    End Sub

    Public Function selectEmployeeById(id As String) As DataTable
        Return dao.selectEmployeeById(id)
    End Function

    Public Function getAllEmployees() As DataTable
        Return dao.getAllEmployees()
    End Function

    Public Function searchEmployee() As DataTable
        Return dao.searchEmployee(makeList())
    End Function

    Public Function isActive(id As String) As Boolean
        Dim table As New DataTable
        table = dao.isActive(id)
        Dim active As Integer
        If table.Rows.Count = 1 Then
            active = table.Rows(0)(0)
        End If
        Return active
    End Function

    Public Function getAreaByZipCode(zipcode As String) As String
        Return dao.getAreaByZipCode(zipcode)
    End Function

    Public Function usernameCheck(username As String) As Integer
        Return dao.usernameCheck(username)
    End Function

    Public Function getEmployeeID() As String
        Return employeeID
    End Function

    Public Function getJobTitle() As String
        Return job
    End Function

    Public Sub setJobTitle(title As String)
        job = title
    End Sub

    Public Function getAddress() As String
        Return address
    End Function

    Public Sub setAddress(address As String)
        Me.address = address
    End Sub

    Public Function getZip() As String
        Return zip
    End Function

    Public Sub setZip(zip As String)
        Me.zip = zip
    End Sub

    Public Sub createZipCode(zip As String, area As String)
        dao.createZipCode(zip, area)
    End Sub

    Public Function zipCodeExists(zip As String) As Boolean
        Return dao.zipCodeExists(zip)
    End Function

    'Hjelpemetode. Lager liste som sendes til DAO.
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        With list
            .Add(account.getUsername())
            .Add(account.getPassword())
            .Add(getFirstname())
            .Add(getLastname())
            .Add(getPhone())
            .Add(getEmail())
            .Add(getAddress())
            .Add(getJobTitle())
            .Add(getZip())
            .Add(getActive())
        End With
        Return list
    End Function

End Class
