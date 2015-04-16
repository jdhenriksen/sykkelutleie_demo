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

    Public Function searchEquipment(list As List(Of String)) As DataTable
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.paramQuery(SQLRes.sqlSearchEquipment)
        Return table
    End Function

    Public Function selectEquipmentById(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.paramQuery(SQLRes.sqlSelectEquipmentById)
        Return table
    End Function

    Public Function selectAllEquipment() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllEquipment)
        Return table
    End Function

    Public Sub createCompatibility(model As String, type As String)
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.paramQuery(SQLRes.sqlSelectEquipmentIDOnType)

        For Each row As DataRow In table.Rows
            Dim rowVal As String = row("varenr")
            dbutil.addParametersToQuery("@rowVal", rowVal)
            dbutil.addParametersToQuery("@model", model)
            dbutil.paramQuery(SQLRes.sqlCreateCompatibility)
        Next
    End Sub

    Public Function getEquipmentByModel(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.paramQuery(SQLRes.sqlModelEquipmentCompatible)
        Return table
    End Function

    Public Function getEquipmentID(type As String) As DataTable
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.paramQuery(SQLRes.sqlGetEquipmentID)
        Return table
    End Function

    Public Function getEquipmentIDDuringOrder(type As String) As DataTable
        dbutil.addParametersToQuery("@type", type)
        table = dbutil.paramQuery(SQLRes.sqlGetEquipmentIDDuringOrder)
        Return table
    End Function

    Public Function getTypeByID(id As String) As DataTable
        dbutil.addParametersToQuery("@id", id)
        table = dbutil.paramQuery(SQLRes.sqlGetTypeFromID)
        Return table
    End Function

    Public Sub removeCompatibility(model As String, id As String)
        dbutil.addParametersToQuery("@model", model)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlRemoveCompatibility)
    End Sub

    Public Function getCompatibleEquipment(model As String) As DataTable
        dbutil.addParametersToQuery("@model", model)
        table = dbutil.paramQuery(SQLRes.sqlCompatibleEquipment)
        Return table
    End Function

    Public Sub setEquipmentUnderOrder(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlSetEquipmentUnderOrder)
    End Sub

    Public Sub setEquipmentNotUnderOrder(id As String)
        dbutil.addParametersToQuery("@id", id)
        dbutil.paramQuery(SQLRes.sqlSetEquipmentNotUnderOrder)
    End Sub

    Public Sub setAllEquipmentNotUnderOrder()
        dbutil.paramQuery(SQLRes.sqlSetAllEquipmentNotUnderOrder)
    End Sub

    Public Function getEquipmentGroupByType() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectEquipmentGroupByType)
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

    Private Function prepareForSearch(inputList As List(Of String)) As String()
        Dim i As Integer
        Dim listItemLength As Integer
        Dim list(inputList.Count - 1) As String
        For i = 0 To inputList.Count - 1
            If String.IsNullOrEmpty(inputList(i)) Or inputList(i) = Nothing Then
                list(i) = String.Format("%{0}%", inputList(i))
            Else
                listItemLength = inputList(i).Length
                list(i) = String.Format("%{0," & listItemLength & "}%", inputList(i))
            End If
        Next
        Return list
    End Function
End Class