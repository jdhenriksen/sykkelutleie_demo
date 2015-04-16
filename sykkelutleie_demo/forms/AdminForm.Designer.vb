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
        Me.pnlStatistics.Location = New System.Drawing.Point(109, 452)
        Me.pnlStatistics.Name = "pnlStatistics"
        Me.pnlStatistics.Size = New System.Drawing.Size(253, 143)
        Me.pnlStatistics.TabIndex = 6
        '
        'LabelFra
        '
        Me.LabelFra.AutoSize = True
        Me.LabelFra.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelFra.Location = New System.Drawing.Point(29, 16)
        Me.LabelFra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFra.Name = "LabelFra"
        Me.LabelFra.Size = New System.Drawing.Size(33, 17)
        Me.LabelFra.TabIndex = 12
        Me.LabelFra.Text = "Fra:"
        '
        'LabelAntall
        '
        Me.LabelAntall.AutoSize = True
        Me.LabelAntall.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAntall.Location = New System.Drawing.Point(29, 112)
        Me.LabelAntall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAntall.Name = "LabelAntall"
        Me.LabelAntall.Size = New System.Drawing.Size(47, 17)
        Me.LabelAntall.TabIndex = 18
        Me.LabelAntall.Text = "Antall:"
        '
        'LabelDispType
        '
        Me.LabelDispType.AutoSize = True
        Me.LabelDispType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispType.Location = New System.Drawing.Point(112, 80)
        Me.LabelDispType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDispType.Name = "LabelDispType"
        Me.LabelDispType.Size = New System.Drawing.Size(115, 17)
        Me.LabelDispType.TabIndex = 17
        Me.LabelDispType.Text = "Mest leide sykkel"
        '
        'LabelDispFromDate
        '
        Me.LabelDispFromDate.AutoSize = True
        Me.LabelDispFromDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispFromDate.Location = New System.Drawing.Point(112, 16)
        Me.LabelDispFromDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDispFromDate.Name = "LabelDispFromDate"
        Me.LabelDispFromDate.Size = New System.Drawing.Size(110, 17)
        Me.LabelDispFromDate.TabIndex = 13
        Me.LabelDispFromDate.Text = "6. Februar 2015"
        '
        'LabelTil
        '
        Me.LabelTil.AutoSize = True
        Me.LabelTil.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTil.Location = New System.Drawing.Point(29, 48)
        Me.LabelTil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTil.Name = "LabelTil"
        Me.LabelTil.Size = New System.Drawing.Size(27, 17)
        Me.LabelTil.TabIndex = 14
        Me.LabelTil.Text = "Til:"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelType.Location = New System.Drawing.Point(29, 80)
        Me.LabelType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(44, 17)
        Me.LabelType.TabIndex = 16
        Me.LabelType.Text = "Type:"
        '
        'LabelDispToDate
        '
        Me.LabelDispToDate.AutoSize = True
        Me.LabelDispToDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispToDate.Location = New System.Drawing.Point(112, 48)
        Me.LabelDispToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDispToDate.Name = "LabelDispToDate"
        Me.LabelDispToDate.Size = New System.Drawing.Size(118, 17)
        Me.LabelDispToDate.TabIndex = 15
        Me.LabelDispToDate.Text = "20. Februar 2015"
        '
        'LabelDispAntall
        '
        Me.LabelDispAntall.AutoSize = True
        Me.LabelDispAntall.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDispAntall.Location = New System.Drawing.Point(112, 112)
        Me.LabelDispAntall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDispAntall.Name = "LabelDispAntall"
        Me.LabelDispAntall.Size = New System.Drawing.Size(24, 17)
        Me.LabelDispAntall.TabIndex = 19
        Me.LabelDispAntall.Text = "10"
        '
        'CmbBxType
        '
        Me.CmbBxType.FormattingEnabled = True
        Me.CmbBxType.Items.AddRange(New Object() {"Billigste sykkel", "Dyreste sykkel", "Avanse", "Mest populære sykler", "Minst populære sykler", "Mest aktive selger", "Minst aktive selger", "Antall bestillinger"})
        Me.CmbBxType.Location = New System.Drawing.Point(31, 67)
        Me.CmbBxType.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBxType.Name = "CmbBxType"
        Me.CmbBxType.Size = New System.Drawing.Size(160, 24)
        Me.CmbBxType.TabIndex = 5
        Me.CmbBxType.Text = "Billigste sykkel"
        '
        'btnAdminSave
        '
        Me.btnAdminSave.Enabled = False
        Me.btnAdminSave.Location = New System.Drawing.Point(583, 408)
        Me.btnAdminSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminSave.Name = "btnAdminSave"
        Me.btnAdminSave.Size = New System.Drawing.Size(175, 45)
        Me.btnAdminSave.TabIndex = 57
        Me.btnAdminSave.Text = "Lagre endringer"
        Me.btnAdminSave.UseVisualStyleBackColor = True
        '
        'btnAdminReset
        '
        Me.btnAdminReset.Enabled = False
        Me.btnAdminReset.Location = New System.Drawing.Point(215, 408)
        Me.btnAdminReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminReset.Name = "btnAdminReset"
        Me.btnAdminReset.Size = New System.Drawing.Size(175, 45)
        Me.btnAdminReset.TabIndex = 58
        Me.btnAdminReset.Text = "Tøm felter"
        Me.btnAdminReset.UseVisualStyleBackColor = True
        '
        'LabelCmbBxType
        '
        Me.LabelCmbBxType.AutoSize = True
        Me.LabelCmbBxType.Location = New System.Drawing.Point(78, 37)
        Me.LabelCmbBxType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCmbBxType.Name = "LabelCmbBxType"
        Me.LabelCmbBxType.Size = New System.Drawing.Size(40, 17)
        Me.LabelCmbBxType.TabIndex = 6
        Me.LabelCmbBxType.Text = "Type"
        '
        'cmbbxPosition
        '
        Me.cmbbxPosition.Enabled = False
        Me.cmbbxPosition.FormattingEnabled = True
        Me.cmbbxPosition.Items.AddRange(New Object() {"Selger", "Administrator", "Lagerarbeider"})
        Me.cmbbxPosition.Location = New System.Drawing.Point(496, 322)
        Me.cmbbxPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbbxPosition.Name = "cmbbxPosition"
        Me.cmbbxPosition.Size = New System.Drawing.Size(236, 24)
        Me.cmbbxPosition.TabIndex = 36
        '
        'NumericUpDownAntall
        '
        Me.NumericUpDownAntall.Location = New System.Drawing.Point(239, 69)
        Me.NumericUpDownAntall.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownAntall.Name = "NumericUpDownAntall"
        Me.NumericUpDownAntall.Size = New System.Drawing.Size(160, 22)
        Me.NumericUpDownAntall.TabIndex = 10
        '
        'grpBxStatisticsMetaData
        '
        Me.grpBxStatisticsMetaData.Controls.Add(Me.NumericUpDownAntall)
        Me.grpBxStatisticsMetaData.Controls.Add(Me.LabelCmbBxAntall)
        Me.grpBxStatisticsMetaData.Controls.Add(Me.LabelCmbBxType)
        Me.grpBxStatisticsMetaData.Controls.Add(Me.CmbBxType)
        Me.grpBxStatisticsMetaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpBxStatisticsMetaData.Location = New System.Drawing.Point(16, 304)
        Me.grpBxStatisticsMetaData.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBxStatisticsMetaData.Name = "grpBxStatisticsMetaData"
        Me.grpBxStatisticsMetaData.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxStatisticsMetaData.Size = New System.Drawing.Size(458, 134)
        Me.grpBxStatisticsMetaData.TabIndex = 11
        Me.grpBxStatisticsMetaData.TabStop = False
        Me.grpBxStatisticsMetaData.Text = "Velg data"
        '
        'LabelCmbBxAntall
        '
        Me.LabelCmbBxAntall.AutoSize = True
        Me.LabelCmbBxAntall.Location = New System.Drawing.Point(290, 37)
        Me.LabelCmbBxAntall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCmbBxAntall.Name = "LabelCmbBxAntall"
        Me.LabelCmbBxAntall.Size = New System.Drawing.Size(43, 17)
        Me.LabelCmbBxAntall.TabIndex = 8
        Me.LabelCmbBxAntall.Text = "Antall"
        '
        'chkBxAllTimeStart
        '
        Me.chkBxAllTimeStart.AutoSize = True
        Me.chkBxAllTimeStart.Checked = True
        Me.chkBxAllTimeStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBxAllTimeStart.Location = New System.Drawing.Point(93, 25)
        Me.chkBxAllTimeStart.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBxAllTimeStart.Name = "chkBxAllTimeStart"
        Me.chkBxAllTimeStart.Size = New System.Drawing.Size(133, 21)
        Me.chkBxAllTimeStart.TabIndex = 11
        Me.chkBxAllTimeStart.Text = "Tidenes morgen"
        Me.chkBxAllTimeStart.UseVisualStyleBackColor = True
        '
        'labelTilSelect
        '
        Me.labelTilSelect.AutoSize = True
        Me.labelTilSelect.Location = New System.Drawing.Point(248, 25)
        Me.labelTilSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTilSelect.Name = "labelTilSelect"
        Me.labelTilSelect.Size = New System.Drawing.Size(23, 17)
        Me.labelTilSelect.TabIndex = 10
        Me.labelTilSelect.Text = "Til"
        '
        'lblAdminPostnb
        '
        Me.lblAdminPostnb.AutoSize = True
        Me.lblAdminPostnb.Location = New System.Drawing.Point(395, 195)
        Me.lblAdminPostnb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminPostnb.Name = "lblAdminPostnb"
        Me.lblAdminPostnb.Size = New System.Drawing.Size(91, 17)
        Me.lblAdminPostnb.TabIndex = 50
        Me.lblAdminPostnb.Text = "Postnummer:"
        '
        'msktxtbxPostnb
        '
        Me.msktxtbxPostnb.Enabled = False
        Me.msktxtbxPostnb.Location = New System.Drawing.Point(496, 193)
        Me.msktxtbxPostnb.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxPostnb.Mask = "0000"
        Me.msktxtbxPostnb.Name = "msktxtbxPostnb"
        Me.msktxtbxPostnb.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxPostnb.TabIndex = 49
        '
        'lblAdminPassword
        '
        Me.lblAdminPassword.AutoSize = True
        Me.lblAdminPassword.Location = New System.Drawing.Point(41, 332)
        Me.lblAdminPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminPassword.Name = "lblAdminPassword"
        Me.lblAdminPassword.Size = New System.Drawing.Size(64, 17)
        Me.lblAdminPassword.TabIndex = 56
        Me.lblAdminPassword.Text = "Passord:"
        '
        'lblAdminAdress
        '
        Me.lblAdminAdress.AutoSize = True
        Me.lblAdminAdress.Location = New System.Drawing.Point(395, 152)
        Me.lblAdminAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminAdress.Name = "lblAdminAdress"
        Me.lblAdminAdress.Size = New System.Drawing.Size(99, 17)
        Me.lblAdminAdress.TabIndex = 48
        Me.lblAdminAdress.Text = "Gate Adresse:"
        '
        'msktxtbxPassword
        '
        Me.msktxtbxPassword.Enabled = False
        Me.msktxtbxPassword.Location = New System.Drawing.Point(142, 328)
        Me.msktxtbxPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxPassword.Name = "msktxtbxPassword"
        Me.msktxtbxPassword.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxPassword.TabIndex = 55
        '
        'msktxtbxAdress
        '
        Me.msktxtbxAdress.Enabled = False
        Me.msktxtbxAdress.Location = New System.Drawing.Point(496, 150)
        Me.msktxtbxAdress.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxAdress.Name = "msktxtbxAdress"
        Me.msktxtbxAdress.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxAdress.TabIndex = 47
        '
        'lblAdminTel
        '
        Me.lblAdminTel.AutoSize = True
        Me.lblAdminTel.Location = New System.Drawing.Point(395, 109)
        Me.lblAdminTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminTel.Name = "lblAdminTel"
        Me.lblAdminTel.Size = New System.Drawing.Size(60, 17)
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
        Me.grpBxSelectPeriod.Location = New System.Drawing.Point(16, 24)
        Me.grpBxSelectPeriod.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBxSelectPeriod.Name = "grpBxSelectPeriod"
        Me.grpBxSelectPeriod.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxSelectPeriod.Size = New System.Drawing.Size(458, 272)
        Me.grpBxSelectPeriod.TabIndex = 7
        Me.grpBxSelectPeriod.TabStop = False
        Me.grpBxSelectPeriod.Text = "Velg periode"
        '
        'chkBxAllTimeEnd
        '
        Me.chkBxAllTimeEnd.AutoSize = True
        Me.chkBxAllTimeEnd.Checked = True
        Me.chkBxAllTimeEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBxAllTimeEnd.Location = New System.Drawing.Point(280, 25)
        Me.chkBxAllTimeEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBxAllTimeEnd.Name = "chkBxAllTimeEnd"
        Me.chkBxAllTimeEnd.Size = New System.Drawing.Size(97, 21)
        Me.chkBxAllTimeEnd.TabIndex = 12
        Me.chkBxAllTimeEnd.Text = "End Times"
        Me.chkBxAllTimeEnd.UseVisualStyleBackColor = True
        '
        'CalendarTo
        '
        Me.CalendarTo.Location = New System.Drawing.Point(239, 50)
        Me.CalendarTo.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CalendarTo.Name = "CalendarTo"
        Me.CalendarTo.TabIndex = 9
        '
        'labelFraSelect
        '
        Me.labelFraSelect.AutoSize = True
        Me.labelFraSelect.Location = New System.Drawing.Point(28, 25)
        Me.labelFraSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFraSelect.Name = "labelFraSelect"
        Me.labelFraSelect.Size = New System.Drawing.Size(29, 17)
        Me.labelFraSelect.TabIndex = 8
        Me.labelFraSelect.Text = "Fra"
        '
        'CalendarFrom
        '
        Me.CalendarFrom.Location = New System.Drawing.Point(16, 50)
        Me.CalendarFrom.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CalendarFrom.Name = "CalendarFrom"
        Me.CalendarFrom.TabIndex = 7
        '
        'lblAdminUsername
        '
        Me.lblAdminUsername.AutoSize = True
        Me.lblAdminUsername.Location = New System.Drawing.Point(41, 287)
        Me.lblAdminUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminUsername.Name = "lblAdminUsername"
        Me.lblAdminUsername.Size = New System.Drawing.Size(85, 17)
        Me.lblAdminUsername.TabIndex = 54
        Me.lblAdminUsername.Text = "Brukernavn:"
        '
        'msktxtbxUsername
        '
        Me.msktxtbxUsername.Enabled = False
        Me.msktxtbxUsername.Location = New System.Drawing.Point(142, 284)
        Me.msktxtbxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxUsername.Name = "msktxtbxUsername"
        Me.msktxtbxUsername.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxUsername.TabIndex = 53
        '
        'lblAdminEpost
        '
        Me.lblAdminEpost.AutoSize = True
        Me.lblAdminEpost.Location = New System.Drawing.Point(395, 281)
        Me.lblAdminEpost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminEpost.Name = "lblAdminEpost"
        Me.lblAdminEpost.Size = New System.Drawing.Size(48, 17)
        Me.lblAdminEpost.TabIndex = 44
        Me.lblAdminEpost.Text = "Epost:"
        '
        'lblAdminPostplace
        '
        Me.lblAdminPostplace.AutoSize = True
        Me.lblAdminPostplace.Location = New System.Drawing.Point(395, 238)
        Me.lblAdminPostplace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminPostplace.Name = "lblAdminPostplace"
        Me.lblAdminPostplace.Size = New System.Drawing.Size(67, 17)
        Me.lblAdminPostplace.TabIndex = 52
        Me.lblAdminPostplace.Text = "Poststed:"
        '
        'msktxtbxPostplace
        '
        Me.msktxtbxPostplace.Enabled = False
        Me.msktxtbxPostplace.Location = New System.Drawing.Point(496, 236)
        Me.msktxtbxPostplace.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxPostplace.Name = "msktxtbxPostplace"
        Me.msktxtbxPostplace.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxPostplace.TabIndex = 51
        '
        'msktxtbxEpost
        '
        Me.msktxtbxEpost.Enabled = False
        Me.msktxtbxEpost.Location = New System.Drawing.Point(497, 279)
        Me.msktxtbxEpost.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxEpost.Name = "msktxtbxEpost"
        Me.msktxtbxEpost.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxEpost.TabIndex = 43
        '
        'lblAdminPosition
        '
        Me.lblAdminPosition.AutoSize = True
        Me.lblAdminPosition.Location = New System.Drawing.Point(395, 324)
        Me.lblAdminPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminPosition.Name = "lblAdminPosition"
        Me.lblAdminPosition.Size = New System.Drawing.Size(53, 17)
        Me.lblAdminPosition.TabIndex = 42
        Me.lblAdminPosition.Text = "Stilling:"
        '
        'lblAdminLname
        '
        Me.lblAdminLname.AutoSize = True
        Me.lblAdminLname.Location = New System.Drawing.Point(41, 242)
        Me.lblAdminLname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminLname.Name = "lblAdminLname"
        Me.lblAdminLname.Size = New System.Drawing.Size(73, 17)
        Me.lblAdminLname.TabIndex = 41
        Me.lblAdminLname.Text = "Etternavn:"
        '
        'msktxtbxTlf
        '
        Me.msktxtbxTlf.Enabled = False
        Me.msktxtbxTlf.Location = New System.Drawing.Point(496, 107)
        Me.msktxtbxTlf.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxTlf.Mask = "000 00 000"
        Me.msktxtbxTlf.Name = "msktxtbxTlf"
        Me.msktxtbxTlf.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxTlf.TabIndex = 45
        '
        'msktxtbxLname
        '
        Me.msktxtbxLname.Enabled = False
        Me.msktxtbxLname.Location = New System.Drawing.Point(143, 240)
        Me.msktxtbxLname.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxLname.Name = "msktxtbxLname"
        Me.msktxtbxLname.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxLname.TabIndex = 40
        '
        'cmbbxUsers
        '
        Me.cmbbxUsers.FormattingEnabled = True
        Me.cmbbxUsers.Items.AddRange(New Object() {"Kjell Hansen", "Stig Ofstad", "Duane Henriksen", "Kristoffer Pedersen"})
        Me.cmbbxUsers.Location = New System.Drawing.Point(142, 106)
        Me.cmbbxUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbbxUsers.Name = "cmbbxUsers"
        Me.cmbbxUsers.Size = New System.Drawing.Size(236, 24)
        Me.cmbbxUsers.TabIndex = 6
        '
        'btnAdminCreate
        '
        Me.btnAdminCreate.Location = New System.Drawing.Point(400, 23)
        Me.btnAdminCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminCreate.Name = "btnAdminCreate"
        Me.btnAdminCreate.Size = New System.Drawing.Size(175, 45)
        Me.btnAdminCreate.TabIndex = 31
        Me.btnAdminCreate.Text = "Opprett ny"
        Me.btnAdminCreate.UseVisualStyleBackColor = True
        '
        'lblAdminEmployee
        '
        Me.lblAdminEmployee.AutoSize = True
        Me.lblAdminEmployee.Location = New System.Drawing.Point(41, 107)
        Me.lblAdminEmployee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminEmployee.Name = "lblAdminEmployee"
        Me.lblAdminEmployee.Size = New System.Drawing.Size(52, 17)
        Me.lblAdminEmployee.TabIndex = 5
        Me.lblAdminEmployee.Text = "Ansatt:"
        '
        'BtnEndApplication
        '
        Me.BtnEndApplication.Location = New System.Drawing.Point(160, 651)
        Me.BtnEndApplication.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEndApplication.Name = "BtnEndApplication"
        Me.BtnEndApplication.Size = New System.Drawing.Size(125, 28)
        Me.BtnEndApplication.TabIndex = 6
        Me.BtnEndApplication.Text = "Avslutt"
        Me.BtnEndApplication.UseVisualStyleBackColor = True
        '
        'btnAdminDelete
        '
        Me.btnAdminDelete.Enabled = False
        Me.btnAdminDelete.Location = New System.Drawing.Point(583, 23)
        Me.btnAdminDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminDelete.Name = "btnAdminDelete"
        Me.btnAdminDelete.Size = New System.Drawing.Size(175, 45)
        Me.btnAdminDelete.TabIndex = 32
        Me.btnAdminDelete.Text = "Slett"
        Me.btnAdminDelete.UseVisualStyleBackColor = True
        '
        'btnAdminEdit
        '
        Me.btnAdminEdit.Enabled = False
        Me.btnAdminEdit.Location = New System.Drawing.Point(400, 408)
        Me.btnAdminEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminEdit.Name = "btnAdminEdit"
        Me.btnAdminEdit.Size = New System.Drawing.Size(175, 45)
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
        Me.grpbxAdminUserAccount.Location = New System.Drawing.Point(13, 135)
        Me.grpbxAdminUserAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.grpbxAdminUserAccount.Name = "grpbxAdminUserAccount"
        Me.grpbxAdminUserAccount.Padding = New System.Windows.Forms.Padding(4)
        Me.grpbxAdminUserAccount.Size = New System.Drawing.Size(775, 476)
        Me.grpbxAdminUserAccount.TabIndex = 7
        Me.grpbxAdminUserAccount.TabStop = False
        Me.grpbxAdminUserAccount.Text = "Brukerkontoer"
        '
        'lblAdminFname
        '
        Me.lblAdminFname.AutoSize = True
        Me.lblAdminFname.Location = New System.Drawing.Point(41, 197)
        Me.lblAdminFname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminFname.Name = "lblAdminFname"
        Me.lblAdminFname.Size = New System.Drawing.Size(64, 17)
        Me.lblAdminFname.TabIndex = 39
        Me.lblAdminFname.Text = "Fornavn:"
        '
        'msktxtbxFname
        '
        Me.msktxtbxFname.Enabled = False
        Me.msktxtbxFname.Location = New System.Drawing.Point(142, 196)
        Me.msktxtbxFname.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxFname.Name = "msktxtbxFname"
        Me.msktxtbxFname.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxFname.TabIndex = 38
        '
        'lblAdminEmployeeID
        '
        Me.lblAdminEmployeeID.AutoSize = True
        Me.lblAdminEmployeeID.Location = New System.Drawing.Point(41, 152)
        Me.lblAdminEmployeeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminEmployeeID.Name = "lblAdminEmployeeID"
        Me.lblAdminEmployeeID.Size = New System.Drawing.Size(103, 17)
        Me.lblAdminEmployeeID.TabIndex = 37
        Me.lblAdminEmployeeID.Text = "Ansattnummer:"
        '
        'msktxtbxID
        '
        Me.msktxtbxID.Enabled = False
        Me.msktxtbxID.Location = New System.Drawing.Point(142, 152)
        Me.msktxtbxID.Margin = New System.Windows.Forms.Padding(4)
        Me.msktxtbxID.Mask = "0000"
        Me.msktxtbxID.Name = "msktxtbxID"
        Me.msktxtbxID.Size = New System.Drawing.Size(236, 22)
        Me.msktxtbxID.TabIndex = 35
        '
        'grpBxStatistic
        '
        Me.grpBxStatistic.Controls.Add(Me.grpBxSelectPeriod)
        Me.grpBxStatistic.Controls.Add(Me.grpBxStatisticsMetaData)
        Me.grpBxStatistic.Controls.Add(Me.BtnEndApplication)
        Me.grpBxStatistic.Controls.Add(Me.btnDisplayStatistics)
        Me.grpBxStatistic.Controls.Add(Me.pnlStatistics)
        Me.grpBxStatistic.Location = New System.Drawing.Point(834, 25)
        Me.grpBxStatistic.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBxStatistic.Name = "grpBxStatistic"
        Me.grpBxStatistic.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxStatistic.Size = New System.Drawing.Size(482, 697)
        Me.grpBxStatistic.TabIndex = 6
        Me.grpBxStatistic.TabStop = False
        Me.grpBxStatistic.Text = "Statistikk"
        '
        'btnDisplayStatistics
        '
        Me.btnDisplayStatistics.Location = New System.Drawing.Point(160, 615)
        Me.btnDisplayStatistics.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisplayStatistics.Name = "btnDisplayStatistics"
        Me.btnDisplayStatistics.Size = New System.Drawing.Size(125, 28)
        Me.btnDisplayStatistics.TabIndex = 0
        Me.btnDisplayStatistics.Text = "Vis Statistikk"
        Me.btnDisplayStatistics.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 761)
        Me.Controls.Add(Me.grpbxAdminUserAccount)
        Me.Controls.Add(Me.grpBxStatistic)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1815, 935)
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
End Class
