''' <summary>
''' Testklasse for Employee-klassen.
''' </summary>
''' <remarks></remarks>
Public Class EmployeeTest

    Private emp As Employee
    Private Sub btnCreateEmployee_Click(sender As Object, e As EventArgs) Handles btnCreateEmployee.Click
        Dim firstname As String = txtEmpFirstname.Text
        Dim lastname As String = txtEmpLastname.Text
        Dim phone As String = txtEmpPhone.Text
        Dim email As String = txtEmpEmail.Text
        Dim job As String = txtEmpJobTitle.Text
        Dim username As String = txtEmpUsername.Text
        Dim password As String = txtEmpPassword.Text

        emp = New Employee(firstname, lastname, phone, email, job, username, password)
        rtbEmployeeTest.Text = emp.toString()
    End Sub

    Private Sub btnCreateEmpTest_Click(sender As Object, e As EventArgs) Handles btnCreateEmpTest.Click
        emp = New Employee()
        rtbEmployeeTest.Text = emp.toString()
    End Sub
End Class