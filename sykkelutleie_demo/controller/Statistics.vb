''' <summary>
''' Klasse som holder statistikk funksjonalitet
''' </summary>
''' <remarks></remarks>
Public Class Statistics
    Private typeStatistic As String
    Private startDate As String
    Private endDate As String
    Private limitResult As Integer

    Public Sub New(ByVal typeStatistic As String, ByVal startDate As String, ByVal endDate As String, ByVal limitResult As Integer)
        Me.typeStatistic = typeStatistic
        Me.startDate = startDate
        Me.endDate = endDate
        Me.limitResult = limitResult

    End Sub

    Public Function generateStatistics() As DataTable
        Dim query As String
        Dim sqlRes As New SQLRes
        Dim dbUtil As New DBUtility

        With dbUtil
            .addParametersToQuery("@limit", limitResult, DbType.Int64)
            .addParametersToQuery("@startDate", startDate)
            .addParametersToQuery("@endDate", endDate)
        End With


        Select Case typeStatistic
            Case "Dyreste sykkel"
                query = sqlRes.mostExpensiveBicycles

            Case "Billigste sykkel"
                query = sqlRes.cheapestBicycles

            Case "Mest aktive selger"
                query = sqlRes.mostActiveSalesman

            Case "Minst aktive selger"
                query = sqlRes.leastActiveSalesman

            Case "Avanse"
                query = sqlRes.avanseBicycles

            Case "Antall bestillinger"
                query = sqlRes.countOrders

            Case "Mest populære sykler"
                query = sqlRes.countMosteActiveBicycles

            Case "Minst populære sykler"
                query = sqlRes.countLeastActiveBicycles

            Case Else
                statisticsTypeError()
                Return Nothing
        End Select
        ' Dim dbUtil As New DBUtility(query)


        Return dbUtil.paramQuery(query) 'dbUtil.selectQuery
    End Function

    Private Sub statisticsTypeError()
        MsgBox("Valgt SQL spørring finnes ikke")
    End Sub

End Class
