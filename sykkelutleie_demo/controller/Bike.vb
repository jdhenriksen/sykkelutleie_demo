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
    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim myData As New DataTable




    ''' <summary>
    ''' Nytt bikeobject
    ''' </summary>
    ''' <remarks>Tar i mot modellobjektet i tilegg til alle de andre parametere</remarks>
    Public Sub New(ByVal framenb As String, ByVal stat As String,
                    ByVal loc As String, ByVal placeorigin As String,
                    ByVal brake As String, ByVal tire As String,
                    ByVal framename As String, ByVal gearname As String, ByRef modelobject As Object)

        frameNumber = framenb
        status = stat
        location = loc
        placeOfOrigin = placeorigin
        brakes = brake
        tires = tire
        frame = framename
        gear = gearname
        model = modelobject

    End Sub
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Ny sykkel
    ''' </summary>
    ''' <remarks>Hvis True altså utført får vi bekreftelse</remarks>
    Public Sub createBike()

        dao.createBike(makeList())

    End Sub
    ''' <summary>
    ''' Søk etter sykkel
    ''' </summary>
    ''' <remarks>Fyller datagridview for sykkel med reultater</remarks>
    Public Function searchBike()

        myData = dao.searchBike(makeList())

        Return myData

    End Function
    ''' <summary>
    ''' Endre Sykkel
    ''' </summary>
    ''' <remarks>oppdatering av sykkelinfo, alle bokser og felter oppdateres
    ''' Hvis bekreftet svar= True så gir vi bekreftelse til bruker</remarks>
    Public Sub changeBike()

        dao.editBike(makeList())

    End Sub
    ''' <summary>
    ''' Slette sykkel
    ''' </summary>
    ''' <remarks>Bruker også objectet, men trenger kun modellnavn
    ''' Returnerer også svar i form av msgbox()</remarks>
    Public Sub deleteBike()

        dao.deleteBike(getFrameNumber())

    End Sub


    Public Function getBike(ByVal chosenbike As String)

        myData = dao.getBike(chosenbike)

        Return myData

    End Function

    ''' <summary>
    ''' Finner sykkel og modelldata 
    ''' </summary>
    ''' <returns>Datatabell basert på sql spørring</returns>
    ''' <remarks>Joiner sykkel og modell for å gi data fra begge</remarks>
    Function searchBicycleModel(bike As Bike) As DataTable



        myData = dao.searchBicycleModel(bike.makeList(), bike.model.price, bike.model.getProducer, bike.model.getCategory)

        Return myData

    End Function

    Public Sub setBikeUnderOrder(bicycleID As String)

        dao.setBikeUnderOrder(bicycleID)

    End Sub

    Public Sub setAllBikesNotUnderOrder()

        dao.setAllBikesNotUnderOrder()

    End Sub

    Public Function getFrameNumber()
        Return frameNumber
    End Function
    Public Function getStatus()
        Return status
    End Function
    Public Function getLocation()
        Return location
    End Function
    Public Function getPlaceOfOrigins()
        Return placeOfOrigin
    End Function
    Public Function getTires()
        Return tires
    End Function
    Public Function getFrame()
        Return frame
    End Function
    Public Function getGear()
        Return gear
    End Function
    Public Function getModel()
        Return model.getModel()
    End Function

    'DAO
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)

        list.Add(getFrameNumber())
        list.Add(getStatus())
        list.Add(getLocation())
        list.Add(getPlaceOfOrigins())
        list.Add(brakes)
        list.Add(getTires())
        list.Add(getFrame())
        list.Add(getGear())
        list.Add(model.getModel())

        Return list

    End Function
End Class
