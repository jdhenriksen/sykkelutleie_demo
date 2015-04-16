Public Class MailTest
    Dim password As String
    Dim mailAdress As String

    Private Sub MailTest_Shown1(sender As Object, e As EventArgs) Handles Me.Shown
        mailLogin.Show()
        '  Dim mailogin As New mailLogin
        ' password = mailogin.passord
        'mailAdress = mailogin.epostAdresse
        'TextBox2.Text = mailAdress
        password = "mitthemmeligepassord"
        mailAdress = "vbtestsomo@gmail.com"


    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click

        Dim mailFrom As String = txtFrom.Text
        Dim mailTo As String = txtTo.Text
        Dim mailSubject As String = txtSubject.Text
        Dim mailBody As String = rtbContent.Text
        Dim mailMessage As New MailUtility(mailFrom, mailTo, mailSubject, mailBody, password)

        mailMessage.sendMail()

    End Sub



End Class