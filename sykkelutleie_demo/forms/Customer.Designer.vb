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
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.txtCmrId = New System.Windows.Forms.TextBox()
        Me.btnInsertCustomer = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTlf = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtCmrEmail = New System.Windows.Forms.TextBox()
        Me.txtCmrPhone = New System.Windows.Forms.TextBox()
        Me.txtCmrLastname = New System.Windows.Forms.TextBox()
        Me.txtCmrFirstname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(57, 81)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(66, 17)
        Me.lblCustID.TabIndex = 59
        Me.lblCustID.Text = "KundeID:"
        '
        'txtCmrId
        '
        Me.txtCmrId.Enabled = False
        Me.txtCmrId.Location = New System.Drawing.Point(131, 81)
        Me.txtCmrId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCmrId.Name = "txtCmrId"
        Me.txtCmrId.Size = New System.Drawing.Size(188, 22)
        Me.txtCmrId.TabIndex = 58
        '
        'btnInsertCustomer
        '
        Me.btnInsertCustomer.Location = New System.Drawing.Point(131, 239)
        Me.btnInsertCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertCustomer.Name = "btnInsertCustomer"
        Me.btnInsertCustomer.Size = New System.Drawing.Size(188, 28)
        Me.btnInsertCustomer.TabIndex = 57
        Me.btnInsertCustomer.Text = "Opprett Kunde"
        Me.btnInsertCustomer.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(57, 209)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 17)
        Me.lblEmail.TabIndex = 56
        Me.lblEmail.Text = "Epost:"
        '
        'lblTlf
        '
        Me.lblTlf.AutoSize = True
        Me.lblTlf.Location = New System.Drawing.Point(57, 177)
        Me.lblTlf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(60, 17)
        Me.lblTlf.TabIndex = 55
        Me.lblTlf.Text = "Telefon:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(57, 145)
        Me.lblLname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(73, 17)
        Me.lblLname.TabIndex = 54
        Me.lblLname.Text = "Etternavn:"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(57, 113)
        Me.lblFname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(64, 17)
        Me.lblFname.TabIndex = 53
        Me.lblFname.Text = "Fornavn:"
        '
        'txtCmrEmail
        '
        Me.txtCmrEmail.Location = New System.Drawing.Point(131, 209)
        Me.txtCmrEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCmrEmail.Name = "txtCmrEmail"
        Me.txtCmrEmail.Size = New System.Drawing.Size(188, 22)
        Me.txtCmrEmail.TabIndex = 52
        '
        'txtCmrPhone
        '
        Me.txtCmrPhone.Location = New System.Drawing.Point(131, 177)
        Me.txtCmrPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCmrPhone.Name = "txtCmrPhone"
        Me.txtCmrPhone.Size = New System.Drawing.Size(188, 22)
        Me.txtCmrPhone.TabIndex = 51
        '
        'txtCmrLastname
        '
        Me.txtCmrLastname.Location = New System.Drawing.Point(131, 145)
        Me.txtCmrLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCmrLastname.Name = "txtCmrLastname"
        Me.txtCmrLastname.Size = New System.Drawing.Size(188, 22)
        Me.txtCmrLastname.TabIndex = 50
        '
        'txtCmrFirstname
        '
        Me.txtCmrFirstname.Location = New System.Drawing.Point(131, 113)
        Me.txtCmrFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCmrFirstname.Name = "txtCmrFirstname"
        Me.txtCmrFirstname.Size = New System.Drawing.Size(188, 22)
        Me.txtCmrFirstname.TabIndex = 49
        '
        'CustomerTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 357)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.txtCmrId)
        Me.Controls.Add(Me.btnInsertCustomer)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTlf)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtCmrEmail)
        Me.Controls.Add(Me.txtCmrPhone)
        Me.Controls.Add(Me.txtCmrLastname)
        Me.Controls.Add(Me.txtCmrFirstname)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CustomerTest"
        Me.Text = "CustomerTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents txtCmrId As System.Windows.Forms.TextBox
    Friend WithEvents btnInsertCustomer As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTlf As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents txtCmrEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCmrPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCmrLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtCmrFirstname As System.Windows.Forms.TextBox
End Class
