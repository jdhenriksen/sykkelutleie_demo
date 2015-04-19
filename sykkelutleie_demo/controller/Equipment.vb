''' <summary>
''' Klasse som håndterer operasjoner i forbindelse med tilleggsutstyr.
''' </summary>
''' <remarks></remarks>
Public Class Equipment
    Property equipmentPrice As Double
    Property equipmentStatus As String
    Property equipmentID As String
    Property equipmentType As String

    Private dao As New EquipmentDao

    ''' <summary>
    ''' Konstruktør som setter alle objektvariabler.
    ''' </summary>
    ''' <param name="equipmentID">ID for tilleggsutstyr: varenummer.</param>
    ''' <param name="equipmentStatus">Status for tilleggsutstyr.</param>
    ''' <param name="equipmentPrice">Pris.</param>
    ''' <param name="equipmentType">Type utstyr.</param>
    ''' <remarks></remarks>
    Public Sub New(equipmentID As String, equipmentStatus As String, equipmentPrice As Double, equipmentType As String)
        Me.equipmentID = equipmentID
        Me.equipmentStatus = equipmentStatus
        Me.equipmentPrice = equipmentPrice
        Me.equipmentType = equipmentType
    End Sub

    ''' <summary>
    ''' Standardkonstruktør. Brukes hvis det er nødvendig med et objekt, men konkret informasjon ikke foreligger.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Skriver tilleggsutstyr til databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub createEquipment()
        dao.createEquipment(makeList())
    End Sub

    ''' <summary>
    ''' Endrer informasjon om et spesifikt tilleggsutstyr i databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub editEquipment()
        dao.editEquipment(makeList())
    End Sub

    ''' <summary>
    ''' Sletter tilleggsutstyr fra databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub deleteEquipment()
        dao.deleteEquipment(equipmentID)
    End Sub

    ''' <summary>
    ''' Søker etter tilleggsutstyr i databasen.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function searchEquipment() As DataTable
        Return dao.searchEquipment(makeList())
    End Function

    ''' <summary>
    ''' Lager en kobling mellom tilleggsutstyr og modell som tilsier kompatibilitet.
    ''' </summary>
    ''' <param name="model">Modellnavn.</param>
    ''' <param name="equipmentType">Type tilleggsutstyr.</param>
    ''' <remarks>Skriver til koblingstabell mellom modell og tilleggsutstyr i databasen.</remarks>
    Public Sub createCompatibility(model As String, equipmentType As String)
        dao.createCompatibility(model, equipmentType)
    End Sub

    ''' <summary>
    ''' Henter ut tilleggsutstyr som er kompatibelt med en spesifikk modell.
    ''' </summary>
    ''' <param name="model">Modell som tilleggsutstyret skal sjekkes mot.</param>
    ''' <returns>En datatabell som representerer alt tilgjengelig tilleggsutstyr for en modell.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentByModel(model As String) As DataTable
        Return dao.getEquipmentByModel(model)
    End Function

    ''' <summary>
    ''' Henter ut all informasjon om tilleggsutstyr basert på varenummer.
    ''' </summary>
    ''' <param name="id">Varenummeret det skal søkes på.</param>
    ''' <returns>En datatabell som viser all informasjon om aktuelt tilleggsutstyr.</returns>
    ''' <remarks></remarks>
    Public Function selectEquipmentById(id As String) As DataTable
        Return dao.selectEquipmentById(id)
    End Function

    ''' <summary>
    ''' Finner varenummer og pris for et tilleggsutstyr basert på type.
    ''' </summary>
    ''' <param name="type">Type tilleggsutstyr det skal søkes etter.</param>
    ''' <returns>En datatabell som representerer varenummer og pris for aktuell type tilleggsutstyr.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentID(type As String) As DataTable
        Return dao.getEquipmentID(type)
    End Function

    ''' <summary>
    ''' Finner alt tilleggsutstyr av en spesifikk type som for øyeblikket er under bestilling.
    ''' </summary>
    ''' <param name="type">Type tilleggsutstyr det skal søkes etter.</param>
    ''' <returns></returns>
    ''' <remarks>Brukes midlertidig i systemet for å holde orden på bestillingsprosessen.</remarks>
    Public Function getEquipmentIDDuringOrder(type As String) As DataTable
        Return dao.getEquipmentIDDuringOrder(type)
    End Function

    ''' <summary>
    ''' Finner typen til et tilleggsutstyr basert på varenummer.
    ''' </summary>
    ''' <param name="id">Varenummer det skal søkes etter.</param>
    ''' <returns>En tekstrepresentasjon av typen til aktuelt tilleggsutstyr.</returns>
    ''' <remarks></remarks>
    Public Function getTypeByID(id As String) As String
        Dim table As DataTable = dao.getTypeByID(id)
        Dim res As String = table.Rows(0)(0).ToString()
        Return res
    End Function

    ''' <summary>
    ''' Fjerner kompatibilitet mellom tilleggsutstyr og modell basert på
    ''' henholdsvis varenummer og modellnavn.
    ''' </summary>
    ''' <param name="model">Modellnavn.</param>
    ''' <param name="id">Varenummer.</param>
    ''' <remarks></remarks>
    Public Sub removeCompatibility(model As String, ByVal id As String)
        dao.removeCompatibility(model, id)
    End Sub

    ''' <summary>
    ''' Henter ut tilleggsutstyr som er kompatibelt med en modell og ikke er under bestilling.
    ''' Finner kun tilleggsutstyr som er på lager.
    ''' Grupperer på type tilleggsutstyr.
    ''' </summary>
    ''' <param name="model">Modellnavn.</param>
    ''' <returns>En datatabell bestående av tilgjengelig tilleggsutstyr
    ''' som er kompatibelt med en gitt modell.</returns>
    ''' <remarks></remarks>
    Public Function getCompatibleEquipment(model As String) As DataTable
        Return dao.getCompatibleEquipment(model)
    End Function

    ''' <summary>
    ''' Setter tilleggsutstyr med spesifisert varenummer til å være under bestilling.
    ''' </summary>
    ''' <param name="id">Varenummer for aktuelt tilleggsutstyr.</param>
    ''' <remarks>Setter under_bestilling-attributtet til '1'.</remarks>
    Public Sub setEquipmentUnderOrder(id As String)
        dao.setEquipmentUnderOrder(id)
    End Sub


    ''' <summary>
    ''' Setter tilleggsutstyr med spesifisert varenummer til å ikke være under bestillling.
    ''' </summary>
    ''' <param name="id">Varenummer for aktuelt tilleggsutstyr.</param>
    ''' <remarks>Setter under_bestilling-attributtet til '0'.</remarks>
    Public Sub setEquipmentNotUnderOrder(id As String)
        dao.setEquipmentNotUnderOrder(id)
    End Sub

    ''' <summary>
    ''' Setter alt tilleggsutstyr til å ikke være under bestilling.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub setAllEquipmentNotUnderOrder()
        dao.setAllEquipmentNotUnderOrder()
    End Sub

    ''' <summary>
    ''' Henter ut alt tilleggsutstyr og grupperer etter type.
    ''' </summary>
    ''' <returns>En datatabell som inneholder alt tilleggsutstyr, gruppert etter type.</returns>
    ''' <remarks></remarks>
    Public Function getEquipmentGroupByType()
        Return dao.getEquipmentGroupByType()
    End Function

    ''' <summary>
    ''' Hjelpemetode. Lager liste som sendes til DAO.
    ''' </summary>
    ''' <returns>En liste bestående innholdet i alle objektvariablene for objektet.</returns>
    ''' <remarks>Se EquipmentDAO for bruk.</remarks>
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