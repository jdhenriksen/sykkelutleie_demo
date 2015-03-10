Public Class Form1
    Dim anySqlQuery As New DBUtility

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.DataSource = anySqlQuery.query("SELECT * FROM ansatt")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim celle As Integer
        TextBox1.Text = DataGridView1.CurrentCell.Value
        celle = DataGridView1.CurrentCell.ColumnIndex + 1

        TextBox2.Text = DataGridView1.CurrentRow.Cells(celle).Value
    End Sub
End Class
