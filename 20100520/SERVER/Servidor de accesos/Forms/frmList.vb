Public Class frmList

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal UserList As List(Of String), Optional ByVal AllowUserSelection As Boolean = False)

        InitializeComponent()

        Try
            List.DataSource = UserList

            chkOther.Visible = AllowUserSelection

            Me.ShowDialog()

        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Private Sub List_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List.DoubleClick
        Try

            ItemSelected()

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing

        End Try
    End Sub

    Private Sub List_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            ItemSelected()

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing

        End Try
    End Sub

    Public ReadOnly Property SelectedItem() As String
        Get
            Return List.SelectedItem
        End Get
    End Property

    Public ReadOnly Property UserSelection() As Boolean
        Get
            Return chkOther.Checked
        End Get
    End Property

    Private Sub ItemSelected()
        Try
            If List.SelectedItem IsNot Nothing Then Me.Close()
        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub OtherSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOther.CheckedChanged
        Try
            If chkOther.Checked Then Me.Close()
        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing

        End Try
    End Sub
End Class