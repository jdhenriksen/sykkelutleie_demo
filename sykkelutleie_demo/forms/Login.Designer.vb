<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblPasswordLogin = New System.Windows.Forms.Label()
        Me.lblUsernameLogin = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnOpenAdminForm = New System.Windows.Forms.Button()
        Me.grpboxTestArea = New System.Windows.Forms.GroupBox()
        Me.btnCustomerTest = New System.Windows.Forms.Button()
        Me.btnOpenOrderTest = New System.Windows.Forms.Button()
        Me.btnOpenMailTest = New System.Windows.Forms.Button()
        Me.btnOpenStorageWorkerTest = New System.Windows.Forms.Button()
        Me.btnOpenEmployeeTest = New System.Windows.Forms.Button()
        Me.grpboxTestArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPasswordLogin
        '
        Me.lblPasswordLogin.AutoSize = True
        Me.lblPasswordLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordLogin.Location = New System.Drawing.Point(62, 76)
        Me.lblPasswordLogin.Name = "lblPasswordLogin"
        Me.lblPasswordLogin.Size = New System.Drawing.Size(60, 17)
        Me.lblPasswordLogin.TabIndex = 17
        Me.lblPasswordLogin.Text = "Passord"
        '
        'lblUsernameLogin
        '
        Me.lblUsernameLogin.AutoSize = True
        Me.lblUsernameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameLogin.Location = New System.Drawing.Point(62, 50)
        Me.lblUsernameLogin.Name = "lblUsernameLogin"
        Me.lblUsernameLogin.Size = New System.Drawing.Size(81, 17)
        Me.lblUsernameLogin.TabIndex = 16
        Me.lblUsernameLogin.Text = "Brukernavn"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(202, 100)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 34)
        Me.btnLogin.TabIndex = 15
        Me.btnLogin.Text = "Logg inn"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(149, 76)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(129, 23)
        Me.txtPassword.TabIndex = 14
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(149, 50)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(129, 23)
        Me.txtUsername.TabIndex = 13
        '
        'btnOpenAdminForm
        '
        Me.btnOpenAdminForm.Location = New System.Drawing.Point(18, 20)
        Me.btnOpenAdminForm.Name = "btnOpenAdminForm"
        Me.btnOpenAdminForm.Size = New System.Drawing.Size(142, 56)
        Me.btnOpenAdminForm.TabIndex = 10
        Me.btnOpenAdminForm.Text = "AdminForm"
        Me.btnOpenAdminForm.UseVisualStyleBackColor = True
        '
        'grpboxTestArea
        '
        Me.grpboxTestArea.Controls.Add(Me.btnCustomerTest)
        Me.grpboxTestArea.Controls.Add(Me.btnOpenOrderTest)
        Me.grpboxTestArea.Controls.Add(Me.btnOpenMailTest)
        Me.grpboxTestArea.Controls.Add(Me.btnOpenStorageWorkerTest)
        Me.grpboxTestArea.Controls.Add(Me.btnOpenEmployeeTest)
        Me.grpboxTestArea.Controls.Add(Me.btnOpenAdminForm)
        Me.grpboxTestArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxTestArea.Location = New System.Drawing.Point(10, 140)
        Me.grpboxTestArea.Name = "grpboxTestArea"
        Me.grpboxTestArea.Size = New System.Drawing.Size(341, 221)
        Me.grpboxTestArea.TabIndex = 18
        Me.grpboxTestArea.TabStop = False
        Me.grpboxTestArea.Text = "TestArea"
        '
        'btnCustomerTest
        '
        Me.btnCustomerTest.Location = New System.Drawing.Point(17, 155)
        Me.btnCustomerTest.Name = "btnCustomerTest"
        Me.btnCustomerTest.Size = New System.Drawing.Size(142, 56)
        Me.btnCustomerTest.TabIndex = 17
        Me.btnCustomerTest.Text = "CustomerTest"
        Me.btnCustomerTest.UseVisualStyleBackColor = True
        '
        'btnOpenOrderTest
        '
        Me.btnOpenOrderTest.Location = New System.Drawing.Point(186, 20)
        Me.btnOpenOrderTest.Name = "btnOpenOrderTest"
        Me.btnOpenOrderTest.Size = New System.Drawing.Size(142, 56)
        Me.btnOpenOrderTest.TabIndex = 16
        Me.btnOpenOrderTest.Text = "OrderTest"
        Me.btnOpenOrderTest.UseVisualStyleBackColor = True
        '
        'btnOpenMailTest
        '
        Me.btnOpenMailTest.Location = New System.Drawing.Point(186, 87)
        Me.btnOpenMailTest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpenMailTest.Name = "btnOpenMailTest"
        Me.btnOpenMailTest.Size = New System.Drawing.Size(142, 56)
        Me.btnOpenMailTest.TabIndex = 15
        Me.btnOpenMailTest.Text = "Mail Test"
        Me.btnOpenMailTest.UseVisualStyleBackColor = True
        '
        'btnOpenStorageWorkerTest
        '
        Me.btnOpenStorageWorkerTest.Location = New System.Drawing.Point(17, 87)
        Me.btnOpenStorageWorkerTest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpenStorageWorkerTest.Name = "btnOpenStorageWorkerTest"
        Me.btnOpenStorageWorkerTest.Size = New System.Drawing.Size(142, 56)
        Me.btnOpenStorageWorkerTest.TabIndex = 13
        Me.btnOpenStorageWorkerTest.Text = "StorageWorker"
        Me.btnOpenStorageWorkerTest.UseVisualStyleBackColor = True
        '
        'btnOpenEmployeeTest
        '
        Me.btnOpenEmployeeTest.Location = New System.Drawing.Point(186, 155)
        Me.btnOpenEmployeeTest.Name = "btnOpenEmployeeTest"
        Me.btnOpenEmployeeTest.Size = New System.Drawing.Size(142, 56)
        Me.btnOpenEmployeeTest.TabIndex = 11
        Me.btnOpenEmployeeTest.Text = "EmployeeTest"
        Me.btnOpenEmployeeTest.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 370)
        Me.Controls.Add(Me.lblPasswordLogin)
        Me.Controls.Add(Me.lblUsernameLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.grpboxTestArea)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.grpboxTestArea.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPasswordLogin As System.Windows.Forms.Label
    Friend WithEvents lblUsernameLogin As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenAdminForm As System.Windows.Forms.Button
    Friend WithEvents grpboxTestArea As System.Windows.Forms.GroupBox
    Friend WithEvents btnCustomerTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenOrderTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenMailTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenStorageWorkerTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenEmployeeTest As System.Windows.Forms.Button

End Class
