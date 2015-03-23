<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnNullmodel = New System.Windows.Forms.Button()
        Me.btnNullbike = New System.Windows.Forms.Button()
        Me.btnDeletemodel = New System.Windows.Forms.Button()
        Me.txtModelcategory = New System.Windows.Forms.MaskedTextBox()
        Me.txtModelproducer = New System.Windows.Forms.MaskedTextBox()
        Me.txtModelprice = New System.Windows.Forms.MaskedTextBox()
        Me.txtModelname = New System.Windows.Forms.MaskedTextBox()
        Me.txtBrakes = New System.Windows.Forms.MaskedTextBox()
        Me.txtGear = New System.Windows.Forms.MaskedTextBox()
        Me.txtFrame = New System.Windows.Forms.MaskedTextBox()
        Me.txtTire = New System.Windows.Forms.MaskedTextBox()
        Me.txtPointofsale = New System.Windows.Forms.MaskedTextBox()
        Me.txtLocation = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrice = New System.Windows.Forms.MaskedTextBox()
        Me.txtCategory = New System.Windows.Forms.MaskedTextBox()
        Me.txtProducer = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnSavemodel = New System.Windows.Forms.Button()
        Me.btnChangemodel = New System.Windows.Forms.Button()
        Me.btnSearchmodel = New System.Windows.Forms.Button()
        Me.btnNewmodel = New System.Windows.Forms.Button()
        Me.btnSavebike = New System.Windows.Forms.Button()
        Me.btnChangebike = New System.Windows.Forms.Button()
        Me.btnDeletebike = New System.Windows.Forms.Button()
        Me.btnSearchbike = New System.Windows.Forms.Button()
        Me.btnNewbike = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFramenumber = New System.Windows.Forms.MaskedTextBox()
        Me.dtgvModel = New System.Windows.Forms.DataGridView()
        Me.dtgvBike = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNullmodel
        '
        Me.btnNullmodel.Location = New System.Drawing.Point(11, 634)
        Me.btnNullmodel.Name = "btnNullmodel"
        Me.btnNullmodel.Size = New System.Drawing.Size(83, 23)
        Me.btnNullmodel.TabIndex = 195
        Me.btnNullmodel.Text = "Reset"
        Me.btnNullmodel.UseVisualStyleBackColor = True
        '
        'btnNullbike
        '
        Me.btnNullbike.Location = New System.Drawing.Point(11, 365)
        Me.btnNullbike.Name = "btnNullbike"
        Me.btnNullbike.Size = New System.Drawing.Size(83, 23)
        Me.btnNullbike.TabIndex = 194
        Me.btnNullbike.Text = "Reset"
        Me.btnNullbike.UseVisualStyleBackColor = True
        '
        'btnDeletemodel
        '
        Me.btnDeletemodel.Enabled = False
        Me.btnDeletemodel.Location = New System.Drawing.Point(11, 663)
        Me.btnDeletemodel.Name = "btnDeletemodel"
        Me.btnDeletemodel.Size = New System.Drawing.Size(83, 23)
        Me.btnDeletemodel.TabIndex = 193
        Me.btnDeletemodel.Text = "Slett"
        Me.btnDeletemodel.UseVisualStyleBackColor = True
        '
        'txtModelcategory
        '
        Me.txtModelcategory.Location = New System.Drawing.Point(146, 598)
        Me.txtModelcategory.Name = "txtModelcategory"
        Me.txtModelcategory.Size = New System.Drawing.Size(127, 22)
        Me.txtModelcategory.TabIndex = 192
        '
        'txtModelproducer
        '
        Me.txtModelproducer.Location = New System.Drawing.Point(148, 569)
        Me.txtModelproducer.Name = "txtModelproducer"
        Me.txtModelproducer.Size = New System.Drawing.Size(127, 22)
        Me.txtModelproducer.TabIndex = 191
        '
        'txtModelprice
        '
        Me.txtModelprice.Location = New System.Drawing.Point(146, 540)
        Me.txtModelprice.Mask = "0000"
        Me.txtModelprice.Name = "txtModelprice"
        Me.txtModelprice.Size = New System.Drawing.Size(127, 22)
        Me.txtModelprice.TabIndex = 190
        '
        'txtModelname
        '
        Me.txtModelname.Location = New System.Drawing.Point(146, 511)
        Me.txtModelname.Name = "txtModelname"
        Me.txtModelname.Size = New System.Drawing.Size(127, 22)
        Me.txtModelname.TabIndex = 189
        '
        'txtBrakes
        '
        Me.txtBrakes.Location = New System.Drawing.Point(132, 327)
        Me.txtBrakes.Name = "txtBrakes"
        Me.txtBrakes.Size = New System.Drawing.Size(151, 22)
        Me.txtBrakes.TabIndex = 188
        '
        'txtGear
        '
        Me.txtGear.Location = New System.Drawing.Point(130, 298)
        Me.txtGear.Name = "txtGear"
        Me.txtGear.Size = New System.Drawing.Size(151, 22)
        Me.txtGear.TabIndex = 187
        '
        'txtFrame
        '
        Me.txtFrame.Location = New System.Drawing.Point(130, 276)
        Me.txtFrame.Name = "txtFrame"
        Me.txtFrame.Size = New System.Drawing.Size(151, 22)
        Me.txtFrame.TabIndex = 186
        '
        'txtTire
        '
        Me.txtTire.Location = New System.Drawing.Point(130, 250)
        Me.txtTire.Name = "txtTire"
        Me.txtTire.Size = New System.Drawing.Size(151, 22)
        Me.txtTire.TabIndex = 185
        '
        'txtPointofsale
        '
        Me.txtPointofsale.Location = New System.Drawing.Point(130, 221)
        Me.txtPointofsale.Name = "txtPointofsale"
        Me.txtPointofsale.Size = New System.Drawing.Size(151, 22)
        Me.txtPointofsale.TabIndex = 184
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(130, 192)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(151, 22)
        Me.txtLocation.TabIndex = 183
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(130, 128)
        Me.txtPrice.Mask = "0000"
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(153, 22)
        Me.txtPrice.TabIndex = 182
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(132, 106)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(153, 22)
        Me.txtCategory.TabIndex = 181
        '
        'txtProducer
        '
        Me.txtProducer.Location = New System.Drawing.Point(132, 76)
        Me.txtProducer.Name = "txtProducer"
        Me.txtProducer.ReadOnly = True
        Me.txtProducer.Size = New System.Drawing.Size(153, 22)
        Me.txtProducer.TabIndex = 180
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 17)
        Me.Label12.TabIndex = 179
        Me.Label12.Text = "Pris"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Produsent"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(25, 106)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 17)
        Me.Label30.TabIndex = 177
        Me.Label30.Text = "Kategori"
        '
        'btnSavemodel
        '
        Me.btnSavemodel.Enabled = False
        Me.btnSavemodel.Location = New System.Drawing.Point(193, 663)
        Me.btnSavemodel.Name = "btnSavemodel"
        Me.btnSavemodel.Size = New System.Drawing.Size(87, 23)
        Me.btnSavemodel.TabIndex = 176
        Me.btnSavemodel.Text = "Lagre"
        Me.btnSavemodel.UseVisualStyleBackColor = True
        '
        'btnChangemodel
        '
        Me.btnChangemodel.Enabled = False
        Me.btnChangemodel.Location = New System.Drawing.Point(100, 663)
        Me.btnChangemodel.Name = "btnChangemodel"
        Me.btnChangemodel.Size = New System.Drawing.Size(87, 23)
        Me.btnChangemodel.TabIndex = 175
        Me.btnChangemodel.Text = "Endre"
        Me.btnChangemodel.UseVisualStyleBackColor = True
        '
        'btnSearchmodel
        '
        Me.btnSearchmodel.Location = New System.Drawing.Point(193, 634)
        Me.btnSearchmodel.Name = "btnSearchmodel"
        Me.btnSearchmodel.Size = New System.Drawing.Size(87, 23)
        Me.btnSearchmodel.TabIndex = 174
        Me.btnSearchmodel.Text = "Søk"
        Me.btnSearchmodel.UseVisualStyleBackColor = True
        '
        'btnNewmodel
        '
        Me.btnNewmodel.Location = New System.Drawing.Point(100, 634)
        Me.btnNewmodel.Name = "btnNewmodel"
        Me.btnNewmodel.Size = New System.Drawing.Size(87, 23)
        Me.btnNewmodel.TabIndex = 173
        Me.btnNewmodel.Text = "Opprett"
        Me.btnNewmodel.UseVisualStyleBackColor = True
        '
        'btnSavebike
        '
        Me.btnSavebike.Enabled = False
        Me.btnSavebike.Location = New System.Drawing.Point(190, 395)
        Me.btnSavebike.Name = "btnSavebike"
        Me.btnSavebike.Size = New System.Drawing.Size(93, 23)
        Me.btnSavebike.TabIndex = 172
        Me.btnSavebike.Text = "Lagre"
        Me.btnSavebike.UseVisualStyleBackColor = True
        '
        'btnChangebike
        '
        Me.btnChangebike.Enabled = False
        Me.btnChangebike.Location = New System.Drawing.Point(100, 395)
        Me.btnChangebike.Name = "btnChangebike"
        Me.btnChangebike.Size = New System.Drawing.Size(83, 23)
        Me.btnChangebike.TabIndex = 171
        Me.btnChangebike.Text = "Endre"
        Me.btnChangebike.UseVisualStyleBackColor = True
        '
        'btnDeletebike
        '
        Me.btnDeletebike.Enabled = False
        Me.btnDeletebike.Location = New System.Drawing.Point(11, 395)
        Me.btnDeletebike.Name = "btnDeletebike"
        Me.btnDeletebike.Size = New System.Drawing.Size(83, 23)
        Me.btnDeletebike.TabIndex = 170
        Me.btnDeletebike.Text = "Slett"
        Me.btnDeletebike.UseVisualStyleBackColor = True
        '
        'btnSearchbike
        '
        Me.btnSearchbike.Location = New System.Drawing.Point(190, 366)
        Me.btnSearchbike.Name = "btnSearchbike"
        Me.btnSearchbike.Size = New System.Drawing.Size(93, 23)
        Me.btnSearchbike.TabIndex = 169
        Me.btnSearchbike.Text = "Søk"
        Me.btnSearchbike.UseVisualStyleBackColor = True
        '
        'btnNewbike
        '
        Me.btnNewbike.Location = New System.Drawing.Point(100, 366)
        Me.btnNewbike.Name = "btnNewbike"
        Me.btnNewbike.Size = New System.Drawing.Size(83, 23)
        Me.btnNewbike.TabIndex = 168
        Me.btnNewbike.Text = "Opprett"
        Me.btnNewbike.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(25, 595)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 17)
        Me.Label26.TabIndex = 167
        Me.Label26.Text = "Kategori"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(25, 567)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 17)
        Me.Label25.TabIndex = 166
        Me.Label25.Text = "Produsent"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(25, 537)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 17)
        Me.Label24.TabIndex = 165
        Me.Label24.Text = "Pris"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(25, 511)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 17)
        Me.Label23.TabIndex = 164
        Me.Label23.Text = "Modell"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Til Reparasjon", "Skal til Reparasjon", "På Lager", "Utleid", "Under Transport"})
        Me.cmbStatus.Location = New System.Drawing.Point(132, 157)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(151, 24)
        Me.cmbStatus.TabIndex = 163
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(132, 43)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(151, 24)
        Me.cmbModel.TabIndex = 162
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "Bremser"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 17)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Gir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Ramme"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Dekk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Utleiested"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Lokasjon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Modell"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Rammenr"
        '
        'txtFramenumber
        '
        Me.txtFramenumber.Location = New System.Drawing.Point(132, 14)
        Me.txtFramenumber.Name = "txtFramenumber"
        Me.txtFramenumber.Size = New System.Drawing.Size(149, 22)
        Me.txtFramenumber.TabIndex = 152
        '
        'dtgvModel
        '
        Me.dtgvModel.AllowUserToAddRows = False
        Me.dtgvModel.AllowUserToDeleteRows = False
        Me.dtgvModel.AllowUserToResizeColumns = False
        Me.dtgvModel.AllowUserToResizeRows = False
        Me.dtgvModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvModel.Location = New System.Drawing.Point(291, 511)
        Me.dtgvModel.MultiSelect = False
        Me.dtgvModel.Name = "dtgvModel"
        Me.dtgvModel.ReadOnly = True
        Me.dtgvModel.RowHeadersVisible = False
        Me.dtgvModel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dtgvModel.RowTemplate.Height = 24
        Me.dtgvModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvModel.Size = New System.Drawing.Size(462, 175)
        Me.dtgvModel.TabIndex = 151
        '
        'dtgvBike
        '
        Me.dtgvBike.AllowUserToAddRows = False
        Me.dtgvBike.AllowUserToDeleteRows = False
        Me.dtgvBike.AllowUserToResizeColumns = False
        Me.dtgvBike.AllowUserToResizeRows = False
        Me.dtgvBike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvBike.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgvBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvBike.Location = New System.Drawing.Point(291, 14)
        Me.dtgvBike.MultiSelect = False
        Me.dtgvBike.Name = "dtgvBike"
        Me.dtgvBike.ReadOnly = True
        Me.dtgvBike.RowHeadersVisible = False
        Me.dtgvBike.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dtgvBike.RowTemplate.Height = 24
        Me.dtgvBike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvBike.Size = New System.Drawing.Size(462, 404)
        Me.dtgvBike.TabIndex = 150
        '
        'StorageWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 723)
        Me.Controls.Add(Me.btnNullmodel)
        Me.Controls.Add(Me.btnNullbike)
        Me.Controls.Add(Me.btnDeletemodel)
        Me.Controls.Add(Me.txtModelcategory)
        Me.Controls.Add(Me.txtModelproducer)
        Me.Controls.Add(Me.txtModelprice)
        Me.Controls.Add(Me.txtModelname)
        Me.Controls.Add(Me.txtBrakes)
        Me.Controls.Add(Me.txtGear)
        Me.Controls.Add(Me.txtFrame)
        Me.Controls.Add(Me.txtTire)
        Me.Controls.Add(Me.txtPointofsale)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProducer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.btnSavemodel)
        Me.Controls.Add(Me.btnChangemodel)
        Me.Controls.Add(Me.btnSearchmodel)
        Me.Controls.Add(Me.btnNewmodel)
        Me.Controls.Add(Me.btnSavebike)
        Me.Controls.Add(Me.btnChangebike)
        Me.Controls.Add(Me.btnDeletebike)
        Me.Controls.Add(Me.btnSearchbike)
        Me.Controls.Add(Me.btnNewbike)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFramenumber)
        Me.Controls.Add(Me.dtgvModel)
        Me.Controls.Add(Me.dtgvBike)
        Me.Name = "StorageWorker"
        Me.Text = "StorageWorker"
        CType(Me.dtgvModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNullmodel As System.Windows.Forms.Button
    Friend WithEvents btnNullbike As System.Windows.Forms.Button
    Friend WithEvents btnDeletemodel As System.Windows.Forms.Button
    Friend WithEvents txtModelcategory As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtModelproducer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtModelprice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtModelname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBrakes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtGear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFrame As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTire As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPointofsale As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLocation As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPrice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCategory As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtProducer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnSavemodel As System.Windows.Forms.Button
    Friend WithEvents btnChangemodel As System.Windows.Forms.Button
    Friend WithEvents btnSearchmodel As System.Windows.Forms.Button
    Friend WithEvents btnNewmodel As System.Windows.Forms.Button
    Friend WithEvents btnSavebike As System.Windows.Forms.Button
    Friend WithEvents btnChangebike As System.Windows.Forms.Button
    Friend WithEvents btnDeletebike As System.Windows.Forms.Button
    Friend WithEvents btnSearchbike As System.Windows.Forms.Button
    Friend WithEvents btnNewbike As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFramenumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtgvModel As System.Windows.Forms.DataGridView
    Friend WithEvents dtgvBike As System.Windows.Forms.DataGridView
End Class
