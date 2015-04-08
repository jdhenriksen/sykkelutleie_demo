Public Class EquipmentDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createEquipment(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateEquipment)
    End Sub

    Public Sub editEquipment(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditEquipment)
    End Sub

    Public Sub deleteEquipment(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlDeleteEquipment)
    End Sub

    Public Function selectEquipmentById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.paramQuery(SQLRes.sqlSelectEquipmentById)
        Return table
    End Function

    Public Function selectAllEquipment() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllEquipment)
        Return table
    End Function

    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@id", list(0))
            .addParametersToQuery("@type", list(1))
            .addParametersToQuery("@price", list(2))
            .addParametersToQuery("@status", list(3))
        End With
    End Sub

    'SKAL INN I EQUIPMENT
    'Private Function makeList() As List(Of String)
    '    Dim list As New List(Of String)
    '    With list
    '        .Add(getEquipmentId())
    '        .Add(getEquipmentType())
    '        .Add(getEquipmentPrice())
    '        .Add(getEquipmentStatus())
    '    End With
    'End Function
End Class
