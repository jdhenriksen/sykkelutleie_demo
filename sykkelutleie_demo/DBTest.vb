Public Class DBTest
    Dim anySqlQuery As New DBUtility

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.DataSource = anySqlQuery.selectQuery("SELECT * FROM ansatt")


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim celle As Integer
        TextBox1.Text = DataGridView1.CurrentCell.Value
        celle = DataGridView1.CurrentCell.ColumnIndex + 1

        TextBox2.Text = DataGridView1.CurrentRow.Cells(celle).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If anySqlQuery.updateQuary("INSERT INTO  `adr05`.`ansatt` (`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)VALUES ('testbrukernavn',  'testpassord',  'Per',  'Olav',  '8888887',  'test@mail.cns',  'testveien 118',  'Lagerarbeider',  '7020',  '1')") = True Then
            MsgBox("INSERT vellykket")
        End If



    End Sub
End Class
