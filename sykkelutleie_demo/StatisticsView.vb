''' <summary>
''' Form som viser statistikk som er valgt i AdminForm
''' </summary>
''' <remarks></remarks>
Public Class StatisticsView

    Private Sub StatisticsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myStatistic As New Statistics
        Dim result As DataTable

        result = myStatistic.generateStatistics(AdminForm.statisticsType, AdminForm.startDate, AdminForm.endDate)
        If result.Rows.Count = 0 Then
            MsgBox("Ingen data ble funnet på valgt filter")
        End If
        DataGridView1.DataSource = result
        Label1.Text = result.Rows.Count
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
   
End Class