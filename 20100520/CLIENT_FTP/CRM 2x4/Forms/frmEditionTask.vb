Public Class frmEditionTask

    Private WithEvents frmSearchCustomer As frmSearch
    Private WithEvents frmSearchTask As frmSearch
    Private mProccess As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub



    Public Sub New(ByVal task As Domain.Task)

        InitializeComponent()

        If task.Entities IsNot Nothing Then

            For Each TaskEntity As Crm.Domain.TaskEntity In task.Entities

                GridEntities.Rows.Add(TaskEntity.Type.Id, TaskEntity.Type.UserName, TaskEntity.Code)

            Next

        End If
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub DrawMe()

        Try

            InitDate.Value = Now
            InitTime.Value = Now

            InitTime.Format = DateTimePickerFormat.Custom
            InitTime.CustomFormat = "hh:mm"

            cmbPriority.DataSource = Domain.TaskRepository.GetPriorities()
            cmbPriority.ValueMember = "Id"
            cmbPriority.DisplayMember = "Name"

            If cmbPriority.Items.Count <= 0 Then
                MsgBox("No existen prioridades", MsgBoxStyle.Information, "Atención")
                Me.Close()
                Exit Sub
            End If

            cmbUser.DataSource = Domain.UserRepository.GetByCompany(Domain.MainCompany.Id)
            cmbUser.ValueMember = "Id"
            cmbUser.DisplayMember = "NickName"
            cmbUser.SelectedValue = Domain.SystemUser.Id

            If cmbUser.Items.Count <= 0 Then
                MsgBox("No se pudo accesder a la lista de usuarios", MsgBoxStyle.Information, "Atención")
                Me.Close()
                Exit Sub
            End If


            cmbType.DataSource = Domain.TaskRepository.GetTypes()
            cmbType.ValueMember = "Id"
            cmbType.DisplayMember = "Name"

            If cmbType.Items.Count <= 0 Then
                MsgBox("No existen tipos de tareas", MsgBoxStyle.Information, "Atención")
                Me.Close()
                Exit Sub
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()

                Case Keys.F10 : SaveEntity()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub cmbUser_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUser.SelectedValueChanged
        Try

            If cmbUser.SelectedValue = Domain.SystemUser.Id Then
                txtDetail.ReadOnly = False
                txtOwnerDetail.ReadOnly = True
            Else
                txtDetail.ReadOnly = True
                txtOwnerDetail.ReadOnly = False
            End If
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub SearchCustomer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddCustomer.Click

        Dim Customers As DataSet
        Try

            Customers = Domain.CustomerRepository.GetAll(False, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)
            ' MsgBox(Domain.SystemUser.Id)

            frmSearchCustomer = New frmSearch("CLIENTES", Customers, "")
            frmSearchCustomer.ShowDialog()

            If frmSearchCustomer.SelectedValue IsNot Nothing Then
                GridEntities.Rows.Add(1, "CLIENTE", frmSearchCustomer.SelectedValue)
            End If
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmSearchCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSearchCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmSearchCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub SearchTask(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddTask.Click

        Dim Tasks As DataSet

        Try
            Tasks = Domain.TaskRepository.GetAll(Domain.SystemUser.Id, , , True)

            frmSearchTask = New frmSearch("TAREAS", Tasks, "")
            frmSearchTask.ShowDialog()

            If frmSearchCustomer.SelectedValue IsNot Nothing Then
                GridEntities.Rows.Add(2, "TAREA", frmSearchCustomer.SelectedValue)
            End If

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


    Private Sub BrowserAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAccept.Click
        Try

            SaveEntity()
            mProccess = True

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub SaveEntity()
        Dim task As Domain.Task
        Dim TaskEntity As Domain.TaskEntity
        Dim frmAlert As frmEditionAlert

        Try

            task = New Domain.Task

            task.Type = cmbType.SelectedItem
            task.User = cmbUser.SelectedItem
            task.Owner = Domain.SystemUser
            task.CompanyId = Domain.MainCompany.Id
            task.Detail = txtDetail.Text
            task.OwnerDetail = txtOwnerDetail.Text
            task.Initdate = InitDate.Value
            task.InitTime = InitTime.Value
            If chkPersonal.Checked Then
                task.InternalType = 2
            Else
                task.InternalType = 3
            End If
            task.State = New Domain.Task.TaskState With {.Id = 1}
            task.Priority = cmbPriority.SelectedItem

            If task.Entities Is Nothing Then task.Entities = New List(Of Domain.TaskEntity)

            Dim sData As String
            Dim iCount As Integer
            iCount = 0

            For Each row As DataGridViewRow In GridEntities.Rows

                iCount = iCount + 1
                TaskEntity = New Domain.TaskEntity

                TaskEntity.Type = Domain.SystemEntities(CStr(row.Cells(0).Value))

                TaskEntity.Code = row.Cells(2).Value
                If iCount = 1 Then sData = row.Cells(1).Value & " " & TaskEntity.Code

                task.Entities.Add(TaskEntity)

            Next

            Domain.TaskRepository.Save(task)

            If chkAlert.Checked Then
                frmAlert = New frmEditionAlert(InitDate.Value, InitTime.Value, cmbType.SelectedItem.name & " - " & sData, txtDetail.Text)
                frmAlert.Show()

            End If

            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click, BrowserCancel.Click
        Try

            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub User_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbUser.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            If cmbUser.SelectedItem IsNot Nothing Then cmbType.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Type_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            If cmbType.SelectedItem IsNot Nothing Then cmbPriority.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub Priority_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPriority.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            If cmbPriority.SelectedItem IsNot Nothing Then InitDate.Focus()

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

            chkAlert.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub Alert_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkAlert.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            chkPersonal.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub TaskPersonal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkPersonal.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            If txtDetail.Enabled Then
                txtDetail.Focus()
            Else
                txtOwnerDetail.Focus()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub Combo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUser.TextChanged, cmbType.TextChanged, cmbPriority.TextChanged
        Try


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CheckBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonal.Enter, chkAlert.Enter
        Try

            sender.Backcolor = System.Drawing.SystemColors.ControlLight

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub CheckBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonal.Leave, chkAlert.Leave
        Try

            sender.Backcolor = System.Drawing.SystemColors.Control

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Public Property ProccessOk() As Boolean
        Get
            Return mProccess
        End Get
        Set(ByVal value As Boolean)
            ProccessOk = mProccess
        End Set
    End Property


End Class