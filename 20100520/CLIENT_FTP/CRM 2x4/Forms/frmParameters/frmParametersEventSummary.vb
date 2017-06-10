Public Class frmParametersEventSummary

    Private WithEvents frmViewer As frmReportViewer
    Private WithEvents frmUser As frmSearch
    Private WithEvents frmType As frmSearch
    Private WithEvents frmState As frmSearch
    Private WithEvents frmEvent As frmSearch

    Private GroupField As String
    Private GroupName As String

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DrawMe(False)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DrawMe(ByVal FormEnabled As Boolean)
        Dim GBox As GroupBox
        Dim TBox As TextBox

        Try
            txtUserFrom.Focus()

            For Each Ctrl As Control In Me.Controls

                GBox = TryCast(Ctrl, GroupBox)

                If GBox IsNot Nothing Then

                    GBox.Enabled = FormEnabled

                    For Each ChildCtrl As Control In GBox.Controls

                        TBox = TryCast(ChildCtrl, TextBox)

                        If TBox IsNot Nothing Then TBox.Text = ""

                    Next

                End If

            Next

            MenuReportList.Enabled = Not FormEnabled

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Escape
                    If Not MenuReportList.Enabled Then
                        DrawMe(False)
                    Else
                        Me.Close()
                    End If

                Case Keys.F10
                    ShowReport()

            End Select

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowReport()
        Dim dt As DataTable
        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportClass
        Dim FieldDef As CrystalDecisions.CrystalReports.Engine.FieldDefinition

        Try

            If Not ValidateForm() Then Exit Try

            dt = Domain.ReportRepository.EventList(txtUserFrom.Text, txtUserTo.Text, DateFrom.Value, DateTo.Value, txtTypeFrom.Text, txtTypeTo.Text, txtStateFrom.Text, txtStateTo.Text, txtEventFrom.Text, txtEventTo.Text)

            Rpt = New RptEventList
            Rpt.SetDataSource(dt)

            Rpt.DataDefinition.FormulaFields("COMPANYNAME").Text = "'" & Domain.MainCompany.Name & "'"
            Rpt.DataDefinition.FormulaFields("USEROWNER").Text = "'" & Domain.SystemUser.NickName & "'"
            Rpt.DataDefinition.FormulaFields("REPORTTITLE").Text = "'" & Me.Text & "'"

            FieldDef = Rpt.Database.Tables.Item(0).Fields.Item(GroupField)

            Rpt.DataDefinition.Groups.Item(0).ConditionField = FieldDef

            Rpt.DataDefinition.FormulaFields("GROUPNAME").Text = "'" & GroupName & "'"

            Rpt.Refresh()

            Me.Hide()

            frmViewer = New frmReportViewer(Rpt, dt, Me.Text)
            frmViewer.Show()

        Catch ex As Exception

            DrawMe(False)

            Me.Show()

            Throw ex

        End Try
    End Sub

    Private Function ValidateForm() As Boolean

        Try

            If txtUserFrom.Text = "" Then
                txtUserFrom.Focus()
                Exit Function
            End If

            If txtUserTo.Text = "" Then
                txtUserTo.Focus()
                Exit Function
            End If

            If txtTypeFrom.Text = "" Then
                txtTypeFrom.Focus()
                Exit Function
            End If

            If txtTypeTo.Text = "" Then
                txtTypeTo.Focus()
                Exit Function
            End If

            If txtStateFrom.Text = "" Then
                txtStateFrom.Focus()
                Exit Function
            End If

            If txtStateTo.Text = "" Then
                txtStateTo.Focus()
                Exit Function
            End If

            If txtEventFrom.Text = "" Then
                txtEventFrom.Focus()
                Exit Function
            End If

            If txtEventTo.Text = "" Then
                txtEventTo.Focus()
                Exit Function
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EnableForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportListByUser.Click, MenuReportListByType.Click, MenuReportListByStatus.Click, MenuReportListByDate.Click, MenuReportListByEventType.Click

        Try
            GroupField = sender.tag

            GroupName = UCase(Mid(sender.Text, 5, 100))

            DrawMe(True)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuReportCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportCancel.Click
        Try
            If Not MenuReportList.Enabled Then
                DrawMe(False)
            Else
                Me.Close()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ViewerClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles frmViewer.FormClosed
        Try

            DrawMe(False)

            Me.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub txtUserFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtUserFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtUserTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtUserTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtTypeFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTypeFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtTypeFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtTypeTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTypeTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtTypeTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub DateFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then DateFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub DateTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then DateTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    Private Sub txtStateFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStateFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtStateFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtStateTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStateTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtStateTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub


    Private Sub txtEventFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEventFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtEventFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtEventTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEventTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtEventTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtUserFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserFrom.Validating
        Dim SearchPattern As String
        Dim User As Domain.User
        Dim Users As DataSet

        Try

            If Not txtUserFrom.Enabled Then Exit Try

            SearchPattern = txtUserFrom.Text

            If txtUserFrom.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtUserFrom.Text) Then SearchPattern = 0

            User = Domain.UserRepository.GetByCode(CInt(SearchPattern))

            If User IsNot Nothing Then
                txtUserFrom.Text = User.Id
                txtUserNameFrom.Text = User.NickName
                txtUserTo.Focus()
                Exit Try
            End If

            txtUserFrom.Text = ""
            txtUserNameFrom.Text = ""

            Users = Domain.UserRepository.GetAll(, , True)


            frmUser = New frmSearch("USUARIOS", Users, SearchPattern)
            frmUser.ShowDialog()

            If frmUser.SelectedValue IsNot Nothing Then
                User = Crm.Domain.UserRepository.GetByCode(frmuser.SelectedValue)
                If User IsNot Nothing Then
                    txtUserFrom.Text = User.Id
                    txtUserNameFrom.Text = User.NickName
                    txtUserTo.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            User = Nothing
            Users = Nothing
        End Try
    End Sub


    Private Sub txtUserTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserTo.Validating
        Dim SearchPattern As String
        Dim User As Domain.User
        Dim Users As DataSet

        Try

            If Not txtUserTo.Enabled Then Exit Try

            SearchPattern = txtUserTo.Text

            If txtUserTo.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtUserTo.Text) Then SearchPattern = 0

            User = Domain.UserRepository.GetByCode(CInt(SearchPattern))

            If User IsNot Nothing Then
                txtUserTo.Text = User.Id
                txtUserNameTo.Text = User.NickName
                DateFrom.Focus()
                Exit Try
            End If

            txtUserTo.Text = ""
            txtUserNameTo.Text = ""

            Users = Domain.UserRepository.GetAll(, , True)


            frmUser = New frmSearch("USUARIOS", Users, SearchPattern)
            frmUser.ShowDialog()

            If frmUser.SelectedValue IsNot Nothing Then
                User = Crm.Domain.UserRepository.GetByCode(frmUser.SelectedValue)
                If User IsNot Nothing Then
                    txtUserTo.Text = User.Id
                    txtUserNameTo.Text = User.NickName
                    DateFrom.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            User = Nothing
            Users = Nothing
        End Try
    End Sub

    Private Sub DateFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateFrom.Validating
        Try
            If Not IsDate(DateFrom.Text) Then
                MsgBox("Debe ingresar una fecha válida", MsgBoxStyle.Information, "Atención")
                Exit Try
            End If

            DateTo.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DateTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTo.Validating
        Try
            If Not IsDate(DateTo.Text) Then
                MsgBox("Debe ingresar una fecha válida", MsgBoxStyle.Information, "Atención")
                Exit Try
            End If

            txtTypeFrom.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub



    Private Sub txtTypeFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTypeFrom.Validating
        Dim SearchPattern As String
        Dim Type As Domain.Task.TaskType
        Dim Types As DataSet

        Try

            If Not txtTypeFrom.Enabled Then Exit Try

            SearchPattern = txtTypeFrom.Text

            If txtTypeFrom.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtTypeFrom.Text) Then SearchPattern = 0


            Type = Domain.TaskRepository.GetTypeById(CInt(SearchPattern))

            If Type IsNot Nothing Then
                txtTypeFrom.Text = Type.Id
                txtTypeNameFrom.Text = Type.Name
                txtTypeTo.Focus()
                Exit Try
            End If

            txtTypeFrom.Text = ""
            txtTypeNameFrom.Text = ""

            Types = Domain.TaskRepository.getAllTYpes(, , True)


            frmType = New frmSearch("TIPOS DE TAREA", Types, SearchPattern)
            frmType.ShowDialog()

            If frmType.SelectedValue IsNot Nothing Then
                Type = Domain.TaskRepository.GetTypeById(CInt(frmType.SelectedValue))
                If Type IsNot Nothing Then
                    txtTypeFrom.Text = Type.Id
                    txtTypeNameFrom.Text = Type.Name
                    txtTypeTo.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Type = Nothing
            Types = Nothing
        End Try
    End Sub

    Private Sub txtTypeTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTypeTo.Validating
        Dim SearchPattern As String
        Dim Type As Domain.Task.TaskType
        Dim Types As DataSet

        Try

            If Not txtTypeTo.Enabled Then Exit Try

            SearchPattern = txtTypeTo.Text

            If txtTypeTo.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtTypeTo.Text) Then SearchPattern = 0

            Type = Domain.TaskRepository.GetTypeById(CInt(SearchPattern))

            If Type IsNot Nothing Then
                txtTypeTo.Text = Type.Id
                txtTypeNameTo.Text = Type.Name
                txtStateFrom.Focus()
                Exit Try
            End If

            txtTypeTo.Text = ""
            txtTypeNameTo.Text = ""

            Types = Domain.TaskRepository.GetAllTypes(, , True)


            frmType = New frmSearch("TIPOS DE TAREA", Types, SearchPattern)
            frmType.ShowDialog()

            If frmType.SelectedValue IsNot Nothing Then
                Type = Domain.TaskRepository.GetTypeById(CInt(frmType.SelectedValue))
                If Type IsNot Nothing Then
                    txtTypeTo.Text = Type.Id
                    txtTypeNameTo.Text = Type.Name
                    txtStateFrom.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Type = Nothing
            Types = Nothing
        End Try
    End Sub


    Private Sub txtStateFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStateFrom.Validating
        Dim SearchPattern As String
        Dim State As Domain.Task.TaskState
        Dim States As DataSet

        Try

            If Not txtStateFrom.Enabled Then Exit Try

            SearchPattern = txtStateFrom.Text

            If txtStateFrom.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtStateFrom.Text) Then SearchPattern = 0


            State = Domain.TaskRepository.GetStateById(CInt(SearchPattern))

            If State IsNot Nothing Then
                txtStateFrom.Text = State.Id
                txtStateNameFrom.Text = State.Name
                txtStateTo.Focus()
                Exit Try
            End If

            txtStateFrom.Text = ""
            txtStateNameFrom.Text = ""

            States = Domain.TaskRepository.getAllStates(, , True)


            frmState = New frmSearch("TIPOS DE TAREA", States, SearchPattern)
            frmState.ShowDialog()

            If frmState.SelectedValue IsNot Nothing Then
                State = Domain.TaskRepository.GetStateById(CInt(frmState.SelectedValue))
                If State IsNot Nothing Then
                    txtStateFrom.Text = State.Id
                    txtStateNameFrom.Text = State.Name
                    txtStateTo.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            State = Nothing
            States = Nothing
        End Try
    End Sub

    Private Sub txtStateTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStateTo.Validating
        Dim SearchPattern As String
        Dim State As Domain.Task.TaskState
        Dim States As DataSet

        Try

            If Not txtStateTo.Enabled Then Exit Try

            SearchPattern = txtStateTo.Text

            If txtStateTo.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtStateTo.Text) Then SearchPattern = 0

            State = Domain.TaskRepository.GetStateById(CInt(SearchPattern))

            If State IsNot Nothing Then
                txtStateTo.Text = State.Id
                txtStateNameTo.Text = State.Name
                txtEventFrom.Focus()
                Exit Try
            End If

            txtStateTo.Text = ""
            txtStateNameTo.Text = ""

            States = Domain.TaskRepository.GetAllStates(, , True)


            frmState = New frmSearch("TIPOS DE TAREA", States, SearchPattern)
            frmState.ShowDialog()

            If frmState.SelectedValue IsNot Nothing Then
                State = Domain.TaskRepository.GetStateById(CInt(frmState.SelectedValue))
                If State IsNot Nothing Then
                    txtStateTo.Text = State.Id
                    txtStateNameTo.Text = State.Name
                    txtEventFrom.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            State = Nothing
            States = Nothing
        End Try
    End Sub




    Private Sub txtEventFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEventFrom.Validating
        Dim SearchPattern As String
        Dim TaskEvent As Domain.TaskEvent.EventType
        Dim Events As DataSet

        Try

            If Not txtEventFrom.Enabled Then Exit Try

            SearchPattern = txtEventFrom.Text

            If txtEventFrom.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtEventFrom.Text) Then SearchPattern = 0


            TaskEvent = Domain.TaskEventRepository.GetTypeById(CInt(SearchPattern))

            If TaskEvent IsNot Nothing Then
                txtEventFrom.Text = TaskEvent.Id
                txtEventNameFrom.Text = TaskEvent.Name
                txtEventTo.Focus()
                Exit Try
            End If

            txtEventFrom.Text = ""
            txtEventNameFrom.Text = ""

            Events = Domain.TaskEventRepository.getAllEventTypes(, , True)


            frmEvent = New frmSearch("TIPOS DE EVENTO", Events, SearchPattern)
            frmEvent.ShowDialog()

            If frmEvent.SelectedValue IsNot Nothing Then
                TaskEvent = Domain.TaskEventRepository.GetTypeById(CInt(frmEvent.SelectedValue))
                If TaskEvent IsNot Nothing Then
                    txtEventFrom.Text = TaskEvent.Id
                    txtEventNameFrom.Text = TaskEvent.Name
                    txtEventTo.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            TaskEvent = Nothing
            Events = Nothing
        End Try
    End Sub

    Private Sub txtEventTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEventTo.Validating
        Dim SearchPattern As String
        Dim TaskEvent As Domain.TaskEvent.EventType
        Dim Events As DataSet

        Try

            If Not txtEventTo.Enabled Then Exit Try

            SearchPattern = txtEventTo.Text

            If txtEventTo.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtEventTo.Text) Then SearchPattern = 0


            TaskEvent = Domain.TaskEventRepository.GetTypeById(CInt(SearchPattern))

            If TaskEvent IsNot Nothing Then
                txtEventTo.Text = TaskEvent.Id
                txtEventNameTo.Text = TaskEvent.Name
                ShowReport()
                Exit Try
            End If

            txtEventFrom.Text = ""
            txtEventNameFrom.Text = ""

            Events = Domain.TaskEventRepository.getAllEventTypes(, , True)


            frmEvent = New frmSearch("TIPOS DE EVENTO", Events, SearchPattern)
            frmEvent.ShowDialog()

            If frmEvent.SelectedValue IsNot Nothing Then
                TaskEvent = Domain.TaskEventRepository.GetTypeById(CInt(frmEvent.SelectedValue))
                If TaskEvent IsNot Nothing Then
                    txtEventTo.Text = TaskEvent.Id
                    txtEventNameTo.Text = TaskEvent.Name
                    ShowReport()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            TaskEvent = Nothing
            Events = Nothing
        End Try
    End Sub

    Private Sub frmUser_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmUser.ParametersChanged
        Dim Users As DataSet = Nothing

        Try
            Users = Domain.UserRepository.GetAll(Field, value, False)

            frmUser.DataSource = Users

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmType_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmType.ParametersChanged
        Dim Types As DataSet = Nothing

        Try
            Types = Domain.TaskRepository.GetAllTypes(Field, value, False)

            frmType.DataSource = Types

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmState_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmState.ParametersChanged
        Dim States As DataSet = Nothing

        Try
            States = Domain.TaskRepository.GetAllStates(Field, value, False)

            frmState.DataSource = States

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmEvent_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmEvent.ParametersChanged
        Dim Events As DataSet = Nothing

        Try
            Events = Domain.TaskEventRepository.GetAllEventTypes(Field, value, False)

            frmEvent.DataSource = Events

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

End Class