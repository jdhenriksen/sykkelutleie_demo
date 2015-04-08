''' <summary>
''' Behandler utstyrsBestillinger
''' </summary>
''' <remarks></remarks>
Public Class EquipmentOrder
    Private orderId As String
    Private equipmentNumber As String

    Public Sub New(orderId As String, equipmentNumber As String)
        Me.orderId = orderId
        Me.equipmentNumber = equipmentNumber
    End Sub

    Public Sub registerEquipmentOrder()
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "INSERT INTO `14badr05`.`utstyr_bestilling` (`bestillingsid`, `varenr`) VALUES ('" & orderId & "', '" & equipmentNumber & "');"

        dbutil.updateQuery(sql)
    End Sub
End Class
