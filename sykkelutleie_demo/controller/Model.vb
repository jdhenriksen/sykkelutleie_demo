''' <summary>
''' Klasse som håndterer funksjonalitet forbundet med modell-objekter.
''' </summary>
''' <remarks></remarks>
Public Class Model
    Private listofEquipment As List(Of Equipment)
    Property model As String
    Property price As Double
    Property producer As String
    Property category As String

    Private table As New DataTable
    Private dao As New ModelDao

    ''' <summary>
    ''' Konstruktør som setter alle objektvariabler.
    ''' </summary>
    ''' <param name="model">Modellnavn.</param>
    ''' <param name="price">Pris.</param>
    ''' <param name="producer">Produsent.</param>
    ''' <param name="category">Kategori.</param>
    ''' <remarks></remarks>
    Public Sub New(model As String, price As Double, producer As String, category As String)
        Me.model = model
        Me.price = price
        Me.producer = producer
        Me.category = category
    End Sub

    ''' <summary>
    ''' Standardkonstruktør. Brukes hvis et objekt er nødvendig med det ikke
    ''' foreligger konkret informasjon.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Skriver et modell-objekt til databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub createModel()
        dao.createModel(makeList())
    End Sub

    ''' <summary>
    ''' Endrer en eksisterende modell i databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub editModel()
        dao.editModel(makeList())
    End Sub

    ''' <summary>
    ''' Søker etter modeller i databasen på en dynamisk måte.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om modeller som stemmer overens med søk.</returns>
    ''' <remarks></remarks>
    Public Function searchModel() As DataTable
        table = dao.searchModel(makeList())
        Return table
    End Function

    ''' <summary>
    ''' Henter ut alle modeller i databasen.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om alle modeller i databasen.</returns>
    ''' <remarks></remarks>
    Public Function selectAllModels() As DataTable
        table = dao.selectAllModels()
        Return table
    End Function

    ''' <summary>
    ''' Henter ut en modell basert på modellnavn (ID i databasen).
    ''' </summary>
    ''' <param name="model"></param>
    ''' <returns>En datatabell med informasjon om aktuell modell.</returns>
    ''' <remarks></remarks>
    Public Function getModelById(model As String) As DataTable
        table = dao.getModelById(model)
        Return table
    End Function

    ''' <summary>
    ''' Hjelpemetode. Lager liste som sendes til DAO.
    ''' </summary>
    ''' <returns>En liste bestående innholdet i alle objektvariablene for objektet.</returns>
    ''' <remarks>Se ModelDAO for bruk.</remarks>
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(getModel())
        list.Add(getPrice())
        list.Add(getProducer())
        list.Add(getCategory())
        Return list
    End Function

    'GET-metoder for objektvariabler.
    Public Function getModel() As String
        Return model
    End Function

    Public Function getPrice() As String
        If price = 0 Then
            Return ""
        Else
            Return price
        End If
    End Function

    Public Function getProducer() As String
        Return producer
    End Function

    Public Function getCategory() As String
        Return category
    End Function
End Class
