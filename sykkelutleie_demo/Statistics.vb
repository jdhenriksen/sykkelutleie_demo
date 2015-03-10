''' <summary>
''' Klasse som holder statistikk funksjonalitet
''' </summary>
''' <remarks></remarks>
Public Class Statistics
    Public Function generateStatistics(ByVal typeStatistic As String, ByVal startDate As Date, ByVal endDate As Date) As DataTable
        Dim query As String
        Dim sqlRes As New SQLRes
        Dim DButil As New DBUtility
        'Dim typeWhereDate As String

        Select Case typeStatistic
            Case "Dyreste sykkel"
                query = sqlRes.costliestBicycle
            Case "Billigste sykkel"
                query = sqlRes.cheapestBicycle
            Case "Mest aktive selger"
                query = sqlRes.mosteActiveSalesman & "WHERE datotid BETWEEN '" & startDate & "' AND '" & endDate & "'"

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
