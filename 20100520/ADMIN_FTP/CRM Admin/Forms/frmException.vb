Public Class frmException

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Text = Domain.SystemLicence.Name & " - Informe de errores"
            Me.Controls.Remove(txtDetail)

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Me.Close()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub cmdDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetail.Click
        Try

            If Me.Controls.Contains(txtDetail) Then
                Me.Controls.Remove(txtDetail)
                cmdDetail.Text = "Detalle >>>"
                txtDetail.Visible = False
            Else
                txtDetail.Location = New System.Drawing.Point(12, 137)
                Me.Controls.Add(txtDetail)
                cmdDetail.Text = "Detalle <<<"
                txtDetail.Visible = True
            End If

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Public Sub ShowException(ByVal ex As Exception)
        Try
            txtMessage.Text = ex.Message
            txtDetail.Text = ex.ToString

            Me.Show()

        Catch exc As Exception
            exc = Nothing
        End Try

    End Sub

    Private Sub cmdSendError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendError.Click

        Try

            Domain.SmtpServer.SendReport(txtDetail.Text)

            MsgBox("Mensaje enviado", MsgBoxStyle.Information, "Informe de errores")

        Catch ex As Exception
            MsgBox("Ocurrio un error durante el envío" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub
End Class