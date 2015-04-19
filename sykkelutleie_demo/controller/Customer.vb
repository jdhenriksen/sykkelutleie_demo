''' <summary>
''' Klasse som håndterer funksjonalitet forbundet med kundeobjekter.
''' </summary>
''' <remarks></remarks>
Public Class Customer
    Inherits Person

    Property customerID As String
    Private dao As New CustomerDao

    ''' <summary>
    ''' Konstruktør som setter alle objektvariabler.
    ''' </summary>
    ''' <param name="firstname">Fornavn.</param>
    ''' <param name="lastname">Etternavn.</param>
    ''' <param name="phone">Telefon.</param>
    ''' <param name="email">Epost-adresse.</param>
    ''' <remarks></remarks>
    Sub New(firstname As String, lastname As String, phone As String, email As String)
        MyBase.New(firstname, lastname, phone, email)
    End Sub

    ''' <summary>
    ''' Konstruktør som kun setter kundeID.
    ''' </summary>
    ''' <param name="id">KundeID.</param>
    ''' <remarks></remarks>
    Sub New(id As String)
        customerID = id
    End Sub

    ''' <summary>
    ''' Standardkonstruktør. Brukes når et objekt er nødvendig men konkret informasjon ikke foreligger.
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()

    End Sub

    ''' <summary>
    ''' Skriver en kunde til databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub createCustomer()
        dao.createCustomer(makeList)
    End Sub

    ''' <summary>
    ''' Endrer kundeinformasjon basert på kundeID.
    ''' </summary>
    ''' <param name="id">KundeID til kunde som skal oppdateres.</param>
    ''' <remarks></remarks>
    Public Sub editCustomer(id As String)
        dao.editCustomer(makeList(), id)
    End Sub

    ''' <summary>
    ''' Sletter en kunde fra databasen basert på kundeID.
    ''' </summary>
    ''' <param name="id">KundeID til kunde som skal slettes.</param>
    ''' <remarks>Setter også aktivert = '0' for inneværende objekt.</remarks>
    Public Sub deleteCustomer(id As String)
        setActive(0)
        dao.deleteCustomer(id)
    End Sub

    ''' <summary>
    ''' Søker etter kunder i databasen på en dynamisk måte.
    ''' </summary>
    ''' <returns>En datatabell som inneholder informasjon om kunder 
    ''' som stemmer overens med søk.</returns>
    ''' <remarks>Brukes i forbindelse med søk i tekstfelt i Form.</remarks>
    Public Function searchCustomer() As DataTable
        Return dao.searchCustomer(makeList())
    End Function

    ''' <summary>
    ''' Henter alle aktive kunder fra databasen.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om alle aktiverte kunder.</returns>
    ''' <remarks></remarks>
    Public Function getActiveCustomer() As DataTable
        Return dao.getActiveCustomers()
    End Function

    ''' <summary>
    ''' Henter ut informasjon om en kunde basert på kundeID.
    ''' </summary>
    ''' <param name="id">KundeID det skal søkes etter.</param>
    ''' <returns>En datatabell med informasjon om aktuell kunde.</returns>
    ''' <remarks></remarks>
    Private Function selectCustomerById(id As String) As DataTable
        Return dao.selectCustomerById(id)
    End Function

    ''' <summary>
    ''' Hjelpemetode. Lager liste som sendes til DAO.
    ''' </summary>
    ''' <returns>En liste bestående innholdet i alle objektvariablene for objektet.</returns>
    ''' <remarks>Se CustomerDAO for bruk.</remarks>
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(getFirstname())
        list.Add(getLastname())
        list.Add(getPhone())
        list.Add(getEmail())
        list.Add(getActive())
        Return list
    End Function

    'GET- og SET-metoder for kundeID.
    Public Function getCustomerID() As String
        Return customerID
    End Function

    Public Sub setCustomerID(tempCustomerID As String)
        Me.customerID = tempCustomerID
    End Sub

End Class
