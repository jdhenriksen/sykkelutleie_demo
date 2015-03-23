Public Class CustomerTest

    Private cmr As Customer
    Private Sub btnInsertCustomer_Click(sender As Object, e As EventArgs) Handles btnInsertCustomer.Click
        Dim firstname As String = txtCmrFirstname.Text
        Dim lastname As String = txtCmrLastname.Text
        Dim phone As String = txtCmrPhone.Text
        Dim email As String = txtCmrEmail.Text

        cmr = New Customer(firstname, lastname, phone, email)
        rtbCustomerTest.Text = cmr.toString()
        cmr.createCustomer()
    End Sub

    Private Sub btnSelectAllCustomers_Click(sender As Object, e As EventArgs) Handles btnSelectAllCustomers.Click
        Dim dbutil As New DBUtility
        Dim table As New DataTable
        table = dbutil.selectQuery("SELECT * FROM kunde")
        dgvCustomerTest.DataSource = table
    End Sub

    Private Sub btnSearchForCmrById_Click(sender As Object, e As EventArgs) Handles btnSearchForCmrById.Click
        Dim id As String = txtCmrId.Text
        cmr = New Customer()
        dgvCustomerTest.DataSource = cmr.selectCustomerById(id)
    End Sub

    Private Sub btnActiveTest_Click(sender As Object, e As EventArgs) Handles btnActiveTest.Click
        Dim textBoxArr() As TextBox = {txtCmrId, txtCmrFirstname, txtCmrLastname, txtCmrPhone, txtCmrEmail}
        If Not cmr.isActive() Then
            For Each txtBox In textBoxArr
                txtBox.Enabled = False
            Next
        End If
    End Sub

    Private Sub btnSetActiveToZero_Click(sender As Object, e As EventArgs) Handles btnSetActiveToZero.Click
        Dim dbutil As New DBUtility
        dbutil.updateQuery("UPDATE kunde SET aktivert = 0 WHERE kid = " & cmr.getCustomerID() & ";")
        cmr.setActive(0) 'Må gjøres i programmet og DB i samme steg...
    End Sub

    Private Sub btnSendInfoToTxt_Click(sender As Object, e As EventArgs) Handles btnSendInfoToTxt.Click
        Dim rowIndex As Integer = dgvCustomerTest.CurrentCellAddress.Y
        Dim cmrId As String = dgvCustomerTest.Rows(rowIndex).Cells(0).Value.ToString()
        Dim table As New DataTable
        Dim dbutil As New DBUtility

        table = dbutil.selectQuery("SELECT * FROM kunde WHERE kid = " & cmrId)

        txtCmrId.Enabled = False
        txtCmrId.Text = cmrId
        txtCmrFirstname.Text = table.Rows(0)(1).ToString()
        txtCmrLastname.Text = table.Rows(0)(2).ToString()
        txtCmrPhone.Text = table.Rows(0)(3).ToString()
        txtCmrEmail.Text = table.Rows(0)(4).ToString()

    End Sub

    Private Sub btnUpdateCmr_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        cmr.editCustomer(txtCmrId.Text)
    End Sub
End Class