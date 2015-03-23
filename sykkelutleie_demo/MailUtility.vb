Imports System.Net.Mail
''' <summary>
''' Klasse som holder epost funksjonalitet
''' </summary>
''' <remarks></remarks>
Public Class MailUtility
    Dim mailFrom As String, _
        recipient As String, _
        subject As String, _
        body As String, _
        password As String

    Public Sub New(mailFrom As String, recipient As String, subject As String, body As String, password As String)
        Me.mailFrom = mailFrom
        Me.recipient = recipient
        Me.subject = subject
        Me.body = body
        Me.password = password
    End Sub

    ''' <summary>
    ''' Sender epost basert på innloggings info og utfylt epost skjema
    ''' </summary>
    ''' <remarks>Konstruer New mailUtility først, deretter sendMail()</remarks>
    Public Sub sendMail()
        Dim eMail As New MailMessage(mailFrom, recipient, subject, body)

        Try

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(mailFrom, password)

            smtp.Send(eMail)

        Catch ex As Exception
            mailError(ex)
        End Try

        MsgBox("Eposten er sendt til " & recipient)

    End Sub

    Private Sub mailError(ex As Exception)
        MsgBox("Noe gikk galt i forbindelse med sending av din e-post. Systemet ga følgende feilmelding:" & vbCr & ex.Message)
    End Sub

End Class
