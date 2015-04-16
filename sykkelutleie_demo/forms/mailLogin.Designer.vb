<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mailLogin
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
        Me.lblNotat = New System.Windows.Forms.Label()
        Me.btnMailogon = New System.Windows.Forms.Button()
        Me.txtMailLoginPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmailAdress = New System.Windows.Forms.TextBox()
        Me.lblEmailAdress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNotat
        '
        Me.lblNotat.AutoSize = True
        Me.lblNotat.Location = New System.Drawing.Point(115, 140)
        Me.lblNotat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotat.Name = "lblNotat"
        Me.lblNotat.Size = New System.Drawing.Size(292, 17)
        Me.lblNotat.TabIndex = 17
        Me.lblNotat.Text = "Trenger ikke skrive noe hær... er hardkodet.."
        '
        'btnMailogon
        '
        Me.btnMailogon.Location = New System.Drawing.Point(119, 256)
        Me.btnMailogon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMailogon.Name = "btnMailogon"
        Me.btnMailogon.Size = New System.Drawing.Size(259, 28)
        Me.btnMailogon.TabIndex = 16
        Me.btnMailogon.Text = "Ok"
        Me.btnMailogon.UseVisualStyleBackColor = True
        '
        'txtMailLoginPass
        '
        Me.txtMailLoginPass.Location = New System.Drawing.Point(119, 224)
        Me.txtMailLoginPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMailLoginPass.Name = "txtMailLoginPass"
        Me.txtMailLoginPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMailLoginPass.Size = New System.Drawing.Size(257, 22)
        Me.txtMailLoginPass.TabIndex = 15
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(51, 227)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 17)
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Text = "Passord"
        '
        'txtEmailAdress
        '
        Me.txtEmailAdress.Location = New System.Drawing.Point(119, 170)
        Me.txtEmailAdress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailAdress.Name = "txtEmailAdress"
        Me.txtEmailAdress.Size = New System.Drawing.Size(257, 22)
        Me.txtEmailAdress.TabIndex = 13
        '
        'lblEmailAdress
        '
        Me.lblEmailAdress.AutoSize = True
        Me.lblEmailAdress.Location = New System.Drawing.Point(9, 173)
        Me.lblEmailAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailAdress.Name = "lblEmailAdress"
        Me.lblEmailAdress.Size = New System.Drawing.Size(104, 17)
        Me.lblEmailAdress.TabIndex = 12
        Me.lblEmailAdress.Text = "E-post adresse"
        '
        'mailLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 455)
        Me.Controls.Add(Me.lblNotat)
        Me.Controls.Add(Me.btnMailogon)
        Me.Controls.Add(Me.txtMailLoginPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtEmailAdress)
        Me.Controls.Add(Me.lblEmailAdress)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "mailLogin"
        Me.Text = "mailLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNotat As System.Windows.Forms.Label
    Friend WithEvents btnMailogon As System.Windows.Forms.Button
    Friend WithEvents txtMailLoginPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtEmailAdress As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailAdress As System.Windows.Forms.Label
End Class
