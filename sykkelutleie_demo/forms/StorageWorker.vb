Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class StorageWorker
    Private result As Integer
    Public bikemodel As Model
    Public bike As Bike
    Public model As Model
    Public equipment As Equipment
    Private table As DataTable

    ''' <summary>
    ''' BUTTON: Oppretter ny sykkel.
    ''' </summary> 
    ''' <remarks>Benytter seg av bikeobject og modelobject som settes inn i bikeobject.
    ''' Etter en sykkel har blitt opprettet kjøres en nullstilling og oppdatering av combobokser.
    ''' Alt blir resettet og et nytt generelt søk blir gjort for å vise at sykkelen har blitt lagt til.</remarks>
    Private Sub newBike_Click(sender As Object, e As EventArgs) Handles btnNewbike.Click 'Opprett knapp
        objectupdate()      'Nytt object slik at alle verdier er de nyeste.
        If txtFramenumber.Text = "" Or cmbModel.SelectedIndex = -1 Or cmbStatus.SelectedIndex = -1 Or txtFramenumber.TextLength >= 9 Then    'Rammenummer, modelltype og status er minimum før oppretting av sykkel.
            MsgBox("Du må skrive inn et rammenummer mellom 1 og 8 tall, velge modell og sette status")                         'Varsel dersom mimimumskrav ikke er oppfylt
        Else

            result = MsgBox("Vil du opprette sykkel med rammenr: " & bike.getFrameNumber & "?", MsgBoxStyle.YesNo)
            If result = 6 Then                       'Spørsmål om bekreftelse av ny sykkel.
                objectupdate()
                bike.createBike()                           'Hvis svaret på dialogboksen er "Yes" så vil dialogeResult bli "6". Først da kjøres createbike().
                updateComboboxes()                          'Renser og fyller combobokser.
                Nullbike_Click(sender, e)
                searchBike_Click(sender, e)
            Else
                MsgBox("Opprettelse av sykkel ble avbrutt.") 'Hvis "No" blir presset får bruker opp bekreftelse på at ingen sykkel ble opprettet.
            End If
        End If
    End Sub

    ''' <summary>
    ''' BUTTON: Søk etter sykkel.
    ''' </summary>
    ''' <remarks> Søker etter alle de verdier som er skrevet inn.
    ''' Oppdaterer object med nyeste verdier.</remarks>
    Private Sub searchBike_Click(sender As Object, e As EventArgs) Handles btnSearchbike.Click
        objectupdate()
        dtgvBike.DataSource = bike.searchBike() 'Bruker alle tilgjengelge felter med informasjon til å søke etter samsvarende sykler.
        updateComboboxes()                      'Oppdaterer combobokser.
        dtgvBike.ClearSelection()
    End Sub

    ''' <summary>
    ''' BUTTON: Sletting av sykkel.
    ''' </summary>
    ''' <remarks>Sletting av sykkel.
    ''' Bruker bikeobjektet.
    ''' Eneste som brukes er rammenr som er valgt.</remarks>
    Private Sub deleteBike_Click(sender As Object, e As EventArgs) Handles btnDeletebike.Click
        objectupdate()
        result = MsgBox("Vil du slette sykkel med rammenummer: " & bike.getFrameNumber() & "?", MsgBoxStyle.YesNo) 'Spør om bekreftelse angående sletting av sykkel.
        If result = 6 Then        'Hvis Yes er valgt så vil sykkelen bli slettet, Model klassen returnerer en dialogboks som bekrefter.
            bike.deleteBike()
            updateComboboxes()
            Nullbike_Click(sender, e)
            searchBike_Click(sender, e)
        Else
            MsgBox("Sykkel ble ikke slettet.") 'Tilbakemelding om at ingenting ble slettet da bruker avbrøt.
        End If
    End Sub

    ''' <summary>
    ''' BUTTON: Lagrer ny sykkel.
    ''' </summary>
    ''' <remarks>Oppdaterer valgt sykkel med alle feltene.
    ''' Det må velges en sykkel før det er mulighet til å oppdatere.</remarks>
    Private Sub saveBike_Click(sender As Object, e As EventArgs) Handles btnSavebike.Click
        Dim result As Integer
        objectupdate()
        result = MsgBox("Vil du oppdatere sykkel med rammenr: " & bike.getFrameNumber & " sin informasjon? ", MsgBoxStyle.YesNo)
        If result = 6 Then
            If bike.getFrameNumber() = "" Then                      'Dette feltet er låst og blir kun fylt hvis en sykkel blir valgt fra datagridview.
                MsgBox("Du må velge en sykkel fra listen etter søk") 'Hvis det er ingenting der så betyr det at bruker ikke har valgt noe fra søk.
            Else
                bike.changeBike()
            End If
        Else
            MsgBox("Oppdatering av sykkel informasjon ble avbrutt.") 'Bekreftelse hvis bruker avbryter.
        End If

        'Funksjonalitet som sjekker status på sykkel og forespør bruker om det
        'ønskes å sende epost angående reperasjon hvis status tilsier det.
        If cmbStatus.SelectedIndex = 1 Then
            result = MsgBox("vil du sende Email ang reperasjon?", MsgBoxStyle.YesNoCancel)
            If result = DialogResult.Cancel Then
                Close()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Det ble ikke bestilt via mail")
            ElseIf result = DialogResult.Yes Then
                Mail.Show()
            End If
        End If
        updateComboboxes()
        Nullbike_Click(sender, e)
        searchBike_Click(sender, e)
    End Sub

    ''' <summary>
    ''' BUTTON: Mulighet for å endre sykkel.
    ''' </summary>
    ''' <remarks>Endrer knapper og tekstfelt slik at brukeren kan skrive inn endringer.</remarks>
    Private Sub changeBike_Click(sender As Object, e As EventArgs) Handles btnChangebike.Click
        btnSavebike.Enabled = True  'Åpner tekstfelt for redigering i sykkelområde av GUI.
        btnChangebike.Enabled = False
        cmbModel.Enabled = True
        cmbStatus.Enabled = True
        txtLocation.ReadOnly = False
        txtPointofsale.ReadOnly = False
        txtTire.ReadOnly = False
        txtFrame.ReadOnly = False
        txtGear.ReadOnly = False
        txtBrakes.ReadOnly = False
    End Sub

    ''' <summary>
    ''' BUTTON: Opprette en ny modell.
    ''' </summary>
    ''' <remarks>Minimumskrav er at at modellnavn er fylt inn.
    ''' Oppdaterer comboboxer på sykkeldelen siden det er ny modell som må legges til.
    ''' Resetter modellfelt og knapper.
    ''' Helt til slutt tar den et søk så bruker ser at en ny modell er lagt til.</remarks>
    Private Sub newModel_Click(sender As Object, e As EventArgs) Handles btnNewmodel.Click
        objectupdate()
        If txtModelname.Text = "" Then
            MsgBox("Du må skrive inn et modellnavn")
        Else
            result = MsgBox("Vil opprette modell med navn: " & model.getModel() & "?", MsgBoxStyle.YesNo)
            If result = 6 Then
                model.createModel()
                For Each itemChecked In lstbxEqipment.CheckedItems
                    equipment.createCompatibility(model.getModel, (itemChecked.item("type").ToString()))
                Next
                updateComboboxes()
                Nullmodel_Click(sender, e)
                searchModel_Click(sender, e)
                resetCheckedList()
            Else
                MsgBox("Oppretting av modell ble avbrutt.")
            End If
        End If
    End Sub

    ''' <summary>
    ''' BUTTON: Søke etter modell.
    ''' </summary>
    ''' <remarks>Søker etter modeller og den/de som stemmer overens med søk
    ''' fylles inn i modell sin DataGridView</remarks>
    Private Sub searchModel_Click(sender As Object, e As EventArgs) Handles btnSearchmodel.Click
        objectupdate()
        dtgvModel.DataSource = model.searchModel()
        dtgvModel.ClearSelection()
    End Sub

    ''' <summary>
    ''' BUTTON: Lagre (oppdatere) modell
    ''' </summary>
    ''' <remarks>Mulighet for å endre alt utenom navnet.
    ''' Nullstiller modellfelt og søker for å vise at søket er gjort.</remarks>
    Private Sub saveModel_Click(sender As Object, e As EventArgs) Handles btnSavemodel.Click
        btnEqipReset_Click(sender, e)
        btnEqipSearch_Click(sender, e)
        objectupdate()
        table = equipment.getEquipmentGroupByType()
        result = MsgBox("Vil du endre modell med navn: " & model.getModel() & "?", MsgBoxStyle.YesNo)

        If result = 6 Then
            model.editModel()
            For i As Integer = 0 To lstbxEqipment.Items.Count - 1
                Dim chkstate As CheckState
                chkstate = lstbxEqipment.GetItemCheckState(i)
                If (chkstate = CheckState.Checked) Then
                    equipment.createCompatibility(model.getModel, table.Rows(i)("type").ToString)
                Else
                    equipment.removeCompatibility(model.getModel, table.Rows(i)("varenr").ToString())
                End If
            Next

            Nullmodel_Click(sender, e)
            searchModel_Click(sender, e)
            resetCheckedList()
        Else
            MsgBox("Endringer ble ikke lagret.") 'Tilbakemedling hvis bruker avbryter
        End If
    End Sub

    ''' <summary>
    ''' BUTTON: Endre modell.
    ''' </summary>
    ''' <remarks>Kun kosmetiske forandringer der knapper blir enabled, disabled og tekstfelt blir åpnet slik at brukeren kan skrive inn for lagring.</remarks>
    Private Sub changeModel_Click(sender As Object, e As EventArgs) Handles btnChangemodel.Click
        txtModelcategory.ReadOnly = False  'Rediger modeller, denne åpner tekstfelt så ting kan endres på modell.
        txtModelprice.ReadOnly = False
        txtModelproducer.ReadOnly = False
        btnSavemodel.Enabled = True
        btnChangemodel.Enabled = False
        lstbxEqipment.Enabled = True
    End Sub

    ''' <summary>
    ''' ONLOAD: Fyller GridViews for sykkel, modell og tilleggsutstyr.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objectupdate()
        'Fyller modell-bokser med modellvalg
        searchModel_Click(sender, e)
        searchBike_Click(sender, e)
        btnEqipSearch_Click(sender, e)
        resetCheckedList()
        updateComboboxes()
        btnmissingbike_Click(sender, e)
    End Sub

    ''' <summary>
    ''' EVENT: Boks for treff fra søk og velging av sykler fra klikk i celler i GridView.
    ''' </summary>
    ''' <remarks>Kan kun velge en hel rad og uansett hvilken celle man trykker på så vil vi bry oss kun om Y rad.
    ''' Når rad er valgt tas Kolonne 0 og rad y som er rammenummeret.
    ''' Rammenummeret blir da brukt for å finne resten av data som er tilhørende og fyller det inn i tekstfelt.
    ''' Samtidig blir tekstfelt låst slik at bruker forstår at sykkelen er valgt. Knapper blir også forandret.</remarks>
    Private Sub gridViewBike(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvBike.CellClick
        Dim rowchoice As Integer = dtgvBike.CurrentCellAddress.Y 'Finner Y rad som er valgt i datagridview.
        Dim chosenbikenb As String
        Dim testdata As New DataTable

        chosenbikenb = dtgvBike.Rows(rowchoice).Cells(0).Value.ToString() 'Legger rammenr inn i variabel.
        testdata = bike.selectBikeById(chosenbikenb)

        txtFramenumber.Text = chosenbikenb                     'Alt fra DataTable inn i Tekstbokser på edit siden.
        cmbModel.Text = testdata.Rows(0)(0).ToString()
        cmbStatus.Text = testdata.Rows(0)(1).ToString()
        txtLocation.Text = testdata.Rows(0)(2).ToString()
        txtPointofsale.Text = testdata.Rows(0)(3).ToString()
        txtTire.Text = testdata.Rows(0)(4).ToString()
        txtFrame.Text = testdata.Rows(0)(5).ToString()
        txtGear.Text = testdata.Rows(0)(6).ToString()
        txtBrakes.Text = testdata.Rows(0)(7).ToString()

        cmbModel.Enabled = False
        cmbStatus.Enabled = False
        txtFramenumber.ReadOnly = True
        txtLocation.ReadOnly = True
        txtPointofsale.ReadOnly = True
        txtTire.ReadOnly = True
        txtFrame.ReadOnly = True
        txtGear.ReadOnly = True
        txtBrakes.ReadOnly = True

        btnNewbike.Enabled = False
        btnSearchbike.Enabled = False
        btnSavebike.Enabled = False
        btnDeletebike.Enabled = True
        btnChangebike.Enabled = True
    End Sub

    ''' <summary>
    ''' EVENT: Boks for fylling av modelldata ved klikk i celle i GridView.
    ''' </summary>
    ''' <remarks>Når det trykkes på en celle blir kollonne 0 og rad Y innholdet (modellnavnet) sendt for å hente mer data for å fylle inn i tekstfelt 
    ''' Tekstfelt blir låst og knapper endret</remarks>
    Private Sub gridViewModel(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvModel.CellClick
        objectupdate()

        lstbxEqipment.Enabled = False
        resetCheckedList()

        Dim rowchoice As Integer = dtgvModel.CurrentCellAddress.Y 'Finner Y rad some r valgt i datagridview på modelldelen
        Dim chosenmodel As String
        Dim datagrid As New DataGridView
        Dim datafill As New DataTable
        Dim allEquipment As DataTable
        Dim teller As Integer = 0
        Dim count As Integer = 0
        Dim treff As Integer = 0
        Dim arraycount As Integer = 0

        datagrid.DefaultCellStyle.NullValue = 0.0
        chosenmodel = dtgvModel.Rows(rowchoice).Cells(0).Value.ToString()

        'Sender valgt modell fra GridView og får tilbake resultater som settes inn i modell sine tekstbokser 
        datafill = model.getModelById(chosenmodel)

        txtModelname.Text = chosenmodel
        txtModelprice.Text = datafill.Rows(0)(1).ToString()
        txtModelproducer.Text = datafill.Rows(0)(2).ToString()
        txtModelcategory.Text = datafill.Rows(0)(3).ToString()

        btnChangemodel.Enabled = True
        btnSearchmodel.Enabled = False
        btnNewmodel.Enabled = False
        btnSavemodel.Enabled = False

        txtModelname.ReadOnly = True
        txtModelprice.ReadOnly = True
        txtModelproducer.ReadOnly = True
        txtModelcategory.ReadOnly = True

        allEquipment = equipment.getEquipmentGroupByType()
        table = equipment.getEquipmentByModel(chosenmodel)

            While treff < (allEquipment.Rows.Count)
                While teller < (table.Rows.Count)
                    If allEquipment.Rows(treff)(0).ToString() = table.Rows(teller)(0).ToString() Then
                        lstbxEqipment.SetItemChecked(treff, True)
                    End If
                    teller = teller + 1
                End While
                teller = 0
                treff = treff + 1
            End While
    End Sub


    ''' <summary>
    ''' EVENT: Boks for fylling av tilleggsutstyrdata ved klikk i celle i GridView.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub dtgvEquip_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvEquip.CellClick
        Dim rowchoice As Integer = dtgvEquip.CurrentCellAddress.Y
        Dim chosenequipment As String
        Dim datagrid As New DataGridView
        Dim datafill As New DataTable

        datagrid.DefaultCellStyle.NullValue = 0.0
        chosenequipment = dtgvEquip.Rows(rowchoice).Cells(0).Value.ToString()

        'Sender valgt modell fra GridView og får tilbake resultater som settes inn i tilleggsutstyr sine tekstbokser.
        datafill = equipment.selectEquipmentById(chosenequipment)

        txtEqipID.Text = chosenequipment
        txtEqipType.Text = datafill.Rows(0)(1).ToString()
        txtEqipPrice.Text = datafill.Rows(0)(2).ToString()
        txtEqipStatus.Text = datafill.Rows(0)(3).ToString()

        btnEqipDelete.Enabled = True
        btnEqipChange.Enabled = True
        btnEqipSearch.Enabled = False
        btnEqipCreate.Enabled = False
        btnEqipSave.Enabled = False
        btnEqipReset.Enabled = True

        txtEqipID.ReadOnly = True
        txtEqipType.ReadOnly = True
        txtEqipPrice.ReadOnly = True
        txtEqipStatus.ReadOnly = True
    End Sub

    ''' <summary>
    ''' EVENT: Forandring i ComboBox for modell tilhørende sykkel.
    ''' </summary>
    ''' <remarks>Når en annen modell blir valgt finner vi informasjon for å fylle i modelldelen av sykkel.</remarks>
    Private Sub indexChangedModel(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        Dim chosenmodel As String = cmbModel.SelectedItem.ToString()  'Hvis alternativ i ComboBox blir valgt får vi fylt ut 3 andre tekstbokser
        Dim modelfilled As DataTable

        modelfilled = model.getModelById(chosenmodel)
        txtPrice.Text = modelfilled.Rows(0)(1).ToString()
        txtProducer.Text = modelfilled.Rows(0)(2).ToString()
        txtCategory.Text = modelfilled.Rows(0)(3).ToString()
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Oppdaterer combobokser.
    ''' </summary>
    ''' <remarks>Av og til skjer endringer som gjør at vi må oppdatere valgene inne i comboboksene så innholdet reflekterer endringene.</remarks>
    Private Sub updateComboboxes()
        objectupdate()
        Dim comboModelNames As DataTable
        cmbModel.Items.Clear()
        comboModelNames = model.selectAllModels 'Henter modellnavn.
        Dim totalRows As Integer = comboModelNames.Rows.Count()

        For counter As Integer = counter To totalRows - 1 'Fyller opp modell combobox med valg basert på hvor mange modeller er databasen.
            cmbModel.Items.Add(comboModelNames.Rows(counter)(0)) 'Kjøres ofte etter endringer/sletting for å gi brukeren de nyeste valgene.
        Next

        txtProducer.Clear()
        txtPrice.Clear()
        txtCategory.Clear()
        cmbStatus.Items.Clear()

        cmbStatus.Items.Add("Til Reparasjon")
        cmbStatus.Items.Add("Skal til Reparasjon")
        cmbStatus.Items.Add("På Lager")
        cmbStatus.Items.Add("Utleid")
        cmbStatus.Items.Add("Under Transport")
        cmbStatus.Items.Add("Deaktivert")
    End Sub

    ''' <summary>
    ''' Oppdatering av objekter.
    ''' </summary>
    ''' <remarks>Oppdatering av objekter så vi har de nyeste verdier å arbeide med.</remarks>
    Private Sub objectupdate()
        Dim p As Double
        Dim pm As Double
        Double.TryParse(txtEqipPrice.Text, p)
        Double.TryParse(txtModelprice.Text, pm)
        model = New Model(txtModelname.Text, pm, txtModelproducer.Text, txtModelcategory.Text) 'Objekt for modelldel for søk, opprett, slett, endre, lagre.
        bikemodel = New Model(cmbModel.SelectedItem, pm, txtProducer.Text, txtCategory.Text) 'Modell-objekt som sendes med sykkel-objektet.
        bike = New Bike(txtFramenumber.Text, cmbStatus.SelectedItem, txtLocation.Text, txtPointofsale.Text, txtBrakes.Text, txtTire.Text, txtFrame.Text, txtGear.Text, bikemodel) 'Sykkel-objekt.
        equipment = New Equipment(txtEqipID.Text, txtEqipStatus.Text, p, txtEqipType.Text) 'Tilleggsutstyrs-objekt.
    End Sub

    ''' <summary>
    ''' BUTTON: Nullstille komponenter relatert til sykkel.
    ''' </summary>
    ''' <remarks>Fjerner alt fra tekstfelter, datagridview og nullstiller knapper.</remarks>
    Private Sub Nullbike_Click(sender As Object, e As EventArgs) Handles btnNullbike.Click
        cmbModel.Enabled = True
        cmbStatus.Enabled = True
        txtFramenumber.ReadOnly = False
        txtLocation.ReadOnly = False
        txtPointofsale.ReadOnly = False
        txtTire.ReadOnly = False
        txtFrame.ReadOnly = False
        txtGear.ReadOnly = False
        txtBrakes.ReadOnly = False

        btnNewbike.Enabled = True
        btnSearchbike.Enabled = True
        btnDeletebike.Enabled = False
        btnSavebike.Enabled = False
        btnChangebike.Enabled = False

        txtFramenumber.Clear()
        txtLocation.Clear()
        txtPointofsale.Clear()
        txtTire.Clear()
        txtFrame.Clear()
        txtGear.Clear()
        txtBrakes.Clear()

        updateComboboxes()
        dtgvBike.DataSource = Nothing

        objectupdate()
    End Sub

    ''' <summary>
    ''' BUTTON: Nullstiller komponenter relatert til modell.
    ''' </summary>
    ''' <remarks>Fjerner alt fra tekstfelter og nullstiller knappene.</remarks>
    Private Sub Nullmodel_Click(sender As Object, e As EventArgs) Handles btnNullmodel.Click
        txtModelcategory.Clear()
        txtModelname.Clear()
        txtModelprice.Clear()
        txtModelproducer.Clear()

        txtModelname.ReadOnly = False
        txtModelprice.ReadOnly = False
        txtModelproducer.ReadOnly = False
        txtModelcategory.ReadOnly = False

        btnChangemodel.Enabled = False
        btnSavemodel.Enabled = False
        btnNewmodel.Enabled = True
        btnSearchmodel.Enabled = True

        dtgvModel.DataSource = Nothing
        resetCheckedList()
    End Sub

    ''' <summary>
    ''' BUTTON: Nullstiller komponenter relatert til tilleggsutstyr.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnEqipReset_Click(sender As Object, e As EventArgs) Handles btnEqipReset.Click
        txtEqipID.Clear()
        txtEqipType.Clear()
        txtEqipPrice.Clear()
        txtEqipStatus.Clear()

        txtEqipType.ReadOnly = False
        txtEqipPrice.ReadOnly = False
        txtEqipStatus.ReadOnly = False

        btnEqipSearch.Enabled = True
        btnEqipCreate.Enabled = True
        btnEqipReset.Enabled = True
        btnEqipDelete.Enabled = False
        btnEqipChange.Enabled = False
        btnEqipSave.Enabled = False

        dtgvEquip.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' BUTTON: Søker etter tilleggsutstyr.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnEqipSearch_Click(sender As Object, e As EventArgs) Handles btnEqipSearch.Click
        objectupdate()
        dtgvEquip.DataSource = equipment.searchEquipment()
        dtgvEquip.ClearSelection()
    End Sub

    ''' <summary>
    ''' BUTTON: Klargjøring for endring av informasjon om tilleggsutstyr.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnEqipChange_Click(sender As Object, e As EventArgs) Handles btnEqipChange.Click
        txtEqipType.ReadOnly = False
        txtEqipPrice.ReadOnly = False
        txtEqipStatus.ReadOnly = False
        btnEqipSave.Enabled = True
    End Sub

    ''' <summary>
    ''' BUTTON: Lagring av tilleggsutstyr.
    ''' </summary>
    ''' <remarks>Utføres etter endring av informasjon.</remarks>
    Private Sub btnEqipSave_Click(sender As Object, e As EventArgs) Handles btnEqipSave.Click
        objectupdate()
        equipment.editEquipment()
        btnEqipReset_Click(sender, e)
        btnEqipSearch_Click(sender, e)
    End Sub

    ''' <summary>
    ''' BUTTON: Sletter tilleggsutstyr.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnEqipDelete_Click(sender As Object, e As EventArgs) Handles btnEqipDelete.Click
        objectupdate()
        equipment.deleteEquipment()
        btnEqipReset_Click(sender, e)
        btnEqipSearch_Click(sender, e)
    End Sub

    ''' <summary>
    ''' BUTTON: Oppretter tilleggsutstyr og sender melding videre for å skrive det til databasen.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnEqipCreate_Click(sender As Object, e As EventArgs) Handles btnEqipCreate.Click
        objectupdate()
        equipment.createEquipment()
        btnEqipReset_Click(sender, e)
        btnEqipSearch_Click(sender, e)
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Nullstiller checklist av tilleggsutstyr i forbindelse med modell.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub resetCheckedList()
        lstbxEqipment.Enabled = False
        lstbxEqipment.DataSource = Nothing
        lstbxEqipment.DataSource = equipment.getEquipmentGroupByType()
        lstbxEqipment.DisplayMember = "type"
    End Sub

    Private Sub btnmissingbike_Click(sender As Object, e As EventArgs) Handles btnmissingbike.Click

        dtgvmissingbike.DataSource = bike.missingBikes
    End Sub
End Class