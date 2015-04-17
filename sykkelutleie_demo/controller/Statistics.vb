''' <summary>
''' Klasse som holder statistikk funksjonalitet
''' </summary>
''' <remarks></remarks>
Public Class Statistics
    Private type As String
    Private startDate As String
    Private endDate As String
    Private resultLimit As Integer

    Public Sub New(type As String, startDate As String, endDate As String, resultLimit As Integer)
        Me.type = type
        Me.startDate = startDate
        Me.endDate = endDate
        Me.resultLimit = resultLimit
    End Sub

    Public Function generateStatistics() As DataTable
        Dim query As String
        Dim sqlRes As New SQLRes
        Dim dbUtil As New DBUtility

        With dbUtil
            .addParametersToQuery("@limit", resultLimit, DbType.Int64)
            .addParametersToQuery("@startDate", startDate)
            .addParametersToQuery("@endDate", endDate)
        End With

        Select Case type
            Case "Dyreste sykkel"
                query = sqlRes.sqlMostExpensiveBicycles
            Case "Billigste sykkel"
                query = sqlRes.sqlCheapestBicycles
            Case "Mest aktive selger"
                query = sqlRes.sqlMostActiveSalesman
            Case "Minst aktive selger"
                query = sqlRes.sqlLeastActiveSalesman
            Case "Avanse"
                query = sqlRes.sqlSalesIncomeBicycles
            Case "Antall bestillinger"
                query = sqlRes.sqlCountOrders
            Case "Mest populære sykler"
                query = sqlRes.sqlCountMosteActiveBicycles
            Case "Minst populære sykler"
                query = sqlRes.sqlCountLeastActiveBicycles
            Case Else
                statisticsTypeError()
                Return Nothing
        End Select
        Return dbUtil.paramQuery(query)
    End Function

    Private Sub statisticsTypeError()
        MsgBox("Valgt SQL spørring finnes ikke")
    End Sub
End Class
