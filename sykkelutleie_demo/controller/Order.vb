''' <summary>
''' Holder funksjoner til bestilling, minus sykkel og utstyr
''' </summary>
''' <remarks></remarks>
Public Class Order
    Property bicycleList As New List(Of Bike)
    'Private equipment As List(Of EquipmentDao)
    Property customer As New Customer
    Property salesman As New Employee
    Property orderID As String
    Property fromDate As Date
    Property toDate As Date
    Property discount As String
    Property bicyclePriceCounter As Double
    Property sum As Double


    Public Sub New()

    End Sub
    Public Sub New(bicycleList As List(Of Bike), customer As Customer, salesman As Employee, fromDate As Date, toDate As Date, discount As String)
        Me.bicycleList = bicycleList
        Me.customer = customer
        Me.salesman = salesman
        Me.fromDate = Format(fromDate, "yyyy/MM/dd")
        Me.toDate = Format(toDate, "yyyy/MM/dd")
        Me.discount = discount
    End Sub




    ''' <summary>
    ''' Finner Datatable basert på sykkel- og modellsøk
    ''' </summary>
    ''' <param name="bike">Kommer fra tekstfeltene som det skrives i</param>
    ''' <returns>Returnerer Datatable</returns>
    ''' <remarks>Det meste som søkes på er "tomme" felt , ""</remarks>
    Public Function updateBicycle(bike As Bike) As DataTable
        Dim data As DataTable

        data = bike.searchBicycleModel(bike)

        Return data
    End Function
    Public Function updateCustomer(customer As Customer) As DataTable
        Dim data As DataTable

        data = customer.searchCustomer(customer)

        Return data
    End Function




    ''' <summary>
    ''' Finner tiden i dager mellom to datoer
    ''' </summary>
    ''' <returns>Returnerer antall dager som heltall</returns>
    Public Function getTimeSpanOfOrder() As Integer
        Dim orderDays As Integer
        orderDays = DateDiff(DateInterval.DayOfYear, fromDate, toDate) + 1

        Return orderDays
    End Function




    ''' <summary>
    ''' Finner totalpris basert på valgt rabatt og antall dager.
    ''' </summary>
    ''' <returns>Returnerer pris som double med 2 desimaler</returns>
    Public Function getTotalPrice() As Double
        Dim totalPrice As Double

        For Each Bike As Bike In bicycleList
            bicyclePriceCounter += Bike.model.price
        Next
        totalPrice = CInt(getTimeSpanOfOrder()) * bicyclePriceCounter

        Select Case discount
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
        Dim dbutil As New DBUtility
        Dim sql As String
        Dim tempFromDate As String = Format(fromDate, "yyyy/MM/dd")
        Dim tempToDate As String = Format(toDate, "yyyy/MM/dd")

        sql = "INSERT INTO `14badr05`.`bestilling` (`bestillingsid`, `datotid`, `leie_fra`, `leie_til`, `ansattid`, `kid`, `sum`) VALUES (NULL, CURRENT_TIMESTAMP, '" & tempFromDate & "', '" & tempToDate & "', '" & getEmployeeID(salesman.account.username) & "', '" & customer.customerID & "', '" & getTotalPrice() & "');"

        dbutil.updateQuery(sql)

        For Each tempBicycle As Bike In bicycleList

            sql = "INSERT INTO `14badr05`.`sykkel_bestilling` (`bestillingsid`, `rammenr`) VALUES ('" & getOrderID() & "', '" & tempBicycle.frameNumber & "');"

            dbutil.updateQuery(sql)
        Next

        ' Public Sub registerEquipmentOrder()
        '   Dim dbutil As New DBUtility
        '  Dim sql As String

        '  sql = "INSERT INTO `14badr05`.`utstyr_bestilling` (`bestillingsid`, `varenr`) VALUES ('" & orderID & "', '" & equipmentNumber & "');"

        '  dbutil.updateQuery(sql)
        '  End Sub

    End Sub




    ''' <summary>
    ''' Finner bestillingsID basert på info brukt til å lage bestilling
    ''' </summary>
    ''' <returns>BestillingsID som string</returns>
    ''' <remarks>Brukes av skriv til Bicycle- og EquipmentOrder</remarks>
    Public Function getOrderID() As String
        Dim dbutil As New DBUtility
        Dim sql As String
        Dim result As DataTable
        Dim row As DataRow
        Dim id As String
        Dim tempFromDate As String = Format(fromDate, "yyyy/MM/dd")
        Dim tempToDate As String = Format(toDate, "yyyy/MM/dd")

        sql = "SELECT bestillingsid FROM bestilling WHERE leie_fra ='" & tempFromDate & "' AND leie_til='" & tempToDate & "' AND ansattid='" & getEmployeeID(salesman.account.username) & "' AND kid='" & customer.customerID & "' AND sum='" & sum & "';"

        result = dbutil.selectQuery(sql)

        If result.Rows.Count <> 1 Then
            Return MsgBox("Kunne ikke finne ordrenummer til bestillingen")
        Else

            row = result.Rows(0)
            id = row("bestillingsid")

            Return id
        End If

    End Function




    ''' <summary>
    ''' Henter ansattID på innlogget bruker
    ''' </summary>
    ''' <param name="username">Hentes fra Account klassen</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getEmployeeID(username As String) As String
        Dim dbutil As New DBUtility
        Dim sql As String
        Dim result As DataTable
        Dim row As DataRow
        Dim id As String

        sql = "SELECT ansatt.ansattid FROM ansatt WHERE brukernavn = '" & username & "';"
        result = dbutil.selectQuery(sql)

        If result.Rows.Count <> 1 Then
            Return MsgBox("Kunne ikke finne ansattID til ansatt med brukernavn " & username & " i databasen")
        Else

            row = result.Rows(0)
            id = row("ansattid")

            Return id
        End If

    End Function

End Class
