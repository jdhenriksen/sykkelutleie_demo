Imports System.Net.Mail
''' <summary>
''' Klasse som håndterer epost-funksjonalitet.
''' </summary>
''' <remarks></remarks>
Public Class MailUtility
    Private from, recipient, subject, body, password As String

    ''' <summary>
    ''' Konstruktør som setter objektvariabler for epost-funksjonalitet.
    ''' </summary>
    ''' <param name="fromAddress">Fra-adresse.</param>
    ''' <param name="recipient">Til-adresse.</param>
    ''' <param name="subject">Emne.</param>
    ''' <param name="body">Tekst i epost-kropp.</param>
    ''' <param name="password">Passord.</param>
    ''' <remarks></remarks>
    Sub New(fromAddress As String, recipient As String, subject As String, body As String, password As String)
        Me.from = fromAddress
        Me.recipient = recipient
        Me.subject = subject
        Me.body = body
        Me.password = password
    End Sub

    ''' <summary>
    ''' Sender epost basert på innloggingsinformasjon og utfylt epost-skjema
    ''' </summary>
    ''' <remarks>Setter mailUtility først, deretter sendMail()</remarks>
    Public Sub send()
        Dim email As New MailMessage(from, recipient, subject, body)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(from, password)
            smtp.Send(email)
        Catch ex As Exception
            mailError(ex)
        End Try
        MsgBox("Eposten er sendt til " & recipient)
    End Sub

    ''' <summary>
    ''' Gir standardisert feilmelding.
    ''' </summary>
    ''' <param name="ex">Feilmeldingsobjekt fra system.</param>
    ''' <remarks></remarks>
    Private Sub mailError(ex As Exception)
        MsgBox("Noe gikk galt i forbindelse med sending av din e-post. Systemet ga følgende feilmelding:" & vbCr & ex.Message)
    End Sub
End Class
