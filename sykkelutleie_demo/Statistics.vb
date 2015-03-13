''' <summary>
''' Klasse som holder statistikk funksjonalitet
''' </summary>
''' <remarks></remarks>
Public Class Statistics
    Public Function generateStatistics(ByVal typeStatistic As String, ByVal startDate As String, ByVal endDate As String, ByVal limitResult As Integer) As DataTable
        Dim query As String
        Dim sqlRes As New SQLRes
        Dim DButil As New DBUtility
        'Dim typeWhereDate As String

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

        Return DButil.selectQuery(query)
    End Function

    Private Sub statisticsTypeError()
        MsgBox("Bare statistikkene 'Billigste-' og 'Dyreste sykkel' kan brukes for øyeblikket")
    End Sub

End Class
