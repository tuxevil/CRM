<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.msPanels = New System.Windows.Forms.MenuStrip
        Me.msPanelOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.mainSplit = New System.Windows.Forms.SplitContainer
        Me.tsOptions = New System.Windows.Forms.ToolStrip
        Me.btHide = New System.Windows.Forms.ToolStripButton
        Me.lblMenu = New System.Windows.Forms.ToolStripLabel
        Me.GroupOptions = New System.Windows.Forms.GroupBox
        Me.chkIncremental = New System.Windows.Forms.CheckBox
        Me.lvRows = New System.Windows.Forms.ListView
        Me.pnlCriteria = New System.Windows.Forms.Panel
        Me.txtCriteria = New System.Windows.Forms.TextBox
        Me.lblCriteria = New System.Windows.Forms.Label
        Me.lblField = New System.Windows.Forms.Label
        Me.cmbField = New System.Windows.Forms.ComboBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.msPanels.SuspendLayout()
        Me.mainSplit.Panel1.SuspendLayout()
        Me.mainSplit.Panel2.SuspendLayout()
        Me.mainSplit.SuspendLayout()
        Me.tsOptions.SuspendLayout()
        Me.GroupOptions.SuspendLayout()
        Me.pnlCriteria.SuspendLayout()
        Me.SuspendLayout()
        '
        'msPanels
        '
        Me.msPanels.Dock = System.Windows.Forms.DockStyle.Left
        Me.msPanels.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msPanelOptions})
        Me.msPanels.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.msPanels.Location = New System.Drawing.Point(0, 0)
        Me.msPanels.Name = "msPanels"
        Me.msPanels.Size = New System.Drawing.Size(34, 496)
        Me.msPanels.TabIndex = 18
        Me.msPanels.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'msPanelOptions
        '
        Me.msPanelOptions.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msPanelOptions.Name = "msPanelOptions"
        Me.msPanelOptions.Size = New System.Drawing.Size(21, 119)
        Me.msPanelOptions.Text = "Panel de opciones"
        '
        'mainSplit
        '
        Me.mainSplit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplit.Location = New System.Drawing.Point(34, 0)
        Me.mainSplit.Name = "mainSplit"
        '
        'mainSplit.Panel1
        '
        Me.mainSplit.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.mainSplit.Panel1.Controls.Add(Me.tsOptions)
        Me.mainSplit.Panel1.Controls.Add(Me.GroupOptions)
        Me.mainSplit.Panel1Collapsed = True
        Me.mainSplit.Panel1MinSize = 250
        '
        'mainSplit.Panel2
        '
        Me.mainSplit.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.mainSplit.Panel2.Controls.Add(Me.lvRows)
        Me.mainSplit.Panel2.Controls.Add(Me.pnlCriteria)
        Me.mainSplit.Panel2.Controls.Add(Me.lblTitle)
        Me.mainSplit.Size = New System.Drawing.Size(962, 496)
        Me.mainSplit.SplitterDistance = 250
        Me.mainSplit.SplitterWidth = 3
        Me.mainSplit.TabIndex = 19
        '
        'tsOptions
        '
        Me.tsOptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btHide, Me.lblMenu})
        Me.tsOptions.Location = New System.Drawing.Point(0, 0)
        Me.tsOptions.Name = "tsOptions"
        Me.tsOptions.Size = New System.Drawing.Size(250, 25)
        Me.tsOptions.TabIndex = 17
        Me.tsOptions.Text = "ToolStrip1"
        '
        'btHide
        '
        Me.btHide.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btHide.CheckOnClick = True
        Me.btHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btHide.Image = CType(resources.GetObject("btHide.Image"), System.Drawing.Image)
        Me.btHide.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btHide.Name = "btHide"
        Me.btHide.Size = New System.Drawing.Size(23, 22)
        '
        'lblMenu
        '
        Me.lblMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(121, 22)
        Me.lblMenu.Text = "Panel de opciones"
        '
        'GroupOptions
        '
        Me.GroupOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupOptions.Controls.Add(Me.chkIncremental)
        Me.GroupOptions.Location = New System.Drawing.Point(12, 53)
        Me.GroupOptions.Name = "GroupOptions"
        Me.GroupOptions.Size = New System.Drawing.Size(226, 202)
        Me.GroupOptions.TabIndex = 15
        Me.GroupOptions.TabStop = False
        Me.GroupOptions.Text = "Opciones de búsqueda"
        '
        'chkIncremental
        '
        Me.chkIncremental.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncremental.Checked = True
        Me.chkIncremental.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncremental.Location = New System.Drawing.Point(23, 33)
        Me.chkIncremental.Name = "chkIncremental"
        Me.chkIncremental.Size = New System.Drawing.Size(184, 17)
        Me.chkIncremental.TabIndex = 0
        Me.chkIncremental.Text = "Incremental"
        Me.chkIncremental.UseVisualStyleBackColor = True
        '
        'lvRows
        '
        Me.lvRows.AllowDrop = True
        Me.lvRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRows.FullRowSelect = True
        Me.lvRows.HideSelection = False
        Me.lvRows.Location = New System.Drawing.Point(0, 114)
        Me.lvRows.Name = "lvRows"
        Me.lvRows.Size = New System.Drawing.Size(962, 382)
        Me.lvRows.TabIndex = 1
        Me.lvRows.UseCompatibleStateImageBehavior = False
        Me.lvRows.View = System.Windows.Forms.View.Details
        '
        'pnlCriteria
        '
        Me.pnlCriteria.Controls.Add(Me.txtCriteria)
        Me.pnlCriteria.Controls.Add(Me.lblCriteria)
        Me.pnlCriteria.Controls.Add(Me.lblField)
        Me.pnlCriteria.Controls.Add(Me.cmbField)
        Me.pnlCriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCriteria.Location = New System.Drawing.Point(0, 38)
        Me.pnlCriteria.Name = "pnlCriteria"
        Me.pnlCriteria.Size = New System.Drawing.Size(962, 76)
        Me.pnlCriteria.TabIndex = 14
        '
        'txtCriteria
        '
        Me.txtCriteria.Location = New System.Drawing.Point(23, 34)
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.Size = New System.Drawing.Size(278, 20)
        Me.txtCriteria.TabIndex = 11
        '
        'lblCriteria
        '
        Me.lblCriteria.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria.Location = New System.Drawing.Point(20, 15)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(281, 16)
        Me.lblCriteria.TabIndex = 12
        Me.lblCriteria.Text = "Buscar "
        '
        'lblField
        '
        Me.lblField.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblField.Location = New System.Drawing.Point(330, 15)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(281, 16)
        Me.lblField.TabIndex = 10
        Me.lblField.Text = "En"
        '
        'cmbField
        '
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.Location = New System.Drawing.Point(329, 34)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(282, 21)
        Me.cmbField.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(962, 38)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Búsqueda de contactos"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 496)
        Me.Controls.Add(Me.mainSplit)
        Me.Controls.Add(Me.msPanels)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSearch"
        Me.Text = "CRM 2x4"
        Me.msPanels.ResumeLayout(False)
        Me.msPanels.PerformLayout()
        Me.mainSplit.Panel1.ResumeLayout(False)
        Me.mainSplit.Panel1.PerformLayout()
        Me.mainSplit.Panel2.ResumeLayout(False)
        Me.mainSplit.ResumeLayout(False)
        Me.tsOptions.ResumeLayout(False)
        Me.tsOptions.PerformLayout()
        Me.GroupOptions.ResumeLayout(False)
        Me.pnlCriteria.ResumeLayout(False)
        Me.pnlCriteria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msPanels As System.Windows.Forms.MenuStrip
    Friend WithEvents msPanelOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents tsOptions As System.Windows.Forms.ToolStrip
    Friend WithEvents btHide As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblMenu As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkIncremental As System.Windows.Forms.CheckBox
    Friend WithEvents lvRows As System.Windows.Forms.ListView
    Friend WithEvents pnlCriteria As System.Windows.Forms.Panel
    Friend WithEvents txtCriteria As System.Windows.Forms.TextBox
    Friend WithEvents lblCriteria As System.Windows.Forms.Label
    Friend WithEvents lblField As System.Windows.Forms.Label
    Friend WithEvents cmbField As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
