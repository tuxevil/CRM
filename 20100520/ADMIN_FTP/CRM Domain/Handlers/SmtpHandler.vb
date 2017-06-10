Public Class SmtpHandler

    Private SmtpClient As System.Net.Mail.SmtpClient
    Private SmtpUser As String

    Public Sub New(ByVal host As String, ByVal port As Integer, ByVal user As String, ByVal password As String, ByVal SSL As Boolean, ByVal SPA As Boolean)
        Dim nc As System.Net.NetworkCredential
        Try

            SmtpUser = user

            SmtpClient = New System.Net.Mail.SmtpClient(host, port)
            SmtpClient.Credentials = New System.Net.NetworkCredential(user, password)
            SmtpClient.EnableSsl = SSL



            nc = New Net.NetworkCredential(user, password)

            SmtpClient.Credentials = nc.GetCredential(host, port, "NTLM")

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub



    Public Sub SendMail(ByVal Receipt As String, ByVal Subject As String, ByVal Body As String)

        Dim Mail As System.Net.Mail.MailMessage

        Try

            Mail = New System.Net.Mail.MailMessage(SmtpUser, Receipt, Subject, Body)
            If Receipt <> SystemLicence.ContactMail Then Mail.Bcc.Add(SystemLicence.ContactMail)

            SmtpClient.SendAsync(Mail, Nothing)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub SendReport(ByVal Body As String)

        Dim Mail As System.Net.Mail.MailMessage
        Dim Report As String

        Try
            Report = ""
            Report = Report & "Mensaje enviado por " & SystemUser.FullName & " (" & SystemUser.NickName & ") " & vbCrLf
            Report = Report & vbCrLf
            Report = Report & "Responder a " & SystemUser.Mail & vbCrLf
            Report = Report & Body & vbCrLf
            Report = Report & Format(Now(), "dd/MM/dddd") & Format(Now(), "hh:mm:ss") & vbCrLf

            Mail = New System.Net.Mail.MailMessage(SmtpUser, SystemLicence.ContactMail, "INFORME DE ERRORES", Report)

            SmtpClient.SendAsync(Mail, Nothing)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
