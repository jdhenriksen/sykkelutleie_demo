Public Class DBTest
    Dim myDBUtil As New DBUtility

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.DataSource = myDBUtil.selectQuery("SELECT * FROM ansatt")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As New SQLRes
        If myDBUtil.updateQuery(query.DBTestInsert) = True Then
            MsgBox("Ny ansatt er opprettet")
        End If
        DataGridView1.DataSource = myDBUtil.selectQuery("SELECT * FROM ansatt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As New SQLRes
        If myDBUtil.updateQuery(query.autoIncrementAs2) = True Then
            MsgBox("Auto Increment er satt til 2, så lenge det ikke eksisterte høyere verdi fra før")
        End If
        DataGridView1.DataSource = myDBUtil.selectQuery("SELECT * FROM ansatt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query As New SQLRes
        If myDBUtil.updateQuery(query.deleteManyAnsatt) = True Then
            MsgBox("Alle ansatt med ansattid høyere en 1 er slettet")
        End If
        DataGridView1.DataSource = myDBUtil.selectQuery("SELECT * FROM ansatt")
    End Sub
End Class
