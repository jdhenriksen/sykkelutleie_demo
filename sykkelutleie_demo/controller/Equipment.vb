Public Class Equipment
    Private dao As New EquipmentDao

    Property equipmentPrice As Double
    Property equipmentStatus As String
    Property equipmentID As String
    Property equipmentType As String

    Public Sub New()

    End Sub

    Public Sub New(equipmentID As String, equipmentStatus As String, equipmentPrice As Double, equipmentType As String)
        Me.equipmentStatus = equipmentStatus
        Me.equipmentPrice = equipmentPrice
        Me.equipmentType = equipmentType
        Me.equipmentID = equipmentID
    End Sub

    Public Sub createEquipment()
        dao.createEquipment(makeList())
    End Sub

    Public Sub deleteEquipment()
        dao.deleteEquipment(equipmentID)
    End Sub

    Public Sub editEquipment()
        dao.editEquipment(makeList())
    End Sub

    Public Function searchEquipment() As DataTable
        Return dao.searchEquipment(makeList())
    End Function

    Public Sub createCompatibility(ByVal modellnavn As String, ByVal equipmenttype As String)
        dao.createCompatibility(modellnavn, equipmenttype)
    End Sub

    Public Function getEquipmentByModel(ByVal modelname As String) As DataTable
        Return dao.getEquipmentByModel(modelname)
    End Function

    Public Function chosenEquipment(ByVal numberid As String) As DataTable
        Return dao.selectEquipmentById(numberid)
    End Function

    Public Function getEquipmentID(ByVal type As String) As DataTable
        Return dao.getEquipmentID(type)
    End Function
    Public Function getEquipmentIDDuringOrder(ByVal type As String) As DataTable
        Return dao.getEquipmentIDDuringOrder(type)
    End Function

    Public Function getTypeByID(ByVal varenr As String) As String
        Dim table As DataTable = dao.getTypeByID(varenr)
        Dim res As String = table.Rows(0)(0).ToString()
        Return res
    End Function

    Public Sub removeCompatibility(ByVal modelname As String, ByVal varenr As String)
        dao.removeCompatibility(modelname, varenr)
    End Sub

    Public Function getCompatibleEquipment(model As String) As DataTable
        Return dao.getCompatibleEquipment(model)
    End Function

    Public Sub setEquipmentUnderOrder(equipmentID As String)
        dao.setEquipmentUnderOrder(equipmentID)
    End Sub

    Public Sub setEquipmentNotUnderOrder(equipmentID As String)
        dao.setEquipmentNotUnderOrder(equipmentID)
    End Sub

    Public Sub setAllEquipmentNotUnderOrder()
        dao.setAllEquipmentNotUnderOrder()
    End Sub

    Public Function getEquipmentGroupByType()
        Return dao.getEquipmentGroupByType()
    End Function

    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        With list
            .Add(equipmentID)
            .Add(equipmentType)
            .Add(equipmentPrice())
            .Add(equipmentStatus())
        End With
        Return list
    End Function
End Class