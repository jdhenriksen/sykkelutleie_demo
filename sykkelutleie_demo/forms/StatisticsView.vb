''' <summary>
''' Form som viser statistikk som er valgt i AdminForm
''' </summary>
''' <remarks></remarks>
Public Class StatisticsView
    ''' <summary>
    ''' Viser statistikk i eget vindu.
    ''' </summary>
    ''' <remarks>Justere bredde og høyde automatisk etter treff i databasen.</remarks>
    Public Sub refreshComponents()
        Dim myStatistic As New Statistics(AdminForm.statisticsType, AdminForm.startDate, AdminForm.endDate, AdminForm.limitResult)
        Dim result As DataTable

        result = myStatistic.generateStatistics()

        dtgvStatistic.DataSource = result
        lblResultsnb.Text = result.Rows.Count

        Me.Width = (result.Columns.Count * 100)
        Me.Height = (result.Rows.Count * 41 + 50)  'Hva skjer ved veldig mange treff..

    End Sub
    Private Sub closeStatistic(sender As Object, e As EventArgs) Handles btnStatisticViewClose.Click
        Me.Close()
    End Sub
End Class