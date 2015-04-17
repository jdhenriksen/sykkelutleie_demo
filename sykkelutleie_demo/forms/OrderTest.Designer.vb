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
        Me.txtBxSurName = New System.Windows.Forms.TextBox()
        Me.TabCustomer = New System.Windows.Forms.TabPage()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
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
        Me.lblUID = New System.Windows.Forms.Label()
        Me.TabOrder.SuspendLayout()
        Me.grpBxSelectPeriod.SuspendLayout()
        Me.TabSummary.SuspendLayout()
        Me.TabCustomer.SuspendLayout()
        CType(Me.DataGridViewKunde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBicycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBike.SuspendLayout()
        Me.Bestilling.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOrderSearchBike
        '
        Me.btnOrderSearchBike.Location = New System.Drawing.Point(10, 358)
        Me.btnOrderSearchBike.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderSearchBike.Name = "btnOrderSearchBike"
        Me.btnOrderSearchBike.Size = New System.Drawing.Size(131, 37)
        Me.btnOrderSearchBike.TabIndex = 172
        Me.btnOrderSearchBike.Text = "Søk"
        Me.btnOrderSearchBike.UseVisualStyleBackColor = True
        '
        'lblOrderChooseEqip
        '
        Me.lblOrderChooseEqip.AutoSize = True
        Me.lblOrderChooseEqip.Location = New System.Drawing.Point(657, 13)
        Me.lblOrderChooseEqip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderChooseEqip.Name = "lblOrderChooseEqip"
        Me.lblOrderChooseEqip.Size = New System.Drawing.Size(58, 13)
        Me.lblOrderChooseEqip.TabIndex = 171
        Me.lblOrderChooseEqip.Text = "Velg Utstyr"
        '
        'lblOrderOverView
        '
        Me.lblOrderOverView.AutoSize = True
        Me.lblOrderOverView.Location = New System.Drawing.Point(752, 13)
        Me.lblOrderOverView.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderOverView.Name = "lblOrderOverView"
        Me.lblOrderOverView.Size = New System.Drawing.Size(70, 13)
        Me.lblOrderOverView.TabIndex = 170
        Me.lblOrderOverView.Text = "Ordreoversikt"
        '
        'lstbxEquipment
        '
        Me.lstbxEquipment.FormattingEnabled = True
        Me.lstbxEquipment.Location = New System.Drawing.Point(659, 32)
        Me.lstbxEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.lstbxEquipment.Name = "lstbxEquipment"
        Me.lstbxEquipment.Size = New System.Drawing.Size(91, 304)
        Me.lstbxEquipment.TabIndex = 3
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(147, 358)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(131, 37)
        Me.btnNewOrder.TabIndex = 4
        Me.btnNewOrder.Text = "Reset Bestilling"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnAddToOrder
        '
        Me.btnAddToOrder.Location = New System.Drawing.Point(524, 358)
        Me.btnAddToOrder.Name = "btnAddToOrder"
        Me.btnAddToOrder.Size = New System.Drawing.Size(131, 37)
        Me.btnAddToOrder.TabIndex = 168
        Me.btnAddToOrder.Text = "Legg sykkel med valgt utstyr til bestillingen"
        Me.btnAddToOrder.UseVisualStyleBackColor = True
        '
        'btnBackKunde
        '
        Me.btnBackKunde.Location = New System.Drawing.Point(659, 358)
        Me.btnBackKunde.Name = "btnBackKunde"
        Me.btnBackKunde.Size = New System.Drawing.Size(131, 37)
        Me.btnBackKunde.TabIndex = 167
        Me.btnBackKunde.Text = "<-- Tilbake"
        Me.btnBackKunde.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(520, 358)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(131, 37)
        Me.btnPrintReceipt.TabIndex = 2
        Me.btnPrintReceipt.Text = "Vis Kvittering"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'TabOrder
        '
        Me.TabOrder.BackColor = System.Drawing.Color.Transparent
        Me.TabOrder.Controls.Add(Me.lblDiscount)
        Me.TabOrder.Controls.Add(Me.CmbBoxDiscount)
        Me.TabOrder.Controls.Add(Me.grpBxSelectPeriod)
        Me.TabOrder.Controls.Add(Me.btnBackSykkel)
        Me.TabOrder.Controls.Add(Me.btnNextSammendrag)
        Me.TabOrder.Location = New System.Drawing.Point(4, 22)
        Me.TabOrder.Name = "TabOrder"
        Me.TabOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOrder.Size = New System.Drawing.Size(955, 399)
        Me.TabOrder.TabIndex = 2
        Me.TabOrder.Text = "Bestilling"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(548, 168)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(39, 13)
        Me.lblDiscount.TabIndex = 173
        Me.lblDiscount.Text = "Rabatt"
        '
        'CmbBoxDiscount
        '
        Me.CmbBoxDiscount.FormattingEnabled = True
        Me.CmbBoxDiscount.Items.AddRange(New Object() {"Ingen", "10%", "20%", "Ansatt", "Skoleklasse", "Gruppe 10+", "Kampanje 50%"})
        Me.CmbBoxDiscount.Location = New System.Drawing.Point(593, 166)
        Me.CmbBoxDiscount.Name = "CmbBoxDiscount"
        Me.CmbBoxDiscount.Size = New System.Drawing.Size(121, 21)
        Me.CmbBoxDiscount.TabIndex = 172
        Me.CmbBoxDiscount.Text = "Ingen"
        '
        'grpBxSelectPeriod
        '
        Me.grpBxSelectPeriod.Controls.Add(Me.labelTilSelect)
        Me.grpBxSelectPeriod.Controls.Add(Me.CalendarTo)
        Me.grpBxSelectPeriod.Controls.Add(Me.labelFraSelect)
        Me.grpBxSelectPeriod.Controls.Add(Me.CalendarFrom)
        Me.grpBxSelectPeriod.Location = New System.Drawing.Point(46, 71)
        Me.grpBxSelectPeriod.Name = "grpBxSelectPeriod"
        Me.grpBxSelectPeriod.Size = New System.Drawing.Size(473, 221)
        Me.grpBxSelectPeriod.TabIndex = 171
        Me.grpBxSelectPeriod.TabStop = False
        Me.grpBxSelectPeriod.Text = "Velg periode"
        '
        'labelTilSelect
        '
        Me.labelTilSelect.AutoSize = True
        Me.labelTilSelect.Location = New System.Drawing.Point(256, 20)
        Me.labelTilSelect.Name = "labelTilSelect"
        Me.labelTilSelect.Size = New System.Drawing.Size(18, 13)
        Me.labelTilSelect.TabIndex = 10
        Me.labelTilSelect.Text = "Til"
        '
        'CalendarTo
        '
        Me.CalendarTo.Location = New System.Drawing.Point(256, 42)
        Me.CalendarTo.Name = "CalendarTo"
        Me.CalendarTo.TabIndex = 9
        '
        'labelFraSelect
        '
        Me.labelFraSelect.AutoSize = True
        Me.labelFraSelect.Location = New System.Drawing.Point(21, 20)
        Me.labelFraSelect.Name = "labelFraSelect"
        Me.labelFraSelect.Size = New System.Drawing.Size(22, 13)
        Me.labelFraSelect.TabIndex = 8
        Me.labelFraSelect.Text = "Fra"
        '
        'CalendarFrom
        '
        Me.CalendarFrom.Location = New System.Drawing.Point(24, 42)
        Me.CalendarFrom.Name = "CalendarFrom"
        Me.CalendarFrom.TabIndex = 7
        '
        'btnBackSykkel
        '
        Me.btnBackSykkel.Location = New System.Drawing.Point(658, 358)
        Me.btnBackSykkel.Name = "btnBackSykkel"
        Me.btnBackSykkel.Size = New System.Drawing.Size(131, 37)
        Me.btnBackSykkel.TabIndex = 170
        Me.btnBackSykkel.Text = "<-- Tilbake"
        Me.btnBackSykkel.UseVisualStyleBackColor = True
        '
        'btnNextSammendrag
        '
        Me.btnNextSammendrag.Location = New System.Drawing.Point(795, 358)
        Me.btnNextSammendrag.Name = "btnNextSammendrag"
        Me.btnNextSammendrag.Size = New System.Drawing.Size(131, 37)
        Me.btnNextSammendrag.TabIndex = 169
        Me.btnNextSammendrag.Text = "Neste -->"
        Me.btnNextSammendrag.UseVisualStyleBackColor = True
        '
        'ListBoxOrderOverview
        '
        Me.ListBoxOrderOverview.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxOrderOverview.FormattingEnabled = True
        Me.ListBoxOrderOverview.Location = New System.Drawing.Point(754, 30)
        Me.ListBoxOrderOverview.Name = "ListBoxOrderOverview"
        Me.ListBoxOrderOverview.Size = New System.Drawing.Size(173, 316)
        Me.ListBoxOrderOverview.TabIndex = 3
        '
        'TabSummary
        '
        Me.TabSummary.BackColor = System.Drawing.Color.Transparent
        Me.TabSummary.Controls.Add(Me.btnBackBestilling)
        Me.TabSummary.Controls.Add(Me.btnRegisterOrder)
        Me.TabSummary.Controls.Add(Me.btnPrintReceipt)
        Me.TabSummary.Controls.Add(Me.ListBoxReceipt)
        Me.TabSummary.Location = New System.Drawing.Point(4, 22)
        Me.TabSummary.Name = "TabSummary"
        Me.TabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSummary.Size = New System.Drawing.Size(955, 399)
        Me.TabSummary.TabIndex = 3
        Me.TabSummary.Text = "Sammendrag"
        '
        'btnBackBestilling
        '
        Me.btnBackBestilling.Location = New System.Drawing.Point(658, 358)
        Me.btnBackBestilling.Name = "btnBackBestilling"
        Me.btnBackBestilling.Size = New System.Drawing.Size(131, 37)
        Me.btnBackBestilling.TabIndex = 171
        Me.btnBackBestilling.Text = "<-- Tilbake"
        Me.btnBackBestilling.UseVisualStyleBackColor = True
        '
        'btnRegisterOrder
        '
        Me.btnRegisterOrder.Location = New System.Drawing.Point(795, 358)
        Me.btnRegisterOrder.Name = "btnRegisterOrder"
        Me.btnRegisterOrder.Size = New System.Drawing.Size(131, 37)
        Me.btnRegisterOrder.TabIndex = 3
        Me.btnRegisterOrder.Text = "Registrer bestilling"
        Me.btnRegisterOrder.UseVisualStyleBackColor = True
        '
        'ListBoxReceipt
        '
        Me.ListBoxReceipt.FormattingEnabled = True
        Me.ListBoxReceipt.Location = New System.Drawing.Point(55, 24)
        Me.ListBoxReceipt.Name = "ListBoxReceipt"
        Me.ListBoxReceipt.Size = New System.Drawing.Size(872, 316)
        Me.ListBoxReceipt.TabIndex = 1
        '
        'btnNextBestilling
        '
        Me.btnNextBestilling.Location = New System.Drawing.Point(795, 358)
        Me.btnNextBestilling.Name = "btnNextBestilling"
        Me.btnNextBestilling.Size = New System.Drawing.Size(131, 37)
        Me.btnNextBestilling.TabIndex = 166
        Me.btnNextBestilling.Text = "Neste -->"
        Me.btnNextBestilling.UseVisualStyleBackColor = True
        '
        'lblLastnameOrder
        '
        Me.lblLastnameOrder.AutoSize = True
        Me.lblLastnameOrder.Location = New System.Drawing.Point(11, 111)
        Me.lblLastnameOrder.Name = "lblLastnameOrder"
        Me.lblLastnameOrder.Size = New System.Drawing.Size(53, 13)
        Me.lblLastnameOrder.TabIndex = 3
        Me.lblLastnameOrder.Text = "Etternavn"
        '
        'txtBxSurName
        '
        Me.txtBxSurName.Location = New System.Drawing.Point(63, 108)
        Me.txtBxSurName.Name = "txtBxSurName"
        Me.txtBxSurName.Size = New System.Drawing.Size(161, 20)
        Me.txtBxSurName.TabIndex = 2
        '
        'TabCustomer
        '
        Me.TabCustomer.BackColor = System.Drawing.Color.Transparent
        Me.TabCustomer.Controls.Add(Me.lblUID)
        Me.TabCustomer.Controls.Add(Me.btnSearchCustomer)
        Me.TabCustomer.Controls.Add(Me.btnDeleteCustomer)
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
        Me.TabCustomer.Controls.Add(Me.txtBxSurName)
        Me.TabCustomer.Controls.Add(Me.lblFirstnameOrder)
        Me.TabCustomer.Controls.Add(Me.txtBxFirstName)
        Me.TabCustomer.Location = New System.Drawing.Point(4, 22)
        Me.TabCustomer.Name = "TabCustomer"
        Me.TabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCustomer.Size = New System.Drawing.Size(955, 399)
        Me.TabCustomer.TabIndex = 0
        Me.TabCustomer.Text = "Kunde"
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(240, 358)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(131, 37)
        Me.btnSearchCustomer.TabIndex = 157
        Me.btnSearchCustomer.Text = "Søk kunde"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(514, 358)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(131, 37)
        Me.btnDeleteCustomer.TabIndex = 156
        Me.btnDeleteCustomer.Text = "Slett kunde"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'btnChangeCustomer
        '
        Me.btnChangeCustomer.Location = New System.Drawing.Point(377, 358)
        Me.btnChangeCustomer.Name = "btnChangeCustomer"
        Me.btnChangeCustomer.Size = New System.Drawing.Size(131, 37)
        Me.btnChangeCustomer.TabIndex = 155
        Me.btnChangeCustomer.Text = "Endre kunde"
        Me.btnChangeCustomer.UseVisualStyleBackColor = True
        '
        'btnCreateNewCustomer
        '
        Me.btnCreateNewCustomer.Location = New System.Drawing.Point(14, 356)
        Me.btnCreateNewCustomer.Name = "btnCreateNewCustomer"
        Me.btnCreateNewCustomer.Size = New System.Drawing.Size(131, 37)
        Me.btnCreateNewCustomer.TabIndex = 154
        Me.btnCreateNewCustomer.Text = "Opprett ny kunde"
        Me.btnCreateNewCustomer.UseVisualStyleBackColor = True
        '
        'btnNextToSykkel
        '
        Me.btnNextToSykkel.Location = New System.Drawing.Point(795, 358)
        Me.btnNextToSykkel.Name = "btnNextToSykkel"
        Me.btnNextToSykkel.Size = New System.Drawing.Size(131, 37)
        Me.btnNextToSykkel.TabIndex = 153
        Me.btnNextToSykkel.Text = "Neste -->"
        Me.btnNextToSykkel.UseVisualStyleBackColor = True
        '
        'DataGridViewKunde
        '
        Me.DataGridViewKunde.AllowUserToAddRows = False
        Me.DataGridViewKunde.AllowUserToDeleteRows = False
        Me.DataGridViewKunde.AllowUserToResizeColumns = False
        Me.DataGridViewKunde.AllowUserToResizeRows = False
        Me.DataGridViewKunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewKunde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewKunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKunde.Location = New System.Drawing.Point(240, 18)
        Me.DataGridViewKunde.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewKunde.MultiSelect = False
        Me.DataGridViewKunde.Name = "DataGridViewKunde"
        Me.DataGridViewKunde.ReadOnly = True
        Me.DataGridViewKunde.RowHeadersVisible = False
        Me.DataGridViewKunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewKunde.RowTemplate.Height = 24
        Me.DataGridViewKunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewKunde.Size = New System.Drawing.Size(686, 325)
        Me.DataGridViewKunde.TabIndex = 151
        '
        'lblKidOrdre
        '
        Me.lblKidOrdre.AutoSize = True
        Me.lblKidOrdre.Location = New System.Drawing.Point(11, 302)
        Me.lblKidOrdre.Name = "lblKidOrdre"
        Me.lblKidOrdre.Size = New System.Drawing.Size(22, 13)
        Me.lblKidOrdre.TabIndex = 9
        Me.lblKidOrdre.Text = "Kid"
        '
        'txtBxKID
        '
        Me.txtBxKID.Location = New System.Drawing.Point(63, 302)
        Me.txtBxKID.Name = "txtBxKID"
        Me.txtBxKID.ReadOnly = True
        Me.txtBxKID.Size = New System.Drawing.Size(161, 20)
        Me.txtBxKID.TabIndex = 8
        '
        'lblemailOrder
        '
        Me.lblemailOrder.AutoSize = True
        Me.lblemailOrder.Location = New System.Drawing.Point(11, 175)
        Me.lblemailOrder.Name = "lblemailOrder"
        Me.lblemailOrder.Size = New System.Drawing.Size(37, 13)
        Me.lblemailOrder.TabIndex = 7
        Me.lblemailOrder.Text = "E-post"
        '
        'txtBxEmail
        '
        Me.txtBxEmail.Location = New System.Drawing.Point(63, 174)
        Me.txtBxEmail.Name = "txtBxEmail"
        Me.txtBxEmail.Size = New System.Drawing.Size(161, 20)
        Me.txtBxEmail.TabIndex = 6
        '
        'lblTlfOrder
        '
        Me.lblTlfOrder.AutoSize = True
        Me.lblTlfOrder.Location = New System.Drawing.Point(11, 238)
        Me.lblTlfOrder.Name = "lblTlfOrder"
        Me.lblTlfOrder.Size = New System.Drawing.Size(43, 13)
        Me.lblTlfOrder.TabIndex = 5
        Me.lblTlfOrder.Text = "Telefon"
        '
        'txtBxPhone
        '
        Me.txtBxPhone.Location = New System.Drawing.Point(63, 238)
        Me.txtBxPhone.Name = "txtBxPhone"
        Me.txtBxPhone.Size = New System.Drawing.Size(161, 20)
        Me.txtBxPhone.TabIndex = 4
        '
        'lblFirstnameOrder
        '
        Me.lblFirstnameOrder.AutoSize = True
        Me.lblFirstnameOrder.Location = New System.Drawing.Point(11, 48)
        Me.lblFirstnameOrder.Name = "lblFirstnameOrder"
        Me.lblFirstnameOrder.Size = New System.Drawing.Size(46, 13)
        Me.lblFirstnameOrder.TabIndex = 1
        Me.lblFirstnameOrder.Text = "Fornavn"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.Location = New System.Drawing.Point(63, 46)
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(161, 20)
        Me.txtBxFirstName.TabIndex = 0
        '
        'dgvBicycle
        '
        Me.dgvBicycle.AllowUserToAddRows = False
        Me.dgvBicycle.AllowUserToDeleteRows = False
        Me.dgvBicycle.AllowUserToResizeColumns = False
        Me.dgvBicycle.AllowUserToResizeRows = False
        Me.dgvBicycle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBicycle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBicycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBicycle.Location = New System.Drawing.Point(240, 18)
        Me.dgvBicycle.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBicycle.MultiSelect = False
        Me.dgvBicycle.Name = "dgvBicycle"
        Me.dgvBicycle.ReadOnly = True
        Me.dgvBicycle.RowHeadersVisible = False
        Me.dgvBicycle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvBicycle.RowTemplate.Height = 24
        Me.dgvBicycle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBicycle.Size = New System.Drawing.Size(415, 325)
        Me.dgvBicycle.TabIndex = 164
        '
        'lblFramenbOrder
        '
        Me.lblFramenbOrder.AutoSize = True
        Me.lblFramenbOrder.Location = New System.Drawing.Point(15, 306)
        Me.lblFramenbOrder.Name = "lblFramenbOrder"
        Me.lblFramenbOrder.Size = New System.Drawing.Size(55, 13)
        Me.lblFramenbOrder.TabIndex = 163
        Me.lblFramenbOrder.Text = "Rammenr."
        '
        'txtBxRammenr
        '
        Me.txtBxRammenr.Location = New System.Drawing.Point(67, 303)
        Me.txtBxRammenr.Name = "txtBxRammenr"
        Me.txtBxRammenr.Size = New System.Drawing.Size(161, 20)
        Me.txtBxRammenr.TabIndex = 162
        '
        'lblBrandOrder
        '
        Me.lblBrandOrder.AutoSize = True
        Me.lblBrandOrder.Location = New System.Drawing.Point(15, 241)
        Me.lblBrandOrder.Name = "lblBrandOrder"
        Me.lblBrandOrder.Size = New System.Drawing.Size(37, 13)
        Me.lblBrandOrder.TabIndex = 161
        Me.lblBrandOrder.Text = "Merke"
        '
        'txtBxMerke
        '
        Me.txtBxMerke.Location = New System.Drawing.Point(67, 239)
        Me.txtBxMerke.Name = "txtBxMerke"
        Me.txtBxMerke.Size = New System.Drawing.Size(161, 20)
        Me.txtBxMerke.TabIndex = 160
        '
        'lblPriceOrder
        '
        Me.lblPriceOrder.AutoSize = True
        Me.lblPriceOrder.Location = New System.Drawing.Point(15, 177)
        Me.lblPriceOrder.Name = "lblPriceOrder"
        Me.lblPriceOrder.Size = New System.Drawing.Size(24, 13)
        Me.lblPriceOrder.TabIndex = 159
        Me.lblPriceOrder.Text = "Pris"
        '
        'txtBxPris
        '
        Me.txtBxPris.Location = New System.Drawing.Point(67, 175)
        Me.txtBxPris.Name = "txtBxPris"
        Me.txtBxPris.Size = New System.Drawing.Size(161, 20)
        Me.txtBxPris.TabIndex = 158
        '
        'lblModelOrder
        '
        Me.lblModelOrder.AutoSize = True
        Me.lblModelOrder.Location = New System.Drawing.Point(15, 113)
        Me.lblModelOrder.Name = "lblModelOrder"
        Me.lblModelOrder.Size = New System.Drawing.Size(38, 13)
        Me.lblModelOrder.TabIndex = 157
        Me.lblModelOrder.Text = "Modell"
        '
        'txtBxModell
        '
        Me.txtBxModell.Location = New System.Drawing.Point(67, 109)
        Me.txtBxModell.Name = "txtBxModell"
        Me.txtBxModell.Size = New System.Drawing.Size(161, 20)
        Me.txtBxModell.TabIndex = 156
        '
        'lblCategoryOrder
        '
        Me.lblCategoryOrder.AutoSize = True
        Me.lblCategoryOrder.Location = New System.Drawing.Point(15, 49)
        Me.lblCategoryOrder.Name = "lblCategoryOrder"
        Me.lblCategoryOrder.Size = New System.Drawing.Size(46, 13)
        Me.lblCategoryOrder.TabIndex = 155
        Me.lblCategoryOrder.Text = "Kategori"
        '
        'txtBxKategori
        '
        Me.txtBxKategori.Location = New System.Drawing.Point(67, 46)
        Me.txtBxKategori.Name = "txtBxKategori"
        Me.txtBxKategori.Size = New System.Drawing.Size(161, 20)
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
        Me.tabBike.Location = New System.Drawing.Point(4, 22)
        Me.tabBike.Name = "tabBike"
        Me.tabBike.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBike.Size = New System.Drawing.Size(955, 399)
        Me.tabBike.TabIndex = 1
        Me.tabBike.Text = "Sykkel"
        '
        'Bestilling
        '
        Me.Bestilling.Controls.Add(Me.TabCustomer)
        Me.Bestilling.Controls.Add(Me.tabBike)
        Me.Bestilling.Controls.Add(Me.TabOrder)
        Me.Bestilling.Controls.Add(Me.TabSummary)
        Me.Bestilling.Location = New System.Drawing.Point(27, 43)
        Me.Bestilling.Name = "Bestilling"
        Me.Bestilling.SelectedIndex = 0
        Me.Bestilling.Size = New System.Drawing.Size(963, 425)
        Me.Bestilling.TabIndex = 3
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.Location = New System.Drawing.Point(11, 18)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(82, 13)
        Me.lblUID.TabIndex = 4
        Me.lblUID.Text = "Velkommen, id: "
        '
        'OrderTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 587)
        Me.Controls.Add(Me.Bestilling)
        Me.Name = "OrderTest"
        Me.Text = "OrderTest"
        Me.TabOrder.ResumeLayout(False)
        Me.TabOrder.PerformLayout()
        Me.grpBxSelectPeriod.ResumeLayout(False)
        Me.grpBxSelectPeriod.PerformLayout()
        Me.TabSummary.ResumeLayout(False)
        Me.TabCustomer.ResumeLayout(False)
        Me.TabCustomer.PerformLayout()
        CType(Me.DataGridViewKunde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBicycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBike.ResumeLayout(False)
        Me.tabBike.PerformLayout()
        Me.Bestilling.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents txtBxSurName As System.Windows.Forms.TextBox
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
    Friend WithEvents btnDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents lblUID As System.Windows.Forms.Label
End Class
