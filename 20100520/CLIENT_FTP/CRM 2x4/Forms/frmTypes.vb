Public Class frmTypes

    Private Source As DataTable
    Private Row As DataRow
    Private RowIndex As Integer

    Private mCodeValid As Integer

    Public Event SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String)
    Public Event CodeChanged(ByVal Code As Integer)

    Public Sub New()
        InitializeComponent()
    End Sub


    Public Sub New(ByVal Title As String, ByVal Table As DataTable)
        InitializeComponent()

        Me.Text = Title
        Source = Table

    End Sub


    Public WriteOnly Property CodeValid() As Integer
        Set(ByVal value As Integer)
            mCodeValid = value
        End Set
    End Property

    Public Property DataSource() As DataTable
        Get
            Return Source
        End Get
        Set(ByVal value As DataTable)
            Source = value
            DrawMe()
        End Set
    End Property

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If txtName.ReadOnly Then
                        Me.Close()
                    Else
                        DrawMe()
                    End If

                Case Keys.F10 : SaveRow()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DrawMe(Optional ByVal EditionMode As Boolean = False, Optional ByVal NewRow As Boolean = False)
        Try

            If Source Is Nothing Then Throw New Exception("ERROR DE DATOS")

            If RowIndex >= Source.Rows.Count Then
                txtCode.Text = ""
                txtName.Text = ""
                txtDetails.Text = ""
                txtOtherDetails.Text = ""

                If Not Source.Columns.Count > 3 Then
                    txtOtherDetails.Visible = False
                    Label4.Visible = False
                End If

                If Not NewRow Then
                    BrowserAccept.Visible = False

                    txtCode.ReadOnly = True
                    txtName.ReadOnly = True
                    txtDetails.ReadOnly = True
                    txtOtherDetails.ReadOnly = True
                Else
                    BrowserAccept.Visible = True

                    txtCode.ReadOnly = False
                    txtName.ReadOnly = False
                    txtDetails.ReadOnly = False
                    txtOtherDetails.ReadOnly = False
                End If


                Exit Try

            End If

            Row = Source.Rows(RowIndex)

            If Row Is Nothing Then Exit Try

            If Not NewRow Then
                If Source.Columns.Count > 0 Then txtCode.Text = Row.Item(0).ToString
                If Source.Columns.Count > 1 Then txtName.Text = Row.Item(1).ToString
                If Source.Columns.Count > 2 Then txtDetails.Text = Row.Item(2).ToString
                If Source.Columns.Count > 3 Then
                    txtOtherDetails.Text = Row.Item(3).ToString
                Else
                    txtOtherDetails.Visible = False
                    Label4.Visible = False
                End If
            Else
                txtCode.Text = ""
                txtName.Text = ""
                txtDetails.Text = ""
                txtOtherDetails.Text = ""
            End If

            If EditionMode Then

                If txtCode.Text = "" Then
                    txtCode.Focus()
                Else
                    txtName.Focus()
                End If

                BrowserAccept.Visible = True

                If txtCode.Text = "" Then txtCode.ReadOnly = False
                txtName.ReadOnly = False
                txtDetails.ReadOnly = False
                txtOtherDetails.ReadOnly = False

            Else
                BrowserAccept.Visible = False

                txtCode.ReadOnly = True
                txtName.ReadOnly = True
                txtDetails.ReadOnly = True
                txtOtherDetails.ReadOnly = True

            End If



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BrowserFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserFirst.Click
        Try
            RowIndex = 0
            DrawMe()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserPrevious.Click

        If RowIndex > 0 Then
            RowIndex = RowIndex - 1
            DrawMe()
        End If

    End Sub

    Private Sub BrowserNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserNext.Click
        If RowIndex < Source.Rows.Count - 1 Then
            RowIndex = RowIndex + 1
            DrawMe()
        End If
    End Sub


    Private Sub BrowserLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserLast.Click
        RowIndex = Source.Rows.Count - 1
        DrawMe()
    End Sub


    Private Sub BrowserAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAdd.Click, MenuAdd.Click
        Try
            DrawMe(True, True)
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserCancel.Click
        Try
            DrawMe()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub BrowserAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAccept.Click
        Try
            SAVEROW()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserEdit.Click, MenuEdit.Click
        Try
            DrawMe(True)
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DrawButtons(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAccept.VisibleChanged
        Try
            If sender.VISIBLE Then
                MenuAdd.Enabled = Not sender.visible
                MenuEdit.Enabled = Not sender.visible
                BrowserAdd.Visible = Not sender.visible
                BrowserAdd.Visible = Not sender.visible
                BrowserEdit.Visible = Not sender.visible
                BrowserFirst.Visible = Not sender.visible
                BrowserLast.Visible = Not sender.visible
                BrowserPrevious.Visible = Not sender.visible
                BrowserNext.Visible = Not sender.visible
                BrowserSearch.Visible = False
                BrowserCancel.Visible = sender.visible
            Else
                MenuAdd.Enabled = Domain.SystemUser.Profile.CustomerParameters
                MenuEdit.Enabled = Domain.SystemUser.Profile.CustomerParameters
                BrowserAdd.Visible = Domain.SystemUser.Profile.CustomerParameters
                BrowserAdd.Visible = Domain.SystemUser.Profile.CustomerParameters
                BrowserEdit.Visible = Domain.SystemUser.Profile.CustomerParameters
                BrowserFirst.Visible = Not sender.visible
                BrowserLast.Visible = Not sender.visible
                BrowserPrevious.Visible = Not sender.visible
                BrowserNext.Visible = Not sender.visible
                BrowserSearch.Visible = False
                BrowserCancel.Visible = sender.visible
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub



    Private Sub Code_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CodeValidated Then txtName.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If NameValidated() Then txtDetails.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Description_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetails.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If txtOtherDetails.Visible Then
                txtOtherDetails.Focus()
            Else
                SaveRow()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub OtherDetails_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOtherDetails.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            SaveRow()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Function CodeValidated() As Boolean
        Dim Counter As Integer
        Try

            If txtCode.ReadOnly Then Return True

            If txtCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Information, "ATENCIÓN")
                Return False
            End If

            If Not IsNumeric(txtCode.Text) Then
                MsgBox("EL CODIGO DEBE SER NUMERICO", MsgBoxStyle.Information, "ATENCIÓN")
                Return False
            End If

            mCodeValid = 0

            RaiseEvent CodeChanged(CInt(txtCode.Text))

            Do Until mCodeValid <> 0 Or Counter = 1000
                Application.DoEvents()
            Loop

            If mCodeValid = -1 Then
                MsgBox("CODIGO EXISTENTE", MsgBoxStyle.Information, "ATENCIÓN")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function NameValidated() As Boolean
        Try

            If txtName.ReadOnly Then Return True

            If txtName.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Information, "ATENCIÓN")
                Return False
            End If


            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Sub Code_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCode.Validating
        Try

            If txtCode.ReadOnly = False Then e.Cancel = Not CodeValidated()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Name_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Try

            If txtCode.ReadOnly = False Then e.Cancel = Not NameValidated()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveRow()
        Try
            If Not CodeValidated() Then Exit Try

            If Not NameValidated() Then Exit Try

            RaiseEvent SourceChanged(CInt(txtCode.Text), txtName.Text, txtDetails.Text, txtOtherDetails.Text)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserSearch.Click

    End Sub
End Class