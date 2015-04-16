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
        Return dbUtil.paramQuery(query)
    End Function

    Private Sub statisticsTypeError()
        MsgBox("Valgt SQL spørring finnes ikke")
    End Sub
End Class
