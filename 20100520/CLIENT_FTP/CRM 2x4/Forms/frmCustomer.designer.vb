<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlNotes = New System.Windows.Forms.Panel
        Me.txtNotes = New System.Windows.Forms.RichTextBox
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileClose = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActions = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionsAddContact = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionsAddAttachment = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionsAddTask = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionPotentialCustomersToReal = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearch = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchByKey = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchPrevious = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchNext = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchFirst = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSearchLast = New System.Windows.Forms.ToolStripMenuItem
        Me.frmSplit = New System.Windows.Forms.SplitContainer
        Me.tsCustomer = New System.Windows.Forms.ToolStrip
        Me.tbGeneral = New System.Windows.Forms.ToolStripButton
        Me.tbAdress = New System.Windows.Forms.ToolStripButton
        Me.tbDelivery = New System.Windows.Forms.ToolStripButton
        Me.tbTerms = New System.Windows.Forms.ToolStripButton
        Me.tbNotes = New System.Windows.Forms.ToolStripButton
        Me.tbContacts = New System.Windows.Forms.ToolStripButton
        Me.tbAttachment = New System.Windows.Forms.ToolStripButton
        Me.tbTask = New System.Windows.Forms.ToolStripButton
        Me.pnlTerms = New System.Windows.Forms.Panel
        Me.GroupIBB = New System.Windows.Forms.GroupBox
        Me.chkIBBInternalTax = New System.Windows.Forms.CheckBox
        Me.txtIBBTaxCode = New System.Windows.Forms.TextBox
        Me.lblIBBTaxCode = New System.Windows.Forms.Label
        Me.chkIBBCalc = New System.Windows.Forms.CheckBox
        Me.GroupInternalTax = New System.Windows.Forms.GroupBox
        Me.chkInternalTaxCalc = New System.Windows.Forms.CheckBox
        Me.chkInternalTaxDetail = New System.Windows.Forms.CheckBox
        Me.chkInternalTaxPlus = New System.Windows.Forms.CheckBox
        Me.GroupIB = New System.Windows.Forms.GroupBox
        Me.txtIBTaxAditionalCode = New System.Windows.Forms.TextBox
        Me.txtIBTaxCode = New System.Windows.Forms.TextBox
        Me.lblIBIBTaxAditionalCode = New System.Windows.Forms.Label
        Me.chkIBCalc = New System.Windows.Forms.CheckBox
        Me.lblIBTaxCode = New System.Windows.Forms.Label
        Me.GroupIva = New System.Windows.Forms.GroupBox
        Me.txtNCTaxCode = New System.Windows.Forms.TextBox
        Me.lblNCTaxCode = New System.Windows.Forms.Label
        Me.txtIVAExclusionPercent = New System.Windows.Forms.TextBox
        Me.lblIVAExclusionPercent = New System.Windows.Forms.Label
        Me.txtIVAFreePercent = New System.Windows.Forms.TextBox
        Me.lblIVAFreePercent = New System.Windows.Forms.Label
        Me.chkIVAFree = New System.Windows.Forms.CheckBox
        Me.chkIVAPlus = New System.Windows.Forms.CheckBox
        Me.txtIVACategory = New System.Windows.Forms.TextBox
        Me.lblIVACategory = New System.Windows.Forms.Label
        Me.txtEmployeeCode = New System.Windows.Forms.TextBox
        Me.txtEmployeeName = New System.Windows.Forms.TextBox
        Me.txtSalesTermsCode = New System.Windows.Forms.TextBox
        Me.txtSalesTermsName = New System.Windows.Forms.TextBox
        Me.txtCurrencyName = New System.Windows.Forms.TextBox
        Me.lblExchange = New System.Windows.Forms.Label
        Me.txtIBNumber = New System.Windows.Forms.TextBox
        Me.lblIBNumber = New System.Windows.Forms.Label
        Me.txtCuit = New System.Windows.Forms.TextBox
        Me.lblCuit = New System.Windows.Forms.Label
        Me.lblEmployee = New System.Windows.Forms.Label
        Me.lblSalesTerms = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.pnlAdress = New System.Windows.Forms.Panel
        Me.txtZoneCode = New System.Windows.Forms.TextBox
        Me.txtZoneName = New System.Windows.Forms.TextBox
        Me.lblZone = New System.Windows.Forms.Label
        Me.txtStateCode = New System.Windows.Forms.TextBox
        Me.txtStateName = New System.Windows.Forms.TextBox
        Me.lblState = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblCity = New System.Windows.Forms.Label
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.lblZipCode = New System.Windows.Forms.Label
        Me.txtWeb = New System.Windows.Forms.TextBox
        Me.lblWeb = New System.Windows.Forms.Label
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtAdress = New System.Windows.Forms.TextBox
        Me.lblAdress = New System.Windows.Forms.Label
        Me.pnlBasic = New System.Windows.Forms.Panel
        Me.txtGroupName = New System.Windows.Forms.TextBox
        Me.txtGroupCode = New System.Windows.Forms.TextBox
        Me.lblGroup = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblLegalName = New System.Windows.Forms.Label
        Me.txtLegalName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.pnlDelivery = New System.Windows.Forms.Panel
        Me.txtTranspCode = New System.Windows.Forms.TextBox
        Me.txtTranspName = New System.Windows.Forms.TextBox
        Me.lblTransp = New System.Windows.Forms.Label
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.lblHours = New System.Windows.Forms.Label
        Me.txtDeliveryAdress = New System.Windows.Forms.TextBox
        Me.lblDeliveryAdress = New System.Windows.Forms.Label
        Me.Browser = New System.Windows.Forms.ToolStrip
        Me.BrowserMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BrowserMenuView = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowserMenuViewLargeIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowserMenuViewSmallIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowserAdd = New System.Windows.Forms.ToolStripButton
        Me.BrowserDelete = New System.Windows.Forms.ToolStripButton
        Me.BrowserEdit = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserFirst = New System.Windows.Forms.ToolStripButton
        Me.BrowserPrevious = New System.Windows.Forms.ToolStripButton
        Me.BrowserNext = New System.Windows.Forms.ToolStripButton
        Me.BrowserLast = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserSearch = New System.Windows.Forms.ToolStripButton
        Me.BrowserList = New System.Windows.Forms.ToolStripButton
        Me.BrowserRefresh = New System.Windows.Forms.ToolStripButton
        Me.lblTitle = New System.Windows.Forms.Label
        Me.pnlContacts = New System.Windows.Forms.Panel
        Me.GridContacts = New Crm.UI.GridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEPARTMENT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FIRSTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LASTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHONE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MAIL2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BIRTHDAY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlAttachments = New System.Windows.Forms.Panel
        Me.FileList = New System.Windows.Forms.ListView
        Me.IList = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlTasks = New System.Windows.Forms.Panel
        Me.GridTaks = New Crm.UI.GridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateInit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskPriority = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlNotes.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.frmSplit.Panel1.SuspendLayout()
        Me.frmSplit.SuspendLayout()
        Me.tsCustomer.SuspendLayout()
        Me.pnlTerms.SuspendLayout()
        Me.GroupIBB.SuspendLayout()
        Me.GroupInternalTax.SuspendLayout()
        Me.GroupIB.SuspendLayout()
        Me.GroupIva.SuspendLayout()
        Me.pnlAdress.SuspendLayout()
        Me.pnlBasic.SuspendLayout()
        Me.pnlDelivery.SuspendLayout()
        Me.Browser.SuspendLayout()
        Me.BrowserMenu.SuspendLayout()
        Me.pnlContacts.SuspendLayout()
        CType(Me.GridContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAttachments.SuspendLayout()
        Me.pnlTasks.SuspendLayout()
        CType(Me.GridTaks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlNotes
        '
        Me.pnlNotes.Controls.Add(Me.txtNotes)
        Me.pnlNotes.Location = New System.Drawing.Point(120, 840)
        Me.pnlNotes.Name = "pnlNotes"
        Me.pnlNotes.Size = New System.Drawing.Size(703, 108)
        Me.pnlNotes.TabIndex = 27
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.Size = New System.Drawing.Size(703, 108)
        Me.txtNotes.TabIndex = 0
        Me.txtNotes.Text = "CUSTOMER/NOTES"
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuActions, Me.MenuSearch})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(842, 24)
        Me.MainMenu.TabIndex = 30
        Me.MainMenu.Text = "MenuStrip1"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileAdd, Me.MenuFileEdit, Me.MenuFileClose})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(55, 20)
        Me.MenuFile.Text = "Archivo"
        '
        'MenuFileAdd
        '
        Me.MenuFileAdd.Name = "MenuFileAdd"
        Me.MenuFileAdd.Size = New System.Drawing.Size(128, 22)
        Me.MenuFileAdd.Text = "Agregar"
        '
        'MenuFileEdit
        '
        Me.MenuFileEdit.Name = "MenuFileEdit"
        Me.MenuFileEdit.Size = New System.Drawing.Size(128, 22)
        Me.MenuFileEdit.Text = "Modificar"
        '
        'MenuFileClose
        '
        Me.MenuFileClose.Name = "MenuFileClose"
        Me.MenuFileClose.Size = New System.Drawing.Size(128, 22)
        Me.MenuFileClose.Text = "Salir"
        '
        'MenuActions
        '
        Me.MenuActions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuActionsAddContact, Me.MenuActionsAddAttachment, Me.MenuActionsAddTask, Me.MenuActionPotentialCustomersToReal})
        Me.MenuActions.Name = "MenuActions"
        Me.MenuActions.Size = New System.Drawing.Size(61, 20)
        Me.MenuActions.Text = "Acciones"
        '
        'MenuActionsAddContact
        '
        Me.MenuActionsAddContact.Name = "MenuActionsAddContact"
        Me.MenuActionsAddContact.Size = New System.Drawing.Size(169, 22)
        Me.MenuActionsAddContact.Text = "Agregar contacto"
        '
        'MenuActionsAddAttachment
        '
        Me.MenuActionsAddAttachment.Name = "MenuActionsAddAttachment"
        Me.MenuActionsAddAttachment.Size = New System.Drawing.Size(169, 22)
        Me.MenuActionsAddAttachment.Text = "Agregar adjunto"
        '
        'MenuActionsAddTask
        '
        Me.MenuActionsAddTask.Name = "MenuActionsAddTask"
        Me.MenuActionsAddTask.Size = New System.Drawing.Size(169, 22)
        Me.MenuActionsAddTask.Text = "Agregar tarea"
        '
        'MenuActionPotentialCustomersToReal
        '
        Me.MenuActionPotentialCustomersToReal.Name = "MenuActionPotentialCustomersToReal"
        Me.MenuActionPotentialCustomersToReal.Size = New System.Drawing.Size(169, 22)
        Me.MenuActionPotentialCustomersToReal.Text = "Pasar a Tango"
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
        'frmSplit
        '
        Me.frmSplit.Location = New System.Drawing.Point(0, 113)
        Me.frmSplit.Name = "frmSplit"
        '
        'frmSplit.Panel1
        '
        Me.frmSplit.Panel1.Controls.Add(Me.tsCustomer)
        '
        'frmSplit.Panel2
        '
        Me.frmSplit.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.frmSplit.Size = New System.Drawing.Size(842, 471)
        Me.frmSplit.SplitterDistance = 128
        Me.frmSplit.TabIndex = 32
        '
        'tsCustomer
        '
        Me.tsCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.tsCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbGeneral, Me.tbAdress, Me.tbDelivery, Me.tbTerms, Me.tbNotes, Me.tbContacts, Me.tbAttachment, Me.tbTask})
        Me.tsCustomer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCustomer.Location = New System.Drawing.Point(0, 0)
        Me.tsCustomer.Name = "tsCustomer"
        Me.tsCustomer.Size = New System.Drawing.Size(128, 471)
        Me.tsCustomer.TabIndex = 27
        Me.tsCustomer.Text = "Modulos"
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
        Me.tbGeneral.Size = New System.Drawing.Size(126, 23)
        Me.tbGeneral.Text = "General"
        '
        'tbAdress
        '
        Me.tbAdress.BackColor = System.Drawing.SystemColors.Control
        Me.tbAdress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAdress.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdress.Image = CType(resources.GetObject("tbAdress.Image"), System.Drawing.Image)
        Me.tbAdress.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAdress.Name = "tbAdress"
        Me.tbAdress.Size = New System.Drawing.Size(126, 23)
        Me.tbAdress.Text = "Domicilio"
        '
        'tbDelivery
        '
        Me.tbDelivery.BackColor = System.Drawing.SystemColors.Control
        Me.tbDelivery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbDelivery.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDelivery.Image = CType(resources.GetObject("tbDelivery.Image"), System.Drawing.Image)
        Me.tbDelivery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbDelivery.Name = "tbDelivery"
        Me.tbDelivery.Size = New System.Drawing.Size(126, 23)
        Me.tbDelivery.Text = "Entrega"
        '
        'tbTerms
        '
        Me.tbTerms.BackColor = System.Drawing.SystemColors.Control
        Me.tbTerms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbTerms.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTerms.Image = CType(resources.GetObject("tbTerms.Image"), System.Drawing.Image)
        Me.tbTerms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbTerms.Name = "tbTerms"
        Me.tbTerms.Size = New System.Drawing.Size(126, 23)
        Me.tbTerms.Text = "Facturación"
        '
        'tbNotes
        '
        Me.tbNotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbNotes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNotes.Image = CType(resources.GetObject("tbNotes.Image"), System.Drawing.Image)
        Me.tbNotes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbNotes.Name = "tbNotes"
        Me.tbNotes.Size = New System.Drawing.Size(126, 23)
        Me.tbNotes.Text = "Comentarios"
        '
        'tbContacts
        '
        Me.tbContacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbContacts.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbContacts.Image = CType(resources.GetObject("tbContacts.Image"), System.Drawing.Image)
        Me.tbContacts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbContacts.Name = "tbContacts"
        Me.tbContacts.Size = New System.Drawing.Size(126, 23)
        Me.tbContacts.Text = "Contactos"
        '
        'tbAttachment
        '
        Me.tbAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAttachment.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbAttachment.Image = CType(resources.GetObject("tbAttachment.Image"), System.Drawing.Image)
        Me.tbAttachment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAttachment.Name = "tbAttachment"
        Me.tbAttachment.Size = New System.Drawing.Size(126, 23)
        Me.tbAttachment.Text = "Adjuntos"
        '
        'tbTask
        '
        Me.tbTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbTask.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbTask.Image = CType(resources.GetObject("tbTask.Image"), System.Drawing.Image)
        Me.tbTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbTask.Name = "tbTask"
        Me.tbTask.Size = New System.Drawing.Size(126, 23)
        Me.tbTask.Text = "Tareas"
        '
        'pnlTerms
        '
        Me.pnlTerms.Controls.Add(Me.GroupIBB)
        Me.pnlTerms.Controls.Add(Me.GroupInternalTax)
        Me.pnlTerms.Controls.Add(Me.GroupIB)
        Me.pnlTerms.Controls.Add(Me.GroupIva)
        Me.pnlTerms.Controls.Add(Me.txtEmployeeCode)
        Me.pnlTerms.Controls.Add(Me.txtEmployeeName)
        Me.pnlTerms.Controls.Add(Me.txtSalesTermsCode)
        Me.pnlTerms.Controls.Add(Me.txtSalesTermsName)
        Me.pnlTerms.Controls.Add(Me.txtCurrencyName)
        Me.pnlTerms.Controls.Add(Me.lblExchange)
        Me.pnlTerms.Controls.Add(Me.txtIBNumber)
        Me.pnlTerms.Controls.Add(Me.lblIBNumber)
        Me.pnlTerms.Controls.Add(Me.txtCuit)
        Me.pnlTerms.Controls.Add(Me.lblCuit)
        Me.pnlTerms.Controls.Add(Me.lblEmployee)
        Me.pnlTerms.Controls.Add(Me.lblSalesTerms)
        Me.pnlTerms.Controls.Add(Me.txtDiscount)
        Me.pnlTerms.Controls.Add(Me.lblDiscount)
        Me.pnlTerms.Location = New System.Drawing.Point(6, 3)
        Me.pnlTerms.Name = "pnlTerms"
        Me.pnlTerms.Size = New System.Drawing.Size(704, 450)
        Me.pnlTerms.TabIndex = 24
        '
        'GroupIBB
        '
        Me.GroupIBB.Controls.Add(Me.chkIBBInternalTax)
        Me.GroupIBB.Controls.Add(Me.txtIBBTaxCode)
        Me.GroupIBB.Controls.Add(Me.lblIBBTaxCode)
        Me.GroupIBB.Controls.Add(Me.chkIBBCalc)
        Me.GroupIBB.Location = New System.Drawing.Point(406, 317)
        Me.GroupIBB.Name = "GroupIBB"
        Me.GroupIBB.Size = New System.Drawing.Size(287, 118)
        Me.GroupIBB.TabIndex = 46
        Me.GroupIBB.TabStop = False
        Me.GroupIBB.Text = "PERCEPCION DE INGRESOS BRUTOS BS. AS."
        '
        'chkIBBInternalTax
        '
        Me.chkIBBInternalTax.AutoSize = True
        Me.chkIBBInternalTax.Enabled = False
        Me.chkIBBInternalTax.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIBBInternalTax.Location = New System.Drawing.Point(16, 50)
        Me.chkIBBInternalTax.Name = "chkIBBInternalTax"
        Me.chkIBBInternalTax.Size = New System.Drawing.Size(193, 19)
        Me.chkIBBInternalTax.TabIndex = 40
        Me.chkIBBInternalTax.Tag = "CUSTOMER/IBBINTERNALTAX"
        Me.chkIBBInternalTax.Text = "INCLUYE IMPUESTOS INTERNOS"
        Me.chkIBBInternalTax.UseVisualStyleBackColor = True
        '
        'txtIBBTaxCode
        '
        Me.txtIBBTaxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIBBTaxCode.Location = New System.Drawing.Point(106, 86)
        Me.txtIBBTaxCode.Name = "txtIBBTaxCode"
        Me.txtIBBTaxCode.ReadOnly = True
        Me.txtIBBTaxCode.Size = New System.Drawing.Size(77, 23)
        Me.txtIBBTaxCode.TabIndex = 39
        Me.txtIBBTaxCode.Tag = "CUSTOMER/IBBTAX/CODE"
        '
        'lblIBBTaxCode
        '
        Me.lblIBBTaxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBBTaxCode.Location = New System.Drawing.Point(13, 86)
        Me.lblIBBTaxCode.Name = "lblIBBTaxCode"
        Me.lblIBBTaxCode.Size = New System.Drawing.Size(87, 23)
        Me.lblIBBTaxCode.TabIndex = 38
        Me.lblIBBTaxCode.Tag = "CUSTOMER/IBBTAX/CODE"
        Me.lblIBBTaxCode.Text = "ALICUOTA FIJA"
        Me.lblIBBTaxCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkIBBCalc
        '
        Me.chkIBBCalc.AutoSize = True
        Me.chkIBBCalc.Enabled = False
        Me.chkIBBCalc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIBBCalc.Location = New System.Drawing.Point(16, 25)
        Me.chkIBBCalc.Name = "chkIBBCalc"
        Me.chkIBBCalc.Size = New System.Drawing.Size(71, 19)
        Me.chkIBBCalc.TabIndex = 35
        Me.chkIBBCalc.Tag = "CUSTOMER/IBBCALC"
        Me.chkIBBCalc.Text = "LIQUIDA"
        Me.chkIBBCalc.UseVisualStyleBackColor = True
        '
        'GroupInternalTax
        '
        Me.GroupInternalTax.Controls.Add(Me.chkInternalTaxCalc)
        Me.GroupInternalTax.Controls.Add(Me.chkInternalTaxDetail)
        Me.GroupInternalTax.Controls.Add(Me.chkInternalTaxPlus)
        Me.GroupInternalTax.Location = New System.Drawing.Point(16, 329)
        Me.GroupInternalTax.Name = "GroupInternalTax"
        Me.GroupInternalTax.Size = New System.Drawing.Size(384, 110)
        Me.GroupInternalTax.TabIndex = 45
        Me.GroupInternalTax.TabStop = False
        Me.GroupInternalTax.Tag = ""
        Me.GroupInternalTax.Text = "IMPUESTOS INTERNOS"
        '
        'chkInternalTaxCalc
        '
        Me.chkInternalTaxCalc.AutoSize = True
        Me.chkInternalTaxCalc.Enabled = False
        Me.chkInternalTaxCalc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInternalTaxCalc.Location = New System.Drawing.Point(18, 29)
        Me.chkInternalTaxCalc.Name = "chkInternalTaxCalc"
        Me.chkInternalTaxCalc.Size = New System.Drawing.Size(71, 19)
        Me.chkInternalTaxCalc.TabIndex = 36
        Me.chkInternalTaxCalc.Tag = "CUSTOMER/INTERNALTAXCALC"
        Me.chkInternalTaxCalc.Text = "LIQUIDA"
        Me.chkInternalTaxCalc.UseVisualStyleBackColor = True
        '
        'chkInternalTaxDetail
        '
        Me.chkInternalTaxDetail.AutoSize = True
        Me.chkInternalTaxDetail.Enabled = False
        Me.chkInternalTaxDetail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInternalTaxDetail.Location = New System.Drawing.Point(17, 54)
        Me.chkInternalTaxDetail.Name = "chkInternalTaxDetail"
        Me.chkInternalTaxDetail.Size = New System.Drawing.Size(92, 19)
        Me.chkInternalTaxDetail.TabIndex = 22
        Me.chkInternalTaxDetail.Tag = "CUSTOMER/INTERNALTAXDETAIL"
        Me.chkInternalTaxDetail.Text = "DISCRIMINA"
        Me.chkInternalTaxDetail.UseVisualStyleBackColor = True
        '
        'chkInternalTaxPlus
        '
        Me.chkInternalTaxPlus.AutoSize = True
        Me.chkInternalTaxPlus.Enabled = False
        Me.chkInternalTaxPlus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInternalTaxPlus.Location = New System.Drawing.Point(17, 79)
        Me.chkInternalTaxPlus.Name = "chkInternalTaxPlus"
        Me.chkInternalTaxPlus.Size = New System.Drawing.Size(253, 19)
        Me.chkInternalTaxPlus.TabIndex = 21
        Me.chkInternalTaxPlus.Tag = "CUSTOMER/INTERNALTAXPLUS"
        Me.chkInternalTaxPlus.Text = "SOBRE/SUBTASA DE IMPUESTOS INTERNOS"
        Me.chkInternalTaxPlus.UseVisualStyleBackColor = True
        '
        'GroupIB
        '
        Me.GroupIB.Controls.Add(Me.txtIBTaxAditionalCode)
        Me.GroupIB.Controls.Add(Me.txtIBTaxCode)
        Me.GroupIB.Controls.Add(Me.lblIBIBTaxAditionalCode)
        Me.GroupIB.Controls.Add(Me.chkIBCalc)
        Me.GroupIB.Controls.Add(Me.lblIBTaxCode)
        Me.GroupIB.Location = New System.Drawing.Point(405, 137)
        Me.GroupIB.Name = "GroupIB"
        Me.GroupIB.Size = New System.Drawing.Size(287, 118)
        Me.GroupIB.TabIndex = 45
        Me.GroupIB.TabStop = False
        Me.GroupIB.Text = "PERCEPCION DE INGRESOS BRUTOS"
        '
        'txtIBTaxAditionalCode
        '
        Me.txtIBTaxAditionalCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIBTaxAditionalCode.Location = New System.Drawing.Point(143, 86)
        Me.txtIBTaxAditionalCode.Name = "txtIBTaxAditionalCode"
        Me.txtIBTaxAditionalCode.ReadOnly = True
        Me.txtIBTaxAditionalCode.Size = New System.Drawing.Size(77, 23)
        Me.txtIBTaxAditionalCode.TabIndex = 39
        Me.txtIBTaxAditionalCode.Tag = "CUSTOMER/IBTAXADITIONAL/CODE"
        '
        'txtIBTaxCode
        '
        Me.txtIBTaxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIBTaxCode.Location = New System.Drawing.Point(143, 54)
        Me.txtIBTaxCode.Name = "txtIBTaxCode"
        Me.txtIBTaxCode.ReadOnly = True
        Me.txtIBTaxCode.Size = New System.Drawing.Size(77, 23)
        Me.txtIBTaxCode.TabIndex = 37
        Me.txtIBTaxCode.Tag = "CUSTOMER/IBTAX/CODE"
        '
        'lblIBIBTaxAditionalCode
        '
        Me.lblIBIBTaxAditionalCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBIBTaxAditionalCode.Location = New System.Drawing.Point(13, 86)
        Me.lblIBIBTaxAditionalCode.Name = "lblIBIBTaxAditionalCode"
        Me.lblIBIBTaxAditionalCode.Size = New System.Drawing.Size(124, 23)
        Me.lblIBIBTaxAditionalCode.TabIndex = 38
        Me.lblIBIBTaxAditionalCode.Tag = "CUSTOMER/IBTAXADITIONAL/CODE"
        Me.lblIBIBTaxAditionalCode.Text = "ALICUOTA ADICIONAL"
        Me.lblIBIBTaxAditionalCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkIBCalc
        '
        Me.chkIBCalc.AutoSize = True
        Me.chkIBCalc.Enabled = False
        Me.chkIBCalc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIBCalc.Location = New System.Drawing.Point(16, 25)
        Me.chkIBCalc.Name = "chkIBCalc"
        Me.chkIBCalc.Size = New System.Drawing.Size(71, 19)
        Me.chkIBCalc.TabIndex = 35
        Me.chkIBCalc.Tag = "CUSTOMER/IBCALC"
        Me.chkIBCalc.Text = "LIQUIDA"
        Me.chkIBCalc.UseVisualStyleBackColor = True
        '
        'lblIBTaxCode
        '
        Me.lblIBTaxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBTaxCode.Location = New System.Drawing.Point(13, 54)
        Me.lblIBTaxCode.Name = "lblIBTaxCode"
        Me.lblIBTaxCode.Size = New System.Drawing.Size(124, 23)
        Me.lblIBTaxCode.TabIndex = 36
        Me.lblIBTaxCode.Tag = "CUSTOMER/IBTAX/CODE"
        Me.lblIBTaxCode.Text = "ALICUOTA FIJA"
        Me.lblIBTaxCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupIva
        '
        Me.GroupIva.Controls.Add(Me.txtNCTaxCode)
        Me.GroupIva.Controls.Add(Me.lblNCTaxCode)
        Me.GroupIva.Controls.Add(Me.txtIVAExclusionPercent)
        Me.GroupIva.Controls.Add(Me.lblIVAExclusionPercent)
        Me.GroupIva.Controls.Add(Me.txtIVAFreePercent)
        Me.GroupIva.Controls.Add(Me.lblIVAFreePercent)
        Me.GroupIva.Controls.Add(Me.chkIVAFree)
        Me.GroupIva.Controls.Add(Me.chkIVAPlus)
        Me.GroupIva.Controls.Add(Me.txtIVACategory)
        Me.GroupIva.Controls.Add(Me.lblIVACategory)
        Me.GroupIva.Location = New System.Drawing.Point(15, 137)
        Me.GroupIva.Name = "GroupIva"
        Me.GroupIva.Size = New System.Drawing.Size(384, 186)
        Me.GroupIva.TabIndex = 44
        Me.GroupIva.TabStop = False
        Me.GroupIva.Text = "I.V.A."
        '
        'txtNCTaxCode
        '
        Me.txtNCTaxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCTaxCode.Location = New System.Drawing.Point(145, 138)
        Me.txtNCTaxCode.Name = "txtNCTaxCode"
        Me.txtNCTaxCode.ReadOnly = True
        Me.txtNCTaxCode.Size = New System.Drawing.Size(77, 23)
        Me.txtNCTaxCode.TabIndex = 34
        Me.txtNCTaxCode.Tag = "CUSTOMER/NCTAX/CODE"
        '
        'lblNCTaxCode
        '
        Me.lblNCTaxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNCTaxCode.Location = New System.Drawing.Point(15, 138)
        Me.lblNCTaxCode.Name = "lblNCTaxCode"
        Me.lblNCTaxCode.Size = New System.Drawing.Size(124, 23)
        Me.lblNCTaxCode.TabIndex = 33
        Me.lblNCTaxCode.Tag = "CUSTOMER/NCTAX/CODE"
        Me.lblNCTaxCode.Text = "NO CATEGORIZADO"
        Me.lblNCTaxCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIVAExclusionPercent
        '
        Me.txtIVAExclusionPercent.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAExclusionPercent.Location = New System.Drawing.Point(145, 109)
        Me.txtIVAExclusionPercent.Name = "txtIVAExclusionPercent"
        Me.txtIVAExclusionPercent.ReadOnly = True
        Me.txtIVAExclusionPercent.Size = New System.Drawing.Size(77, 23)
        Me.txtIVAExclusionPercent.TabIndex = 32
        Me.txtIVAExclusionPercent.Tag = "CUSTOMER/IVAEXCLUSIONPERCENT"
        '
        'lblIVAExclusionPercent
        '
        Me.lblIVAExclusionPercent.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAExclusionPercent.Location = New System.Drawing.Point(15, 109)
        Me.lblIVAExclusionPercent.Name = "lblIVAExclusionPercent"
        Me.lblIVAExclusionPercent.Size = New System.Drawing.Size(124, 23)
        Me.lblIVAExclusionPercent.TabIndex = 31
        Me.lblIVAExclusionPercent.Tag = "CUSTOMER/IVAEXCLUSIONPERCENT"
        Me.lblIVAExclusionPercent.Text = "PORC. EXCLUSION"
        Me.lblIVAExclusionPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIVAFreePercent
        '
        Me.txtIVAFreePercent.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAFreePercent.Location = New System.Drawing.Point(145, 77)
        Me.txtIVAFreePercent.Name = "txtIVAFreePercent"
        Me.txtIVAFreePercent.ReadOnly = True
        Me.txtIVAFreePercent.Size = New System.Drawing.Size(77, 23)
        Me.txtIVAFreePercent.TabIndex = 30
        Me.txtIVAFreePercent.Tag = "CUSTOMER/IVAFREEPERCENT"
        '
        'lblIVAFreePercent
        '
        Me.lblIVAFreePercent.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAFreePercent.Location = New System.Drawing.Point(15, 77)
        Me.lblIVAFreePercent.Name = "lblIVAFreePercent"
        Me.lblIVAFreePercent.Size = New System.Drawing.Size(124, 23)
        Me.lblIVAFreePercent.TabIndex = 29
        Me.lblIVAFreePercent.Tag = "CUSTOMER/IVAFREEPERCENT"
        Me.lblIVAFreePercent.Text = "PORC. LIBERACION"
        Me.lblIVAFreePercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkIVAFree
        '
        Me.chkIVAFree.AutoSize = True
        Me.chkIVAFree.Enabled = False
        Me.chkIVAFree.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIVAFree.Location = New System.Drawing.Point(200, 48)
        Me.chkIVAFree.Name = "chkIVAFree"
        Me.chkIVAFree.Size = New System.Drawing.Size(109, 19)
        Me.chkIVAFree.TabIndex = 22
        Me.chkIVAFree.Tag = "CUSTOMER/IVAFREE"
        Me.chkIVAFree.Text = "I.V.A. LIBERADO"
        Me.chkIVAFree.UseVisualStyleBackColor = True
        '
        'chkIVAPlus
        '
        Me.chkIVAPlus.AutoSize = True
        Me.chkIVAPlus.Enabled = False
        Me.chkIVAPlus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIVAPlus.Location = New System.Drawing.Point(18, 48)
        Me.chkIVAPlus.Name = "chkIVAPlus"
        Me.chkIVAPlus.Size = New System.Drawing.Size(160, 19)
        Me.chkIVAPlus.TabIndex = 21
        Me.chkIVAPlus.Tag = "CUSTOMER/IVAPLUS"
        Me.chkIVAPlus.Text = "SOBRE/SUBTASA DE I.V.A."
        Me.chkIVAPlus.UseVisualStyleBackColor = True
        '
        'txtIVACategory
        '
        Me.txtIVACategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACategory.Location = New System.Drawing.Point(145, 19)
        Me.txtIVACategory.Name = "txtIVACategory"
        Me.txtIVACategory.ReadOnly = True
        Me.txtIVACategory.Size = New System.Drawing.Size(223, 23)
        Me.txtIVACategory.TabIndex = 20
        Me.txtIVACategory.Tag = "CUSTOMER/IVACATEGORY"
        '
        'lblIVACategory
        '
        Me.lblIVACategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVACategory.Location = New System.Drawing.Point(14, 19)
        Me.lblIVACategory.Name = "lblIVACategory"
        Me.lblIVACategory.Size = New System.Drawing.Size(125, 23)
        Me.lblIVACategory.TabIndex = 19
        Me.lblIVACategory.Tag = "CUSTOMER/IVACATEGORY"
        Me.lblIVACategory.Text = "CONDICION DE I.V.A."
        Me.lblIVACategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmployeeCode
        '
        Me.txtEmployeeCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeCode.Location = New System.Drawing.Point(172, 100)
        Me.txtEmployeeCode.Name = "txtEmployeeCode"
        Me.txtEmployeeCode.ReadOnly = True
        Me.txtEmployeeCode.Size = New System.Drawing.Size(49, 23)
        Me.txtEmployeeCode.TabIndex = 43
        Me.txtEmployeeCode.Tag = "CUSTOMER/EMPLOYEE/CODE"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(227, 100)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(466, 23)
        Me.txtEmployeeName.TabIndex = 42
        Me.txtEmployeeName.Tag = "CUSTOMER/EMPLOYEE/NAME"
        '
        'txtSalesTermsCode
        '
        Me.txtSalesTermsCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesTermsCode.Location = New System.Drawing.Point(171, 71)
        Me.txtSalesTermsCode.Name = "txtSalesTermsCode"
        Me.txtSalesTermsCode.ReadOnly = True
        Me.txtSalesTermsCode.Size = New System.Drawing.Size(49, 23)
        Me.txtSalesTermsCode.TabIndex = 41
        Me.txtSalesTermsCode.Tag = "CUSTOMER/SALESTERM/CODE"
        '
        'txtSalesTermsName
        '
        Me.txtSalesTermsName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesTermsName.Location = New System.Drawing.Point(226, 71)
        Me.txtSalesTermsName.Name = "txtSalesTermsName"
        Me.txtSalesTermsName.ReadOnly = True
        Me.txtSalesTermsName.Size = New System.Drawing.Size(466, 23)
        Me.txtSalesTermsName.TabIndex = 40
        Me.txtSalesTermsName.Tag = "CUSTOMER/SALESTERM/NAME"
        '
        'txtCurrencyName
        '
        Me.txtCurrencyName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrencyName.Location = New System.Drawing.Point(172, 42)
        Me.txtCurrencyName.Name = "txtCurrencyName"
        Me.txtCurrencyName.ReadOnly = True
        Me.txtCurrencyName.Size = New System.Drawing.Size(197, 23)
        Me.txtCurrencyName.TabIndex = 38
        Me.txtCurrencyName.Tag = "CUSTOMER/CURRENCY/NAME"
        '
        'lblExchange
        '
        Me.lblExchange.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExchange.Location = New System.Drawing.Point(30, 41)
        Me.lblExchange.Name = "lblExchange"
        Me.lblExchange.Size = New System.Drawing.Size(100, 23)
        Me.lblExchange.TabIndex = 37
        Me.lblExchange.Tag = "CUSTOMER/CURRENCY/CODE"
        Me.lblExchange.Text = "MONEDA"
        Me.lblExchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIBNumber
        '
        Me.txtIBNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIBNumber.Location = New System.Drawing.Point(495, 12)
        Me.txtIBNumber.Name = "txtIBNumber"
        Me.txtIBNumber.ReadOnly = True
        Me.txtIBNumber.Size = New System.Drawing.Size(197, 23)
        Me.txtIBNumber.TabIndex = 36
        Me.txtIBNumber.Tag = "CUSTOMER/IBNUMBER"
        '
        'lblIBNumber
        '
        Me.lblIBNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBNumber.Location = New System.Drawing.Point(389, 12)
        Me.lblIBNumber.Name = "lblIBNumber"
        Me.lblIBNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblIBNumber.TabIndex = 35
        Me.lblIBNumber.Tag = "CUSTOMER/IBNUMBER"
        Me.lblIBNumber.Text = "Nº ING. BRUTOS"
        Me.lblIBNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.Location = New System.Drawing.Point(171, 13)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.ReadOnly = True
        Me.txtCuit.Size = New System.Drawing.Size(197, 23)
        Me.txtCuit.TabIndex = 34
        Me.txtCuit.Tag = "CUSTOMER/CUIT"
        '
        'lblCuit
        '
        Me.lblCuit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuit.Location = New System.Drawing.Point(29, 12)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(100, 23)
        Me.lblCuit.TabIndex = 33
        Me.lblCuit.Tag = "CUSTOMER/CUIT"
        Me.lblCuit.Text = "C.U.I.T"
        Me.lblCuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployee
        '
        Me.lblEmployee.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(30, 100)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee.TabIndex = 31
        Me.lblEmployee.Tag = "CUSTOMER/EMPLOYEE/CODE"
        Me.lblEmployee.Text = "VENDEDOR"
        Me.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalesTerms
        '
        Me.lblSalesTerms.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTerms.Location = New System.Drawing.Point(30, 71)
        Me.lblSalesTerms.Name = "lblSalesTerms"
        Me.lblSalesTerms.Size = New System.Drawing.Size(100, 23)
        Me.lblSalesTerms.TabIndex = 29
        Me.lblSalesTerms.Tag = "CUSTOMER/SALESTERM/CODE"
        Me.lblSalesTerms.Text = "FORMA DE PAGO"
        Me.lblSalesTerms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(495, 41)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(197, 23)
        Me.txtDiscount.TabIndex = 28
        Me.txtDiscount.Tag = "CUSTOMER/DISCOUNTPERCENT"
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(389, 42)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 27
        Me.lblDiscount.Tag = "CUSTOMER/DISCOUNTPERCENT"
        Me.lblDiscount.Text = "DESCUENTO"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlAdress
        '
        Me.pnlAdress.Controls.Add(Me.txtZoneCode)
        Me.pnlAdress.Controls.Add(Me.txtZoneName)
        Me.pnlAdress.Controls.Add(Me.lblZone)
        Me.pnlAdress.Controls.Add(Me.txtStateCode)
        Me.pnlAdress.Controls.Add(Me.txtStateName)
        Me.pnlAdress.Controls.Add(Me.lblState)
        Me.pnlAdress.Controls.Add(Me.txtCity)
        Me.pnlAdress.Controls.Add(Me.lblCity)
        Me.pnlAdress.Controls.Add(Me.txtZipCode)
        Me.pnlAdress.Controls.Add(Me.lblZipCode)
        Me.pnlAdress.Controls.Add(Me.txtWeb)
        Me.pnlAdress.Controls.Add(Me.lblWeb)
        Me.pnlAdress.Controls.Add(Me.txtMail)
        Me.pnlAdress.Controls.Add(Me.lblMail)
        Me.pnlAdress.Controls.Add(Me.txtFax)
        Me.pnlAdress.Controls.Add(Me.lblFax)
        Me.pnlAdress.Controls.Add(Me.txtPhone)
        Me.pnlAdress.Controls.Add(Me.lblPhone)
        Me.pnlAdress.Controls.Add(Me.txtAdress)
        Me.pnlAdress.Controls.Add(Me.lblAdress)
        Me.pnlAdress.Location = New System.Drawing.Point(3, 8)
        Me.pnlAdress.Name = "pnlAdress"
        Me.pnlAdress.Size = New System.Drawing.Size(704, 264)
        Me.pnlAdress.TabIndex = 22
        '
        'txtZoneCode
        '
        Me.txtZoneCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZoneCode.Location = New System.Drawing.Point(171, 116)
        Me.txtZoneCode.Name = "txtZoneCode"
        Me.txtZoneCode.ReadOnly = True
        Me.txtZoneCode.Size = New System.Drawing.Size(49, 23)
        Me.txtZoneCode.TabIndex = 34
        Me.txtZoneCode.Tag = "CUSTOMER/ZONE/CODE"
        '
        'txtZoneName
        '
        Me.txtZoneName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZoneName.Location = New System.Drawing.Point(226, 116)
        Me.txtZoneName.Name = "txtZoneName"
        Me.txtZoneName.ReadOnly = True
        Me.txtZoneName.Size = New System.Drawing.Size(466, 23)
        Me.txtZoneName.TabIndex = 33
        Me.txtZoneName.Tag = "CUSTOMER/ZONE/NAME"
        '
        'lblZone
        '
        Me.lblZone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.Location = New System.Drawing.Point(29, 115)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(100, 23)
        Me.lblZone.TabIndex = 32
        Me.lblZone.Tag = "CUSTOMER/ZONE/CODE"
        Me.lblZone.Text = "ZONA"
        Me.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStateCode
        '
        Me.txtStateCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateCode.Location = New System.Drawing.Point(171, 84)
        Me.txtStateCode.Name = "txtStateCode"
        Me.txtStateCode.ReadOnly = True
        Me.txtStateCode.Size = New System.Drawing.Size(49, 23)
        Me.txtStateCode.TabIndex = 31
        Me.txtStateCode.Tag = "CUSTOMER/STATE/CODE"
        '
        'txtStateName
        '
        Me.txtStateName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateName.Location = New System.Drawing.Point(226, 84)
        Me.txtStateName.Name = "txtStateName"
        Me.txtStateName.ReadOnly = True
        Me.txtStateName.Size = New System.Drawing.Size(466, 23)
        Me.txtStateName.TabIndex = 30
        Me.txtStateName.Tag = "CUSTOMER/STATE/NAME"
        '
        'lblState
        '
        Me.lblState.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(29, 83)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(100, 23)
        Me.lblState.TabIndex = 29
        Me.lblState.Tag = "CUSTOMER/STATE/CODE"
        Me.lblState.Text = "PROVINCIA"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(171, 55)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(197, 23)
        Me.txtCity.TabIndex = 28
        Me.txtCity.Tag = "CUSTOMER/CITY"
        '
        'lblCity
        '
        Me.lblCity.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(29, 54)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(100, 23)
        Me.lblCity.TabIndex = 27
        Me.lblCity.Tag = "CUSTOMER/CITY"
        Me.lblCity.Text = "LOCALIDAD"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(495, 56)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.Size = New System.Drawing.Size(197, 23)
        Me.txtZipCode.TabIndex = 26
        Me.txtZipCode.Tag = "CUSTOMER/ZIPCODE"
        '
        'lblZipCode
        '
        Me.lblZipCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(389, 55)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(100, 23)
        Me.lblZipCode.TabIndex = 25
        Me.lblZipCode.Tag = "CUSTOMER/ZIPCODE"
        Me.lblZipCode.Text = "COD. POSTAL"
        Me.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWeb
        '
        Me.txtWeb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.Location = New System.Drawing.Point(171, 222)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.ReadOnly = True
        Me.txtWeb.Size = New System.Drawing.Size(521, 23)
        Me.txtWeb.TabIndex = 24
        Me.txtWeb.Tag = "CUSTOMER/WEB"
        '
        'lblWeb
        '
        Me.lblWeb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.Location = New System.Drawing.Point(29, 221)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(100, 23)
        Me.lblWeb.TabIndex = 23
        Me.lblWeb.Tag = "CUSTOMER/WEB"
        Me.lblWeb.Text = "WEB"
        Me.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(171, 183)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ReadOnly = True
        Me.txtMail.Size = New System.Drawing.Size(521, 23)
        Me.txtMail.TabIndex = 22
        Me.txtMail.Tag = "CUSTOMER/MAIL"
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(29, 182)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(100, 23)
        Me.lblMail.TabIndex = 21
        Me.lblMail.Tag = "CUSTOMER/MAIL"
        Me.lblMail.Text = "EMAIL"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(495, 145)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(197, 23)
        Me.txtFax.TabIndex = 20
        Me.txtFax.Tag = "CUSTOMER/FAX"
        '
        'lblFax
        '
        Me.lblFax.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(389, 145)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(100, 23)
        Me.lblFax.TabIndex = 19
        Me.lblFax.Tag = "CUSTOMER/FAX"
        Me.lblFax.Text = "FAX"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(171, 144)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(197, 23)
        Me.txtPhone.TabIndex = 18
        Me.txtPhone.Tag = "CUSTOMER/PHONE"
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(29, 144)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 23)
        Me.lblPhone.TabIndex = 17
        Me.lblPhone.Tag = "CUSTOMER/PHONE"
        Me.lblPhone.Text = "TELEFONO"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdress
        '
        Me.txtAdress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(171, 23)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.ReadOnly = True
        Me.txtAdress.Size = New System.Drawing.Size(521, 23)
        Me.txtAdress.TabIndex = 16
        Me.txtAdress.Tag = "CUSTOMER/ADRESS"
        '
        'lblAdress
        '
        Me.lblAdress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdress.Location = New System.Drawing.Point(29, 23)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(100, 23)
        Me.lblAdress.TabIndex = 15
        Me.lblAdress.Tag = "CUSTOMER/ADRESS"
        Me.lblAdress.Text = "DOMICILIO"
        Me.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBasic
        '
        Me.pnlBasic.Controls.Add(Me.txtGroupName)
        Me.pnlBasic.Controls.Add(Me.txtGroupCode)
        Me.pnlBasic.Controls.Add(Me.lblGroup)
        Me.pnlBasic.Controls.Add(Me.txtCode)
        Me.pnlBasic.Controls.Add(Me.lblCode)
        Me.pnlBasic.Controls.Add(Me.lblLegalName)
        Me.pnlBasic.Controls.Add(Me.txtLegalName)
        Me.pnlBasic.Controls.Add(Me.lblName)
        Me.pnlBasic.Controls.Add(Me.txtName)
        Me.pnlBasic.Location = New System.Drawing.Point(6, 10)
        Me.pnlBasic.Name = "pnlBasic"
        Me.pnlBasic.Size = New System.Drawing.Size(688, 153)
        Me.pnlBasic.TabIndex = 22
        '
        'txtGroupName
        '
        Me.txtGroupName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.Location = New System.Drawing.Point(226, 103)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.ReadOnly = True
        Me.txtGroupName.Size = New System.Drawing.Size(466, 23)
        Me.txtGroupName.TabIndex = 33
        Me.txtGroupName.Tag = "CUSTOMER/GROUP/NAME"
        '
        'txtGroupCode
        '
        Me.txtGroupCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupCode.Location = New System.Drawing.Point(171, 104)
        Me.txtGroupCode.Name = "txtGroupCode"
        Me.txtGroupCode.ReadOnly = True
        Me.txtGroupCode.Size = New System.Drawing.Size(49, 23)
        Me.txtGroupCode.TabIndex = 32
        Me.txtGroupCode.Tag = "CUSTOMER/GROUP/CODE"
        '
        'lblGroup
        '
        Me.lblGroup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.Location = New System.Drawing.Point(29, 103)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(136, 23)
        Me.lblGroup.TabIndex = 9
        Me.lblGroup.Tag = "CUSTOMER/GROUP/CODE"
        Me.lblGroup.Text = "GRUPO EMPRESARIO"
        Me.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(171, 16)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(137, 23)
        Me.txtCode.TabIndex = 2
        Me.txtCode.Tag = "CUSTOMER/CODE"
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(29, 16)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(100, 23)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Tag = "CUSTOMER/CODE"
        Me.lblCode.Text = "CODIGO"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLegalName
        '
        Me.lblLegalName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegalName.Location = New System.Drawing.Point(29, 45)
        Me.lblLegalName.Name = "lblLegalName"
        Me.lblLegalName.Size = New System.Drawing.Size(100, 23)
        Me.lblLegalName.TabIndex = 3
        Me.lblLegalName.Tag = "CUSTOMER/LEGALNAME"
        Me.lblLegalName.Text = "RAZON SOCIAL"
        Me.lblLegalName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLegalName
        '
        Me.txtLegalName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLegalName.Location = New System.Drawing.Point(171, 45)
        Me.txtLegalName.Name = "txtLegalName"
        Me.txtLegalName.ReadOnly = True
        Me.txtLegalName.Size = New System.Drawing.Size(521, 23)
        Me.txtLegalName.TabIndex = 4
        Me.txtLegalName.Tag = "CUSTOMER/LEGALNAME"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(29, 74)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 23)
        Me.lblName.TabIndex = 7
        Me.lblName.Tag = "CUSTOMER/NAME"
        Me.lblName.Text = "NOMBRE COMERCIAL"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(171, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(521, 23)
        Me.txtName.TabIndex = 8
        Me.txtName.Tag = "CUSTOMER/NAME"
        '
        'pnlDelivery
        '
        Me.pnlDelivery.Controls.Add(Me.txtTranspCode)
        Me.pnlDelivery.Controls.Add(Me.txtTranspName)
        Me.pnlDelivery.Controls.Add(Me.lblTransp)
        Me.pnlDelivery.Controls.Add(Me.txtHours)
        Me.pnlDelivery.Controls.Add(Me.lblHours)
        Me.pnlDelivery.Controls.Add(Me.txtDeliveryAdress)
        Me.pnlDelivery.Controls.Add(Me.lblDeliveryAdress)
        Me.pnlDelivery.Location = New System.Drawing.Point(6, 31)
        Me.pnlDelivery.Name = "pnlDelivery"
        Me.pnlDelivery.Size = New System.Drawing.Size(704, 106)
        Me.pnlDelivery.TabIndex = 23
        '
        'txtTranspCode
        '
        Me.txtTranspCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranspCode.Location = New System.Drawing.Point(171, 76)
        Me.txtTranspCode.Name = "txtTranspCode"
        Me.txtTranspCode.ReadOnly = True
        Me.txtTranspCode.Size = New System.Drawing.Size(49, 23)
        Me.txtTranspCode.TabIndex = 36
        Me.txtTranspCode.Tag = "CUSTOMER/TRANSPORT/CODE"
        '
        'txtTranspName
        '
        Me.txtTranspName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranspName.Location = New System.Drawing.Point(226, 76)
        Me.txtTranspName.Name = "txtTranspName"
        Me.txtTranspName.ReadOnly = True
        Me.txtTranspName.Size = New System.Drawing.Size(466, 23)
        Me.txtTranspName.TabIndex = 35
        Me.txtTranspName.Tag = "CUSTOMER/TRANSPORT/NAME"
        '
        'lblTransp
        '
        Me.lblTransp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransp.Location = New System.Drawing.Point(29, 76)
        Me.lblTransp.Name = "lblTransp"
        Me.lblTransp.Size = New System.Drawing.Size(100, 23)
        Me.lblTransp.TabIndex = 25
        Me.lblTransp.Tag = "CUSTOMER/TRANSPORT/CODE"
        Me.lblTransp.Text = "TRANSPORTE"
        Me.lblTransp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(171, 47)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.ReadOnly = True
        Me.txtHours.Size = New System.Drawing.Size(521, 23)
        Me.txtHours.TabIndex = 24
        Me.txtHours.Tag = "CUSTOMER/HOURS"
        '
        'lblHours
        '
        Me.lblHours.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(29, 47)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(100, 23)
        Me.lblHours.TabIndex = 23
        Me.lblHours.Tag = "CUSTOMER/HOURS"
        Me.lblHours.Text = "HORARIO"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDeliveryAdress
        '
        Me.txtDeliveryAdress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryAdress.Location = New System.Drawing.Point(171, 18)
        Me.txtDeliveryAdress.Name = "txtDeliveryAdress"
        Me.txtDeliveryAdress.ReadOnly = True
        Me.txtDeliveryAdress.Size = New System.Drawing.Size(521, 23)
        Me.txtDeliveryAdress.TabIndex = 22
        Me.txtDeliveryAdress.Tag = "CUSTOMER/DELIVERYADRESS"
        '
        'lblDeliveryAdress
        '
        Me.lblDeliveryAdress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryAdress.Location = New System.Drawing.Point(29, 18)
        Me.lblDeliveryAdress.Name = "lblDeliveryAdress"
        Me.lblDeliveryAdress.Size = New System.Drawing.Size(100, 23)
        Me.lblDeliveryAdress.TabIndex = 21
        Me.lblDeliveryAdress.Tag = "CUSTOMER/DELIVERYADRESS"
        Me.lblDeliveryAdress.Text = "DOMICILIO"
        Me.lblDeliveryAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Browser
        '
        Me.Browser.ContextMenuStrip = Me.BrowserMenu
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAdd, Me.BrowserDelete, Me.BrowserEdit, Me.BrowserSeparator1, Me.BrowserFirst, Me.BrowserPrevious, Me.BrowserNext, Me.BrowserLast, Me.BrowserSeparator2, Me.BrowserSearch, Me.BrowserList, Me.BrowserRefresh})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(842, 31)
        Me.Browser.TabIndex = 37
        Me.Browser.Text = "ToolStrip1"
        '
        'BrowserMenu
        '
        Me.BrowserMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserMenuView})
        Me.BrowserMenu.Name = "BrowserMenu"
        Me.BrowserMenu.Size = New System.Drawing.Size(102, 26)
        '
        'BrowserMenuView
        '
        Me.BrowserMenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserMenuViewLargeIcons, Me.BrowserMenuViewSmallIcons})
        Me.BrowserMenuView.Name = "BrowserMenuView"
        Me.BrowserMenuView.Size = New System.Drawing.Size(101, 22)
        Me.BrowserMenuView.Text = "Ver"
        '
        'BrowserMenuViewLargeIcons
        '
        Me.BrowserMenuViewLargeIcons.Checked = True
        Me.BrowserMenuViewLargeIcons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BrowserMenuViewLargeIcons.Name = "BrowserMenuViewLargeIcons"
        Me.BrowserMenuViewLargeIcons.Size = New System.Drawing.Size(167, 22)
        Me.BrowserMenuViewLargeIcons.Text = "Iconos grandes"
        '
        'BrowserMenuViewSmallIcons
        '
        Me.BrowserMenuViewSmallIcons.Name = "BrowserMenuViewSmallIcons"
        Me.BrowserMenuViewSmallIcons.Size = New System.Drawing.Size(167, 22)
        Me.BrowserMenuViewSmallIcons.Text = "Iconos pequeños"
        '
        'BrowserAdd
        '
        Me.BrowserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAdd.Image = Global.Crm.UI.My.Resources.Resources.add
        Me.BrowserAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAdd.Name = "BrowserAdd"
        Me.BrowserAdd.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAdd.Text = "Añadir registro"
        '
        'BrowserDelete
        '
        Me.BrowserDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserDelete.Image = Global.Crm.UI.My.Resources.Resources.delete
        Me.BrowserDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserDelete.Name = "BrowserDelete"
        Me.BrowserDelete.Size = New System.Drawing.Size(28, 28)
        Me.BrowserDelete.Text = "Eliminar registro"
        Me.BrowserDelete.Visible = False
        '
        'BrowserEdit
        '
        Me.BrowserEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserEdit.Image = Global.Crm.UI.My.Resources.Resources.up
        Me.BrowserEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserEdit.Name = "BrowserEdit"
        Me.BrowserEdit.Size = New System.Drawing.Size(28, 28)
        Me.BrowserEdit.Text = "Modifica el registro"
        '
        'BrowserSeparator1
        '
        Me.BrowserSeparator1.Name = "BrowserSeparator1"
        Me.BrowserSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BrowserFirst
        '
        Me.BrowserFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserFirst.Image = Global.Crm.UI.My.Resources.Resources.First
        Me.BrowserFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserFirst.Name = "BrowserFirst"
        Me.BrowserFirst.Size = New System.Drawing.Size(28, 28)
        Me.BrowserFirst.Text = "Primer registro"
        '
        'BrowserPrevious
        '
        Me.BrowserPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserPrevious.Image = Global.Crm.UI.My.Resources.Resources.previous
        Me.BrowserPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserPrevious.Name = "BrowserPrevious"
        Me.BrowserPrevious.Size = New System.Drawing.Size(28, 28)
        Me.BrowserPrevious.Text = "Registro anterior"
        '
        'BrowserNext
        '
        Me.BrowserNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserNext.Image = Global.Crm.UI.My.Resources.Resources._next
        Me.BrowserNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserNext.Name = "BrowserNext"
        Me.BrowserNext.Size = New System.Drawing.Size(28, 28)
        Me.BrowserNext.Text = "Próximo registro"
        '
        'BrowserLast
        '
        Me.BrowserLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserLast.Image = Global.Crm.UI.My.Resources.Resources.Last
        Me.BrowserLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserLast.Name = "BrowserLast"
        Me.BrowserLast.Size = New System.Drawing.Size(28, 28)
        Me.BrowserLast.Text = "Último registro"
        '
        'BrowserSeparator2
        '
        Me.BrowserSeparator2.Name = "BrowserSeparator2"
        Me.BrowserSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BrowserSearch
        '
        Me.BrowserSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserSearch.Image = Global.Crm.UI.My.Resources.Resources.search
        Me.BrowserSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserSearch.Name = "BrowserSearch"
        Me.BrowserSearch.Size = New System.Drawing.Size(28, 28)
        Me.BrowserSearch.Text = "Buscar registro"
        '
        'BrowserList
        '
        Me.BrowserList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserList.Image = Global.Crm.UI.My.Resources.Resources.List
        Me.BrowserList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserList.Name = "BrowserList"
        Me.BrowserList.Size = New System.Drawing.Size(28, 28)
        Me.BrowserList.Text = "Listar"
        Me.BrowserList.Visible = False
        '
        'BrowserRefresh
        '
        Me.BrowserRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserRefresh.Image = Global.Crm.UI.My.Resources.Resources.Refresh
        Me.BrowserRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserRefresh.Name = "BrowserRefresh"
        Me.BrowserRefresh.Size = New System.Drawing.Size(28, 28)
        Me.BrowserRefresh.Text = "Actualiza el registro"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(842, 58)
        Me.lblTitle.TabIndex = 38
        Me.lblTitle.Text = "010001 - DISTRIBUIDORA LOMBARDI"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlContacts
        '
        Me.pnlContacts.Controls.Add(Me.GridContacts)
        Me.pnlContacts.Location = New System.Drawing.Point(3, 12)
        Me.pnlContacts.Name = "pnlContacts"
        Me.pnlContacts.Size = New System.Drawing.Size(704, 264)
        Me.pnlContacts.TabIndex = 35
        '
        'GridContacts
        '
        Me.GridContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.GridContacts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridContacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridContacts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DEPARTMENT, Me.POSITION, Me.FIRSTNAME, Me.LASTNAME, Me.PHONE, Me.FAX, Me.MAIL, Me.MAIL2, Me.BIRTHDAY})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridContacts.DefaultCellStyle = DataGridViewCellStyle1
        Me.GridContacts.GridColor = System.Drawing.SystemColors.Control
        Me.GridContacts.Location = New System.Drawing.Point(-3, 131)
        Me.GridContacts.Name = "GridContacts"
        Me.GridContacts.ReadOnly = True
        Me.GridContacts.RowHeadersVisible = False
        Me.GridContacts.RowHeadersWidth = 35
        Me.GridContacts.RowTemplate.DividerHeight = 5
        Me.GridContacts.RowTemplate.Height = 30
        Me.GridContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridContacts.Size = New System.Drawing.Size(707, 196)
        Me.GridContacts.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.HeaderText = "AREA"
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.ReadOnly = True
        '
        'POSITION
        '
        Me.POSITION.HeaderText = "CARGO"
        Me.POSITION.Name = "POSITION"
        Me.POSITION.ReadOnly = True
        '
        'FIRSTNAME
        '
        Me.FIRSTNAME.HeaderText = "NOMBRE"
        Me.FIRSTNAME.Name = "FIRSTNAME"
        Me.FIRSTNAME.ReadOnly = True
        '
        'LASTNAME
        '
        Me.LASTNAME.HeaderText = "APELLIDO"
        Me.LASTNAME.Name = "LASTNAME"
        Me.LASTNAME.ReadOnly = True
        '
        'PHONE
        '
        Me.PHONE.HeaderText = "TELEFONO"
        Me.PHONE.Name = "PHONE"
        Me.PHONE.ReadOnly = True
        '
        'FAX
        '
        Me.FAX.HeaderText = "FAX"
        Me.FAX.Name = "FAX"
        Me.FAX.ReadOnly = True
        '
        'MAIL
        '
        Me.MAIL.HeaderText = "MAIL"
        Me.MAIL.Name = "MAIL"
        Me.MAIL.ReadOnly = True
        '
        'MAIL2
        '
        Me.MAIL2.HeaderText = "MAIL ALT."
        Me.MAIL2.Name = "MAIL2"
        Me.MAIL2.ReadOnly = True
        '
        'BIRTHDAY
        '
        Me.BIRTHDAY.HeaderText = "FECHA. NAC"
        Me.BIRTHDAY.Name = "BIRTHDAY"
        Me.BIRTHDAY.ReadOnly = True
        '
        'pnlAttachments
        '
        Me.pnlAttachments.Controls.Add(Me.FileList)
        Me.pnlAttachments.Location = New System.Drawing.Point(69, 160)
        Me.pnlAttachments.Name = "pnlAttachments"
        Me.pnlAttachments.Size = New System.Drawing.Size(704, 264)
        Me.pnlAttachments.TabIndex = 39
        '
        'FileList
        '
        Me.FileList.AllowDrop = True
        Me.FileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileList.HideSelection = False
        Me.FileList.LargeImageList = Me.IList
        Me.FileList.Location = New System.Drawing.Point(0, 0)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(704, 264)
        Me.FileList.TabIndex = 40
        Me.FileList.UseCompatibleStateImageBehavior = False
        '
        'IList
        '
        Me.IList.ImageStream = CType(resources.GetObject("IList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IList.TransparentColor = System.Drawing.Color.Transparent
        Me.IList.Images.SetKeyName(0, "CLIP.png")
        '
        'pnlTasks
        '
        Me.pnlTasks.Controls.Add(Me.GridTaks)
        Me.pnlTasks.Location = New System.Drawing.Point(77, 168)
        Me.pnlTasks.Name = "pnlTasks"
        Me.pnlTasks.Size = New System.Drawing.Size(704, 264)
        Me.pnlTasks.TabIndex = 40
        '
        'GridTaks
        '
        Me.GridTaks.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridTaks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridTaks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTaks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DateInit, Me.LastDate, Me.TaskType, Me.TaskState, Me.TaskUser, Me.TaskPriority})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridTaks.DefaultCellStyle = DataGridViewCellStyle4
        Me.GridTaks.GridColor = System.Drawing.SystemColors.Control
        Me.GridTaks.Location = New System.Drawing.Point(29, 0)
        Me.GridTaks.Name = "GridTaks"
        Me.GridTaks.ReadOnly = True
        Me.GridTaks.RowHeadersVisible = False
        Me.GridTaks.RowTemplate.DividerHeight = 5
        Me.GridTaks.RowTemplate.Height = 30
        Me.GridTaks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridTaks.Size = New System.Drawing.Size(704, 264)
        Me.GridTaks.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DateInit
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DateInit.DefaultCellStyle = DataGridViewCellStyle2
        Me.DateInit.HeaderText = "INICIO"
        Me.DateInit.Name = "DateInit"
        Me.DateInit.ReadOnly = True
        '
        'LastDate
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.LastDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.LastDate.HeaderText = "ULT.ESTADO"
        Me.LastDate.Name = "LastDate"
        Me.LastDate.ReadOnly = True
        '
        'TaskType
        '
        Me.TaskType.HeaderText = "TIPO"
        Me.TaskType.Name = "TaskType"
        Me.TaskType.ReadOnly = True
        '
        'TaskState
        '
        Me.TaskState.HeaderText = "ESTADO"
        Me.TaskState.Name = "TaskState"
        Me.TaskState.ReadOnly = True
        '
        'TaskUser
        '
        Me.TaskUser.HeaderText = "RESPONSABLE"
        Me.TaskUser.Name = "TaskUser"
        Me.TaskUser.ReadOnly = True
        '
        'TaskPriority
        '
        Me.TaskPriority.HeaderText = "PRIORIDAD"
        Me.TaskPriority.Name = "TaskPriority"
        Me.TaskPriority.ReadOnly = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 584)
        Me.Controls.Add(Me.frmSplit)
        Me.Controls.Add(Me.pnlNotes)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.pnlAttachments)
        Me.Controls.Add(Me.pnlAdress)
        Me.Controls.Add(Me.pnlBasic)
        Me.Controls.Add(Me.pnlDelivery)
        Me.Controls.Add(Me.pnlContacts)
        Me.Controls.Add(Me.pnlTerms)
        Me.Controls.Add(Me.pnlTasks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCustomer"
        Me.Text = "Clientes"
        Me.pnlNotes.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.frmSplit.Panel1.ResumeLayout(False)
        Me.frmSplit.Panel1.PerformLayout()
        Me.frmSplit.ResumeLayout(False)
        Me.tsCustomer.ResumeLayout(False)
        Me.tsCustomer.PerformLayout()
        Me.pnlTerms.ResumeLayout(False)
        Me.pnlTerms.PerformLayout()
        Me.GroupIBB.ResumeLayout(False)
        Me.GroupIBB.PerformLayout()
        Me.GroupInternalTax.ResumeLayout(False)
        Me.GroupInternalTax.PerformLayout()
        Me.GroupIB.ResumeLayout(False)
        Me.GroupIB.PerformLayout()
        Me.GroupIva.ResumeLayout(False)
        Me.GroupIva.PerformLayout()
        Me.pnlAdress.ResumeLayout(False)
        Me.pnlAdress.PerformLayout()
        Me.pnlBasic.ResumeLayout(False)
        Me.pnlBasic.PerformLayout()
        Me.pnlDelivery.ResumeLayout(False)
        Me.pnlDelivery.PerformLayout()
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.BrowserMenu.ResumeLayout(False)
        Me.pnlContacts.ResumeLayout(False)
        CType(Me.GridContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAttachments.ResumeLayout(False)
        Me.pnlTasks.ResumeLayout(False)
        CType(Me.GridTaks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlNotes As System.Windows.Forms.Panel
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents tsCustomer As System.Windows.Forms.ToolStrip
    Friend WithEvents tbGeneral As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbAdress As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbDelivery As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbTerms As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbNotes As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlBasic As System.Windows.Forms.Panel
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents txtGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblLegalName As System.Windows.Forms.Label
    Friend WithEvents txtLegalName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents pnlDelivery As System.Windows.Forms.Panel
    Friend WithEvents txtTranspCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTranspName As System.Windows.Forms.TextBox
    Friend WithEvents lblTransp As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryAdress As System.Windows.Forms.TextBox
    Friend WithEvents lblDeliveryAdress As System.Windows.Forms.Label
    Friend WithEvents pnlTerms As System.Windows.Forms.Panel
    Friend WithEvents GroupIBB As System.Windows.Forms.GroupBox
    Friend WithEvents chkIBBInternalTax As System.Windows.Forms.CheckBox
    Friend WithEvents txtIBBTaxCode As System.Windows.Forms.TextBox
    Friend WithEvents lblIBBTaxCode As System.Windows.Forms.Label
    Friend WithEvents chkIBBCalc As System.Windows.Forms.CheckBox
    Friend WithEvents GroupInternalTax As System.Windows.Forms.GroupBox
    Friend WithEvents chkInternalTaxCalc As System.Windows.Forms.CheckBox
    Friend WithEvents chkInternalTaxDetail As System.Windows.Forms.CheckBox
    Friend WithEvents chkInternalTaxPlus As System.Windows.Forms.CheckBox
    Friend WithEvents GroupIB As System.Windows.Forms.GroupBox
    Friend WithEvents txtIBTaxAditionalCode As System.Windows.Forms.TextBox
    Friend WithEvents txtIBTaxCode As System.Windows.Forms.TextBox
    Friend WithEvents lblIBIBTaxAditionalCode As System.Windows.Forms.Label
    Friend WithEvents chkIBCalc As System.Windows.Forms.CheckBox
    Friend WithEvents lblIBTaxCode As System.Windows.Forms.Label
    Friend WithEvents GroupIva As System.Windows.Forms.GroupBox
    Friend WithEvents txtNCTaxCode As System.Windows.Forms.TextBox
    Friend WithEvents lblNCTaxCode As System.Windows.Forms.Label
    Friend WithEvents txtIVAExclusionPercent As System.Windows.Forms.TextBox
    Friend WithEvents lblIVAExclusionPercent As System.Windows.Forms.Label
    Friend WithEvents txtIVAFreePercent As System.Windows.Forms.TextBox
    Friend WithEvents lblIVAFreePercent As System.Windows.Forms.Label
    Friend WithEvents chkIVAFree As System.Windows.Forms.CheckBox
    Friend WithEvents chkIVAPlus As System.Windows.Forms.CheckBox
    Friend WithEvents txtIVACategory As System.Windows.Forms.TextBox
    Friend WithEvents lblIVACategory As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTermsCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTermsName As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrencyName As System.Windows.Forms.TextBox
    Friend WithEvents lblExchange As System.Windows.Forms.Label
    Friend WithEvents txtIBNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblIBNumber As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
    Friend WithEvents lblSalesTerms As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents pnlAdress As System.Windows.Forms.Panel
    Friend WithEvents txtZoneCode As System.Windows.Forms.TextBox
    Friend WithEvents txtZoneName As System.Windows.Forms.TextBox
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents txtStateCode As System.Windows.Forms.TextBox
    Friend WithEvents txtStateName As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents lblAdress As System.Windows.Forms.Label
    Friend WithEvents Browser As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents BrowserAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserList As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowserMenuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserMenuViewLargeIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserMenuViewSmallIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionsAddTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbContacts As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlContacts As System.Windows.Forms.Panel
    Friend WithEvents GridContacts As Crm.UI.GridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAIL2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDAY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbAttachment As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlAttachments As System.Windows.Forms.Panel
    Friend WithEvents FileList As System.Windows.Forms.ListView
    Friend WithEvents MenuActionsAddAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IList As System.Windows.Forms.ImageList
    Friend WithEvents MenuFileEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionsAddContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchByKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchPrevious As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchFirst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchLast As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionPotentialCustomersToReal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbTask As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlTasks As System.Windows.Forms.Panel
    Friend WithEvents GridTaks As Crm.UI.GridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateInit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskPriority As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
