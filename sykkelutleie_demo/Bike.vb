﻿Public Class Bike
    Private frameNumber As String
    Private status As String
    Private location As String
    Private placeOfOrigin As String
    Private Property brakes As String
    Private tires As String
    Private frame As String
    Private gear As String
    Public model As Model
    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim myData As New DataTable
    Dim svar As String


    ''' <summary>
    ''' Nytt bikeobject
    ''' </summary>
    ''' <param name="framenb"></param>
    ''' <param name="stat"></param>
    ''' <param name="loc"></param>
    ''' <param name="placeorigin"></param>
    ''' <param name="brake"></param>
    ''' <param name="tire"></param>
    ''' <param name="framename"></param>
    ''' <param name="gearname"></param>
    ''' <param name="modelobject"></param>
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
    ''' <summary>
    ''' Ny sykkel
    ''' </summary>
    ''' <remarks>Hvis True altså utført får vi bekreftelse</remarks>
    Public Sub createBike()

        sqlstring = "INSERT INTO sykkel (rammenr, status, lokasjon, utleiested, bremser, dekk, ramme, gir, modell) VALUES ('" & frameNumber & "','" & getStatus() & "','" & getLocation() & "','" & getPlaceOfOrigins() & "','" & brakes & "','" & getTires() & "','" & getFrame() & "','" & getGear() & "','" & getModel() & "')"

        svar = anySqlQuery.updateQuery(sqlstring)
        If svar = "True" Then
            MsgBox("Sykkel er opprettet")
        End If

    End Sub
    ''' <summary>
    ''' Søk etter sykkel
    ''' </summary>
    ''' <remarks>Fyller datagridview for sykkel med reultater</remarks>
    Public Function searchBike() As DataTable

        myData = anySqlQuery.selectQuery("SELECT rammenr, modell, lokasjon, status FROM sykkel WHERE (rammenr LIKE '%" & frameNumber & "%') AND (modell LIKE '%" & getModel() & "%') AND (status LIKE '" & getStatus() & "%') AND (lokasjon LIKE '%" & getLocation() & "%') AND (utleiested LIKE '%" & getPlaceOfOrigins() & "%') AND (bremser LIKE '%" & brakes & "%') AND (dekk LIKE '%" & getTires() & "%') AND (ramme LIKE '%" & getFrame() & "%') AND (gir LIKE '%" & getGear() & "%') AND (modell LIKE '%" & getModel() & "%')")

        Return myData

    End Function
    ''' <summary>
    ''' Finner sykkel og modelldata 
    ''' </summary>
    ''' <returns>Datatabell basert på sql spørring</returns>
    ''' <remarks>Joiner sykkel og modell for å gi data fra begge</remarks>
    Public Function searchBicycleModel() As DataTable

        myData = anySqlQuery.selectQuery("SELECT rammenr, kategori, pris, produsent, sykkel.modell FROM sykkel JOIN modell ON sykkel.modell=modell.modell WHERE  (rammenr LIKE '%" & frameNumber & "%') AND (sykkel.modell LIKE '%" & getModel() & "%') AND (status LIKE '%" & getStatus() & "%') AND (lokasjon LIKE '%" & getLocation() & "%') AND (utleiested LIKE '%" & getPlaceOfOrigins() & "%') AND (bremser LIKE '%" & brakes & "%') AND (dekk LIKE '%" & getTires() & "%') AND (ramme LIKE '%" & getFrame() & "%') AND (gir LIKE '%" & getGear() & "%') AND (pris >=" & getPrice() & ") AND (produsent LIKE '%" & getProducer() & "%') AND (kategori LIKE '%" & getCategory() & "%')")

        Return myData
    End Function

    ''' <summary>
    ''' Endre Sykkel
    ''' </summary>
    ''' <remarks>oppdatering av sykkelinfo, alle bokser og felter oppdateres
    ''' Hvis bekreftet svar= True så gir vi bekreftelse til bruker</remarks>
    Public Sub changeBike()

        svar = anySqlQuery.updateQuery("UPDATE sykkel SET status ='" & getStatus() & "', lokasjon ='" & getLocation() & "', utleiested='" & getPlaceOfOrigins() & "', bremser='" & brakes & "', dekk= '" & getTires() & "', ramme= '" & getFrame() & "', gir ='" & getGear() & "', modell ='" & getModel() & "' WHERE rammenr ='" & frameNumber & "'")

        If svar = "True" Then
            MsgBox("Sykkel er oppdatert")
        End If

    End Sub
    ''' <summary>
    ''' Slette sykkel
    ''' </summary>
    ''' <remarks>Bruker også objectet, men trenger kun modellnavn
    ''' Returnerer også svar i form av msgbox()</remarks>
    Public Sub deleteBike()

        svar = anySqlQuery.updateQuery("DELETE FROM sykkel WHERE rammenr ='" & frameNumber & "'")
        If svar = "True" Then
            MsgBox("Sykkel ble slettet")
        End If

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

    Public Function getModelname(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getModel
        Else

            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            svar = myData.Rows(0)(0).ToString()
            Return svar
        End If

    End Function

    Public Function getPrice(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getPrice
        Else
            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            Dim modellnavn As String = myData.Rows(0)(0).ToString()

            myData = anySqlQuery.selectQuery("SELECT pris FROM modell WHERE modell = '" & modellnavn & "'")
            svar = myData.Rows(0)(0).ToString()
            Return svar
        End If

    End Function

    Public Function getProducer(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getProducer
        Else
            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            Dim modellnavn As String = myData.Rows(0)(0).ToString()

            myData = anySqlQuery.selectQuery("SELECT produsent FROM modell WHERE modell = '" & modellnavn & "'")
            svar = myData.Rows(0)(0).ToString()
            Return svar
        End If

    End Function

    Public Function getCategory(Optional ByVal framenb As String = "")
        If framenb = "" Then
            Return model.getCategory
        Else
            myData = anySqlQuery.selectQuery("SELECT modell FROM sykkel WHERE rammenr = '" & framenb & "'")
            Dim modellnavn As String = myData.Rows(0)(0).ToString()

            myData = anySqlQuery.selectQuery("SELECT kategori FROM modell WHERE modell = '" & modellnavn & "'")
            svar = myData.Rows(0)(0).ToString()
            Return svar
        End If

    End Function
End Class
