''' <summary>
''' DAO som håndterer databasekommunikasjon logisk tilhørende Customer.
''' </summary>
''' <remarks></remarks>
Public Class CustomerDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    ''' <summary>
    ''' Skriver en kunde til databasen.
    ''' </summary>
    ''' <param name="list">Liste med objektvariabler som representerer kolonneverdier i databasen.</param>
    ''' <remarks></remarks>
    Public Sub createCustomer(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlCreateCustomer)
    End Sub

    ''' <summary>
    ''' Endrer kundeinformasjon basert på kundeID.
    ''' </summary>
    ''' <param name="list">Liste med ny informasjon om aktuell kunde.</param>
    ''' <param name="id">KundeID for aktuell kunde som skal få endret informasjon.</param>
    ''' <remarks></remarks>
    Public Sub editCustomer(list As List(Of String), id As String)
        populateList(list)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlEditCustomer)
    End Sub

    ''' <summary>
    ''' Sletter en kunde fra databasen basert på kundeID.
    ''' </summary>
    ''' <param name="id">KundeID for aktuell kunde som skal slettes.</param>
    ''' <remarks>I praksis settes aktivert-attributtet i databasen til '0'.</remarks>
    Public Sub deleteCustomer(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlDeleteCustomer)
    End Sub

    ''' <summary>
    ''' Søker etter kunder i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <returns>En datatabell som inneholder alle kunder som stemmer overens med søket.</returns>
    ''' <remarks>Brukes ved søk i tekstfelt i Form.</remarks>
    Public Function searchCustomer(list As List(Of String)) As DataTable
        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.query(SQLRes.sqlSearchCustomer)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alle aktive kunder fra databasen.
    ''' </summary>
    ''' <returns>En datatabell som inneholder informasjon tilhørende alle aktive kunder.</returns>
    ''' <remarks>Helt konkret er det verdien til aktivert-attributtet som bestemmer resultatet.</remarks>
    Public Function getActiveCustomers() As DataTable
        table = dbutil.query(SQLRes.sqlGetActiveCustomers)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut informasjon om en kunde basert på kundeID.
    ''' </summary>
    ''' <param name="id">KundeID det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder informasjon om aktuell kunde.</returns>
    ''' <remarks></remarks>
    Public Function selectCustomerById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.query(SQLRes.sqlSelectCustomerById)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Legger til informasjon fra makeList()-metoden i Customer som spørringsparametere.
    ''' </summary>
    ''' <param name="list">Liste fra makeList()-metode i Customer.
    ''' Representerer verdier for alle objektvariabler.</param>
    ''' <remarks></remarks>
    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@firstname", list(0))
            .addParametersToQuery("@lastname", list(1))
            .addParametersToQuery("@phone", list(2))
            .addParametersToQuery("@email", list(3))
            .addParametersToQuery("@active", list(4))
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
