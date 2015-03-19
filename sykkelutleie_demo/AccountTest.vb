Public Class AccountTest

    Private dbutil As New DBUtility
    Private sql As String
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub showAllEmployees()
        sql = "SELECT * FROM ansatt"
        Dim table As DataTable = dbutil.selectQuery(sql)
        dgvAccount.DataSource = table
    End Sub

    Private Sub btnShowAllEmployees_Click(sender As Object, e As EventArgs) Handles btnShowAllEmployees.Click
        showAllEmployees()
    End Sub

    Private Sub btnChangeUsername_Click(sender As Object, e As EventArgs) Handles btnChangeUsername.Click
        Dim newName As String = InputBox("Gjør om brukernavn til:")
        sql = "UPDATE ansatt SET brukernavn = '" & newName & "' WHERE ansattid > 1"
        If dbutil.updateQuery(sql) Then
            showAllEmployees()
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim newPassword As String = InputBox("Endre passord til:")
        Dim acc As Account = New Account("Hashtest", newPassword)
        sql = "UPDATE ansatt SET passord = '" & acc.password & "' WHERE ansattid > 1"
        If dbutil.updateQuery(sql) Then
            showAllEmployees()
        End If
    End Sub

    Private Sub dgvAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellDoubleClick

        Dim row As String = dgvAccount.CurrentCell.RowIndex
        Dim col As String = dgvAccount.CurrentCell.ColumnIndex
        MsgBox(row & ", " & col)
        'Dim out As String = dgvAccount.Rows(row).Cells(col).Value
        'MsgBox(out)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

    End Sub
End Class