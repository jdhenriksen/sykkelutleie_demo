<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeTest
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
        Me.dgvEmployeeTest = New System.Windows.Forms.DataGridView()
        Me.txtEmpFirstname = New System.Windows.Forms.TextBox()
        Me.txtEmpLastname = New System.Windows.Forms.TextBox()
        Me.txtEmpPhone = New System.Windows.Forms.TextBox()
        Me.txtEmpEmail = New System.Windows.Forms.TextBox()
        Me.txtEmpJobTitle = New System.Windows.Forms.TextBox()
        Me.txtEmpUsername = New System.Windows.Forms.TextBox()
        Me.txtEmpPassword = New System.Windows.Forms.TextBox()
        Me.lblEmpFirstname = New System.Windows.Forms.Label()
        Me.lblEmpLastname = New System.Windows.Forms.Label()
        Me.lblEmpPhone = New System.Windows.Forms.Label()
        Me.lblEmpEmail = New System.Windows.Forms.Label()
        Me.lblEmpJobDescription = New System.Windows.Forms.Label()
        Me.lblEmpUsername = New System.Windows.Forms.Label()
        Me.lblEmpPassword = New System.Windows.Forms.Label()
        Me.btnInsertEmployee = New System.Windows.Forms.Button()
        Me.btnSelectAllEmployees = New System.Windows.Forms.Button()
        Me.btnSearchForEmpById = New System.Windows.Forms.Button()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.lblEmpId = New System.Windows.Forms.Label()
        Me.btnUpdateEmp = New System.Windows.Forms.Button()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.txtEmpZipCode = New System.Windows.Forms.TextBox()
        Me.lblEmpAddress = New System.Windows.Forms.Label()
        Me.lblEmpZipCode = New System.Windows.Forms.Label()
        Me.txtEmpZipArea = New System.Windows.Forms.TextBox()
        Me.lblEmpZipArea = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvEmployeeTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployeeTest
        '
        Me.dgvEmployeeTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeTest.Location = New System.Drawing.Point(294, 12)
        Me.dgvEmployeeTest.Name = "dgvEmployeeTest"
        Me.dgvEmployeeTest.Size = New System.Drawing.Size(566, 335)
        Me.dgvEmployeeTest.TabIndex = 1
        '
        'txtEmpFirstname
        '
        Me.txtEmpFirstname.Location = New System.Drawing.Point(100, 45)
        Me.txtEmpFirstname.Name = "txtEmpFirstname"
        Me.txtEmpFirstname.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpFirstname.TabIndex = 2
        '
        'txtEmpLastname
        '
        Me.txtEmpLastname.Location = New System.Drawing.Point(100, 71)
        Me.txtEmpLastname.Name = "txtEmpLastname"
        Me.txtEmpLastname.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpLastname.TabIndex = 3
        '
        'txtEmpPhone
        '
        Me.txtEmpPhone.Location = New System.Drawing.Point(100, 97)
        Me.txtEmpPhone.Name = "txtEmpPhone"
        Me.txtEmpPhone.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpPhone.TabIndex = 4
        '
        'txtEmpEmail
        '
        Me.txtEmpEmail.Location = New System.Drawing.Point(100, 123)
        Me.txtEmpEmail.Name = "txtEmpEmail"
        Me.txtEmpEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpEmail.TabIndex = 5
        '
        'txtEmpJobTitle
        '
        Me.txtEmpJobTitle.Location = New System.Drawing.Point(100, 149)
        Me.txtEmpJobTitle.Name = "txtEmpJobTitle"
        Me.txtEmpJobTitle.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpJobTitle.TabIndex = 6
        '
        'txtEmpUsername
        '
        Me.txtEmpUsername.Location = New System.Drawing.Point(100, 272)
        Me.txtEmpUsername.Name = "txtEmpUsername"
        Me.txtEmpUsername.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpUsername.TabIndex = 7
        '
        'txtEmpPassword
        '
        Me.txtEmpPassword.Location = New System.Drawing.Point(100, 298)
        Me.txtEmpPassword.Name = "txtEmpPassword"
        Me.txtEmpPassword.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpPassword.TabIndex = 8
        '
        'lblEmpFirstname
        '
        Me.lblEmpFirstname.AutoSize = True
        Me.lblEmpFirstname.Location = New System.Drawing.Point(35, 48)
        Me.lblEmpFirstname.Name = "lblEmpFirstname"
        Me.lblEmpFirstname.Size = New System.Drawing.Size(49, 13)
        Me.lblEmpFirstname.TabIndex = 9
        Me.lblEmpFirstname.Text = "Fornavn:"
        '
        'lblEmpLastname
        '
        Me.lblEmpLastname.AutoSize = True
        Me.lblEmpLastname.Location = New System.Drawing.Point(35, 74)
        Me.lblEmpLastname.Name = "lblEmpLastname"
        Me.lblEmpLastname.Size = New System.Drawing.Size(56, 13)
        Me.lblEmpLastname.TabIndex = 10
        Me.lblEmpLastname.Text = "Etternavn:"
        '
        'lblEmpPhone
        '
        Me.lblEmpPhone.AutoSize = True
        Me.lblEmpPhone.Location = New System.Drawing.Point(35, 100)
        Me.lblEmpPhone.Name = "lblEmpPhone"
        Me.lblEmpPhone.Size = New System.Drawing.Size(46, 13)
        Me.lblEmpPhone.TabIndex = 11
        Me.lblEmpPhone.Text = "Telefon:"
        '
        'lblEmpEmail
        '
        Me.lblEmpEmail.AutoSize = True
        Me.lblEmpEmail.Location = New System.Drawing.Point(35, 126)
        Me.lblEmpEmail.Name = "lblEmpEmail"
        Me.lblEmpEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmpEmail.TabIndex = 12
        Me.lblEmpEmail.Text = "Epost:"
        '
        'lblEmpJobDescription
        '
        Me.lblEmpJobDescription.AutoSize = True
        Me.lblEmpJobDescription.Location = New System.Drawing.Point(35, 152)
        Me.lblEmpJobDescription.Name = "lblEmpJobDescription"
        Me.lblEmpJobDescription.Size = New System.Drawing.Size(52, 13)
        Me.lblEmpJobDescription.TabIndex = 13
        Me.lblEmpJobDescription.Text = "Jobbtittel:"
        '
        'lblEmpUsername
        '
        Me.lblEmpUsername.AutoSize = True
        Me.lblEmpUsername.Location = New System.Drawing.Point(35, 275)
        Me.lblEmpUsername.Name = "lblEmpUsername"
        Me.lblEmpUsername.Size = New System.Drawing.Size(65, 13)
        Me.lblEmpUsername.TabIndex = 14
        Me.lblEmpUsername.Text = "Brukernavn:"
        '
        'lblEmpPassword
        '
        Me.lblEmpPassword.AutoSize = True
        Me.lblEmpPassword.Location = New System.Drawing.Point(35, 301)
        Me.lblEmpPassword.Name = "lblEmpPassword"
        Me.lblEmpPassword.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpPassword.TabIndex = 15
        Me.lblEmpPassword.Text = "Passord:"
        '
        'btnInsertEmployee
        '
        Me.btnInsertEmployee.Location = New System.Drawing.Point(160, 353)
        Me.btnInsertEmployee.Name = "btnInsertEmployee"
        Me.btnInsertEmployee.Size = New System.Drawing.Size(82, 23)
        Me.btnInsertEmployee.TabIndex = 18
        Me.btnInsertEmployee.Text = "Legg til"
        Me.btnInsertEmployee.UseVisualStyleBackColor = True
        '
        'btnSelectAllEmployees
        '
        Me.btnSelectAllEmployees.Location = New System.Drawing.Point(783, 353)
        Me.btnSelectAllEmployees.Name = "btnSelectAllEmployees"
        Me.btnSelectAllEmployees.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAllEmployees.TabIndex = 19
        Me.btnSelectAllEmployees.Text = "Alle ansatte"
        Me.btnSelectAllEmployees.UseVisualStyleBackColor = True
        '
        'btnSearchForEmpById
        '
        Me.btnSearchForEmpById.Location = New System.Drawing.Point(703, 353)
        Me.btnSearchForEmpById.Name = "btnSearchForEmpById"
        Me.btnSearchForEmpById.Size = New System.Drawing.Size(74, 23)
        Me.btnSearchForEmpById.TabIndex = 20
        Me.btnSearchForEmpById.Text = "Søk på ID"
        Me.btnSearchForEmpById.UseVisualStyleBackColor = True
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(100, 19)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpId.TabIndex = 21
        '
        'lblEmpId
        '
        Me.lblEmpId.AutoSize = True
        Me.lblEmpId.Location = New System.Drawing.Point(35, 22)
        Me.lblEmpId.Name = "lblEmpId"
        Me.lblEmpId.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpId.TabIndex = 22
        Me.lblEmpId.Text = "AnsattID:"
        '
        'btnUpdateEmp
        '
        Me.btnUpdateEmp.Location = New System.Drawing.Point(160, 382)
        Me.btnUpdateEmp.Name = "btnUpdateEmp"
        Me.btnUpdateEmp.Size = New System.Drawing.Size(82, 23)
        Me.btnUpdateEmp.TabIndex = 26
        Me.btnUpdateEmp.Text = "Endre"
        Me.btnUpdateEmp.UseVisualStyleBackColor = True
        '
        'btnDeleteEmp
        '
        Me.btnDeleteEmp.Location = New System.Drawing.Point(160, 411)
        Me.btnDeleteEmp.Name = "btnDeleteEmp"
        Me.btnDeleteEmp.Size = New System.Drawing.Size(82, 23)
        Me.btnDeleteEmp.TabIndex = 27
        Me.btnDeleteEmp.Text = "Slett"
        Me.btnDeleteEmp.UseVisualStyleBackColor = True
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Location = New System.Drawing.Point(100, 175)
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpAddress.TabIndex = 28
        '
        'txtEmpZipCode
        '
        Me.txtEmpZipCode.Location = New System.Drawing.Point(100, 201)
        Me.txtEmpZipCode.Name = "txtEmpZipCode"
        Me.txtEmpZipCode.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpZipCode.TabIndex = 29
        '
        'lblEmpAddress
        '
        Me.lblEmpAddress.AutoSize = True
        Me.lblEmpAddress.Location = New System.Drawing.Point(35, 178)
        Me.lblEmpAddress.Name = "lblEmpAddress"
        Me.lblEmpAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpAddress.TabIndex = 30
        Me.lblEmpAddress.Text = "Adresse:"
        '
        'lblEmpZipCode
        '
        Me.lblEmpZipCode.AutoSize = True
        Me.lblEmpZipCode.Location = New System.Drawing.Point(35, 204)
        Me.lblEmpZipCode.Name = "lblEmpZipCode"
        Me.lblEmpZipCode.Size = New System.Drawing.Size(40, 13)
        Me.lblEmpZipCode.TabIndex = 31
        Me.lblEmpZipCode.Text = "Postnr:"
        '
        'txtEmpZipArea
        '
        Me.txtEmpZipArea.Location = New System.Drawing.Point(100, 227)
        Me.txtEmpZipArea.Name = "txtEmpZipArea"
        Me.txtEmpZipArea.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpZipArea.TabIndex = 32
        '
        'lblEmpZipArea
        '
        Me.lblEmpZipArea.AutoSize = True
        Me.lblEmpZipArea.Location = New System.Drawing.Point(35, 230)
        Me.lblEmpZipArea.Name = "lblEmpZipArea"
        Me.lblEmpZipArea.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpZipArea.TabIndex = 33
        Me.lblEmpZipArea.Text = "Poststed:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 353)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 23)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(15, 411)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 23)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'EmployeeTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 457)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblEmpZipArea)
        Me.Controls.Add(Me.txtEmpZipArea)
        Me.Controls.Add(Me.lblEmpZipCode)
        Me.Controls.Add(Me.lblEmpAddress)
        Me.Controls.Add(Me.txtEmpZipCode)
        Me.Controls.Add(Me.txtEmpAddress)
        Me.Controls.Add(Me.btnDeleteEmp)
        Me.Controls.Add(Me.btnUpdateEmp)
        Me.Controls.Add(Me.lblEmpId)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.btnSearchForEmpById)
        Me.Controls.Add(Me.btnSelectAllEmployees)
        Me.Controls.Add(Me.btnInsertEmployee)
        Me.Controls.Add(Me.lblEmpPassword)
        Me.Controls.Add(Me.lblEmpUsername)
        Me.Controls.Add(Me.lblEmpJobDescription)
        Me.Controls.Add(Me.lblEmpEmail)
        Me.Controls.Add(Me.lblEmpPhone)
        Me.Controls.Add(Me.lblEmpLastname)
        Me.Controls.Add(Me.lblEmpFirstname)
        Me.Controls.Add(Me.txtEmpPassword)
        Me.Controls.Add(Me.txtEmpUsername)
        Me.Controls.Add(Me.txtEmpJobTitle)
        Me.Controls.Add(Me.txtEmpEmail)
        Me.Controls.Add(Me.txtEmpPhone)
        Me.Controls.Add(Me.txtEmpLastname)
        Me.Controls.Add(Me.txtEmpFirstname)
        Me.Controls.Add(Me.dgvEmployeeTest)
        Me.Name = "EmployeeTest"
        Me.Text = "EmployeeTest"
        CType(Me.dgvEmployeeTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmployeeTest As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmpFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpJobTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpFirstname As System.Windows.Forms.Label
    Friend WithEvents lblEmpLastname As System.Windows.Forms.Label
    Friend WithEvents lblEmpPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmpEmail As System.Windows.Forms.Label
    Friend WithEvents lblEmpJobDescription As System.Windows.Forms.Label
    Friend WithEvents lblEmpUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmpPassword As System.Windows.Forms.Label
    Friend WithEvents btnInsertEmployee As System.Windows.Forms.Button
    Friend WithEvents btnSelectAllEmployees As System.Windows.Forms.Button
    Friend WithEvents btnSearchForEmpById As System.Windows.Forms.Button
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpId As System.Windows.Forms.Label
    Friend WithEvents btnUpdateEmp As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEmp As System.Windows.Forms.Button
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpZipCode As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmpZipCode As System.Windows.Forms.Label
    Friend WithEvents txtEmpZipArea As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpZipArea As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
