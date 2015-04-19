Public Class MailTest
    Dim password As String
    Dim address As String

    'EVENT: Setter passord og adresse som harkodede tekststrenger.
    Private Sub MailTest_Shown1(sender As Object, e As EventArgs) Handles Me.Shown
        mailLogin.Show()
        password = "mitthemmeligepassord"
        address = "vbtestsomo@gmail.com"
    End Sub

    'BUTTON: Lager et MailUtility-objekt og sender eposten.
    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Dim from As String = txtFrom.Text
        Dim mailTo As String = txtTo.Text
        Dim subject As String = txtSubject.Text
        Dim body As String = rtbContent.Text
        Dim message As New MailUtility(from, mailTo, subject, body, password)
        message.send()
    End Sub
End Class