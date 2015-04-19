''' <summary>
''' DAO-klasse som håndterer databasekommunikasjon logisk tilhørende Model.
''' </summary>
''' <remarks></remarks>
Public Class ModelDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    ''' <summary>
    ''' Skriver et modell-objekt til databasen.
    ''' </summary>
    ''' <param name="list">Liste med verdier som skal skrives (alle objektvariabler).</param>
    ''' <remarks></remarks>
    Public Sub createModel(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlCreateModel)
    End Sub

    ''' <summary>
    ''' Endrer en eksisterende modell i databasen.
    ''' </summary>
    ''' <param name="list">Liste med verdier som skal skrives (endres): alle objektvariabler.</param>
    ''' <remarks></remarks>
    Public Sub editModel(list As List(Of String))
        populateList(list)
        dbutil.query(SQLRes.sqlEditModel)
    End Sub

    ''' <summary>
    ''' Søker etter modeller i databasen på en dynamisk måte.
    ''' </summary>
    ''' <param name="list">Liste som representerer alle kolonneverdiene i databasen.</param>
    ''' <returns>En datatabell som inneholder alle modeller som stemmer overens med søket.</returns>
    ''' <remarks>Brukes ved søk i tekstfelt i Form.</remarks>
    Public Function searchModel(list As List(Of String)) As DataTable
        'Lager en matrise basert på listen og legger informasjonen tilbake i listen.
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.query(SQLRes.sqlSearchModel)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut prisen til en modell direkte fra databasen basert på modellnavn.
    ''' </summary>
    ''' <param name="model">Modellnavn det skal søkes etter.</param>
    ''' <returns>En datatabell bestående av pris for aktuell modell</returns>
    ''' <remarks></remarks>
    Public Function getPrice(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.query(SQLRes.sqlGetModelPrice)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut produsent for en modell direkte fra databasen basert på modellnavn.
    ''' </summary>
    ''' <param name="model">Modellnavn det skal søkes etter.</param>
    ''' <returns>En datatabell bestående av produsent for angitt modell.</returns>
    ''' <remarks></remarks>
    Public Function getProducer(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.query(SQLRes.sqlGetModelProducer)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut kategori for en modell direkte fra databasen basert på modellnavn.
    ''' </summary>
    ''' <param name="model">Modellnavn det skal søkes etter.</param>
    ''' <returns>En datatabell bestående av produsent for angitt modell.</returns>
    ''' <remarks></remarks>
    Public Function getCategory(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.query(SQLRes.sqlGetModelCategory)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alle modeller i databasen.
    ''' </summary>
    ''' <returns>En datatabell som inneholder alle modeller i databasen.</returns>
    ''' <remarks></remarks>
    Public Function selectAllModels() As DataTable
        table = dbutil.query(SQLRes.sqlSelectAllModels)
        Return table
    End Function

    ''' <summary>
    ''' Henter ut en modell basert på modellnavn (ID i databasen).
    ''' </summary>
    ''' <param name="model">Modellnavn det skal søkes etter.</param>
    ''' <returns>En datatabell bestående av informasjon om aktuell modell.</returns>
    ''' <remarks></remarks>
    Public Function getModelById(ByVal model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.query(SQLRes.sqlGetModelById)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode: Legger til informasjon fra makeList()-metoden i Model som spørringsparametere.
    ''' </summary>
    ''' <param name="list">Liste fra makeList()-metode i Model.
    ''' Representerer verdier for alle objektvariabler.</param>
    ''' <remarks></remarks>
    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@model", list(0))
            .addParametersToQuery("@price", list(1))
            .addParametersToQuery("@producer", list(2))
            .addParametersToQuery("@category", list(3))
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
