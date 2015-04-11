Public Class Equipment

    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim MyData As New DataTable
    Dim Answer As String

    Property EquipmentPrice As Double
    Property EquipmentStatus As String
    Property EquipmentID As String
    Property EquipmentType As String

    Public Sub New()

    End Sub

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

        sqlstring = "SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE (varenr LIKE '%" & EquipmentID & "%') AND (type LIKE '%" & EquipmentType & "%') AND (pris LIKE '%" & EquipmentPrice & "%') AND (status LIKE '%" & EquipmentStatus & "%') GROUP BY type;"

        MyData = anySqlQuery.selectQuery(sqlstring)

        Return MyData
    End Function

    Public Sub modeljoin(ByVal modellnavn As String, ByVal equipmenttype As String)

        Dim data As DataTable
        data = anySqlQuery.selectQuery("SELECT tilleggsutstyr.varenr FROM tilleggsutstyr WHERE type ='" & equipmenttype & "'")

        For Each row As DataRow In data.Rows
            sqlstring = "INSERT INTO kompatibel (varenr, modell) VALUES ('" & row("varenr") & "','" & modellnavn & "') ON DUPLICATE KEY UPDATE modell=VALUES(modell)"
            anySqlQuery.updateQuery(sqlstring)
        Next

    End Sub

    Public Function modelEquipementCompatiable(ByVal modelname As String)

        MyData = (anySqlQuery.selectQuery("SELECT varenr FROM kompatibel WHERE modell ='" & modelname & "'"))

        Return MyData

    End Function

    Public Function chosenEquipment(ByVal numberid As String)

        Return anySqlQuery.selectQuery("SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE varenr ='" & numberid & "'")

    End Function

    Public Function getEquipmentID(ByVal type As String) As DataTable

        MyData = anySqlQuery.selectQuery("SELECT varenr, tilleggsutstyr.pris FROM tilleggsutstyr WHERE type ='" & type & "' AND tilleggsutstyr.status = 'På lager' AND under_bestilling=0;")

        Return MyData

    End Function
    Public Function getEquipmentIDDuringOrder(ByVal type As String) As DataTable

        MyData = anySqlQuery.selectQuery("SELECT varenr FROM tilleggsutstyr WHERE type ='" & type & "'AND tilleggsutstyr.under_bestilling = '1';")

        Return MyData

    End Function

    Public Function finntype(ByVal varenr As String)

        MyData = anySqlQuery.selectQuery("SELECT type FROM tilleggsutstyr WHERE varenr ='" & varenr & "'")

        Return MyData.Rows(0)(0).ToString()

    End Function

    Public Function deletejoin(ByVal modelname As String, ByVal varenr As String)

        Return anySqlQuery.updateQuery("DELETE FROM kompatibel WHERE varenr ='" & varenr & "'" & " AND modell= '" & modelname & "'")

    End Function

    Public Function compatibleEquipment(model As String) As DataTable
        Dim dbutil As New DBUtility
        Dim sql As String
        Dim result As DataTable

        sql = "SELECT tilleggsutstyr.type, tilleggsutstyr.varenr FROM tilleggsutstyr JOIN kompatibel ON kompatibel.varenr=tilleggsutstyr.varenr WHERE modell ='" & model & "' AND tilleggsutstyr.status = 'På lager' AND under_bestilling=0 GROUP BY type;"

        result = dbutil.selectQuery(sql)

        Return result
    End Function

    Public Sub setEquipmentUnderOrder(equipmentID As String)
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "UPDATE  `14badr05`.`tilleggsutstyr` SET  `under_bestilling` =  '1' WHERE  `tilleggsutstyr`.`varenr` =" & equipmentID & ";"

        dbutil.updateQuery(sql)

    End Sub

    Public Sub setEquipmentNotUnderOrder(equipmentID As String)
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "UPDATE  `14badr05`.`tilleggsutstyr` SET  `under_bestilling` =  '0' WHERE  `tilleggsutstyr`.`varenr` =" & equipmentID & ";"

        dbutil.updateQuery(sql)

    End Sub

    Public Sub setAllEquipmentNotUnderOrder()
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "UPDATE  `14badr05`.`tilleggsutstyr` SET  `under_bestilling` =  '0'"

        dbutil.updateQuery(sql)

    End Sub

End Class
