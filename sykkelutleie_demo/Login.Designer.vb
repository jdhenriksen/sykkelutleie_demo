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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOpenDatabaseTest = New System.Windows.Forms.Button()
        Me.btnOpenAdminForm = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnOpenStorageWorkerTest = New System.Windows.Forms.Button()
        Me.btnOpenAccountTest = New System.Windows.Forms.Button()
        Me.btnOpenEmployeeTest = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(107, 23)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(171, 22)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(107, 55)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(171, 22)
        Me.txtPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(179, 100)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 28)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Logg inn"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Brukernavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Passord"
        '
        'btnOpenDatabaseTest
        '
        Me.btnOpenDatabaseTest.Location = New System.Drawing.Point(23, 25)
        Me.btnOpenDatabaseTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenDatabaseTest.Name = "btnOpenDatabaseTest"
        Me.btnOpenDatabaseTest.Size = New System.Drawing.Size(171, 36)
        Me.btnOpenDatabaseTest.TabIndex = 9
        Me.btnOpenDatabaseTest.Text = "Database Test"
        Me.btnOpenDatabaseTest.UseVisualStyleBackColor = True
        '
        'btnOpenAdminForm
        '
        Me.btnOpenAdminForm.Location = New System.Drawing.Point(23, 68)
        Me.btnOpenAdminForm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenAdminForm.Name = "btnOpenAdminForm"
        Me.btnOpenAdminForm.Size = New System.Drawing.Size(171, 30)
        Me.btnOpenAdminForm.TabIndex = 10
        Me.btnOpenAdminForm.Text = "AdminForm"
        Me.btnOpenAdminForm.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOpenStorageWorkerTest)
        Me.GroupBox2.Controls.Add(Me.btnOpenAccountTest)
        Me.GroupBox2.Controls.Add(Me.btnOpenEmployeeTest)
        Me.GroupBox2.Controls.Add(Me.btnOpenAdminForm)
        Me.GroupBox2.Controls.Add(Me.btnOpenDatabaseTest)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(667, 353)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TestArea"
        '
        'btnOpenStorageWorkerTest
        '
        Me.btnOpenStorageWorkerTest.Location = New System.Drawing.Point(23, 176)
        Me.btnOpenStorageWorkerTest.Name = "btnOpenStorageWorkerTest"
        Me.btnOpenStorageWorkerTest.Size = New System.Drawing.Size(171, 43)
        Me.btnOpenStorageWorkerTest.TabIndex = 13
        Me.btnOpenStorageWorkerTest.Text = "StorageWorker"
        Me.btnOpenStorageWorkerTest.UseVisualStyleBackColor = True
        '
        'btnOpenAccountTest
        '
        Me.btnOpenAccountTest.Location = New System.Drawing.Point(23, 140)
        Me.btnOpenAccountTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenAccountTest.Name = "btnOpenAccountTest"
        Me.btnOpenAccountTest.Size = New System.Drawing.Size(171, 28)
        Me.btnOpenAccountTest.TabIndex = 12
        Me.btnOpenAccountTest.Text = "AccountTest"
        Me.btnOpenAccountTest.UseVisualStyleBackColor = True
        '
        'btnOpenEmployeeTest
        '
        Me.btnOpenEmployeeTest.Location = New System.Drawing.Point(23, 105)
        Me.btnOpenEmployeeTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenEmployeeTest.Name = "btnOpenEmployeeTest"
        Me.btnOpenEmployeeTest.Size = New System.Drawing.Size(171, 28)
        Me.btnOpenEmployeeTest.TabIndex = 11
        Me.btnOpenEmployeeTest.Text = "EmployeeTest"
        Me.btnOpenEmployeeTest.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 572)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOpenDatabaseTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenAdminForm As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpenEmployeeTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenAccountTest As System.Windows.Forms.Button
    Friend WithEvents btnOpenStorageWorkerTest As System.Windows.Forms.Button

End Class
