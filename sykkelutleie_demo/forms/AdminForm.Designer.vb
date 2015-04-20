<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.pnlStatistics = New System.Windows.Forms.Panel()
        Me.LabelFra = New System.Windows.Forms.Label()
        Me.LabelAntall = New System.Windows.Forms.Label()
        Me.LabelDispType = New System.Windows.Forms.Label()
        Me.LabelDispFromDate = New System.Windows.Forms.Label()
        Me.LabelTil = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelDispToDate = New System.Windows.Forms.Label()
        Me.LabelDispAntall = New System.Windows.Forms.Label()
        Me.CmbBxType = New System.Windows.Forms.ComboBox()
        Me.btnAdminSave = New System.Windows.Forms.Button()
        Me.btnAdminReset = New System.Windows.Forms.Button()
        Me.LabelCmbBxType = New System.Windows.Forms.Label()
        Me.cmbbxPosition = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownAntall = New System.Windows.Forms.NumericUpDown()
        Me.grpBxStatisticsMetaData = New System.Windows.Forms.GroupBox()
        Me.LabelCmbBxAntall = New System.Windows.Forms.Label()
        Me.chkBxAllTimeStart = New System.Windows.Forms.CheckBox()
        Me.labelTilSelect = New System.Windows.Forms.Label()
        Me.lblAdminPostnb = New System.Windows.Forms.Label()
        Me.msktxtbxPostnb = New System.Windows.Forms.MaskedTextBox()
        Me.lblAdminPassword = New System.Windows.Forms.Label()
        Me.lblAdminAdress = New System.Windows.Forms.Label()
        Me.msktxtbxPassword = New System.Windows.Forms.MaskedTextBox()
        Me.msktxtbxAdress = New System.Windows.Forms.MaskedTextBox()
        Me.lblAdminTel = New System.Windows.Forms.Label()
        Me.grpBxSelectPeriod = New System.Windows.Forms.GroupBox()
        Me.chkBxAllTimeEnd = New System.Windows.Forms.CheckBox()
        Me.CalendarTo = New System.Windows.Forms.MonthCalendar()
        Me.labelFraSelect = New System.Windows.Forms.Label()
        Me.CalendarFrom = New System.Windows.Forms.MonthCalendar()
        Me.lblAdminUsername = New System.Windows.Forms.Label()
        Me.msktxtbxUsername = New System.Windows.Forms.MaskedTextBox()
        Me.lblAdminEpost = New System.Windows.Forms.Label()
        Me.lblAdminPostplace = New System.Windows.Forms.Label()
        Me.msktxtbxPostplace = New System.Windows.Forms.MaskedTextBox()
        Me.msktxtbxEpost = New System.Windows.Forms.MaskedTextBox()
        Me.lblAdminPosition = New System.Windows.Forms.Label()
        Me.lblAdminLname = New System.Windows.Forms.Label()
        Me.msktxtbxTlf = New System.Windows.Forms.MaskedTextBox()
        Me.msktxtbxLname = New System.Windows.Forms.MaskedTextBox()
        Me.cmbbxUsers = New System.Windows.Forms.ComboBox()
        Me.btnAdminCreate = New System.Windows.Forms.Button()
        Me.lblAdminEmployee = New System.Windows.Forms.Label()
        Me.BtnEndApplication = New System.Windows.Forms.Button()
        Me.btnAdminDelete = New System.Windows.Forms.Button()
        Me.btnAdminEdit = New System.Windows.Forms.Button()
        Me.grpbxAdminUserAccount = New System.Windows.Forms.GroupBox()
        Me.lblAdminFname = New System.Windows.Forms.Label()
        Me.msktxtbxFname = New System.Windows.Forms.MaskedTextBox()
        Me.lblAdminEmployeeID = New System.Windows.Forms.Label()
        Me.msktxtbxID = New System.Windows.Forms.MaskedTextBox()
        Me.grpBxStatistic = New System.Windows.Forms.GroupBox()
        Me.btnDisplayStatistics = New System.Windows.Forms.Button()
        Me.btnEmployeeTestOpen = New System.Windows.Forms.Button()
        Me.pnlStatistics.SuspendLayout()
        CType(Me.NumericUpDownAntall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBxStatisticsMetaData.SuspendLayout()
        Me.grpBxSelectPeriod.SuspendLayout()
        Me.grpbxAdminUserAccount.SuspendLayout()
        Me.grpBxStatistic.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStatistics
        '
        Me.pnlStatistics.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlStatistics.Controls.Add(Me.LabelFra)
        Me.pnlStatistics.Controls.Add(Me.LabelAntall)
        Me.pnlStatistics.Controls.Add(Me.LabelDispType)
        Me.pnlStatistics.Controls.Add(Me.LabelDispFromDate)
        Me.pnlStatistics.Controls.Add(Me.LabelTil)
        Me.pnlStatistics.Controls.Add(Me.LabelType)
        Me.pnlStatistics.Controls.Add(Me.LabelDispToDate)
        Me.pnlStatistics.Controls.Add(Me.LabelDispAntall)
        Me.pnlStatistics.Location = New System.Drawing.Point(82, 367)
        Me.pnlStatistics.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlStatistics.Name = "pnlStatistics"
        Me.pnlStatistics.Size = New System.Drawing.Size(190, 116)
        Me.pnlStatistics.TabIndex = 6
        '
        'LabelFra
        '
        Me.LabelFra.AutoSize = True
        Me.LabelFra.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelFra.Location = New System.Drawing.Point(22, 13)
        Me.LabelFra.Name = "LabelFra"
        Me.LabelFra.Size = New System.Drawing.Size(25, 13)
        Me.LabelFra.TabIndex = 12
        Me.LabelFra.Text = "Fra:"
        '
        'LabelAntall
        '
        Me.LabelAntall.AutoSize = True
        Me.LabelAntall.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAntall.Location = New System.Drawing.Point(22, 91)
        Me.LabelAntall.Name = "LabelAntall"
        Me.LabelAntall.Size = New System.Drawing.Size(36, 13)
        Me.LabelAntall.TabIndex = 18
        Me.LabelAntall.Text = "Antall:"
        '
        'LabelDispType
        '
        Me.LabelDispType.AutoSize = True
        Me.LabelDispType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispType.Location = New System.Drawing.Point(84, 65)
        Me.LabelDispType.Name = "LabelDispType"
        Me.LabelDispType.Size = New System.Drawing.Size(88, 13)
        Me.LabelDispType.TabIndex = 17
        Me.LabelDispType.Text = "Mest leide sykkel"
        '
        'LabelDispFromDate
        '
        Me.LabelDispFromDate.AutoSize = True
        Me.LabelDispFromDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispFromDate.Location = New System.Drawing.Point(84, 13)
        Me.LabelDispFromDate.Name = "LabelDispFromDate"
        Me.LabelDispFromDate.Size = New System.Drawing.Size(82, 13)
        Me.LabelDispFromDate.TabIndex = 13
        Me.LabelDispFromDate.Text = "6. Februar 2015"
        '
        'LabelTil
        '
        Me.LabelTil.AutoSize = True
        Me.LabelTil.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTil.Location = New System.Drawing.Point(22, 39)
        Me.LabelTil.Name = "LabelTil"
        Me.LabelTil.Size = New System.Drawing.Size(21, 13)
        Me.LabelTil.TabIndex = 14
        Me.LabelTil.Text = "Til:"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelType.Location = New System.Drawing.Point(22, 65)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(34, 13)
        Me.LabelType.TabIndex = 16
        Me.LabelType.Text = "Type:"
        '
        'LabelDispToDate
        '
        Me.LabelDispToDate.AutoSize = True
        Me.LabelDispToDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispToDate.Location = New System.Drawing.Point(84, 39)
        Me.LabelDispToDate.Name = "LabelDispToDate"
        Me.LabelDispToDate.Size = New System.Drawing.Size(88, 13)
        Me.LabelDispToDate.TabIndex = 15
        Me.LabelDispToDate.Text = "20. Februar 2015"
        '
        'LabelDispAntall
        '
        Me.LabelDispAntall.AutoSize = True
        Me.LabelDispAntall.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispAntall.Location = New System.Drawing.Point(84, 91)
        Me.LabelDispAntall.Name = "LabelDispAntall"
        Me.LabelDispAntall.Size = New System.Drawing.Size(19, 13)
        Me.LabelDispAntall.TabIndex = 19
        Me.LabelDispAntall.Text = "10"
        '
        'CmbBxType
        '
        Me.CmbBxType.FormattingEnabled = True
        Me.CmbBxType.Items.AddRange(New Object() {"Billigste sykkel", "Dyreste sykkel", "Avanse", "Mest populære sykler", "Minst populære sykler", "Mest aktive selger", "Minst aktive selger", "Antall bestillinger"})
        Me.CmbBxType.Location = New System.Drawing.Point(23, 54)
        Me.CmbBxType.Name = "CmbBxType"
        Me.CmbBxType.Size = New System.Drawing.Size(121, 21)
        Me.CmbBxType.TabIndex = 5
        Me.CmbBxType.Text = "Billigste sykkel"
        '
        'btnAdminSave
        '
        Me.btnAdminSave.Enabled = False
        Me.btnAdminSave.Location = New System.Drawing.Point(437, 332)
        Me.btnAdminSave.Name = "btnAdminSave"
        Me.btnAdminSave.Size = New System.Drawing.Size(131, 37)
        Me.btnAdminSave.TabIndex = 57
        Me.btnAdminSave.Text = "Lagre endringer"
        Me.btnAdminSave.UseVisualStyleBackColor = True
        '
        'btnAdminReset
        '
        Me.btnAdminReset.Enabled = False
        Me.btnAdminReset.Location = New System.Drawing.Point(161, 332)
        Me.btnAdminReset.Name = "btnAdminReset"
        Me.btnAdminReset.Size = New System.Drawing.Size(131, 37)
        Me.btnAdminReset.TabIndex = 58
        Me.btnAdminReset.Text = "Tøm felter"
        Me.btnAdminReset.UseVisualStyleBackColor = True
        '
        'LabelCmbBxType
        '
        Me.LabelCmbBxType.AutoSize = True
        Me.LabelCmbBxType.Location = New System.Drawing.Point(58, 30)
        Me.LabelCmbBxType.Name = "LabelCmbBxType"
        Me.LabelCmbBxType.Size = New System.Drawing.Size(31, 13)
        Me.LabelCmbBxType.TabIndex = 6
        Me.LabelCmbBxType.Text = "Type"
        '
        'cmbbxPosition
        '
        Me.cmbbxPosition.Enabled = False
        Me.cmbbxPosition.FormattingEnabled = True
        Me.cmbbxPosition.Items.AddRange(New Object() {"Selger", "Administrator", "Lagerarbeider"})
        Me.cmbbxPosition.Location = New System.Drawing.Point(372, 262)
        Me.cmbbxPosition.Name = "cmbbxPosition"
        Me.cmbbxPosition.Size = New System.Drawing.Size(178, 21)
        Me.cmbbxPosition.TabIndex = 36
        '
        'NumericUpDownAntall
        '
        Me.NumericUpDownAntall.Location = New System.Drawing.Point(179, 56)
        Me.NumericUpDownAntall.Name = "NumericUpDownAntall"
        Me.NumericUpDownAntall.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownAntall.TabIndex = 10
        '
        'grpBxStatisticsMetaData
        '
        Me.grpBxStatisticsMetaData.Controls.Add(Me.NumericUpDownAntall)
        Me.grpBxStatisticsMetaData.Controls.Add(Me.LabelCmbBxAntall)
        Me.grpBxStatisticsMetaData.Controls.Add(Me.LabelCmbBxType)
        Me.grpBxStatisticsMetaData.Controls.Add(Me.CmbBxType)
        Me.grpBxStatisticsMetaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpBxStatisticsMetaData.Location = New System.Drawing.Point(12, 247)
        Me.grpBxStatisticsMetaData.Name = "grpBxStatisticsMetaData"
        Me.grpBxStatisticsMetaData.Size = New System.Drawing.Size(344, 109)
        Me.grpBxStatisticsMetaData.TabIndex = 11
        Me.grpBxStatisticsMetaData.TabStop = False
        Me.grpBxStatisticsMetaData.Text = "Velg data"
        '
        'LabelCmbBxAntall
        '
        Me.LabelCmbBxAntall.AutoSize = True
        Me.LabelCmbBxAntall.Location = New System.Drawing.Point(218, 30)
        Me.LabelCmbBxAntall.Name = "LabelCmbBxAntall"
        Me.LabelCmbBxAntall.Size = New System.Drawing.Size(33, 13)
        Me.LabelCmbBxAntall.TabIndex = 8
        Me.LabelCmbBxAntall.Text = "Antall"
        '
        'chkBxAllTimeStart
        '
        Me.chkBxAllTimeStart.AutoSize = True
        Me.chkBxAllTimeStart.Checked = True
        Me.chkBxAllTimeStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBxAllTimeStart.Location = New System.Drawing.Point(70, 20)
        Me.chkBxAllTimeStart.Name = "chkBxAllTimeStart"
        Me.chkBxAllTimeStart.Size = New System.Drawing.Size(102, 17)
        Me.chkBxAllTimeStart.TabIndex = 11
        Me.chkBxAllTimeStart.Text = "Tidenes morgen"
        Me.chkBxAllTimeStart.UseVisualStyleBackColor = True
        '
        'labelTilSelect
        '
        Me.labelTilSelect.AutoSize = True
        Me.labelTilSelect.Location = New System.Drawing.Point(186, 20)
        Me.labelTilSelect.Name = "labelTilSelect"
        Me.labelTilSelect.Size = New System.Drawing.Size(18, 13)
        Me.labelTilSelect.TabIndex = 10
        Me.labelTilSelect.Text = "Til"
        '
        'lblAdminPostnb
        '
        Me.lblAdminPostnb.AutoSize = True
        Me.lblAdminPostnb.Location = New System.Drawing.Point(296, 158)
        Me.lblAdminPostnb.Name = "lblAdminPostnb"
        Me.lblAdminPostnb.Size = New System.Drawing.Size(68, 13)
        Me.lblAdminPostnb.TabIndex = 50
        Me.lblAdminPostnb.Text = "Postnummer:"
        '
        'msktxtbxPostnb
        '
        Me.msktxtbxPostnb.Enabled = False
        Me.msktxtbxPostnb.Location = New System.Drawing.Point(372, 157)
        Me.msktxtbxPostnb.Mask = "0000"
        Me.msktxtbxPostnb.Name = "msktxtbxPostnb"
        Me.msktxtbxPostnb.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxPostnb.TabIndex = 49
        '
        'lblAdminPassword
        '
        Me.lblAdminPassword.AutoSize = True
        Me.lblAdminPassword.Location = New System.Drawing.Point(31, 270)
        Me.lblAdminPassword.Name = "lblAdminPassword"
        Me.lblAdminPassword.Size = New System.Drawing.Size(48, 13)
        Me.lblAdminPassword.TabIndex = 56
        Me.lblAdminPassword.Text = "Passord:"
        '
        'lblAdminAdress
        '
        Me.lblAdminAdress.AutoSize = True
        Me.lblAdminAdress.Location = New System.Drawing.Point(296, 124)
        Me.lblAdminAdress.Name = "lblAdminAdress"
        Me.lblAdminAdress.Size = New System.Drawing.Size(74, 13)
        Me.lblAdminAdress.TabIndex = 48
        Me.lblAdminAdress.Text = "Gate Adresse:"
        '
        'msktxtbxPassword
        '
        Me.msktxtbxPassword.Enabled = False
        Me.msktxtbxPassword.Location = New System.Drawing.Point(106, 266)
        Me.msktxtbxPassword.Name = "msktxtbxPassword"
        Me.msktxtbxPassword.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxPassword.TabIndex = 55
        '
        'msktxtbxAdress
        '
        Me.msktxtbxAdress.Enabled = False
        Me.msktxtbxAdress.Location = New System.Drawing.Point(372, 122)
        Me.msktxtbxAdress.Name = "msktxtbxAdress"
        Me.msktxtbxAdress.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxAdress.TabIndex = 47
        '
        'lblAdminTel
        '
        Me.lblAdminTel.AutoSize = True
        Me.lblAdminTel.Location = New System.Drawing.Point(296, 89)
        Me.lblAdminTel.Name = "lblAdminTel"
        Me.lblAdminTel.Size = New System.Drawing.Size(46, 13)
        Me.lblAdminTel.TabIndex = 46
        Me.lblAdminTel.Text = "Telefon:"
        '
        'grpBxSelectPeriod
        '
        Me.grpBxSelectPeriod.Controls.Add(Me.chkBxAllTimeEnd)
        Me.grpBxSelectPeriod.Controls.Add(Me.chkBxAllTimeStart)
        Me.grpBxSelectPeriod.Controls.Add(Me.labelTilSelect)
        Me.grpBxSelectPeriod.Controls.Add(Me.CalendarTo)
        Me.grpBxSelectPeriod.Controls.Add(Me.labelFraSelect)
        Me.grpBxSelectPeriod.Controls.Add(Me.CalendarFrom)
        Me.grpBxSelectPeriod.Location = New System.Drawing.Point(12, 20)
        Me.grpBxSelectPeriod.Name = "grpBxSelectPeriod"
        Me.grpBxSelectPeriod.Size = New System.Drawing.Size(344, 221)
        Me.grpBxSelectPeriod.TabIndex = 7
        Me.grpBxSelectPeriod.TabStop = False
        Me.grpBxSelectPeriod.Text = "Velg periode"
        '
        'chkBxAllTimeEnd
        '
        Me.chkBxAllTimeEnd.AutoSize = True
        Me.chkBxAllTimeEnd.Checked = True
        Me.chkBxAllTimeEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBxAllTimeEnd.Location = New System.Drawing.Point(210, 20)
        Me.chkBxAllTimeEnd.Name = "chkBxAllTimeEnd"
        Me.chkBxAllTimeEnd.Size = New System.Drawing.Size(76, 17)
        Me.chkBxAllTimeEnd.TabIndex = 12
        Me.chkBxAllTimeEnd.Text = "End Times"
        Me.chkBxAllTimeEnd.UseVisualStyleBackColor = True
        '
        'CalendarTo
        '
        Me.CalendarTo.Location = New System.Drawing.Point(179, 41)
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
        Me.CalendarFrom.Location = New System.Drawing.Point(12, 41)
        Me.CalendarFrom.Name = "CalendarFrom"
        Me.CalendarFrom.TabIndex = 7
        '
        'lblAdminUsername
        '
        Me.lblAdminUsername.AutoSize = True
        Me.lblAdminUsername.Location = New System.Drawing.Point(31, 233)
        Me.lblAdminUsername.Name = "lblAdminUsername"
        Me.lblAdminUsername.Size = New System.Drawing.Size(65, 13)
        Me.lblAdminUsername.TabIndex = 54
        Me.lblAdminUsername.Text = "Brukernavn:"
        '
        'msktxtbxUsername
        '
        Me.msktxtbxUsername.Enabled = False
        Me.msktxtbxUsername.Location = New System.Drawing.Point(106, 231)
        Me.msktxtbxUsername.Name = "msktxtbxUsername"
        Me.msktxtbxUsername.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxUsername.TabIndex = 53
        '
        'lblAdminEpost
        '
        Me.lblAdminEpost.AutoSize = True
        Me.lblAdminEpost.Location = New System.Drawing.Point(296, 228)
        Me.lblAdminEpost.Name = "lblAdminEpost"
        Me.lblAdminEpost.Size = New System.Drawing.Size(37, 13)
        Me.lblAdminEpost.TabIndex = 44
        Me.lblAdminEpost.Text = "Epost:"
        '
        'lblAdminPostplace
        '
        Me.lblAdminPostplace.AutoSize = True
        Me.lblAdminPostplace.Location = New System.Drawing.Point(296, 193)
        Me.lblAdminPostplace.Name = "lblAdminPostplace"
        Me.lblAdminPostplace.Size = New System.Drawing.Size(51, 13)
        Me.lblAdminPostplace.TabIndex = 52
        Me.lblAdminPostplace.Text = "Poststed:"
        '
        'msktxtbxPostplace
        '
        Me.msktxtbxPostplace.Enabled = False
        Me.msktxtbxPostplace.Location = New System.Drawing.Point(372, 192)
        Me.msktxtbxPostplace.Name = "msktxtbxPostplace"
        Me.msktxtbxPostplace.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxPostplace.TabIndex = 51
        '
        'msktxtbxEpost
        '
        Me.msktxtbxEpost.Enabled = False
        Me.msktxtbxEpost.Location = New System.Drawing.Point(373, 227)
        Me.msktxtbxEpost.Name = "msktxtbxEpost"
        Me.msktxtbxEpost.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxEpost.TabIndex = 43
        '
        'lblAdminPosition
        '
        Me.lblAdminPosition.AutoSize = True
        Me.lblAdminPosition.Location = New System.Drawing.Point(296, 263)
        Me.lblAdminPosition.Name = "lblAdminPosition"
        Me.lblAdminPosition.Size = New System.Drawing.Size(40, 13)
        Me.lblAdminPosition.TabIndex = 42
        Me.lblAdminPosition.Text = "Stilling:"
        '
        'lblAdminLname
        '
        Me.lblAdminLname.AutoSize = True
        Me.lblAdminLname.Location = New System.Drawing.Point(31, 197)
        Me.lblAdminLname.Name = "lblAdminLname"
        Me.lblAdminLname.Size = New System.Drawing.Size(56, 13)
        Me.lblAdminLname.TabIndex = 41
        Me.lblAdminLname.Text = "Etternavn:"
        '
        'msktxtbxTlf
        '
        Me.msktxtbxTlf.Enabled = False
        Me.msktxtbxTlf.Location = New System.Drawing.Point(372, 87)
        Me.msktxtbxTlf.Mask = "000 00 000"
        Me.msktxtbxTlf.Name = "msktxtbxTlf"
        Me.msktxtbxTlf.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxTlf.TabIndex = 45
        '
        'msktxtbxLname
        '
        Me.msktxtbxLname.Enabled = False
        Me.msktxtbxLname.Location = New System.Drawing.Point(107, 195)
        Me.msktxtbxLname.Name = "msktxtbxLname"
        Me.msktxtbxLname.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxLname.TabIndex = 40
        '
        'cmbbxUsers
        '
        Me.cmbbxUsers.FormattingEnabled = True
        Me.cmbbxUsers.Items.AddRange(New Object() {"Kjell Hansen", "Stig Ofstad", "Duane Henriksen", "Kristoffer Pedersen"})
        Me.cmbbxUsers.Location = New System.Drawing.Point(106, 86)
        Me.cmbbxUsers.Name = "cmbbxUsers"
        Me.cmbbxUsers.Size = New System.Drawing.Size(178, 21)
        Me.cmbbxUsers.TabIndex = 6
        '
        'btnAdminCreate
        '
        Me.btnAdminCreate.Location = New System.Drawing.Point(300, 19)
        Me.btnAdminCreate.Name = "btnAdminCreate"
        Me.btnAdminCreate.Size = New System.Drawing.Size(131, 37)
        Me.btnAdminCreate.TabIndex = 31
        Me.btnAdminCreate.Text = "Opprett ny"
        Me.btnAdminCreate.UseVisualStyleBackColor = True
        '
        'lblAdminEmployee
        '
        Me.lblAdminEmployee.AutoSize = True
        Me.lblAdminEmployee.Location = New System.Drawing.Point(31, 87)
        Me.lblAdminEmployee.Name = "lblAdminEmployee"
        Me.lblAdminEmployee.Size = New System.Drawing.Size(40, 13)
        Me.lblAdminEmployee.TabIndex = 5
        Me.lblAdminEmployee.Text = "Ansatt:"
        '
        'BtnEndApplication
        '
        Me.BtnEndApplication.Location = New System.Drawing.Point(120, 529)
        Me.BtnEndApplication.Name = "BtnEndApplication"
        Me.BtnEndApplication.Size = New System.Drawing.Size(94, 23)
        Me.BtnEndApplication.TabIndex = 6
        Me.BtnEndApplication.Text = "Avslutt"
        Me.BtnEndApplication.UseVisualStyleBackColor = True
        '
        'btnAdminDelete
        '
        Me.btnAdminDelete.Enabled = False
        Me.btnAdminDelete.Location = New System.Drawing.Point(437, 19)
        Me.btnAdminDelete.Name = "btnAdminDelete"
        Me.btnAdminDelete.Size = New System.Drawing.Size(131, 37)
        Me.btnAdminDelete.TabIndex = 32
        Me.btnAdminDelete.Text = "Slett"
        Me.btnAdminDelete.UseVisualStyleBackColor = True
        '
        'btnAdminEdit
        '
        Me.btnAdminEdit.Enabled = False
        Me.btnAdminEdit.Location = New System.Drawing.Point(300, 332)
        Me.btnAdminEdit.Name = "btnAdminEdit"
        Me.btnAdminEdit.Size = New System.Drawing.Size(131, 37)
        Me.btnAdminEdit.TabIndex = 33
        Me.btnAdminEdit.Text = "Rediger"
        Me.btnAdminEdit.UseVisualStyleBackColor = True
        '
        'grpbxAdminUserAccount
        '
        Me.grpbxAdminUserAccount.Controls.Add(Me.btnAdminSave)
        Me.grpbxAdminUserAccount.Controls.Add(Me.btnAdminReset)
        Me.grpbxAdminUserAccount.Controls.Add(Me.cmbbxPosition)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminPostnb)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxPostnb)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminPassword)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminAdress)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxPassword)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxAdress)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminTel)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminUsername)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxUsername)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxTlf)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminEpost)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminPostplace)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxPostplace)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxEpost)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminPosition)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminLname)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxLname)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminFname)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxFname)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminEmployeeID)
        Me.grpbxAdminUserAccount.Controls.Add(Me.msktxtbxID)
        Me.grpbxAdminUserAccount.Controls.Add(Me.btnAdminDelete)
        Me.grpbxAdminUserAccount.Controls.Add(Me.btnAdminEdit)
        Me.grpbxAdminUserAccount.Controls.Add(Me.cmbbxUsers)
        Me.grpbxAdminUserAccount.Controls.Add(Me.btnAdminCreate)
        Me.grpbxAdminUserAccount.Controls.Add(Me.lblAdminEmployee)
        Me.grpbxAdminUserAccount.Location = New System.Drawing.Point(10, 110)
        Me.grpbxAdminUserAccount.Name = "grpbxAdminUserAccount"
        Me.grpbxAdminUserAccount.Size = New System.Drawing.Size(581, 387)
        Me.grpbxAdminUserAccount.TabIndex = 7
        Me.grpbxAdminUserAccount.TabStop = False
        Me.grpbxAdminUserAccount.Text = "Brukerkontoer"
        '
        'lblAdminFname
        '
        Me.lblAdminFname.AutoSize = True
        Me.lblAdminFname.Location = New System.Drawing.Point(31, 160)
        Me.lblAdminFname.Name = "lblAdminFname"
        Me.lblAdminFname.Size = New System.Drawing.Size(49, 13)
        Me.lblAdminFname.TabIndex = 39
        Me.lblAdminFname.Text = "Fornavn:"
        '
        'msktxtbxFname
        '
        Me.msktxtbxFname.Enabled = False
        Me.msktxtbxFname.Location = New System.Drawing.Point(106, 159)
        Me.msktxtbxFname.Name = "msktxtbxFname"
        Me.msktxtbxFname.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxFname.TabIndex = 38
        '
        'lblAdminEmployeeID
        '
        Me.lblAdminEmployeeID.AutoSize = True
        Me.lblAdminEmployeeID.Location = New System.Drawing.Point(31, 124)
        Me.lblAdminEmployeeID.Name = "lblAdminEmployeeID"
        Me.lblAdminEmployeeID.Size = New System.Drawing.Size(77, 13)
        Me.lblAdminEmployeeID.TabIndex = 37
        Me.lblAdminEmployeeID.Text = "Ansattnummer:"
        '
        'msktxtbxID
        '
        Me.msktxtbxID.Enabled = False
        Me.msktxtbxID.Location = New System.Drawing.Point(106, 124)
        Me.msktxtbxID.Mask = "0000"
        Me.msktxtbxID.Name = "msktxtbxID"
        Me.msktxtbxID.Size = New System.Drawing.Size(178, 20)
        Me.msktxtbxID.TabIndex = 35
        '
        'grpBxStatistic
        '
        Me.grpBxStatistic.Controls.Add(Me.grpBxSelectPeriod)
        Me.grpBxStatistic.Controls.Add(Me.grpBxStatisticsMetaData)
        Me.grpBxStatistic.Controls.Add(Me.BtnEndApplication)
        Me.grpBxStatistic.Controls.Add(Me.btnDisplayStatistics)
        Me.grpBxStatistic.Controls.Add(Me.pnlStatistics)
        Me.grpBxStatistic.Location = New System.Drawing.Point(626, 20)
        Me.grpBxStatistic.Name = "grpBxStatistic"
        Me.grpBxStatistic.Size = New System.Drawing.Size(362, 566)
        Me.grpBxStatistic.TabIndex = 6
        Me.grpBxStatistic.TabStop = False
        Me.grpBxStatistic.Text = "Statistikk"
        '
        'btnDisplayStatistics
        '
        Me.btnDisplayStatistics.Location = New System.Drawing.Point(120, 500)
        Me.btnDisplayStatistics.Name = "btnDisplayStatistics"
        Me.btnDisplayStatistics.Size = New System.Drawing.Size(94, 23)
        Me.btnDisplayStatistics.TabIndex = 0
        Me.btnDisplayStatistics.Text = "Vis Statistikk"
        Me.btnDisplayStatistics.UseVisualStyleBackColor = True
        '
        'btnEmployeeTestOpen
        '
        Me.btnEmployeeTestOpen.Location = New System.Drawing.Point(25, 20)
        Me.btnEmployeeTestOpen.Name = "btnEmployeeTestOpen"
        Me.btnEmployeeTestOpen.Size = New System.Drawing.Size(101, 53)
        Me.btnEmployeeTestOpen.TabIndex = 8
        Me.btnEmployeeTestOpen.Text = "Gå til administrasjon av brukerkontoer"
        Me.btnEmployeeTestOpen.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 603)
        Me.Controls.Add(Me.btnEmployeeTestOpen)
        Me.Controls.Add(Me.grpbxAdminUserAccount)
        Me.Controls.Add(Me.grpBxStatistic)
        Me.MaximumSize = New System.Drawing.Size(1365, 767)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlStatistics.ResumeLayout(False)
        Me.pnlStatistics.PerformLayout()
        CType(Me.NumericUpDownAntall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBxStatisticsMetaData.ResumeLayout(False)
        Me.grpBxStatisticsMetaData.PerformLayout()
        Me.grpBxSelectPeriod.ResumeLayout(False)
        Me.grpBxSelectPeriod.PerformLayout()
        Me.grpbxAdminUserAccount.ResumeLayout(False)
        Me.grpbxAdminUserAccount.PerformLayout()
        Me.grpBxStatistic.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlStatistics As System.Windows.Forms.Panel
    Friend WithEvents LabelFra As System.Windows.Forms.Label
    Friend WithEvents LabelAntall As System.Windows.Forms.Label
    Friend WithEvents LabelDispType As System.Windows.Forms.Label
    Friend WithEvents LabelDispFromDate As System.Windows.Forms.Label
    Friend WithEvents LabelTil As System.Windows.Forms.Label
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents LabelDispToDate As System.Windows.Forms.Label
    Friend WithEvents LabelDispAntall As System.Windows.Forms.Label
    Friend WithEvents CmbBxType As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdminSave As System.Windows.Forms.Button
    Friend WithEvents btnAdminReset As System.Windows.Forms.Button
    Friend WithEvents LabelCmbBxType As System.Windows.Forms.Label
    Friend WithEvents cmbbxPosition As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDownAntall As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpBxStatisticsMetaData As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCmbBxAntall As System.Windows.Forms.Label
    Friend WithEvents chkBxAllTimeStart As System.Windows.Forms.CheckBox
    Friend WithEvents labelTilSelect As System.Windows.Forms.Label
    Friend WithEvents lblAdminPostnb As System.Windows.Forms.Label
    Friend WithEvents msktxtbxPostnb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAdminPassword As System.Windows.Forms.Label
    Friend WithEvents lblAdminAdress As System.Windows.Forms.Label
    Friend WithEvents msktxtbxPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxtbxAdress As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAdminTel As System.Windows.Forms.Label
    Friend WithEvents grpBxSelectPeriod As System.Windows.Forms.GroupBox
    Friend WithEvents chkBxAllTimeEnd As System.Windows.Forms.CheckBox
    Friend WithEvents CalendarTo As System.Windows.Forms.MonthCalendar
    Friend WithEvents labelFraSelect As System.Windows.Forms.Label
    Friend WithEvents CalendarFrom As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblAdminUsername As System.Windows.Forms.Label
    Friend WithEvents msktxtbxUsername As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAdminEpost As System.Windows.Forms.Label
    Friend WithEvents lblAdminPostplace As System.Windows.Forms.Label
    Friend WithEvents msktxtbxPostplace As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxtbxEpost As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAdminPosition As System.Windows.Forms.Label
    Friend WithEvents lblAdminLname As System.Windows.Forms.Label
    Friend WithEvents msktxtbxTlf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxtbxLname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbbxUsers As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdminCreate As System.Windows.Forms.Button
    Friend WithEvents lblAdminEmployee As System.Windows.Forms.Label
    Friend WithEvents BtnEndApplication As System.Windows.Forms.Button
    Friend WithEvents btnAdminDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdminEdit As System.Windows.Forms.Button
    Friend WithEvents grpbxAdminUserAccount As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdminFname As System.Windows.Forms.Label
    Friend WithEvents msktxtbxFname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAdminEmployeeID As System.Windows.Forms.Label
    Friend WithEvents msktxtbxID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpBxStatistic As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisplayStatistics As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeTestOpen As System.Windows.Forms.Button
End Class
