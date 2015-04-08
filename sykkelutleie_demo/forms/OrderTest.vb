''' <summary>
''' Test Form til bestilling/selger funksjoner
''' </summary>
''' <remarks></remarks>
Public Class OrderTest
    Private bicycleList(50, 4) As String
    Private bicyclePrice As Double
    Private bicyclePriceCounter As Double
    Private bicycleCounter As Integer = 0
    Private employee As String
    Private customer As String
    Private cmr As Customer
 
    ''' <summary>
    ''' Lager objekter for å bruke i bestillings behandlingen
    ''' </summary>
    ''' <returns>Returnerer ordre objekt</returns>
    ''' <remarks>Samme for de neste 3 rutinene</remarks>
    Private Function createOrder() As Order
        Dim newOrder As New Order(CalendarFrom.SelectionStart, CalendarTo.SelectionEnd, txtBxKID.Text, "21", bicyclePriceCounter, CmbBoxDiscount.Text)

        Return newOrder
    End Function
    Private Function createModel() As Model
        Dim tempbicyclePrice As Double

        If txtBxPris.Text = "" Then
            tempbicyclePrice = 0.0
        Else
            tempbicyclePrice = CDbl(txtBxPris.Text)
        End If

        Dim newModel As New Model(txtBxModell.Text, tempbicyclePrice, txtBxMerke.Text, txtBxKategori.Text)
      
        Return newModel
    End Function
    Private Function createBicycle() As Bike
        Dim newBike As New Bike(txtBxRammenr.Text, "", "", "", "", "", "", "", createModel)

        Return newBike
    End Function
    Private Function createCustomer() As Customer
        Dim newCustomer As New Customer(txtBxFirstName.Text, txtBxSirName.Text, txtBxPhone.Text, txtBxEmail.Text)

        Return newCustomer
    End Function
    ''' <summary>
    ''' Skriver sammendrag av bestilling, tenkt som kvittering
    ''' </summary>
    ''' <remarks>Skrives til ListBox</remarks>
    Private Sub btnPrintReceipt_Click() Handles btnPrintReceipt.Click
        Dim dateFrom = CalendarFrom.SelectionStart
        Dim dateTo As Date = createOrder.toDate
        Dim discount As String = createOrder.discount
        employee = "Per Selgersen" 'Currently logged in salesman
        Dim kid As String = txtBxKID.Text
        customer = txtBxFirstName.Text & " " & txtBxSirName.Text & " kid: " & kid

        ListBoxReceipt.Items.Add("")
        ListBoxReceipt.Items.Add("")

        ListBoxReceipt.Items.Add("Sammendrag")
        ListBoxReceipt.Items.Add("_________________________________________________________")
        If bicycleCounter = 1 Then
            ListBoxReceipt.Items.Add(bicycleCounter & " sykkel")
        Else
            ListBoxReceipt.Items.Add(bicycleCounter & " sykler")
        End If
        ListBoxReceipt.Items.Add("Fra " & dateFrom)
        ListBoxReceipt.Items.Add("Til og med " & FormatDateTime(dateTo, DateFormat.ShortDate))
        ListBoxReceipt.Items.Add("Rabatt: " & discount)
        ListBoxReceipt.Items.Add("Selger: " & employee)
        ListBoxReceipt.Items.Add("Kunde: " & customer)
        ListBoxReceipt.Items.Add("Antall dager: " & createOrder.getTimeSpanOfOrder)
        ListBoxReceipt.Items.Add("Totalpris: " & createOrder.getTotalPrice)
        ListBoxReceipt.Items.Add("__________________________________________________________")

    End Sub
    ''' <summary>
    ''' Registrerer ordren i databasen. Men tilhørende sykkel-/utstyrBestilling
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnRegisterOrder_Click() Handles btnRegisterOrder.Click
        Try

            Dim newOrder As Order = createOrder()
            newOrder.registerOrder()

            For i = 0 To bicycleCounter - 1 'Blar seg igjennom alle sykkler i bestillingen å oppretter kobling i databasen
                Dim bicycleOrder As New BicycleOrder(createOrder.getOrderID, bicycleList(i, 4))

                bicycleOrder.registerBicycleOrder()
            Next
        Catch ex As Exception
            MsgBox("Noe gikk galt under registrering av bestillingen..." & ex.Message)
            Exit Sub
        End Try
        MsgBox("Bestillingen er registrert")
    End Sub
    Private Sub updateCustomerGridView()
        Dim order As New Order

        dtgvKunde.DataSource = order.updateCustomer(createCustomer)

    End Sub
    Private Sub updateBicycleGridView()
        Dim order As New Order

        dgvBicycle.DataSource = order.updateBicycle(createModel, createBicycle)
    End Sub
    Private Sub OrderTest_Load() Handles MyBase.Load
        updateCustomerGridView()
        updateBicycleGridView()

        Bestilling.Dock = DockStyle.Fill
    End Sub
    Private Sub getFromGridViewKunde() Handles dtgvKunde.CellClick
        Dim dbutil As New DBUtility
        Dim rowChoice As Integer = dtgvKunde.CurrentCellAddress.Y 'Finner Y rad some er valgt i datagridview 
        Dim chosenKunde As String
        Dim data As New DataTable

        chosenKunde = dtgvKunde.Rows(rowChoice).Cells(0).Value.ToString()

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
    Private Sub btnAddToOrder_Click() Handles btnAddToOrder.Click
        Dim frameCheck As String = txtBxRammenr.Text 'Skjekker om sykkelen allerede er lagt til listen for bestillingen.
        For Each item In ListBoxOrderOverview.Items
            If item.contains(frameCheck) Then
                MsgBox("Sykkelen er allerede i bestillingen")
                Exit Sub
            End If
        Next

        bicycleList(bicycleCounter, 0) = txtBxKategori.Text
        bicycleList(bicycleCounter, 1) = txtBxModell.Text
        bicycleList(bicycleCounter, 2) = txtBxPris.Text
        bicycleList(bicycleCounter, 3) = txtBxMerke.Text
        bicycleList(bicycleCounter, 4) = txtBxRammenr.Text

        ListBoxReceipt.Items.Add(bicycleCounter + 1 & ". sykkel i bestilling")
        ListBoxReceipt.Items.Add("_________________________________________________________")

        ListBoxReceipt.Items.Add("Kategori: " & bicycleList(bicycleCounter, 0))
        ListBoxReceipt.Items.Add("Modell: " & bicycleList(bicycleCounter, 1))
        ListBoxReceipt.Items.Add("Pris: " & bicycleList(bicycleCounter, 2))
        ListBoxReceipt.Items.Add("Merke: " & bicycleList(bicycleCounter, 3))
        ListBoxReceipt.Items.Add("Rammenummer: " & bicycleList(bicycleCounter, 4))

        ListBoxReceipt.Items.Add("__________________________________________________________")
        ListBoxReceipt.Items.Add("")

        ListBoxOrderOverview.Items.Add(vbTab & bicycleList(bicycleCounter, 4) & ", " & bicycleList(bicycleCounter, 0) & "sykkel")
        ListBoxOrderOverview.Items.Add("")
        ListBoxOrderOverview.Items.Add(vbTab & "Tilleggsutstyr:")
        For Each s As String In CheckedListBox1.CheckedItems
            ListBoxOrderOverview.Items.Add(vbTab & vbTab & s)
        Next
        ListBoxOrderOverview.Items.Add("")


        If txtBxPris.Text = "" Then
            bicyclePrice = 0.0
        Else
            bicyclePrice = CDbl(txtBxPris.Text)
        End If

        bicyclePriceCounter += bicyclePrice
        bicycleCounter += 1

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
    Private Sub Button11_Click()
        End
    End Sub
    Private Sub createCustomerFromTextFields()
        Dim firstname As String = txtBxFirstName.Text
        Dim lastname As String = txtBxSirName.Text
        Dim phone As String = txtBxPhone.Text
        Dim email As String = txtBxEmail.Text

        cmr = New Customer(firstname, lastname, phone, email)
    End Sub
    Private Sub btnChangeCustomer_Click() Handles btnChangeCustomer.Click
        '        txtBxFirstName.Text = ""
        '       txtBxSirName.Text = ""
        '      txtBxPhone.Text = ""
        '     txtBxEmail.Text = ""
        '    txtBxKID.Text = ""
        createCustomerFromTextFields()
        cmr.editCustomer(txtBxKID.Text)
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