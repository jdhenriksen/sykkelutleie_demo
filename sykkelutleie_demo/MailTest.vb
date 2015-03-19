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

    Private Sub txtSendEpost_Click(sender As Object, e As EventArgs) Handles txtSendEpost.Click
        Dim mailMessage As New MailUtility
        Dim mailFrom As String = TextBox2.Text
        Dim mailTo As String = TextBox1.Text
        Dim mailSubject As String = TextBox3.Text
        Dim mailBody As String = RichTextBox1.Text


        mailMessage.sendMail(mailAdress, mailTo, mailSubject, mailBody, password)

        MsgBox("E-postmelding er sendt!")

    End Sub



End Class