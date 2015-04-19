''' <summary>
''' DAO-klasse som logisk henger sammen med Employee.
''' </summary>
''' <remarks>Blir også brukt av andre klasser for kommunikasjon mot ansatt-tabell i databasen.</remarks>
Public Class EmployeeDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    ''' <summary>
    ''' Sender spørring som skriver en ansatt til databasen.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <remarks></remarks>
    Public Sub createEmployee(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlCreateEmployee)
    End Sub

    ''' <summary>
    ''' Sender spørring som endrer informasjonen om en ansatt i databasen.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <param name="id">AnsattID som identifiserer den ansatte i databasen.</param>
    ''' <remarks>Alle verdiene oppdateres, selv om bare enkelte har blitt endret.</remarks>
    Public Sub editEmployee(list As List(Of String), id As String)
        populateList(list)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlEditEmployee)
    End Sub

    ''' <summary>
    ''' Sletter en ansatt fra databasen.
    ''' </summary>
    ''' <param name="id">AnsattID som identifiserer den ansatte i databasen.</param>
    ''' <remarks>I praksis settes kun aktivert-attributtet til 0.</remarks>
    Public Sub deleteEmployee(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlDeleteEmployee)
    End Sub

    ''' <summary>
    ''' Søker etter ansatte i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <returns>En datatabell som inneholder alle ansatte som stemmer overens med søket.</returns>
    ''' <remarks>Brukes ved søk i tekstfelt i Form.</remarks>
    Public Function searchEmployee(list As List(Of String)) As DataTable
        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next

        populateList(list)
        table = dbutil.query(SQLRes.sqlSearchEmployee)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alle ansatte i databasen.
    ''' </summary>
    ''' <returns>En datatabell som inneholder alle aktiverte ansatte i databasen.</returns>
    ''' <remarks></remarks>
    Public Function getAllEmployees() As DataTable
        Return dbutil.query(SQLRes.sqlGetAllEmployees)
    End Function

    ''' <summary>
    ''' Henter ut en ansatt med en spesifikk ansattID.
    ''' </summary>
    ''' <param name="id">AnsattID det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder den ansatte med ID fra argument.</returns>
    ''' <remarks></remarks>
    Public Function selectEmployeeById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.query(SQLRes.sqlSelectEmployeeById)
        Return table
    End Function

    ''' <summary>
    ''' Sjekker aktivert-attributtet for en ansatt med spesifisert ID.
    ''' </summary>
    ''' <param name="id">AnsattID det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder aktivert-verdien til ansatt med ID fra argument.</returns>
    ''' <remarks></remarks>
    Public Function isActive(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.query(SQLRes.sqlIsActive)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut hash-verdien til en ansatt basert på brukernavn.
    ''' </summary>
    ''' <param name="username">Brukernavn det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder hashet passordet til ansatt.</returns>
    ''' <remarks></remarks>
    Public Function getPasswordHashByUsername(username As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        table = dbutil.query(SQLRes.sqlGetPasswordHashByUsername)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut poststed basert på postnummer.
    ''' </summary>
    ''' <param name="zipcode">Postnummer det skal søkes etter.</param>
    ''' <returns>En tekstrepresentasjon av poststed.</returns>
    ''' <remarks></remarks>
    Public Function getAreaByZipCode(zipcode As String) As String
        dbutil.addParametersToQuery("@zipcode", zipcode)
        table = dbutil.query(SQLRes.sqlGetAreaByZipCode)
        If table.Rows.Count > 0 Then
            Return table.Rows(0)(0)
        End If
        Return ""
    End Function

    ''' <summary>
    ''' Sjekker hvor mange forekomster av et brukernavn det finnes i databasen.
    ''' </summary>
    ''' <param name="username">Brukernavn det skal søkes etter.</param>
    ''' <returns>Antall brukernavn som stemmer overens med argument.</returns>
    ''' <remarks></remarks>
    Public Function usernameCheck(username As String) As Integer
        dbutil.addParametersToQuery("@username", username)
        table = dbutil.query(SQLRes.sqlUsernameCheck)
        Return table.Rows.Count
    End Function

    ''' <summary>
    ''' Håndterer databasekommunikasjon i forbindelse med innlogging.
    ''' </summary>
    ''' <param name="username">Brukernavn.</param>
    ''' <param name="password">Passord.</param>
    ''' <returns>En datatabell som inneholder stillingsbeskrivelsen til aktuell bruker
    ''' basert på brukernavn og passord.</returns>
    ''' <remarks></remarks>
    Public Function login(username As String, password As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        dbutil.addParametersToQuery("@password", password)
        table = dbutil.query(SQLRes.sqlLogin)
        Return table
    End Function

    ''' <summary>
    ''' Skriver postnummer og poststed til poststed-tabell i databasen.
    ''' </summary>
    ''' <param name="zip">Postnummer.</param>
    ''' <param name="area">Poststed.</param>
    ''' <remarks></remarks>
    Public Sub createZipCode(zip As String, area As String)
        dbutil.addParametersToQuery("@zip", zip)
        dbutil.addParametersToQuery("@area", area)
        dbutil.query(SQLRes.sqlCreateZipCode)
    End Sub

    ''' <summary>
    ''' Sjekker om postnummer eksisterer i poststed-tabellen.
    ''' </summary>
    ''' <param name="zip">Postnummer det skal søkes etter.</param>
    ''' <returns>True hvis postnummer eksisterer, False hvis ikke.</returns>
    ''' <remarks></remarks>
    Public Function zipCodeExists(zip As String) As Boolean
        dbutil.addParametersToQuery("@zip", zip)
        Dim exists As Boolean = False
        table = dbutil.query(SQLRes.sqlZipCodeExists)
        If table.Rows.Count > 0 Then
            exists = True
        End If
        Return exists
    End Function

    ''' <summary>
    ''' Sender en spørring som produserer et resultat som gjør det mulig å sette
    ''' delt variabel i Account ('session'-variabel). Henter ansattID basert på brukernavn.
    ''' </summary>
    ''' <param name="username">Brukernavn det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder ansattID tilhørende brukernavn i argument.</returns>
    ''' <remarks></remarks>
    Public Function setUserId(username As String) As DataTable
        dbutil.addParametersToQuery("@username", username)
        table = dbutil.query(SQLRes.sqlSetUserId)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Legger til informasjon fra makeList()-metoden i Employee som spørringsparametere.
    ''' </summary>
    ''' <param name="list">Liste fra makeList()-metode i Employee.
    ''' Representerer verdier for alle objektvariabler.</param>
    ''' <remarks></remarks>
    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@username", list(0))
            .addParametersToQuery("@password", list(1))
            .addParametersToQuery("@firstname", list(2))
            .addParametersToQuery("@lastname", list(3))
            .addParametersToQuery("@phone", list(4))
            .addParametersToQuery("@email", list(5))
            .addParametersToQuery("@address", list(6))
            .addParametersToQuery("@job", list(7))
            .addParametersToQuery("@zip", list(8))
            .addParametersToQuery("@active", list(9))
        End With
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Brukes for å støtte opp om bruk av wildcards i søk i databasen.
    ''' Legger til '%' før og etter spørringsparameterens verdi.
    ''' </summary>
    ''' <param name="inputList">Liste med verdier som skal ha wildcards.</param>
    ''' <returns>En matrise som representerer den endrede listen.</returns>
    ''' <remarks>Grunnen til at det ikke returnes en vanlig liste er forbundet
    ''' med problematikk i forhold til å endre innholdet i listen. En matrise
    ''' returneres derfor i stedet.</remarks>
    Private Function prepareForSearch(inputList As List(Of String)) As String()
        Dim i As Integer
        Dim listItemLength As Integer 'Representerer lengden til hver enkelt verdi.
        Dim list(inputList.Count - 1) As String

        'Går gjennom listen og legger til wildcards. Kopierer dette over til matrisen.
        For i = 0 To inputList.Count - 1
            'If-delen gjelder for 'tomme' verdier.
            'Else-delen gjelder for verdier som ikke er 'tomme'.
            If String.IsNullOrEmpty(inputList(i)) Or inputList(i) = Nothing Then
                list(i) = String.Format("%{0}%", inputList(i))
            Else
                listItemLength = inputList(i).Length
                list(i) = String.Format("%{0," & listItemLength & "}%", inputList(i))
            End If
        Next
        Return list
    End Function
End Class
