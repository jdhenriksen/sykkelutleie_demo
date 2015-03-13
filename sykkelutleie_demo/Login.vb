Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        AccountTest.Show()
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
End Class
