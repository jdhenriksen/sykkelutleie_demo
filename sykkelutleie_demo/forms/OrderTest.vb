''' <summary>
''' Test Form til bestilling/selger funksjoner
''' </summary>
''' <remarks></remarks>
Public Class OrderTest
    Private bicycleList As New List(Of Bike)
    Private bicycleCounter As Integer = 0
    Private employee As String
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

    Private salesmanEmployeeID As String
    Private salesmanFirstname As String
    Private salesmanLastname As String


    ''' <summary>
    ''' Prossedyrer som setter variablene fra tekstbokser.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub setTestOrder()
        setTestSalesman()
        setTestCustomer()
        fromDate = CalendarFrom.SelectionStart
        toDate = CalendarTo.SelectionEnd
        discount = CmbBoxDiscount.Text

    End Sub
    Public Sub setTestBicycle()
        modelCategory = txtBxKategori.Text
        If txtBxPris.Text = "" Then
            modelPrice = 0.0
        Else
            modelPrice = CDbl(txtBxPris.Text)
        End If
        modelModel = txtBxModell.Text
        modelProducer = txtBxMerke.Text
        bikeFrameNumber = txtBxRammenr.Text
    End Sub
    Public Sub setTestCustomer()
        customerEmail = txtBxEmail.Text
        customerFirstname = txtBxFirstName.Text
        customerLastname = txtBxSirName.Text
        customerPhone = txtBxPhone.Text
        customerCustomerID = txtBxKID.Text
    End Sub
    Public Sub setTestSalesman() 'Forløbig hardkodet
        salesmanEmployeeID = "1"
        salesmanFirstname = "Stig"
        salesmanLastname = "Ofstad"
    End Sub




    ''' <summary>
    ''' Registrerer ordren i databasen. Men tilhørende sykkel-/utstyrBestilling
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnRegisterOrder_Click() Handles btnRegisterOrder.Click
        setTestOrder()

        Dim customer As New Customer(customerFirstname, customerLastname, customerPhone, customerEmail)
        customer.setCustomerID(customerCustomerID)
        Dim employee As New Employee(salesmanFirstname, salesmanLastname, "", "", "", "", "", "soofstad", "") 'Mangler ansatt id her
        Dim order As New Order(bicycleList, customer, employee, fromDate, toDate, discount)

        order.registerOrder()

        MsgBox("Bestillingen er registrert")
    End Sub
    ''' <summary>
    ''' Legger valgt sykkel (tekstbokser) inn i liste over sykler til bestillingen.
    ''' </summary>
    ''' <remarks>Startet med å skjekke om sykkel allerede er i bestillingen.
    ''' Skriver deretter noe info til listeboks på siste side.
    ''' </remarks>
    Private Sub btnAddToOrder_Click() Handles btnAddToOrder.Click
        Dim frameCheck As String = txtBxRammenr.Text 'Skjekker om sykkelen allerede er lagt til listen for bestillingen.
        For Each item In ListBoxOrderOverview.Items
            If item.contains(frameCheck) Then
                MsgBox("Sykkelen er allerede i bestillingen")
                Exit Sub
            End If
        Next

        setTestBicycle()
        Dim tempModel As New Model(modelModel, modelPrice, modelProducer, modelCategory)
        Dim tempBicycle As New Bike(bikeFrameNumber, "", "", "", "", "", "", "", tempModel)
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
        For Each s As String In CheckedListBox1.CheckedItems
            ListBoxOrderOverview.Items.Add(vbTab & vbTab & s)
        Next
        ListBoxOrderOverview.Items.Add("")


        bicycleCounter += 1

        btnAddNewBicycle_Click()
    End Sub
    ''' <summary>
    ''' Skriver sammendrag av bestilling, tenkt som kvittering
    ''' </summary>
    ''' <remarks>Skrives til ListBox</remarks>
    Private Sub btnPrintReceipt_Click() Handles btnPrintReceipt.Click
        setTestOrder()
        Dim customer As New Customer(customerFirstname, customerLastname, customerPhone, customerEmail)
        Dim employee As New Employee(salesmanFirstname, salesmanLastname, "", "", "", "", "", "soofstad", "passord123") 'Mangler ansatt id her
        Dim order As New Order(bicycleList, customer, employee, fromDate, toDate, discount)

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
        ListBoxReceipt.Items.Add("Selger: " & salesmanFirstname & " " & salesmanLastname)
        ListBoxReceipt.Items.Add("Kunde: " & customerFirstname & " " & customerLastname & " KID: " & customerCustomerID)
        ListBoxReceipt.Items.Add("Antall dager: " & order.getTimeSpanOfOrder)
        ListBoxReceipt.Items.Add("Totalpris: " & order.getTotalPrice)
        ListBoxReceipt.Items.Add("__________________________________________________________")

    End Sub
    Private Sub OrderTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCustomerGridView()
        updateBicycleGridView()

        Bestilling.Dock = DockStyle.Fill
    End Sub



    ''' <summary>
    ''' Prossedyrer som oppdaterer DataGridView med data fra tekstfeltene.
    ''' </summary>
    ''' <remarks>Kalles ved hver endring i samtlige tekstbokser, og ved lasting av form.</remarks>
    Private Sub updateCustomerGridView()
        setTestCustomer()
        Dim customer As New Customer(customerFirstname, customerLastname, customerPhone, customerEmail)
        Dim order As New Order
        DataGridViewKunde.DataSource = order.updateCustomer(customer)

    End Sub
    Private Sub updateBicycleGridView()
        setTestBicycle()
        Dim tempModel As New Model(modelModel, modelPrice, modelProducer, modelCategory)
        Dim tempBicycle As New Bike(bikeFrameNumber, "", "", "", "", "", "", "", tempModel)
        Dim order As New Order
        dgvBicycle.DataSource = order.updateBicycle(tempBicycle)
    End Sub


    ''' <summary>
    ''' Prossedyre for henting av Kune-/Sykkeldata fra database
    ''' </summary>
    ''' <remarks>Når det trykkes på en celle blir kollonne 0 og rad Y innholdet sendt for å hente resterende data som fyller  tekstfelt 
    '''</remarks>
    Private Sub getFromGridViewKunde() Handles DataGridViewKunde.CellClick
        Dim dbutil As New DBUtility
        Dim rowChoice As Integer = DataGridViewKunde.CurrentCellAddress.Y 'Finner Y rad some er valgt i datagridview 
        Dim chosenKunde As String
        Dim data As New DataTable

        chosenKunde = DataGridViewKunde.Rows(rowChoice).Cells(0).Value.ToString()

        'Sender valgt Kunde fra GridView og får tilbake resultater som settes inn i Kundel sine tekstbokser 
        data = dbutil.selectQuery("SELECT fornavn, etternavn, telefon, epost, kid FROM kunde WHERE kid ='" & chosenKunde & "'")

        txtBxFirstName.Text = data.Rows(0)(0).ToString()
        txtBxSirName.Text = data.Rows(0)(1).ToString()
        txtBxPhone.Text = data.Rows(0)(2).ToString()
        txtBxEmail.Text = data.Rows(0)(3).ToString()
        txtBxKID.Text = data.Rows(0)(4).ToString()

    End Sub
    Private Sub getFromDgvBicycle_CellContentClick() Handles dgvBicycle.CellClick
        Dim dbUtil As New DBUtility
        Dim rowChoice As Integer = dgvBicycle.CurrentCellAddress.Y 'Finner Y rad some er valgt i datagridview 
        Dim chosenBicycle As String
        Dim data As New DataTable

        chosenBicycle = dgvBicycle.Rows(rowChoice).Cells(0).Value.ToString()

        ' Sender valgt Kunde fra DataGridView og får tilbake resultater som settes inn i Kundetekstboksene 
        data = dbUtil.selectQuery("SELECT kategori, sykkel.modell, pris, produsent, rammenr FROM  sykkel JOIN modell ON sykkel.modell=modell.modell  WHERE rammenr ='" & chosenBicycle & "'")

        txtBxKategori.Text = data.Rows(0)(0).ToString()
        txtBxModell.Text = data.Rows(0)(1).ToString()
        txtBxPris.Text = data.Rows(0)(2).ToString()
        txtBxMerke.Text = data.Rows(0)(3).ToString()
        txtBxRammenr.Text = data.Rows(0)(4).ToString()

    End Sub




    ''' <summary>
    ''' Prossedyrer som trigges av endring i tekstboksene
    ''' </summary>
    ''' <remarks>Muligjør levende søk</remarks>
    Private Sub txtBxFirstName_TextChanged() Handles txtBxFirstName.TextChanged
        updateCustomerGridView()
    End Sub
    Private Sub txtBxSirName_TextChanged() Handles txtBxSirName.TextChanged
        updateCustomerGridView()
    End Sub
    Private Sub txtBxEmail_TextChanged() Handles txtBxEmail.TextChanged
        updateCustomerGridView()
    End Sub
    Private Sub txtBxPhone_TextChanged() Handles txtBxPhone.TextChanged
        updateCustomerGridView()
    End Sub
    Private Sub txtBxKategori_TextChanged() Handles txtBxKategori.TextChanged
        updateBicycleGridView()
    End Sub
    Private Sub txtBxModell_TextChanged() Handles txtBxModell.TextChanged
        updateBicycleGridView()
    End Sub
    Private Sub txtBxPris_TextChanged() Handles txtBxPris.TextChanged
        updateBicycleGridView()
    End Sub
    Private Sub txtBxRammenr_TextChanged() Handles txtBxRammenr.TextChanged
        updateBicycleGridView()
    End Sub
    Private Sub txtBxMerke_TextChanged() Handles txtBxMerke.TextChanged
        updateBicycleGridView()
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
    Private Sub btnAddNewBicycle_Click() Handles btnAddNewBicycle.Click
        txtBxKategori.Text = ""
        txtBxMerke.Text = ""
        txtBxModell.Text = ""
        txtBxPris.Text = "0"
        txtBxRammenr.Text = ""
    End Sub
    Private Sub btnChangeCustomer_Click() Handles btnChangeCustomer.Click
        txtBxFirstName.Text = ""
        txtBxSirName.Text = ""
        txtBxPhone.Text = ""
        txtBxEmail.Text = ""
        txtBxKID.Text = ""
    End Sub
    Private Sub btnNextToSykkel_Click() Handles btnNextToSykkel.Click

        Bestilling.SelectTab(1)
        ListBoxOrderOverview.Items.Add("Kunde:")
        ListBoxOrderOverview.Items.Add(vbTab & txtBxFirstName.Text)
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add("Sykkel:")
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
        txtBxSirName.Text = ""
        txtBxPhone.Text = ""
        txtBxEmail.Text = ""
        txtBxKID.Text = ""
        txtBxKategori.Text = ""
        txtBxMerke.Text = ""
        txtBxModell.Text = ""
        txtBxPris.Text = "0"
        txtBxRammenr.Text = ""
        For i = 0 To (CheckedListBox1.Items.Count - 1)
            CheckedListBox1.SetItemChecked(i, False)
        Next

        CmbBoxDiscount.SelectedIndex = 0
        ListBoxReceipt.Items.Clear()
        ListBoxOrderOverview.Items.Clear()
        Bestilling.SelectTab(0)
    End Sub
    Private Sub btnBackSykkel_Click() Handles btnBackSykkel.Click
        Bestilling.SelectTab(1)
    End Sub
    Private Sub btnBackBestilling_Click() Handles btnBackBestilling.Click
        Bestilling.SelectTab(2)
    End Sub

End Class