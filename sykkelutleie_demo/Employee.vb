''' <summary>
''' Håndterer oppgaver i forbindelse med ansatte (brukere) i systemet.
''' </summary>
''' <remarks></remarks>
Public Class Employee
    Inherits Person
    Private employeeID As String 'Hentes fra databasen
    Private jobTitle As String
    Private account As Account


    Sub New(fn As String, ln As String, phone As String, email As String, job As String, username As String, password As String)
        MyBase.New(fn, ln, phone, email)
        jobTitle = job
        account = New Account(username, password)
    End Sub

    'Testkonstruktør
    Sub New()
        MyBase.New()
        jobTitle = "selger"
        account = New Account("testbrukernavn", "testpassord17")
    End Sub

    Public Function getEmployeeID() As String
        Return employeeID
    End Function

    Public Function getJobTitle() As String
        Return jobTitle
    End Function

    Public Sub setJobTitle(title As String)
        jobTitle = title
    End Sub

    Public Function getAccountInfo() As String
        Return account.toString()
    End Function

    Public Overrides Function toString() As String
        Return MyBase.toString() & "Jobbtittel: " & getJobTitle() & vbCrLf & "Brukernavn: " _
            & account.toString()
    End Function
End Class
