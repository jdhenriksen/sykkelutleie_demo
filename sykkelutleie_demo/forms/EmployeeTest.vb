''' <summary>
''' Testklasse for Employee-klassen.
''' </summary>
''' <remarks></remarks>
Public Class EmployeeTest
    Private emp As Employee
    Private table As New DataTable

    'BUTTON: Oppretter en ansatt og skriver informasjonen til databasen.
    Private Sub btnInsertEmployee_Click(sender As Object, e As EventArgs) Handles btnInsertEmployee.Click
        'Sjekker om brukernavn eksisterer fra før.
        If usernameCheck() > 0 Then
            MsgBox("Brukernavn opptatt. Velg et annet.")
            Exit Sub
        End If

        'Sjekker om alle tekstfeltene inneholder informasjon.
        If Not checkTextBoxes() Then
            MsgBox("Alle tekstfelt må fylles ut.")
            Exit Sub
        End If

        'Oppretter ansattobjekt basert på tekstfelt.
        createEmployeeFromTextFields()

        'Sjekker om passordet er gyldig.
        If Not emp.account.setPassword(emp.account.getPassword()) Then
            MsgBox("Ikke gyldig passord.")
            Exit Sub
        End If

        'Sjekker om postnummer finnes i databasen. Se egen metode for detaljer.
        If Not emp.zipCodeExists(emp.getZip()) Then
            emp.createZipCode(emp.getZip(), txtEmpZipArea.Text)
        End If

        'Skriver objekt til databasen og oppdaterer GridView.
        emp.createEmployee()
        getAllEmployees()
    End Sub


    'BUTTON: Oppdaterer informasjon om en ansatt og skriver ny informasjon til databasen.
    Private Sub btnUpdateEmp_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp.Click
        'Sjekker om brukernavn eksisterer fra før. Må her også ta hensyn til eget brukernavn.
        If usernameCheck() > 1 Then
            MsgBox("Brukernavn opptatt. Velg et annet.")
            Exit Sub
        End If

        'Sjekker om alle tekstfeltene inneholder informasjon.
        If Not checkTextBoxes() Then
            MsgBox("Alle tekstfelt må fylles ut.")
            Exit Sub
        End If

        'Lager ansattobjekt.
        createEmployeeFromTextFields()

        'Hent passord fra database og sammenlign med passord i objekt.
        Dim pwd As String = emp.getPasswordHashByUsername(emp.account.getUsername())
        If Not pwd.Equals(emp.account.getPassword()) Then
            If Not emp.account.setPassword(emp.account.getPassword()) Then
                MsgBox("Ugyldig passord.")
                Exit Sub
            End If
        End If

        'Sjekker om postnummer eksisterer i databasen. Se egen metode for detaljer.
        If Not emp.zipCodeExists(emp.getZip()) Then
            emp.createZipCode(emp.getZip(), txtEmpZipArea.Text)
        End If

        'Skriver objekt til databasen og oppdaterer GridView.
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

    ''' <summary>
    ''' Hjelpemetode: Lister ut alle ansatte og presenterer dem i datagridviewet.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub getAllEmployees()
        emp = New Employee()
        table = emp.getAllEmployees()
        dgvEmployeeTest.DataSource = table
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Legger informasjon fra databasen over i tekstfelt.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub addInfoToTextFields()
        'Finner AnsattID.
        Dim rowIndex As Integer = dgvEmployeeTest.CurrentCellAddress.Y
        Dim empId As String = dgvEmployeeTest.Rows(rowIndex).Cells(0).Value.ToString()
        txtEmpId.Text = empId

        table = emp.selectEmployeeById(empId)

        'Sørger for at riktig informasjon havner i riktig tekstfelt ved å referere til kolonnenavn i databasen.
        txtEmpUsername.Text = table.Rows(0).Item("brukernavn")
        txtEmpPassword.Text = table.Rows(0).Item("passord")
        txtEmpFirstname.Text = table.Rows(0).Item("fornavn")
        txtEmpLastname.Text = table.Rows(0).Item("etternavn")
        txtEmpPhone.Text = table.Rows(0).Item("telefon")
        txtEmpEmail.Text = table.Rows(0).Item("epost")
        txtEmpAddress.Text = table.Rows(0).Item("adresse")
        txtEmpJobTitle.Text = table.Rows(0).Item("stilling")
        txtEmpZipCode.Text = table.Rows(0).Item("postnr")
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Sjekker aktivert-verdien til et Employee-objekt.
    ''' </summary>
    ''' <remarks>Hvis aktivert = 1 enables alle aktuelle tekstfelt, hvis aktivert = 0 disables de.</remarks>
    Private Sub activeCheck()
        Dim textBoxes() As TextBox = {txtEmpEmail, txtEmpFirstname, txtEmpId, txtEmpJobTitle, txtEmpLastname, txtEmpPassword, txtEmpPhone, txtEmpUsername, txtEmpAddress, txtEmpZipCode, txtEmpZipArea}
        If Not emp.isActive(txtEmpId.Text) Then
            For Each txtBox In textBoxes
                txtBox.Enabled = False
            Next
        Else
            For Each txtBox In textBoxes
                txtBox.Enabled = True
            Next
        End If
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Lager ansatt-objekt basert på verdier i tekstfelt.
    ''' </summary>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Hjelpemetode: Sjekker om brukernavn allerede eksisterer i databasen.
    ''' </summary>
    ''' <returns>Antall rader i databasen som stemmer overens med brukernavnet i tekstfeltet.</returns>
    ''' <remarks></remarks>
    Private Function usernameCheck() As Integer
        Dim username = txtEmpUsername.Text
        Return emp.usernameCheck(username)
    End Function

    'ONLOAD: Tekstfelt for passord vil alltid vise passordtegn.
    'Det skal ikke være mulig å endre cellene i GridView eller i tekstfeltet for id.
    Private Sub EmployeeTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmpPassword.PasswordChar = "*"
        dgvEmployeeTest.ReadOnly = True
        txtEmpId.Enabled = False
        emp = New Employee()
    End Sub

    'EVENT: Hver gang en celle i dataGridViewet markeres sendes informasjonen om markert ansatt til tekstfelt.
    Private Sub dgvEmployeeTest_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeTest.CellEnter
        addInfoToTextFields()
        activeCheck()
    End Sub

    'EVENT: Henter ut poststed basert på informasjon postnummer-feltet.
    Private Sub txtEmpZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmpZipCode.TextChanged
        txtEmpZipArea.Text = emp.getAreaByZipCode(txtEmpZipCode.Text)
    End Sub

    'BUTTON: Søker etter ansatte i databasen.
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        createEmployeeFromTextFields()
        dgvEmployeeTest.DataSource = emp.searchEmployee()
    End Sub

    'BUTTON: Nullstiller alle tekstfelt.
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If ctrl.GetType() = GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    ''' <summary>
    ''' Hjelpemetode: Går gjennom alle tekstfelt og sjekker om de er fylt ut.
    ''' </summary>
    ''' <returns>True hvis alle tekstfelt har godkjente verdier, False hvis ikke.</returns>
    ''' <remarks></remarks>
    Private Function checkTextBoxes() As Boolean
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If ctrl.GetType() = GetType(TextBox) Then
                If ctrl.Text = "" Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function
End Class