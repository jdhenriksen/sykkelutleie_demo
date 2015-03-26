<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerTest
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
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCmrId = New System.Windows.Forms.TextBox()
        Me.btnSearchForCmrById = New System.Windows.Forms.Button()
        Me.btnInsertCustomer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCmrEmail = New System.Windows.Forms.TextBox()
        Me.txtCmrPhone = New System.Windows.Forms.TextBox()
        Me.txtCmrLastname = New System.Windows.Forms.TextBox()
        Me.txtCmrFirstname = New System.Windows.Forms.TextBox()
        Me.dgvCustomerTest = New System.Windows.Forms.DataGridView()
        Me.btnSetActiveToZero = New System.Windows.Forms.Button()
        Me.btnSelectAllCustomers = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(70, 240)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateCustomer.TabIndex = 52
        Me.btnUpdateCustomer.Text = "Oppdater"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "KundeID:"
        '
        'txtCmrId
        '
        Me.txtCmrId.Location = New System.Drawing.Point(91, 30)
        Me.txtCmrId.Name = "txtCmrId"
        Me.txtCmrId.Size = New System.Drawing.Size(142, 20)
        Me.txtCmrId.TabIndex = 47
        '
        'btnSearchForCmrById
        '
        Me.btnSearchForCmrById.Location = New System.Drawing.Point(21, 240)
        Me.btnSearchForCmrById.Name = "btnSearchForCmrById"
        Me.btnSearchForCmrById.Size = New System.Drawing.Size(43, 23)
        Me.btnSearchForCmrById.TabIndex = 46
        Me.btnSearchForCmrById.Text = "Søk"
        Me.btnSearchForCmrById.UseVisualStyleBackColor = True
        '
        'btnInsertCustomer
        '
        Me.btnInsertCustomer.Location = New System.Drawing.Point(151, 240)
        Me.btnInsertCustomer.Name = "btnInsertCustomer"
        Me.btnInsertCustomer.Size = New System.Drawing.Size(82, 23)
        Me.btnInsertCustomer.TabIndex = 44
        Me.btnInsertCustomer.Text = "Skriv til DB"
        Me.btnInsertCustomer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Epost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Telefon:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Etternavn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Fornavn:"
        '
        'txtCmrEmail
        '
        Me.txtCmrEmail.Location = New System.Drawing.Point(91, 134)
        Me.txtCmrEmail.Name = "txtCmrEmail"
        Me.txtCmrEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtCmrEmail.TabIndex = 32
        '
        'txtCmrPhone
        '
        Me.txtCmrPhone.Location = New System.Drawing.Point(91, 108)
        Me.txtCmrPhone.Name = "txtCmrPhone"
        Me.txtCmrPhone.Size = New System.Drawing.Size(142, 20)
        Me.txtCmrPhone.TabIndex = 31
        '
        'txtCmrLastname
        '
        Me.txtCmrLastname.Location = New System.Drawing.Point(91, 82)
        Me.txtCmrLastname.Name = "txtCmrLastname"
        Me.txtCmrLastname.Size = New System.Drawing.Size(142, 20)
        Me.txtCmrLastname.TabIndex = 30
        '
        'txtCmrFirstname
        '
        Me.txtCmrFirstname.Location = New System.Drawing.Point(91, 56)
        Me.txtCmrFirstname.Name = "txtCmrFirstname"
        Me.txtCmrFirstname.Size = New System.Drawing.Size(142, 20)
        Me.txtCmrFirstname.TabIndex = 29
        '
        'dgvCustomerTest
        '
        Me.dgvCustomerTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerTest.Location = New System.Drawing.Point(271, 23)
        Me.dgvCustomerTest.Name = "dgvCustomerTest"
        Me.dgvCustomerTest.Size = New System.Drawing.Size(580, 299)
        Me.dgvCustomerTest.TabIndex = 28
        '
        'btnSetActiveToZero
        '
        Me.btnSetActiveToZero.Location = New System.Drawing.Point(151, 308)
        Me.btnSetActiveToZero.Name = "btnSetActiveToZero"
        Me.btnSetActiveToZero.Size = New System.Drawing.Size(75, 23)
        Me.btnSetActiveToZero.TabIndex = 53
        Me.btnSetActiveToZero.Text = "Deaktiver"
        Me.btnSetActiveToZero.UseVisualStyleBackColor = True
        '
        'btnSelectAllCustomers
        '
        Me.btnSelectAllCustomers.Location = New System.Drawing.Point(21, 308)
        Me.btnSelectAllCustomers.Name = "btnSelectAllCustomers"
        Me.btnSelectAllCustomers.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAllCustomers.TabIndex = 54
        Me.btnSelectAllCustomers.Text = "List Kunder"
        Me.btnSelectAllCustomers.UseVisualStyleBackColor = True
        '
        'CustomerTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 375)
        Me.Controls.Add(Me.btnSelectAllCustomers)
        Me.Controls.Add(Me.btnSetActiveToZero)
        Me.Controls.Add(Me.btnUpdateCustomer)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCmrId)
        Me.Controls.Add(Me.btnSearchForCmrById)
        Me.Controls.Add(Me.btnInsertCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCmrEmail)
        Me.Controls.Add(Me.txtCmrPhone)
        Me.Controls.Add(Me.txtCmrLastname)
        Me.Controls.Add(Me.txtCmrFirstname)
        Me.Controls.Add(Me.dgvCustomerTest)
        Me.Name = "CustomerTest"
        Me.Text = "CustomerTest"
        CType(Me.dgvCustomerTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdateCustomer As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCmrId As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchForCmrById As System.Windows.Forms.Button
    Friend WithEvents btnInsertCustomer As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCmrEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCmrPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCmrLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtCmrFirstname As System.Windows.Forms.TextBox
    Friend WithEvents dgvCustomerTest As System.Windows.Forms.DataGridView
    Friend WithEvents btnSetActiveToZero As System.Windows.Forms.Button
    Friend WithEvents btnSelectAllCustomers As System.Windows.Forms.Button
End Class
