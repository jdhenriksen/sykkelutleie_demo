Public Class BikeDao
    Private dbutil As New DBUtility
    Private table As New DataTable
    Private sql As String

    Public Sub createBike(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateBike)
    End Sub

    Public Sub editBike(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditBike)
    End Sub

    Public Sub deleteBike(framenumber As String)
        dbutil.addParametersToQuery("@framenumber", framenumber)
        dbutil.paramQuery(SQLRes.sqlDeleteBike)
    End Sub

    'INCOMPLETE. Virker ikke. %-tegnene gjør at verdiene blir feil.
    Public Function searchBike(list As List(Of String)) As DataTable
        populateList(list)
        sql = "SELECT rammenr, modell, lokasjon, status FROM sykkel WHERE (rammenr LIKE %@framenumber%) AND (status LIKE %@status%) AND " & _
            "(lokasjon LIKE %@location%) AND (utleiested LIKE %@placeOfOrigin%) AND (bremser LIKE %@brakes%) AND (dekk LIKE %@tires%) AND " & _
            "(ramme LIKE %@frame%) AND (gir LIKE %@gear%) AND (modell LIKE %@model%);"
        table = dbutil.paramQuery(sql)
        Return table
    End Function

    Public Function getModelName(framenumber As String) As DataTable
        dbutil.addParametersToQuery("@framenumber", framenumber)
        table = dbutil.paramQuery(SQLRes.sqlGetModelName)
        Return table
    End Function

    Public Function selectAllBikes() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllBikes)
        Return table
    End Function

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

    'SKAL BRUKES I BIKE
    'Private Function makeList() As List(Of String)
    '    Dim list As New List(Of String)
    '    list.Add(getFrameNumber())
    '    list.Add(getStatus())
    '    list.Add(getLocation())
    '    list.Add(getPlaceOfOrigins())
    '    list.Add(brakes)
    '    list.Add(getTires())
    '    list.Add(getFrame())
    '    list.Add(getGear())
    '    list.Add(model.getModel())
    '    Return list
    'End Function
End Class
