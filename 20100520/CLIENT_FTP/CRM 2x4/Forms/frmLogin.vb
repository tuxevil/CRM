Public Class frmLogin


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
                    Handles MyBase.MouseMove, lblMessage.MouseMove, lblUser.MouseMove, lblPassword.MouseMove
        Try
            If e.Button = MouseButtons.Left Then
                MoveForm()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub


    Private Sub Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            DrawMe()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub DrawMe()
        Try
            Me.Text = System.Windows.Forms.Application.ProductName & " - Bienvenido"
            txtUser.Text = My.Settings.LastUser

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged
        Try
            cmdAccept.Enabled = txtUser.Text <> ""

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub LogIn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click, cmdAccept.Click

        Try
            cmdCancel.Enabled = False
            cmdAccept.Enabled = False

            If Crm.Domain.Tango.Login(txtUser.Text, txtPassword.Text) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            Me.DialogResult = Windows.Forms.DialogResult.None
            cmdCancel.Enabled = True
            cmdAccept.Enabled = True
        End Try

    End Sub

    Private Sub cmdAccept_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAccept.EnabledChanged
        Try
            If cmdAccept.Enabled Then Me.AcceptButton = cmdAccept
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

  
    Private Sub lblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessage.Click

    End Sub
End Class