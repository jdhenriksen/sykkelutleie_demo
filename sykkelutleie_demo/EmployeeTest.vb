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

    Private Sub btnInsertEmployee_Click(sender As Object, e As EventArgs) Handles btnInsertEmployee.Click
        Dim firstname As String = txtEmpFirstname.Text
        Dim lastname As String = txtEmpLastname.Text
        Dim phone As String = txtEmpPhone.Text
        Dim email As String = txtEmpEmail.Text
        Dim job As String = txtEmpJobTitle.Text
        Dim username As String = txtEmpUsername.Text
        Dim password As String = txtEmpPassword.Text

        emp = New Employee(firstname, lastname, phone, email, job, username, password)
        rtbEmployeeTest.Text = emp.toString()
        emp.createEmployee()
    End Sub

    Private Sub btnSelectAllEmployees_Click(sender As Object, e As EventArgs) Handles btnSelectAllEmployees.Click
        Dim dbutil As New DBUtility
        Dim table As New DataTable
        table = dbutil.selectQuery("SELECT * FROM ansatt")
        dgvEmployeeTest.DataSource = table
    End Sub

    Private Sub btnSearchForEmpById_Click(sender As Object, e As EventArgs) Handles btnSearchForEmpById.Click
        Dim id As String = txtEmpId.Text
        emp = New Employee(id)
        dgvEmployeeTest.DataSource = emp.selectEmployeeById(id)
    End Sub

    Private Sub btnActiveTest_Click(sender As Object, e As EventArgs) Handles btnActiveTest.Click
        Dim textBoxArr() As TextBox = {txtEmpEmail, txtEmpFirstname, txtEmpId, txtEmpJobTitle, txtEmpLastname, txtEmpPassword, txtEmpPhone, txtEmpUsername}
        If Not emp.isActive() Then
            For Each txtBox In textBoxArr
                txtBox.Enabled = False
            Next
        End If
    End Sub

    Private Sub btnSetActiveToZero_Click(sender As Object, e As EventArgs) Handles btnSetActiveToZero.Click
        Dim dbutil As New DBUtility
        dbutil.updateQuery("UPDATE ansatt SET aktivert = 0 WHERE ansattid = " & emp.getEmployeeID() & ";")
        emp.setActive(0) 'Må gjøres i programmet og DB i samme steg...
    End Sub

    Private Sub btnSendInfoToTxt_Click(sender As Object, e As EventArgs) Handles btnSendInfoToTxt.Click
        Dim rowIndex As Integer = dgvEmployeeTest.CurrentCellAddress.Y
        Dim empId As String = dgvEmployeeTest.Rows(rowIndex).Cells(0).Value.ToString()
        Dim table As New DataTable
        Dim dbutil As New DBUtility

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

    Private Sub btnUpdateEmp_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp.Click
        emp.editEmployee(txtEmpId.Text)
    End Sub
End Class