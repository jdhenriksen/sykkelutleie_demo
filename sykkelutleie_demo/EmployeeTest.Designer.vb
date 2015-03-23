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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnInsertEmployee = New System.Windows.Forms.Button()
        Me.btnSelectAllEmployees = New System.Windows.Forms.Button()
        Me.btnSearchForEmpById = New System.Windows.Forms.Button()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUpdateEmp = New System.Windows.Forms.Button()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        CType(Me.dgvEmployeeTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployeeTest
        '
        Me.dgvEmployeeTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeTest.Location = New System.Drawing.Point(294, 12)
        Me.dgvEmployeeTest.Name = "dgvEmployeeTest"
        Me.dgvEmployeeTest.Size = New System.Drawing.Size(566, 310)
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
        Me.txtEmpUsername.Location = New System.Drawing.Point(100, 243)
        Me.txtEmpUsername.Name = "txtEmpUsername"
        Me.txtEmpUsername.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpUsername.TabIndex = 7
        '
        'txtEmpPassword
        '
        Me.txtEmpPassword.Location = New System.Drawing.Point(100, 269)
        Me.txtEmpPassword.Name = "txtEmpPassword"
        Me.txtEmpPassword.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpPassword.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fornavn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Etternavn:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Telefon:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Epost:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jobbtittel:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Brukernavn:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Passord:"
        '
        'btnInsertEmployee
        '
        Me.btnInsertEmployee.Location = New System.Drawing.Point(18, 328)
        Me.btnInsertEmployee.Name = "btnInsertEmployee"
        Me.btnInsertEmployee.Size = New System.Drawing.Size(82, 23)
        Me.btnInsertEmployee.TabIndex = 18
        Me.btnInsertEmployee.Text = "Legg til"
        Me.btnInsertEmployee.UseVisualStyleBackColor = True
        '
        'btnSelectAllEmployees
        '
        Me.btnSelectAllEmployees.Location = New System.Drawing.Point(785, 328)
        Me.btnSelectAllEmployees.Name = "btnSelectAllEmployees"
        Me.btnSelectAllEmployees.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAllEmployees.TabIndex = 19
        Me.btnSelectAllEmployees.Text = "Alle ansatte"
        Me.btnSelectAllEmployees.UseVisualStyleBackColor = True
        '
        'btnSearchForEmpById
        '
        Me.btnSearchForEmpById.Location = New System.Drawing.Point(705, 328)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "AnsattID:"
        '
        'btnUpdateEmp
        '
        Me.btnUpdateEmp.Location = New System.Drawing.Point(120, 328)
        Me.btnUpdateEmp.Name = "btnUpdateEmp"
        Me.btnUpdateEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateEmp.TabIndex = 26
        Me.btnUpdateEmp.Text = "Endre"
        Me.btnUpdateEmp.UseVisualStyleBackColor = True
        '
        'btnDeleteEmp
        '
        Me.btnDeleteEmp.Location = New System.Drawing.Point(213, 328)
        Me.btnDeleteEmp.Name = "btnDeleteEmp"
        Me.btnDeleteEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteEmp.TabIndex = 27
        Me.btnDeleteEmp.Text = "Slett"
        Me.btnDeleteEmp.UseVisualStyleBackColor = True
        '
        'EmployeeTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 418)
        Me.Controls.Add(Me.btnDeleteEmp)
        Me.Controls.Add(Me.btnUpdateEmp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.btnSearchForEmpById)
        Me.Controls.Add(Me.btnSelectAllEmployees)
        Me.Controls.Add(Me.btnInsertEmployee)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnInsertEmployee As System.Windows.Forms.Button
    Friend WithEvents btnSelectAllEmployees As System.Windows.Forms.Button
    Friend WithEvents btnSearchForEmpById As System.Windows.Forms.Button
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateEmp As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEmp As System.Windows.Forms.Button
End Class
