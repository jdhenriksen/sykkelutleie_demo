Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim
        Dim password As String = txtPassword.Text.Trim

        If username = "" Or password = "" Then
            MsgBox("Vennligst skriv inn både brukernavn og passord.")
            Exit Sub
        End If

        Dim account As New Account(username, password)
        Dim dbutil As New DBUtility
        Dim table As New DataTable
        Dim sql As String = "SELECT brukernavn, passord FROM ansatt WHERE brukernavn LIKE '" & account.getUsername() _
                            & "' AND passord LIKE '" & account.getPassword() & "';"
        table = dbutil.selectQuery(sql)
        If table.Rows.Count > 0 Then
            MsgBox("Brukerkonto funnet. Du redirigeres nå til et nytt skjermbilde.")
            AccountTest.Show()
        Else
            MsgBox("Kombinasjonen av brukernavn og passord finnes ikke i databasen.")
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnOpenDatabaseTest.Click
        Me.Hide()
        DBTest.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnOpenAdminForm.Click
        Me.Hide()
        AdminForm.Show()
    End Sub

    Private Sub btnEmployeeTest_Click(sender As Object, e As EventArgs) Handles btnOpenEmployeeTest.Click
        Me.Hide()
        EmployeeTest.Show()
    End Sub

    Private Sub btnOpenAccountTest_Click(sender As Object, e As EventArgs) Handles btnOpenAccountTest.Click
        Me.Hide()
        AccountTest.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpenStorageWorkerTest.Click

        Me.Hide()
        StorageWorker.Show()

    End Sub

    Private Sub btnOpenMailTest_Click(sender As Object, e As EventArgs) Handles btnOpenMailTest.Click
        Me.Hide()
        MailTest.Show()
    End Sub

    Private Sub btnOpenOrderTest_Click(sender As Object, e As EventArgs) Handles btnOpenOrderTest.Click
        OrderTest.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomerTest_Click_2(sender As Object, e As EventArgs) Handles btnCustomerTest.Click
        CustomerTest.Show()
        Me.Hide()
    End Sub
End Class
