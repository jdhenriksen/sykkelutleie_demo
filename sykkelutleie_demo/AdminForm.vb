''' <summary>
''' Form som holder grensestittet til Sjef/sekretær aktør
''' </summary>
''' <remarks></remarks>
Public Class AdminForm
    Public startDate As String
    Public endDate As String
    Public statisticsType As String
    Public limitResult As Integer
    Private Sub endApplication(sender As Object, e As EventArgs) Handles BtnEndApplication.Click
        End
    End Sub

    Private Sub CalendarFrom_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarFrom.DateChanged
        LabelDispFromDate.Text = Format(CalendarFrom.SelectionStart, "yyyy/MM/dd")
    End Sub
    Private Sub CalenderTo_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarTo.DateChanged
        LabelDispToDate.Text = Format(CalendarTo.SelectionEnd, "yyyy/MM/dd")
    End Sub
    Private Sub CmbBxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBxType.SelectedIndexChanged
        LabelDispType.Text = CmbBxType.SelectedItem
    End Sub

    Private Sub NumericUpDownAntall_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownAntall.ValueChanged
        LabelDispAntall.Text = NumericUpDownAntall.Value
    End Sub
    Private Sub chkBxAllTimeStart_CheckedChanged(sender As Object, e As EventArgs) Handles chkBxAllTimeStart.CheckedChanged
        If chkBxAllTimeStart.Checked = True Then
            CalendarFrom.Enabled = False
            LabelDispFromDate.Text = "2015/01/01"
        Else
            CalendarFrom.Enabled = True
            LabelDispFromDate.Text = Format(CalendarFrom.SelectionStart, "yyyy/MM/dd")
        End If
    End Sub

    Private Sub chkBxAllTimeEnd_CheckedChanged(sender As Object, e As EventArgs) Handles chkBxAllTimeEnd.CheckedChanged
        If chkBxAllTimeEnd.Checked = True Then
            CalendarTo.Enabled = False
            LabelDispToDate.Text = "2099/01/01"
        Else
            CalendarTo.Enabled = True
            LabelDispToDate.Text = Format(CalendarTo.SelectionEnd, "yyyy/MM/dd")
        End If
    End Sub
    Private Sub btnDisplayStatistics_Click(sender As Object, e As EventArgs) Handles btnDisplayStatistics.Click
        startDate = LabelDispFromDate.Text
        endDate = LabelDispToDate.Text
        statisticsType = LabelDispType.Text
        limitResult = LabelDispAntall.Text


        Dim myStatistic As New Statistics(statisticsType, startDate, endDate, limitResult)
        Dim result As DataTable = myStatistic.generateStatistics()

        If result.Rows.Count = 0 Then
            MsgBox("Ingen data ble funnet på valgt filter")
        Else
            StatisticsView.Show()
            StatisticsView.refreshComponents()

        End If
    End Sub

End Class