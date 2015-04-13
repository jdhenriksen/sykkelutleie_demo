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
    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim myData As New DataTable
    Dim answer As String


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
    Public Function createBike()

        sqlstring = "INSERT INTO sykkel (rammenr, status, lokasjon, utleiested, bremser, dekk, ramme, gir, modell) VALUES ('" & frameNumber & "','" & getStatus() & "','" & getLocation() & "','" & getPlaceOfOrigins() & "','" & brakes & "','" & getTires() & "','" & getFrame() & "','" & getGear() & "','" & getModel() & "')"

        answer = anySqlQuery.updateQuery(sqlstring)

        Return answer

    End Function
    ''' <summary>
    ''' Søk etter sykkel
    ''' </summary>
    ''' <remarks>Fyller datagridview for sykkel med reultater</remarks>
    Public Function searchBike()

        myData = anySqlQuery.selectQuery("SELECT rammenr, modell, lokasjon, status FROM sykkel WHERE (rammenr LIKE '%" & frameNumber & "%') AND (modell LIKE '%" & getModel() & "%') AND (status LIKE '" & getStatus() & "%') AND (lokasjon LIKE '%" & getLocation() & "%') AND (utleiested LIKE '%" & getPlaceOfOrigins() & "%') AND (bremser LIKE '%" & brakes & "%') AND (dekk LIKE '%" & getTires() & "%') AND (ramme LIKE '%" & getFrame() & "%') AND (gir LIKE '%" & getGear() & "%')")

        Return myData

    End Function
    ''' <summary>
    ''' Endre Sykkel
    ''' </summary>
    ''' <remarks>oppdatering av sykkelinfo, alle bokser og felter oppdateres
    ''' Hvis bekreftet svar= True så gir vi bekreftelse til bruker</remarks>
    Public Function changeBike()

        answer = anySqlQuery.updateQuery("UPDATE sykkel SET status ='" & getStatus() & "', lokasjon ='" & getLocation() & "', utleiested='" & getPlaceOfOrigins() & "', bremser='" & brakes & "', dekk= '" & getTires() & "', ramme= '" & getFrame() & "', gir ='" & getGear() & "', modell ='" & getModel() & "' WHERE rammenr ='" & frameNumber & "'")

        Return answer

    End Function
    ''' <summary>
    ''' Slette sykkel
    ''' </summary>
    ''' <remarks>Bruker også objectet, men trenger kun modellnavn
    ''' Returnerer også svar i form av msgbox()</remarks>
    Public Function deleteBike()

        answer = anySqlQuery.updateQuery("UPDATE sykkel SET status ='Deaktivert' WHERE rammenr ='" & frameNumber & "'")

        Return answer

    End Function

    Public Function getModelname(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getModel
        Else

            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            answer = myData.Rows(0)(0).ToString()
            Return answer
        End If

    End Function

    Public Function getPrice(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getPrice
        Else
            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            Dim modellnavn As String = myData.Rows(0)(0).ToString()

            myData = anySqlQuery.selectQuery("SELECT pris FROM modell WHERE modell = '" & modellnavn & "'")
            answer = myData.Rows(0)(0).ToString()
            Return answer
        End If

    End Function

    Public Function getProducer(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getProducer
        Else
            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            Dim modellnavn As String = myData.Rows(0)(0).ToString()

            myData = anySqlQuery.selectQuery("SELECT produsent FROM modell WHERE modell = '" & modellnavn & "'")
            answer = myData.Rows(0)(0).ToString()
            Return answer
        End If

    End Function

    Public Function getCategory(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getCategory
        Else
            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            Dim modellnavn As String = myData.Rows(0)(0).ToString()

            myData = anySqlQuery.selectQuery("SELECT kategori FROM modell WHERE modell = '" & modellnavn & "'")
            answer = myData.Rows(0)(0).ToString()
            Return answer
        End If

    End Function

    Public Function relBike(ByVal chosenbike As String)
        Return anySqlQuery.selectQuery("SELECT modell, status, lokasjon, utleiested, dekk, ramme, gir, bremser FROM sykkel WHERE rammenr ='" & chosenbike & "'")
    End Function

    ''' <summary>
    ''' Finner sykkel og modelldata 
    ''' </summary>
    ''' <returns>Datatabell basert på sql spørring</returns>
    ''' <remarks>Joiner sykkel og modell for å gi data fra begge</remarks>
    Function searchBicycleModel(bike As Bike) As DataTable
        Dim sql As String
        sql = "SELECT rammenr, kategori, pris, produsent, sykkel.modell FROM sykkel JOIN modell ON sykkel.modell=modell.modell WHERE (rammenr LIKE '%" & bike.frameNumber & "%') AND (sykkel.modell LIKE '%" & bike.model.model & "%') AND (status LIKE '%" & "" & "%') AND (lokasjon LIKE '%" & bike.location & "%') AND(utleiested LIKE '%" & bike.placeOfOrigin & "%') AND (pris >=" & bike.model.price & ") AND (produsent LIKE '%" & bike.model.producer & "%') AND (kategori LIKE '%" & bike.model.category & "%' AND sykkel.under_bestilling = '0' )"

        myData = anySqlQuery.selectQuery(sql)

        Return myData
    End Function

    Public Sub setBikeUnderOrder(bicycleID As String)
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "UPDATE  `14badr05`.`sykkel` SET  sykkel.`under_bestilling` =  '1' WHERE  sykkel.rammenr =" & bicycleID & ";"

        dbutil.updateQuery(sql)

    End Sub

    Public Sub setAllBikesNotUnderOrder()
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "UPDATE  `14badr05`.`sykkel` SET  sykkel.`under_bestilling` =  '0';"

        dbutil.updateQuery(sql)

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
End Class
