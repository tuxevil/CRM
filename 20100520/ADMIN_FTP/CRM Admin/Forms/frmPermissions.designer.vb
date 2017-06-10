<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermissions
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Empresas")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermissions))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SUPERVISOR", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ADMINISTRACION", 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("JEVE DE VENTAS", 0)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("DIOS", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("VENTAS", 0)
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
        Me.MenuActions = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionsAddTask = New System.Windows.Forms.ToolStripMenuItem
        Me.tvCompanies = New System.Windows.Forms.TreeView
        Me.TreeMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TreeMenuAddUser = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeMenuDeleteuser = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeMenuUserDomain = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeMenuUserDomainAbs = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeMenuUserDomainDefine = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeMenuUserProfileOwner = New System.Windows.Forms.ToolStripMenuItem
        Me.IList = New System.Windows.Forms.ImageList(Me.components)
        Me.frmSplit = New System.Windows.Forms.Splitter
        Me.ProfileList = New System.Windows.Forms.ListBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ILList = New System.Windows.Forms.ImageList(Me.components)
        Me.Browser.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.TreeMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAccept, Me.BrowserCancel, Me.BrowserAdd, Me.BrowserDelete, Me.BrowserEdit, Me.BrowserSeparator1, Me.BrowserFirst, Me.BrowserPrevious, Me.BrowserNext, Me.BrowserLast, Me.BrowserSeparator2, Me.BrowserSearch, Me.BrowserList})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(643, 31)
        Me.Browser.TabIndex = 41
        Me.Browser.Text = "ToolStrip1"
        Me.Browser.Visible = False
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
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuActions})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(643, 24)
        Me.MainMenu.TabIndex = 40
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
        Me.MenuFileExit.Size = New System.Drawing.Size(116, 22)
        Me.MenuFileExit.Text = "Cerrar"
        '
        'MenuActions
        '
        Me.MenuActions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuActionsAddTask})
        Me.MenuActions.Name = "MenuActions"
        Me.MenuActions.Size = New System.Drawing.Size(52, 20)
        Me.MenuActions.Text = "Edición"
        '
        'MenuActionsAddTask
        '
        Me.MenuActionsAddTask.Name = "MenuActionsAddTask"
        Me.MenuActionsAddTask.Size = New System.Drawing.Size(147, 22)
        Me.MenuActionsAddTask.Text = "Asociar perfil"
        '
        'tvCompanies
        '
        Me.tvCompanies.AllowDrop = True
        Me.tvCompanies.ContextMenuStrip = Me.TreeMenu
        Me.tvCompanies.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvCompanies.HideSelection = False
        Me.tvCompanies.ImageIndex = 0
        Me.tvCompanies.ImageList = Me.IList
        Me.tvCompanies.Location = New System.Drawing.Point(0, 24)
        Me.tvCompanies.Name = "tvCompanies"
        TreeNode1.Name = "Root"
        TreeNode1.Text = "Empresas"
        Me.tvCompanies.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvCompanies.SelectedImageIndex = 0
        Me.tvCompanies.Size = New System.Drawing.Size(289, 433)
        Me.tvCompanies.TabIndex = 42
        '
        'TreeMenu
        '
        Me.TreeMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreeMenuAddUser, Me.TreeMenuDeleteuser, Me.TreeMenuUserDomain, Me.TreeMenuUserProfileOwner})
        Me.TreeMenu.Name = "TreeMenu"
        Me.TreeMenu.Size = New System.Drawing.Size(189, 92)
        '
        'TreeMenuAddUser
        '
        Me.TreeMenuAddUser.Name = "TreeMenuAddUser"
        Me.TreeMenuAddUser.Size = New System.Drawing.Size(188, 22)
        Me.TreeMenuAddUser.Text = "Agregar usuario"
        '
        'TreeMenuDeleteuser
        '
        Me.TreeMenuDeleteuser.Name = "TreeMenuDeleteuser"
        Me.TreeMenuDeleteuser.Size = New System.Drawing.Size(188, 22)
        Me.TreeMenuDeleteuser.Text = "Eliminar usuario"
        '
        'TreeMenuUserDomain
        '
        Me.TreeMenuUserDomain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreeMenuUserDomainAbs, Me.TreeMenuUserDomainDefine})
        Me.TreeMenuUserDomain.Name = "TreeMenuUserDomain"
        Me.TreeMenuUserDomain.Size = New System.Drawing.Size(188, 22)
        Me.TreeMenuUserDomain.Text = "Dominio"
        '
        'TreeMenuUserDomainAbs
        '
        Me.TreeMenuUserDomainAbs.Name = "TreeMenuUserDomainAbs"
        Me.TreeMenuUserDomainAbs.Size = New System.Drawing.Size(127, 22)
        Me.TreeMenuUserDomainAbs.Text = "Absoluto"
        '
        'TreeMenuUserDomainDefine
        '
        Me.TreeMenuUserDomainDefine.Name = "TreeMenuUserDomainDefine"
        Me.TreeMenuUserDomainDefine.Size = New System.Drawing.Size(127, 22)
        Me.TreeMenuUserDomainDefine.Text = "Definir"
        '
        'TreeMenuUserProfileOwner
        '
        Me.TreeMenuUserProfileOwner.Name = "TreeMenuUserProfileOwner"
        Me.TreeMenuUserProfileOwner.Size = New System.Drawing.Size(188, 22)
        Me.TreeMenuUserProfileOwner.Text = "Responsable de perfil"
        '
        'IList
        '
        Me.IList.ImageStream = CType(resources.GetObject("IList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IList.TransparentColor = System.Drawing.Color.Transparent
        Me.IList.Images.SetKeyName(0, "Company.png")
        Me.IList.Images.SetKeyName(1, "UserInfo.png")
        Me.IList.Images.SetKeyName(2, "UserKey.png")
        '
        'frmSplit
        '
        Me.frmSplit.Location = New System.Drawing.Point(289, 24)
        Me.frmSplit.Name = "frmSplit"
        Me.frmSplit.Size = New System.Drawing.Size(3, 433)
        Me.frmSplit.TabIndex = 43
        Me.frmSplit.TabStop = False
        '
        'ProfileList
        '
        Me.ProfileList.AllowDrop = True
        Me.ProfileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfileList.FormattingEnabled = True
        Me.ProfileList.Location = New System.Drawing.Point(292, 24)
        Me.ProfileList.Name = "ProfileList"
        Me.ProfileList.Size = New System.Drawing.Size(351, 433)
        Me.ProfileList.TabIndex = 44
        '
        'ListView1
        '
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListView1.LargeImageList = Me.ILList
        Me.ListView1.Location = New System.Drawing.Point(361, 104)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(260, 213)
        Me.ListView1.SmallImageList = Me.ILList
        Me.ListView1.TabIndex = 45
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        Me.ListView1.Visible = False
        '
        'ILList
        '
        Me.ILList.ImageStream = CType(resources.GetObject("ILList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILList.TransparentColor = System.Drawing.Color.Transparent
        Me.ILList.Images.SetKeyName(0, "UserKey.png")
        '
        'frmPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 457)
        Me.Controls.Add(Me.ProfileList)
        Me.Controls.Add(Me.frmSplit)
        Me.Controls.Add(Me.tvCompanies)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPermissions"
        Me.Text = "Administrador de permisos"
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.TreeMenu.ResumeLayout(False)
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
    Friend WithEvents MenuActions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionsAddTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tvCompanies As System.Windows.Forms.TreeView
    Friend WithEvents frmSplit As System.Windows.Forms.Splitter
    Friend WithEvents ProfileList As System.Windows.Forms.ListBox
    Friend WithEvents IList As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ILList As System.Windows.Forms.ImageList
    Friend WithEvents TreeMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TreeMenuAddUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenuDeleteuser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenuUserDomain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenuUserDomainAbs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenuUserDomainDefine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenuUserProfileOwner As System.Windows.Forms.ToolStripMenuItem
End Class
