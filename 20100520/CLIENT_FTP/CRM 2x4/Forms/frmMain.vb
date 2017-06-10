Public Class frmMain

    Private NodeCustomersParametersContactsAreas As TreeNode
    Private NodeCustomersParametersContactsCargos As TreeNode
    Private NodeCustomersParametersContacts As TreeNode
    Private NodeCustomersParametersCancelReassons As TreeNode

    Private NodeCustomersProcessRealCustomersDelete As TreeNode
    Private NodeCustomersProcessRealCustomers As TreeNode

    Private NodeCustomersProcessPotentialCustomersDelete As TreeNode
    Private NodeCustomersProcessPotentialCustomersToReal As TreeNode
    Private NodeCustomersProcessPotentialCustomers As TreeNode
    Private NodeCustomersProcessConfirmCustomersDeleted As TreeNode
    Private NodeCustomersProcess As TreeNode

    Private NodeCustomersParameters As TreeNode
    Private NodeCustomersEditionRealContacts As TreeNode
    Private NodeCustomersEditionPotentialContacts As TreeNode
    Private NodeCustomersEditionRealCustomers As TreeNode
    Private NodeCustomersEditionPotencialCustomers As TreeNode
    Private NodeCustomersEditionCustomersReal As TreeNode
    Private NodeCustomersEditionCustomersPotential As TreeNode
    Private NodeCustomersEditionCustomers As TreeNode
    Private NodeCustomersEdition As TreeNode
    Private NodeCustomersFiles As TreeNode
    Private NodeCustomersReportsCustomersList As TreeNode
    Private NodeCustomersReportsCustomersDeleted As TreeNode
    Private NodeCustomersReportsCustomersToTango As TreeNode
    Private NodeCustomersReportsPotentialCustomersEntry As TreeNode
    Private NodeCustomersReports As TreeNode
    Private NodeCustomers As TreeNode

    Private NodeTasksReportsCustomersTaskDetails As TreeNode
    Private NodeTasksReportsCustomersTaskSummary As TreeNode
    Private NodeTasksReportsTaskDetails As TreeNode
    Private NodeTasksReportsEventSumary As TreeNode
    Private NodeTasksReportsTaksSumary As TreeNode
    Private NodeTasksReports As TreeNode
    Private NodeTasksParametersTaskTypes As TreeNode
    Private NodeTasksParametersTaskPriorities As TreeNode
    Private NodeTasksParametersTasks As TreeNode
    Private NodeTasksParametersEventTypes As TreeNode
    Private NodeTasksParametersEvents As TreeNode
    Private NodeTasksParameters As TreeNode
    Private NodeTaskEditionAddAlert As TreeNode
    Private NodeTasksEditionAlerts As TreeNode
    Private NodeTasksEditionTasks As TreeNode
    Private NodeTasksEdition As TreeNode
    Private NodeTasksFiles As TreeNode
    Private NodeTasks As TreeNode

    Private FavoritesDirectory As String = System.Windows.Forms.Application.UserAppDataPath & "\Favoritos\"
    Private WithEvents FavoritesWatcher As System.IO.FileSystemWatcher

    Private CustomerContactCode As String

    Public Sub New()

        Dim btest As Boolean = False

        InitializeComponent()

        Try
            ' Nodos del arbol
            NodeCustomersParametersContactsAreas = New TreeNode("Areas")
            NodeCustomersParametersContactsCargos = New TreeNode("Cargos")
            NodeCustomersParametersContacts = New TreeNode("Contactos", New TreeNode() {NodeCustomersParametersContactsAreas, NodeCustomersParametersContactsCargos})
            NodeCustomersParametersCancelReassons = New TreeNode("Motivos de baja")
            NodeCustomersParameters = New TreeNode("Parametros generales", New TreeNode() {NodeCustomersParametersContacts, NodeCustomersParametersCancelReassons})
            NodeCustomersEditionRealCustomers = New TreeNode("Clientes")
            NodeCustomersEditionRealContacts = New TreeNode("Contactos")
            NodeCustomersEditionCustomersReal = New TreeNode("Clientes reales", New TreeNode() {NodeCustomersEditionRealContacts, NodeCustomersEditionRealCustomers})
            NodeCustomersEditionPotencialCustomers = New TreeNode("Clientes")
            NodeCustomersEditionPotentialContacts = New TreeNode("Contactos")
            NodeCustomersEditionCustomersPotential = New TreeNode("Clientes potenciales", New TreeNode() {NodeCustomersEditionPotentialContacts, NodeCustomersEditionPotencialCustomers})
            NodeCustomersEditionCustomers = New TreeNode("Clientes", New TreeNode() {NodeCustomersEditionCustomersPotential, NodeCustomersEditionCustomersReal})
            NodeCustomersEdition = New TreeNode("Altas y modificaciones", New TreeNode() {NodeCustomersEditionCustomers})
            NodeCustomersProcessPotentialCustomersToReal = New TreeNode("Pasaje a Tango Gestión")
            NodeCustomersProcessPotentialCustomersDelete = New TreeNode("Baja")
            NodeCustomersProcessPotentialCustomers = New TreeNode("Clientes potenciales", New TreeNode() {NodeCustomersProcessPotentialCustomersToReal, NodeCustomersProcessPotentialCustomersDelete})
            NodeCustomersProcessRealCustomersDelete = New TreeNode("Baja")
            NodeCustomersProcessRealCustomers = New TreeNode("Clientes reales", New TreeNode() {NodeCustomersProcessRealCustomersDelete})
            NodeCustomersProcessConfirmCustomersDeleted = New TreeNode("Confirmación de bajas")
            NodeCustomersProcess = New TreeNode("Procesos", New TreeNode() {NodeCustomersProcessPotentialCustomers, NodeCustomersProcessRealCustomers, NodeCustomersProcessConfirmCustomersDeleted})
            NodeCustomersFiles = New TreeNode("Archivos", New TreeNode() {NodeCustomersParameters, NodeCustomersEdition, NodeCustomersProcess})

            If Not btest Then
                'Customer Reports
                NodeCustomersReportsCustomersList = New TreeNode("Nómina de clientes")
                NodeCustomersReportsCustomersDeleted = New TreeNode("Baja de clientes")
                NodeCustomersReportsCustomersToTango = New TreeNode("Pasaje de clientes a Tango")
                NodeCustomersReportsPotentialCustomersEntry = New TreeNode("Alta de clientes potenciales")
                NodeCustomersReports = New TreeNode("Informes", New TreeNode() {NodeCustomersReportsPotentialCustomersEntry, NodeCustomersReportsCustomersToTango, NodeCustomersReportsCustomersDeleted, NodeCustomersReportsCustomersList})
                NodeCustomers = New TreeNode("Clientes", New TreeNode() {NodeCustomersFiles, NodeCustomersReports})
            Else
                NodeCustomers = New TreeNode("Clientes", New TreeNode() {NodeCustomersFiles})
            End If
            ''NodeCustomers = New TreeNode("Clientes", New TreeNode() {NodeCustomersFiles, NodeCustomersReports})
            ''''NodeCustomers = New TreeNode("Clientes", New TreeNode() {NodeCustomersFiles})

            'TASKS Reports
            If Not btest Then
                NodeTasksReportsCustomersTaskDetails = New TreeNode("Detalle de clientes con actividad")
                NodeTasksReportsCustomersTaskSummary = New TreeNode("Resumen de clientes con actividad")
                NodeTasksReportsTaskDetails = New TreeNode("Detalle de tareas")
                NodeTasksReportsEventSumary = New TreeNode("Resumen de eventos")
                NodeTasksReportsTaksSumary = New TreeNode("Resumen de tareas")
                NodeTasksReports = New TreeNode("Informes", New TreeNode() {NodeTasksReportsTaksSumary, NodeTasksReportsEventSumary, NodeTasksReportsTaskDetails, NodeTasksReportsCustomersTaskSummary, NodeTasksReportsCustomersTaskDetails})
                'Else
                '    NodeTasksReports = New TreeNode("Informes", New TreeNode() {NodeTasksReportsTaksSumary, NodeTasksReportsEventSumary, NodeTasksReportsTaskDetails, NodeTasksReportsCustomersTaskSummary, NodeTasksReportsCustomersTaskDetails})
            End If
            '
            NodeTasksParametersTaskTypes = New TreeNode("Tipos")
            NodeTasksParametersTaskPriorities = New TreeNode("Prioridades")
            NodeTasksParametersTasks = New TreeNode("Tareas", New TreeNode() {NodeTasksParametersTaskTypes, NodeTasksParametersTaskPriorities})
            NodeTasksParametersEventTypes = New TreeNode("Tipos")
            NodeTasksParametersEvents = New TreeNode("Eventos", New TreeNode() {NodeTasksParametersEventTypes})
            NodeTasksParameters = New TreeNode("Parametros generales", New TreeNode() {NodeTasksParametersTasks, NodeTasksParametersEvents})
            NodeTaskEditionAddAlert = New TreeNode("Nueva alerta")
            NodeTasksEditionAlerts = New TreeNode("Alertas")
            NodeTasksEditionTasks = New TreeNode("Tareas")
            NodeTasksEdition = New TreeNode("Altas y modificaciones", New TreeNode() {NodeTasksEditionTasks, NodeTaskEditionAddAlert, NodeTasksEditionAlerts})
            NodeTasksFiles = New TreeNode("Archivos", New TreeNode() {NodeTasksParameters, NodeTasksEdition})

            If Not btest Then
                NodeTasks = New TreeNode("Tareas", New TreeNode() {NodeTasksFiles, NodeTasksReports})
            Else
                NodeTasks = New TreeNode("Tareas", New TreeNode() {NodeTasksFiles})
            End If

            If Not btest Then
                NodeCustomersReportsCustomersList.Tag = "125"
                NodeCustomersReportsCustomersDeleted.Tag = "124"
            End If

            NodeCustomersProcessConfirmCustomersDeleted.Tag = "123"
            NodeCustomersProcessRealCustomersDelete.Tag = "1221"
            NodeCustomersProcessRealCustomers.Tag = "122"
            NodeCustomersProcessPotentialCustomersToReal.Tag = "1211"
            NodeCustomersProcessPotentialCustomersDelete.Tag = "1212"
            NodeCustomersProcessPotentialCustomers.Tag = "121"
            NodeCustomersProcess.Tag = "12"

            NodeCustomersParametersContactsAreas.Tag = "11011"
            NodeCustomersParametersContactsCargos.Tag = "11012"
            NodeCustomersParametersContacts.Tag = "1101"
            NodeCustomersParametersCancelReassons.Tag = "1102"
            NodeCustomersParameters.Tag = "110"
            NodeCustomersEditionRealCustomers.Tag = ""
            NodeCustomersEditionRealContacts.Tag = "1112"

            NodeCustomersEditionPotencialCustomers.Tag = "111111"
            NodeCustomersEditionPotentialContacts.Tag = "111112"
            NodeCustomersEditionCustomersPotential.Tag = "11111"

            NodeCustomersEditionRealCustomers.Tag = "111121"
            NodeCustomersEditionRealContacts.Tag = "111122"
            NodeCustomersEditionCustomersReal.Tag = "11112"
            NodeCustomersEditionCustomers.Tag = "1111"
            NodeCustomersEdition.Tag = "111"
            NodeCustomersFiles.Tag = "11"

            If Not btest Then
                NodeCustomersReportsCustomersToTango.Tag = "122"
                NodeCustomersReportsPotentialCustomersEntry.Tag = "121"
                NodeCustomersReports.Tag = "12"
            End If
            
            NodeCustomers.Tag = "1"

            If Not btest Then
                NodeTasksReportsCustomersTaskDetails.Tag = "225"
                NodeTasksReportsCustomersTaskSummary.Tag = "224"
                NodeTasksReportsTaskDetails.Tag = "223"
                NodeTasksReportsEventSumary.Tag = "222"
                NodeTasksReportsTaksSumary.Tag = "221"
                NodeTasksReports.Tag = "22"
            End If
            
            NodeTasksParametersTaskTypes.Tag = "21011"
            NodeTasksParametersTaskPriorities.Tag = "21012"
            NodeTasksParametersTasks.Tag = "2101"
            NodeTasksParametersEventTypes.Tag = "21021"
            NodeTasksParametersEventTypes.Text = "Tipos"
            NodeTasksParametersEvents.Tag = "2102"
            NodeTasksParameters.Tag = "210"
            NodeTasksEditionAlerts.Tag = "2113"
            NodeTaskEditionAddAlert.Tag = "2112"
            NodeTasksEditionTasks.Tag = "2111"
            NodeTasksEdition.Tag = "211"
            NodeTasksFiles.Tag = "21"
            NodeTasks.Tag = "2"
5:
            ' Watcher de los favoritos
            FavoritesWatcher = New System.IO.FileSystemWatcher(FavoritesDirectory, "*.lnk")
            FavoritesWatcher.EnableRaisingEvents = True

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
        End Try

        Try

            AddHandlers()

            DrawMe()

            MainTree.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub AddHandlers()

        Try
            AddHandler SCCustomers.Click, AddressOf GotoModule
            AddHandler SCTango.Click, AddressOf GotoModule
            AddHandler SCTasks.Click, AddressOf GotoModule
            AddHandler SCTools.Click, AddressOf GotoModule

            AddHandler MainMenuGoToCustomers.Click, AddressOf GotoModule
            AddHandler MainMenuGoToTango.Click, AddressOf GotoModule
            AddHandler MainMenuGoToTasks.Click, AddressOf GotoModule
            AddHandler MainMenuGoToTools.Click, AddressOf GotoModule

            AddHandler FavoritesWatcher.Renamed, AddressOf FavoritesWatcherEvent
            AddHandler FavoritesWatcher.Created, AddressOf FavoritesWatcherEvent
            AddHandler FavoritesWatcher.Deleted, AddressOf FavoritesWatcherEvent
            AddHandler FavoritesWatcher.Disposed, AddressOf FavoritesWatcherEvent

            AddHandler RefreshTimers.Tick, AddressOf ShowPendingTasks
            AddHandler AlertTimer.Tick, AddressOf ShowAlerts

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DrawMe()

        Try
            Me.Text = System.Windows.Forms.Application.ProductName & " - " & Domain.MainCompany.Name & " - " & System.Windows.Forms.Application.ProductVersion
            Me.lblMainTitle.Text = System.Windows.Forms.Application.ProductName & " - " & Domain.MainCompany.Name & " "
            ' MsgBox(System.Windows.Forms.Application.ProductVersion)
            btModules.Checked = Not My.Settings.PanelModules
            btTasks.Checked = Not My.Settings.PanelTasks
            btFavorites.Checked = Not My.Settings.PanelFavorites

            MainMenuViewTitle.Checked = My.Settings.PanelTitle
            MainMenuViewToolBarLargeIcons.Checked = Not My.Settings.LargeIcons

            MainTree.Font = My.Settings.TreeFont

            ViewModules(btModules, System.EventArgs.Empty)
            ViewTasks(btTasks, System.EventArgs.Empty)
            ViewFavorites(btFavorites, System.EventArgs.Empty)
            ViewTitle(MainMenuViewTitle, System.EventArgs.Empty)

            lblUser.Text = "Usuario: " & Domain.SystemUser.NickName
            lblCompany.Text = "Empresa: " & Domain.MainCompany.Name
            lblKey.Text = "Llave: " & Domain.TgKey
            lblVersion.Text = "Versión: " & Application.ProductVersion


            Icons_ChangeSize(MainMenuViewToolBarLargeIcons, System.EventArgs.Empty)

            GotoModule(tsModules.Items(My.Settings.LastModule), System.EventArgs.Empty)

            FillList()
            ShowPendingTasks()

            RefreshTimers.Interval = 60000
            RefreshTimers.Start()

            AlertTimer.Interval = 60000
            AlertTimer.Start()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If e.CloseReason <> CloseReason.UserClosing Then Exit Sub

            If MsgBox("Esta seguro que desea cerrar la sesion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CRM 2x4") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub Form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Try

            For Each ctrl As ToolStripStatusLabel In StatusBar.Items

                ctrl.Width = StatusBar.Width / 4.05

            Next

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Me.Close()

                Case Keys.F6 : MainTree.Focus()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    Private Sub GotoModule(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Button As ToolStripButton = Nothing

        Try

            For Each bt As ToolStripButton In tsModules.Items

                bt.Checked = False

            Next

        Catch ex As Exception
            ex = Nothing
        End Try

        Try

            If sender.GetType.Name = "ToolStripButton" Then
                Button = sender

            Else
                Select Case sender.name

                    Case "MainMenuGoToCustomers" : Button = SCCustomers

                    Case "MainMenuGoToTango" : Button = SCTango

                    Case "MainMenuGoToTasks" : Button = SCTasks

                    Case "MainMenuGoToTools" : Button = SCTools

                End Select

            End If

            If Button IsNot Nothing Then
                Button.Checked = True
                My.Settings.LastModule = Button.Name
                My.Settings.Save()
                lblModule.Text = "Modulo:  " & Button.Text
            End If

        Catch ex As Exception
            ex = Nothing

        End Try

        Try

            DrawTree(sender.Name)

            MainTree.Focus()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")

        Finally
            Button = Nothing

        End Try

    End Sub

    Private Sub DrawTree(ByVal ModuleName As String)

        Try
            MainTree.Nodes.Clear()

            Select Case ModuleName

                Case SCCustomers.Name, MainMenuGoToCustomers.Name

                    MainTree.Nodes.Add(NodeCustomers)

                Case SCTasks.Name, MainMenuGoToTasks.Name

                    MainTree.Nodes.Add(NodeTasks)

                Case SCTango.Name, MainMenuGoToTango.Name

                Case SCTools.Name, MainMenuGoToTools.Name


            End Select

            MainTree.ExpandAll()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ViewModules(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewModules.Click, btModules.Click
        Try
            sender.Checked = Not sender.Checked

            MainMenuViewModules.Checked = sender.Checked
            btModules.Checked = sender.Checked
            pnlModules.Visible = sender.Checked

            My.Settings.PanelModules = sender.Checked
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub


    Private Sub ViewTasks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewTasks.Click, btTasks.Click
        Try
            sender.Checked = Not sender.Checked

            MainMenuViewTasks.Checked = sender.Checked
            btTasks.Checked = sender.Checked
            pnlTasks.Visible = sender.Checked

            My.Settings.PanelTasks = sender.Checked
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub


    Private Sub ViewFavorites(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewFavorites.Click, btFavorites.Click
        Try
            sender.Checked = Not sender.Checked

            MainMenuViewFavorites.Checked = sender.Checked
            btFavorites.Checked = sender.Checked
            pnlFavorites.Visible = sender.Checked

            My.Settings.PanelTasks = sender.Checked
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub ViewTitle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewTitle.CheckedChanged
        Try

            pnlTitle.Visible = sender.Checked

            My.Settings.PanelTitle = sender.Checked
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub


    Private Sub Icons_ChangeSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewToolBarSmallIcons.Click, MainMenuViewToolBarLargeIcons.Click

        Dim ImgScl As ToolStripItemImageScaling = ToolStripItemImageScaling.SizeToFit

        Try

            MainMenuViewToolBarLargeIcons.Checked = Not (MainMenuViewToolBarLargeIcons.Checked)
            MainMenuViewToolBarSmallIcons.Checked = Not (MainMenuViewToolBarSmallIcons.Checked)

            If MainMenuViewToolBarLargeIcons.Checked Then ImgScl = ToolStripItemImageScaling.None

            For Each bt As ToolStripButton In ToolBar.Items
                bt.ImageScaling = ImgScl
            Next

            My.Settings.LargeIcons = MainMenuViewToolBarLargeIcons.Checked
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub NewWindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuFileNewWindow.Click

        Dim NewWindow As Process

        Try

            NewWindow = Process.Start(System.Windows.Forms.Application.ProductName)

        Catch ex As Exception
            frmError.ShowException(ex)

        End Try


    End Sub

    Private Sub AppExit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuFileExit.Click
        Try
            Me.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub ResetView(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewReset.Click
        Try
            My.Settings.LargeIcons = True
            My.Settings.PanelModules = True
            My.Settings.PanelTasks = True
            My.Settings.PanelTitle = True
            My.Settings.PanelFavorites = True

            My.Settings.Save()

            DrawMe()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub SelectFont(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuViewTreeFont.Click

        Dim browser As FontDialog

        Try

            browser = New FontDialog
            browser.AllowVerticalFonts = False
            browser.Font = My.Settings.TreeFont

            If browser.ShowDialog() = Windows.Forms.DialogResult.OK Then My.Settings.TreeFont = browser.Font

            DrawMe()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub DragShortCut(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles FileList.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None
            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub DropShortCut(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles FileList.DragDrop

        Dim s() As String

        Try
            s = e.Data.GetData(DataFormats.FileDrop, False)

            For i = 0 To s.Length - 1
                Domain.ShortcutHandler.Add(s(i), FavoritesDirectory)
            Next i

        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el acceso directo" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")

        End Try

    End Sub

    Private Sub FavoritesWatcherEvent(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs)
        If FileList.InvokeRequired Then
            Dim IFillList As New FillListCallback(AddressOf FillList)
            Me.Invoke(IFillList)
        Else
            FillList()
        End If
    End Sub

    Delegate Sub FillListCallback()

    Private Sub FillList()

        Dim FileInfo As IO.FileInfo
        Dim NewIcon As Integer

        Try

            FIList.Images.Clear()

            FIList.Images.Add(My.Resources.Favorites)

            FileList.Items.Clear()

        Catch ex As Exception
            ex = Nothing
        End Try

        For Each File As String In IO.Directory.GetFiles(FavoritesDirectory)
            Try
                FileInfo = New IO.FileInfo(File)
                NewIcon = AddIcon(FileInfo.ToString)
                FileList.Items.Add(Domain.ShortcutHandler.DisplayName(FileInfo), NewIcon)
            Catch ex As Exception
                ex = Nothing
            End Try

        Next

    End Sub

    Private Function AddIcon(ByVal Name As String) As Integer

        Dim Icon As System.Drawing.Icon

        Try

            Icon = Domain.ShortcutHandler.GetIcon(Name)

            If Icon IsNot Nothing Then
                FIList.Images.Add(Icon)
                Return FIList.Images.Count - 1
            Else
                Return 0
            End If

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub FileList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FileList.KeyDown

        Try

            If FileList.SelectedItems Is Nothing Then Exit Sub
            If FileList.SelectedItems.Count = 0 Then Exit Sub

            Select Case e.KeyCode
                Case Keys.Delete
                    For Each file As ListViewItem In FileList.SelectedItems
                        Try
                            Domain.ShortcutHandler.Delete(file.Text, FavoritesDirectory)
                        Catch ex As Exception
                            MsgBox("Ocurrio un error al eliminar el acceso directo a " & file.Text & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
                            ex = Nothing
                        End Try
                    Next

                Case Keys.Enter
                    For Each file As ListViewItem In FileList.SelectedItems
                        Try
                            Domain.ShortcutHandler.Execute(file.Text, FavoritesDirectory)
                        Catch ex As Exception
                            MsgBox("Ocurrio un error al intentar acceder a " & file.Text & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
                            ex = Nothing
                        End Try
                    Next

            End Select
        Catch ex As Exception
            MsgBox("Ocurrio un error al procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub FileList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FileList.MouseDoubleClick
        Try

            If FileList.SelectedItems Is Nothing Then Exit Sub
            If FileList.SelectedItems.Count = 0 Then Exit Sub

            For Each file As ListViewItem In FileList.SelectedItems
                Try
                    Domain.ShortcutHandler.Execute(file.Text, FavoritesDirectory)
                Catch ex As Exception
                    MsgBox("Ocurrio un error al intentar acceder a " & file.Text & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
                    ex = Nothing
                End Try
            Next

        Catch ex As Exception
            MsgBox("Ocurrio un error al procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")

        End Try
    End Sub

    Private Sub ChangeCompany(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            Domain.MainCompany = Domain.CompanyRepository.GetById(CInt(sender.tag))

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try


    End Sub

    Private Sub MainMenuFileChangeCompany_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainMenuFileChangeCompany.DropDownOpening
        Dim CompanyMenu As ToolStripMenuItem

        Try
            MainMenuFileChangeCompany.DropDownItems.Clear()

            For Each company As Domain.Company In Domain.CompanyRepository.GetByUser(Domain.SystemUser.Id)

                CompanyMenu = MainMenuFileChangeCompany.DropDownItems.Add(company.Name, Nothing, AddressOf ChangeCompany)
                CompanyMenu.Tag = company.Id

                If CompanyMenu.Text = Domain.MainCompany.Name Then CompanyMenu.Enabled = False


            Next

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub






    Private Sub OpenFormByKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MainTree.KeyDown

        Dim Node As TreeNode

        Try
            If e.KeyCode <> Keys.Enter Then Exit Try

            Node = MainTree.SelectedNode

            If Node Is Nothing Then Exit Try

            OpenOption(Node.Tag)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub OpenFormByMouse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles MainTree.NodeMouseDoubleClick
        Try

            OpenOption(e.Node.Tag)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub OpenOption(ByVal Tag As String)

        Try
            Select Case Tag

                Case 123 : ShowCustomersDeletedToConfirm()

                Case 111111 : ShowPotentialCustomers()

                Case 111112 : ShowPotentialContacts()

                Case 111121 : ShowRealCustomers()

                Case 111122 : ShowRealContacts()

                Case 11011 : ShowContactsAreas()

                Case 11012 : ShowContactsCargos()

                Case 1102 : ShowCancelReassons()

                Case 1211 : ProcessCustomersToTango()

                Case 1221 : DeleteCustomer(False)

                Case 1212 : DeleteCustomer(True)

                Case 21011 : ShowTaskTypes()

                Case 21012 : ShowTaskPriorities()

                Case 21021 : ShowEventTypes()

                Case 2111 : ShowTasks()

                Case 2112 : AddAlert()

                Case 2113 : ShowAllAlerts()

                    'Case 12 : ShowReport()

                Case 121 : ShowPotentialCustomersEntry()

                Case 122 : ShowCustomersToTango()

                Case 124 : ShowCustomersDeleted()

                Case 125 : ShowCustomersList()

                Case 221 : ShowTaskSummary()

                Case 222 : ShowEventSummary()

                Case 223 : ShowTaskDetails()
            End Select


        Catch ex As Exception
            Throw ex
        End Try
    End Sub






    Private WithEvents frmAreas As frmTypes
    Private WithEvents frmCargos As frmTypes
    Private WithEvents frmReassons As frmTypes
    Private WithEvents frmCustomers As frmCustomer
    Private WithEvents frmSearchRealCustomer As frmSearch
    Private WithEvents frmSearchPotentialCustomer As frmSearch
    Private WithEvents frmContacts As frmContact
    Private WithEvents frmTasks As frmTask
    Private WithEvents frmTaskTypes As frmTypes
    Private WithEvents frmTaskPriorities As frmTypes
    Private WithEvents frmEventTypes As frmTypes



    Private Sub ShowRealCustomers()
        Try

            frmCustomers = New frmCustomer(False)
            frmCustomers.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowRealContacts()
        Try
            CustomerContactCode = SearchRealCustomer()

            If CustomerContactCode = "" Then Exit Sub

            frmContacts = New frmContact("Contactos del cliente " & CustomerContactCode, Domain.ContactRepository.GetByCustomer(CustomerContactCode), CustomerContactCode, True)
            frmContacts.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowPotentialCustomers()
        Try
            frmCustomers = New frmCustomer(True)
            frmCustomers.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowPotentialContacts()
        Try
            CustomerContactCode = SearchPotentialCustomer()

            If CustomerContactCode = "" Then Exit Sub

            frmContacts = New frmContact("Contactos del cliente " & CustomerContactCode, Domain.ContactRepository.GetByCustomer(CustomerContactCode), CustomerContactCode, True)
            frmContacts.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowContactsAreas()
        Try

            frmAreas = New frmTypes("AREAS DE CONTACTOS", Domain.ContactRepository.GetTableAreas())
            frmAreas.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowCancelReassons()
        Try

            frmReassons = New frmTypes("MOTIVOS DE BAJA", Domain.CustomerRepository.GetTableCancelReassons())
            frmReassons.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub ShowContactsCargos()
        Try

            frmCargos = New frmTypes("CARGOS DE CONTACTOS", Domain.ContactRepository.GetTableCargos())
            frmCargos.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmAreas_CodeChanged(ByVal Code As Integer) Handles frmAreas.CodeChanged

        Try
            If Domain.ContactRepository.GetCargoById(Code) Is Nothing Then
                frmAreas.CodeValid = 1
            Else
                frmAreas.CodeValid = -1
            End If

        Catch ex As Exception
            frmAreas.CodeValid = -1
        End Try
    End Sub

    Private Sub frmAreas_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmAreas.SourceChanged

        Try
            Domain.ContactRepository.SaveArea(Code, Name, Description, Otherdetails)

            frmAreas.DataSource = Domain.ContactRepository.GetTableAreas()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmCargos_CodeChanged(ByVal Code As Integer) Handles frmCargos.CodeChanged

        Try
            If Domain.ContactRepository.GetCargoById(Code) Is Nothing Then
                frmCargos.CodeValid = 1
            Else
                frmCargos.CodeValid = -1
            End If

        Catch ex As Exception
            frmCargos.CodeValid = -1
        End Try
    End Sub

    Private Sub frmCargos_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmCargos.SourceChanged

        Try
            Domain.ContactRepository.SaveCargo(Code, Name, Description, Otherdetails)

            frmCargos.DataSource = Domain.ContactRepository.GetTableCargos()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmReassons_CodeChanged(ByVal Code As Integer) Handles frmReassons.CodeChanged

        Try
            If Domain.CustomerRepository.GetCancelReassonById(Code) Is Nothing Then
                frmReassons.CodeValid = 1
            Else
                frmReassons.CodeValid = -1
            End If

        Catch ex As Exception
            frmReassons.CodeValid = -1
        End Try
    End Sub

    Private Sub frmReassons_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmReassons.SourceChanged

        Try
            Domain.CustomerRepository.SaveCancelReasson(Code, Name, Description, Otherdetails)

            frmReassons.DataSource = Domain.CustomerRepository.GetTableCancelReassons()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Function SearchRealCustomer() As String

        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(False, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmSearchRealCustomer = New frmSearch("CLIENTES", Customers, "")
            frmSearchRealCustomer.ShowDialog()

            If frmSearchRealCustomer.SelectedValue IsNot Nothing Then Return frmSearchRealCustomer.SelectedValue

            Return ""

        Catch ex As Exception
            frmError.ShowException(ex)
            Return ""
        End Try
    End Function

    Private Sub frmSearchRealCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSearchRealCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(False, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmSearchRealCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Function SearchPotentialCustomer() As String

        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(True, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmSearchPotentialCustomer = New frmSearch("CLIENTES POTENCIALES", Customers, "")
            frmSearchPotentialCustomer.ShowDialog()

            If frmSearchPotentialCustomer.SelectedValue IsNot Nothing Then Return frmSearchPotentialCustomer.SelectedValue

            Return ""

        Catch ex As Exception
            frmError.ShowException(ex)
            Return ""
        End Try
    End Function

    Private Sub frmSearchPotentialCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSearchPotentialCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(True, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmSearchPotentialCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub frmContacts_SourceChanged(ByVal CustomerCode As String) Handles frmContacts.SourceChanged
        Try
            frmContacts.ListDataSource = Domain.ContactRepository.GetByCustomer(CustomerCode)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub ShowTask()
        Try

            frmTasks = New frmTask(CInt(TasksLists.SelectedItems(0).Tag))
            frmTasks.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowTasks()
        Try

            frmTasks = New frmTask(Domain.TaskRepository.GetCodes(Domain.SystemUser.Id))
            frmTasks.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowTaskTypes()
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



    Private Sub ShowTaskPriorities()
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

    Private Sub ShowEventTypes()
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


    Private Sub ShowPendingTasks()
        Dim Item As ListViewItem
        Dim Tasks As List(Of Domain.Task)
        Dim TaskGroup As ListViewGroup

        Dim MainCustomer As Domain.Customer

        Try

            TasksLists.Clear()

            TasksLists.View = View.SmallIcon

            Tasks = Domain.TaskRepository.GetPendingTask()

            If Tasks Is Nothing Then Exit Sub

            For Each Task As Domain.Task In Tasks

                If Task.Type Is Nothing Then Task.Type = New Domain.Task.TaskType
                If Task.Priority Is Nothing Then Task.Priority = New Domain.Task.TaskPriority

                If Task.Entities IsNot Nothing Then
                    If Task.Entities.Count > 0 Then
                        If Task.Entities(0).Type.Id = 1 Then
                            MainCustomer = Domain.CustomerRepository.GetByCode(Task.Entities(0).Code, False)
                            If MainCustomer IsNot Nothing Then
                                Item = TasksLists.Items.Add(Task.Type.Name & " - " & MainCustomer.LegalName, 0)
                            Else
                                Item = TasksLists.Items.Add(Task.Type.Name, 0)
                            End If
                        ElseIf Task.Entities(0).Type.Id = 4 Then
                            MainCustomer = Domain.CustomerRepository.GetByCode(Task.Entities(0).Code, True)
                            If MainCustomer IsNot Nothing Then
                                Item = TasksLists.Items.Add(Task.Type.Name & " - " & MainCustomer.LegalName, 0)
                            Else
                                Item = TasksLists.Items.Add(Task.Type.Name, 0)
                            End If
                        Else
                            Item = TasksLists.Items.Add(Task.Type.Name, 0)
                        End If
                    Else
                        Item = TasksLists.Items.Add(Task.Type.Name, 0)
                    End If
                Else
                    Item = TasksLists.Items.Add(Task.Type.Name, 0)
                End If
                Item.SubItems.Add(CStr(Task.Id))
                Item.SubItems.Add(Task.Priority.Name)
                Item.SubItems.Add(Format(Task.Initdate, "dd/MM/yyyy"))
                Item.SubItems.Add(Format(Task.Initdate, "hh:mm"))

                If DateDiff(DateInterval.Day, Task.Initdate, Now) > 0 Then
                    If Task.Firstdate = "01/01/1800" Then
                        Item.ForeColor = Color.Red
                    Else
                        Item.ForeColor = Color.Orange
                    End If
                Else
                    Item.ForeColor = Color.Green
                End If

                TaskGroup = TasksLists.Groups(CStr(Format(Task.Initdate, "dd/MM/yyyy")))

                If TaskGroup Is Nothing Then TasksLists.Groups.Add(New ListViewGroup(CStr(Format(Task.Initdate, "dd/MM/yyyy")), CStr(Format(Task.Initdate, "dd/MM/yyyy"))))

                Item.Group = TasksLists.Groups(CStr(Format(Task.Initdate, "dd/MM/yyyy")))

                Item.Tag = CStr(Task.Id)

            Next


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TasksLists_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TasksLists.KeyDown
        Try

            If TasksLists.SelectedItems Is Nothing Then Exit Sub

            If TasksLists.SelectedItems(0) Is Nothing Then Exit Sub

            If e.KeyCode = Keys.Enter Then ShowTask()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub TasksLists_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TasksLists.MouseDoubleClick
        Try

            If TasksLists.SelectedItems Is Nothing Then Exit Sub

            If TasksLists.SelectedItems(0) Is Nothing Then Exit Sub

            ShowTask()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowAlerts()
        Dim Alerts As List(Of Domain.Alert)
        Dim frm As frmAlert
        Try

            Alerts = Domain.AlertRepository.GetAlerts(Domain.SystemUser.Id, Domain.SystemUser.Profile.Id)

            If Alerts Is Nothing Then Exit Sub

            For Each Alert As Domain.Alert In Alerts

                If Application.OpenForms("Alert" & Alert.Id) Is Nothing Then
                    frm = New frmAlert(Alert)
                    frm.Name = "Alert" & Alert.Id
                    frm.Show()
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmTasks_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles frmTasks.FormClosed
        Try

            ShowPendingTasks()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ProcessCustomersToTango()
        Dim frm As frmCustomersToTango
        Try

            frm = New frmCustomersToTango()
            frm.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub AddAlert()
        Dim frm As frmEditionAlert
        Try

            frm = New frmEditionAlert
            frm.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub ShowAllAlerts()
        Dim frm As frmAlerts
        Try
            frm = New frmAlerts()
            frm.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DeleteCustomer(ByVal PotentialCustomer As Boolean)
        Dim frm As frmDeleteCustomer
        Try

            frm = New frmDeleteCustomer(PotentialCustomer)
            frm.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowCustomersDeletedToConfirm()
        Dim frm As frmCustomersDeleted
        Try

            frm = New frmCustomersDeleted
            frm.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub


    Private Sub ShowReport()
        Dim frm As frmParametersTaskSummary

        frm = New frmParametersTaskSummary

        frm.Show()

    End Sub

    Private Sub ShowPotentialCustomersEntry()
        Dim frm As frmParametersPotentialCustomersEntry

        frm = New frmParametersPotentialCustomersEntry

        frm.Show()

    End Sub

    Private Sub ShowCustomersToTango()
        Dim frm As frmParametersPotentialToTango

        frm = New frmParametersPotentialToTango

        frm.Show()

    End Sub

    Private Sub ShowCustomersDeleted()

        Dim frm As frmParametersCustomersDeleted

        frm = New frmParametersCustomersDeleted

        frm.Show()

    End Sub

    Private Sub ShowCustomersList()

        Dim frm As frmParametersCustomersList

        frm = New frmParametersCustomersList

        frm.Show()

    End Sub

    Private Sub ShowTaskSummary()

        Dim frm As frmParametersTaskSummary

        frm = New frmParametersTaskSummary
        frm.Show()

    End Sub

    Private Sub ShowEventSummary()

        Dim frm As frmParametersEventSummary

        frm = New frmParametersEventSummary
        frm.Show()

    End Sub

    Private Sub ShowTaskDetails()

        Dim frm As frmParametersTaskDetails

        frm = New frmParametersTaskDetails
        frm.Show()

    End Sub


    Private Sub MainTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles MainTree.AfterSelect

    End Sub
End Class
