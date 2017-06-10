Public Class frmCompanies

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
                    Handles MyBase.MouseMove, lblMessage.MouseMove, lblUser.MouseMove
        Try
            If e.Button = MouseButtons.Left Then
                MoveForm()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal user As Domain.User, ByVal Companies As List(Of Domain.Company))
        InitializeComponent()

        Try
            Me.Text = System.Windows.Forms.Application.ProductName & " - Bienvenido " & user.NickName
            Me.lblUser.Text = "USUARIO: " & user.NickName

            ListCompanies.DataSource = Companies
            ListCompanies.DisplayMember = "Name"

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub


    Public ReadOnly Property SelectedCompany() As Domain.Company
        Get
            Return ListCompanies.SelectedItem
        End Get
    End Property

    Private Sub SelectedCompany_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListCompanies.SelectedIndexChanged
        Try

            If ListCompanies.SelectedItem IsNot Nothing Then cmdAccept.Enabled = True

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub


    Private Sub ListCompanies_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListCompanies.MouseDoubleClick
        Try

            SelectCompany()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        Try

            SelectCompany()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub SelectCompany()

        Try
            If ListCompanies.SelectedItem Is Nothing Then Exit Try

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            ListCompanies.SelectedItem = Nothing

            Me.DialogResult = Windows.Forms.DialogResult.Cancel

            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)

        End Try

    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If ListCompanies.Items.Count = 1 Then
                ListCompanies.SelectedItem = ListCompanies.Items(0)
                SelectCompany()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub cmdAccept_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAccept.EnabledChanged
        Try
            If cmdAccept.Enabled Then Me.AcceptButton = cmdAccept
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub
End Class