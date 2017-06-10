Public Class frmAlert

    Private Entity As Domain.Alert

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Alert As Domain.Alert)
        InitializeComponent()

        Entity = Alert
    End Sub


    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DrawMe()

            ShowTimer.Interval = 30000
            ShowTimer.Start()

            My.Computer.Audio.Play(My.Resources.REMINDER, AudioPlayMode.Background)

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub DrawMe()
        Try
            Me.cmbMinutes.DataSource = Domain.AlertRepository.TimeTypes
            Me.cmbMinutes.DisplayMember = "Name"
            Me.cmbMinutes.ValueMember = "Id"

            Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, Screen.PrimaryScreen.Bounds.Height - Me.Height)

            Me.ShowInTaskbar = False

            Me.TopMost = True

            Me.Text = Entity.Subject

            Me.GroupMsg.Text = Me.Text

            Me.lblDetail.Text = Entity.Detail

            Me.lblInitDate.Text = "Inicio: " & Format(Entity.Initdate, "dd/MM/yyyy hh:mm tt")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ShowTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowTimer.Tick
        Try
            Me.Close()
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&


    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage( _
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
            ByVal wParam As Integer, ByVal lParam As Integer _
            )
    End Sub

    Private Sub MoveForm()
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                    Handles MyBase.MouseMove, lblMessage.MouseMove, GroupMsg.MouseMove, lblDetail.MouseMove
        Try
            If e.Button = MouseButtons.Left Then
                MoveForm()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        Try
            Domain.AlertRepository.DiscardAlert(Entity.Id)
            Me.Close()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub cmdSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuspend.Click
        Try
            Domain.AlertRepository.SuspendAlert(Entity.Id, cmbMinutes.SelectedItem.Minutes, cmbMinutes.SelectedItem.id)
            Me.Close()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

End Class