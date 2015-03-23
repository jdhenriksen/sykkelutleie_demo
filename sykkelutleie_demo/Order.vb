Public Class Order
    Private orderID As String
    Private timestamp As Date
    Private fromDate As Date
    Private toDate As Date
    Private customer As Customer
    Private employee As Employee
    Private bike() As Bike
    Private model As Model 'Foreløpig hjelpevariabel
    'Private equipment As Equipment

    Sub New(timestamp As Date, fromDate As Date, toDate As Date, c As Customer, emp As Employee, b() As Bike)
        Me.timestamp = timestamp
        Me.fromDate = fromDate
        Me.toDate = toDate
        customer = c
        employee = emp
    End Sub

    'Testkonstruktør
    Sub New()
        timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        fromDate = New Date(2015, 3, 15)
        toDate = New Date(2015, 3, 17)
        customer = New Customer()
        employee = New Employee("Egil", "Jensen", "45454545", "egil@jensen.no", "selger", "egiljen", "45egiljensen")
        model = New Model("4545", "800", "dadsa", "jfdjsf")
        Dim bikeTemp(0) As Bike
        bikeTemp(0) = New Bike("554488", "jodoksad", "alstad", "alstad", "keramikk", "dunlop", "djasdois", "dsahda", model)
        Me.bike = bikeTemp
    End Sub

    Public Overrides Function toString() As String
        Return "Timestamp: " & getTimestamp() & vbCrLf & "Fra: " & getFromDate() & vbCrLf & "Til: " & getToDate() & vbCrLf _
            & "Kunde: " & getCustomerName() & vbCrLf & "Ansatt: " & getEmployeeName() & vbCrLf & "Sykkel: " & getAllBikeNumbers() _
            & "Totalpris: " & model.getPrice() & " kr."
    End Function

    Public Function getTimestamp() As Date
        Return timestamp
    End Function

    Public Sub setTimestamp(timestamp As Date)
        Me.timestamp = timestamp
    End Sub

    Public Function getFromDate() As Date
        Return fromDate
    End Function

    Public Sub setFromDate(fromDate As Date)
        Me.fromDate = fromDate
    End Sub

    Public Function getToDate() As Date
        Return toDate
    End Function

    Public Sub setToDate(toDate As Date)
        Me.toDate = toDate
    End Sub

    Public Function getCustomerName() As String
        Return customer.getFirstname() & " " & customer.getLastname()
    End Function

    Public Function getEmployeeName() As String
        Return employee.getFirstname() & " " & employee.getLastname()
    End Function

    Public Function getAllBikeNumbers() As String
        Dim outString As String = ""
        For Each b In bike
            outString &= b.getFrameNumber() & vbCrLf
        Next
        Return outString
    End Function

    Public Function getAllEquipmentNames() As String
        Return Nothing
    End Function
End Class
