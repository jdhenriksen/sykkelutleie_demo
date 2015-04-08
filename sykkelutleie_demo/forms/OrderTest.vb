''' <summary>
''' Test Form til bestilling/selger funksjoner
''' </summary>
''' <remarks></remarks>
Public Class OrderTest
    Private bicycleList As List(Of Bike)
    Private modelList As List(Of Model)
    Private bicycle As Bike
    Private bicycleModel As Model
    Private customer As Customer
    Private salesman As Employee
    Private order As Order
    Private bicyclePriceCounter As Double
    Private bicycleCounter As Integer = 0
    Private employee As String




    Public Sub setCustomer()
        customer.setEmail(txtBxEmail.Text)
        customer.email = txtBxEmail.Text
        customer.firstname = txtBxFirstName.Text
        customer.lastname = txtBxSirName.Text
        customer.phone = txtBxPhone.Text
        customer.customerID = txtBxKID.Text
    End Sub
    Public Sub setBicycle()
        bicycle.model = bicycleModel
        bicycle.frameNumber = txtBxRammenr.Text
    End Sub
    Public Sub setModel()
        bicycleModel.model = txtBxModell.Text
        bicycleModel.category = txtBxKategori.Text
        If txtBxPris.Text = "" Then
            bicycleModel.price = 0.0
        Else
            bicycleModel.price = CDbl(txtBxPris.Text)
        End If

        bicycleModel.producer = txtBxMerke.Text
    End Sub
    Public Sub setSalesman() 'Fiks hardkoding
        salesman.employeeID = "1"
        salesman.firstname = "Stig"
        salesman.lastname = "Ofstad"
    End Sub
    Public Sub setOrder()
        order.bicycleList = bicycleList
        order.customer = customer
        order.salesman = salesman
        order.fromDate = CalendarFrom.SelectionStart
        order.toDate = CalendarTo.SelectionEnd
        order.discount = CmbBoxDiscount.Text
        order.bicyclePriceCounter = bicyclePriceCounter
    End Sub


    Private Sub btnRegisterOrder_Click() Handles btnRegisterOrder.Click
        setCustomer()
        setSalesman()
        setOrder()

        order.registerOrder()

        MsgBox("Bestillingen er registrert")
    End Sub
    Private Sub btnAddToOrder_Click() Handles btnAddToOrder.Click
        Dim frameCheck As String = txtBxRammenr.Text 'Skjekker om sykkelen allerede er lagt til listen for bestillingen.
        For Each item In ListBoxOrderOverview.Items
            If item.contains(frameCheck) Then
                MsgBox("Sykkelen er allerede i bestillingen")
                Exit Sub
            End If
        Next

        setBicycle()
        bicycleList.Add(bicycle)
        setModel()
        modelList.Add(bicycleModel)

        ListBoxReceipt.Items.Add(bicycleCounter + 1 & ". sykkel i bestilling")
        ListBoxReceipt.Items.Add("_________________________________________________________")

        ListBoxReceipt.Items.Add("Kategori: " & modelList(bicycleCounter).category)
        ListBoxReceipt.Items.Add("Modell: " & modelList(bicycleCounter).model)
        ListBoxReceipt.Items.Add("Pris: " & modelList(bicycleCounter).price)
        ListBoxReceipt.Items.Add("Merke: " & modelList(bicycleCounter).producer)
        ListBoxReceipt.Items.Add("Rammenummer: " & bicycleList(bicycleCounter).frameNumber)

        ListBoxReceipt.Items.Add("__________________________________________________________")
        ListBoxReceipt.Items.Add("")

        ListBoxOrderOverview.Items.Add(vbTab & bicycleList(bicycleCounter).frameNumber & ", " & modelList(bicycleCounter).category & "sykkel")
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add(vbTab & "Tilleggsutstyr:")
        For Each s As String In CheckedListBox1.CheckedItems
            ListBoxOrderOverview.Items.Add(vbTab & vbTab & s)
        Next
        ListBoxOrderOverview.Items.Add("")


        bicyclePriceCounter += bicycleModel.price
        bicycleCounter += 1

    End Sub

    ''' <summary>
    ''' Skriver sammendrag av bestilling, tenkt som kvittering
    ''' </summary>
    ''' <remarks>Skrives til ListBox</remarks>
    Private Sub btnPrintReceipt_Click() Handles btnPrintReceipt.Click
        setOrder()
        setCustomer()
        setSalesman()

        ListBoxReceipt.Items.Add("")
        ListBoxReceipt.Items.Add("")

        ListBoxReceipt.Items.Add("Sammendrag")
        ListBoxReceipt.Items.Add("_________________________________________________________")
        If bicycleCounter = 1 Then
            ListBoxReceipt.Items.Add(bicycleCounter & " sykkel")
        Else
            ListBoxReceipt.Items.Add(bicycleCounter & " sykler")
        End If
        ListBoxReceipt.Items.Add("Fra " & FormatDateTime(order.fromDate, DateFormat.ShortDate))
        ListBoxReceipt.Items.Add("Til og med " & FormatDateTime(order.toDate, DateFormat.ShortDate))
        ListBoxReceipt.Items.Add("Rabatt: " & order.discount)
        ListBoxReceipt.Items.Add("Selger: " & salesman.firstname & " " & salesman.lastname)
        ListBoxReceipt.Items.Add("Kunde: " & customer.firstname & " " & customer.lastname & " KID: " & customer.customerID)
        ListBoxReceipt.Items.Add("Antall dager: " & order.getTimeSpanOfOrder)
        ListBoxReceipt.Items.Add("Totalpris: " & order.getTotalPrice)
        ListBoxReceipt.Items.Add("__________________________________________________________")

    End Sub
    ''' <summary>
    ''' Registrerer ordren i databasen. Men tilhørende sykkel-/utstyrBestilling
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateCustomerGridView()
        setOrder()
        setCustomer()

        DataGridViewKunde.DataSource = order.updateCustomer()

    End Sub
    Private Sub updateBicycleGridView()
        Dim order As New Order
        setModel()
        setBicycle()

        dgvBicycle.DataSource = order.updateBicycle()
    End Sub
    Private Sub OrderTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCustomer()
        setModel()
        setSalesman()
        setBicycle()
        setOrder()

        updateCustomerGridView()
        updateBicycleGridView()

        Bestilling.Dock = DockStyle.Fill
    End Sub
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
    Private Sub btnAddNewBicycle_Click() Handles btnAddNewBicycle.Click
        txtBxKategori.Text = ""
        txtBxMerke.Text = ""
        txtBxModell.Text = ""
        txtBxPris.Text = "0"
        txtBxRammenr.Text = ""
    End Sub
    Private Sub btnNextSammendrag_Click() Handles btnNextSammendrag.Click
        btnPrintReceipt_Click()

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
    Private Sub btnChangeCustomer_Click() Handles btnChangeCustomer.Click
        txtBxFirstName.Text = ""
        txtBxSirName.Text = ""
        txtBxPhone.Text = ""
        txtBxEmail.Text = ""
        txtBxKID.Text = ""
    End Sub
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
    Private Sub Button1_Click()
        End
    End Sub
    Private Sub Button2_Click() Handles btnNextToSykkel.Click

        Bestilling.SelectTab(1)
        ListBoxOrderOverview.Items.Add("Kunde:")
        ListBoxOrderOverview.Items.Add(vbTab & txtBxFirstName.Text)
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add("Sykkel:")
    End Sub
    Private Sub Button4_Click()
        End
    End Sub
    Private Sub Button3_Click() Handles btnNextBestilling.Click
        Bestilling.SelectTab(2)
    End Sub
    Private Sub Button5_Click() Handles btnBackKunde.Click
        Bestilling.SelectTab(0)
    End Sub
    Private Sub Button6_Click() Handles btnCreateNewCustomer.Click
        CustomerTest.Show()
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