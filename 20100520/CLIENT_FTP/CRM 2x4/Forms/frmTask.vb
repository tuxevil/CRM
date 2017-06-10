Public Class frmTask

    Private task As Crm.Domain.Task
    Private Codes As List(Of Integer) = Nothing
    Private ListIndex As Integer

    Private WithEvents frmTaskTypes As frmTypes
    Private WithEvents frmEventTypes As frmTypes
    Private WithEvents frmTaskPriorities As frmTypes
    Private WithEvents frmEvent As frmEvent

    Private WithEvents frmSearchRealCustomer As frmSearch
    Private WithEvents frmSearchPotentialCustomer As frmSearch

    Private WithEvents frmSearchTask As frmSearch
    Private WithEvents frmNewTask As frmEditionTask

    Public Property DataSource() As List(Of Integer)
        Get
            Return Codes
        End Get
        Set(ByVal value As List(Of Integer))
            Codes = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Source As List(Of Integer))

        InitializeComponent()
        Codes = Source

    End Sub

    Public Sub New(ByVal TaskCode As Integer)

        InitializeComponent()

        Codes = New List(Of Integer)
        Codes.Add(TaskCode)
        MenuFile.Visible = False
        Browser.Visible = False
        MenuSearch.Visible = False

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Pnl As Panel
        Dim Lbl As Label = Nothing

        Try

            For Each FormControl As Control In Me.Controls
                Pnl = TryCast(FormControl, Panel)

                If Pnl IsNot Nothing Then

                    For Each Control As Control In Pnl.Controls

                        Lbl = TryCast(Control, Label)
                        If Lbl IsNot Nothing Then Lbl.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

                    Next
                End If

            Next

            For Each FormControl As Control In Me.Controls

                Lbl = TryCast(FormControl, Label)
                If Lbl IsNot Nothing Then Lbl.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            Next

            LoadTask()

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
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

    Private Sub DrawMe()
        Try

            BindPanelS()
            Me.Controls.Remove(pnlGeneral)
            Me.Controls.Remove(pnlEntities)
            Me.Controls.Remove(pnlEvents)

            GotoModules(tbGeneral, System.EventArgs.Empty)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GotoModules(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGeneral.Click, tbEntities.Click, tbEvents.Click

        Dim panel As Panel = Nothing

        frmSplit.Panel2.Controls.Clear()

        For Each Button As ToolStripButton In tsTask.Items
            Button.Checked = False
        Next

        Select Case sender.Name

            Case tbGeneral.Name
                panel = pnlGeneral

            Case tbEntities.Name
                panel = pnlEntities

            Case tbEvents.Name
                panel = pnlEvents

        End Select

        If panel IsNot Nothing Then
            frmSplit.Panel2.Controls.Add(panel)
            panel.Dock = DockStyle.Fill
            sender.checked = True
        End If

    End Sub


    Private Sub BindPanels()


        Try
            ClearPanels()

            If task Is Nothing Then

                For Each Item As ToolStripItem In MenuAction.DropDownItems
                    Item.Enabled = False
                Next
                Exit Sub

            End If

            If task.Id = 0 Then

                For Each Item As ToolStripItem In MenuAction.DropDownItems
                    Item.Enabled = False
                Next
                Exit Sub

            End If

            If task.Type IsNot Nothing Then lblTitle.Text = task.Type.Name

            If task.Detail <> "" Then lblTitle.Text = lblTitle.Text & " - " & Mid(task.Detail, 1, 100)

            If task.Priority IsNot Nothing Then txtPriority.Text = task.Priority.Name
            If task.State IsNot Nothing Then
                txtStatus.Text = task.State.Name

                If task.State.Id <> 1 Then
                    For Each Item As ToolStripItem In MenuAction.DropDownItems
                        Item.Enabled = False
                    Next
                Else
                    For Each Item As ToolStripItem In MenuAction.DropDownItems
                        Item.Enabled = True
                    Next
                End If

            End If


            If task.User IsNot Nothing Then txtUser.Text = task.User.NickName
            If task.Owner IsNot Nothing Then 'Error en términos debería decir UserInit
                txtOwner.Text = task.Owner.NickName
            Else
                txtOwner.Text = " -"
            End If

            If task.Admin IsNot Nothing Then
                txtAdmin.Text = task.Admin.NickName
            Else
                txtAdmin.Text = " -"
            End If

            If task.UserProfile IsNot Nothing Then
                txtProfile.Text = task.UserProfile.Name
            Else
                txtProfile.Text = " -"
            End If


            If task.SystemDate <> "01/01/1800" Then txtSystemDate.Text = Format(task.SystemDate, "dd/MM/yyyy")
            If task.Initdate <> "01/01/1800" Then txtInitDate.Text = Format(task.Initdate, "dd/MM/yyyy")
            If task.InitTime <> "01/01/1800" Then txtInitTime.Text = Format(task.InitTime, "hh:mm")
            If task.Firstdate <> "01/01/1800" Then txtFirstDate.Text = Format(task.Firstdate, "dd/MM/yyyy")
            If task.Lastdate <> "01/01/1800" Then txtLastDate.Text = Format(task.Lastdate, "dd/MM/yyyy")

            If task.Detail IsNot Nothing Then txtDetail.Text = task.Detail
            If task.OwnerDetail IsNot Nothing Then txtOwnerDetail.Text = task.OwnerDetail

            If task.Entities IsNot Nothing Then

                For Each TaskEntity As Crm.Domain.TaskEntity In task.Entities

                    GridEntities.Rows.Add(TaskEntity.Type.Id, TaskEntity.Type.UserName, TaskEntity.Code)

                Next

            End If

            If task.Events IsNot Nothing Then

                For Each TaskEvent As Crm.Domain.TaskEvent In task.Events

                    GridEvents.Rows.Add(TaskEvent.EventDate, TaskEvent.EventTime, TaskEvent.Type.Name, TaskEvent.Detail)

                Next

            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ClearPanels()
        Dim txt As TextBox = Nothing

        Try
            lblTitle.Text = ""

            For Each ctrl As Control In pnlGeneral.Controls
                txt = TryCast(ctrl, TextBox)
                If txt IsNot Nothing Then txt.Text = ""
            Next

            For Each ctrl As Control In GroupUser.Controls
                txt = TryCast(ctrl, TextBox)
                If txt IsNot Nothing Then txt.Text = ""
            Next

            For Each ctrl As Control In GroupDates.Controls
                txt = TryCast(ctrl, TextBox)
                If txt IsNot Nothing Then txt.Text = ""
            Next

            GridEvents.Rows.Clear()

            GridEntities.Rows.Clear()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTask()

        Try

            If Codes Is Nothing Then
                task = New Domain.Task
            Else
                If Codes.Count <= 0 Then
                    task = New Domain.Task
                Else
                    If ListIndex < Codes.Count Then
                        task = Domain.TaskRepository.GetById(Codes(ListIndex))
                    Else
                        task = Domain.TaskRepository.GetById(Codes(0))
                    End If
                End If
            End If

            DrawMe()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BrowserIconsSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenuViewLargeIcons.Click, BrowserMenuViewSmallIcons.Click
        Dim IScale As ToolStripItemImageScaling = ToolStripItemImageScaling.None

        Try
            BrowserMenuViewLargeIcons.Checked = Not BrowserMenuViewLargeIcons.Checked
            BrowserMenuViewSmallIcons.Checked = Not BrowserMenuViewSmallIcons.Checked

            If BrowserMenuViewSmallIcons.Checked Then IScale = ToolStripItemImageScaling.SizeToFit

            For Each item As ToolStripItem In Browser.Items
                item.ImageScaling = IScale
            Next

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub BrowserFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserFirst.Click, MenuSearchFirst.Click
        Try
            ListIndex = 0
            LoadTask()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserPrevious.Click, MenuSearchPrevious.Click

        If ListIndex > 0 Then
            ListIndex = ListIndex - 1
            LoadTask()
        End If

    End Sub

    Private Sub BrowserNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserNext.Click, MenuSearchNext.Click
        If ListIndex < Codes.Count - 1 Then
            ListIndex = ListIndex + 1
            LoadTask()
        End If
    End Sub


    Private Sub BrowserLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserLast.Click, MenuSearchLast.Click
        ListIndex = Codes.Count - 1
        LoadTask()
    End Sub

    Private Sub ViewTaskEntity(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridEntities.CellMouseDoubleClick

        Try
            OpenEntity(GridEntities.Rows(e.RowIndex).Cells(0).Value, GridEntities.Rows(e.RowIndex).Cells(2).Value)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub OpenEntity(ByVal EntityType As Integer, ByVal EntityCode As String)
        Dim frm As Form

        Try

            Select Case EntityType
                Case 1
                    frm = New frmCustomer(EntityCode)
                    frm.Show()

                Case 2
                    frm = New frmTask(EntityCode)
                    frm.Show()

                Case 4
                    frm = New frmCustomer(EntityCode, True)
                    frm.Show()

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditTypes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditionTypes.Click
        Try

            frmTaskTypes = New frmTypes("TIPOS DE TAREAS", Domain.TaskRepository.GetTableTypes())
            frmTaskTypes.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmTaskTypes_CodeChanged(ByVal Code As Integer) Handles frmTaskTypes.CodeChanged

        Try
            If Domain.TaskRepository.GetTypeById(Code) Is Nothing Then
                frmTaskTypes.CodeValid = 1
            Else
                frmTaskTypes.CodeValid = -1
            End If

        Catch ex As Exception
            frmTaskTypes.CodeValid = -1
        End Try
    End Sub

    Private Sub frmTaskTypes_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmTaskTypes.SourceChanged

        Try
            Domain.TaskRepository.SaveType(Code, Name, Description, Otherdetails)

            frmTaskTypes.DataSource = Domain.TaskRepository.GetTableTypes()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub



    Private Sub EditPriorities(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditionPriorities.Click
        Try

            frmTaskPriorities = New frmTypes("PRIORIDADES", Domain.TaskRepository.GetTablePriorities())
            frmTaskPriorities.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmTaskPriorities_CodeChanged(ByVal Code As Integer) Handles frmTaskPriorities.CodeChanged

        Try
            If Domain.TaskRepository.GetPriorityById(Code) Is Nothing Then
                frmTaskPriorities.CodeValid = 1
            Else
                frmTaskPriorities.CodeValid = -1
            End If

        Catch ex As Exception
            frmTaskPriorities.CodeValid = -1
        End Try
    End Sub

    Private Sub frmTaskPriorities_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmTaskPriorities.SourceChanged

        Try
            Domain.TaskRepository.SavePriority(Code, Name, Description, Otherdetails)

            frmTaskPriorities.DataSource = Domain.TaskRepository.GetTablePriorities()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub













    Private Sub EditEventTypes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditionEventTypes.Click
        Try

            frmEventTypes = New frmTypes("TIPOS DE EVENTOS", Domain.TaskEventRepository.GetTableTypes())
            frmEventTypes.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmEventTypes_CodeChanged(ByVal Code As Integer) Handles frmEventTypes.CodeChanged

        Try
            If Domain.TaskEventRepository.GetTypeById(Code) Is Nothing Then
                frmEventTypes.CodeValid = 1
            Else
                frmEventTypes.CodeValid = -1
            End If

        Catch ex As Exception
            frmEventTypes.CodeValid = -1
        End Try
    End Sub

    Private Sub frmEventTypes_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmEventTypes.SourceChanged

        Try
            Domain.TaskEventRepository.SaveType(Code, Name, Description, Otherdetails)

            frmEventTypes.DataSource = Domain.TaskEventRepository.GetTableTypes()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CloseTask(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionCloseTask.Click
        Try

            frmEvent = New frmEvent
            frmEvent.ShowDialog()

            If frmEvent.DialogResult = Windows.Forms.DialogResult.OK Then
                Domain.TaskRepository.CloseTask(task.Id)

                LoadTask()

                DrawMe()

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CancelTask(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionCancelTask.Click
        Try
            frmEvent = New frmEvent
            frmEvent.ShowDialog()

            If frmEvent.DialogResult = Windows.Forms.DialogResult.OK Then
                Domain.TaskRepository.CancelTask(task.Id)

                LoadTask()

                DrawMe()

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub AddEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionAddEvent.Click
        Try

            frmEvent = New frmEvent
            frmEvent.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmEvent_SourceChanged(ByVal EventType As Integer, ByVal Detail As String) Handles frmEvent.SourceChanged
        Try


            Domain.TaskEventRepository.save(task.Id, EventType, Detail)

            LoadTask()

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub SearchRealCustomer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionAddCustomerReal.Click

        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(False, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmSearchRealCustomer = New frmSearch("CLIENTES", Customers, "")
            frmSearchRealCustomer.ShowDialog()

            If frmSearchRealCustomer.SelectedValue IsNot Nothing Then
                Domain.TaskRepository.AddEntity(task.Id, 1, frmSearchRealCustomer.SelectedValue)
            End If

            LoadTask()

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub SearchPotentialCustomer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionAddCustomerPotential.Click

        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(True, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmSearchPotentialCustomer = New frmSearch("CLIENTES POTENCIALES", Customers, "")
            frmSearchPotentialCustomer.ShowDialog()

            If frmSearchRealCustomer.SelectedValue IsNot Nothing Then
                Domain.TaskRepository.AddEntity(task.Id, 4, frmSearchPotentialCustomer.SelectedValue)
            End If

            LoadTask()

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmSearchRealCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSearchRealCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(False, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmSearchRealCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub frmSearchPotentialCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSearchPotentialCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(True, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmSearchPotentialCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub SearchTask(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionAddTask.Click

        Dim Tasks As DataSet

        Try
            Tasks = Domain.TaskRepository.GetAll(Domain.SystemUser.Id, , , True)

            frmSearchTask = New frmSearch("TAREAS", Tasks, "")
            frmSearchTask.ShowDialog()

            If frmSearchTask.SelectedValue IsNot Nothing Then
                If CInt(frmSearchTask.SelectedValue) <> task.Id Then
                    Domain.TaskRepository.AddEntity(task.Id, 2, frmSearchTask.SelectedValue)
                Else
                    MsgBox("La tarea no puede autoreferenciarse", MsgBoxStyle.Information, "Atención")
                End If
            End If

                LoadTask()

                DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmSearchTask_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSearchTask.ParametersChanged
        Dim Tasks As DataSet

        Try
            Tasks = Domain.TaskRepository.GetAll(Domain.SystemUser.Id, Field, value, False)

            frmSearchTask.DataSource = Tasks

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub


    Private Sub TaskentityMenuRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskentityMenuRemove.Click
        Dim row As DataGridViewRow
        Try

            If GridEntities.SelectedRows Is Nothing Then Exit Sub

            row = GridEntities.SelectedRows(0)

            Domain.TaskRepository.RemoveEntity(task.Id, CInt(row.Cells(0).Value), row.Cells(2).Value)

            LoadTask()

            DrawMe()


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserSearch.Click, MenuSearchByKey.Click
        Dim Tasks As DataSet

        Try
            Tasks = Domain.TaskRepository.GetAll(Domain.SystemUser.Id, , , True)

            frmSearchTask = New frmSearch("TAREAS", Tasks, "")
            frmSearchTask.ShowDialog()

            If frmSearchTask.SelectedValue IsNot Nothing Then

                task = Domain.TaskRepository.GetById(CInt(frmSearchTask.SelectedValue))

                DrawMe()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub BrowserAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAdd.Click, MenuFileAdd.Click


        Try

            frmNewTask = New frmEditionTask
            'Puse como modal para luego actualizar el formulario actual mostrando las modificaciones
            frmNewTask.ShowDialog()

            'Vuelvo a asignar la colección de task al formulario
            If frmNewTask.ProccessOk Then
                Codes = Domain.TaskRepository.GetCodes(Domain.SystemUser.Id)
                DrawMe()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub GridEvents_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridEvents.CellDoubleClick

        Try
            If e.ColumnIndex <> 3 Then Exit Sub

            GridEvents.Rows(e.RowIndex).Cells(3).ToolTipText = CStr(GridEvents.Rows(e.RowIndex).Cells(3).Value)

            GridEvents.ShowCellToolTips = True

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally

        End Try

    End Sub

    Private Sub BrowserAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAccept.Click

    End Sub

    Private Sub frmSplit_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles frmSplit.Panel2.Paint

    End Sub
End Class