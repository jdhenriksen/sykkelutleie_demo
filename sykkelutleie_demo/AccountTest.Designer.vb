<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountTest
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnChangeUsername = New System.Windows.Forms.Button()
        Me.dgvAccount = New System.Windows.Forms.DataGridView()
        Me.btnShowAllEmployees = New System.Windows.Forms.Button()
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(541, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logg ut"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(12, 175)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(101, 23)
        Me.btnStatus.TabIndex = 12
        Me.btnStatus.Text = "Vis status"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(12, 88)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(101, 23)
        Me.btnCreateAccount.TabIndex = 9
        Me.btnCreateAccount.Text = "Lag konto"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(12, 146)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(101, 23)
        Me.btnChangePassword.TabIndex = 11
        Me.btnChangePassword.Text = "Endre passord"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnChangeUsername
        '
        Me.btnChangeUsername.Location = New System.Drawing.Point(12, 117)
        Me.btnChangeUsername.Name = "btnChangeUsername"
        Me.btnChangeUsername.Size = New System.Drawing.Size(101, 23)
        Me.btnChangeUsername.TabIndex = 10
        Me.btnChangeUsername.Text = "Endre brukernavn"
        Me.btnChangeUsername.UseVisualStyleBackColor = True
        '
        'dgvAccount
        '
        Me.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccount.Location = New System.Drawing.Point(160, 12)
        Me.dgvAccount.Name = "dgvAccount"
        Me.dgvAccount.Size = New System.Drawing.Size(375, 269)
        Me.dgvAccount.TabIndex = 13
        '
        'btnShowAllEmployees
        '
        Me.btnShowAllEmployees.Location = New System.Drawing.Point(13, 13)
        Me.btnShowAllEmployees.Name = "btnShowAllEmployees"
        Me.btnShowAllEmployees.Size = New System.Drawing.Size(100, 23)
        Me.btnShowAllEmployees.TabIndex = 14
        Me.btnShowAllEmployees.Text = "Vis ansatte"
        Me.btnShowAllEmployees.UseVisualStyleBackColor = True
        '
        'AccountTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 293)
        Me.Controls.Add(Me.btnShowAllEmployees)
        Me.Controls.Add(Me.dgvAccount)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnChangeUsername)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "AccountTest"
        Me.Text = "AccountTest"
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnChangeUsername As System.Windows.Forms.Button
    Friend WithEvents dgvAccount As System.Windows.Forms.DataGridView
    Friend WithEvents btnShowAllEmployees As System.Windows.Forms.Button
End Class
