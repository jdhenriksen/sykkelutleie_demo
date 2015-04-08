''' <summary>
''' Behandler sykkel bestillinger
''' </summary>
''' <remarks></remarks>
Public Class BicycleOrder
    Private orderId As String
    Private frameNumber As String

    Public Sub New(orderId As String, frameNumber As String)
        Me.orderId = orderId
        Me.frameNumber = frameNumber
    End Sub
    ''' <summary>
    ''' Skriver til koplingstabellen sykkelBestilling
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub registerBicycleOrder()
        Dim dbutil As New DBUtility
        Dim sql As String

        sql = "INSERT INTO `14badr05`.`sykkel_bestilling` (`bestillingsid`, `rammenr`) VALUES ('" & orderId & "', '" & frameNumber & "');"

        dbutil.updateQuery(sql)
    End Sub
End Class
