﻿Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim
        Dim password As String = txtPassword.Text.Trim

        If username = "" Or password = "" Then
            MsgBox("Vennligst skriv inn både brukernavn og passord.")
            Exit Sub
        End If

        Dim account As New Account(username, password)
        Dim table As DataTable = account.login()
        Dim jobDesc As String = ""
        If table.Rows.Count > 0 Then
            jobDesc = table.Rows(0).Item("stilling")
            MsgBox("Brukerkonto funnet. Du er logget inn som:" & vbCrLf & jobDesc)
        Else
            MsgBox("Kombinasjonen av brukernavn og passord finnes ikke i databasen.")
        End If

        jobDesc = jobDesc.ToLower
        Select Case jobDesc
            Case "lagerarbeider"
                StorageWorker.Show()
            Case "selger"
                OrderTest.Show()
            Case "sekretær", "daglig leder"
                AdminForm.Show()
            Case Else
        End Select

        txtPassword.Clear()
        txtUsername.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnOpenDatabaseTest.Click
        DBTest.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnOpenAdminForm.Click
        AdminForm.Show()
    End Sub

    Private Sub btnEmployeeTest_Click(sender As Object, e As EventArgs) Handles btnOpenEmployeeTest.Click
        EmployeeTest.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpenStorageWorkerTest.Click
        StorageWorker.Show()
    End Sub

    Private Sub btnOpenMailTest_Click(sender As Object, e As EventArgs) Handles btnOpenMailTest.Click
        MailTest.Show()
    End Sub

    Private Sub btnOpenOrderTest_Click(sender As Object, e As EventArgs) Handles btnOpenOrderTest.Click
        OrderTest.Show()
    End Sub

    Private Sub btnCustomerTest_Click_2(sender As Object, e As EventArgs) Handles btnCustomerTest.Click
        CustomerTest.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin
    End Sub
End Class
