<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfiles))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos generales", 0, 0)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Domicilio", 0, 0)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrega", 0, 0)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Facturación", 0, 0)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comentarios", 0, 0)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contactos", 0, 0)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adjuntos", 0, 0)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altas", 0, 0)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificaciones", 0, 0)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reales", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos generales", 0, 0)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Domicilio", 0, 0)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrega", 0, 0)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Facturación", 0, 0)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comentarios", 0, 0)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contactos", 0, 0)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adjuntos", 0, 0)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altas", 0, 0)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificaciones", 0, 0)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Potenciales", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clientes", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tareas", 0, 0)
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parámetros Generales", 0, 0)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entidades", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CRM", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode26})
        Me.Browser = New System.Windows.Forms.ToolStrip
        Me.BrowserAccept = New System.Windows.Forms.ToolStripButton
        Me.BrowserCancel = New System.Windows.Forms.ToolStripButton
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
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEdition = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditionSave = New System.Windows.Forms.ToolStripMenuItem
        Me.ITree = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlProfile = New System.Windows.Forms.Panel
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.PermissionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PermissionsMenuEnabledNodes = New System.Windows.Forms.ToolStripMenuItem
        Me.PermissionsMenuEnabledNode = New System.Windows.Forms.ToolStripMenuItem
        Me.PermissionsMenuDisableNodes = New System.Windows.Forms.ToolStripMenuItem
        Me.PermissionsMenuDisableNode = New System.Windows.Forms.ToolStripMenuItem
        Me.tvPermissions = New System.Windows.Forms.TreeView
        Me.Browser.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.pnlProfile.SuspendLayout()
        Me.PermissionsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAccept, Me.BrowserCancel, Me.BrowserAdd, Me.BrowserDelete, Me.BrowserEdit, Me.BrowserSeparator1, Me.BrowserFirst, Me.BrowserPrevious, Me.BrowserNext, Me.BrowserLast, Me.BrowserSeparator2, Me.BrowserSearch, Me.BrowserList})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(468, 31)
        Me.Browser.TabIndex = 39
        Me.Browser.Text = "ToolStrip1"
        '
        'BrowserAccept
        '
        Me.BrowserAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAccept.Image = Global.Admin.My.Resources.Resources.accept
        Me.BrowserAccept.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAccept.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAccept.Name = "BrowserAccept"
        Me.BrowserAccept.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAccept.Text = "Guardar cambios"
        Me.BrowserAccept.Visible = False
        '
        'BrowserCancel
        '
        Me.BrowserCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserCancel.Image = Global.Admin.My.Resources.Resources.Cancel
        Me.BrowserCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserCancel.Name = "BrowserCancel"
        Me.BrowserCancel.Size = New System.Drawing.Size(28, 28)
        Me.BrowserCancel.Text = "Deshacer cambios"
        Me.BrowserCancel.Visible = False
        '
        'BrowserAdd
        '
        Me.BrowserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAdd.Image = Global.Admin.My.Resources.Resources.add
        Me.BrowserAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAdd.Name = "BrowserAdd"
        Me.BrowserAdd.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAdd.Text = "Añadir registro"
        '
        'BrowserDelete
        '
        Me.BrowserDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserDelete.Image = Global.Admin.My.Resources.Resources.delete
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
        Me.BrowserEdit.Image = Global.Admin.My.Resources.Resources.up
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
        Me.BrowserFirst.Image = Global.Admin.My.Resources.Resources.First
        Me.BrowserFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserFirst.Name = "BrowserFirst"
        Me.BrowserFirst.Size = New System.Drawing.Size(28, 28)
        Me.BrowserFirst.Text = "Primer registro"
        '
        'BrowserPrevious
        '
        Me.BrowserPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserPrevious.Image = Global.Admin.My.Resources.Resources.previous
        Me.BrowserPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserPrevious.Name = "BrowserPrevious"
        Me.BrowserPrevious.Size = New System.Drawing.Size(28, 28)
        Me.BrowserPrevious.Text = "Registro anterior"
        '
        'BrowserNext
        '
        Me.BrowserNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserNext.Image = Global.Admin.My.Resources.Resources._next
        Me.BrowserNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserNext.Name = "BrowserNext"
        Me.BrowserNext.Size = New System.Drawing.Size(28, 28)
        Me.BrowserNext.Text = "Próximo registro"
        '
        'BrowserLast
        '
        Me.BrowserLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserLast.Image = Global.Admin.My.Resources.Resources.Last
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
        Me.BrowserSearch.Image = Global.Admin.My.Resources.Resources.search
        Me.BrowserSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserSearch.Name = "BrowserSearch"
        Me.BrowserSearch.Size = New System.Drawing.Size(28, 28)
        Me.BrowserSearch.Text = "Buscar registro"
        Me.BrowserSearch.Visible = False
        '
        'BrowserList
        '
        Me.BrowserList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserList.Image = Global.Admin.My.Resources.Resources.List
        Me.BrowserList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserList.Name = "BrowserList"
        Me.BrowserList.Size = New System.Drawing.Size(28, 28)
        Me.BrowserList.Text = "Listar"
        Me.BrowserList.Visible = False
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuEdition})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(468, 24)
        Me.MainMenu.TabIndex = 38
        Me.MainMenu.Text = "MenuStrip1"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileExit})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(55, 20)
        Me.MenuFile.Text = "Archivo"
        '
        'MenuFileExit
        '
        Me.MenuFileExit.Name = "MenuFileExit"
        Me.MenuFileExit.Size = New System.Drawing.Size(105, 22)
        Me.MenuFileExit.Text = "Salir"
        '
        'MenuEdition
        '
        Me.MenuEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEditionEdit, Me.MenuEditionAdd, Me.MenuEditionCancel, Me.MenuEditionSave})
        Me.MenuEdition.Name = "MenuEdition"
        Me.MenuEdition.Size = New System.Drawing.Size(52, 20)
        Me.MenuEdition.Text = "Edición"
        '
        'MenuEditionEdit
        '
        Me.MenuEditionEdit.Name = "MenuEditionEdit"
        Me.MenuEditionEdit.Size = New System.Drawing.Size(128, 22)
        Me.MenuEditionEdit.Text = "Modificar"
        '
        'MenuEditionAdd
        '
        Me.MenuEditionAdd.Name = "MenuEditionAdd"
        Me.MenuEditionAdd.Size = New System.Drawing.Size(128, 22)
        Me.MenuEditionAdd.Text = "Agregar"
        '
        'MenuEditionCancel
        '
        Me.MenuEditionCancel.Name = "MenuEditionCancel"
        Me.MenuEditionCancel.Size = New System.Drawing.Size(128, 22)
        Me.MenuEditionCancel.Text = "Cancelar"
        Me.MenuEditionCancel.Visible = False
        '
        'MenuEditionSave
        '
        Me.MenuEditionSave.Name = "MenuEditionSave"
        Me.MenuEditionSave.Size = New System.Drawing.Size(128, 22)
        Me.MenuEditionSave.Text = "Guardar"
        Me.MenuEditionSave.Visible = False
        '
        'ITree
        '
        Me.ITree.ImageStream = CType(resources.GetObject("ITree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ITree.TransparentColor = System.Drawing.Color.Transparent
        Me.ITree.Images.SetKeyName(0, "lock.png")
        Me.ITree.Images.SetKeyName(1, "unlock.png")
        '
        'pnlProfile
        '
        Me.pnlProfile.Controls.Add(Me.txtDescription)
        Me.pnlProfile.Controls.Add(Me.lblDescription)
        Me.pnlProfile.Controls.Add(Me.txtName)
        Me.pnlProfile.Controls.Add(Me.lblName)
        Me.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlProfile.Location = New System.Drawing.Point(0, 55)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Size = New System.Drawing.Size(468, 81)
        Me.pnlProfile.TabIndex = 41
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(114, 52)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(322, 23)
        Me.txtDescription.TabIndex = 38
        Me.txtDescription.Text = "VENDEDORES / TELEMARKETERS"
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(8, 51)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(100, 23)
        Me.lblDescription.TabIndex = 37
        Me.lblDescription.Text = "DESCRIPCION"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(114, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(322, 23)
        Me.txtName.TabIndex = 36
        Me.txtName.Text = "VENTAS"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(8, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 35
        Me.lblName.Text = "PERFIL"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PermissionsMenu
        '
        Me.PermissionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermissionsMenuEnabledNodes, Me.PermissionsMenuEnabledNode, Me.PermissionsMenuDisableNodes, Me.PermissionsMenuDisableNode})
        Me.PermissionsMenu.Name = "ContextMenuStrip1"
        Me.PermissionsMenu.Size = New System.Drawing.Size(165, 92)
        Me.PermissionsMenu.Text = "Permisos"
        '
        'PermissionsMenuEnabledNodes
        '
        Me.PermissionsMenuEnabledNodes.Enabled = False
        Me.PermissionsMenuEnabledNodes.Name = "PermissionsMenuEnabledNodes"
        Me.PermissionsMenuEnabledNodes.Size = New System.Drawing.Size(164, 22)
        Me.PermissionsMenuEnabledNodes.Text = "Habilita rama"
        '
        'PermissionsMenuEnabledNode
        '
        Me.PermissionsMenuEnabledNode.Enabled = False
        Me.PermissionsMenuEnabledNode.Name = "PermissionsMenuEnabledNode"
        Me.PermissionsMenuEnabledNode.Size = New System.Drawing.Size(164, 22)
        Me.PermissionsMenuEnabledNode.Text = "Habilita item"
        '
        'PermissionsMenuDisableNodes
        '
        Me.PermissionsMenuDisableNodes.Enabled = False
        Me.PermissionsMenuDisableNodes.Name = "PermissionsMenuDisableNodes"
        Me.PermissionsMenuDisableNodes.Size = New System.Drawing.Size(164, 22)
        Me.PermissionsMenuDisableNodes.Text = "Deshabilita rama"
        '
        'PermissionsMenuDisableNode
        '
        Me.PermissionsMenuDisableNode.Enabled = False
        Me.PermissionsMenuDisableNode.Name = "PermissionsMenuDisableNode"
        Me.PermissionsMenuDisableNode.Size = New System.Drawing.Size(164, 22)
        Me.PermissionsMenuDisableNode.Text = "Deshabilita item"
        '
        'tvPermissions
        '
        Me.tvPermissions.ContextMenuStrip = Me.PermissionsMenu
        Me.tvPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvPermissions.ImageIndex = 0
        Me.tvPermissions.ImageList = Me.ITree
        Me.tvPermissions.Location = New System.Drawing.Point(0, 136)
        Me.tvPermissions.Name = "tvPermissions"
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "NodeCustomerRealViewGeneral"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Tag = "Item"
        TreeNode1.Text = "Datos generales"
        TreeNode2.ImageIndex = 0
        TreeNode2.Name = "NodeCustomerRealViewAdress"
        TreeNode2.SelectedImageIndex = 0
        TreeNode2.Tag = "Item"
        TreeNode2.Text = "Domicilio"
        TreeNode3.ImageIndex = 0
        TreeNode3.Name = "NodeCustomerRealViewDelivery"
        TreeNode3.SelectedImageIndex = 0
        TreeNode3.Tag = "Item"
        TreeNode3.Text = "Entrega"
        TreeNode4.ImageIndex = 0
        TreeNode4.Name = "NodeCustomerRealViewTerms"
        TreeNode4.SelectedImageIndex = 0
        TreeNode4.Tag = "Item"
        TreeNode4.Text = "Facturación"
        TreeNode5.ImageIndex = 0
        TreeNode5.Name = "NodeCustomerRealViewNotes"
        TreeNode5.SelectedImageIndex = 0
        TreeNode5.Tag = "Item"
        TreeNode5.Text = "Comentarios"
        TreeNode6.ImageIndex = 0
        TreeNode6.Name = "NodeCustomerRealViewContacts"
        TreeNode6.SelectedImageIndex = 0
        TreeNode6.Tag = "Item"
        TreeNode6.Text = "Contactos"
        TreeNode7.ImageIndex = 0
        TreeNode7.Name = "NodeCustomerRealViewAttachments"
        TreeNode7.SelectedImageIndex = 0
        TreeNode7.Tag = "Item"
        TreeNode7.Text = "Adjuntos"
        TreeNode8.ImageIndex = 0
        TreeNode8.Name = "NodeCustomerRealView"
        TreeNode8.SelectedImageIndex = 0
        TreeNode8.Text = "Consultas"
        TreeNode9.ImageIndex = 0
        TreeNode9.Name = "NodeCustomerRealAdd"
        TreeNode9.SelectedImageIndex = 0
        TreeNode9.Tag = "Item"
        TreeNode9.Text = "Altas"
        TreeNode10.ImageIndex = 0
        TreeNode10.Name = "NodeCustomerRealEdit"
        TreeNode10.SelectedImageIndex = 0
        TreeNode10.Tag = "Item"
        TreeNode10.Text = "Modificaciones"
        TreeNode11.ImageIndex = 0
        TreeNode11.Name = "NodeCustomerReal"
        TreeNode11.SelectedImageIndex = 0
        TreeNode11.Text = "Reales"
        TreeNode12.ImageIndex = 0
        TreeNode12.Name = "NodeCustomerPotentialViewGeneral"
        TreeNode12.SelectedImageIndex = 0
        TreeNode12.Tag = "Item"
        TreeNode12.Text = "Datos generales"
        TreeNode13.ImageIndex = 0
        TreeNode13.Name = "NodeCustomerPotentialViewAdress"
        TreeNode13.SelectedImageIndex = 0
        TreeNode13.Tag = "Item"
        TreeNode13.Text = "Domicilio"
        TreeNode14.ImageIndex = 0
        TreeNode14.Name = "NodeCustomerPotentialViewDelivery"
        TreeNode14.SelectedImageIndex = 0
        TreeNode14.Tag = "Item"
        TreeNode14.Text = "Entrega"
        TreeNode15.ImageIndex = 0
        TreeNode15.Name = "NodeCustomerPotentialViewTerms"
        TreeNode15.SelectedImageIndex = 0
        TreeNode15.Tag = "Item"
        TreeNode15.Text = "Facturación"
        TreeNode16.ImageIndex = 0
        TreeNode16.Name = "NodeCustomerPotentialViewNotes"
        TreeNode16.SelectedImageIndex = 0
        TreeNode16.Tag = "Item"
        TreeNode16.Text = "Comentarios"
        TreeNode17.ImageIndex = 0
        TreeNode17.Name = "NodeCustomerPotentialViewContacts"
        TreeNode17.SelectedImageIndex = 0
        TreeNode17.Tag = "Item"
        TreeNode17.Text = "Contactos"
        TreeNode18.ImageIndex = 0
        TreeNode18.Name = "NodeCustomerPotentialViewAttachments"
        TreeNode18.SelectedImageIndex = 0
        TreeNode18.Tag = "Item"
        TreeNode18.Text = "Adjuntos"
        TreeNode19.ImageIndex = 0
        TreeNode19.Name = "NodeCustomerPotentialView"
        TreeNode19.SelectedImageIndex = 0
        TreeNode19.Text = "Consultas"
        TreeNode20.ImageIndex = 0
        TreeNode20.Name = "NodeCustomerPotentialAdd"
        TreeNode20.SelectedImageIndex = 0
        TreeNode20.Tag = "Item"
        TreeNode20.Text = "Altas"
        TreeNode21.ImageIndex = 0
        TreeNode21.Name = "NodeCustomerPotentialEdit"
        TreeNode21.SelectedImageIndex = 0
        TreeNode21.Tag = "Item"
        TreeNode21.Text = "Modificaciones"
        TreeNode22.ImageIndex = 0
        TreeNode22.Name = "NodeCustomerPotential"
        TreeNode22.SelectedImageIndex = 0
        TreeNode22.Text = "Potenciales"
        TreeNode23.ImageIndex = 0
        TreeNode23.Name = "NodeCustomer"
        TreeNode23.SelectedImageIndex = 0
        TreeNode23.Text = "Clientes"
        TreeNode24.ImageIndex = 0
        TreeNode24.Name = "NodeTask"
        TreeNode24.SelectedImageIndex = 0
        TreeNode24.Tag = "Item"
        TreeNode24.Text = "Tareas"
        TreeNode25.ImageIndex = 0
        TreeNode25.Name = "NodeParGen"
        TreeNode25.SelectedImageIndex = 0
        TreeNode25.Tag = "Item"
        TreeNode25.Text = "Parámetros Generales"
        TreeNode26.ImageIndex = 0
        TreeNode26.Name = "NodeEntity"
        TreeNode26.SelectedImageIndex = 0
        TreeNode26.Text = "Entidades"
        TreeNode27.ImageIndex = 0
        TreeNode27.Name = "NodeRoot"
        TreeNode27.SelectedImageIndex = 0
        TreeNode27.Text = "CRM"
        Me.tvPermissions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode27})
        Me.tvPermissions.SelectedImageIndex = 0
        Me.tvPermissions.Size = New System.Drawing.Size(468, 319)
        Me.tvPermissions.TabIndex = 42
        '
        'frmProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 455)
        Me.Controls.Add(Me.tvPermissions)
        Me.Controls.Add(Me.pnlProfile)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmProfiles"
        Me.Text = "Usuarios y Permisos"
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.pnlProfile.ResumeLayout(False)
        Me.pnlProfile.PerformLayout()
        Me.PermissionsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Browser As System.Windows.Forms.ToolStrip
    Friend WithEvents BrowserAccept As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserList As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditionEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITree As System.Windows.Forms.ImageList
    Friend WithEvents pnlProfile As System.Windows.Forms.Panel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents PermissionsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PermissionsMenuEnabledNodes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermissionsMenuEnabledNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermissionsMenuDisableNodes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermissionsMenuDisableNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents tvPermissions As System.Windows.Forms.TreeView
    Friend WithEvents MenuEditionAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditionCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditionSave As System.Windows.Forms.ToolStripMenuItem
End Class
