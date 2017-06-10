Public Class frmEditionAlert


    Private Alert As Domain.Alert

    Public Sub New()
        InitializeComponent()
        Me.InitDate.Value = Now()
        Me.InitTime.Value = Now()

        If Domain.SystemUser.ProfileOwner Then chkShared.Enabled = True

    End Sub


    Public Sub New(ByVal InitDate As Date, ByVal InitTime As Date, ByVal Subject As String, ByVal Detail As String)
        InitializeComponent()
        Me.InitDate.Value = InitDate
        Me.InitTime.Value = InitTime
        Me.txtSubject.Text = Subject
        Me.txtDetail.Text = Detail

        If Domain.SystemUser.ProfileOwner Then chkShared.Enabled = True

    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Me.Close()

                Case Keys.F10 : SaveEntity()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    Private Sub Subject_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubject.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            If txtSubject.Text <> "" Then txtDetail.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try


    End Sub

    Private Sub Detail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetail.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            InitDate.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub InitDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InitDate.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            InitTime.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub InitTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InitTime.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            chkShared.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub



    Private Sub SaveEntity()
        Try

            If Not BindEntity() Then Exit Try

            Domain.AlertRepository.SaveAlert(Alert)

            Me.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BindEntity() As Boolean
        Try

            If txtSubject.Text = "" Then
                MsgBox("Debe ingresar el asunto", MsgBoxStyle.Information, "Atención")
                txtSubject.Focus()
                Exit Try
            End If

            Alert = New Domain.Alert

            Alert.Active = True
            Alert.Detail = txtDetail.Text
            Alert.Initdate = InitTime.Value
            Alert.Subject = txtSubject.Text

            If chkShared.Checked And Domain.SystemUser.ProfileOwner Then Alert.Profile = Domain.SystemUser.Profile

            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SaveEntity(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditSave.Click, BrowserAccept.Click
        Try

            SaveEntity()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub ExitForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click, MenuEditCancel.Click, BrowserCancel.Click
        Try

            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Change_Date(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitDate.ValueChanged
        Try
            InitTime.Value = InitDate.Value
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub
End Class