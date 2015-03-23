''' <summary>
''' Testklasse for Employee-klassen.
''' </summary>
''' <remarks></remarks>
Public Class EmployeeTest

    Private emp As Employee
    Private dbutil As DBUtility
    Private table As DataTable

    Private Sub btnInsertEmployee_Click(sender As Object, e As EventArgs) Handles btnInsertEmployee.Click
        Dim firstname As String = txtEmpFirstname.Text
        Dim lastname As String = txtEmpLastname.Text
        Dim phone As String = txtEmpPhone.Text
        Dim email As String = txtEmpEmail.Text
        Dim job As String = txtEmpJobTitle.Text
        Dim username As String = txtEmpUsername.Text
        Dim password As String = txtEmpPassword.Text

        emp = New Employee(firstname, lastname, phone, email, job, username, password)
        emp.createEmployee()
    End Sub

    Private Sub btnSearchForEmpById_Click(sender As Object, e As EventArgs) Handles btnSearchForEmpById.Click
        Dim id As String = txtEmpId.Text
        emp = New Employee(id)
        dgvEmployeeTest.DataSource = emp.selectEmployeeById(id)
        addInfoToTextFields()
        activeCheck()
    End Sub

    Private Sub btnUpdateEmp_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp.Click
        emp.editEmployee(txtEmpId.Text)
    End Sub

    Private Sub btnDeleteEmp_Click(sender As Object, e As EventArgs) Handles btnDeleteEmp.Click
        emp = New Employee(txtEmpId.Text)
        emp.deleteEmployee()
        getAllEmployees()
        activeCheck()
    End Sub

    Private Sub dgvEmployeeTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeTest.CellContentClick
        addInfoToTextFields()
    End Sub

    Private Sub btnSelectAllEmployees_Click(sender As Object, e As EventArgs) Handles btnSelectAllEmployees.Click
        getAllEmployees()
    End Sub

    Private Sub getAllEmployees()
        dbutil = New DBUtility
        table = New DataTable
        table = dbutil.selectQuery("SELECT * FROM ansatt")
        dgvEmployeeTest.DataSource = table
    End Sub

    'Hjelpemetode: Legger informasjon fra databasen over i tekstfelt.
    Private Sub addInfoToTextFields()
        Dim rowIndex As Integer = dgvEmployeeTest.CurrentCellAddress.Y
        Dim empId As String = dgvEmployeeTest.Rows(rowIndex).Cells(0).Value.ToString()
        dbutil = New DBUtility
        table = New DataTable

        table = dbutil.selectQuery("SELECT * FROM ansatt WHERE ansattid = " & empId)

        txtEmpId.Enabled = False
        txtEmpId.Text = empId
        txtEmpUsername.Text = table.Rows(0)(1).ToString()
        txtEmpPassword.Text = table.Rows(0)(2).ToString()
        txtEmpFirstname.Text = table.Rows(0)(3).ToString()
        txtEmpLastname.Text = table.Rows(0)(4).ToString()
        txtEmpPhone.Text = table.Rows(0)(5).ToString()
        txtEmpEmail.Text = table.Rows(0)(6).ToString()
        txtEmpJobTitle.Text = table.Rows(0)(8).ToString()
    End Sub

    'Hjelpemetode: Sjekker aktivert-verdien til en ansatt. IKKE FUNGERENDE.
    Private Sub activeCheck()
        Dim textBoxArr() As TextBox = {txtEmpEmail, txtEmpFirstname, txtEmpId, txtEmpJobTitle, txtEmpLastname, txtEmpPassword, txtEmpPhone, txtEmpUsername}
        If Not emp.isActive() Then
            For Each txtBox In textBoxArr
                txtBox.Enabled = False
            Next
        End If
    End Sub
End Class