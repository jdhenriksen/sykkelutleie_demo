''' <summary>
''' Test Form til bestilling/selger funksjoner
''' </summary>
''' <remarks></remarks>
Public Class OrderTest
    Private order As New Order
    Private customer As Customer
    Private employee As Employee
    Private bike As New Bike

    Private bicycleList As New List(Of Bike)
    Private bicycleCounter As Integer = 0
    Private employeeVar As String
    Private fromDate As Date
    Private toDate As Date
    Private discount As String

    Private modelCategory As String
    Private modelPrice As Double
    Private modelModel As String
    Private modelProducer As String
    Private bikeFrameNumber As String

    Private customerEmail As String
    Private customerFirstname As String
    Private customerLastname As String
    Private customerPhone As String
    Private customerCustomerID As String


    ''' <summary>
    ''' Prossedyrer som setter variablene fra tekstbokser.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub setTestOrder()
        setTestCustomer()
        fromDate = CalendarFrom.SelectionStart
        toDate = CalendarTo.SelectionEnd
        discount = CmbBoxDiscount.Text

    End Sub
    Public Sub setTestBicycle()
        modelCategory = txtBxCategory.Text
        If txtBxPrice.Text = "" Then
            modelPrice = 0.0
        Else
            modelPrice = CDbl(txtBxPrice.Text)
        End If
        modelModel = txtBxModel.Text
        modelProducer = txtBxProducer.Text
        bikeFrameNumber = txtBxFramenumber.Text
    End Sub
    Public Sub setTestCustomer()
        customerEmail = txtBxEmail.Text
        customerFirstname = txtBxFirstName.Text
        customerLastname = txtBxSurName.Text
        customerPhone = txtBxPhone.Text
        customerCustomerID = txtBxKID.Text
    End Sub

    ''' <summary>
    ''' Registrerer ordren i databasen. Men tilhørende sykkel-/utstyrBestilling
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnRegisterOrder_Click() Handles btnRegisterOrder.Click

        customer.setCustomerID(customerCustomerID)
        order = New Order(bicycleList, customer, employee, fromDate, toDate, discount)

        'Legge til totalpris
        order.sum = order.getTotalPrice()

        order.registerOrder()

        MsgBox("Bestillingen er registrert")
        btnNewOrder_Click()
    End Sub

    ''' <summary>
    ''' Legger valgt sykkel (tekstbokser) inn i liste over sykler til bestillingen.
    ''' </summary>
    ''' <remarks>Startet med å skjekke om sykkel allerede er i bestillingen.
    ''' Skriver deretter noe info til listeboks på siste side.
    ''' </remarks>
    Private Sub btnAddToOrder_Click() Handles btnAddToOrder.Click
        Dim frameCheck As String = txtBxFramenumber.Text 'Sjekker om sykkelen allerede er lagt til listen for bestillingen.
        For Each item In ListBoxOrderOverview.Items
            If item.contains(frameCheck) Then
                MsgBox("Sykkelen er allerede i bestillingen")
                addNewBicycle()
                Exit Sub
            End If
        Next

        setTestBicycle()
        Dim tempModel As New Model(modelModel, modelPrice, modelProducer, modelCategory)
        Dim tempBicycle As New Bike(bikeFrameNumber, "", "", "", "", "", "", "", tempModel)
        tempBicycle.setBikeUnderOrder(bikeFrameNumber)

        For Each itemChecked In lstbxEquipment.CheckedItems 'For hver utstyr checkbox markert hentes første utstyr som er ledig av den typen  
            'og legges til i equipmentList til sykkelen. under_bestilling settes til 1 for å unngå konflikt. 
            Dim tempEquipment As New Equipment
            Dim data As DataTable

            tempEquipment.equipmentType = itemChecked.item("type").ToString()

            data = tempEquipment.getEquipmentID(tempEquipment.equipmentType) 'Henter varenr og pris til utstyr som er på lager, og som enda IKKE er under bestilling(under_bestilling=0)

            tempEquipment.equipmentID = data.Rows(0)("varenr")
            tempEquipment.equipmentPrice = data.Rows(0)("pris")
            tempEquipment.setEquipmentUnderOrder(tempEquipment.equipmentID) ' Setter under_bestilling =True

            tempBicycle.equipmentList.Add(tempEquipment)
        Next

        bicycleList.Add(tempBicycle)

        ListBoxReceipt.Items.Add(bicycleCounter + 1 & ". sykkel i bestilling")
        ListBoxReceipt.Items.Add("_________________________________________________________")

        ListBoxReceipt.Items.Add("Kategori: " & bicycleList(bicycleCounter).model.category)
        ListBoxReceipt.Items.Add("Modell: " & bicycleList(bicycleCounter).model.model)
        ListBoxReceipt.Items.Add("Pris: " & bicycleList(bicycleCounter).model.price)
        ListBoxReceipt.Items.Add("Merke: " & bicycleList(bicycleCounter).model.producer)
        ListBoxReceipt.Items.Add("Rammenummer: " & bicycleList(bicycleCounter).frameNumber)

        ListBoxReceipt.Items.Add("__________________________________________________________")
        ListBoxReceipt.Items.Add("")

        ListBoxOrderOverview.Items.Add(vbTab & bicycleList(bicycleCounter).frameNumber & ", " & bicycleList(bicycleCounter).model.category & "sykkel")
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add(vbTab & "Tilleggsutstyr:")
        For Each item In lstbxEquipment.CheckedItems
            ListBoxOrderOverview.Items.Add(vbTab & vbTab & item.item("type").ToString())
        Next
        ListBoxOrderOverview.Items.Add("")


        bicycleCounter += 1

        addNewBicycle()
    End Sub

    ''' <summary>
    ''' Skriver sammendrag av bestilling, tenkt som kvittering
    ''' </summary>
    ''' <remarks>Skrives til ListBox</remarks>
    Private Sub btnPrintReceipt_Click() Handles btnPrintReceipt.Click
        setTestOrder()
        Dim customer As New Customer(customerFirstname, customerLastname, customerPhone, customerEmail)
        employee = order.getEmployee(employee.employeeID)
        order = New Order(bicycleList, customer, employee, fromDate, toDate, discount)

        ListBoxReceipt.Items.Add("")
        ListBoxReceipt.Items.Add("")
        ListBoxReceipt.Items.Add("Sammendrag")
        ListBoxReceipt.Items.Add("_________________________________________________________")
        If bicycleCounter = 1 Then
            ListBoxReceipt.Items.Add(bicycleCounter & " sykkel")
        Else
            ListBoxReceipt.Items.Add(bicycleCounter & " sykler")
        End If
        ListBoxReceipt.Items.Add("Fra " & FormatDateTime(fromDate, DateFormat.ShortDate))
        ListBoxReceipt.Items.Add("Til og med " & FormatDateTime(toDate, DateFormat.ShortDate))
        ListBoxReceipt.Items.Add("Rabatt: " & discount)
        ListBoxReceipt.Items.Add("Selger: " & employee.getFirstname() & " " & employee.getLastname())
        ListBoxReceipt.Items.Add("Kunde: " & customerFirstname & " " & customerLastname & " KID: " & customerCustomerID)
        ListBoxReceipt.Items.Add("Antall dager: " & order.getTimeSpanOfOrder)
        ListBoxReceipt.Items.Add("Totalpris: " & order.getTotalPrice)
        ListBoxReceipt.Items.Add("__________________________________________________________")


    End Sub
    Private Sub OrderTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCustomerGridView()
        updateBicycleGridView()
        Bestilling.Dock = DockStyle.Fill
        lblUID.Text &= Account.userID
    End Sub

    ''' <summary>
    ''' Prossedyrer som oppdaterer DataGridView med data fra tekstfeltene.
    ''' </summary>
    ''' <remarks>Kalles ved hver endring i samtlige tekstbokser, og ved lasting av form.</remarks>
    Public Sub updateCustomerGridView()
        DataGridViewKunde.DataSource = order.updateCustomer()
    End Sub
    Private Sub updateBicycleGridView()
        dgvBicycle.DataSource = order.searchBicycle()
    End Sub


    ''' <summary>
    ''' Prossedyre for henting av Kune-/Sykkeldata fra database
    ''' </summary>
    ''' <remarks>Når det trykkes på en celle blir kollonne 0 og rad Y innholdet sendt for å hente resterende data som fyller  tekstfelt 
    '''</remarks>
    Private Sub getFromGridViewKunde() Handles DataGridViewKunde.CellClick
        Dim rowChoice As Integer = DataGridViewKunde.CurrentCellAddress.Y 'Finner Y rad some er valgt i datagridview 
        Dim customerID As String
        Dim data As New DataTable

        customerID = DataGridViewKunde.Rows(rowChoice).Cells(0).Value.ToString()

        'Sender valgt Kunde fra GridView og får tilbake resultater som settes inn i Kunde sine tekstbokser 
        data = order.getCustomerById(customerID)

        txtBxKID.Text = data.Rows(0)(0).ToString()
        txtBxFirstName.Text = data.Rows(0)(1).ToString()
        txtBxSurName.Text = data.Rows(0)(2).ToString()
        txtBxPhone.Text = data.Rows(0)(3).ToString()
        txtBxEmail.Text = data.Rows(0)(4).ToString()

    End Sub
    Private Sub getFromDgvBicycle_CellContentClick() Handles dgvBicycle.CellClick
        Dim rowChoice As Integer = dgvBicycle.CurrentCellAddress.Y 'Finner Y rad some er valgt i datagridview 
        Dim tempBike As String
        Dim data As New DataTable

        tempBike = dgvBicycle.Rows(rowChoice).Cells(0).Value.ToString()

        ' Sender valgt Sykkel fra DataGridView og får tilbake resultater som settes inn i Sykkeltekstboksene 

        data = order.getBikeJoinModel(tempBike)

        txtBxCategory.Text = data.Rows(0)(0).ToString()
        txtBxModel.Text = data.Rows(0)(1).ToString()
        txtBxPrice.Text = data.Rows(0)(2).ToString()
        txtBxProducer.Text = data.Rows(0)(3).ToString()
        txtBxFramenumber.Text = data.Rows(0)(4).ToString()

        Dim tempEquipment As New Equipment
        lstbxEquipment.DataSource = Nothing
        lstbxEquipment.DataSource = tempEquipment.getCompatibleEquipment(txtBxModel.Text) 'Fyller checkedListBox med utstyr som er på lager. Basert på model som er valgt. 
        'Viser bare en checkbox per utstyr Type
        lstbxEquipment.DisplayMember = "type"

    End Sub

    ''' <summary>
    ''' Prossedyrer som håndterer ren GUI funksjonalitet
    ''' </summary>
    ''' <remarks>Trigges av knappetrykk</remarks>
    Private Sub btnNextSammendrag_Click() Handles btnNextSammendrag.Click

        If CalendarFrom.SelectionStart.DayOfYear > CalendarTo.SelectionEnd.DayOfYear Then
            MsgBox("Tidsperioden som er valgt er ikke gyldig")
            Exit Sub
        End If

        Bestilling.SelectTab(3)

        ListBoxOrderOverview.Items.Add("Leieperiode:")
        ListBoxOrderOverview.Items.Add(vbTab & "Fra: " & CalendarFrom.SelectionStart)
        ListBoxOrderOverview.Items.Add(vbTab & "Til og med: " & FormatDateTime(CalendarTo.SelectionEnd, DateFormat.ShortDate))
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add("Rabatt:")
        ListBoxOrderOverview.Items.Add(vbTab & CmbBoxDiscount.Text)
    End Sub
    Private Sub addNewBicycle()
        txtBxCategory.Text = ""
        txtBxProducer.Text = ""
        txtBxModel.Text = ""
        txtBxPrice.Text = "0"
        txtBxFramenumber.Text = ""
        lstbxEquipment.DataSource = Nothing
    End Sub

    Private Sub createCustomerFromTextFields()
        Dim firstname As String = txtBxFirstName.Text
        Dim lastname As String = txtBxSurName.Text
        Dim phone As String = txtBxPhone.Text
        Dim email As String = txtBxEmail.Text
        customer = New Customer(firstname, lastname, phone, email)
    End Sub

    Private Sub btnChangeCustomer_Click() Handles btnChangeCustomer.Click
        createCustomerFromTextFields()
        customer.editCustomer(txtBxKID.Text)
        updateCustomerGridView()
    End Sub
    Private Sub btnNextToSykkel_Click() Handles btnNextToSykkel.Click

        Bestilling.SelectTab(1)
        ListBoxOrderOverview.Items.Add("Kunde:")
        ListBoxOrderOverview.Items.Add(vbTab & txtBxFirstName.Text)
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add("Sykkel:")

        createCustomerFromTextFields()
        employee = New Employee()
        Dim table As DataTable = employee.selectEmployeeById(Account.userID)
        Dim id As String = table.Rows(0)(0)
        employee = New Employee(id)
    End Sub
    Private Sub btnNextBestilling_Click() Handles btnNextBestilling.Click
        Bestilling.SelectTab(2)
    End Sub
    Private Sub btnBackKunde_Click() Handles btnBackKunde.Click
        Bestilling.SelectTab(0)
    End Sub
    Private Sub btnRegisterNewcustomer_Click() Handles btnCreateNewCustomer.Click
        CustomerTest.Show()
    End Sub
    Private Sub btnNewOrder_Click() Handles btnNewOrder.Click
        txtBxFirstName.Text = ""
        txtBxSurName.Text = ""
        txtBxPhone.Text = ""
        txtBxEmail.Text = ""
        txtBxKID.Text = ""
        txtBxCategory.Text = ""
        txtBxProducer.Text = ""
        txtBxModel.Text = ""
        txtBxPrice.Text = ""
        txtBxFramenumber.Text = ""
        CmbBoxDiscount.SelectedIndex = 0
        ListBoxReceipt.Items.Clear()
        ListBoxOrderOverview.Items.Clear()
        Bestilling.SelectTab(0)
        Dim tempEquipment As New Equipment
        Dim tempBike As New Bike
        tempEquipment.setAllEquipmentNotUnderOrder()
        tempBike.setAllBikesNotUnderOrder()
        updateBicycleGridView()
        updateCustomerGridView()
        bicycleList.Clear()
        bicycleCounter = 0
    End Sub
    Private Sub btnBackSykkel_Click() Handles btnBackSykkel.Click
        Bestilling.SelectTab(1)
    End Sub
    Private Sub btnBackBestilling_Click() Handles btnBackBestilling.Click
        Bestilling.SelectTab(2)
    End Sub

    Private Sub btnSearchBike(sender As Object, e As EventArgs) Handles btnOrderSearchBike.Click
        Dim model As New Model(txtBxModel.Text, 0.0, txtBxProducer.Text, txtBxCategory.Text)
        bike = New Bike(txtBxFramenumber.Text, "", "", "", "", "", "", "", model)
        order.bike = bike
        updateBicycleGridView()
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        createCustomerFromTextFields()
        customer.deleteCustomer(txtBxKID.Text)
        updateCustomerGridView()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        createCustomerFromTextFields()
        DataGridViewKunde.DataSource = customer.searchCustomer()
    End Sub



    'Private Sub txtBxFirstName_TextChanged() Handles txtBxFirstName.TextChanged
    '    updateCustomerGridView()
    'End Sub
    'Private Sub txtBxSirName_TextChanged() Handles txtBxSirName.TextChanged
    '    updateCustomerGridView()
    'End Sub
    'Private Sub txtBxEmail_TextChanged() Handles txtBxEmail.TextChanged
    '    updateCustomerGridView()
    'End Sub
    'Private Sub txtBxPhone_TextChanged() Handles txtBxPhone.TextChanged
    '    updateCustomerGridView()
    'End Sub
    'Private Sub txtBxKategori_TextChanged() Handles txtBxKategori.TextChanged
    '    updateBicycleGridView()
    'End Sub
    'Private Sub txtBxModell_TextChanged() Handles txtBxModell.TextChanged
    '    updateBicycleGridView()
    'End Sub
    'Private Sub txtBxPris_TextChanged() Handles txtBxPris.TextChanged
    '    updateBicycleGridView()
    'End Sub
    'Private Sub txtBxRammenr_TextChanged() Handles txtBxRammenr.TextChanged
    '    updateBicycleGridView()
    'End Sub
    'Private Sub txtBxMerke_TextChanged() Handles txtBxMerke.TextChanged
    '    updateBicycleGridView()
    'End Sub

    Private Sub btnBackKunde_Click(sender As Object, e As EventArgs) Handles btnBackKunde.Click

    End Sub
End Class