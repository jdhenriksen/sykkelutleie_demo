''' <summary>
''' Holder funksjoner til bestilling, minus sykkel og utstyr
''' </summary>
''' <remarks></remarks>
Public Class Order
    Property bikes As New List(Of Bike)
    'Private equipment As List(Of Equipment)
    Property customer As New Customer
    Property employee As New Employee
    Property bike As New Bike
    Property orderID As String
    Property fromDate As Date
    Property toDate As Date
    Property discount As String
    Property bicyclePriceCounter As Double
    Property sum As Double

    Private dao As New OrderDao

    ''' <summary>
    ''' Standardkonstruktør. Skal brukes i starten av en bestilling.
    ''' Objektet skal oppdateres underveis i bestillingsprosessen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Konstruktør som setter verdier på alle objektvariabler.
    ''' </summary>
    ''' <param name="bicycleList">Liste av sykkelobjekter.</param>
    ''' <param name="customer">Kunde.</param>
    ''' <param name="salesman">Ansatt.</param>
    ''' <param name="fromDate">Fra-dato.</param>
    ''' <param name="toDate">Til-dato.</param>
    ''' <param name="discount">Rabatt.</param>
    ''' <remarks></remarks>
    Public Sub New(bicycleList As List(Of Bike), customer As Customer, salesman As Employee, fromDate As Date, toDate As Date, discount As String)
        Me.bikes = bicycleList
        Me.customer = customer
        Me.employee = salesman
        Me.fromDate = Format(fromDate, "yyyy/MM/dd")
        Me.toDate = Format(toDate, "yyyy/MM/dd")
        Me.discount = discount
    End Sub

    ''' <summary>
    ''' Søker etter sykler og tilhørende modellinformasjon i databasen på en dynamisk måte.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om sykler og tilhørende modellinformasjon.</returns>
    ''' <remarks></remarks>
    Public Function searchBicycle() As DataTable
        Dim data As DataTable
        data = bike.searchBicycleModel()
        Return data
    End Function

    ''' <summary>
    ''' Henter aktive kunder fra databasen.
    ''' </summary>
    ''' <returns>En datatabell med informasjon om aktive kunder.</returns>
    ''' <remarks></remarks>
    Public Function updateCustomer() As DataTable
        Dim data As DataTable
        data = customer.getActiveCustomer()
        Return data
    End Function

    ''' <summary>
    ''' Finner tiden i dager mellom to datoer
    ''' </summary>
    ''' <returns>Antall dager som heltall</returns>
    Public Function getTimeSpanOfOrder() As Integer
        Dim orderDays As Integer
        orderDays = DateDiff(DateInterval.DayOfYear, fromDate, toDate) + 1
        Return orderDays
    End Function

    ''' <summary>
    ''' Finner totalpris basert på valgt rabatt og antall dager.
    ''' </summary>
    ''' <returns>Pris som double med 2 desimaler</returns>
    Public Function getTotalPrice() As Double
        Dim totalPrice As Double

        For Each bike As Bike In bikes
            bicyclePriceCounter += bike.model.price 'Legger sammen prisen på alle sykklene i bestillingen.
            For Each tempEquipment As Equipment In bike.equipmentList
                bicyclePriceCounter += tempEquipment.EquipmentPrice 'Legger sammen prisen på alt av utstyr i bestillingen.
            Next
        Next
        totalPrice = CInt(getTimeSpanOfOrder()) * bicyclePriceCounter 'Multipliserer hele summen med antall dager leie.

        Select Case discount ' Multipliserer hele summen med prosentall representerer rabatt.
            Case "Ingen"
                totalPrice = totalPrice
            Case "10%"
                totalPrice = totalPrice * 0.9
            Case "20%"
                totalPrice = totalPrice * 0.8
            Case "Ansatt"
                totalPrice = totalPrice * 0.6
            Case "Skoleklasse"
                totalPrice = totalPrice * 0.9
            Case "Gruppe 10+"
                totalPrice = totalPrice * 0.95
            Case "Kampanje 50%"
                totalPrice = totalPrice * 0.5
        End Select

        sum = FormatCurrency(totalPrice, 2)
        Return FormatCurrency(totalPrice, 2)
    End Function


    ''' <summary>
    ''' Skriver bestillingen til Databasen
    ''' </summary>
    ''' <remarks>
    ''' Blar seg gjennom listene for sykkel og tilleggsutstyr for å opprette koblingstabeller
    ''' Formaterer datotid til rett sql format</remarks>
    Public Sub registerOrder()
        dao.createOrder(makeList())
        Dim tempOrderID As String = dao.getLatestOrder()
        For Each tempBicycle As Bike In bikes
            'Hver sykkel i bestillingen legges til i sykkel_bestilling i database.
            'SETTES IKKE TIL UTLEID STATUS
            dao.createBikeOrder(tempOrderID, tempBicycle.frameNumber)

            For Each tempEquipment As Equipment In tempBicycle.equipmentList
                Dim data As DataTable = tempEquipment.getEquipmentIDDuringOrder(tempEquipment.EquipmentType) 'Finner varenr til første vare i databasen hvor under_bestilling = True
                Dim row As DataRow
                Dim tempEquipmentID As String


                If data.Rows.Count = 0 Then
                    MsgBox("Kunne ikke finne Varenummeret til " & tempEquipment.EquipmentType & " i databasen")

                Else
                    row = data.Rows(0)
                    tempEquipmentID = row("varenr")

                    'Hvert utstyr til hver sykkel legges til i bestillingen i Databasen. 
                    'SETTES IKKE TIL UTLEID
                    dao.createEquipmentOrder(tempOrderID, tempEquipmentID)
                    tempEquipment.setEquipmentNotUnderOrder(tempEquipmentID) 'Setter under_bestilling = False, slik at samme vare ikke kommer i neste loop
                End If
            Next
        Next

        Dim equipment As New Equipment
        equipment.setAllEquipmentNotUnderOrder()
    End Sub

    ''' <summary>
    ''' Henter ut informasjon om en kunde basert på kundeID.
    ''' </summary>
    ''' <param name="id">KundeID.</param>
    ''' <returns>En datatabell med informasjon om aktuell kunde.</returns>
    ''' <remarks></remarks>
    Public Function getCustomerById(id As String) As DataTable
        Dim customerDao As New CustomerDao
        Return customerDao.selectCustomerById(id)
    End Function

    ''' <summary>
    ''' Henter utvalgt informasjon om sykler og modell for bruk i bestillings-Form.
    ''' </summary>
    ''' <param name="framenumber">Rammenummer til aktuell sykkel.</param>
    ''' <returns>En datatabell med relevant informasjon om sykkel og tilhørende modell.</returns>
    ''' <remarks></remarks>
    Public Function getBikeJoinModel(framenumber As String) As DataTable
        Return dao.getBikeJoinModel(framenumber)
    End Function

    ''' <summary>
    ''' Henter ut en ansatt basert på ansattID.
    ''' </summary>
    ''' <param name="id">AnsattID for aktuell ansatt.</param>
    ''' <returns>Et ansatt-objekt med informasjon om aktuell ansatt.</returns>
    ''' <remarks>Setter også fornavn og etternavn eksplisitt.</remarks>
    Public Function getEmployee(id As String) As Employee
        Dim table As New DataTable
        Dim dao As New EmployeeDao
        table = dao.selectEmployeeById(id)
        employee.setFirstname(table.Rows(0).Item("fornavn"))
        employee.setLastname(table.Rows(0).Item("etternavn"))
        employee.employeeID = id
        Return employee
    End Function

    ''' <summary>
    ''' Hjelpemetode. Lager liste som sendes til DAO.
    ''' </summary>
    ''' <returns>En liste bestående innholdet i alle objektvariablene for objektet.</returns>
    ''' <remarks>Se OrderDAO for bruk.</remarks>
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        With list
            .Add(Format(fromDate, "yyyy/MM/dd"))
            .Add(Format(toDate, "yyyy/MM/dd"))
            .Add(employee.employeeID)
            .Add(customer.customerID)
            .Add(sum)
        End With
        Return list
    End Function
End Class
