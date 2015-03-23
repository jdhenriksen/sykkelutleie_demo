Public Class mailLogin
    Public epostAdresse As String
    Public passord As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        epostAdresse = TextBox1.Text
        passord = TextBox2.Text
        Me.Close()

    End Sub

End Class