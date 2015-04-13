''' <summary>
''' Testklasse for Employee-klassen.
''' </summary>
''' <remarks></remarks>
Public Class EmployeeTest
    Private emp As Employee
    Private table As New DataTable

    'BUTTON: Oppretter en ansatt og skriver informasjonen til databasen.
    Private Sub btnInsertEmployee_Click(sender As Object, e As EventArgs) Handles btnInsertEmployee.Click
        If usernameCheck() > 0 Then
            MsgBox("Brukernavn opptatt. Velg et annet.")
            Exit Sub
        End If
        createEmployeeFromTextFields()
        If Not emp.zipCodeExists(emp.getZip()) Then
            emp.createZipCode(emp.getZip(), txtEmpZipArea.Text)
        End If
        emp.createEmployee()
        getAllEmployees()
    End Sub

    'BUTTON: Søker etter en ansatt basert på verdi i id-feltet.
    Private Sub btnSearchForEmpById_Click(sender As Object, e As EventArgs) Handles btnSearchForEmpById.Click
        Dim id As String = txtEmpId.Text
        emp = New Employee(id)
        dgvEmployeeTest.DataSource = emp.selectEmployeeById(id)
        addInfoToTextFields()
        activeCheck()
    End Sub

    'BUTTON: Oppdaterer informasjon om en ansatt og skriver ny informasjon til databasen.
    Private Sub btnUpdateEmp_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp.Click
        If usernameCheck() > 1 Then
            MsgBox("Brukernavn opptatt. Velg et annet.")
            Exit Sub
        End If
        createEmployeeFromTextFields()
        If Not emp.zipCodeExists(emp.getZip()) Then
            emp.createZipCode(emp.getZip(), txtEmpZipArea.Text)
        End If
        emp.editEmployee(txtEmpId.Text)
        getAllEmployees()
    End Sub

    'BUTTON: Sletter en ansatt fra databasen (i praksis settes aktivert-attributtet i databasen til 0).
    Private Sub btnDeleteEmp_Click(sender As Object, e As EventArgs) Handles btnDeleteEmp.Click
        emp = New Employee(txtEmpId.Text)
        emp.deleteEmployee()
        getAllEmployees()
        activeCheck()
    End Sub

    'BUTTON: Viser alle ansatte i databasen i dataGridViewet.
    Private Sub btnSelectAllEmployees_Click(sender As Object, e As EventArgs) Handles btnSelectAllEmployees.Click
        getAllEmployees()
    End Sub

    'Hjelpemetode: Lister ut alle ansatte og presenterer dem i datagridviewet.
    Private Sub getAllEmployees()
        emp = New Employee()
        table = emp.getAllEmployees()
        dgvEmployeeTest.DataSource = table
    End Sub

    'Hjelpemetode: Legger informasjon fra databasen over i tekstfelt.
    Private Sub addInfoToTextFields()
        Dim rowIndex As Integer = dgvEmployeeTest.CurrentCellAddress.Y
        Dim empId As String = dgvEmployeeTest.Rows(rowIndex).Cells(0).Value.ToString()

        table = emp.selectEmployeeById(empId)

        txtEmpId.Enabled = False
        txtEmpId.Text = empId
        txtEmpUsername.Text = table.Rows(0)(1).ToString()
        txtEmpPassword.Text = table.Rows(0)(2).ToString()
        txtEmpFirstname.Text = table.Rows(0)(3).ToString()
        txtEmpLastname.Text = table.Rows(0)(4).ToString()
        txtEmpPhone.Text = table.Rows(0)(5).ToString()
        txtEmpEmail.Text = table.Rows(0)(6).ToString()
        txtEmpAddress.Text = table.Rows(0)(7).ToString()
        txtEmpJobTitle.Text = table.Rows(0)(8).ToString()
        txtEmpZipCode.Text = table.Rows(0)(9).ToString()
    End Sub

    'Hjelpemetode: Sjekker aktivert-verdien til et Employee-objekt.
    Private Sub activeCheck()
        Dim textBoxArr() As TextBox = {txtEmpEmail, txtEmpFirstname, txtEmpId, txtEmpJobTitle, txtEmpLastname, txtEmpPassword, txtEmpPhone, txtEmpUsername, txtEmpAddress, txtEmpZipCode}
        If Not emp.isActive(txtEmpId.Text) Then
            For Each txtBox In textBoxArr
                txtBox.Enabled = False
            Next
        Else
            For Each txtBox In textBoxArr
                txtBox.Enabled = True
            Next
        End If
    End Sub

    'Hjelpemetode: Lager Employee-objekt basert på verdier i tekstfelt.
    Private Sub createEmployeeFromTextFields()
        Dim firstname As String = txtEmpFirstname.Text
        Dim lastname As String = txtEmpLastname.Text
        Dim phone As String = txtEmpPhone.Text
        Dim email As String = txtEmpEmail.Text
        Dim job As String = txtEmpJobTitle.Text
        Dim address As String = txtEmpAddress.Text
        Dim zip As String = txtEmpZipCode.Text
        Dim username As String = txtEmpUsername.Text
        Dim password As String = txtEmpPassword.Text

        emp = New Employee(firstname, lastname, phone, email, job, address, zip, username, password)
    End Sub

    'Hjelpemetode: Sjekker om brukernavn allerede eksisterer i databasen.
    Private Function usernameCheck() As Integer
        Dim username = txtEmpUsername.Text
        Return emp.usernameCheck(username)
    End Function

    'ONLOAD: Tekstfelt for passord vil alltid vise passordtegn.
    Private Sub EmployeeTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmpPassword.PasswordChar = "*"
        dgvEmployeeTest.ReadOnly = True
        emp = New Employee()
    End Sub

    'EVENT: Hver gang en celle i dataGridViewet markeres sendes informasjonen om markert ansatt til tekstfelt.
    Private Sub dgvEmployeeTest_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeTest.CellEnter
        addInfoToTextFields()
        activeCheck()
    End Sub

    Private Sub txtEmpZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmpZipCode.TextChanged
        txtEmpZipArea.Text = emp.getAreaByZipCode(txtEmpZipCode.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        createEmployeeFromTextFields()
        dgvEmployeeTest.DataSource = emp.searchEmployee()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If ctrl.GetType() = GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
    End Sub
End Class