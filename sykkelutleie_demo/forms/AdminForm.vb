''' <summary>
''' Håndterer oppgaver i forbindelse med visning av statistikk.
''' </summary>
''' <remarks></remarks>
Public Class AdminForm
    Public startDate As String
    Public endDate As String
    Public statisticsType As String
    Public limitResult As Integer

    'BUTTON: Lukker vindu (Form).
    Private Sub endApplication() Handles BtnEndApplication.Click
        Me.Close()
    End Sub

    'EVENT: Formaterer dato for valgt fra-tidspunkt i kalender.
    Private Sub CalendarFrom_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarFrom.DateChanged
        LabelDispFromDate.Text = Format(CalendarFrom.SelectionStart, "yyyy/MM/dd")
    End Sub

    'EVENT: Formaterer dato for valgt til-tidspunkt i kalender.
    Private Sub CalenderTo_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarTo.DateChanged
        LabelDispToDate.Text = Format(CalendarTo.SelectionEnd, "yyyy/MM/dd")
    End Sub

    'EVENT: Oppdaterer label basert på valgt type statistikk fra ComboBox.
    Private Sub CmbBxType_SelectedIndexChanged() Handles CmbBxType.SelectedIndexChanged
        LabelDispType.Text = CmbBxType.SelectedItem
    End Sub

    'EVENT: Oppdaterer label basert på verdi i antall-felt.
    Private Sub NumericUpDownAntall_ValueChanged() Handles NumericUpDownAntall.ValueChanged
        LabelDispAntall.Text = NumericUpDownAntall.Value
    End Sub

    'EVENT: Håndterer logikk forbundet med sjekkboks for statistikk med startdato 'Fra tidenes morgen'.
    Private Sub chkBxAllTimeStart_CheckedChanged() Handles chkBxAllTimeStart.CheckedChanged
        If chkBxAllTimeStart.Checked = True Then
            CalendarFrom.Enabled = False
            LabelDispFromDate.Text = "2015/01/01"
        Else
            CalendarFrom.Enabled = True
            LabelDispFromDate.Text = Format(CalendarFrom.SelectionStart, "yyyy/MM/dd")
        End If
    End Sub

    'EVENT: Håndterer logikk forbundet med sjekkboks for statistikk med sluttdato 'For all tid'.
    Private Sub chkBxAllTimeEnd_CheckedChanged() Handles chkBxAllTimeEnd.CheckedChanged
        If chkBxAllTimeEnd.Checked = True Then
            CalendarTo.Enabled = False
            LabelDispToDate.Text = "2099/01/01"
        Else
            CalendarTo.Enabled = True
            LabelDispToDate.Text = Format(CalendarTo.SelectionEnd, "yyyy/MM/dd")
        End If
    End Sub

    'BUTTON: Henter ut og viser statistikk basert på valg i brukergrensesnittet.
    Private Sub btnDisplayStatistics_Click() Handles btnDisplayStatistics.Click
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