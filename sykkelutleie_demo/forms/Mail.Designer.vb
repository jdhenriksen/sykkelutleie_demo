<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mail
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
        Me.lblContent = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.rtbContent = New System.Windows.Forms.RichTextBox()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(56, 142)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(58, 17)
        Me.lblContent.TabIndex = 34
        Me.lblContent.Text = "Innhold:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(56, 74)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 17)
        Me.lblFrom.TabIndex = 33
        Me.lblFrom.Text = "Fra:"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(117, 108)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(252, 22)
        Me.txtSubject.TabIndex = 32
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(56, 40)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(27, 17)
        Me.lblTo.TabIndex = 31
        Me.lblTo.Text = "Til:"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(117, 74)
        Me.txtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(252, 22)
        Me.txtFrom.TabIndex = 30
        Me.txtFrom.Text = "vbtestsomo@gmail.com"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(56, 108)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(48, 17)
        Me.lblSubject.TabIndex = 29
        Me.lblSubject.Text = "Emne:"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(117, 40)
        Me.txtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(252, 22)
        Me.txtTo.TabIndex = 28
        '
        'rtbContent
        '
        Me.rtbContent.Location = New System.Drawing.Point(117, 142)
        Me.rtbContent.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbContent.Name = "rtbContent"
        Me.rtbContent.Size = New System.Drawing.Size(252, 223)
        Me.rtbContent.TabIndex = 27
        Me.rtbContent.Text = ""
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(117, 373)
        Me.btnSendMail.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(252, 36)
        Me.btnSendMail.TabIndex = 26
        Me.btnSendMail.Text = "Send E-Post"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'MailTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 455)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.rtbContent)
        Me.Controls.Add(Me.btnSendMail)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MailTest"
        Me.Text = "MailTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents rtbContent As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSendMail As System.Windows.Forms.Button
End Class
