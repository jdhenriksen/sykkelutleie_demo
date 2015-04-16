<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOrderSearchBike = New System.Windows.Forms.Button()
        Me.lblOrderChooseEqip = New System.Windows.Forms.Label()
        Me.lblOrderOverView = New System.Windows.Forms.Label()
        Me.lstbxEquipment = New System.Windows.Forms.CheckedListBox()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnAddToOrder = New System.Windows.Forms.Button()
        Me.btnBackKunde = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.TabOrder = New System.Windows.Forms.TabPage()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.CmbBoxDiscount = New System.Windows.Forms.ComboBox()
        Me.grpBxSelectPeriod = New System.Windows.Forms.GroupBox()
        Me.labelTilSelect = New System.Windows.Forms.Label()
        Me.CalendarTo = New System.Windows.Forms.MonthCalendar()
        Me.labelFraSelect = New System.Windows.Forms.Label()
        Me.CalendarFrom = New System.Windows.Forms.MonthCalendar()
        Me.btnBackSykkel = New System.Windows.Forms.Button()
        Me.btnNextSammendrag = New System.Windows.Forms.Button()
        Me.ListBoxOrderOverview = New System.Windows.Forms.ListBox()
        Me.TabSummary = New System.Windows.Forms.TabPage()
        Me.btnBackBestilling = New System.Windows.Forms.Button()
        Me.btnRegisterOrder = New System.Windows.Forms.Button()
        Me.ListBoxReceipt = New System.Windows.Forms.ListBox()
        Me.btnNextBestilling = New System.Windows.Forms.Button()
        Me.lblLastnameOrder = New System.Windows.Forms.Label()
        Me.txtBxSirName = New System.Windows.Forms.TextBox()
        Me.TabCustomer = New System.Windows.Forms.TabPage()
        Me.btnChangeCustomer = New System.Windows.Forms.Button()
        Me.btnCreateNewCustomer = New System.Windows.Forms.Button()
        Me.btnNextToSykkel = New System.Windows.Forms.Button()
        Me.DataGridViewKunde = New System.Windows.Forms.DataGridView()
        Me.lblKidOrdre = New System.Windows.Forms.Label()
        Me.txtBxKID = New System.Windows.Forms.TextBox()
        Me.lblemailOrder = New System.Windows.Forms.Label()
        Me.txtBxEmail = New System.Windows.Forms.TextBox()
        Me.lblTlfOrder = New System.Windows.Forms.Label()
        Me.txtBxPhone = New System.Windows.Forms.TextBox()
        Me.lblFirstnameOrder = New System.Windows.Forms.Label()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.dgvBicycle = New System.Windows.Forms.DataGridView()
        Me.lblFramenbOrder = New System.Windows.Forms.Label()
        Me.txtBxRammenr = New System.Windows.Forms.TextBox()
        Me.lblBrandOrder = New System.Windows.Forms.Label()
        Me.txtBxMerke = New System.Windows.Forms.TextBox()
        Me.lblPriceOrder = New System.Windows.Forms.Label()
        Me.txtBxPris = New System.Windows.Forms.TextBox()
        Me.lblModelOrder = New System.Windows.Forms.Label()
        Me.txtBxModell = New System.Windows.Forms.TextBox()
        Me.lblCategoryOrder = New System.Windows.Forms.Label()
        Me.txtBxKategori = New System.Windows.Forms.TextBox()
        Me.tabBike = New System.Windows.Forms.TabPage()
        Me.Bestilling = New System.Windows.Forms.TabControl()
        Me.TabOrder.SuspendLayout
        Me.grpBxSelectPeriod.SuspendLayout
        Me.TabSummary.SuspendLayout
        Me.TabCustomer.SuspendLayout
        CType(Me.DataGridViewKunde,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvBicycle,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBike.SuspendLayout
        Me.Bestilling.SuspendLayout
        Me.SuspendLayout
        '
        'btnOrderSearchBike
        '
        Me.btnOrderSearchBike.Location = New System.Drawing.Point(14, 441)
        Me.btnOrderSearchBike.Name = "btnOrderSearchBike"
        Me.btnOrderSearchBike.Size = New System.Drawing.Size(175, 45)
        Me.btnOrderSearchBike.TabIndex = 172
        Me.btnOrderSearchBike.Text = "Søk"
        Me.btnOrderSearchBike.UseVisualStyleBackColor = true
        '
        'lblOrderChooseEqip
        '
        Me.lblOrderChooseEqip.AutoSize = true
        Me.lblOrderChooseEqip.Location = New System.Drawing.Point(876, 16)
        Me.lblOrderChooseEqip.Name = "lblOrderChooseEqip"
        Me.lblOrderChooseEqip.Size = New System.Drawing.Size(77, 17)
        Me.lblOrderChooseEqip.TabIndex = 171
        Me.lblOrderChooseEqip.Text = "Velg Utstyr"
        '
        'lblOrderOverView
        '
        Me.lblOrderOverView.AutoSize = true
        Me.lblOrderOverView.Location = New System.Drawing.Point(1003, 16)
        Me.lblOrderOverView.Name = "lblOrderOverView"
        Me.lblOrderOverView.Size = New System.Drawing.Size(94, 17)
        Me.lblOrderOverView.TabIndex = 170
        Me.lblOrderOverView.Text = "Ordreoversikt"
        '
        'lstbxEquipment
        '
        Me.lstbxEquipment.FormattingEnabled = true
        Me.lstbxEquipment.Location = New System.Drawing.Point(879, 40)
        Me.lstbxEquipment.Name = "lstbxEquipment"
        Me.lstbxEquipment.Size = New System.Drawing.Size(120, 378)
        Me.lstbxEquipment.TabIndex = 3
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(196, 441)
        Me.btnNewOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(175, 45)
        Me.btnNewOrder.TabIndex = 4
        Me.btnNewOrder.Text = "Reset Bestilling"
        Me.btnNewOrder.UseVisualStyleBackColor = true
        '
        'btnAddToOrder
        '
        Me.btnAddToOrder.Location = New System.Drawing.Point(698, 441)
        Me.btnAddToOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddToOrder.Name = "btnAddToOrder"
        Me.btnAddToOrder.Size = New System.Drawing.Size(175, 45)
        Me.btnAddToOrder.TabIndex = 168
        Me.btnAddToOrder.Text = "Legg sykkel med valgt utstyr til bestillingen"
        Me.btnAddToOrder.UseVisualStyleBackColor = true
        '
        'btnBackKunde
        '
        Me.btnBackKunde.Location = New System.Drawing.Point(879, 441)
        Me.btnBackKunde.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackKunde.Name = "btnBackKunde"
        Me.btnBackKunde.Size = New System.Drawing.Size(175, 45)
        Me.btnBackKunde.TabIndex = 167
        Me.btnBackKunde.Text = "<-- Tilbake"
        Me.btnBackKunde.UseVisualStyleBackColor = true
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(694, 441)
        Me.btnPrintReceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(175, 45)
        Me.btnPrintReceipt.TabIndex = 2
        Me.btnPrintReceipt.Text = "Vis Kvittering"
        Me.btnPrintReceipt.UseVisualStyleBackColor = true
        '
        'TabOrder
        '
        Me.TabOrder.BackColor = System.Drawing.Color.Transparent
        Me.TabOrder.Controls.Add(Me.lblDiscount)
        Me.TabOrder.Controls.Add(Me.CmbBoxDiscount)
        Me.TabOrder.Controls.Add(Me.grpBxSelectPeriod)
        Me.TabOrder.Controls.Add(Me.btnBackSykkel)
        Me.TabOrder.Controls.Add(Me.btnNextSammendrag)
        Me.TabOrder.Location = New System.Drawing.Point(4, 25)
        Me.TabOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.TabOrder.Name = "TabOrder"
        Me.TabOrder.Padding = New System.Windows.Forms.Padding(4)
        Me.TabOrder.Size = New System.Drawing.Size(1276, 494)
        Me.TabOrder.TabIndex = 2
        Me.TabOrder.Text = "Bestilling"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = true
        Me.lblDiscount.Location = New System.Drawing.Point(731, 207)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(50, 17)
        Me.lblDiscount.TabIndex = 173
        Me.lblDiscount.Text = "Rabatt"
        '
        'CmbBoxDiscount
        '
        Me.CmbBoxDiscount.FormattingEnabled = true
        Me.CmbBoxDiscount.Items.AddRange(New Object() {"Ingen", "10%", "20%", "Ansatt", "Skoleklasse", "Gruppe 10+", "Kampanje 50%"})
        Me.CmbBoxDiscount.Location = New System.Drawing.Point(791, 204)
        Me.CmbBoxDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBoxDiscount.Name = "CmbBoxDiscount"
        Me.CmbBoxDiscount.Size = New System.Drawing.Size(160, 24)
        Me.CmbBoxDiscount.TabIndex = 172
        Me.CmbBoxDiscount.Text = "Ingen"
        '
        'grpBxSelectPeriod
        '
        Me.grpBxSelectPeriod.Controls.Add(Me.labelTilSelect)
        Me.grpBxSelectPeriod.Controls.Add(Me.CalendarTo)
        Me.grpBxSelectPeriod.Controls.Add(Me.labelFraSelect)
        Me.grpBxSelectPeriod.Controls.Add(Me.CalendarFrom)
        Me.grpBxSelectPeriod.Location = New System.Drawing.Point(62, 87)
        Me.grpBxSelectPeriod.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBxSelectPeriod.Name = "grpBxSelectPeriod"
        Me.grpBxSelectPeriod.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxSelectPeriod.Size = New System.Drawing.Size(631, 272)
        Me.grpBxSelectPeriod.TabIndex = 171
        Me.grpBxSelectPeriod.TabStop = false
        Me.grpBxSelectPeriod.Text = "Velg periode"
        '
        'labelTilSelect
        '
        Me.labelTilSelect.AutoSize = true
        Me.labelTilSelect.Location = New System.Drawing.Point(341, 25)
        Me.labelTilSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTilSelect.Name = "labelTilSelect"
        Me.labelTilSelect.Size = New System.Drawing.Size(23, 17)
        Me.labelTilSelect.TabIndex = 10
        Me.labelTilSelect.Text = "Til"
        '
        'CalendarTo
        '
        Me.CalendarTo.Location = New System.Drawing.Point(341, 52)
        Me.CalendarTo.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CalendarTo.Name = "CalendarTo"
        Me.CalendarTo.TabIndex = 9
        '
        'labelFraSelect
        '
        Me.labelFraSelect.AutoSize = true
        Me.labelFraSelect.Location = New System.Drawing.Point(28, 25)
        Me.labelFraSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFraSelect.Name = "labelFraSelect"
        Me.labelFraSelect.Size = New System.Drawing.Size(29, 17)
        Me.labelFraSelect.TabIndex = 8
        Me.labelFraSelect.Text = "Fra"
        '
        'CalendarFrom
        '
        Me.CalendarFrom.Location = New System.Drawing.Point(32, 52)
        Me.CalendarFrom.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CalendarFrom.Name = "CalendarFrom"
        Me.CalendarFrom.TabIndex = 7
        '
        'btnBackSykkel
        '
        Me.btnBackSykkel.Location = New System.Drawing.Point(877, 441)
        Me.btnBackSykkel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackSykkel.Name = "btnBackSykkel"
        Me.btnBackSykkel.Size = New System.Drawing.Size(175, 45)
        Me.btnBackSykkel.TabIndex = 170
        Me.btnBackSykkel.Text = "<-- Tilbake"
        Me.btnBackSykkel.UseVisualStyleBackColor = true
        '
        'btnNextSammendrag
        '
        Me.btnNextSammendrag.Location = New System.Drawing.Point(1060, 441)
        Me.btnNextSammendrag.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextSammendrag.Name = "btnNextSammendrag"
        Me.btnNextSammendrag.Size = New System.Drawing.Size(175, 45)
        Me.btnNextSammendrag.TabIndex = 169
        Me.btnNextSammendrag.Text = "Neste -->"
        Me.btnNextSammendrag.UseVisualStyleBackColor = true
        '
        'ListBoxOrderOverview
        '
        Me.ListBoxOrderOverview.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxOrderOverview.FormattingEnabled = true
        Me.ListBoxOrderOverview.ItemHeight = 16
        Me.ListBoxOrderOverview.Location = New System.Drawing.Point(1006, 37)
        Me.ListBoxOrderOverview.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxOrderOverview.Name = "ListBoxOrderOverview"
        Me.ListBoxOrderOverview.Size = New System.Drawing.Size(229, 388)
        Me.ListBoxOrderOverview.TabIndex = 3
        '
        'TabSummary
        '
        Me.TabSummary.BackColor = System.Drawing.Color.Transparent
        Me.TabSummary.Controls.Add(Me.btnBackBestilling)
        Me.TabSummary.Controls.Add(Me.btnRegisterOrder)
        Me.TabSummary.Controls.Add(Me.btnPrintReceipt)
        Me.TabSummary.Controls.Add(Me.ListBoxReceipt)
        Me.TabSummary.Location = New System.Drawing.Point(4, 25)
        Me.TabSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.TabSummary.Name = "TabSummary"
        Me.TabSummary.Padding = New System.Windows.Forms.Padding(4)
        Me.TabSummary.Size = New System.Drawing.Size(1276, 494)
        Me.TabSummary.TabIndex = 3
        Me.TabSummary.Text = "Sammendrag"
        '
        'btnBackBestilling
        '
        Me.btnBackBestilling.Location = New System.Drawing.Point(877, 441)
        Me.btnBackBestilling.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackBestilling.Name = "btnBackBestilling"
        Me.btnBackBestilling.Size = New System.Drawing.Size(175, 45)
        Me.btnBackBestilling.TabIndex = 171
        Me.btnBackBestilling.Text = "<-- Tilbake"
        Me.btnBackBestilling.UseVisualStyleBackColor = true
        '
        'btnRegisterOrder
        '
        Me.btnRegisterOrder.Location = New System.Drawing.Point(1060, 441)
        Me.btnRegisterOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegisterOrder.Name = "btnRegisterOrder"
        Me.btnRegisterOrder.Size = New System.Drawing.Size(175, 45)
        Me.btnRegisterOrder.TabIndex = 3
        Me.btnRegisterOrder.Text = "Registrer bestilling"
        Me.btnRegisterOrder.UseVisualStyleBackColor = true
        '
        'ListBoxReceipt
        '
        Me.ListBoxReceipt.FormattingEnabled = true
        Me.ListBoxReceipt.ItemHeight = 16
        Me.ListBoxReceipt.Location = New System.Drawing.Point(73, 30)
        Me.ListBoxReceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxReceipt.Name = "ListBoxReceipt"
        Me.ListBoxReceipt.Size = New System.Drawing.Size(1162, 388)
        Me.ListBoxReceipt.TabIndex = 1
        '
        'btnNextBestilling
        '
        Me.btnNextBestilling.Location = New System.Drawing.Point(1060, 441)
        Me.btnNextBestilling.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextBestilling.Name = "btnNextBestilling"
        Me.btnNextBestilling.Size = New System.Drawing.Size(175, 45)
        Me.btnNextBestilling.TabIndex = 166
        Me.btnNextBestilling.Text = "Neste -->"
        Me.btnNextBestilling.UseVisualStyleBackColor = true
        '
        'lblLastnameOrder
        '
        Me.lblLastnameOrder.AutoSize = true
        Me.lblLastnameOrder.Location = New System.Drawing.Point(15, 137)
        Me.lblLastnameOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastnameOrder.Name = "lblLastnameOrder"
        Me.lblLastnameOrder.Size = New System.Drawing.Size(69, 17)
        Me.lblLastnameOrder.TabIndex = 3
        Me.lblLastnameOrder.Text = "Etternavn"
        '
        'txtBxSirName
        '
        Me.txtBxSirName.Location = New System.Drawing.Point(84, 133)
        Me.txtBxSirName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxSirName.Name = "txtBxSirName"
        Me.txtBxSirName.Size = New System.Drawing.Size(213, 22)
        Me.txtBxSirName.TabIndex = 2
        '
        'TabCustomer
        '
        Me.TabCustomer.BackColor = System.Drawing.Color.Transparent
        Me.TabCustomer.Controls.Add(Me.btnChangeCustomer)
        Me.TabCustomer.Controls.Add(Me.btnCreateNewCustomer)
        Me.TabCustomer.Controls.Add(Me.btnNextToSykkel)
        Me.TabCustomer.Controls.Add(Me.DataGridViewKunde)
        Me.TabCustomer.Controls.Add(Me.lblKidOrdre)
        Me.TabCustomer.Controls.Add(Me.txtBxKID)
        Me.TabCustomer.Controls.Add(Me.lblemailOrder)
        Me.TabCustomer.Controls.Add(Me.txtBxEmail)
        Me.TabCustomer.Controls.Add(Me.lblTlfOrder)
        Me.TabCustomer.Controls.Add(Me.txtBxPhone)
        Me.TabCustomer.Controls.Add(Me.lblLastnameOrder)
        Me.TabCustomer.Controls.Add(Me.txtBxSirName)
        Me.TabCustomer.Controls.Add(Me.lblFirstnameOrder)
        Me.TabCustomer.Controls.Add(Me.txtBxFirstName)
        Me.TabCustomer.Location = New System.Drawing.Point(4, 25)
        Me.TabCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.TabCustomer.Name = "TabCustomer"
        Me.TabCustomer.Padding = New System.Windows.Forms.Padding(4)
        Me.TabCustomer.Size = New System.Drawing.Size(1276, 494)
        Me.TabCustomer.TabIndex = 0
        Me.TabCustomer.Text = "Kunde"
        '
        'btnChangeCustomer
        '
        Me.btnChangeCustomer.Location = New System.Drawing.Point(694, 441)
        Me.btnChangeCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeCustomer.Name = "btnChangeCustomer"
        Me.btnChangeCustomer.Size = New System.Drawing.Size(175, 45)
        Me.btnChangeCustomer.TabIndex = 155
        Me.btnChangeCustomer.Text = "Endre kunde"
        Me.btnChangeCustomer.UseVisualStyleBackColor = true
        '
        'btnCreateNewCustomer
        '
        Me.btnCreateNewCustomer.Location = New System.Drawing.Point(877, 441)
        Me.btnCreateNewCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateNewCustomer.Name = "btnCreateNewCustomer"
        Me.btnCreateNewCustomer.Size = New System.Drawing.Size(175, 45)
        Me.btnCreateNewCustomer.TabIndex = 154
        Me.btnCreateNewCustomer.Text = "Opprett ny kunde"
        Me.btnCreateNewCustomer.UseVisualStyleBackColor = true
        '
        'btnNextToSykkel
        '
        Me.btnNextToSykkel.Location = New System.Drawing.Point(1060, 441)
        Me.btnNextToSykkel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextToSykkel.Name = "btnNextToSykkel"
        Me.btnNextToSykkel.Size = New System.Drawing.Size(175, 45)
        Me.btnNextToSykkel.TabIndex = 153
        Me.btnNextToSykkel.Text = "Neste -->"
        Me.btnNextToSykkel.UseVisualStyleBackColor = true
        '
        'DataGridViewKunde
        '
        Me.DataGridViewKunde.AllowUserToAddRows = false
        Me.DataGridViewKunde.AllowUserToDeleteRows = false
        Me.DataGridViewKunde.AllowUserToResizeColumns = false
        Me.DataGridViewKunde.AllowUserToResizeRows = false
        Me.DataGridViewKunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewKunde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewKunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKunde.Location = New System.Drawing.Point(320, 22)
        Me.DataGridViewKunde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewKunde.MultiSelect = false
        Me.DataGridViewKunde.Name = "DataGridViewKunde"
        Me.DataGridViewKunde.ReadOnly = true
        Me.DataGridViewKunde.RowHeadersVisible = false
        Me.DataGridViewKunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewKunde.RowTemplate.Height = 24
        Me.DataGridViewKunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewKunde.Size = New System.Drawing.Size(915, 400)
        Me.DataGridViewKunde.TabIndex = 151
        '
        'lblKidOrdre
        '
        Me.lblKidOrdre.AutoSize = true
        Me.lblKidOrdre.Location = New System.Drawing.Point(15, 372)
        Me.lblKidOrdre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKidOrdre.Name = "lblKidOrdre"
        Me.lblKidOrdre.Size = New System.Drawing.Size(28, 17)
        Me.lblKidOrdre.TabIndex = 9
        Me.lblKidOrdre.Text = "Kid"
        '
        'txtBxKID
        '
        Me.txtBxKID.Location = New System.Drawing.Point(84, 372)
        Me.txtBxKID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxKID.Name = "txtBxKID"
        Me.txtBxKID.ReadOnly = true
        Me.txtBxKID.Size = New System.Drawing.Size(213, 22)
        Me.txtBxKID.TabIndex = 8
        '
        'lblemailOrder
        '
        Me.lblemailOrder.AutoSize = true
        Me.lblemailOrder.Location = New System.Drawing.Point(15, 215)
        Me.lblemailOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemailOrder.Name = "lblemailOrder"
        Me.lblemailOrder.Size = New System.Drawing.Size(49, 17)
        Me.lblemailOrder.TabIndex = 7
        Me.lblemailOrder.Text = "E-post"
        '
        'txtBxEmail
        '
        Me.txtBxEmail.Location = New System.Drawing.Point(84, 214)
        Me.txtBxEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxEmail.Name = "txtBxEmail"
        Me.txtBxEmail.Size = New System.Drawing.Size(213, 22)
        Me.txtBxEmail.TabIndex = 6
        '
        'lblTlfOrder
        '
        Me.lblTlfOrder.AutoSize = true
        Me.lblTlfOrder.Location = New System.Drawing.Point(15, 293)
        Me.lblTlfOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTlfOrder.Name = "lblTlfOrder"
        Me.lblTlfOrder.Size = New System.Drawing.Size(56, 17)
        Me.lblTlfOrder.TabIndex = 5
        Me.lblTlfOrder.Text = "Telefon"
        '
        'txtBxPhone
        '
        Me.txtBxPhone.Location = New System.Drawing.Point(84, 293)
        Me.txtBxPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxPhone.Name = "txtBxPhone"
        Me.txtBxPhone.ReadOnly = true
        Me.txtBxPhone.Size = New System.Drawing.Size(213, 22)
        Me.txtBxPhone.TabIndex = 4
        '
        'lblFirstnameOrder
        '
        Me.lblFirstnameOrder.AutoSize = true
        Me.lblFirstnameOrder.Location = New System.Drawing.Point(15, 59)
        Me.lblFirstnameOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstnameOrder.Name = "lblFirstnameOrder"
        Me.lblFirstnameOrder.Size = New System.Drawing.Size(60, 17)
        Me.lblFirstnameOrder.TabIndex = 1
        Me.lblFirstnameOrder.Text = "Fornavn"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.Location = New System.Drawing.Point(84, 56)
        Me.txtBxFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(213, 22)
        Me.txtBxFirstName.TabIndex = 0
        '
        'dgvBicycle
        '
        Me.dgvBicycle.AllowUserToAddRows = false
        Me.dgvBicycle.AllowUserToDeleteRows = false
        Me.dgvBicycle.AllowUserToResizeColumns = false
        Me.dgvBicycle.AllowUserToResizeRows = false
        Me.dgvBicycle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBicycle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBicycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBicycle.Location = New System.Drawing.Point(320, 22)
        Me.dgvBicycle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvBicycle.MultiSelect = false
        Me.dgvBicycle.Name = "dgvBicycle"
        Me.dgvBicycle.ReadOnly = true
        Me.dgvBicycle.RowHeadersVisible = false
        Me.dgvBicycle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvBicycle.RowTemplate.Height = 24
        Me.dgvBicycle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBicycle.Size = New System.Drawing.Size(553, 400)
        Me.dgvBicycle.TabIndex = 164
        '
        'lblFramenbOrder
        '
        Me.lblFramenbOrder.AutoSize = true
        Me.lblFramenbOrder.Location = New System.Drawing.Point(20, 376)
        Me.lblFramenbOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFramenbOrder.Name = "lblFramenbOrder"
        Me.lblFramenbOrder.Size = New System.Drawing.Size(73, 17)
        Me.lblFramenbOrder.TabIndex = 163
        Me.lblFramenbOrder.Text = "Rammenr."
        '
        'txtBxRammenr
        '
        Me.txtBxRammenr.Location = New System.Drawing.Point(89, 373)
        Me.txtBxRammenr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxRammenr.Name = "txtBxRammenr"
        Me.txtBxRammenr.Size = New System.Drawing.Size(213, 22)
        Me.txtBxRammenr.TabIndex = 162
        '
        'lblBrandOrder
        '
        Me.lblBrandOrder.AutoSize = true
        Me.lblBrandOrder.Location = New System.Drawing.Point(20, 297)
        Me.lblBrandOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrandOrder.Name = "lblBrandOrder"
        Me.lblBrandOrder.Size = New System.Drawing.Size(47, 17)
        Me.lblBrandOrder.TabIndex = 161
        Me.lblBrandOrder.Text = "Merke"
        '
        'txtBxMerke
        '
        Me.txtBxMerke.Location = New System.Drawing.Point(89, 294)
        Me.txtBxMerke.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxMerke.Name = "txtBxMerke"
        Me.txtBxMerke.Size = New System.Drawing.Size(213, 22)
        Me.txtBxMerke.TabIndex = 160
        '
        'lblPriceOrder
        '
        Me.lblPriceOrder.AutoSize = true
        Me.lblPriceOrder.Location = New System.Drawing.Point(20, 218)
        Me.lblPriceOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceOrder.Name = "lblPriceOrder"
        Me.lblPriceOrder.Size = New System.Drawing.Size(32, 17)
        Me.lblPriceOrder.TabIndex = 159
        Me.lblPriceOrder.Text = "Pris"
        '
        'txtBxPris
        '
        Me.txtBxPris.Location = New System.Drawing.Point(89, 215)
        Me.txtBxPris.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxPris.Name = "txtBxPris"
        Me.txtBxPris.Size = New System.Drawing.Size(213, 22)
        Me.txtBxPris.TabIndex = 158
        '
        'lblModelOrder
        '
        Me.lblModelOrder.AutoSize = true
        Me.lblModelOrder.Location = New System.Drawing.Point(20, 139)
        Me.lblModelOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelOrder.Name = "lblModelOrder"
        Me.lblModelOrder.Size = New System.Drawing.Size(49, 17)
        Me.lblModelOrder.TabIndex = 157
        Me.lblModelOrder.Text = "Modell"
        '
        'txtBxModell
        '
        Me.txtBxModell.Location = New System.Drawing.Point(89, 134)
        Me.txtBxModell.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxModell.Name = "txtBxModell"
        Me.txtBxModell.Size = New System.Drawing.Size(213, 22)
        Me.txtBxModell.TabIndex = 156
        '
        'lblCategoryOrder
        '
        Me.lblCategoryOrder.AutoSize = true
        Me.lblCategoryOrder.Location = New System.Drawing.Point(20, 60)
        Me.lblCategoryOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoryOrder.Name = "lblCategoryOrder"
        Me.lblCategoryOrder.Size = New System.Drawing.Size(61, 17)
        Me.lblCategoryOrder.TabIndex = 155
        Me.lblCategoryOrder.Text = "Kategori"
        '
        'txtBxKategori
        '
        Me.txtBxKategori.Location = New System.Drawing.Point(89, 57)
        Me.txtBxKategori.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxKategori.Name = "txtBxKategori"
        Me.txtBxKategori.Size = New System.Drawing.Size(213, 22)
        Me.txtBxKategori.TabIndex = 154
        '
        'tabBike
        '
        Me.tabBike.BackColor = System.Drawing.Color.Transparent
        Me.tabBike.Controls.Add(Me.btnOrderSearchBike)
        Me.tabBike.Controls.Add(Me.lblOrderChooseEqip)
        Me.tabBike.Controls.Add(Me.lblOrderOverView)
        Me.tabBike.Controls.Add(Me.lstbxEquipment)
        Me.tabBike.Controls.Add(Me.ListBoxOrderOverview)
        Me.tabBike.Controls.Add(Me.btnNewOrder)
        Me.tabBike.Controls.Add(Me.btnAddToOrder)
        Me.tabBike.Controls.Add(Me.btnBackKunde)
        Me.tabBike.Controls.Add(Me.btnNextBestilling)
        Me.tabBike.Controls.Add(Me.dgvBicycle)
        Me.tabBike.Controls.Add(Me.lblFramenbOrder)
        Me.tabBike.Controls.Add(Me.txtBxRammenr)
        Me.tabBike.Controls.Add(Me.lblBrandOrder)
        Me.tabBike.Controls.Add(Me.txtBxMerke)
        Me.tabBike.Controls.Add(Me.lblPriceOrder)
        Me.tabBike.Controls.Add(Me.txtBxPris)
        Me.tabBike.Controls.Add(Me.lblModelOrder)
        Me.tabBike.Controls.Add(Me.txtBxModell)
        Me.tabBike.Controls.Add(Me.lblCategoryOrder)
        Me.tabBike.Controls.Add(Me.txtBxKategori)
        Me.tabBike.Location = New System.Drawing.Point(4, 25)
        Me.tabBike.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBike.Name = "tabBike"
        Me.tabBike.Padding = New System.Windows.Forms.Padding(4)
        Me.tabBike.Size = New System.Drawing.Size(1276, 494)
        Me.tabBike.TabIndex = 1
        Me.tabBike.Text = "Sykkel"
        '
        'Bestilling
        '
        Me.Bestilling.Controls.Add(Me.TabCustomer)
        Me.Bestilling.Controls.Add(Me.tabBike)
        Me.Bestilling.Controls.Add(Me.TabOrder)
        Me.Bestilling.Controls.Add(Me.TabSummary)
        Me.Bestilling.Location = New System.Drawing.Point(36, 53)
        Me.Bestilling.Margin = New System.Windows.Forms.Padding(4)
        Me.Bestilling.Name = "Bestilling"
        Me.Bestilling.SelectedIndex = 0
        Me.Bestilling.Size = New System.Drawing.Size(1284, 523)
        Me.Bestilling.TabIndex = 3
        '
        'OrderTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 723)
        Me.Controls.Add(Me.Bestilling)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OrderTest"
        Me.Text = "OrderTest"
        Me.TabOrder.ResumeLayout(false)
        Me.TabOrder.PerformLayout
        Me.grpBxSelectPeriod.ResumeLayout(false)
        Me.grpBxSelectPeriod.PerformLayout
        Me.TabSummary.ResumeLayout(false)
        Me.TabCustomer.ResumeLayout(false)
        Me.TabCustomer.PerformLayout
        CType(Me.DataGridViewKunde,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvBicycle,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBike.ResumeLayout(false)
        Me.tabBike.PerformLayout
        Me.Bestilling.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnOrderSearchBike As System.Windows.Forms.Button
    Friend WithEvents lblOrderChooseEqip As System.Windows.Forms.Label
    Friend WithEvents lblOrderOverView As System.Windows.Forms.Label
    Friend WithEvents lstbxEquipment As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnAddToOrder As System.Windows.Forms.Button
    Friend WithEvents btnBackKunde As System.Windows.Forms.Button
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents TabOrder As System.Windows.Forms.TabPage
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents CmbBoxDiscount As System.Windows.Forms.ComboBox
    Friend WithEvents grpBxSelectPeriod As System.Windows.Forms.GroupBox
    Friend WithEvents labelTilSelect As System.Windows.Forms.Label
    Friend WithEvents CalendarTo As System.Windows.Forms.MonthCalendar
    Friend WithEvents labelFraSelect As System.Windows.Forms.Label
    Friend WithEvents CalendarFrom As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnBackSykkel As System.Windows.Forms.Button
    Friend WithEvents btnNextSammendrag As System.Windows.Forms.Button
    Friend WithEvents ListBoxOrderOverview As System.Windows.Forms.ListBox
    Friend WithEvents TabSummary As System.Windows.Forms.TabPage
    Friend WithEvents btnBackBestilling As System.Windows.Forms.Button
    Friend WithEvents btnRegisterOrder As System.Windows.Forms.Button
    Friend WithEvents ListBoxReceipt As System.Windows.Forms.ListBox
    Friend WithEvents btnNextBestilling As System.Windows.Forms.Button
    Friend WithEvents lblLastnameOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxSirName As System.Windows.Forms.TextBox
    Friend WithEvents TabCustomer As System.Windows.Forms.TabPage
    Friend WithEvents btnChangeCustomer As System.Windows.Forms.Button
    Friend WithEvents btnCreateNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnNextToSykkel As System.Windows.Forms.Button
    Friend WithEvents DataGridViewKunde As System.Windows.Forms.DataGridView
    Friend WithEvents lblKidOrdre As System.Windows.Forms.Label
    Friend WithEvents txtBxKID As System.Windows.Forms.TextBox
    Friend WithEvents lblemailOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblTlfOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstnameOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents dgvBicycle As System.Windows.Forms.DataGridView
    Friend WithEvents lblFramenbOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxRammenr As System.Windows.Forms.TextBox
    Friend WithEvents lblBrandOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxMerke As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxPris As System.Windows.Forms.TextBox
    Friend WithEvents lblModelOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxModell As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoryOrder As System.Windows.Forms.Label
    Friend WithEvents txtBxKategori As System.Windows.Forms.TextBox
    Friend WithEvents tabBike As System.Windows.Forms.TabPage
    Friend WithEvents Bestilling As System.Windows.Forms.TabControl
End Class
