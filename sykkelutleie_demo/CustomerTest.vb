Public Class CustomerTest

    Private cmr As Customer
    Private dbutil As DBUtility
    Private table As DataTable

    Private Sub btnInsertCustomer_Click(sender As Object, e As EventArgs) Handles btnInsertCustomer.Click
        Dim firstname As String = txtCmrFirstname.Text
        Dim lastname As String = txtCmrLastname.Text
        Dim phone As String = txtCmrPhone.Text
        Dim email As String = txtCmrEmail.Text

        cmr = New Customer(firstname, lastname, phone, email)
        cmr.createCustomer()
    End Sub
    Private Sub btnSearchForCmrById_Click(sender As Object, e As EventArgs)
        Dim kid As String = txtCmrId.Text
        cmr = New Customer(kid)
        dgvCustomerTest.DataSource = cmr.selectCustomerById(kid)
        addInfoToTextFields()
    End Sub
    Private Sub btnSelectAllCustomers_Click(sender As Object, e As EventArgs) Handles btnSelectAllCustomers.Click
        getAllCustomers()
    End Sub
    Private Sub getAllCustomers()
        dbutil = New DBUtility
        table = New DataTable
        table = dbutil.selectQuery("SELECT * FROM kunde")
        dgvCustomerTest.DataSource = table
    End Sub
    Private Sub btnSetActiveToZero_Click(sender As Object, e As EventArgs)
        Dim dbutil As New DBUtility
        dbutil.updateQuery("UPDATE kunde SET aktivert = 0 WHERE kid = " & cmr.getCustomerID() & ";")
        cmr.setActive(0) 'Må gjøres i programmet og DB i samme steg...
    End Sub
    Private Sub btnUpdateCmr_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        cmr.editCustomer(txtCmrId.Text)
    End Sub
    Private Sub dgvCustomerTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerTest.CellContentClick
        addInfoToTextFields()
    End Sub

    Private Sub addInfoToTextFields()
        Dim rowIndex As Integer = dgvCustomerTest.CurrentCellAddress.Y
        Dim cmrId As String = dgvCustomerTest.Rows(rowIndex).Cells(0).Value.ToString()
        dbutil = New DBUtility
        table = New DataTable

        table = dbutil.selectQuery("SELECT * FROM kunde WHERE kid = " & cmrId)

        txtCmrId.Enabled = False
        txtCmrId.Text = cmrId
        txtCmrFirstname.Text = table.Rows(0)(1).ToString()
        txtCmrLastname.Text = table.Rows(0)(2).ToString()
        txtCmrPhone.Text = table.Rows(0)(3).ToString()
        txtCmrEmail.Text = table.Rows(0)(4).ToString()
    End Sub

End Class