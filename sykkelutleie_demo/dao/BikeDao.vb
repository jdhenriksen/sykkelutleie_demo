''' <summary>
''' DAO-klasse som håndterer databasekommunikasjon logisk tilhørende Bike.
''' </summary>
''' <remarks></remarks>
Public Class BikeDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    ''' <summary>
    ''' Skriver et sykkel-objekt til databasen.
    ''' </summary>
    ''' <param name="list">Liste som representerer kolonneverdier i databasen 
    ''' i form av verdier på objektvariabler.</param>
    ''' <remarks></remarks>
    Public Sub createBike(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlCreateBike)
    End Sub

    ''' <summary>
    ''' Endrer en eksisterende sykkel i databasen.
    ''' </summary>
    ''' <param name="list">Liste med verdier som skal endres i databasen.</param>
    ''' <remarks></remarks>
    Public Sub editBike(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlEditBike)
    End Sub

    ''' <summary>
    ''' Sletter en sykkel fra databasen basert på rammenummer (ID i databasen).
    ''' </summary>
    ''' <param name="framenumber">Rammenummer tilhørende sykkel som skal slettes.</param>
    ''' <remarks></remarks>
    Public Sub deleteBike(framenumber As String)
        dbutil.addParametersToQuery("@framenumber", framenumber)
        dbutil.query(SQLRes.sqlDeleteBike)
    End Sub

    ''' <summary>
    ''' Søker etter sykler i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <returns>En datatabell som inneholder alle sykler som stemmer overens med søket.</returns>
    ''' <remarks>Brukes ved søk i tekstfelt i Form.</remarks>
    Public Function searchBike(list As List(Of String)) As DataTable
        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.query(SQLRes.sqlSearchBike)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut modellnavn for en sykkel basert på rammenummer.
    ''' </summary>
    ''' <param name="framenumber">Rammenummer til sykkel som modell skal finnes for.</param>
    ''' <returns>En datatabell som inneholder modell som tilhører aktuell sykkel.</returns>
    ''' <remarks></remarks>
    Public Function getModelName(framenumber As String) As DataTable
        dbutil.addParametersToQuery("@framenumber", framenumber)
        table = dbutil.query(SQLRes.sqlGetModelName)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut en sykkel fra databasen basert på rammenummer.
    ''' </summary>
    ''' <param name="framenumber">Rammenummer det skal søkes etter.</param>
    ''' <returns>En datatabell som inneholder informasjon om aktuell sykkel.</returns>
    ''' <remarks></remarks>
    Public Function selectBikeById(framenumber As String) As DataTable
        dbutil.addParametersToQuery("@framenumber", framenumber)
        table = dbutil.query(SQLRes.sqlSelectBikeById)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alle sykler fra databasen.
    ''' </summary>
    ''' <returns>En database som inneholder informasjon om alle sykler i databasen.</returns>
    ''' <remarks></remarks>
    Public Function selectAllBikes() As DataTable
        table = dbutil.query(SQLRes.sqlSelectAllBikes)
        Return table
    End Function

    ''' <summary>
    ''' Setter alle sykler til å ikke være under bestilling.
    ''' </summary>
    ''' <remarks>I praksis settes under_bestilling-attributtet til 0.</remarks>
    Public Sub setAllBikesNotUnderOrder()
        dbutil.query(SQLRes.sqlSetAllBikesNotUnderOrder)
    End Sub

    Public Function missingBikes()
        table = dbutil.query(SQLRes.sqlMissingBikes)
        Return table
    End Function

    ''' <summary>
    ''' Setter en sykkel til å være under bestilling basert på rammenummer.
    ''' </summary>
    ''' <param name="framenumber">Rammenummer for sykkel som skal settes under bestilling.</param>
    ''' <remarks>I praksis settes under_bestilling-attributtet til 1.</remarks>
    Public Sub setBikeUnderOrder(framenumber As String)
        dbutil.addParametersToQuery("@framenumber", framenumber)
        dbutil.query(SQLRes.sqlSetBikeUnderOrder)
    End Sub

    ''' <summary>
    ''' Søker etter sykler og tilhørende modellinformasjon i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <returns>En datatabell som inneholder alle sykler og deres modellinformasjon
    ''' som stemmer overens med søket.</returns>
    ''' <remarks>Brukes ved søk i tekstfelt i Form.</remarks>
    Public Function searchBicycleModel(list As List(Of String), price As Double, producer As String, category As String) As DataTable
        'Legger til ekstra parametere til spørringen som er nødvendige for join mot modell-tabell.
        list.Add(producer)
        list.Add(category)

        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next

        populateList(list)
        dbutil.addParametersToQuery("@price", price, DbType.Decimal)
        dbutil.addParametersToQuery("@producer", list(9))
        dbutil.addParametersToQuery("@category", list(10))

        table = dbutil.query(SQLRes.sqlSearchBicycleModel)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Legger til informasjon fra makeList()-metoden i Bike som spørringsparametere.
    ''' </summary>
    ''' <param name="list">Liste fra makeList()-metode i Bike.
    ''' Representerer verdier for alle objektvariabler.</param>
    ''' <remarks></remarks>
    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@framenumber", list(0))
            .addParametersToQuery("@status", list(1))
            .addParametersToQuery("@location", list(2))
            .addParametersToQuery("@placeOfOrigin", list(3))
            .addParametersToQuery("@brakes", list(4))
            .addParametersToQuery("@tires", list(5))
            .addParametersToQuery("@frame", list(6))
            .addParametersToQuery("@gear", list(7))
            .addParametersToQuery("@model", list(8))
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
