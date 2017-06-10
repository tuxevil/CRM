Public Class Form1

    Private Sub cmdEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEncrypt.Click

        TextToDecrypt.Text = Replace(Encrypter.EncryptString(TextToEncrypt.Text), Chr(10), " ")

    End Sub

    Private Sub cmdDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecrypt.Click
        TextToEncrypt.Text = Encrypter.DecryptString(TextToDecrypt.Text)
    End Sub
End Class
