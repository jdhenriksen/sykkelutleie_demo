''' <summary>
''' Form som holder grensestittet til Sjef/sekretær aktør
''' </summary>
''' <remarks></remarks>
Public Class AdminForm
    Public startDate As String  'Public variabler som hentes fra kalender og combobox. De skal nåes fra StatisticsView
    Public endDate As String
    Public statisticsType As String
    Public limitResult As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        AccountTest.Show()
    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Label6.Text = Format(MonthCalendar1.SelectionStart, "yyyy/MM/dd")
    End Sub
    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Label8.Text = Format(MonthCalendar2.SelectionEnd, "yyyy/MM/dd")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label10.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label12.Text = NumericUpDown1.Value
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MonthCalendar1.Enabled = False
            Label6.Text = "2015/01/01"
        Else
            MonthCalendar1.Enabled = True
            Label6.Text = Format(MonthCalendar1.SelectionStart, "yyyy/MM/dd")
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            MonthCalendar2.Enabled = False
            Label8.Text = "2099/01/01"
        Else
            MonthCalendar2.Enabled = True
            Label8.Text = Format(MonthCalendar2.SelectionEnd, "yyyy/MM/dd")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startDate = Label6.Text
        endDate = Label8.Text
        statisticsType = Label10.Text
        limitResult = Label12.Text
        StatisticsView.Show()
    End Sub


End Class