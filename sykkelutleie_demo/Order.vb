''' <summary>
''' Holder funksjoner til bestilling, minus sykkel og utstyr
''' </summary>
''' <remarks></remarks>
Public Class Order
    Property orderID As String
    Property fromDate As Date
    Property toDate As Date
    Property kid As String
    Property employeeNumber As String
    Property discount As String
    Property bicyclePriceCounter As Double
    Property sum As Double
    Public Sub New()

    End Sub
    Public Sub New(fromDate As Date, toDate As Date, kid As String, employeNumber As String, bicyclePriceCounter As Double, discount As String)
        Me.fromDate = Format(fromDate, "yyyy/MM/dd")
        Me.toDate = Format(toDate, "yyyy/MM/dd")
        Me.kid = kid
        Me.employeeNumber = employeNumber
        Me.bicyclePriceCounter = bicyclePriceCounter
        Me.discount = discount
    End Sub
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

        Return FormatCurrency(totalPrice, 2)

    End Function
    ''' <summary>
    ''' Skriver bestillingen til Databasen
    ''' </summary>
    ''' <remarks>Formaterer datotid til rett sql format</remarks>
    Public Sub registerOrder()
        Dim dbutil As New DBUtility
        Dim sql As String
        Dim tempFromDate As String = Format(fromDate, "yyyy/MM/dd")
        Dim tempToDate As String = Format(toDate, "yyyy/MM/dd")

        sql = "INSERT INTO `14badr05`.`bestilling` (`bestillingsid`, `datotid`, `leie_fra`, `leie_til`, `ansattid`, `kid`, `sum`) VALUES (NULL, CURRENT_TIMESTAMP, '" & tempFromDate & "', '" & tempToDate & "', '" & employeeNumber & "', '" & kid & "', '" & getTotalPrice() & "');"

        dbutil.updateQuery(sql)
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

        sql = "SELECT bestillingsid FROM bestilling WHERE leie_fra ='" & tempFromDate & "' AND leie_til='" & tempToDate & "' AND ansattid='" & employeeNumber & "' AND kid='" & kid & "' AND sum='" & getTotalPrice() & "';"

        result = dbutil.selectQuery(sql)

        If result.Rows.Count < 1 Then
            Return MsgBox("Kunne ikke finne ordrenummer til bestillingen")
        Else

            row = result.Rows(0)
            id = row("bestillingsid")

            Return id
        End If

    End Function
    ''' <summary>
    ''' Finner ny Datatable basert på sykkel- og modellsøk
    ''' </summary>
    ''' <param name="model">Kommer fra tekstfeltene som det skrives i</param>
    ''' <param name="bike">Kommer fra tekstfeltene som det skrives i</param>
    ''' <returns>Returnerer Datatable</returns>
    ''' <remarks>Det meste som søkes på er "tomme" felt , ""</remarks>
    Public Function updateBicycle(model As Model, bike As Bike) As DataTable
        Dim data As DataTable

        data = bike.searchBicycleModel

        Return data
    End Function
    Public Function updateCustomer(customer As Customer) As DataTable
        Dim data As DataTable

        data = customer.searchCustomer

        Return data
    End Function

End Class
