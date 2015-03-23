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


        Select Case typeStatistic
            Case "Dyreste sykkel"
                query = sqlRes.costliestBicycles & limitResult

            Case "Billigste sykkel"
                query = sqlRes.cheapestBicycles & limitResult

            Case "Mest aktive selger"
                query = sqlRes.mosteActiveSalesman & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "'"

            Case "Minst aktive selger"
                query = sqlRes.leastActiveSalesman & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "' GROUP BY ansatt.ansattid DESC"

            Case "Avanse"
                query = sqlRes.avanseBicycles & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "'"

            Case "Antall bestillinger"
                query = sqlRes.countOrders & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "'"

            Case "Mest populære sykler"
                query = sqlRes.countMosteActiveBicycles & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "' GROUP BY sykkel.rammenr LIMIT " & limitResult

            Case "Minst populære sykler"
                query = sqlRes.countLeastActiveBicycles & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "' GROUP BY sykkel.rammenr DESC LIMIT " & limitResult

            Case Else
                statisticsTypeError()
                Return Nothing
        End Select
        ' Dim dbUtil As New DBUtility(query)


        Return dbUtil.selectQuery(query)'dbUtil.selectQuery
    End Function

    Private Sub statisticsTypeError()
        MsgBox("Valgt SQL spørring finnes ikke")
    End Sub

End Class
