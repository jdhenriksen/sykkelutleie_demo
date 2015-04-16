<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblAmountofhit = New System.Windows.Forms.Label()
        Me.lblResultsnb = New System.Windows.Forms.Label()
        Me.btnStatisticViewClose = New System.Windows.Forms.Button()
        Me.dtgvStatistic = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvStatistic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAmountofhit
        '
        Me.lblAmountofhit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAmountofhit.AutoSize = True
        Me.lblAmountofhit.BackColor = System.Drawing.Color.Silver
        Me.lblAmountofhit.Location = New System.Drawing.Point(16, 428)
        Me.lblAmountofhit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountofhit.Name = "lblAmountofhit"
        Me.lblAmountofhit.Size = New System.Drawing.Size(76, 17)
        Me.lblAmountofhit.TabIndex = 7
        Me.lblAmountofhit.Text = "Antall treff:"
        '
        'lblResultsnb
        '
        Me.lblResultsnb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResultsnb.AutoSize = True
        Me.lblResultsnb.BackColor = System.Drawing.Color.Silver
        Me.lblResultsnb.Location = New System.Drawing.Point(87, 428)
        Me.lblResultsnb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultsnb.Name = "lblResultsnb"
        Me.lblResultsnb.Size = New System.Drawing.Size(51, 17)
        Me.lblResultsnb.TabIndex = 6
        Me.lblResultsnb.Text = "Label1"
        '
        'btnStatisticViewClose
        '
        Me.btnStatisticViewClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStatisticViewClose.Location = New System.Drawing.Point(190, 412)
        Me.btnStatisticViewClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStatisticViewClose.Name = "btnStatisticViewClose"
        Me.btnStatisticViewClose.Size = New System.Drawing.Size(107, 28)
        Me.btnStatisticViewClose.TabIndex = 5
        Me.btnStatisticViewClose.Text = "Close"
        Me.btnStatisticViewClose.UseVisualStyleBackColor = True
        '
        'dtgvStatistic
        '
        Me.dtgvStatistic.AllowUserToAddRows = False
        Me.dtgvStatistic.AllowUserToDeleteRows = False
        Me.dtgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvStatistic.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvStatistic.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvStatistic.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvStatistic.Location = New System.Drawing.Point(0, 0)
        Me.dtgvStatistic.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgvStatistic.MinimumSize = New System.Drawing.Size(67, 0)
        Me.dtgvStatistic.Name = "dtgvStatistic"
        Me.dtgvStatistic.ReadOnly = True
        Me.dtgvStatistic.RowHeadersVisible = False
        Me.dtgvStatistic.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvStatistic.Size = New System.Drawing.Size(482, 455)
        Me.dtgvStatistic.TabIndex = 4
        '
        'StatisticsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 455)
        Me.Controls.Add(Me.lblAmountofhit)
        Me.Controls.Add(Me.lblResultsnb)
        Me.Controls.Add(Me.btnStatisticViewClose)
        Me.Controls.Add(Me.dtgvStatistic)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "StatisticsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StatisticsView"
        Me.TopMost = True
        CType(Me.dtgvStatistic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmountofhit As System.Windows.Forms.Label
    Friend WithEvents lblResultsnb As System.Windows.Forms.Label
    Friend WithEvents btnStatisticViewClose As System.Windows.Forms.Button
    Friend WithEvents dtgvStatistic As System.Windows.Forms.DataGridView
End Class
