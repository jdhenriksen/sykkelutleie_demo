<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderTest
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
        Me.rtbOrderTest = New System.Windows.Forms.RichTextBox()
        Me.btnOrderTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbOrderTest
        '
        Me.rtbOrderTest.Location = New System.Drawing.Point(236, 19)
        Me.rtbOrderTest.Name = "rtbOrderTest"
        Me.rtbOrderTest.Size = New System.Drawing.Size(283, 271)
        Me.rtbOrderTest.TabIndex = 0
        Me.rtbOrderTest.Text = ""
        '
        'btnOrderTest
        '
        Me.btnOrderTest.Location = New System.Drawing.Point(444, 296)
        Me.btnOrderTest.Name = "btnOrderTest"
        Me.btnOrderTest.Size = New System.Drawing.Size(75, 23)
        Me.btnOrderTest.TabIndex = 1
        Me.btnOrderTest.Text = "TestOrdre"
        Me.btnOrderTest.UseVisualStyleBackColor = True
        '
        'OrderTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 325)
        Me.Controls.Add(Me.btnOrderTest)
        Me.Controls.Add(Me.rtbOrderTest)
        Me.Name = "OrderTest"
        Me.Text = "OrderTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbOrderTest As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOrderTest As System.Windows.Forms.Button
End Class
