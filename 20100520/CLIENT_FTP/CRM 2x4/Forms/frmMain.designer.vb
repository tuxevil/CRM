<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Pendientes", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Cumplidas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusBar = New System.Windows.Forms.StatusStrip
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCompany = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblKey = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.MainMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuFileNewWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuFileChangeCompany = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuFileSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MainMenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuView = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewModules = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewTasks = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewTitle = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewFavorites = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MainMenuViewTreeFont = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewToolBar = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewToolBarLargeIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewToolBarSmallIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuViewSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MainMenuViewReset = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuGoTo = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuGoToCustomers = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuGoToTasks = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuGoToTango = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuGoToTools = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolBar = New System.Windows.Forms.ToolStrip
        Me.btModules = New System.Windows.Forms.ToolStripButton
        Me.btTasks = New System.Windows.Forms.ToolStripButton
        Me.btFavorites = New System.Windows.Forms.ToolStripButton
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblMainTitle = New System.Windows.Forms.Label
        Me.pnlModules = New System.Windows.Forms.Panel
        Me.RecentList = New System.Windows.Forms.ListBox
        Me.RecentsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecentsMenuClear = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitRecents = New System.Windows.Forms.Splitter
        Me.lblRecent = New System.Windows.Forms.Label
        Me.tsModules = New System.Windows.Forms.ToolStrip
        Me.SCCustomers = New System.Windows.Forms.ToolStripButton
        Me.SCTasks = New System.Windows.Forms.ToolStripButton
        Me.SCTango = New System.Windows.Forms.ToolStripButton
        Me.SCTools = New System.Windows.Forms.ToolStripButton
        Me.pnlTasks = New System.Windows.Forms.Panel
        Me.TasksLists = New System.Windows.Forms.ListView
        Me.TaskType = New System.Windows.Forms.ColumnHeader
        Me.TaskId = New System.Windows.Forms.ColumnHeader
        Me.TaskPriority = New System.Windows.Forms.ColumnHeader
        Me.TaskInitDate = New System.Windows.Forms.ColumnHeader
        Me.TaskInitTime = New System.Windows.Forms.ColumnHeader
        Me.IList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTasks = New System.Windows.Forms.Label
        Me.FIList = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitModules = New System.Windows.Forms.Splitter
        Me.SplitTasks = New System.Windows.Forms.Splitter
        Me.pnlFavorites = New System.Windows.Forms.Panel
        Me.FileList = New System.Windows.Forms.ListView
        Me.lblFavorites = New System.Windows.Forms.Label
        Me.SplitFavorites = New System.Windows.Forms.Splitter
        Me.pnlTree = New System.Windows.Forms.Panel
        Me.MainTree = New System.Windows.Forms.TreeView
        Me.lblModule = New System.Windows.Forms.Label
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.AlertTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshTimers = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.ToolBar.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlModules.SuspendLayout()
        Me.RecentsMenu.SuspendLayout()
        Me.tsModules.SuspendLayout()
        Me.pnlTasks.SuspendLayout()
        Me.pnlFavorites.SuspendLayout()
        Me.pnlTree.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar
        '
        Me.StatusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.lblCompany, Me.lblKey, Me.lblVersion})
        Me.StatusBar.Location = New System.Drawing.Point(0, 493)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1072, 22)
        Me.StatusBar.TabIndex = 0
        Me.StatusBar.Text = "Barra de estado"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = False
        Me.lblUser.AutoToolTip = True
        Me.lblUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUser.Image = Global.Crm.UI.My.Resources.Resources.UserInfo
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(66, 17)
        Me.lblUser.Text = "Usuario: "
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUser.ToolTipText = "Usuario:"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = False
        Me.lblCompany.AutoToolTip = True
        Me.lblCompany.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblCompany.Image = Global.Crm.UI.My.Resources.Resources.Company
        Me.lblCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(71, 17)
        Me.lblCompany.Text = "Empresa: "
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKey
        '
        Me.lblKey.AutoSize = False
        Me.lblKey.AutoToolTip = True
        Me.lblKey.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblKey.Image = Global.Crm.UI.My.Resources.Resources.Key
        Me.lblKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(52, 17)
        Me.lblKey.Text = "Llave:"
        Me.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = False
        Me.lblVersion.AutoToolTip = True
        Me.lblVersion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblVersion.Image = Global.Crm.UI.My.Resources.Resources.Info
        Me.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(62, 17)
        Me.lblVersion.Text = "Versión:"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuFile, Me.MainMenuView, Me.MainMenuGoTo})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1072, 24)
        Me.MainMenu.TabIndex = 3
        Me.MainMenu.Text = "Menú principal"
        '
        'MainMenuFile
        '
        Me.MainMenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuFileNewWindow, Me.MainMenuFileChangeCompany, Me.MainMenuFileSeparator1, Me.MainMenuFileExit})
        Me.MainMenuFile.Name = "MainMenuFile"
        Me.MainMenuFile.Size = New System.Drawing.Size(55, 20)
        Me.MainMenuFile.Text = "Archivo"
        '
        'MainMenuFileNewWindow
        '
        Me.MainMenuFileNewWindow.Name = "MainMenuFileNewWindow"
        Me.MainMenuFileNewWindow.Size = New System.Drawing.Size(168, 22)
        Me.MainMenuFileNewWindow.Text = "Nuevo menu"
        '
        'MainMenuFileChangeCompany
        '
        Me.MainMenuFileChangeCompany.Name = "MainMenuFileChangeCompany"
        Me.MainMenuFileChangeCompany.Size = New System.Drawing.Size(168, 22)
        Me.MainMenuFileChangeCompany.Text = "Cambiar empresa"
        '
        'MainMenuFileSeparator1
        '
        Me.MainMenuFileSeparator1.Name = "MainMenuFileSeparator1"
        Me.MainMenuFileSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'MainMenuFileExit
        '
        Me.MainMenuFileExit.Name = "MainMenuFileExit"
        Me.MainMenuFileExit.Size = New System.Drawing.Size(168, 22)
        Me.MainMenuFileExit.Text = "Salir"
        '
        'MainMenuView
        '
        Me.MainMenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuViewModules, Me.MainMenuViewTasks, Me.MainMenuViewTitle, Me.MainMenuViewFavorites, Me.MainMenuViewSeparator1, Me.MainMenuViewTreeFont, Me.MainMenuViewToolBar, Me.MainMenuViewSeparator2, Me.MainMenuViewReset})
        Me.MainMenuView.Name = "MainMenuView"
        Me.MainMenuView.Size = New System.Drawing.Size(35, 20)
        Me.MainMenuView.Text = "Ver"
        '
        'MainMenuViewModules
        '
        Me.MainMenuViewModules.Checked = True
        Me.MainMenuViewModules.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainMenuViewModules.Name = "MainMenuViewModules"
        Me.MainMenuViewModules.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewModules.Text = "Modulos"
        '
        'MainMenuViewTasks
        '
        Me.MainMenuViewTasks.Checked = True
        Me.MainMenuViewTasks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainMenuViewTasks.Name = "MainMenuViewTasks"
        Me.MainMenuViewTasks.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewTasks.Text = "Tareas"
        '
        'MainMenuViewTitle
        '
        Me.MainMenuViewTitle.Checked = True
        Me.MainMenuViewTitle.CheckOnClick = True
        Me.MainMenuViewTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainMenuViewTitle.Name = "MainMenuViewTitle"
        Me.MainMenuViewTitle.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewTitle.Text = "Panel de titulo"
        '
        'MainMenuViewFavorites
        '
        Me.MainMenuViewFavorites.Checked = True
        Me.MainMenuViewFavorites.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainMenuViewFavorites.Name = "MainMenuViewFavorites"
        Me.MainMenuViewFavorites.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewFavorites.Text = "Favoritos"
        '
        'MainMenuViewSeparator1
        '
        Me.MainMenuViewSeparator1.Name = "MainMenuViewSeparator1"
        Me.MainMenuViewSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'MainMenuViewTreeFont
        '
        Me.MainMenuViewTreeFont.Name = "MainMenuViewTreeFont"
        Me.MainMenuViewTreeFont.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewTreeFont.Text = "Fuente"
        '
        'MainMenuViewToolBar
        '
        Me.MainMenuViewToolBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuViewToolBarLargeIcons, Me.MainMenuViewToolBarSmallIcons})
        Me.MainMenuViewToolBar.Name = "MainMenuViewToolBar"
        Me.MainMenuViewToolBar.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewToolBar.Text = "Barra de herramientas"
        '
        'MainMenuViewToolBarLargeIcons
        '
        Me.MainMenuViewToolBarLargeIcons.Name = "MainMenuViewToolBarLargeIcons"
        Me.MainMenuViewToolBarLargeIcons.Size = New System.Drawing.Size(167, 22)
        Me.MainMenuViewToolBarLargeIcons.Text = "Iconos grandes"
        '
        'MainMenuViewToolBarSmallIcons
        '
        Me.MainMenuViewToolBarSmallIcons.Checked = True
        Me.MainMenuViewToolBarSmallIcons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainMenuViewToolBarSmallIcons.Name = "MainMenuViewToolBarSmallIcons"
        Me.MainMenuViewToolBarSmallIcons.Size = New System.Drawing.Size(167, 22)
        Me.MainMenuViewToolBarSmallIcons.Text = "Iconos pequeños"
        '
        'MainMenuViewSeparator2
        '
        Me.MainMenuViewSeparator2.Name = "MainMenuViewSeparator2"
        Me.MainMenuViewSeparator2.Size = New System.Drawing.Size(189, 6)
        '
        'MainMenuViewReset
        '
        Me.MainMenuViewReset.Name = "MainMenuViewReset"
        Me.MainMenuViewReset.Size = New System.Drawing.Size(192, 22)
        Me.MainMenuViewReset.Text = "Restablecer vista"
        '
        'MainMenuGoTo
        '
        Me.MainMenuGoTo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuGoToCustomers, Me.MainMenuGoToTasks, Me.MainMenuGoToTango, Me.MainMenuGoToTools})
        Me.MainMenuGoTo.Name = "MainMenuGoTo"
        Me.MainMenuGoTo.Size = New System.Drawing.Size(36, 20)
        Me.MainMenuGoTo.Text = "Ir a"
        '
        'MainMenuGoToCustomers
        '
        Me.MainMenuGoToCustomers.Image = Global.Crm.UI.My.Resources.Resources.Customer
        Me.MainMenuGoToCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainMenuGoToCustomers.Name = "MainMenuGoToCustomers"
        Me.MainMenuGoToCustomers.Size = New System.Drawing.Size(154, 22)
        Me.MainMenuGoToCustomers.Text = "Clientes"
        '
        'MainMenuGoToTasks
        '
        Me.MainMenuGoToTasks.Image = Global.Crm.UI.My.Resources.Resources.Task
        Me.MainMenuGoToTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainMenuGoToTasks.Name = "MainMenuGoToTasks"
        Me.MainMenuGoToTasks.Size = New System.Drawing.Size(154, 22)
        Me.MainMenuGoToTasks.Text = "Tareas"
        '
        'MainMenuGoToTango
        '
        Me.MainMenuGoToTango.Image = Global.Crm.UI.My.Resources.Resources.Tango
        Me.MainMenuGoToTango.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainMenuGoToTango.Name = "MainMenuGoToTango"
        Me.MainMenuGoToTango.Size = New System.Drawing.Size(154, 22)
        Me.MainMenuGoToTango.Text = "Tango Gestión"
        '
        'MainMenuGoToTools
        '
        Me.MainMenuGoToTools.Image = Global.Crm.UI.My.Resources.Resources.Tool
        Me.MainMenuGoToTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainMenuGoToTools.Name = "MainMenuGoToTools"
        Me.MainMenuGoToTools.Size = New System.Drawing.Size(154, 22)
        Me.MainMenuGoToTools.Text = "Herramientas"
        '
        'ToolBar
        '
        Me.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btModules, Me.btTasks, Me.btFavorites})
        Me.ToolBar.Location = New System.Drawing.Point(0, 24)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(1072, 36)
        Me.ToolBar.TabIndex = 9
        Me.ToolBar.Text = "ToolStrip2"
        '
        'btModules
        '
        Me.btModules.Checked = True
        Me.btModules.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btModules.Image = Global.Crm.UI.My.Resources.Resources.Modules
        Me.btModules.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btModules.Name = "btModules"
        Me.btModules.Size = New System.Drawing.Size(50, 33)
        Me.btModules.Text = "Modulos"
        Me.btModules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btTasks
        '
        Me.btTasks.Checked = True
        Me.btTasks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btTasks.Image = Global.Crm.UI.My.Resources.Resources.Tasks
        Me.btTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btTasks.Name = "btTasks"
        Me.btTasks.Size = New System.Drawing.Size(44, 33)
        Me.btTasks.Text = "Tareas"
        Me.btTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btFavorites
        '
        Me.btFavorites.Checked = True
        Me.btFavorites.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btFavorites.Image = Global.Crm.UI.My.Resources.Resources.Favorites
        Me.btFavorites.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFavorites.Name = "btFavorites"
        Me.btFavorites.Size = New System.Drawing.Size(56, 33)
        Me.btFavorites.Text = "Favoritos"
        Me.btFavorites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlTitle.Controls.Add(Me.lblMainTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 60)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1072, 50)
        Me.pnlTitle.TabIndex = 13
        '
        'lblMainTitle
        '
        Me.lblMainTitle.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblMainTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMainTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.Color.White
        Me.lblMainTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(1072, 50)
        Me.lblMainTitle.TabIndex = 0
        Me.lblMainTitle.Text = "CRM - D'ACCORD"
        Me.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlModules
        '
        Me.pnlModules.BackColor = System.Drawing.SystemColors.Window
        Me.pnlModules.Controls.Add(Me.RecentList)
        Me.pnlModules.Controls.Add(Me.SplitRecents)
        Me.pnlModules.Controls.Add(Me.lblRecent)
        Me.pnlModules.Controls.Add(Me.tsModules)
        Me.pnlModules.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlModules.Location = New System.Drawing.Point(0, 110)
        Me.pnlModules.Name = "pnlModules"
        Me.pnlModules.Size = New System.Drawing.Size(176, 383)
        Me.pnlModules.TabIndex = 14
        '
        'RecentList
        '
        Me.RecentList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecentList.ContextMenuStrip = Me.RecentsMenu
        Me.RecentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecentList.FormattingEnabled = True
        Me.RecentList.Location = New System.Drawing.Point(0, 23)
        Me.RecentList.Name = "RecentList"
        Me.RecentList.Size = New System.Drawing.Size(176, 195)
        Me.RecentList.TabIndex = 10
        '
        'RecentsMenu
        '
        Me.RecentsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecentsMenuClear})
        Me.RecentsMenu.Name = "RecentsMenu"
        Me.RecentsMenu.Size = New System.Drawing.Size(163, 26)
        '
        'RecentsMenuClear
        '
        Me.RecentsMenuClear.Name = "RecentsMenuClear"
        Me.RecentsMenuClear.Size = New System.Drawing.Size(162, 22)
        Me.RecentsMenuClear.Text = "Borrar recientes"
        '
        'SplitRecents
        '
        Me.SplitRecents.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitRecents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitRecents.Location = New System.Drawing.Point(0, 228)
        Me.SplitRecents.Name = "SplitRecents"
        Me.SplitRecents.Size = New System.Drawing.Size(176, 3)
        Me.SplitRecents.TabIndex = 8
        Me.SplitRecents.TabStop = False
        '
        'lblRecent
        '
        Me.lblRecent.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRecent.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRecent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.ForeColor = System.Drawing.Color.White
        Me.lblRecent.Location = New System.Drawing.Point(0, 0)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(176, 23)
        Me.lblRecent.TabIndex = 7
        Me.lblRecent.Text = "Recientes"
        Me.lblRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRecent.Visible = False
        '
        'tsModules
        '
        Me.tsModules.AutoSize = False
        Me.tsModules.BackColor = System.Drawing.SystemColors.Control
        Me.tsModules.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsModules.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsModules.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SCCustomers, Me.SCTasks, Me.SCTango, Me.SCTools})
        Me.tsModules.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsModules.Location = New System.Drawing.Point(0, 231)
        Me.tsModules.Name = "tsModules"
        Me.tsModules.Size = New System.Drawing.Size(176, 152)
        Me.tsModules.TabIndex = 1
        Me.tsModules.Text = "Modulos"
        '
        'SCCustomers
        '
        Me.SCCustomers.BackColor = System.Drawing.SystemColors.Control
        Me.SCCustomers.Checked = True
        Me.SCCustomers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SCCustomers.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCCustomers.Image = Global.Crm.UI.My.Resources.Resources.Customer
        Me.SCCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SCCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SCCustomers.Name = "SCCustomers"
        Me.SCCustomers.Size = New System.Drawing.Size(174, 23)
        Me.SCCustomers.Text = "Clientes"
        Me.SCCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SCTasks
        '
        Me.SCTasks.BackColor = System.Drawing.SystemColors.Control
        Me.SCTasks.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCTasks.Image = Global.Crm.UI.My.Resources.Resources.Task
        Me.SCTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SCTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SCTasks.Name = "SCTasks"
        Me.SCTasks.Size = New System.Drawing.Size(174, 23)
        Me.SCTasks.Text = "Tareas"
        '
        'SCTango
        '
        Me.SCTango.BackColor = System.Drawing.SystemColors.Control
        Me.SCTango.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCTango.Image = Global.Crm.UI.My.Resources.Resources.Tango
        Me.SCTango.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SCTango.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SCTango.Name = "SCTango"
        Me.SCTango.Size = New System.Drawing.Size(174, 23)
        Me.SCTango.Text = "Tango Gestión"
        '
        'SCTools
        '
        Me.SCTools.BackColor = System.Drawing.SystemColors.Control
        Me.SCTools.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCTools.Image = Global.Crm.UI.My.Resources.Resources.Tool
        Me.SCTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SCTools.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SCTools.Name = "SCTools"
        Me.SCTools.Size = New System.Drawing.Size(174, 23)
        Me.SCTools.Text = "Herramientas"
        '
        'pnlTasks
        '
        Me.pnlTasks.Controls.Add(Me.TasksLists)
        Me.pnlTasks.Controls.Add(Me.lblTasks)
        Me.pnlTasks.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTasks.Location = New System.Drawing.Point(872, 110)
        Me.pnlTasks.Name = "pnlTasks"
        Me.pnlTasks.Size = New System.Drawing.Size(200, 383)
        Me.pnlTasks.TabIndex = 15
        '
        'TasksLists
        '
        Me.TasksLists.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TaskType, Me.TaskId, Me.TaskPriority, Me.TaskInitDate, Me.TaskInitTime})
        Me.TasksLists.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Pendientes"
        ListViewGroup1.Name = "PendingTasks"
        ListViewGroup2.Header = "Cumplidas"
        ListViewGroup2.Name = "DoneTasks"
        Me.TasksLists.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.TasksLists.HideSelection = False
        Me.TasksLists.Location = New System.Drawing.Point(0, 23)
        Me.TasksLists.Name = "TasksLists"
        Me.TasksLists.Size = New System.Drawing.Size(200, 360)
        Me.TasksLists.SmallImageList = Me.IList
        Me.TasksLists.TabIndex = 9
        Me.TasksLists.UseCompatibleStateImageBehavior = False
        Me.TasksLists.View = System.Windows.Forms.View.SmallIcon
        '
        'TaskType
        '
        Me.TaskType.DisplayIndex = 1
        Me.TaskType.Text = "Tipo"
        '
        'TaskId
        '
        Me.TaskId.DisplayIndex = 0
        Me.TaskId.Text = "Nro."
        Me.TaskId.Width = 0
        '
        'TaskPriority
        '
        Me.TaskPriority.Text = "Prioridad"
        '
        'TaskInitDate
        '
        Me.TaskInitDate.Text = "Fecha"
        '
        'TaskInitTime
        '
        Me.TaskInitTime.Text = "Hora"
        '
        'IList
        '
        Me.IList.ImageStream = CType(resources.GetObject("IList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IList.TransparentColor = System.Drawing.Color.Transparent
        Me.IList.Images.SetKeyName(0, "Task.png")
        '
        'lblTasks
        '
        Me.lblTasks.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTasks.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasks.ForeColor = System.Drawing.Color.White
        Me.lblTasks.Location = New System.Drawing.Point(0, 0)
        Me.lblTasks.Name = "lblTasks"
        Me.lblTasks.Size = New System.Drawing.Size(200, 23)
        Me.lblTasks.TabIndex = 10
        Me.lblTasks.Text = "Tareas"
        Me.lblTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FIList
        '
        Me.FIList.ImageStream = CType(resources.GetObject("FIList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FIList.TransparentColor = System.Drawing.Color.Transparent
        Me.FIList.Images.SetKeyName(0, "Favorite.ico")
        '
        'SplitModules
        '
        Me.SplitModules.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitModules.Location = New System.Drawing.Point(176, 110)
        Me.SplitModules.Name = "SplitModules"
        Me.SplitModules.Size = New System.Drawing.Size(3, 383)
        Me.SplitModules.TabIndex = 17
        Me.SplitModules.TabStop = False
        '
        'SplitTasks
        '
        Me.SplitTasks.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitTasks.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitTasks.Location = New System.Drawing.Point(869, 110)
        Me.SplitTasks.Name = "SplitTasks"
        Me.SplitTasks.Size = New System.Drawing.Size(3, 383)
        Me.SplitTasks.TabIndex = 18
        Me.SplitTasks.TabStop = False
        '
        'pnlFavorites
        '
        Me.pnlFavorites.Controls.Add(Me.FileList)
        Me.pnlFavorites.Controls.Add(Me.lblFavorites)
        Me.pnlFavorites.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFavorites.Location = New System.Drawing.Point(669, 110)
        Me.pnlFavorites.Name = "pnlFavorites"
        Me.pnlFavorites.Size = New System.Drawing.Size(200, 383)
        Me.pnlFavorites.TabIndex = 19
        '
        'FileList
        '
        Me.FileList.AllowDrop = True
        Me.FileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileList.HideSelection = False
        Me.FileList.LargeImageList = Me.FIList
        Me.FileList.Location = New System.Drawing.Point(0, 23)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(200, 360)
        Me.FileList.SmallImageList = Me.FIList
        Me.FileList.TabIndex = 1
        Me.FileList.UseCompatibleStateImageBehavior = False
        '
        'lblFavorites
        '
        Me.lblFavorites.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFavorites.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFavorites.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavorites.ForeColor = System.Drawing.Color.White
        Me.lblFavorites.Location = New System.Drawing.Point(0, 0)
        Me.lblFavorites.Name = "lblFavorites"
        Me.lblFavorites.Size = New System.Drawing.Size(200, 23)
        Me.lblFavorites.TabIndex = 8
        Me.lblFavorites.Text = "Favoritos"
        Me.lblFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitFavorites
        '
        Me.SplitFavorites.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitFavorites.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitFavorites.Location = New System.Drawing.Point(666, 110)
        Me.SplitFavorites.Name = "SplitFavorites"
        Me.SplitFavorites.Size = New System.Drawing.Size(3, 383)
        Me.SplitFavorites.TabIndex = 20
        Me.SplitFavorites.TabStop = False
        '
        'pnlTree
        '
        Me.pnlTree.Controls.Add(Me.MainTree)
        Me.pnlTree.Controls.Add(Me.lblModule)
        Me.pnlTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTree.Location = New System.Drawing.Point(179, 110)
        Me.pnlTree.Name = "pnlTree"
        Me.pnlTree.Size = New System.Drawing.Size(487, 383)
        Me.pnlTree.TabIndex = 23
        '
        'MainTree
        '
        Me.MainTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTree.HideSelection = False
        Me.MainTree.Location = New System.Drawing.Point(0, 23)
        Me.MainTree.Name = "MainTree"
        Me.MainTree.Size = New System.Drawing.Size(487, 360)
        Me.MainTree.TabIndex = 25
        '
        'lblModule
        '
        Me.lblModule.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblModule.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblModule.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModule.ForeColor = System.Drawing.Color.White
        Me.lblModule.Location = New System.Drawing.Point(0, 0)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(487, 23)
        Me.lblModule.TabIndex = 23
        Me.lblModule.Text = "Modulo:"
        Me.lblModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 515)
        Me.Controls.Add(Me.pnlTree)
        Me.Controls.Add(Me.SplitFavorites)
        Me.Controls.Add(Me.pnlFavorites)
        Me.Controls.Add(Me.SplitTasks)
        Me.Controls.Add(Me.SplitModules)
        Me.Controls.Add(Me.pnlTasks)
        Me.Controls.Add(Me.pnlModules)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.StatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRM - D'ACCORD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlModules.ResumeLayout(False)
        Me.RecentsMenu.ResumeLayout(False)
        Me.tsModules.ResumeLayout(False)
        Me.tsModules.PerformLayout()
        Me.pnlTasks.ResumeLayout(False)
        Me.pnlFavorites.ResumeLayout(False)
        Me.pnlTree.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MainMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuGoTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btModules As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenuViewModules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuViewTasks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btTasks As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenuViewSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainMenuViewToolBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuViewToolBarLargeIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuViewToolBarSmallIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents pnlModules As System.Windows.Forms.Panel
    Friend WithEvents lblRecent As System.Windows.Forms.Label
    Friend WithEvents pnlTasks As System.Windows.Forms.Panel
    Friend WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents MainMenuViewTitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecentsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RecentsMenuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuGoToCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuGoToTasks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuGoToTango As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuGoToTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuFileNewWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainMenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuViewSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainMenuViewReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuViewTreeFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FIList As System.Windows.Forms.ImageList
    Friend WithEvents TasksLists As System.Windows.Forms.ListView
    Friend WithEvents lblTasks As System.Windows.Forms.Label
    Friend WithEvents SplitModules As System.Windows.Forms.Splitter
    Friend WithEvents SplitTasks As System.Windows.Forms.Splitter
    Friend WithEvents pnlFavorites As System.Windows.Forms.Panel
    Friend WithEvents FileList As System.Windows.Forms.ListView
    Friend WithEvents lblFavorites As System.Windows.Forms.Label
    Friend WithEvents SplitFavorites As System.Windows.Forms.Splitter
    Friend WithEvents pnlTree As System.Windows.Forms.Panel
    Friend WithEvents MainTree As System.Windows.Forms.TreeView
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents btFavorites As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitRecents As System.Windows.Forms.Splitter
    Friend WithEvents tsModules As System.Windows.Forms.ToolStrip
    Friend WithEvents SCCustomers As System.Windows.Forms.ToolStripButton
    Friend WithEvents SCTasks As System.Windows.Forms.ToolStripButton
    Friend WithEvents SCTango As System.Windows.Forms.ToolStripButton
    Friend WithEvents SCTools As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenuViewFavorites As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCompany As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblKey As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RecentList As System.Windows.Forms.ListBox
    Friend WithEvents MainMenuFileChangeCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskId As System.Windows.Forms.ColumnHeader
    Friend WithEvents TaskType As System.Windows.Forms.ColumnHeader
    Friend WithEvents TaskPriority As System.Windows.Forms.ColumnHeader
    Friend WithEvents TaskInitDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents TaskInitTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents IList As System.Windows.Forms.ImageList
    Friend WithEvents AlertTimer As System.Windows.Forms.Timer
    Friend WithEvents RefreshTimers As System.Windows.Forms.Timer

End Class
