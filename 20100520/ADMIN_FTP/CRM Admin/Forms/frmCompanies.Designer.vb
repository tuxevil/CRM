<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanies))
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.lblOptions = New System.Windows.Forms.Label
        Me.frmSplit = New System.Windows.Forms.Splitter
        Me.ListCompanies = New System.Windows.Forms.ListView
        Me.CompanyId = New System.Windows.Forms.ColumnHeader
        Me.CompanyTgId = New System.Windows.Forms.ColumnHeader
        Me.CompanyDisplayName = New System.Windows.Forms.ColumnHeader
        Me.CompanyDatabase = New System.Windows.Forms.ColumnHeader
        Me.CompanyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CompanyMenuEnable = New System.Windows.Forms.ToolStripMenuItem
        Me.IList = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlOptions.SuspendLayout()
        Me.CompanyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.lblOptions)
        Me.pnlOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlOptions.Location = New System.Drawing.Point(0, 0)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(200, 519)
        Me.pnlOptions.TabIndex = 1
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
        Me.frmSplit.Location = New System.Drawing.Point(200, 0)
        Me.frmSplit.Name = "frmSplit"
        Me.frmSplit.Size = New System.Drawing.Size(3, 519)
        Me.frmSplit.TabIndex = 2
        Me.frmSplit.TabStop = False
        '
        'ListCompanies
        '
        Me.ListCompanies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompanyId, Me.CompanyTgId, Me.CompanyDisplayName, Me.CompanyDatabase})
        Me.ListCompanies.ContextMenuStrip = Me.CompanyMenu
        Me.ListCompanies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListCompanies.LargeImageList = Me.IList
        Me.ListCompanies.Location = New System.Drawing.Point(203, 0)
        Me.ListCompanies.Name = "ListCompanies"
        Me.ListCompanies.Size = New System.Drawing.Size(575, 519)
        Me.ListCompanies.TabIndex = 3
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
        'CompanyDatabase
        '
        Me.CompanyDatabase.DisplayIndex = 1
        Me.CompanyDatabase.Text = "Base de datos"
        Me.CompanyDatabase.Width = 1000
        '
        'CompanyMenu
        '
        Me.CompanyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyMenuEnable})
        Me.CompanyMenu.Name = "CompanyMenu"
        Me.CompanyMenu.Size = New System.Drawing.Size(169, 26)
        '
        'CompanyMenuEnable
        '
        Me.CompanyMenuEnable.Name = "CompanyMenuEnable"
        Me.CompanyMenuEnable.Size = New System.Drawing.Size(168, 22)
        Me.CompanyMenuEnable.Text = "Habilitar empresa"
        '
        'IList
        '
        Me.IList.ImageStream = CType(resources.GetObject("IList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IList.TransparentColor = System.Drawing.Color.Transparent
        Me.IList.Images.SetKeyName(0, "Companyenabled")
        Me.IList.Images.SetKeyName(1, "CompanyDisabled")
        '
        'frmCompanies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 519)
        Me.Controls.Add(Me.ListCompanies)
        Me.Controls.Add(Me.frmSplit)
        Me.Controls.Add(Me.pnlOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompanies"
        Me.Text = "EMPRESAS"
        Me.pnlOptions.ResumeLayout(False)
        Me.CompanyMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents frmSplit As System.Windows.Forms.Splitter
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents ListCompanies As System.Windows.Forms.ListView
    Friend WithEvents CompanyId As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompanyDisplayName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompanyDatabase As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompanyTgId As System.Windows.Forms.ColumnHeader
    Friend WithEvents IList As System.Windows.Forms.ImageList
    Friend WithEvents CompanyMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CompanyMenuEnable As System.Windows.Forms.ToolStripMenuItem
End Class
