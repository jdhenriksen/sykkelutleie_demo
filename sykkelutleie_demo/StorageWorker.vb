Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class StorageWorker

    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Dim dialogeResult As Integer
    Public bikemodel As Model
    Public bike As Bike
    Public model As Model

    ''' <summary>
    ''' Opretter ny sykkel benytter seg av bikeobject og modelobject objectet som settes inn i bikeobject
    ''' Etter en sykkel har blitt opprettet kjøres en nullstilling og oppdatering av combobokser
    ''' Alt blir resettet og et nytt generelt søk blir gjort for å vise at sykkelen har blitt lagt til
    ''' </summary> 
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub newBike_Click(sender As Object, e As EventArgs) Handles btnNewbike.Click 'Opprett knapp

        objectupdate()      'Nytt object slik at alle verdier er de nyeste

        If txtFramenumber.Text = "" Or cmbModel.SelectedIndex = -1 Or cmbStatus.SelectedIndex = -1 Then    'Rammenummer, modelltype og status er minimum før oppretting av sykkel.
            MsgBox("Du må skrive inn et rammenummer,velge modell og sette status")                         'Varsel dersom mimimumskrav ikke er oppfylt
        Else
            dialogeResult = MsgBox("Vil du opprette sykkel med rammenr: " & bike.getFrameNumber & "?", MsgBoxStyle.YesNo)
            If dialogeResult = 6 Then                       'Spørsmål om bekreftelse av ny sykkel
                bike.createBike()                           'Hvis svaret på dialogboksen er "Yes" så vil dialogeResult bli "6". Først da kjøres createbike()
                updateComboboxes()                          'Renser og fyller combobokser.
                Nullbike_Click(sender, e)
                searchBike_Click(sender, e)
            Else
                MsgBox("Opprettelse av sykkel ble avbrutt.") 'Hvis "No" blir presset får bruker opp bekreftelse på at ingen sykkel ble opprettet
            End If

        End If

    End Sub

    ''' <summary>
    ''' Søk etter sykkel etter alle de verdier som er skrevet inn
    ''' Oppdaterer object med nyeste verdier
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub searchBike_Click(sender As Object, e As EventArgs) Handles btnSearchbike.Click

        objectupdate()
        'Bruker alle tilgjengelge felter med informasjon til å søke etter samsvarende sykler.
        dtgvBike.DataSource = bike.searchBike()
        updateComboboxes()           'oppdaterer combobokser

    End Sub
    ''' <summary>
    ''' Sletting av sykkel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Sletting av sykkel
    ''' Bruker bikeobjektet
    ''' Eneste som brukes er rammenr som er valgt</remarks>
    Private Sub deleteBike_Click(sender As Object, e As EventArgs) Handles btnDeletebike.Click

        objectupdate()

        dialogeResult = MsgBox("Vil du slette sykkel med rammenummer: " & bike.getFrameNumber() & "?", MsgBoxStyle.YesNo) 'Spør okm bekreftelse angående sletting av sykkel

        If dialogeResult = 6 Then        'Hvis Yes er valgt så vil sykkelen bli slettet, Model klassen returnerer en dialogboks som bekrefter.
            bike.deleteBike()            'Sletter sykkel hvis rett rammenr blir funnet
            updateComboboxes()
            Nullbike_Click(sender, e)
        Else
            MsgBox("Sykkel ble ikke slettet.") 'Tilbakemelding om at ingenting ble slettet da bruker avbrøt.
        End If

    End Sub

    ''' <summary>
    ''' Lagrer ny sykkel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Oppdaterer valgt sykkel med alle feltene
    ''' Det må velges en sykkel før du har muligheten til å oppdatere</remarks>
    Private Sub saveBike_Click(sender As Object, e As EventArgs) Handles btnSavebike.Click

        objectupdate()

        dialogeResult = MsgBox("Vil du oppdatere sykkel med rammenr: " & bike.getFrameNumber & " sin informasjon? ", MsgBoxStyle.YesNo)

        If dialogeResult = 6 Then
            If bike.getFrameNumber() = "" Then                      'Dette feltet er låst og blir kun fylt hvis en sykkel blir valgt fra datagridview
                MsgBox("Du må velge en sykkel fra listen etter søk") 'Hvis det er ingenting der så betyr det at bruker ikke har valgt noe fra søk.
            Else
                bike.changeBike()
                updateComboboxes()
                Nullbike_Click(sender, e)
                searchBike_Click(sender, e)

            End If
        Else
            MsgBox("Oppdatering av sykkel informasjon ble avbrutt.") 'Bekreftelse hvis bruker avbryter
        End If

    End Sub

    ''' <summary>
    ''' Endre Sykkel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Endrer knapper og tekstfelt for at brukeren kan skrive inn endringer</remarks>
    Private Sub changeBike_Click(sender As Object, e As EventArgs) Handles btnChangebike.Click

        btnSavebike.Enabled = True  'Rediger åpner tekstfelt for redigering i sykkel del
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
    ''' Opprette en ny modell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Minimum er at at modellnavn er fyllt inn
    ''' oppdaterer comboboxer på bike delen siden det er ny modell som må legges til
    ''' Resetter modellfelt og knapper
    ''' Helt til slutt tar den et søk så bruker ser at en ny modell er lagt til</remarks>
    Private Sub newModel_Click(sender As Object, e As EventArgs) Handles btnNewmodel.Click

        objectupdate()
        If txtModelname.Text = "" Then
            MsgBox("Du må skrive inn et modellnavn")
        Else
            dialogeResult = MsgBox("Vil opprette modell med navn: " & model.getModel() & "?", MsgBoxStyle.YesNo)
            If dialogeResult = 6 Then
                model.createModel()
                updateComboboxes()
                Nullmodel_Click(sender, e)
                searchModel_Click(sender, e)
            Else
                MsgBox("Oppretting av modell ble avbrutt.")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Søke etter modell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Søker etter modeller og hvis den blir funnet fylles modell sin DataGridView</remarks>
    Private Sub searchModel_Click(sender As Object, e As EventArgs) Handles btnSearchmodel.Click

        objectupdate()

        dtgvModel.DataSource = model.sokModell()

    End Sub

    ''' <summary>
    ''' Lagre (oppdatere) modell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Mulighet for å endre alt utenom navnet
    ''' Nullstiller modellfelt og søker for å vise at søket er gjort</remarks>
    Private Sub saveModel_Click(sender As Object, e As EventArgs) Handles btnSavemodel.Click

        objectupdate()

        dialogeResult = MsgBox("Vil du endre modell med navn: " & model.getModel() & "?", MsgBoxStyle.YesNo)

        If dialogeResult = 6 Then
            model.changeModel()
            Nullmodel_Click(sender, e)
            searchModel_Click(sender, e)
        Else
            MsgBox("Endringer ble ikke lagret.") 'Tilbakemedling hvis bruker avbryter
        End If
    End Sub

    ''' <summary>
    ''' Slett Modell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>sletter modell etter modellnavn
    ''' oppdaterer combobokser siden en modell er slettet og det er en færre
    ''' resetter modellfelt og knapper</remarks>
    Private Sub deleteModel_Click(sender As Object, e As EventArgs) Handles btnDeletemodel.Click

        objectupdate()

        dialogeResult = MsgBox("Vil du slette  modell med navn: " & model.getModel & " ?", MsgBoxStyle.YesNo)

        If dialogeResult = 6 Then
            model.deleteModell() 'Sletter modell etter modellnavn
            updateComboboxes()
            Nullmodel_Click(sender, e)
        Else
            MsgBox("Sletting ble avbrutt.") 'Tilbakemelding hvis bruker avbryter
        End If

    End Sub
    ''' <summary>
    ''' Endre Modell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Kun kosmetiske forandringer der knapper blir enabled, disabled ogtekstfelt blir åpnet slik at brukeren kan skrive inn for lagring</remarks>
    Private Sub changeModel_Click(sender As Object, e As EventArgs) Handles btnChangemodel.Click

        txtModelcategory.ReadOnly = False  'Rediger modeller, denne åpner tekstfelt så ting kan endres på modell
        txtModelprice.ReadOnly = False
        txtModelproducer.ReadOnly = False
        btnSavemodel.Enabled = True
        btnChangemodel.Enabled = False

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateComboboxes() 'Fyller Modell bokser med modellvalg

    End Sub

    ''' <summary>
    ''' Boks for treff fra søk og velging av Sykler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Kan kun velge en hel rad og uansett hvilken celle man trykker på så vil vi bry oss kun om Y rad
    ''' Når rad er valgt tas Kolonne 0 og rad y som er rammenummeret
    ''' Rammenummeret blir da brukt for å finne resten av data som er tilhørende og fyller det inn i tekstfelt
    ''' Samtidig blir tekstfelt låst slik at bruker forstår at sykkelen er valgt. Knapper blir også forandret.</remarks>
    Private Sub gridViewBike(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvBike.CellClick
        Dim rowchoice As Integer = dtgvBike.CurrentCellAddress.Y 'Finner Y rad som er valgt i datagridview 
        Dim chosenbikenb As String
        Dim testdata As New DataTable

        chosenbikenb = dtgvBike.Rows(rowchoice).Cells(0).Value.ToString() 'Legger rammenr inn i variabel
        testdata = anySqlQuery.selectQuery("SELECT modell, status, lokasjon, utleiested, dekk, ramme, gir, bremser FROM sykkel WHERE rammenr ='" & chosenbikenb & "'")

        txtFramenumber.Text = chosenbikenb                     'Alt fra DataTable inn i Tekstbokser på edit siden
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
    ''' Boks for fylling av modelldata
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Når det trykkes på en celle blir kollonne 0 og rad Y innholdet (modellnavnet) sendt for å hente mer data for å fylle inn i tekstfelt 
    ''' Tekstfelt blir låst og knapper endret</remarks>
    Private Sub gridViewModel(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvModel.CellClick

        Dim rowchoice As Integer = dtgvModel.CurrentCellAddress.Y 'Finner Y rad some r valgt i datagridview på modelldelen
        Dim chosenmodel As String
        Dim datagrid As New DataGridView
        Dim datafill As New DataTable

        datagrid.DefaultCellStyle.NullValue = 0.0
        chosenmodel = dtgvModel.Rows(rowchoice).Cells(0).Value.ToString()

        'Sender valgt modell fra GridView og får tilbake resultater som settes inn i Modell sine tekstbokser 
        datafill = anySqlQuery.selectQuery("SELECT modell, pris, produsent, kategori FROM modell WHERE modell ='" & chosenmodel & "'")

        txtModelname.Text = chosenmodel
        txtModelprice.Text = datafill.Rows(0)(1).ToString()
        txtModelproducer.Text = datafill.Rows(0)(2).ToString()
        txtModelcategory.Text = datafill.Rows(0)(3).ToString()

        btnDeletemodel.Enabled = True
        btnChangemodel.Enabled = True
        btnSearchmodel.Enabled = False
        btnNewmodel.Enabled = False
        btnSavemodel.Enabled = False

        txtModelname.ReadOnly = True
        txtModelprice.ReadOnly = True
        txtModelproducer.ReadOnly = True
        txtModelcategory.ReadOnly = True

    End Sub

    ''' <summary>
    ''' Combobox_forandring
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Når en annen modell blir valgt finner vi informasjon for å fylle i modelldelen av bike</remarks>
    Private Sub indexChangedModel(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged

        Dim chosenmodel As String = cmbModel.SelectedItem.ToString()  'Hvis alternativ i Combobox blir valgt får vi fylt ut 3 andre tekstbokser
        Dim modelfilled As DataTable

        modelfilled = anySqlQuery.selectQuery("SELECT modell, pris, produsent, kategori FROM modell WHERE modell='" & chosenmodel & "'")

        txtPrice.Text = modelfilled.Rows(0)(1).ToString()
        txtProducer.Text = modelfilled.Rows(0)(2).ToString()
        txtCategory.Text = modelfilled.Rows(0)(3).ToString()

    End Sub

    ''' <summary>
    ''' Oppdaterer combobokser
    ''' </summary>
    ''' <remarks>Av og til skjer endringer som gjør at vi må oppdatere valgene inne i comboboksene så innholdet reflekterer endringene</remarks>
    Public Sub updateComboboxes() 'Oppdaterer combobokser slik at de nyeste valg er tilgjengelig 
        Dim combomodelnames As DataTable

        cmbModel.Items.Clear()
        combomodelnames = anySqlQuery.selectQuery("SELECT * FROM modell") 'Henter modellnavn

        Dim numberrows As Integer = combomodelnames.Rows.Count()
        For counter As Integer = counter To numberrows - 1 'Fyller opp Modell combobox med valg basert på hvor mange modeller er databasen.
            cmbModel.Items.Add(combomodelnames.Rows(counter)(0)) 'Kjøres ofte etter endringer sletting for å gi brukeren de nyeste valgene
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

    End Sub

    ''' <summary>
    ''' Oppdatering av objecter
    ''' </summary>
    ''' <remarks>Oppdatering av objecter så vi har de nyeste verdier å arbeide med</remarks>
    Public Sub objectupdate() 'Brukes for å hente nye verdier og skape nye instanser av disse objektene
        model = New Model(txtModelname.Text, txtModelprice.Text, txtModelproducer.Text, txtModelcategory.Text) 'Objekt for modelldel for søk,opprett,slett,endre,lagre
        bikemodel = New Model(cmbModel.SelectedItem, txtPrice.Text, txtProducer.Text, txtCategory.Text) 'modellObject som sendes med bike objectet
        bike = New Bike(txtFramenumber.Text, cmbStatus.SelectedItem, txtLocation.Text, txtPointofsale.Text, txtBrakes.Text, txtTire.Text, txtFrame.Text, txtGear.Text, bikemodel) 'bikeobjekt
    End Sub

    ''' <summary>
    ''' Bike Nullstiller
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Fjerner alt fra tekstfelter, datagridview og nullstiller knapper</remarks>
    Private Sub Nullbike_Click(sender As Object, e As EventArgs) Handles btnNullbike.Click  'Fjerner alt fra Bike delen og nullstiller knapper

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
    End Sub

    ''' <summary>
    ''' Nullstiller modell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Fjerner alt fra tekstfelter og nullstiller knappene </remarks>
    Private Sub Nullmodel_Click(sender As Object, e As EventArgs) Handles btnNullmodel.Click 'Fjerner alt fra Modellboksen og nullstiller knapper

        txtModelcategory.Clear()
        txtModelname.Clear()
        txtModelprice.Clear()
        txtModelproducer.Clear()

        txtModelname.ReadOnly = False
        txtModelprice.ReadOnly = False
        txtModelproducer.ReadOnly = False
        txtModelcategory.ReadOnly = False
        btnDeletemodel.Enabled = False
        btnChangemodel.Enabled = False
        btnSavemodel.Enabled = False
        btnNewmodel.Enabled = True
        btnSearchmodel.Enabled = True

        dtgvModel.DataSource = Nothing

    End Sub

    Private Sub txtFramenumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtFramenumber.MaskInputRejected
    End Sub
End Class
