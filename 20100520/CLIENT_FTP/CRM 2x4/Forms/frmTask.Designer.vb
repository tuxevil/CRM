<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTask
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTask))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BrowserSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserDelete = New System.Windows.Forms.ToolStripButton
        Me.BrowserAdd = New System.Windows.Forms.ToolStripButton
        Me.BrowserCancel = New System.Windows.Forms.ToolStripButton
        Me.BrowserFirst = New System.Windows.Forms.ToolStripButton
        Me.BrowserPrevious = New System.Windows.Forms.ToolStripButton
        Me.BrowserNext = New System.Windows.Forms.ToolStripButton
        Me.BrowserList = New System.Windows.Forms.ToolStripButton
        Me.BrowserSearch = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserLast = New System.Windows.Forms.ToolStripButton
        Me.BrowserAccept = New System.Windows.Forms.ToolStripButton
        Me.BrowserMenuViewSmallIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowserMenuViewLargeIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowserMenuView = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowserMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Browser = New System.Windows.Forms.ToolStrip
        Me.MenuFileAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.MenuEdition = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionTypes = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionPriorities = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionEventTypes = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuAction = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionAddEvent = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionAddEntity = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionAddCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionAddCustomerReal = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionAddCustomerPotential = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionAddTask = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionCloseTask = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionCancelTask = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearch = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchByKey = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchPrevious = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchNext = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchFirst = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchLast = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTitle = New System.Windows.Forms.Label
        Me.frmSplit = New System.Windows.Forms.SplitContainer
        Me.tsTask = New System.Windows.Forms.ToolStrip
        Me.tbGeneral = New System.Windows.Forms.ToolStripButton
        Me.tbEntities = New System.Windows.Forms.ToolStripButton
        Me.tbEvents = New System.Windows.Forms.ToolStripButton
        Me.pnlEvents = New System.Windows.Forms.Panel
        Me.pnlGeneral = New System.Windows.Forms.Panel
        Me.txtPriority = New System.Windows.Forms.TextBox
        Me.lblPriority = New System.Windows.Forms.Label
        Me.GroupDates = New System.Windows.Forms.GroupBox
        Me.txtInitTime = New System.Windows.Forms.TextBox
        Me.txtFirstDate = New System.Windows.Forms.TextBox
        Me.lblFirstDate = New System.Windows.Forms.Label
        Me.txtInitDate = New System.Windows.Forms.TextBox
        Me.lblSystemDate = New System.Windows.Forms.Label
        Me.txtSystemDate = New System.Windows.Forms.TextBox
        Me.lblInitDate = New System.Windows.Forms.Label
        Me.txtLastDate = New System.Windows.Forms.TextBox
        Me.lblLastDate = New System.Windows.Forms.Label
        Me.GroupUser = New System.Windows.Forms.GroupBox
        Me.lblProfile = New System.Windows.Forms.Label
        Me.txtProfile = New System.Windows.Forms.TextBox
        Me.lblAdmin = New System.Windows.Forms.Label
        Me.txtAdmin = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblOwner = New System.Windows.Forms.Label
        Me.txtOwner = New System.Windows.Forms.TextBox
        Me.txtOwnerDetail = New System.Windows.Forms.TextBox
        Me.lblOwnerDetail = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.txtDetail = New System.Windows.Forms.TextBox
        Me.lblDetail = New System.Windows.Forms.Label
        Me.pnlEntities = New System.Windows.Forms.Panel
        Me.TaskentityMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TaskentityMenuRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.GridEvents = New Crm.UI.GridView
        Me.TaskEventDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskEventTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskEventType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskEventdetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GridEntities = New Crm.UI.GridView
        Me.EntitySystemType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntityType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntityCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BrowserMenu.SuspendLayout()
        Me.Browser.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.frmSplit.Panel1.SuspendLayout()
        Me.frmSplit.SuspendLayout()
        Me.tsTask.SuspendLayout()
        Me.pnlEvents.SuspendLayout()
        Me.pnlGeneral.SuspendLayout()
        Me.GroupDates.SuspendLayout()
        Me.GroupUser.SuspendLayout()
        Me.pnlEntities.SuspendLayout()
        Me.TaskentityMenu.SuspendLayout()
        CType(Me.GridEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEntities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BrowserSeparator1
        '
        Me.BrowserSeparator1.Name = "BrowserSeparator1"
        Me.BrowserSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BrowserDelete
        '
        Me.BrowserDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserDelete.Image = CType(resources.GetObject("BrowserDelete.Image"), System.Drawing.Image)
        Me.BrowserDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserDelete.Name = "BrowserDelete"
        Me.BrowserDelete.Size = New System.Drawing.Size(28, 28)
        Me.BrowserDelete.Text = "Eliminar registro"
        Me.BrowserDelete.Visible = False
        '
        'BrowserAdd
        '
        Me.BrowserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAdd.Image = CType(resources.GetObject("BrowserAdd.Image"), System.Drawing.Image)
        Me.BrowserAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAdd.Name = "BrowserAdd"
        Me.BrowserAdd.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAdd.Text = "Añadir registro"
        '
        'BrowserCancel
        '
        Me.BrowserCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserCancel.Image = CType(resources.GetObject("BrowserCancel.Image"), System.Drawing.Image)
        Me.BrowserCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserCancel.Name = "BrowserCancel"
        Me.BrowserCancel.Size = New System.Drawing.Size(28, 28)
        Me.BrowserCancel.Text = "Deshacer cambios"
        Me.BrowserCancel.Visible = False
        '
        'BrowserFirst
        '
        Me.BrowserFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserFirst.Image = CType(resources.GetObject("BrowserFirst.Image"), System.Drawing.Image)
        Me.BrowserFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserFirst.Name = "BrowserFirst"
        Me.BrowserFirst.Size = New System.Drawing.Size(28, 28)
        Me.BrowserFirst.Text = "Primer registro"
        '
        'BrowserPrevious
        '
        Me.BrowserPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserPrevious.Image = CType(resources.GetObject("BrowserPrevious.Image"), System.Drawing.Image)
        Me.BrowserPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserPrevious.Name = "BrowserPrevious"
        Me.BrowserPrevious.Size = New System.Drawing.Size(28, 28)
        Me.BrowserPrevious.Text = "Registro anterior"
        '
        'BrowserNext
        '
        Me.BrowserNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserNext.Image = CType(resources.GetObject("BrowserNext.Image"), System.Drawing.Image)
        Me.BrowserNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserNext.Name = "BrowserNext"
        Me.BrowserNext.Size = New System.Drawing.Size(28, 28)
        Me.BrowserNext.Text = "Próximo registro"
        '
        'BrowserList
        '
        Me.BrowserList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserList.Image = CType(resources.GetObject("BrowserList.Image"), System.Drawing.Image)
        Me.BrowserList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserList.Name = "BrowserList"
        Me.BrowserList.Size = New System.Drawing.Size(28, 28)
        Me.BrowserList.Text = "Listar"
        Me.BrowserList.Visible = False
        '
        'BrowserSearch
        '
        Me.BrowserSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserSearch.Image = CType(resources.GetObject("BrowserSearch.Image"), System.Drawing.Image)
        Me.BrowserSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserSearch.Name = "BrowserSearch"
        Me.BrowserSearch.Size = New System.Drawing.Size(28, 28)
        Me.BrowserSearch.Text = "Buscar registro"
        '
        'BrowserSeparator2
        '
        Me.BrowserSeparator2.Name = "BrowserSeparator2"
        Me.BrowserSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BrowserLast
        '
        Me.BrowserLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserLast.Image = CType(resources.GetObject("BrowserLast.Image"), System.Drawing.Image)
        Me.BrowserLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserLast.Name = "BrowserLast"
        Me.BrowserLast.Size = New System.Drawing.Size(28, 28)
        Me.BrowserLast.Text = "Último registro"
        '
        'BrowserAccept
        '
        Me.BrowserAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAccept.Image = CType(resources.GetObject("BrowserAccept.Image"), System.Drawing.Image)
        Me.BrowserAccept.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAccept.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAccept.Name = "BrowserAccept"
        Me.BrowserAccept.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAccept.Text = "Guardar cambios"
        Me.BrowserAccept.Visible = False
        '
        'BrowserMenuViewSmallIcons
        '
        Me.BrowserMenuViewSmallIcons.Name = "BrowserMenuViewSmallIcons"
        Me.BrowserMenuViewSmallIcons.Size = New System.Drawing.Size(167, 22)
        Me.BrowserMenuViewSmallIcons.Text = "Iconos pequeños"
        '
        'BrowserMenuViewLargeIcons
        '
        Me.BrowserMenuViewLargeIcons.Checked = True
        Me.BrowserMenuViewLargeIcons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BrowserMenuViewLargeIcons.Name = "BrowserMenuViewLargeIcons"
        Me.BrowserMenuViewLargeIcons.Size = New System.Drawing.Size(167, 22)
        Me.BrowserMenuViewLargeIcons.Text = "Iconos grandes"
        '
        'BrowserMenuView
        '
        Me.BrowserMenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserMenuViewLargeIcons, Me.BrowserMenuViewSmallIcons})
        Me.BrowserMenuView.Name = "BrowserMenuView"
        Me.BrowserMenuView.Size = New System.Drawing.Size(101, 22)
        Me.BrowserMenuView.Text = "Ver"
        '
        'BrowserMenu
        '
        Me.BrowserMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserMenuView})
        Me.BrowserMenu.Name = "BrowserMenu"
        Me.BrowserMenu.Size = New System.Drawing.Size(102, 26)
        '
        'Browser
        '
        Me.Browser.ContextMenuStrip = Me.BrowserMenu
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAccept, Me.BrowserCancel, Me.BrowserAdd, Me.BrowserDelete, Me.BrowserSeparator1, Me.BrowserFirst, Me.BrowserPrevious, Me.BrowserNext, Me.BrowserLast, Me.BrowserSeparator2, Me.BrowserSearch, Me.BrowserList})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(785, 31)
        Me.Browser.TabIndex = 42
        Me.Browser.Text = "ToolStrip1"
        '
        'MenuFileAdd
        '
        Me.MenuFileAdd.Name = "MenuFileAdd"
        Me.MenuFileAdd.Size = New System.Drawing.Size(124, 22)
        Me.MenuFileAdd.Text = "Agregar"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileAdd})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(55, 20)
        Me.MenuFile.Text = "Archivo"
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuEdition, Me.MenuAction, Me.MenuSearch})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(785, 24)
        Me.MainMenu.TabIndex = 40
        Me.MainMenu.Text = "MenuStrip1"
        '
        'MenuEdition
        '
        Me.MenuEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEditionTypes, Me.MenuEditionPriorities, Me.MenuEditionEventTypes})
        Me.MenuEdition.Name = "MenuEdition"
        Me.MenuEdition.Size = New System.Drawing.Size(52, 20)
        Me.MenuEdition.Text = "Edición"
        '
        'MenuEditionTypes
        '
        Me.MenuEditionTypes.Name = "MenuEditionTypes"
        Me.MenuEditionTypes.Size = New System.Drawing.Size(162, 22)
        Me.MenuEditionTypes.Text = "Tipos de tarea"
        '
        'MenuEditionPriorities
        '
        Me.MenuEditionPriorities.Name = "MenuEditionPriorities"
        Me.MenuEditionPriorities.Size = New System.Drawing.Size(162, 22)
        Me.MenuEditionPriorities.Text = "Prioridades"
        '
        'MenuEditionEventTypes
        '
        Me.MenuEditionEventTypes.Name = "MenuEditionEventTypes"
        Me.MenuEditionEventTypes.Size = New System.Drawing.Size(162, 22)
        Me.MenuEditionEventTypes.Text = "Tipos de evento"
        '
        'MenuAction
        '
        Me.MenuAction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuActionAddEvent, Me.MenuActionAddEntity, Me.MenuActionCloseTask, Me.MenuActionCancelTask})
        Me.MenuAction.Name = "MenuAction"
        Me.MenuAction.Size = New System.Drawing.Size(61, 20)
        Me.MenuAction.Text = "Acciones"
        '
        'MenuActionAddEvent
        '
        Me.MenuActionAddEvent.Name = "MenuActionAddEvent"
        Me.MenuActionAddEvent.Size = New System.Drawing.Size(164, 22)
        Me.MenuActionAddEvent.Text = "Agregar evento"
        '
        'MenuActionAddEntity
        '
        Me.MenuActionAddEntity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuActionAddCustomer, Me.MenuActionAddTask})
        Me.MenuActionAddEntity.Name = "MenuActionAddEntity"
        Me.MenuActionAddEntity.Size = New System.Drawing.Size(164, 22)
        Me.MenuActionAddEntity.Text = "Agregar relación"
        '
        'MenuActionAddCustomer
        '
        Me.MenuActionAddCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuActionAddCustomerReal, Me.MenuActionAddCustomerPotential})
        Me.MenuActionAddCustomer.Name = "MenuActionAddCustomer"
        Me.MenuActionAddCustomer.Size = New System.Drawing.Size(118, 22)
        Me.MenuActionAddCustomer.Text = "Cliente"
        '
        'MenuActionAddCustomerReal
        '
        Me.MenuActionAddCustomerReal.Name = "MenuActionAddCustomerReal"
        Me.MenuActionAddCustomerReal.Size = New System.Drawing.Size(128, 22)
        Me.MenuActionAddCustomerReal.Text = "Real"
        '
        'MenuActionAddCustomerPotential
        '
        Me.MenuActionAddCustomerPotential.Name = "MenuActionAddCustomerPotential"
        Me.MenuActionAddCustomerPotential.Size = New System.Drawing.Size(128, 22)
        Me.MenuActionAddCustomerPotential.Text = "Potencial"
        '
        'MenuActionAddTask
        '
        Me.MenuActionAddTask.Name = "MenuActionAddTask"
        Me.MenuActionAddTask.Size = New System.Drawing.Size(118, 22)
        Me.MenuActionAddTask.Text = "Tarea"
        '
        'MenuActionCloseTask
        '
        Me.MenuActionCloseTask.Name = "MenuActionCloseTask"
        Me.MenuActionCloseTask.Size = New System.Drawing.Size(164, 22)
        Me.MenuActionCloseTask.Text = "Finalizar tarea"
        Me.MenuActionCloseTask.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'MenuActionCancelTask
        '
        Me.MenuActionCancelTask.Name = "MenuActionCancelTask"
        Me.MenuActionCancelTask.Size = New System.Drawing.Size(164, 22)
        Me.MenuActionCancelTask.Text = "Cancelar tarea"
        '
        'MenuSearch
        '
        Me.MenuSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSearchByKey, Me.MenuSearchPrevious, Me.MenuSearchNext, Me.MenuSearchFirst, Me.MenuSearchLast})
        Me.MenuSearch.Name = "MenuSearch"
        Me.MenuSearch.Size = New System.Drawing.Size(51, 20)
        Me.MenuSearch.Text = "Buscar"
        '
        'MenuSearchByKey
        '
        Me.MenuSearchByKey.Name = "MenuSearchByKey"
        Me.MenuSearchByKey.Size = New System.Drawing.Size(129, 22)
        Me.MenuSearchByKey.Text = "Por clave"
        '
        'MenuSearchPrevious
        '
        Me.MenuSearchPrevious.Name = "MenuSearchPrevious"
        Me.MenuSearchPrevious.Size = New System.Drawing.Size(129, 22)
        Me.MenuSearchPrevious.Text = "Anterior"
        '
        'MenuSearchNext
        '
        Me.MenuSearchNext.Name = "MenuSearchNext"
        Me.MenuSearchNext.Size = New System.Drawing.Size(129, 22)
        Me.MenuSearchNext.Text = "Siguiente"
        '
        'MenuSearchFirst
        '
        Me.MenuSearchFirst.Name = "MenuSearchFirst"
        Me.MenuSearchFirst.Size = New System.Drawing.Size(129, 22)
        Me.MenuSearchFirst.Text = "Primero"
        '
        'MenuSearchLast
        '
        Me.MenuSearchLast.Name = "MenuSearchLast"
        Me.MenuSearchLast.Size = New System.Drawing.Size(129, 22)
        Me.MenuSearchLast.Text = "Ultimo"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(785, 42)
        Me.lblTitle.TabIndex = 44
        Me.lblTitle.Text = "LLAMADO"
        '
        'frmSplit
        '
        Me.frmSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSplit.Location = New System.Drawing.Point(0, 97)
        Me.frmSplit.Name = "frmSplit"
        '
        'frmSplit.Panel1
        '
        Me.frmSplit.Panel1.Controls.Add(Me.tsTask)
        '
        'frmSplit.Panel2
        '
        Me.frmSplit.Size = New System.Drawing.Size(785, 497)
        Me.frmSplit.SplitterDistance = 118
        Me.frmSplit.TabIndex = 45
        '
        'tsTask
        '
        Me.tsTask.BackColor = System.Drawing.SystemColors.Control
        Me.tsTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsTask.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTask.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbGeneral, Me.tbEntities, Me.tbEvents})
        Me.tsTask.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsTask.Location = New System.Drawing.Point(0, 0)
        Me.tsTask.Name = "tsTask"
        Me.tsTask.Size = New System.Drawing.Size(118, 497)
        Me.tsTask.TabIndex = 27
        Me.tsTask.Text = "Modulos"
        '
        'tbGeneral
        '
        Me.tbGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.tbGeneral.Checked = True
        Me.tbGeneral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tbGeneral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbGeneral.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGeneral.Image = CType(resources.GetObject("tbGeneral.Image"), System.Drawing.Image)
        Me.tbGeneral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbGeneral.Name = "tbGeneral"
        Me.tbGeneral.Size = New System.Drawing.Size(116, 23)
        Me.tbGeneral.Text = "General"
        '
        'tbEntities
        '
        Me.tbEntities.BackColor = System.Drawing.SystemColors.Control
        Me.tbEntities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbEntities.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEntities.Image = CType(resources.GetObject("tbEntities.Image"), System.Drawing.Image)
        Me.tbEntities.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbEntities.Name = "tbEntities"
        Me.tbEntities.Size = New System.Drawing.Size(116, 23)
        Me.tbEntities.Text = "Relaciones"
        '
        'tbEvents
        '
        Me.tbEvents.BackColor = System.Drawing.SystemColors.Control
        Me.tbEvents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbEvents.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEvents.Image = CType(resources.GetObject("tbEvents.Image"), System.Drawing.Image)
        Me.tbEvents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbEvents.Name = "tbEvents"
        Me.tbEvents.Size = New System.Drawing.Size(116, 23)
        Me.tbEvents.Text = "Eventos"
        '
        'pnlEvents
        '
        Me.pnlEvents.Controls.Add(Me.GridEvents)
        Me.pnlEvents.Location = New System.Drawing.Point(3, 16)
        Me.pnlEvents.Name = "pnlEvents"
        Me.pnlEvents.Size = New System.Drawing.Size(702, 411)
        Me.pnlEvents.TabIndex = 1
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.txtPriority)
        Me.pnlGeneral.Controls.Add(Me.lblPriority)
        Me.pnlGeneral.Controls.Add(Me.GroupDates)
        Me.pnlGeneral.Controls.Add(Me.GroupUser)
        Me.pnlGeneral.Controls.Add(Me.txtOwnerDetail)
        Me.pnlGeneral.Controls.Add(Me.lblOwnerDetail)
        Me.pnlGeneral.Controls.Add(Me.txtStatus)
        Me.pnlGeneral.Controls.Add(Me.lblStatus)
        Me.pnlGeneral.Controls.Add(Me.txtDetail)
        Me.pnlGeneral.Controls.Add(Me.lblDetail)
        Me.pnlGeneral.Location = New System.Drawing.Point(247, 12)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(657, 491)
        Me.pnlGeneral.TabIndex = 0
        '
        'txtPriority
        '
        Me.txtPriority.Location = New System.Drawing.Point(126, 13)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.ReadOnly = True
        Me.txtPriority.Size = New System.Drawing.Size(198, 20)
        Me.txtPriority.TabIndex = 55
        Me.txtPriority.Text = "ALTA"
        '
        'lblPriority
        '
        Me.lblPriority.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.Location = New System.Drawing.Point(32, 11)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(88, 23)
        Me.lblPriority.TabIndex = 54
        Me.lblPriority.Text = "PRIORIDAD"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupDates
        '
        Me.GroupDates.Controls.Add(Me.txtInitTime)
        Me.GroupDates.Controls.Add(Me.txtFirstDate)
        Me.GroupDates.Controls.Add(Me.lblFirstDate)
        Me.GroupDates.Controls.Add(Me.txtInitDate)
        Me.GroupDates.Controls.Add(Me.lblSystemDate)
        Me.GroupDates.Controls.Add(Me.txtSystemDate)
        Me.GroupDates.Controls.Add(Me.lblInitDate)
        Me.GroupDates.Controls.Add(Me.txtLastDate)
        Me.GroupDates.Controls.Add(Me.lblLastDate)
        Me.GroupDates.Location = New System.Drawing.Point(353, 46)
        Me.GroupDates.Name = "GroupDates"
        Me.GroupDates.Size = New System.Drawing.Size(295, 129)
        Me.GroupDates.TabIndex = 53
        Me.GroupDates.TabStop = False
        Me.GroupDates.Text = "FECHAS"
        '
        'txtInitTime
        '
        Me.txtInitTime.Location = New System.Drawing.Point(199, 48)
        Me.txtInitTime.Name = "txtInitTime"
        Me.txtInitTime.ReadOnly = True
        Me.txtInitTime.Size = New System.Drawing.Size(73, 20)
        Me.txtInitTime.TabIndex = 50
        Me.txtInitTime.Text = "05/05/2009"
        Me.txtInitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFirstDate
        '
        Me.txtFirstDate.Location = New System.Drawing.Point(120, 74)
        Me.txtFirstDate.Name = "txtFirstDate"
        Me.txtFirstDate.ReadOnly = True
        Me.txtFirstDate.Size = New System.Drawing.Size(152, 20)
        Me.txtFirstDate.TabIndex = 49
        Me.txtFirstDate.Text = "13/05/2009"
        Me.txtFirstDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFirstDate
        '
        Me.lblFirstDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstDate.Location = New System.Drawing.Point(13, 71)
        Me.lblFirstDate.Name = "lblFirstDate"
        Me.lblFirstDate.Size = New System.Drawing.Size(101, 23)
        Me.lblFirstDate.TabIndex = 48
        Me.lblFirstDate.Text = "PRIMER ESTADO"
        Me.lblFirstDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInitDate
        '
        Me.txtInitDate.Location = New System.Drawing.Point(120, 47)
        Me.txtInitDate.Name = "txtInitDate"
        Me.txtInitDate.ReadOnly = True
        Me.txtInitDate.Size = New System.Drawing.Size(73, 20)
        Me.txtInitDate.TabIndex = 45
        Me.txtInitDate.Text = "05/05/2009"
        Me.txtInitDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSystemDate
        '
        Me.lblSystemDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemDate.Location = New System.Drawing.Point(13, 22)
        Me.lblSystemDate.Name = "lblSystemDate"
        Me.lblSystemDate.Size = New System.Drawing.Size(101, 23)
        Me.lblSystemDate.TabIndex = 42
        Me.lblSystemDate.Text = "ALTA"
        Me.lblSystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSystemDate
        '
        Me.txtSystemDate.Location = New System.Drawing.Point(120, 22)
        Me.txtSystemDate.Name = "txtSystemDate"
        Me.txtSystemDate.ReadOnly = True
        Me.txtSystemDate.Size = New System.Drawing.Size(152, 20)
        Me.txtSystemDate.TabIndex = 43
        Me.txtSystemDate.Text = "01/05/2009"
        Me.txtSystemDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInitDate
        '
        Me.lblInitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitDate.Location = New System.Drawing.Point(13, 45)
        Me.lblInitDate.Name = "lblInitDate"
        Me.lblInitDate.Size = New System.Drawing.Size(101, 23)
        Me.lblInitDate.TabIndex = 44
        Me.lblInitDate.Text = "INICIO"
        Me.lblInitDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLastDate
        '
        Me.txtLastDate.Location = New System.Drawing.Point(120, 98)
        Me.txtLastDate.Name = "txtLastDate"
        Me.txtLastDate.ReadOnly = True
        Me.txtLastDate.Size = New System.Drawing.Size(152, 20)
        Me.txtLastDate.TabIndex = 47
        Me.txtLastDate.Text = "13/05/2009"
        Me.txtLastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLastDate
        '
        Me.lblLastDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastDate.Location = New System.Drawing.Point(13, 94)
        Me.lblLastDate.Name = "lblLastDate"
        Me.lblLastDate.Size = New System.Drawing.Size(101, 23)
        Me.lblLastDate.TabIndex = 46
        Me.lblLastDate.Text = "ULT. ESTADO"
        Me.lblLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupUser
        '
        Me.GroupUser.Controls.Add(Me.lblProfile)
        Me.GroupUser.Controls.Add(Me.txtProfile)
        Me.GroupUser.Controls.Add(Me.lblAdmin)
        Me.GroupUser.Controls.Add(Me.txtAdmin)
        Me.GroupUser.Controls.Add(Me.txtUser)
        Me.GroupUser.Controls.Add(Me.lblUser)
        Me.GroupUser.Controls.Add(Me.lblOwner)
        Me.GroupUser.Controls.Add(Me.txtOwner)
        Me.GroupUser.Location = New System.Drawing.Point(17, 46)
        Me.GroupUser.Name = "GroupUser"
        Me.GroupUser.Size = New System.Drawing.Size(325, 129)
        Me.GroupUser.TabIndex = 52
        Me.GroupUser.TabStop = False
        Me.GroupUser.Text = "USUARIOS"
        '
        'lblProfile
        '
        Me.lblProfile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(16, 95)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(78, 23)
        Me.lblProfile.TabIndex = 54
        Me.lblProfile.Text = "PERFIL"
        Me.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProfile
        '
        Me.txtProfile.Location = New System.Drawing.Point(109, 97)
        Me.txtProfile.Name = "txtProfile"
        Me.txtProfile.ReadOnly = True
        Me.txtProfile.Size = New System.Drawing.Size(198, 20)
        Me.txtProfile.TabIndex = 55
        Me.txtProfile.Text = "VENTAS"
        '
        'lblAdmin
        '
        Me.lblAdmin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(16, 69)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(78, 23)
        Me.lblAdmin.TabIndex = 52
        Me.lblAdmin.Text = "AUDITOR"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdmin
        '
        Me.txtAdmin.Location = New System.Drawing.Point(109, 71)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.ReadOnly = True
        Me.txtAdmin.Size = New System.Drawing.Size(198, 20)
        Me.txtAdmin.TabIndex = 53
        Me.txtAdmin.Text = "BORRAJO"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(109, 19)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(198, 20)
        Me.txtUser.TabIndex = 51
        Me.txtUser.Text = "DORA"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(15, 19)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 23)
        Me.lblUser.TabIndex = 50
        Me.lblUser.Text = "RESPONSABLE"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOwner
        '
        Me.lblOwner.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.Location = New System.Drawing.Point(16, 45)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(78, 23)
        Me.lblOwner.TabIndex = 34
        Me.lblOwner.Text = "INICIADOR"
        Me.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(109, 45)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.ReadOnly = True
        Me.txtOwner.Size = New System.Drawing.Size(198, 20)
        Me.txtOwner.TabIndex = 35
        Me.txtOwner.Text = "BORRAJO"
        '
        'txtOwnerDetail
        '
        Me.txtOwnerDetail.Location = New System.Drawing.Point(17, 406)
        Me.txtOwnerDetail.Multiline = True
        Me.txtOwnerDetail.Name = "txtOwnerDetail"
        Me.txtOwnerDetail.ReadOnly = True
        Me.txtOwnerDetail.Size = New System.Drawing.Size(631, 68)
        Me.txtOwnerDetail.TabIndex = 49
        '
        'lblOwnerDetail
        '
        Me.lblOwnerDetail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerDetail.Location = New System.Drawing.Point(14, 380)
        Me.lblOwnerDetail.Name = "lblOwnerDetail"
        Me.lblOwnerDetail.Size = New System.Drawing.Size(634, 23)
        Me.lblOwnerDetail.TabIndex = 48
        Me.lblOwnerDetail.Text = "DETALLE INICIAL"
        Me.lblOwnerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(450, 12)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(198, 20)
        Me.txtStatus.TabIndex = 41
        Me.txtStatus.Text = "CERRADA"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(356, 10)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(88, 23)
        Me.lblStatus.TabIndex = 40
        Me.lblStatus.Text = "ESTADO"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDetail
        '
        Me.txtDetail.Location = New System.Drawing.Point(17, 210)
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.ReadOnly = True
        Me.txtDetail.Size = New System.Drawing.Size(631, 167)
        Me.txtDetail.TabIndex = 39
        '
        'lblDetail
        '
        Me.lblDetail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(14, 184)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(634, 23)
        Me.lblDetail.TabIndex = 38
        Me.lblDetail.Text = "DETALLE"
        Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlEntities
        '
        Me.pnlEntities.Controls.Add(Me.GridEntities)
        Me.pnlEntities.Location = New System.Drawing.Point(16, 39)
        Me.pnlEntities.Name = "pnlEntities"
        Me.pnlEntities.Size = New System.Drawing.Size(632, 388)
        Me.pnlEntities.TabIndex = 1
        '
        'TaskentityMenu
        '
        Me.TaskentityMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaskentityMenuRemove})
        Me.TaskentityMenu.Name = "TaskentityMenu"
        Me.TaskentityMenu.Size = New System.Drawing.Size(122, 26)
        '
        'TaskentityMenuRemove
        '
        Me.TaskentityMenuRemove.Name = "TaskentityMenuRemove"
        Me.TaskentityMenuRemove.Size = New System.Drawing.Size(121, 22)
        Me.TaskentityMenuRemove.Text = "Eliminar"
        '
        'GridEvents
        '
        Me.GridEvents.AllowUserToAddRows = False
        Me.GridEvents.AllowUserToDeleteRows = False
        Me.GridEvents.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskEventDate, Me.TaskEventTime, Me.TaskEventType, Me.TaskEventdetail})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridEvents.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEvents.GridColor = System.Drawing.SystemColors.Control
        Me.GridEvents.Location = New System.Drawing.Point(0, 0)
        Me.GridEvents.Name = "GridEvents"
        Me.GridEvents.ReadOnly = True
        Me.GridEvents.RowHeadersVisible = False
        Me.GridEvents.RowTemplate.DividerHeight = 5
        Me.GridEvents.RowTemplate.Height = 30
        Me.GridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEvents.Size = New System.Drawing.Size(702, 411)
        Me.GridEvents.TabIndex = 1
        '
        'TaskEventDate
        '
        DataGridViewCellStyle1.Format = "d"
        Me.TaskEventDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.TaskEventDate.HeaderText = "FECHA"
        Me.TaskEventDate.Name = "TaskEventDate"
        Me.TaskEventDate.ReadOnly = True
        '
        'TaskEventTime
        '
        DataGridViewCellStyle2.Format = "t"
        Me.TaskEventTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.TaskEventTime.HeaderText = "HORA"
        Me.TaskEventTime.Name = "TaskEventTime"
        Me.TaskEventTime.ReadOnly = True
        '
        'TaskEventType
        '
        Me.TaskEventType.HeaderText = "TIPO"
        Me.TaskEventType.Name = "TaskEventType"
        Me.TaskEventType.ReadOnly = True
        '
        'TaskEventdetail
        '
        Me.TaskEventdetail.HeaderText = "DETALLE"
        Me.TaskEventdetail.Name = "TaskEventdetail"
        Me.TaskEventdetail.ReadOnly = True
        Me.TaskEventdetail.Width = 400
        '
        'GridEntities
        '
        Me.GridEntities.AllowUserToAddRows = False
        Me.GridEntities.AllowUserToDeleteRows = False
        Me.GridEntities.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridEntities.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEntities.ColumnHeadersVisible = False
        Me.GridEntities.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EntitySystemType, Me.EntityType, Me.EntityCode})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridEntities.DefaultCellStyle = DataGridViewCellStyle4
        Me.GridEntities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEntities.GridColor = System.Drawing.SystemColors.Control
        Me.GridEntities.Location = New System.Drawing.Point(0, 0)
        Me.GridEntities.Name = "GridEntities"
        Me.GridEntities.ReadOnly = True
        Me.GridEntities.RowHeadersVisible = False
        Me.GridEntities.RowTemplate.ContextMenuStrip = Me.TaskentityMenu
        Me.GridEntities.RowTemplate.DividerHeight = 5
        Me.GridEntities.RowTemplate.Height = 30
        Me.GridEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEntities.Size = New System.Drawing.Size(632, 388)
        Me.GridEntities.TabIndex = 0
        '
        'EntitySystemType
        '
        Me.EntitySystemType.HeaderText = "SYSTEM TYPE"
        Me.EntitySystemType.Name = "EntitySystemType"
        Me.EntitySystemType.ReadOnly = True
        Me.EntitySystemType.Visible = False
        '
        'EntityType
        '
        Me.EntityType.HeaderText = "TIPO"
        Me.EntityType.Name = "EntityType"
        Me.EntityType.ReadOnly = True
        Me.EntityType.Width = 300
        '
        'EntityCode
        '
        Me.EntityCode.HeaderText = "CODIGO"
        Me.EntityCode.Name = "EntityCode"
        Me.EntityCode.ReadOnly = True
        Me.EntityCode.Width = 200
        '
        'frmTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 594)
        Me.Controls.Add(Me.frmSplit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.pnlEvents)
        Me.Controls.Add(Me.pnlEntities)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmTask"
        Me.Text = "Tareas"
        Me.BrowserMenu.ResumeLayout(False)
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.frmSplit.Panel1.ResumeLayout(False)
        Me.frmSplit.Panel1.PerformLayout()
        Me.frmSplit.ResumeLayout(False)
        Me.tsTask.ResumeLayout(False)
        Me.tsTask.PerformLayout()
        Me.pnlEvents.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlGeneral.PerformLayout()
        Me.GroupDates.ResumeLayout(False)
        Me.GroupDates.PerformLayout()
        Me.GroupUser.ResumeLayout(False)
        Me.GroupUser.PerformLayout()
        Me.pnlEntities.ResumeLayout(False)
        Me.TaskentityMenu.ResumeLayout(False)
        CType(Me.GridEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEntities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowserSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserList As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserAccept As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserMenuViewSmallIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserMenuViewLargeIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserMenuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Browser As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuFileAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents frmSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents tsTask As System.Windows.Forms.ToolStrip
    Friend WithEvents tbGeneral As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlGeneral As System.Windows.Forms.Panel
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtDetail As System.Windows.Forms.TextBox
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents tbEntities As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbEvents As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtSystemDate As System.Windows.Forms.TextBox
    Friend WithEvents lblSystemDate As System.Windows.Forms.Label
    Friend WithEvents txtLastDate As System.Windows.Forms.TextBox
    Friend WithEvents lblLastDate As System.Windows.Forms.Label
    Friend WithEvents txtInitDate As System.Windows.Forms.TextBox
    Friend WithEvents lblInitDate As System.Windows.Forms.Label
    Friend WithEvents pnlEntities As System.Windows.Forms.Panel
    Friend WithEvents pnlEvents As System.Windows.Forms.Panel
    Friend WithEvents GridEvents As Crm.UI.GridView
    Friend WithEvents GridEntities As Crm.UI.GridView
    Friend WithEvents TaskEventDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskEventTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskEventType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskEventdetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtOwnerDetail As System.Windows.Forms.TextBox
    Friend WithEvents lblOwnerDetail As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents GroupUser As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdmin As System.Windows.Forms.Label
    Friend WithEvents txtAdmin As System.Windows.Forms.TextBox
    Friend WithEvents lblProfile As System.Windows.Forms.Label
    Friend WithEvents txtProfile As System.Windows.Forms.TextBox
    Friend WithEvents GroupDates As System.Windows.Forms.GroupBox
    Friend WithEvents txtInitTime As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstDate As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstDate As System.Windows.Forms.Label
    Friend WithEvents MenuEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditionTypes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditionPriorities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPriority As System.Windows.Forms.TextBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents MenuAction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionAddEvent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionAddEntity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditionEventTypes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionCancelTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionCloseTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionAddCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionAddTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntitySystemType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntityType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntityCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskentityMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TaskentityMenuRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchByKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchPrevious As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchFirst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchLast As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionAddCustomerReal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionAddCustomerPotential As System.Windows.Forms.ToolStripMenuItem
End Class
