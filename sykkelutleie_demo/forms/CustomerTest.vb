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
        Me.Hide()
    End Sub
    
End Class