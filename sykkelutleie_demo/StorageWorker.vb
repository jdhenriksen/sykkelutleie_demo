Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class StorageWorker

    Dim sqlstring As String
    Dim anySqlQuery As New DBUtility
    Private bike As Bike
    Private editbike As Bike

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles NewBike.Click 'Opprett knapp


        If Framenumber.Text = "" Or Model.SelectedIndex = -1 Or Status.SelectedIndex = -1 Then 'Sjekker at minimumvalg er valgt
            MsgBox("Du må skrive inn et rammenummer,velge modell og status")
        Else
            bike = New Bike(Framenumber.Text, Status.SelectedItem, Locations.Text, Pointofsale.Text, Brakes.Text, Tire.Text, Frame.Text, Gear.Text, Model.SelectedItem)
            bike.createBike()
        End If
        rCombobox() 'renser comboboxer
        clear()     'nullstiller tekstfelt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SearchBike.Click
        bike = New Bike(Framenumber.Text, Status.SelectedItem, Locations.Text, Pointofsale.Text, Brakes.Text, Tire.Text, Frame.Text, Gear.Text, Model.SelectedItem)

        bike.searchBike()  'Søker etter sykkel med parametere i .searchBike() settes resultat inn i DataGridView1
        rCombobox()
        clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        editbike = New Bike(editFramenb.Text, editStatus.SelectedItem, editLocation.Text, editPointofsale.Text, editBrake.Text, editTire.Text,
                                  editFrame.Text, editGear.Text, editModel.SelectedItem)

        editbike.deleteBike() 'Sletter sykkel hvis rett rammenr blir funnet
        rCombobox()
        clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editbike = New Bike(editFramenb.Text, editStatus.SelectedItem, editLocation.Text, editPointofsale.Text, editBrake.Text, editTire.Text, editFrame.Text, editGear.Text, editModel.SelectedItem)

        If editFramenb.Text = "" Then 'Sjekker at felt ikke er tomt
            MsgBox("Du må velge en sykkel fra listen etter søk")
        Else
            editbike.changeBike()   'sender til changebike og endrer verdier hvis rett rammenr blir funnet
        End If

        rCombobox()
        clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim lagnymodell As New Model(oModell.Text, oPrice.Text, oProducer.Text, oCategory.Text)
        lagnymodell.createModel() 'Ny modell blir laget
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim sokmodell As New Model(oModell.Text, oPrice.Text, oProducer.Text, oCategory.Text)
        sokmodell.sokModell() 'søker etter modeller og hvis den blir funnet fylles DataGridView2

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles eLagr.Click
        Dim editmodel As New Model(eModell.Text, ePris.Text, eProd.Text, eCat.Text)
        editmodel.changeModel()  'Sender modell parametere for lagring og renser tekstfelt
        eLagr.Enabled = False    'Fjerner mulighet for lagring og bruker må trykke på rediger
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles eMod.Click
        'Rediger modeller, denne åpner tekstfelt så ting kan endres
        ePris.ReadOnly = False
        eProd.ReadOnly = False
        eCat.ReadOnly = False
        eLagr.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button5.Enabled = True  'Rediger åpner tekstfelt for redigering i sykkel del
        unlock()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button5.Enabled = False
        eLagr.Enabled = False
        OppdaterComboboxer() 'Fyller Modell bokser med modellvalg
    End Sub


    Private Sub DataGridView1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim rowchoice As Integer = DataGridView1.CurrentCellAddress.Y 'Finner Y rad som er valgt
        Dim chosenbikenb As String
        Dim testdata As New DataTable

        chosenbikenb = DataGridView1.Rows(rowchoice).Cells(0).Value.ToString() 'Legger rammenr inn i variabel
        testdata = anySqlQuery.selectQuery("SELECT modell, status, lokasjon, utleiested, dekk, ramme, gir, bremser FROM sykkel WHERE rammenr ='" & chosenbikenb & "'")

        editFramenb.Text = chosenbikenb                     'Alt fra DataTable inn i Tekstbokser
        editModel.Text = testdata.Rows(0)(0).ToString()
        editStatus.Text = testdata.Rows(0)(1).ToString()
        editLocation.Text = testdata.Rows(0)(2).ToString()
        editPointofsale.Text = testdata.Rows(0)(3).ToString()
        editTire.Text = testdata.Rows(0)(4).ToString()
        editFrame.Text = testdata.Rows(0)(5).ToString()
        editGear.Text = testdata.Rows(0)(6).ToString()
        editBrake.Text = testdata.Rows(0)(7).ToString()

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Dim rowchoice As Integer = DataGridView2.CurrentCellAddress.Y 'Finner Y rad
        Dim chosenmodel As String
        Dim datagrid As New DataGridView
        Dim testdata As New DataTable

        datagrid.DefaultCellStyle.NullValue = 0.0
        chosenmodel = DataGridView2.Rows(rowchoice).Cells(0).Value.ToString()

        testdata = anySqlQuery.selectQuery("SELECT modell, pris, produsent, kategori FROM modell WHERE modell ='" & chosenmodel & "'")
        'Sender valgt modell fra GridView og får tilbake resultater som settes inn i Modell sine tekstbokser 
        eModell.Text = chosenmodel
        ePris.Text = testdata.Rows(0)(1).ToString()
        eProd.Text = testdata.Rows(0)(2).ToString()
        eCat.Text = testdata.Rows(0)(3).ToString()

    End Sub


    Private Sub Model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged

        Dim valgtmodell As String = Model.SelectedItem.ToString()  'Hvis alternativ i Combobox blir valgt får vi fylt ut 3 andre tekstbokser
        Dim modellutfylling As DataTable

        modellutfylling = anySqlQuery.selectQuery("SELECT modell, pris, produsent, kategori FROM modell WHERE modell='" & valgtmodell & "'")

        Price.Text = modellutfylling.Rows(0)(1).ToString()
        Producer.Text = modellutfylling.Rows(0)(2).ToString()
        Category.Text = modellutfylling.Rows(0)(3).ToString()


    End Sub

    Private Sub editModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles editModel.SelectedIndexChanged

        Dim valgtmodell As String = editModel.Text          'Hvis alternativ i Combobox blir valgt får vi fylt ut 3 andre tekstbokser
        Dim modellutfylling As DataTable

        modellutfylling = anySqlQuery.selectQuery("SELECT modell, pris, produsent, kategori FROM modell WHERE modell='" & valgtmodell & "'")

        editProducer.Text = modellutfylling.Rows(0)(2).ToString()
        editCategory.Text = modellutfylling.Rows(0)(3).ToString()
        editPrice.Text = modellutfylling.Rows(0)(1).ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Slett.Click

        Dim deletemodel As New Model(eModell.Text, ePris.Text, eProd.Text, eCat.Text)
        deletemodel.deleteModell() 'Sletter modell etter modellnavn

    End Sub

    Public Sub unlock()                     'Samling for å forenkle åpning tekstbokser for redigering
        editFramenb.ReadOnly = True
        editLocation.ReadOnly = False
        editPointofsale.ReadOnly = False
        editTire.ReadOnly = False
        editFrame.ReadOnly = False
        editGear.ReadOnly = False
        editBrake.ReadOnly = False

    End Sub

    Public Sub lock()                       'Samling for å forenkle låsing så det innhold ikke kan endres
        editFramenb.ReadOnly = True
        editLocation.ReadOnly = True
        editPointofsale.ReadOnly = True
        editTire.ReadOnly = True
        editFrame.ReadOnly = True
        editGear.ReadOnly = True
        editBrake.ReadOnly = True

    End Sub

    Public Sub clear()                     'Samling for å rense ut tekstbokser
        editFramenb.Clear()
        editLocation.Clear()
        editPointofsale.Clear()
        editTire.Clear()
        editFrame.Clear()
        editGear.Clear()
        editBrake.Clear()
        Framenumber.Clear()
        Locations.Clear()
        Pointofsale.Clear()
        Tire.Clear()
        Frame.Clear()
        Gear.Clear()
        Brakes.Clear()
        editProducer.Clear()
        editPrice.Clear()
        editCategory.Clear()
        Producer.Clear()
        Price.Clear()
        Category.Clear()

    End Sub

    Public Sub rCombobox() 'Fjerner alt i comboboxes

        Dim modelln As DataTable
        modelln = anySqlQuery.selectQuery("SELECT * FROM modell")
        Dim numberrows As Integer = modelln.Rows.Count()

        For counter As Integer = counter To numberrows - 1
            Model.Items.RemoveAt(0)
            editModel.Items.RemoveAt(0)

        Next
        OppdaterComboboxer() 'Fyller opp comboboxer
        rensstatusCombobox()    ' resetter statusbokser

    End Sub

    Public Sub OppdaterComboboxer()
        Dim modellnavn As DataTable
        modellnavn = anySqlQuery.selectQuery("SELECT * FROM modell") 'Henter modellnavn
        Dim numberrows As Integer = modellnavn.Rows.Count()

        For counter As Integer = counter To numberrows - 1 'Fyller opp Modell combobox med valg
            Model.Items.Add(modellnavn.Rows(counter)(0))
            editModel.Items.Add(modellnavn.Rows(counter)(0))
        Next

    End Sub
    Public Sub rensstatusCombobox() 'Resetting av statusbokser
        Status.Items.RemoveAt(0)
        Status.Items.RemoveAt(0)
        editStatus.Items.RemoveAt(0)
        editStatus.Items.RemoveAt(0)
        Status.Items.Add("På Lager")
        editStatus.Items.Add("På Lager")
        Status.Items.Add("Ikke på lager")
        editStatus.Items.Add("ikke på lager")
    End Sub
End Class
