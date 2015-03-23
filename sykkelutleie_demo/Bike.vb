Public Class Bike
    Private frameNumber As String
    Private status As String
    Private location As String
    Private placeOfOrigin As String
    Private brakes As String
    Private tires As String
    Private frame As String
    Private gear As String
    Private modellnavn As String
    Public model As Model
    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim myData As New DataTable



    Public Sub New(ByVal framenb As String, ByVal stat As String,
                    ByVal loc As String, ByVal placeorigin As String,
                    ByVal brake As String, ByVal tire As String,
                    ByVal framename As String, ByVal gearname As String, ByVal mnavn As String)



        frameNumber = framenb
        status = stat
        location = loc
        placeOfOrigin = placeorigin
        brakes = brake
        tires = tire
        frame = framename
        gear = gearname
        modellnavn = mnavn
    End Sub

    Public Sub createBike()
        sqlstring = "INSERT INTO sykkel (rammenr, status, lokasjon, utleiested, bremser, dekk, ramme, gir, modell) VALUES ('" & GetframeNumber() & "','" & GetStatus() & "','" & GetLocation() & "','" & GetPlaceOfOrigins() & "','" & GetBrakes() & "','" & GetTires() & "','" & GetFrame() & "','" & GetGear() & "','" & GetModel() & "')"

        anySqlQuery.updateQuery(sqlstring)

        StorageWorker.clear()



    End Sub


    Public Sub changeBike()

        anySqlQuery.updateQuery("UPDATE sykkel SET status ='" & GetStatus() & "', lokasjon ='" & GetLocation() & "', utleiested='" & GetPlaceOfOrigins() & "', bremser='" & GetBrakes() & "', dekk= '" & GetTires() & "', ramme= '" & GetFrame() & "', gir ='" & GetGear() & "', modell ='" & GetModel() & "' WHERE rammenr ='" & GetframeNumber() & "'")
        StorageWorker.clear()
        StorageWorker.lock()
        StorageWorker.Button4.Enabled = True
        StorageWorker.Button5.Enabled = False
    End Sub

    Public Sub deleteBike()

        anySqlQuery.updateQuery("DELETE FROM sykkel WHERE rammenr ='" & GetframeNumber() & "'")
        StorageWorker.editFramenb.Clear()
        StorageWorker.clear()
        StorageWorker.lock()

    End Sub

    Public Sub searchBike()

        myData = anySqlQuery.selectQuery("SELECT rammenr, modell, lokasjon, status FROM sykkel WHERE (rammenr LIKE '%" & GetframeNumber() & "%') AND (modell LIKE '%" & GetModel() & "%') AND (status LIKE '" & GetStatus() & "%') AND (lokasjon LIKE '%" & GetLocation() & "%') AND (utleiested LIKE '%" & GetPlaceOfOrigins() & "%') AND (bremser LIKE '%" & GetBrakes() & "%') AND (dekk LIKE '%" & GetTires() & "%') AND (ramme LIKE '%" & GetFrame() & "%') AND (gir LIKE '%" & GetGear() & "%') AND (modell LIKE '%" & GetModel() & "%')")

        StorageWorker.DataGridView1.DataSource = myData

    End Sub

    Public Function GetframeNumber()

        Return frameNumber

    End Function

    Public Sub SetframeNumber(ByVal fnb As String)

    End Sub


    Public Function GetStatus()

        Return status

    End Function

    Public Sub SetStatus(ByVal s As String)

    End Sub

    Public Function GetLocation()

        Return location

    End Function

    Public Sub SetLocation(ByVal l As String)

    End Sub

    Public Function GetPlaceOfOrigins()

        Return placeOfOrigin

    End Function

    Public Sub SetPlaceOfOrigins(ByVal p As String)

    End Sub

    Public Function GetBrakes()

        Return brakes

    End Function

    Public Sub SetBrakes(ByVal b As String)

    End Sub

    Public Function GetTires()

        Return tires

    End Function

    Public Sub SetTires(ByVal t As String)

    End Sub

    Public Function GetFrame()

        Return frame

    End Function

    Public Sub SetFrame(ByVal f As String)

    End Sub

    Public Function GetGear()

        Return gear

    End Function

    Public Sub SetGear(ByVal g As String)

    End Sub

    Public Function GetModel()
        Return modellnavn
    End Function

    Public Sub SetModel()

    End Sub
End Class

