﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StorageWorker
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
        Me.btnSearchbike = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.lblBikeBreaks = New System.Windows.Forms.Label()
        Me.lblBikeGear = New System.Windows.Forms.Label()
        Me.lblBikeFrame = New System.Windows.Forms.Label()
        Me.lblBikeTires = New System.Windows.Forms.Label()
        Me.btnChangebike = New System.Windows.Forms.Button()
        Me.lblBikePlaceofO = New System.Windows.Forms.Label()
        Me.lblBikeLocation = New System.Windows.Forms.Label()
        Me.lblBikeStatus = New System.Windows.Forms.Label()
        Me.lblBikeModel = New System.Windows.Forms.Label()
        Me.lblBikeFramenb = New System.Windows.Forms.Label()
        Me.dtgvBike = New System.Windows.Forms.DataGridView()
        Me.grpbxBike = New System.Windows.Forms.GroupBox()
        Me.btnSavebike = New System.Windows.Forms.Button()
        Me.btnNewbike = New System.Windows.Forms.Button()
        Me.btnNullbike = New System.Windows.Forms.Button()
        Me.btnDeletebike = New System.Windows.Forms.Button()
        Me.grpbxModels = New System.Windows.Forms.GroupBox()
        Me.lstbxEqipment = New System.Windows.Forms.CheckedListBox()
        Me.btnNullmodel = New System.Windows.Forms.Button()
        Me.btnChangemodel = New System.Windows.Forms.Button()
        Me.btnSearchmodel = New System.Windows.Forms.Button()
        Me.lblModelModel = New System.Windows.Forms.Label()
        Me.btnSavemodel = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnNewmodel = New System.Windows.Forms.Button()
        Me.txtModelname = New System.Windows.Forms.MaskedTextBox()
        Me.txtModelprice = New System.Windows.Forms.MaskedTextBox()
        Me.txtModelproducer = New System.Windows.Forms.MaskedTextBox()
        Me.txtModelcategory = New System.Windows.Forms.MaskedTextBox()
        Me.lblModelPrice = New System.Windows.Forms.Label()
        Me.lblModelCategory = New System.Windows.Forms.Label()
        Me.dtgvModel = New System.Windows.Forms.DataGridView()
        Me.grpbxEquipment = New System.Windows.Forms.GroupBox()
        Me.btnEqipReset = New System.Windows.Forms.Button()
        Me.lblEqipStatus = New System.Windows.Forms.Label()
        Me.btnEqipChange = New System.Windows.Forms.Button()
        Me.lblEqipPrice = New System.Windows.Forms.Label()
        Me.btnEqipDelete = New System.Windows.Forms.Button()
        Me.lblEqipType = New System.Windows.Forms.Label()
        Me.btnEqipSave = New System.Windows.Forms.Button()
        Me.lblEqipID = New System.Windows.Forms.Label()
        Me.dtgvEquip = New System.Windows.Forms.DataGridView()
        Me.txtEqipStatus = New System.Windows.Forms.TextBox()
        Me.txtEqipPrice = New System.Windows.Forms.TextBox()
        Me.btnEqipSearch = New System.Windows.Forms.Button()
        Me.txtEqipType = New System.Windows.Forms.TextBox()
        Me.txtEqipID = New System.Windows.Forms.TextBox()
        Me.txtFramenumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnEqipCreate = New System.Windows.Forms.Button()
        Me.txtBrakes = New System.Windows.Forms.MaskedTextBox()
        Me.txtGear = New System.Windows.Forms.MaskedTextBox()
        Me.txtFrame = New System.Windows.Forms.MaskedTextBox()
        Me.txtTire = New System.Windows.Forms.MaskedTextBox()
        Me.txtPointofsale = New System.Windows.Forms.MaskedTextBox()
        Me.txtLocation = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrice = New System.Windows.Forms.MaskedTextBox()
        Me.txtCategory = New System.Windows.Forms.MaskedTextBox()
        Me.txtProducer = New System.Windows.Forms.MaskedTextBox()
        Me.lblBikePrice = New System.Windows.Forms.Label()
        Me.lblBikeProducer = New System.Windows.Forms.Label()
        Me.lblBikeCategory = New System.Windows.Forms.Label()
        Me.dtgvmissingbike = New System.Windows.Forms.DataGridView()
        Me.lblmissinbike = New System.Windows.Forms.Label()
        Me.btnmissingbike = New System.Windows.Forms.Button()
        CType(Me.dtgvBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxBike.SuspendLayout()
        Me.grpbxModels.SuspendLayout()
        CType(Me.dtgvModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxEquipment.SuspendLayout()
        CType(Me.dtgvEquip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvmissingbike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchbike
        '
        Me.btnSearchbike.Location = New System.Drawing.Point(190, 380)
        Me.btnSearchbike.Name = "btnSearchbike"
        Me.btnSearchbike.Size = New System.Drawing.Size(85, 25)
        Me.btnSearchbike.TabIndex = 186
        Me.btnSearchbike.Text = "Søk"
        Me.btnSearchbike.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Til Reparasjon", "Skal til Reparasjon", "På Lager", "Utleid", "Under Transport"})
        Me.cmbStatus.Location = New System.Drawing.Point(99, 178)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(183, 24)
        Me.cmbStatus.TabIndex = 244
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(99, 64)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(183, 24)
        Me.cmbModel.TabIndex = 243
        '
        'lblBikeBreaks
        '
        Me.lblBikeBreaks.AutoSize = True
        Me.lblBikeBreaks.Location = New System.Drawing.Point(24, 349)
        Me.lblBikeBreaks.Name = "lblBikeBreaks"
        Me.lblBikeBreaks.Size = New System.Drawing.Size(61, 17)
        Me.lblBikeBreaks.TabIndex = 242
        Me.lblBikeBreaks.Text = "Bremser"
        '
        'lblBikeGear
        '
        Me.lblBikeGear.AutoSize = True
        Me.lblBikeGear.Location = New System.Drawing.Point(24, 321)
        Me.lblBikeGear.Name = "lblBikeGear"
        Me.lblBikeGear.Size = New System.Drawing.Size(27, 17)
        Me.lblBikeGear.TabIndex = 241
        Me.lblBikeGear.Text = "Gir"
        '
        'lblBikeFrame
        '
        Me.lblBikeFrame.AutoSize = True
        Me.lblBikeFrame.Location = New System.Drawing.Point(24, 293)
        Me.lblBikeFrame.Name = "lblBikeFrame"
        Me.lblBikeFrame.Size = New System.Drawing.Size(56, 17)
        Me.lblBikeFrame.TabIndex = 240
        Me.lblBikeFrame.Text = "Ramme"
        '
        'lblBikeTires
        '
        Me.lblBikeTires.AutoSize = True
        Me.lblBikeTires.Location = New System.Drawing.Point(24, 265)
        Me.lblBikeTires.Name = "lblBikeTires"
        Me.lblBikeTires.Size = New System.Drawing.Size(40, 17)
        Me.lblBikeTires.TabIndex = 239
        Me.lblBikeTires.Text = "Dekk"
        '
        'btnChangebike
        '
        Me.btnChangebike.Enabled = False
        Me.btnChangebike.Location = New System.Drawing.Point(101, 409)
        Me.btnChangebike.Name = "btnChangebike"
        Me.btnChangebike.Size = New System.Drawing.Size(85, 25)
        Me.btnChangebike.TabIndex = 188
        Me.btnChangebike.Text = "Endre"
        Me.btnChangebike.UseVisualStyleBackColor = True
        '
        'lblBikePlaceofO
        '
        Me.lblBikePlaceofO.AutoSize = True
        Me.lblBikePlaceofO.Location = New System.Drawing.Point(24, 237)
        Me.lblBikePlaceofO.Name = "lblBikePlaceofO"
        Me.lblBikePlaceofO.Size = New System.Drawing.Size(71, 17)
        Me.lblBikePlaceofO.TabIndex = 238
        Me.lblBikePlaceofO.Text = "Utleiested"
        '
        'lblBikeLocation
        '
        Me.lblBikeLocation.AutoSize = True
        Me.lblBikeLocation.Location = New System.Drawing.Point(24, 209)
        Me.lblBikeLocation.Name = "lblBikeLocation"
        Me.lblBikeLocation.Size = New System.Drawing.Size(65, 17)
        Me.lblBikeLocation.TabIndex = 237
        Me.lblBikeLocation.Text = "Lokasjon"
        '
        'lblBikeStatus
        '
        Me.lblBikeStatus.AutoSize = True
        Me.lblBikeStatus.Location = New System.Drawing.Point(24, 181)
        Me.lblBikeStatus.Name = "lblBikeStatus"
        Me.lblBikeStatus.Size = New System.Drawing.Size(48, 17)
        Me.lblBikeStatus.TabIndex = 236
        Me.lblBikeStatus.Text = "Status"
        '
        'lblBikeModel
        '
        Me.lblBikeModel.AutoSize = True
        Me.lblBikeModel.Location = New System.Drawing.Point(24, 69)
        Me.lblBikeModel.Name = "lblBikeModel"
        Me.lblBikeModel.Size = New System.Drawing.Size(49, 17)
        Me.lblBikeModel.TabIndex = 235
        Me.lblBikeModel.Text = "Modell"
        '
        'lblBikeFramenb
        '
        Me.lblBikeFramenb.AutoSize = True
        Me.lblBikeFramenb.Location = New System.Drawing.Point(24, 41)
        Me.lblBikeFramenb.Name = "lblBikeFramenb"
        Me.lblBikeFramenb.Size = New System.Drawing.Size(69, 17)
        Me.lblBikeFramenb.TabIndex = 234
        Me.lblBikeFramenb.Text = "Rammenr"
        '
        'dtgvBike
        '
        Me.dtgvBike.AllowUserToAddRows = False
        Me.dtgvBike.AllowUserToDeleteRows = False
        Me.dtgvBike.AllowUserToResizeColumns = False
        Me.dtgvBike.AllowUserToResizeRows = False
        Me.dtgvBike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvBike.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgvBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvBike.Location = New System.Drawing.Point(290, 36)
        Me.dtgvBike.MultiSelect = False
        Me.dtgvBike.Name = "dtgvBike"
        Me.dtgvBike.ReadOnly = True
        Me.dtgvBike.RowHeadersVisible = False
        Me.dtgvBike.RowTemplate.Height = 24
        Me.dtgvBike.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgvBike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvBike.Size = New System.Drawing.Size(378, 404)
        Me.dtgvBike.TabIndex = 232
        '
        'grpbxBike
        '
        Me.grpbxBike.Controls.Add(Me.btnSavebike)
        Me.grpbxBike.Controls.Add(Me.btnSearchbike)
        Me.grpbxBike.Controls.Add(Me.btnNewbike)
        Me.grpbxBike.Controls.Add(Me.btnChangebike)
        Me.grpbxBike.Controls.Add(Me.btnNullbike)
        Me.grpbxBike.Controls.Add(Me.btnDeletebike)
        Me.grpbxBike.Location = New System.Drawing.Point(7, 8)
        Me.grpbxBike.Name = "grpbxBike"
        Me.grpbxBike.Size = New System.Drawing.Size(679, 449)
        Me.grpbxBike.TabIndex = 258
        Me.grpbxBike.TabStop = False
        Me.grpbxBike.Text = "Sykkel"
        '
        'btnSavebike
        '
        Me.btnSavebike.Enabled = False
        Me.btnSavebike.Location = New System.Drawing.Point(190, 409)
        Me.btnSavebike.Name = "btnSavebike"
        Me.btnSavebike.Size = New System.Drawing.Size(85, 25)
        Me.btnSavebike.TabIndex = 189
        Me.btnSavebike.Text = "Lagre"
        Me.btnSavebike.UseVisualStyleBackColor = True
        '
        'btnNewbike
        '
        Me.btnNewbike.Location = New System.Drawing.Point(101, 380)
        Me.btnNewbike.Name = "btnNewbike"
        Me.btnNewbike.Size = New System.Drawing.Size(85, 25)
        Me.btnNewbike.TabIndex = 185
        Me.btnNewbike.Text = "Opprett"
        Me.btnNewbike.UseVisualStyleBackColor = True
        '
        'btnNullbike
        '
        Me.btnNullbike.Location = New System.Drawing.Point(12, 380)
        Me.btnNullbike.Name = "btnNullbike"
        Me.btnNullbike.Size = New System.Drawing.Size(85, 25)
        Me.btnNullbike.TabIndex = 211
        Me.btnNullbike.Text = "Reset"
        Me.btnNullbike.UseVisualStyleBackColor = True
        '
        'btnDeletebike
        '
        Me.btnDeletebike.Enabled = False
        Me.btnDeletebike.Location = New System.Drawing.Point(12, 409)
        Me.btnDeletebike.Name = "btnDeletebike"
        Me.btnDeletebike.Size = New System.Drawing.Size(85, 25)
        Me.btnDeletebike.TabIndex = 187
        Me.btnDeletebike.Text = "Slett"
        Me.btnDeletebike.UseVisualStyleBackColor = True
        '
        'grpbxModels
        '
        Me.grpbxModels.Controls.Add(Me.lstbxEqipment)
        Me.grpbxModels.Controls.Add(Me.btnNullmodel)
        Me.grpbxModels.Controls.Add(Me.btnChangemodel)
        Me.grpbxModels.Controls.Add(Me.btnSearchmodel)
        Me.grpbxModels.Controls.Add(Me.lblModelModel)
        Me.grpbxModels.Controls.Add(Me.btnSavemodel)
        Me.grpbxModels.Controls.Add(Me.Label18)
        Me.grpbxModels.Controls.Add(Me.btnNewmodel)
        Me.grpbxModels.Controls.Add(Me.txtModelname)
        Me.grpbxModels.Controls.Add(Me.txtModelprice)
        Me.grpbxModels.Controls.Add(Me.txtModelproducer)
        Me.grpbxModels.Controls.Add(Me.txtModelcategory)
        Me.grpbxModels.Controls.Add(Me.lblModelPrice)
        Me.grpbxModels.Controls.Add(Me.lblModelCategory)
        Me.grpbxModels.Controls.Add(Me.dtgvModel)
        Me.grpbxModels.Location = New System.Drawing.Point(7, 489)
        Me.grpbxModels.Name = "grpbxModels"
        Me.grpbxModels.Size = New System.Drawing.Size(771, 218)
        Me.grpbxModels.TabIndex = 260
        Me.grpbxModels.TabStop = False
        Me.grpbxModels.Text = "Modeller"
        '
        'lstbxEqipment
        '
        Me.lstbxEqipment.CheckOnClick = True
        Me.lstbxEqipment.Enabled = False
        Me.lstbxEqipment.FormattingEnabled = True
        Me.lstbxEqipment.Location = New System.Drawing.Point(283, 26)
        Me.lstbxEqipment.Name = "lstbxEqipment"
        Me.lstbxEqipment.Size = New System.Drawing.Size(120, 174)
        Me.lstbxEqipment.TabIndex = 228
        '
        'btnNullmodel
        '
        Me.btnNullmodel.Location = New System.Drawing.Point(12, 145)
        Me.btnNullmodel.Name = "btnNullmodel"
        Me.btnNullmodel.Size = New System.Drawing.Size(85, 25)
        Me.btnNullmodel.TabIndex = 212
        Me.btnNullmodel.Text = "Reset"
        Me.btnNullmodel.UseVisualStyleBackColor = True
        '
        'btnChangemodel
        '
        Me.btnChangemodel.Enabled = False
        Me.btnChangemodel.Location = New System.Drawing.Point(100, 174)
        Me.btnChangemodel.Name = "btnChangemodel"
        Me.btnChangemodel.Size = New System.Drawing.Size(85, 25)
        Me.btnChangemodel.TabIndex = 192
        Me.btnChangemodel.Text = "Endre"
        Me.btnChangemodel.UseVisualStyleBackColor = True
        '
        'btnSearchmodel
        '
        Me.btnSearchmodel.Location = New System.Drawing.Point(187, 145)
        Me.btnSearchmodel.Name = "btnSearchmodel"
        Me.btnSearchmodel.Size = New System.Drawing.Size(85, 25)
        Me.btnSearchmodel.TabIndex = 191
        Me.btnSearchmodel.Text = "Søk"
        Me.btnSearchmodel.UseVisualStyleBackColor = True
        '
        'lblModelModel
        '
        Me.lblModelModel.AutoSize = True
        Me.lblModelModel.Location = New System.Drawing.Point(22, 23)
        Me.lblModelModel.Name = "lblModelModel"
        Me.lblModelModel.Size = New System.Drawing.Size(49, 17)
        Me.lblModelModel.TabIndex = 181
        Me.lblModelModel.Text = "Modell"
        '
        'btnSavemodel
        '
        Me.btnSavemodel.Enabled = False
        Me.btnSavemodel.Location = New System.Drawing.Point(189, 174)
        Me.btnSavemodel.Name = "btnSavemodel"
        Me.btnSavemodel.Size = New System.Drawing.Size(85, 25)
        Me.btnSavemodel.TabIndex = 193
        Me.btnSavemodel.Text = "Lagre"
        Me.btnSavemodel.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 17)
        Me.Label18.TabIndex = 183
        Me.Label18.Text = "Produsent"
        '
        'btnNewmodel
        '
        Me.btnNewmodel.Location = New System.Drawing.Point(100, 145)
        Me.btnNewmodel.Name = "btnNewmodel"
        Me.btnNewmodel.Size = New System.Drawing.Size(85, 25)
        Me.btnNewmodel.TabIndex = 190
        Me.btnNewmodel.Text = "Opprett"
        Me.btnNewmodel.UseVisualStyleBackColor = True
        '
        'txtModelname
        '
        Me.txtModelname.Location = New System.Drawing.Point(104, 24)
        Me.txtModelname.Name = "txtModelname"
        Me.txtModelname.Size = New System.Drawing.Size(173, 22)
        Me.txtModelname.TabIndex = 206
        '
        'txtModelprice
        '
        Me.txtModelprice.Location = New System.Drawing.Point(104, 52)
        Me.txtModelprice.Mask = "0000"
        Me.txtModelprice.Name = "txtModelprice"
        Me.txtModelprice.Size = New System.Drawing.Size(173, 22)
        Me.txtModelprice.TabIndex = 207
        '
        'txtModelproducer
        '
        Me.txtModelproducer.Location = New System.Drawing.Point(104, 80)
        Me.txtModelproducer.Name = "txtModelproducer"
        Me.txtModelproducer.Size = New System.Drawing.Size(173, 22)
        Me.txtModelproducer.TabIndex = 208
        '
        'txtModelcategory
        '
        Me.txtModelcategory.Location = New System.Drawing.Point(104, 108)
        Me.txtModelcategory.Name = "txtModelcategory"
        Me.txtModelcategory.Size = New System.Drawing.Size(173, 22)
        Me.txtModelcategory.TabIndex = 209
        '
        'lblModelPrice
        '
        Me.lblModelPrice.AutoSize = True
        Me.lblModelPrice.Location = New System.Drawing.Point(25, 52)
        Me.lblModelPrice.Name = "lblModelPrice"
        Me.lblModelPrice.Size = New System.Drawing.Size(32, 17)
        Me.lblModelPrice.TabIndex = 182
        Me.lblModelPrice.Text = "Pris"
        '
        'lblModelCategory
        '
        Me.lblModelCategory.AutoSize = True
        Me.lblModelCategory.Location = New System.Drawing.Point(22, 113)
        Me.lblModelCategory.Name = "lblModelCategory"
        Me.lblModelCategory.Size = New System.Drawing.Size(61, 17)
        Me.lblModelCategory.TabIndex = 184
        Me.lblModelCategory.Text = "Kategori"
        '
        'dtgvModel
        '
        Me.dtgvModel.AllowUserToAddRows = False
        Me.dtgvModel.AllowUserToDeleteRows = False
        Me.dtgvModel.AllowUserToResizeColumns = False
        Me.dtgvModel.AllowUserToResizeRows = False
        Me.dtgvModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvModel.Location = New System.Drawing.Point(409, 26)
        Me.dtgvModel.MultiSelect = False
        Me.dtgvModel.Name = "dtgvModel"
        Me.dtgvModel.ReadOnly = True
        Me.dtgvModel.RowHeadersVisible = False
        Me.dtgvModel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dtgvModel.RowTemplate.Height = 24
        Me.dtgvModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvModel.Size = New System.Drawing.Size(347, 173)
        Me.dtgvModel.TabIndex = 168
        '
        'grpbxEquipment
        '
        Me.grpbxEquipment.Controls.Add(Me.btnEqipReset)
        Me.grpbxEquipment.Controls.Add(Me.lblEqipStatus)
        Me.grpbxEquipment.Controls.Add(Me.btnEqipChange)
        Me.grpbxEquipment.Controls.Add(Me.lblEqipPrice)
        Me.grpbxEquipment.Controls.Add(Me.btnEqipDelete)
        Me.grpbxEquipment.Controls.Add(Me.lblEqipType)
        Me.grpbxEquipment.Controls.Add(Me.btnEqipSave)
        Me.grpbxEquipment.Controls.Add(Me.lblEqipID)
        Me.grpbxEquipment.Controls.Add(Me.dtgvEquip)
        Me.grpbxEquipment.Controls.Add(Me.txtEqipStatus)
        Me.grpbxEquipment.Controls.Add(Me.txtEqipPrice)
        Me.grpbxEquipment.Controls.Add(Me.btnEqipSearch)
        Me.grpbxEquipment.Controls.Add(Me.txtEqipType)
        Me.grpbxEquipment.Controls.Add(Me.txtEqipID)
        Me.grpbxEquipment.Location = New System.Drawing.Point(692, 36)
        Me.grpbxEquipment.Name = "grpbxEquipment"
        Me.grpbxEquipment.Size = New System.Drawing.Size(584, 218)
        Me.grpbxEquipment.TabIndex = 259
        Me.grpbxEquipment.TabStop = False
        Me.grpbxEquipment.Text = "Tilleggsutstyr"
        '
        'btnEqipReset
        '
        Me.btnEqipReset.Location = New System.Drawing.Point(7, 142)
        Me.btnEqipReset.Name = "btnEqipReset"
        Me.btnEqipReset.Size = New System.Drawing.Size(85, 25)
        Me.btnEqipReset.TabIndex = 226
        Me.btnEqipReset.Text = "Reset"
        Me.btnEqipReset.UseVisualStyleBackColor = True
        '
        'lblEqipStatus
        '
        Me.lblEqipStatus.AutoSize = True
        Me.lblEqipStatus.Location = New System.Drawing.Point(20, 108)
        Me.lblEqipStatus.Name = "lblEqipStatus"
        Me.lblEqipStatus.Size = New System.Drawing.Size(48, 17)
        Me.lblEqipStatus.TabIndex = 220
        Me.lblEqipStatus.Text = "Status"
        '
        'btnEqipChange
        '
        Me.btnEqipChange.Enabled = False
        Me.btnEqipChange.Location = New System.Drawing.Point(98, 175)
        Me.btnEqipChange.Name = "btnEqipChange"
        Me.btnEqipChange.Size = New System.Drawing.Size(85, 25)
        Me.btnEqipChange.TabIndex = 223
        Me.btnEqipChange.Text = "Endre"
        Me.btnEqipChange.UseVisualStyleBackColor = True
        '
        'lblEqipPrice
        '
        Me.lblEqipPrice.AutoSize = True
        Me.lblEqipPrice.Location = New System.Drawing.Point(20, 79)
        Me.lblEqipPrice.Name = "lblEqipPrice"
        Me.lblEqipPrice.Size = New System.Drawing.Size(32, 17)
        Me.lblEqipPrice.TabIndex = 219
        Me.lblEqipPrice.Text = "Pris"
        '
        'btnEqipDelete
        '
        Me.btnEqipDelete.Enabled = False
        Me.btnEqipDelete.Location = New System.Drawing.Point(7, 173)
        Me.btnEqipDelete.Name = "btnEqipDelete"
        Me.btnEqipDelete.Size = New System.Drawing.Size(85, 25)
        Me.btnEqipDelete.TabIndex = 224
        Me.btnEqipDelete.Text = "Slett"
        Me.btnEqipDelete.UseVisualStyleBackColor = True
        '
        'lblEqipType
        '
        Me.lblEqipType.AutoSize = True
        Me.lblEqipType.Location = New System.Drawing.Point(19, 50)
        Me.lblEqipType.Name = "lblEqipType"
        Me.lblEqipType.Size = New System.Drawing.Size(40, 17)
        Me.lblEqipType.TabIndex = 218
        Me.lblEqipType.Text = "Type"
        '
        'btnEqipSave
        '
        Me.btnEqipSave.Enabled = False
        Me.btnEqipSave.Location = New System.Drawing.Point(189, 175)
        Me.btnEqipSave.Name = "btnEqipSave"
        Me.btnEqipSave.Size = New System.Drawing.Size(85, 25)
        Me.btnEqipSave.TabIndex = 227
        Me.btnEqipSave.Text = "Lagre"
        Me.btnEqipSave.UseVisualStyleBackColor = True
        '
        'lblEqipID
        '
        Me.lblEqipID.AutoSize = True
        Me.lblEqipID.Location = New System.Drawing.Point(20, 21)
        Me.lblEqipID.Name = "lblEqipID"
        Me.lblEqipID.Size = New System.Drawing.Size(89, 17)
        Me.lblEqipID.TabIndex = 217
        Me.lblEqipID.Text = "Varenummer"
        '
        'dtgvEquip
        '
        Me.dtgvEquip.AllowUserToAddRows = False
        Me.dtgvEquip.AllowUserToDeleteRows = False
        Me.dtgvEquip.AllowUserToResizeColumns = False
        Me.dtgvEquip.AllowUserToResizeRows = False
        Me.dtgvEquip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgvEquip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvEquip.Location = New System.Drawing.Point(284, 21)
        Me.dtgvEquip.MultiSelect = False
        Me.dtgvEquip.Name = "dtgvEquip"
        Me.dtgvEquip.ReadOnly = True
        Me.dtgvEquip.RowHeadersVisible = False
        Me.dtgvEquip.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dtgvEquip.RowTemplate.Height = 24
        Me.dtgvEquip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgvEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvEquip.Size = New System.Drawing.Size(296, 179)
        Me.dtgvEquip.TabIndex = 222
        '
        'txtEqipStatus
        '
        Me.txtEqipStatus.Location = New System.Drawing.Point(133, 105)
        Me.txtEqipStatus.Name = "txtEqipStatus"
        Me.txtEqipStatus.Size = New System.Drawing.Size(141, 22)
        Me.txtEqipStatus.TabIndex = 216
        '
        'txtEqipPrice
        '
        Me.txtEqipPrice.Location = New System.Drawing.Point(133, 77)
        Me.txtEqipPrice.Name = "txtEqipPrice"
        Me.txtEqipPrice.Size = New System.Drawing.Size(141, 22)
        Me.txtEqipPrice.TabIndex = 215
        '
        'btnEqipSearch
        '
        Me.btnEqipSearch.Location = New System.Drawing.Point(189, 144)
        Me.btnEqipSearch.Name = "btnEqipSearch"
        Me.btnEqipSearch.Size = New System.Drawing.Size(85, 25)
        Me.btnEqipSearch.TabIndex = 221
        Me.btnEqipSearch.Text = "Søk"
        Me.btnEqipSearch.UseVisualStyleBackColor = True
        '
        'txtEqipType
        '
        Me.txtEqipType.Location = New System.Drawing.Point(133, 49)
        Me.txtEqipType.Name = "txtEqipType"
        Me.txtEqipType.Size = New System.Drawing.Size(141, 22)
        Me.txtEqipType.TabIndex = 214
        '
        'txtEqipID
        '
        Me.txtEqipID.Location = New System.Drawing.Point(133, 21)
        Me.txtEqipID.Name = "txtEqipID"
        Me.txtEqipID.Size = New System.Drawing.Size(141, 22)
        Me.txtEqipID.TabIndex = 213
        '
        'txtFramenumber
        '
        Me.txtFramenumber.Location = New System.Drawing.Point(99, 36)
        Me.txtFramenumber.Name = "txtFramenumber"
        Me.txtFramenumber.Size = New System.Drawing.Size(181, 22)
        Me.txtFramenumber.TabIndex = 233
        '
        'btnEqipCreate
        '
        Me.btnEqipCreate.Location = New System.Drawing.Point(790, 180)
        Me.btnEqipCreate.Name = "btnEqipCreate"
        Me.btnEqipCreate.Size = New System.Drawing.Size(85, 25)
        Me.btnEqipCreate.TabIndex = 257
        Me.btnEqipCreate.Text = "Opprett"
        Me.btnEqipCreate.UseVisualStyleBackColor = True
        '
        'txtBrakes
        '
        Me.txtBrakes.Location = New System.Drawing.Point(99, 348)
        Me.txtBrakes.Name = "txtBrakes"
        Me.txtBrakes.Size = New System.Drawing.Size(183, 22)
        Me.txtBrakes.TabIndex = 256
        '
        'txtGear
        '
        Me.txtGear.Location = New System.Drawing.Point(97, 320)
        Me.txtGear.Name = "txtGear"
        Me.txtGear.Size = New System.Drawing.Size(183, 22)
        Me.txtGear.TabIndex = 255
        '
        'txtFrame
        '
        Me.txtFrame.Location = New System.Drawing.Point(97, 292)
        Me.txtFrame.Name = "txtFrame"
        Me.txtFrame.Size = New System.Drawing.Size(183, 22)
        Me.txtFrame.TabIndex = 254
        '
        'txtTire
        '
        Me.txtTire.Location = New System.Drawing.Point(97, 264)
        Me.txtTire.Name = "txtTire"
        Me.txtTire.Size = New System.Drawing.Size(183, 22)
        Me.txtTire.TabIndex = 253
        '
        'txtPointofsale
        '
        Me.txtPointofsale.Location = New System.Drawing.Point(97, 236)
        Me.txtPointofsale.Name = "txtPointofsale"
        Me.txtPointofsale.Size = New System.Drawing.Size(183, 22)
        Me.txtPointofsale.TabIndex = 252
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(97, 208)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(183, 22)
        Me.txtLocation.TabIndex = 251
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(97, 150)
        Me.txtPrice.Mask = "0000"
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(185, 22)
        Me.txtPrice.TabIndex = 250
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(99, 122)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(185, 22)
        Me.txtCategory.TabIndex = 249
        '
        'txtProducer
        '
        Me.txtProducer.Location = New System.Drawing.Point(99, 94)
        Me.txtProducer.Name = "txtProducer"
        Me.txtProducer.ReadOnly = True
        Me.txtProducer.Size = New System.Drawing.Size(185, 22)
        Me.txtProducer.TabIndex = 248
        '
        'lblBikePrice
        '
        Me.lblBikePrice.AutoSize = True
        Me.lblBikePrice.Location = New System.Drawing.Point(24, 153)
        Me.lblBikePrice.Name = "lblBikePrice"
        Me.lblBikePrice.Size = New System.Drawing.Size(32, 17)
        Me.lblBikePrice.TabIndex = 247
        Me.lblBikePrice.Text = "Pris"
        '
        'lblBikeProducer
        '
        Me.lblBikeProducer.AutoSize = True
        Me.lblBikeProducer.Location = New System.Drawing.Point(24, 97)
        Me.lblBikeProducer.Name = "lblBikeProducer"
        Me.lblBikeProducer.Size = New System.Drawing.Size(73, 17)
        Me.lblBikeProducer.TabIndex = 246
        Me.lblBikeProducer.Text = "Produsent"
        '
        'lblBikeCategory
        '
        Me.lblBikeCategory.AutoSize = True
        Me.lblBikeCategory.Location = New System.Drawing.Point(24, 125)
        Me.lblBikeCategory.Name = "lblBikeCategory"
        Me.lblBikeCategory.Size = New System.Drawing.Size(61, 17)
        Me.lblBikeCategory.TabIndex = 245
        Me.lblBikeCategory.Text = "Kategori"
        '
        'dtgvmissingbike
        '
        Me.dtgvmissingbike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvmissingbike.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgvmissingbike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvmissingbike.Location = New System.Drawing.Point(976, 350)
        Me.dtgvmissingbike.Name = "dtgvmissingbike"
        Me.dtgvmissingbike.RowHeadersVisible = False
        Me.dtgvmissingbike.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtgvmissingbike.RowTemplate.Height = 24
        Me.dtgvmissingbike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvmissingbike.Size = New System.Drawing.Size(262, 339)
        Me.dtgvmissingbike.TabIndex = 261
        '
        'lblmissinbike
        '
        Me.lblmissinbike.AutoSize = True
        Me.lblmissinbike.Location = New System.Drawing.Point(973, 330)
        Me.lblmissinbike.Name = "lblmissinbike"
        Me.lblmissinbike.Size = New System.Drawing.Size(105, 17)
        Me.lblmissinbike.TabIndex = 262
        Me.lblmissinbike.Text = "Savnede sykler"
        '
        'btnmissingbike
        '
        Me.btnmissingbike.Location = New System.Drawing.Point(1156, 327)
        Me.btnmissingbike.Name = "btnmissingbike"
        Me.btnmissingbike.Size = New System.Drawing.Size(82, 23)
        Me.btnmissingbike.TabIndex = 263
        Me.btnmissingbike.Text = "Oppdater"
        Me.btnmissingbike.UseVisualStyleBackColor = True
        '
        'StorageWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 723)
        Me.Controls.Add(Me.btnmissingbike)
        Me.Controls.Add(Me.lblmissinbike)
        Me.Controls.Add(Me.dtgvmissingbike)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.lblBikeBreaks)
        Me.Controls.Add(Me.lblBikeGear)
        Me.Controls.Add(Me.lblBikeFrame)
        Me.Controls.Add(Me.lblBikeTires)
        Me.Controls.Add(Me.lblBikePlaceofO)
        Me.Controls.Add(Me.lblBikeLocation)
        Me.Controls.Add(Me.lblBikeStatus)
        Me.Controls.Add(Me.lblBikeModel)
        Me.Controls.Add(Me.lblBikeFramenb)
        Me.Controls.Add(Me.dtgvBike)
        Me.Controls.Add(Me.txtFramenumber)
        Me.Controls.Add(Me.btnEqipCreate)
        Me.Controls.Add(Me.txtBrakes)
        Me.Controls.Add(Me.txtGear)
        Me.Controls.Add(Me.txtFrame)
        Me.Controls.Add(Me.txtTire)
        Me.Controls.Add(Me.txtPointofsale)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProducer)
        Me.Controls.Add(Me.lblBikePrice)
        Me.Controls.Add(Me.lblBikeProducer)
        Me.Controls.Add(Me.lblBikeCategory)
        Me.Controls.Add(Me.grpbxBike)
        Me.Controls.Add(Me.grpbxModels)
        Me.Controls.Add(Me.grpbxEquipment)
        Me.Name = "StorageWorker"
        Me.Text = "StorageWorker"
        CType(Me.dtgvBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxBike.ResumeLayout(False)
        Me.grpbxModels.ResumeLayout(False)
        Me.grpbxModels.PerformLayout()
        CType(Me.dtgvModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxEquipment.ResumeLayout(False)
        Me.grpbxEquipment.PerformLayout()
        CType(Me.dtgvEquip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvmissingbike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchbike As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents lblBikeBreaks As System.Windows.Forms.Label
    Friend WithEvents lblBikeGear As System.Windows.Forms.Label
    Friend WithEvents lblBikeFrame As System.Windows.Forms.Label
    Friend WithEvents lblBikeTires As System.Windows.Forms.Label
    Friend WithEvents btnChangebike As System.Windows.Forms.Button
    Friend WithEvents lblBikePlaceofO As System.Windows.Forms.Label
    Friend WithEvents lblBikeLocation As System.Windows.Forms.Label
    Friend WithEvents lblBikeStatus As System.Windows.Forms.Label
    Friend WithEvents lblBikeModel As System.Windows.Forms.Label
    Friend WithEvents lblBikeFramenb As System.Windows.Forms.Label
    Friend WithEvents dtgvBike As System.Windows.Forms.DataGridView
    Friend WithEvents grpbxBike As System.Windows.Forms.GroupBox
    Friend WithEvents btnSavebike As System.Windows.Forms.Button
    Friend WithEvents btnNewbike As System.Windows.Forms.Button
    Friend WithEvents btnNullbike As System.Windows.Forms.Button
    Friend WithEvents btnDeletebike As System.Windows.Forms.Button
    Friend WithEvents grpbxModels As System.Windows.Forms.GroupBox
    Friend WithEvents lstbxEqipment As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnNullmodel As System.Windows.Forms.Button
    Friend WithEvents btnChangemodel As System.Windows.Forms.Button
    Friend WithEvents btnSearchmodel As System.Windows.Forms.Button
    Friend WithEvents lblModelModel As System.Windows.Forms.Label
    Friend WithEvents btnSavemodel As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnNewmodel As System.Windows.Forms.Button
    Friend WithEvents txtModelname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtModelprice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtModelproducer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtModelcategory As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblModelPrice As System.Windows.Forms.Label
    Friend WithEvents lblModelCategory As System.Windows.Forms.Label
    Friend WithEvents dtgvModel As System.Windows.Forms.DataGridView
    Friend WithEvents grpbxEquipment As System.Windows.Forms.GroupBox
    Friend WithEvents btnEqipReset As System.Windows.Forms.Button
    Friend WithEvents lblEqipStatus As System.Windows.Forms.Label
    Friend WithEvents btnEqipChange As System.Windows.Forms.Button
    Friend WithEvents lblEqipPrice As System.Windows.Forms.Label
    Friend WithEvents btnEqipDelete As System.Windows.Forms.Button
    Friend WithEvents lblEqipType As System.Windows.Forms.Label
    Friend WithEvents btnEqipSave As System.Windows.Forms.Button
    Friend WithEvents lblEqipID As System.Windows.Forms.Label
    Friend WithEvents dtgvEquip As System.Windows.Forms.DataGridView
    Friend WithEvents txtEqipStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtEqipPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnEqipSearch As System.Windows.Forms.Button
    Friend WithEvents txtEqipType As System.Windows.Forms.TextBox
    Friend WithEvents txtEqipID As System.Windows.Forms.TextBox
    Friend WithEvents txtFramenumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnEqipCreate As System.Windows.Forms.Button
    Friend WithEvents txtBrakes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtGear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFrame As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTire As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPointofsale As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLocation As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPrice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCategory As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtProducer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblBikePrice As System.Windows.Forms.Label
    Friend WithEvents lblBikeProducer As System.Windows.Forms.Label
    Friend WithEvents lblBikeCategory As System.Windows.Forms.Label
    Friend WithEvents dtgvmissingbike As System.Windows.Forms.DataGridView
    Friend WithEvents lblmissinbike As System.Windows.Forms.Label
    Friend WithEvents btnmissingbike As System.Windows.Forms.Button
End Class
