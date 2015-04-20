Public Class CustomerTest

    Private customer As Customer
    Private dbutil As DBUtility
    Private table As DataTable

    'BUTTON: Henter informasjon fra tekstfelt og sender dette videre for skriving til database.
    Private Sub btnInsertCustomer_Click(sender As Object, e As EventArgs) Handles btnInsertCustomer.Click
        Dim firstname As String = txtCmrFirstname.Text
        Dim lastname As String = txtCmrLastname.Text
        Dim phone As String = txtCmrPhone.Text
        Dim email As String = txtCmrEmail.Text

        customer = New Customer(firstname, lastname, phone, email)
        customer.createCustomer()
        Me.Close()
    End Sub

    'EVENT: Når vinduet lukkes (skjer hver gang en kunde opprettes) oppdateres
    'GridView i OrderForm, ettersom det er her kundene vises.
    Private Sub CustomerTest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        OrderTest.updateCustomerGridView()
    End Sub
End Class