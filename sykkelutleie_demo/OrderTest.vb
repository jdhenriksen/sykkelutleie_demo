Public Class OrderTest

    Private Sub btnOrderTest_Click(sender As Object, e As EventArgs) Handles btnOrderTest.Click
        Dim order As New Order()
        rtbOrderTest.Text = order.toString()
    End Sub
End Class