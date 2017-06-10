Public Class frmEvent

    Public Event SourceChanged(ByVal EventType As Integer, ByVal Detail As String)


    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()

                Case Keys.F10
                    RaiseEvent SourceChanged(cmbEventType.SelectedValue, txtDetails.Text)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DrawMe()
        Try

            cmbEventType.DataSource = Domain.TaskEventRepository.GetTypes()
            cmbEventType.DisplayMember = "Name"
            cmbEventType.ValueMember = "Id"

            If cmbEventType.Items.Count <= 0 Then
                MsgBox("No existen tipos de eventos", MsgBoxStyle.Information, "Atención")
                Me.Close()
                Exit Sub
            End If

            cmbEventType.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub MenuEditSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditSave.Click, BrowserAccept.Click
        Try
            RaiseEvent SourceChanged(cmbEventType.SelectedValue, txtDetails.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserCancel.Click, MenuFileExit.Click, MenuEditCancel.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub
End Class