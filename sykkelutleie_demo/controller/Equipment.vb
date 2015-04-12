Public Class Equipment

    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim myData As New DataTable
    Dim Answer As String

    Property EquipmentPrice As Double
    Property EquipmentStatus As String
    Property EquipmentID As String
    Property EquipmentType As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal EquipmentIDValue As String, ByVal EquipmentStatusValue As String, ByVal EquipmentPriceValue As Double, ByVal EquipmentTypeValue As String)

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

        Dim temp As String
        If EquipmentPrice = 0 Then
            temp = ""
        Else
            temp = EquipmentPrice
        End If

        sqlstring = "SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE (varenr LIKE '%" & EquipmentID & "%') AND (type LIKE '%" & temp & "%') AND (pris LIKE '%" & EquipmentPrice & "%') AND (status LIKE '%" & EquipmentStatus & "%') GROUP BY type;"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

    Public Sub modeljoin(ByVal modellnavn As String, ByVal equipmenttype As String)

        sqlstring = "SELECT tilleggsutstyr.varenr FROM tilleggsutstyr WHERE type ='" & equipmenttype & "'"

        myData = anySqlQuery.selectQuery(sqlstring)

        For Each row As DataRow In myData.Rows

            sqlstring = "INSERT INTO kompatibel (varenr, modell) VALUES ('" & row("varenr") & "','" & modellnavn & "') ON DUPLICATE KEY UPDATE modell=VALUES(modell)"

            anySqlQuery.updateQuery(sqlstring)

        Next

    End Sub

    Public Function modelEquipementCompatiable(ByVal modelname As String)

        sqlstring = "SELECT varenr FROM kompatibel WHERE modell ='" & modelname & "'"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

    Public Function chosenEquipment(ByVal numberid As String)

        sqlstring = "SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE varenr ='" & numberid & "'"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

    Public Function getEquipmentID(ByVal type As String) As DataTable

        sqlstring = "SELECT varenr, tilleggsutstyr.pris FROM tilleggsutstyr WHERE type ='" & type & "' AND tilleggsutstyr.status = 'På lager' AND under_bestilling=0;"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function
    Public Function getEquipmentIDDuringOrder(ByVal type As String) As DataTable

        sqlstring = "SELECT varenr FROM tilleggsutstyr WHERE type ='" & type & "'AND tilleggsutstyr.under_bestilling = '1';"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

    Public Function finntype(ByVal varenr As String)

        sqlstring = "SELECT type FROM tilleggsutstyr WHERE varenr ='" & varenr & "'"

        myData = anySqlQuery.selectQuery(sqlstring)

        Answer = myData.Rows(0)(0).ToString()

        Return Answer

    End Function

    Public Function deletejoin(ByVal modelname As String, ByVal varenr As String)

        sqlstring = "DELETE FROM kompatibel WHERE varenr ='" & varenr & "'" & " AND modell= '" & modelname & "'"

        Answer = anySqlQuery.updateQuery(sqlstring)

        Return Answer

    End Function

    Public Function compatibleEquipment(model As String) As DataTable

        sqlstring = "SELECT tilleggsutstyr.type, tilleggsutstyr.varenr FROM tilleggsutstyr JOIN kompatibel ON kompatibel.varenr=tilleggsutstyr.varenr WHERE modell ='" & model & "' AND tilleggsutstyr.status = 'På lager' AND under_bestilling=0 GROUP BY type;"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

    Public Sub setEquipmentUnderOrder(equipmentID As String)


        sqlstring = "UPDATE  `14badr05`.`tilleggsutstyr` SET  `under_bestilling` =  '1' WHERE  `tilleggsutstyr`.`varenr` =" & equipmentID & ";"

        anySqlQuery.updateQuery(sqlstring)

    End Sub

    Public Sub setEquipmentNotUnderOrder(equipmentID As String)

        sqlstring = "UPDATE  `14badr05`.`tilleggsutstyr` SET  `under_bestilling` =  '0' WHERE  `tilleggsutstyr`.`varenr` =" & equipmentID & ";"

        anySqlQuery.updateQuery(sqlstring)

    End Sub

    Public Sub setAllEquipmentNotUnderOrder()


        sqlstring = "UPDATE  `14badr05`.`tilleggsutstyr` SET  `under_bestilling` =  '0'"

        anySqlQuery.updateQuery(sqlstring)

    End Sub


    Public Function listAllEquipment()

        sqlstring = "SELECT varenr, type, pris, status FROM tilleggsutstyr WHERE (varenr LIKE '%" & EquipmentID & "%') AND (type LIKE '%" & EquipmentType & "%') AND (pris LIKE '%" & EquipmentPrice & "%') AND (status LIKE '%" & EquipmentStatus & "%')"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

    Public Function EquipmentTypes()

        sqlstring = "SELECT varenr, type, pris, status FROM tilleggsutstyr GROUP BY type;"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function

End Class
