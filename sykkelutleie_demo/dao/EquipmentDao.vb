''' <summary>
''' DAO-klasse som håndterer databasekommunikasjon logisk tilhørende Equipment 
''' og koblingstabell mellom Equipment og Model.
''' </summary>
''' <remarks></remarks>
Public Class EquipmentDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    ''' <summary>
    ''' Skriver tilleggsutstyr til databasen.
    ''' </summary>
    ''' <param name="list">Liste som representerer verdier som skal skrives til databasen.</param>
    ''' <remarks></remarks>
    Public Sub createEquipment(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlCreateEquipment)
    End Sub

    ''' <summary>
    ''' Endrer tilleggsutstyr i databasen.
    ''' </summary>
    ''' <param name="list">Liste som representerer verdier som skal skrives til databasen.</param>
    ''' <remarks></remarks>
    Public Sub editEquipment(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlEditEquipment)
    End Sub

    ''' <summary>
    ''' Sletter tilleggsutstyr fra databasen.
    ''' </summary>
    ''' <param name="id">Varenummer for tilleggsutstyr som skal slettes.</param>
    ''' <remarks>I praksis endres kun status til 'Deaktivert'.</remarks>
    Public Sub deleteEquipment(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlDeleteEquipment)
    End Sub

    ''' <summary>
    ''' Søker etter tilleggsutstyr i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer verdier det skal søkes etter.</param>
    ''' <returns>En datatabell med resultat fra søk.</returns>
    ''' <remarks>Brukes i forbindelse med søk i tekstfelt i Form.</remarks>
    Public Function searchEquipment(list As List(Of String)) As DataTable
        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.query(SQLRes.sqlSearchEquipment)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut all informasjon om tilleggsutstyr basert på varenummer.
    ''' </summary>
    ''' <param name="id">Varenummer det skal søkes etter.</param>
    ''' <returns>En datatabell med informasjon om tilleggsutstyret.</returns>
    ''' <remarks></remarks>
    Public Function selectEquipmentById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.query(SQLRes.sqlSelectEquipmentById)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut all informasjon om alt tilleggsutstyr.
    ''' </summary>
    ''' <returns>En datatabell bestående av all informasjon om alt tilleggsustyr i databasen.</returns>
    ''' <remarks></remarks>
    Public Function selectAllEquipment() As DataTable
        table = dbutil.query(SQLRes.sqlSelectAllEquipment)
        Return table
    End Function

    ''' <summary>
    ''' Oppretter en kobling mellom tilleggsutstyr og modell for å representere kompatibilitet mellom dem.
    ''' </summary>
    ''' <param name="model">Modellnavn.</param>
    ''' <param name="type">Type tilleggsutstyr.</param>
    ''' <remarks></remarks>
    Public Sub createCompatibility(model As String, type As String)
        'Henter ut varenummer basert på type tilleggsutstyr.
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.query(SQLRes.sqlSelectEquipmentIDOnType)

        'Skriver varenummer og modellnavn til kompatibilitet-tabell i databasen.
        'Dette gjøres for hvert tilleggsutstyr som ble returnert i datatabellen i forrige spørring.
        For Each row As DataRow In table.Rows
            Dim rowVal As String = row("varenr")
            dbutil.addParametersToQuery("@rowVal", rowVal)
            dbutil.addParametersToQuery("@model", model)
            dbutil.query(SQLRes.sqlCreateCompatibility)
        Next
    End Sub

    ''' <summary>
    ''' Henter varenummer for alt tilleggsutstyr som er kompatibelt med en gitt modell.
    ''' </summary>
    ''' <param name="model">Modell det skal søkes etter.</param>
    ''' <returns>En datatabell med alt tilleggsutstyr som er kompatibelt med gitt modell.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentByModel(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.query(SQLRes.sqlGetEquipmentByModel)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut varenummer og pris for tilleggsutstyr basert på type.
    ''' Henter kun ut tilleggsutstyr som er på lager.
    ''' Henter ikke ut tilleggsutstyr som for øyeblikket er under bestilling.
    ''' </summary>
    ''' <param name="type">Type tilleggsutstyr det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder alt tilleggsutstyr som stemmer overens med
    ''' type sendt med som argument.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentID(type As String) As DataTable
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.query(SQLRes.sqlGetEquipmentID)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alt tilleggsutstyr av en viss type som for øyeblikket er under bestilling.
    ''' </summary>
    ''' <param name="type">Type tilleggsutstyr det skal søkes etter.</param>
    ''' <returns>En datatabell bestående av tilleggsutstyr under bestilling.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentIDDuringOrder(type As String) As DataTable
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.query(SQLRes.sqlGetEquipmentIDDuringOrder)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut type tilleggsutstyr basert på varenummer.
    ''' </summary>
    ''' <param name="id">Varenummer det skal søkes etter.</param>
    ''' <returns>En datatabell med type tilleggsutstyr basert på varenummer.</returns>
    ''' <remarks></remarks>
    Public Function getTypeByID(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.query(SQLRes.sqlGetTypeFromID)
        Return table
    End Function

    ''' <summary>
    ''' Fjerner kompatibilitet mellom tilleggsutstyr og modell.
    ''' </summary>
    ''' <param name="model">Modellnavn.</param>
    ''' <param name="type">Varenummer.</param>
    ''' <remarks>Fjerner rad i kompatibel-tabellen som stemmer overens
    ''' med gitt varenummer og modellnavn.</remarks>
    Public Sub removeCompatibility(model As String, type As String)
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.query(SQLRes.sqlSelectEquipmentIDOnType)

        For Each row As DataRow In table.Rows
            Dim rowVal As String = row("varenr")
            dbutil.addParametersToQuery("@rowVal", rowVal)
            dbutil.addParametersToQuery("@model", model)
            dbutil.query(SQLRes.sqlRemoveCompatibility)

        Next

        '  dbutil.addParametersToQuery("@model", model)
        '  dbutil.addParametersToQuery("@id", id)
        '  dbutil.query(SQLRes.sqlRemoveCompatibility)
    End Sub

    ''' <summary>
    ''' Henter ut tilleggsutstyr som er kompatibelt med en modell og ikke er under bestilling.
    ''' Finner kun tilleggsutstyr som er på lager.
    ''' Grupperer på type tilleggsutstyr.
    ''' </summary>
    ''' <param name="model">Modellnavn det skal søkes etter i koblingstabell.</param>
    ''' <returns>En datatabell bestående av tilgjengelig tilleggsutstyr
    ''' som er kompatibelt med gitt modell.</returns>
    ''' <remarks></remarks>
    Public Function getCompatibleEquipment(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.query(SQLRes.sqlCompatibleEquipment)
        Return table
    End Function

    ''' <summary>
    ''' Setter tilleggsutstyr med spesifisert varenummer til å være under bestilling.
    ''' </summary>
    ''' <param name="id">Varenummer for aktuelt tilleggsutstyr.</param>
    ''' <remarks>Setter under_bestilling-attributtet til '1'.</remarks>
    Public Sub setEquipmentUnderOrder(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlSetEquipmentUnderOrder)
    End Sub

    ''' <summary>
    ''' Setter tilleggsutstyr med spesifisert varenummer til å ikke være under bestillling.
    ''' </summary>
    ''' <param name="id">Varenummer for aktuelt tilleggsutstyr.</param>
    ''' <remarks>Setter under_bestilling-attributtet til '0'.</remarks>
    Public Sub setEquipmentNotUnderOrder(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.query(SQLRes.sqlSetEquipmentNotUnderOrder)
    End Sub

    ''' <summary>
    ''' Setter alt tilleggsutstyr til å ikke være under bestilling.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub setAllEquipmentNotUnderOrder()
        dbutil.query(SQLRes.sqlSetAllEquipmentNotUnderOrder)
    End Sub

    ''' <summary>
    ''' Henter ut alt tilleggsutstyr og grupperer etter type.
    ''' </summary>
    ''' <returns>En datatabell som inneholder alt tilleggsutstyr, gruppert etter type.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentGroupByType() As DataTable
        table = dbutil.query(SQLRes.sqlSelectEquipmentGroupByType)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Legger til informasjon fra makeList()-metoden i Equipment som spørringsparametere.
    ''' </summary>
    ''' <param name="list">Liste fra makeList()-metode i Equipment.
    ''' Representerer verdier for alle objektvariabler.</param>
    ''' <remarks></remarks>
    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@id", list(0))
            .addParametersToQuery("@type", list(1))
            .addParametersToQuery("@price", list(2))
            .addParametersToQuery("@status", list(3))
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