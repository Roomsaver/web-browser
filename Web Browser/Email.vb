Imports System.Net.Mail
Public Class Email
    Private Sub Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.EmailOpen = True
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim email As String
        Dim password As String = txtPassword.Text

        If InStr(txtEmail.Text, "@gmail.com") > 0 Then
            email = txtEmail.Text
        Else
            email = txtEmail.Text & "@gmail.com"
        End If

        'Start email
        Dim smtpServer As New SmtpClient()
        progressBar.Value = 10
        Application.DoEvents()
        Dim mail As New MailMessage()
        progressBar.Value = 20
        Application.DoEvents()
        smtpServer.Credentials = New Net.NetworkCredential(email, password)
        progressBar.Value = 30
        Application.DoEvents()
        'using Gmail
        smtpServer.Port = 465
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = True
        progressBar.Value = 40
        Application.DoEvents()
        mail = New MailMessage()
        progressBar.Value = 50
        Application.DoEvents()
        mail.From = New MailAddress(email, txtTo.Text)
        progressBar.Value = 60
        Application.DoEvents()
        mail.To.Add(txtTo.Text)
        progressBar.Value = 70
        Application.DoEvents()
        mail.Subject = txtSubject.Text
        progressBar.Value = 80
        Application.DoEvents()
        mail.Body = txtEmail.Text
        progressBar.Value = 90
        Application.DoEvents()
        smtpServer.Send(mail)
        progressBar.Value = 100
        Application.DoEvents()
    End Sub
End Class