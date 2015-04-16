Public Class Customer
    Inherits Person

    Property customerID As String
    Private dbutil As DBUtility
    Private dao As New CustomerDao

    Sub New(firstname As String, lastname As String, phone As String, email As String)
        MyBase.New(firstname, lastname, phone, email)
    End Sub

    Sub New(id As String)
        customerID = id
    End Sub
    Sub New()

    End Sub
    'Opprette et kunde forhold
    Public Sub createCustomer()
        dao.createCustomer(makeList)
    End Sub
    'Oppdatere kunde info
    Public Sub editCustomer(id As String)
        dao.editCustomer(makeList(), id)
    End Sub
    'Deaktivere kunde
    Public Sub deleteCustomer()
        setActive(0)
        dao.deleteCustomer(getCustomerID())
    End Sub

    Public Function searchCustomer() As DataTable
        Return dao.searchCustomer(makeList())
    End Function
    Public Function getActiveCustomer(customer As Customer) As DataTable
        Return dao.getActiveCustomer()
    End Function

    Private Function selectCustomerById(id As String) As DataTable
        Return dao.selectCustomerById(id)
    End Function

    Public Function getCustomerID() As String
        Return customerID
    End Function

    Public Sub setCustomerID(tempCustomerID As String)
        Me.customerID = tempCustomerID
    End Sub

    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(getFirstname())
        list.Add(getLastname())
        list.Add(getPhone())
        list.Add(getEmail())
        list.Add(getActive())

        Return list
    End Function

End Class
