<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.CompanyDatabase = New System.Windows.Forms.ColumnHeader
        Me.ListCompanies = New System.Windows.Forms.ListView
        Me.CompanyId = New System.Windows.Forms.ColumnHeader
        Me.CompanyTgId = New System.Windows.Forms.ColumnHeader
        Me.CompanyDisplayName = New System.Windows.Forms.ColumnHeader
        Me.UserMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuEnable = New System.Windows.Forms.ToolStripMenuItem
        Me.IList = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.lblOptions = New System.Windows.Forms.Label
        Me.frmSplit = New System.Windows.Forms.Splitter
        Me.UserMenu.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompanyDatabase
        '
        Me.CompanyDatabase.DisplayIndex = 1
        Me.CompanyDatabase.Text = "Base de datos"
        Me.CompanyDatabase.Width = 1000
        '
        'ListCompanies
        '
        Me.ListCompanies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompanyId, Me.CompanyTgId, Me.CompanyDisplayName, Me.CompanyDatabase})
        Me.ListCompanies.ContextMenuStrip = Me.UserMenu
        Me.ListCompanies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListCompanies.LargeImageList = Me.IList
        Me.ListCompanies.Location = New System.Drawing.Point(203, 0)
        Me.ListCompanies.Name = "ListCompanies"
        Me.ListCompanies.Size = New System.Drawing.Size(496, 508)
        Me.ListCompanies.TabIndex = 6
        Me.ListCompanies.UseCompatibleStateImageBehavior = False
        '
        'CompanyId
        '
        Me.CompanyId.DisplayIndex = 2
        Me.CompanyId.Text = "Id"
        Me.CompanyId.Width = 0
        '
        'CompanyTgId
        '
        Me.CompanyTgId.DisplayIndex = 3
        Me.CompanyTgId.Text = "Id Tango"
        Me.CompanyTgId.Width = 0
        '
        'CompanyDisplayName
        '
        Me.CompanyDisplayName.DisplayIndex = 0
        Me.CompanyDisplayName.Text = "Empresa"
        Me.CompanyDisplayName.Width = 1000
        '
        'UserMenu
        '
        Me.UserMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuEnable})
        Me.UserMenu.Name = "CompanyMenu"
        Me.UserMenu.Size = New System.Drawing.Size(163, 48)
        '
        'UserMenuEnable
        '
        Me.UserMenuEnable.Name = "UserMenuEnable"
        Me.UserMenuEnable.Size = New System.Drawing.Size(162, 22)
        Me.UserMenuEnable.Text = "Habilitar usuario"
        '
        'IList
        '
        Me.IList.ImageStream = CType(resources.GetObject("IList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IList.TransparentColor = System.Drawing.Color.Transparent
        Me.IList.Images.SetKeyName(0, "Companyenabled")
        Me.IList.Images.SetKeyName(1, "CompanyDisabled")
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.lblOptions)
        Me.pnlOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlOptions.Location = New System.Drawing.Point(3, 0)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(200, 508)
        Me.pnlOptions.TabIndex = 4
        '
        'lblOptions
        '
        Me.lblOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOptions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(0, 0)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(200, 384)
        Me.lblOptions.TabIndex = 0
        Me.lblOptions.Text = resources.GetString("lblOptions.Text")
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSplit
        '
        Me.frmSplit.Location = New System.Drawing.Point(0, 0)
        Me.frmSplit.Name = "frmSplit"
        Me.frmSplit.Size = New System.Drawing.Size(3, 508)
        Me.frmSplit.TabIndex = 5
        Me.frmSplit.TabStop = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 508)
        Me.Controls.Add(Me.ListCompanies)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.frmSplit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsers"
        Me.Text = "USUARIOS"
        Me.UserMenu.ResumeLayout(False)
        Me.pnlOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CompanyDatabase As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListCompanies As System.Windows.Forms.ListView
    Friend WithEvents CompanyId As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompanyTgId As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompanyDisplayName As System.Windows.Forms.ColumnHeader
    Friend WithEvents UserMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuEnable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IList As System.Windows.Forms.ImageList
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents frmSplit As System.Windows.Forms.Splitter
End Class
