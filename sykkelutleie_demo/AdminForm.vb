''' <summary>
''' Form som holder grensestittet til Sjef/sekretær aktør
''' </summary>
''' <remarks></remarks>
Public Class AdminForm
    Public startDate As Date  'Public variabler som hentes fra kalender og combobox. De skal nåes fra StatisticsView
    Public endDate As Date
    Public statisticsType As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Login.Show()
    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Label6.Text = Format(MonthCalendar1.SelectionStart)
    End Sub
    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Label8.Text = Format(MonthCalendar2.SelectionStart)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label10.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label12.Text = NumericUpDown1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startDate = Format("yyyy/MM/dd", MonthCalendar1.SelectionStart)
        endDate = Format(MonthCalendar2.SelectionEnd, "yyyy/MM/dd")
        statisticsType = Label10.Text
        StatisticsView.Show()
    End Sub
End Class