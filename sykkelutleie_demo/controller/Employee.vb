''' <summary>
''' Håndterer oppgaver i forbindelse med ansatte (brukere) i systemet.
''' Kommuniserer ut mot aktuelt Form og inn mot EmployeeDAO for databaseoperasjoner.
''' </summary>
''' <remarks></remarks>
Public Class Employee
    Inherits Person
    Property employeeID As String
    Private job As String
    Private address As String
    Private zip As String
    Property account As Account
    Private table As New DataTable
    Private dao As New EmployeeDao

    ''' <summary>
    ''' Konstruktør som tar inn verdier for alle objektvariabler. Brukes for å skrive objektet til databasen.
    ''' </summary>
    ''' <param name="firstname">Fornavn.</param>
    ''' <param name="lastname">Etternavn.</param>
    ''' <param name="phone">Telefonnummer.</param>
    ''' <param name="email">Epost-adresse.</param>
    ''' <param name="job">Stillingsbeskrivelse.</param>
    ''' <param name="address">Adresse.</param>
    ''' <param name="zip">Postnummer.</param>
    ''' <param name="username">Brukernavn.</param>
    ''' <param name="password">Passord.</param>
    ''' <remarks>Oppretter et konto-objekt basert på brukernavn og passord.</remarks>
    Sub New(firstname As String, lastname As String, phone As String, email As String, job As String, address As String, zip As String, username As String, password As String)
        MyBase.New(firstname, lastname, phone, email)
        Me.job = job
        Me.address = address
        Me.zip = zip
        account = New Account(username, password)
    End Sub

    ''' <summary>
    ''' Konstruktør som kun gir verdi til AnsattID. Brukes for sletting og oppdatering i databasen.
    ''' </summary>
    ''' <param name="id">AnsattID.</param>
    ''' <remarks></remarks>
    Sub New(id As String)
        employeeID = id
    End Sub

    ''' <summary>
    ''' Standardkonstruktør. Brukes når et ansatt-objekt er nødvendig, men det ikke foreligger konkret informasjon.
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()

    End Sub

    ''' <summary>
    ''' Skriver ansatt til databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub createEmployee()
        dao.createEmployee(makeList())
    End Sub

    ''' <summary>
    ''' Endrer informasjon om en ansatt i databasen basert på AnsattID.
    ''' </summary>
    ''' <param name="id">AnsattID.</param>
    ''' <remarks></remarks>
    Public Sub editEmployee(id As String)
        dao.editEmployee(makeList(), id)
    End Sub

    ''' <summary>
    ''' Sletter en ansatt fra databasen ved å sette aktivert-attributt til 0.
    ''' </summary>
    ''' <remarks>Oppdaterer også inneværende objekt.</remarks>
    Public Sub deleteEmployee()
        setActive(0)
        dao.deleteEmployee(getEmployeeID())
    End Sub

    ''' <summary>
    ''' Henter ut en ansatt fra databasen basert på id.
    ''' </summary>
    ''' <param name="id">AnsattID.</param>
    ''' <returns>En datatabell fra DAO basert på resultatet av spørringen.</returns>
    ''' <remarks></remarks>
    Public Function selectEmployeeById(id As String) As DataTable
        Return dao.selectEmployeeById(id)
    End Function

    ''' <summary>
    ''' Henter alle ansatte fra databasen.
    ''' </summary>
    ''' <returns>En datatabell fra DAO basert på resultatet av spørringen.</returns>
    ''' <remarks></remarks>
    Public Function getAllEmployees() As DataTable
        Return dao.getAllEmployees()
    End Function

    ''' <summary>
    ''' Søker etter ansatte i databasen. Brukes i forbindelse med informasjon i tekstfelt i Form.
    ''' Lager derfor informasjonen den trenger underveis. Se EmployeeDAO for detaljer.
    ''' </summary>
    ''' <returns>En datatabell fra DAO basert på resultatet av spørringen.</returns>
    ''' <remarks></remarks>
    Public Function searchEmployee() As DataTable
        Return dao.searchEmployee(makeList())
    End Function

    ''' <summary>
    ''' Henter ut verdien til aktivert-attributtet fra databasen basert på id.
    ''' </summary>
    ''' <param name="id">AnsattID.</param>
    ''' <returns>True hvis aktivert = 1, False hvis ikke.</returns>
    ''' <remarks>Funksjonshodet definerer Boolean som returtype. Variabelen som returneres er derimot
    ''' en heltallsvariabel. Dette går bra ettersom aktivert kun kan returnere 0 eller 1 fra databasen.</remarks>
    Public Function isActive(id As String) As Boolean
        table = dao.isActive(id)
        Dim active As Integer
        If table.Rows.Count = 1 Then
            active = table.Rows(0)(0)
        End If
        Return active
    End Function

    ''' <summary>
    ''' Finner poststed basert på postnummer i databasen.
    ''' </summary>
    ''' <param name="zipcode">Postnummer som skal brukes i søk.</param>
    ''' <returns>En tekstrepresentasjon av poststed.</returns>
    ''' <remarks></remarks>
    Public Function getAreaByZipCode(zipcode As String) As String
        Return dao.getAreaByZipCode(zipcode)
    End Function

    ''' <summary>
    ''' Sjekker databasen for tilsvarende brukernavn.
    ''' </summary>
    ''' <param name="username">Brukernavn det skal søkes etter.</param>
    ''' <returns>Antall brukernavn som stemmer overens med argumentet.</returns>
    ''' <remarks></remarks>
    Public Function usernameCheck(username As String) As Integer
        Return dao.usernameCheck(username)
    End Function

    ''' <summary>
    ''' Henter ut passordverdien (hashet) fra databasen for et bestemt brukernavn.
    ''' </summary>
    ''' <param name="username">Brukernavn det skal søkes etter.</param>
    ''' <returns>En tekstrepresentasjon av hash-verdien for brukernavn sendt med som argument.</returns>
    ''' <remarks></remarks>
    Public Function getPasswordHashByUsername(username As String) As String
        table = dao.getPasswordHashByUsername(username)
        Return table.Rows(0)(0)
    End Function

    ''' <summary>
    ''' Skriver postnummer og poststed til databasen.
    ''' </summary>
    ''' <param name="zip">Postnummer.</param>
    ''' <param name="area">Poststed.</param>
    ''' <remarks>Må gjøres før ansatt kan skrives til databasen slik
    ''' at referanseintegriteten mellom ansatt- og poststed-tabell opprettholdes.</remarks>
    Public Sub createZipCode(zip As String, area As String)
        dao.createZipCode(zip, area)
    End Sub

    ''' <summary>
    ''' Sjekker om postnummer allerede eksisterer i databasen.
    ''' </summary>
    ''' <param name="zip">Postnummer det skal søkes etter.</param>
    ''' <returns>True hvis postnummer eksisterer, False hvis ikke.</returns>
    ''' <remarks></remarks>
    Public Function zipCodeExists(zip As String) As Boolean
        Return dao.zipCodeExists(zip)
    End Function

    ''' <summary>
    ''' Hjelpemetode. Lager liste som sendes til DAO.
    ''' </summary>
    ''' <returns>En liste bestående innholdet i alle objektvariablene for objektet.</returns>
    ''' <remarks>Se EmployeeDAO for bruk.</remarks>
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

    'GET- og SET-metoder for Employee.
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
End Class
