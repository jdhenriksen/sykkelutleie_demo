Public Class mailLogin
    Public epostAdresse As String
    Public passord As String

    'BUTTON: Logger inn for å kunne sende epost.
    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMailogon.Click
        epostAdresse = txtEmailAdress.Text
        passord = txtMailLoginPass.Text
        Me.Close()
    End Sub
End Class