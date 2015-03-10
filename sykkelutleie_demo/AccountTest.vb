Public Class AccountTest
    Private a1 As Account
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        a1 = New Account(InputBox("Brukernavn:"), InputBox("Passord:"))
        MsgBox(a1.toString)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        If a1.login(username, password) Then
            AccountTest2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChangeUsername.Click
        a1.uname = InputBox("Skriv inn nytt brukernavn")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        a1.pwd = InputBox("Skriv inn nytt passord")
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        MsgBox(a1.toString)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        DBTest.Show()
    End Sub
End Class
