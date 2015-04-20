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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblEmpZipArea = New System.Windows.Forms.Label()
        Me.txtEmpZipArea = New System.Windows.Forms.TextBox()
        Me.lblEmpZipCode = New System.Windows.Forms.Label()
        Me.lblEmpAddress = New System.Windows.Forms.Label()
        Me.txtEmpZipCode = New System.Windows.Forms.TextBox()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        Me.btnUpdateEmp = New System.Windows.Forms.Button()
        Me.lblEmpId = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.btnSelectAllEmployees = New System.Windows.Forms.Button()
        Me.btnInsertEmployee = New System.Windows.Forms.Button()
        Me.lblEmpPassword = New System.Windows.Forms.Label()
        Me.lblEmpUsername = New System.Windows.Forms.Label()
        Me.lblEmpJobDescription = New System.Windows.Forms.Label()
        Me.lblEmpEmail = New System.Windows.Forms.Label()
        Me.lblEmpPhone = New System.Windows.Forms.Label()
        Me.lblEmpLastname = New System.Windows.Forms.Label()
        Me.lblEmpFirstname = New System.Windows.Forms.Label()
        Me.txtEmpPassword = New System.Windows.Forms.TextBox()
        Me.txtEmpUsername = New System.Windows.Forms.TextBox()
        Me.txtEmpJobTitle = New System.Windows.Forms.TextBox()
        Me.txtEmpEmail = New System.Windows.Forms.TextBox()
        Me.txtEmpPhone = New System.Windows.Forms.TextBox()
        Me.txtEmpLastname = New System.Windows.Forms.TextBox()
        Me.txtEmpFirstname = New System.Windows.Forms.TextBox()
        Me.dgvEmployeeTest = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEmployeeTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(23, 483)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 28)
        Me.btnClear.TabIndex = 65
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(247, 483)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 28)
        Me.btnSearch.TabIndex = 64
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblEmpZipArea
        '
        Me.lblEmpZipArea.AutoSize = True
        Me.lblEmpZipArea.Location = New System.Drawing.Point(20, 313)
        Me.lblEmpZipArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpZipArea.Name = "lblEmpZipArea"
        Me.lblEmpZipArea.Size = New System.Drawing.Size(67, 17)
        Me.lblEmpZipArea.TabIndex = 63
        Me.lblEmpZipArea.Text = "Poststed:"
        '
        'txtEmpZipArea
        '
        Me.txtEmpZipArea.Location = New System.Drawing.Point(106, 309)
        Me.txtEmpZipArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpZipArea.Name = "txtEmpZipArea"
        Me.txtEmpZipArea.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpZipArea.TabIndex = 62
        '
        'lblEmpZipCode
        '
        Me.lblEmpZipCode.AutoSize = True
        Me.lblEmpZipCode.Location = New System.Drawing.Point(20, 281)
        Me.lblEmpZipCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpZipCode.Name = "lblEmpZipCode"
        Me.lblEmpZipCode.Size = New System.Drawing.Size(53, 17)
        Me.lblEmpZipCode.TabIndex = 61
        Me.lblEmpZipCode.Text = "Postnr:"
        '
        'lblEmpAddress
        '
        Me.lblEmpAddress.AutoSize = True
        Me.lblEmpAddress.Location = New System.Drawing.Point(20, 249)
        Me.lblEmpAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpAddress.Name = "lblEmpAddress"
        Me.lblEmpAddress.Size = New System.Drawing.Size(64, 17)
        Me.lblEmpAddress.TabIndex = 60
        Me.lblEmpAddress.Text = "Adresse:"
        '
        'txtEmpZipCode
        '
        Me.txtEmpZipCode.Location = New System.Drawing.Point(106, 277)
        Me.txtEmpZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpZipCode.Name = "txtEmpZipCode"
        Me.txtEmpZipCode.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpZipCode.TabIndex = 59
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Location = New System.Drawing.Point(106, 245)
        Me.txtEmpAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpAddress.TabIndex = 58
        '
        'btnDeleteEmp
        '
        Me.btnDeleteEmp.Location = New System.Drawing.Point(23, 519)
        Me.btnDeleteEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteEmp.Name = "btnDeleteEmp"
        Me.btnDeleteEmp.Size = New System.Drawing.Size(104, 28)
        Me.btnDeleteEmp.TabIndex = 57
        Me.btnDeleteEmp.Text = "Slett"
        Me.btnDeleteEmp.UseVisualStyleBackColor = True
        '
        'btnUpdateEmp
        '
        Me.btnUpdateEmp.Location = New System.Drawing.Point(135, 519)
        Me.btnUpdateEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateEmp.Name = "btnUpdateEmp"
        Me.btnUpdateEmp.Size = New System.Drawing.Size(104, 28)
        Me.btnUpdateEmp.TabIndex = 56
        Me.btnUpdateEmp.Text = "Lagre"
        Me.btnUpdateEmp.UseVisualStyleBackColor = True
        '
        'lblEmpId
        '
        Me.lblEmpId.AutoSize = True
        Me.lblEmpId.Location = New System.Drawing.Point(20, 57)
        Me.lblEmpId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpId.Name = "lblEmpId"
        Me.lblEmpId.Size = New System.Drawing.Size(65, 17)
        Me.lblEmpId.TabIndex = 55
        Me.lblEmpId.Text = "AnsattID:"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(106, 53)
        Me.txtEmpId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.ReadOnly = True
        Me.txtEmpId.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpId.TabIndex = 54
        '
        'btnSelectAllEmployees
        '
        Me.btnSelectAllEmployees.Location = New System.Drawing.Point(379, 15)
        Me.btnSelectAllEmployees.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectAllEmployees.Name = "btnSelectAllEmployees"
        Me.btnSelectAllEmployees.Size = New System.Drawing.Size(104, 28)
        Me.btnSelectAllEmployees.TabIndex = 52
        Me.btnSelectAllEmployees.Text = "Alle ansatte"
        Me.btnSelectAllEmployees.UseVisualStyleBackColor = True
        '
        'btnInsertEmployee
        '
        Me.btnInsertEmployee.Location = New System.Drawing.Point(135, 483)
        Me.btnInsertEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertEmployee.Name = "btnInsertEmployee"
        Me.btnInsertEmployee.Size = New System.Drawing.Size(104, 28)
        Me.btnInsertEmployee.TabIndex = 51
        Me.btnInsertEmployee.Text = "Opprett"
        Me.btnInsertEmployee.UseVisualStyleBackColor = True
        '
        'lblEmpPassword
        '
        Me.lblEmpPassword.AutoSize = True
        Me.lblEmpPassword.Location = New System.Drawing.Point(20, 435)
        Me.lblEmpPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpPassword.Name = "lblEmpPassword"
        Me.lblEmpPassword.Size = New System.Drawing.Size(64, 17)
        Me.lblEmpPassword.TabIndex = 50
        Me.lblEmpPassword.Text = "Passord:"
        '
        'lblEmpUsername
        '
        Me.lblEmpUsername.AutoSize = True
        Me.lblEmpUsername.Location = New System.Drawing.Point(20, 403)
        Me.lblEmpUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpUsername.Name = "lblEmpUsername"
        Me.lblEmpUsername.Size = New System.Drawing.Size(85, 17)
        Me.lblEmpUsername.TabIndex = 49
        Me.lblEmpUsername.Text = "Brukernavn:"
        '
        'lblEmpJobDescription
        '
        Me.lblEmpJobDescription.AutoSize = True
        Me.lblEmpJobDescription.Location = New System.Drawing.Point(20, 217)
        Me.lblEmpJobDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpJobDescription.Name = "lblEmpJobDescription"
        Me.lblEmpJobDescription.Size = New System.Drawing.Size(69, 17)
        Me.lblEmpJobDescription.TabIndex = 48
        Me.lblEmpJobDescription.Text = "Jobbtittel:"
        '
        'lblEmpEmail
        '
        Me.lblEmpEmail.AutoSize = True
        Me.lblEmpEmail.Location = New System.Drawing.Point(20, 185)
        Me.lblEmpEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpEmail.Name = "lblEmpEmail"
        Me.lblEmpEmail.Size = New System.Drawing.Size(48, 17)
        Me.lblEmpEmail.TabIndex = 47
        Me.lblEmpEmail.Text = "Epost:"
        '
        'lblEmpPhone
        '
        Me.lblEmpPhone.AutoSize = True
        Me.lblEmpPhone.Location = New System.Drawing.Point(20, 153)
        Me.lblEmpPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpPhone.Name = "lblEmpPhone"
        Me.lblEmpPhone.Size = New System.Drawing.Size(60, 17)
        Me.lblEmpPhone.TabIndex = 46
        Me.lblEmpPhone.Text = "Telefon:"
        '
        'lblEmpLastname
        '
        Me.lblEmpLastname.AutoSize = True
        Me.lblEmpLastname.Location = New System.Drawing.Point(20, 121)
        Me.lblEmpLastname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpLastname.Name = "lblEmpLastname"
        Me.lblEmpLastname.Size = New System.Drawing.Size(73, 17)
        Me.lblEmpLastname.TabIndex = 45
        Me.lblEmpLastname.Text = "Etternavn:"
        '
        'lblEmpFirstname
        '
        Me.lblEmpFirstname.AutoSize = True
        Me.lblEmpFirstname.Location = New System.Drawing.Point(20, 89)
        Me.lblEmpFirstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpFirstname.Name = "lblEmpFirstname"
        Me.lblEmpFirstname.Size = New System.Drawing.Size(64, 17)
        Me.lblEmpFirstname.TabIndex = 44
        Me.lblEmpFirstname.Text = "Fornavn:"
        '
        'txtEmpPassword
        '
        Me.txtEmpPassword.Location = New System.Drawing.Point(106, 432)
        Me.txtEmpPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpPassword.Name = "txtEmpPassword"
        Me.txtEmpPassword.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpPassword.TabIndex = 43
        '
        'txtEmpUsername
        '
        Me.txtEmpUsername.Location = New System.Drawing.Point(106, 400)
        Me.txtEmpUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpUsername.Name = "txtEmpUsername"
        Me.txtEmpUsername.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpUsername.TabIndex = 42
        '
        'txtEmpJobTitle
        '
        Me.txtEmpJobTitle.Location = New System.Drawing.Point(106, 213)
        Me.txtEmpJobTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpJobTitle.Name = "txtEmpJobTitle"
        Me.txtEmpJobTitle.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpJobTitle.TabIndex = 41
        '
        'txtEmpEmail
        '
        Me.txtEmpEmail.Location = New System.Drawing.Point(106, 181)
        Me.txtEmpEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpEmail.Name = "txtEmpEmail"
        Me.txtEmpEmail.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpEmail.TabIndex = 40
        '
        'txtEmpPhone
        '
        Me.txtEmpPhone.Location = New System.Drawing.Point(106, 149)
        Me.txtEmpPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpPhone.Name = "txtEmpPhone"
        Me.txtEmpPhone.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpPhone.TabIndex = 39
        '
        'txtEmpLastname
        '
        Me.txtEmpLastname.Location = New System.Drawing.Point(106, 117)
        Me.txtEmpLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpLastname.Name = "txtEmpLastname"
        Me.txtEmpLastname.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpLastname.TabIndex = 38
        '
        'txtEmpFirstname
        '
        Me.txtEmpFirstname.Location = New System.Drawing.Point(106, 85)
        Me.txtEmpFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpFirstname.Name = "txtEmpFirstname"
        Me.txtEmpFirstname.Size = New System.Drawing.Size(245, 22)
        Me.txtEmpFirstname.TabIndex = 37
        '
        'dgvEmployeeTest
        '
        Me.dgvEmployeeTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeTest.Location = New System.Drawing.Point(379, 51)
        Me.dgvEmployeeTest.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmployeeTest.Name = "dgvEmployeeTest"
        Me.dgvEmployeeTest.Size = New System.Drawing.Size(763, 496)
        Me.dgvEmployeeTest.TabIndex = 36
        '
        'EmployeeTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 562)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EmployeeTest"
        Me.Text = "EmployeeTest"
        CType(Me.dgvEmployeeTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblEmpZipArea As System.Windows.Forms.Label
    Friend WithEvents txtEmpZipArea As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpZipCode As System.Windows.Forms.Label
    Friend WithEvents lblEmpAddress As System.Windows.Forms.Label
    Friend WithEvents txtEmpZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteEmp As System.Windows.Forms.Button
    Friend WithEvents btnUpdateEmp As System.Windows.Forms.Button
    Friend WithEvents lblEmpId As System.Windows.Forms.Label
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectAllEmployees As System.Windows.Forms.Button
    Friend WithEvents btnInsertEmployee As System.Windows.Forms.Button
    Friend WithEvents lblEmpPassword As System.Windows.Forms.Label
    Friend WithEvents lblEmpUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmpJobDescription As System.Windows.Forms.Label
    Friend WithEvents lblEmpEmail As System.Windows.Forms.Label
    Friend WithEvents lblEmpPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmpLastname As System.Windows.Forms.Label
    Friend WithEvents lblEmpFirstname As System.Windows.Forms.Label
    Friend WithEvents txtEmpPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpJobTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpFirstname As System.Windows.Forms.TextBox
    Friend WithEvents dgvEmployeeTest As System.Windows.Forms.DataGridView
End Class
