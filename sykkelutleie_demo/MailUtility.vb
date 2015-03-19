Imports System.Net.Mail

Public Class MailUtility

    ''' <summary>
    ''' Classe som holder E-post funksjonalitet
    ''' </summary>
    ''' <param name="mailFrom">E-post adresse fra den som sender.</param>
    ''' <param name="recipient">E-post adresse til mottaker, skilles med komma.</param>
    ''' <param name="subject">Emne på eposten</param>
    ''' <param name="body">Selve innholdet på eposten</param>
    ''' <remarks>Viser feilmelding om det blir problemer med sending.</remarks>
    Public Sub sendMail(mailFrom As String, recipient As String, subject As String, body As String, password As String)

        Dim eMail As New MailMessage()

        Try
            eMail.From = New MailAddress(mailFrom)
            eMail.To.Add(recipient)
            eMail.Subject = subject
            eMail.Body = body

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(mailFrom, password)
            smtp.Send(eMail)


        Catch ex As Exception
            mailError(ex)
        End Try

    End Sub

    Private Sub mailError(ex As Exception)
        MsgBox("Noe gikk galt ifm. sending av e-post. Systemet ga følgende feilmelding:" & vbCr & ex.Message)
    End Sub

End Class
