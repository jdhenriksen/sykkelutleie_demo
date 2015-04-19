''' <summary>
''' DAO-klasse som håndterer databasekommunikasjon logisk tilhørende Order.
''' </summary>
''' <remarks></remarks>
Public Class OrderDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    ''' <summary>
    ''' Skriver et ordre-objekt til databasen.
    ''' </summary>
    ''' <param name="list">Liste som representerer kolonneverdier i databasen 
    ''' i form av objektvariabler.</param>
    ''' <remarks></remarks>
    Public Sub createOrder(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlCreateOrder)
    End Sub

    ''' <summary>
    ''' Skriver til koblingstabell mellom bestilling og sykkel. Utføres når ordre registreres.
    ''' </summary>
    ''' <param name="orderID">BestillingsID.</param>
    ''' <param name="frameNumber">Rammenummer.</param>
    ''' <remarks></remarks>
    Public Sub createBikeOrder(orderID As String, frameNumber As String)
        dbutil.addParametersToQuery("@orderID", orderID)
        dbutil.addParametersToQuery("@frameNumber", frameNumber)
        dbutil.query(SQLRes.sqlCreateBikeOrder)
    End Sub

    ''' <summary>
    ''' Henter ut seneste ordre fra databasen.
    ''' </summary>
    ''' <returns>En tekstrepresentasjon av siste ordrenummer (bestillingsID).</returns>
    ''' <remarks></remarks>
    Public Function getLatestOrder() As String
        table = dbutil.query(SQLRes.sqlGetLatestOrder)
        Return table.Rows(0)(0)
    End Function

    ''' <summary>
    ''' Skriver til koblingstabell mellom tilleggsutstyr og bestilling. Utføres når ordre registreres.
    ''' </summary>
    ''' <param name="orderID">BestillingsID.</param>
    ''' <param name="equipmentID">Varenummer.</param>
    ''' <remarks></remarks>
    Public Sub createEquipmentOrder(orderID As String, equipmentID As String)
        dbutil.addParametersToQuery("@orderID", orderID)
        dbutil.addParametersToQuery("@equipmentID", equipmentID)
        dbutil.query(SQLRes.sqlCreateEquipmentOrder)
    End Sub

    ''' <summary>
    ''' Endrer en eksisterende bestilling i databasen.
    ''' </summary>
    ''' <param name="list">Liste med objektvariabler som representerer verdier som skal endres.</param>
    ''' <remarks></remarks>
    Public Sub editOrder(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlEditOrder)
    End Sub

    ''' <summary>
    ''' Henter utvalgt informasjon om sykler og modell for bruk i bestillings-Form.
    ''' </summary>
    ''' <param name="framenumber">Rammenummer for sykkel.</param>
    ''' <returns>En datatabell som viser aktuell informasjon om valgt sykkel.</returns>
    ''' <remarks>Brukes for å hente informasjon fra GridView i bestillings-Form 
    ''' og overføre denne informasjonen til tekstfelter.</remarks>
    Public Function getBikeJoinModel(framenumber As String) As DataTable
        dbutil.addParametersToQuery("@framenumber", framenumber)
        table = dbutil.query(SQLRes.sqlGetBikeJoinModel)
        Return table
    End Function

    ''' <summary>
    ''' Søker etter ordre i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <returns>En datatabell som inneholder alle ordre som stemmer overens med søket.</returns>
    ''' <remarks>Brukes ved søk i tekstfelt i Form.</remarks>
    Public Function searchOrder(list As List(Of String)) As DataTable
        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.query(SQLRes.sqlSearchOrder)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut informasjon om ordre basert på ordrenummer (bestillingsID i database).
    ''' </summary>
    ''' <param name="id">BestillingsID det skal søkes etter.</param>
    ''' <returns>En datatabell med informasjon om aktuell ordre.</returns>
    ''' <remarks></remarks>
    Public Function selectOrderById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.query(SQLRes.sqlSelectOrderById)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alle ordre i databasen.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om alle ordre i databasen.</returns>
    ''' <remarks></remarks>
    Public Function selectAllOrders() As DataTable
        table = dbutil.query(SQLRes.sqlSelectAllOrders)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Legger til informasjon fra makeList()-metoden i Order som spørringsparametere.
    ''' </summary>
    ''' <param name="list">Liste fra makeList()-metode i Order.
    ''' Representerer verdier for alle objektvariabler.</param>
    ''' <remarks></remarks>
    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@from", list(0))
            .addParametersToQuery("@to", list(1))
            .addParametersToQuery("@employeeID", list(2))
            .addParametersToQuery("@customerID", list(3))
            .addParametersToQuery("@sum", list(4), DbType.Decimal)
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
