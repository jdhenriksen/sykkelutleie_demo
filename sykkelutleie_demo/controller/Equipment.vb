Public Class Equipment

    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim MyData As New DataTable
    Dim Answer As String

    Private EquipmentPrice As String
    Private EquipmentStatus As String
    Private EquipmentID As String
    Private EquipmentType As String

    Public Sub New(ByVal EquipmentIDValue As String, ByVal EquipmentStatusValue As String, ByVal EquipmentPriceValue As String, ByVal EquipmentTypeValue As String)

        EquipmentStatus = EquipmentStatusValue
        EquipmentPrice = EquipmentPriceValue
        EquipmentType = EquipmentTypeValue
        EquipmentID = EquipmentIDValue

    End Sub


    Public Function createEquipment()

        sqlstring = "INSERT INTO tilleggsutstyr (type, pris, status) VALUES ('" & EquipmentType & "','" & EquipmentPrice & "','" & EquipmentStatus & "')"

        Answer = anySqlQuery.updateQuery(sqlstring)

        Return Answer

    End Function


    Public Function DeleteEquipment()

        sqlstring = "UPDATE tilleggsutstyr SET status ='Deaktivert' WHERE varenr = '" & EquipmentID & "'"

        Answer = anySqlQuery.updateQuery(sqlstring)

        Return Answer

    End Function

    Public Function ChangeEquipment()

        sqlstring = "UPDATE tilleggsutstyr SET type ='" & EquipmentType & "', pris ='" & EquipmentPrice & "', status ='" & EquipmentStatus & "' WHERE varenr = '" & EquipmentID & "'"

        Answer = anySqlQuery.updateQuery(sqlstring)

        Return Answer

    End Function


    Public Function SearchEquipment()

        sqlstring = "SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE (varenr LIKE '%" & EquipmentID & "%') AND (type LIKE '%" & EquipmentType & "%') AND (pris LIKE '%" & EquipmentPrice & "%') AND (status LIKE '%" & EquipmentStatus & "%')"

        MyData = anySqlQuery.selectQuery(sqlstring)

        Return MyData
    End Function

    Public Function modeljoin(ByVal modellnavn As String, ByVal equipmenttype As String)

        Dim varenr As String

        varenr = finnvarenr(equipmenttype)

        sqlstring = "INSERT INTO kompatibel (varenr, modell) VALUES ('" & varenr & "','" & modellnavn & "') ON DUPLICATE KEY UPDATE modell=VALUES(modell)"

        Return anySqlQuery.updateQuery(sqlstring)

    End Function

    Public Function modelEquipementCompatiable(ByVal modelname As String)

        MyData = (anySqlQuery.selectQuery("SELECT varenr FROM kompatibel WHERE modell ='" & modelname & "'"))

        Return MyData

    End Function

    Public Function chosenEquipment(ByVal numberid As String)

        Return anySqlQuery.selectQuery("SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE varenr ='" & numberid & "'")

    End Function

    Public Function finnvarenr(ByVal type As String)

        MyData = anySqlQuery.selectQuery("SELECT varenr FROM tilleggsutstyr WHERE type ='" & type & "'")

        Return MyData.Rows(0)(0).ToString()

    End Function

    Public Function finntype(ByVal varenr As String)

        MyData = anySqlQuery.selectQuery("SELECT type FROM tilleggsutstyr WHERE varenr ='" & varenr & "'")

        Return MyData.Rows(0)(0).ToString()

    End Function

    Public Function deletejoin(ByVal modelname As String, ByVal varenr As String)

        Return anySqlQuery.updateQuery("DELETE FROM kompatibel WHERE varenr ='" & varenr & "'" & " AND modell= '" & modelname & "'")

    End Function

End Class
