''' <summary>
''' Klasse som håndterer funksjonalitet forbundet med sykkel-objekter.
''' </summary>
''' <remarks></remarks>
Public Class Bike
    Property frameNumber As String
    Property status As String
    Property location As String
    Property placeOfOrigin As String
    Property brakes As String
    Property tires As String
    Property frame As String
    Property gear As String
    Property model As New Model
    Property equipmentList As New List(Of Equipment)
    Private dao As New BikeDao
    Private myData As New DataTable

    ''' <summary>
    ''' Konstruktør som setter alle objektvariabler.
    ''' </summary>
    ''' <param name="frameNumber">Rammenummer.</param>
    ''' <param name="status">Status.</param>
    ''' <param name="location">Nåværende sted.</param>
    ''' <param name="placeOfOrigin">Opprinnelsessted.</param>
    ''' <param name="brakes">Bremsetype.</param>
    ''' <param name="tires">Dekktype.</param>
    ''' <param name="frame">Rammetype.</param>
    ''' <param name="gear">Girtype.</param>
    ''' <param name="model">Tilhørende modell.</param>
    ''' <remarks></remarks>
    Sub New(frameNumber As String, status As String, location As String, placeOfOrigin As String, _
                    brakes As String, tires As String, frame As String, gear As String, model As Model)
        Me.frameNumber = frameNumber
        Me.status = status
        Me.location = location
        Me.placeOfOrigin = placeOfOrigin
        Me.brakes = brakes
        Me.tires = tires
        Me.frame = frame
        Me.gear = gear
        Me.model = model
    End Sub

    ''' <summary>
    ''' Standardkonstrukør. Brukes når det er nødvendig med et objekt 
    ''' men konkret informasjon ikke foreligger.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Skriver et sykkel-objekt til databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub createBike()
        dao.createBike(makeList())
    End Sub

    ''' <summary>
    ''' Søker etter sykler i databasen på en dynamisk måte.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om alle sykler som stemmer overens med søk.</returns>
    ''' <remarks></remarks>
    Public Function searchBike() As DataTable
        myData = dao.searchBike(makeList())
        Return myData
    End Function

    ''' <summary>
    ''' Endrer en eksisterende sykkel i databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub changeBike()
        dao.editBike(makeList())
    End Sub

    ''' <summary>
    ''' Sletter en sykkel fra databasen basert på rammenummer (ID i databasen).
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub deleteBike()
        dao.deleteBike(getFrameNumber())
    End Sub

    ''' <summary>
    ''' Henter ut en sykkel fra databasen basert på rammenummer.
    ''' </summary>
    ''' <param name="id">Rammenummer det skal søkes etter.</param>
    ''' <returns>En datatabell med informasjon om aktuell sykkel.</returns>
    ''' <remarks></remarks>
    Public Function selectBikeById(id As String) As DataTable
        myData = dao.selectBikeById(id)
        Return myData
    End Function

    ''' <summary>
    ''' Søker etter sykler og tilhørende modellinformasjon i databasen på en dynamsik måte.
    ''' </summary>
    ''' <returns>En datatabell med sykkel- og modellinformasjon som 
    ''' stemmer overens med søk.</returns>
    ''' <remarks></remarks>
    Function searchBicycleModel() As DataTable
        myData = dao.searchBicycleModel(makeList(), model.price, model.getProducer, model.getCategory)
        Return myData
    End Function

    ''' <summary>
    ''' Setter en sykkel til å være under bestilling basert på rammenummer.
    ''' </summary>
    ''' <param name="id">Rammenummer til aktuell sykkel.</param>
    ''' <remarks></remarks>
    Public Sub setBikeUnderOrder(id As String)
        dao.setBikeUnderOrder(id)
    End Sub

    ''' <summary>
    ''' Setter alle sykler til å ikke være under bestilling.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub setAllBikesNotUnderOrder()
        dao.setAllBikesNotUnderOrder()
    End Sub

    ''' <summary>
    ''' Hjelpemetode. Lager liste som sendes til DAO.
    ''' </summary>
    ''' <returns>En liste bestående innholdet i alle objektvariablene for objektet.</returns>
    ''' <remarks>Se BikeDAO for bruk.</remarks>
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(getFrameNumber())
        list.Add(getStatus())
        list.Add(getLocation())
        list.Add(getPlaceOfOrigins())
        list.Add(getBrakes())
        list.Add(getTires())
        list.Add(getFrame())
        list.Add(getGear())
        list.Add(model.getModel())
        Return list
    End Function

    'GET-metoder for objektvariabler.
    Public Function getFrameNumber() As String
        Return frameNumber
    End Function
    Public Function getStatus() As String
        Return status
    End Function
    Public Function getLocation() As String
        Return location
    End Function
    Public Function getPlaceOfOrigins() As String
        Return placeOfOrigin
    End Function
    Public Function getBrakes() As String
        Return brakes
    End Function
    Public Function getTires() As String
        Return tires
    End Function
    Public Function getFrame() As String
        Return frame
    End Function
    Public Function getGear() As String
        Return gear
    End Function
    Public Function getModel() As String
        Return model.getModel()
    End Function
End Class
