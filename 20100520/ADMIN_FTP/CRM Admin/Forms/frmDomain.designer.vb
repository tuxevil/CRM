<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDomain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDomain))
        Me.mainSplit = New System.Windows.Forms.SplitContainer
        Me.GridCriteria = New System.Windows.Forms.DataGridView
        Me.Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FieldName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FilterMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilterMenuRemoveFilter = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterMenuRemoveAll = New System.Windows.Forms.ToolStripMenuItem
        Me.lblFilters = New System.Windows.Forms.Label
        Me.pnlCriteria = New System.Windows.Forms.Panel
        Me.cmdAddFilter = New System.Windows.Forms.Button
        Me.txtCriteria = New System.Windows.Forms.TextBox
        Me.lblCriteria = New System.Windows.Forms.Label
        Me.lblField = New System.Windows.Forms.Label
        Me.cmbField = New System.Windows.Forms.ComboBox
        Me.lvRows = New System.Windows.Forms.ListView
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.cmdUnSelectAll = New System.Windows.Forms.Button
        Me.cmdSelectAll = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.mainSplit.Panel1.SuspendLayout()
        Me.mainSplit.Panel2.SuspendLayout()
        Me.mainSplit.SuspendLayout()
        CType(Me.GridCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FilterMenu.SuspendLayout()
        Me.pnlCriteria.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainSplit
        '
        Me.mainSplit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplit.Location = New System.Drawing.Point(0, 0)
        Me.mainSplit.Name = "mainSplit"
        '
        'mainSplit.Panel1
        '
        Me.mainSplit.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.mainSplit.Panel1.Controls.Add(Me.GridCriteria)
        Me.mainSplit.Panel1.Controls.Add(Me.lblFilters)
        Me.mainSplit.Panel1.Controls.Add(Me.pnlCriteria)
        Me.mainSplit.Panel1MinSize = 250
        '
        'mainSplit.Panel2
        '
        Me.mainSplit.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.mainSplit.Panel2.Controls.Add(Me.lvRows)
        Me.mainSplit.Panel2.Controls.Add(Me.pnlButtons)
        Me.mainSplit.Panel2.Controls.Add(Me.lblTitle)
        Me.mainSplit.Size = New System.Drawing.Size(996, 496)
        Me.mainSplit.SplitterDistance = 258
        Me.mainSplit.SplitterWidth = 3
        Me.mainSplit.TabIndex = 19
        '
        'GridCriteria
        '
        Me.GridCriteria.AllowUserToAddRows = False
        Me.GridCriteria.AllowUserToDeleteRows = False
        Me.GridCriteria.AllowUserToOrderColumns = True
        Me.GridCriteria.AllowUserToResizeColumns = False
        Me.GridCriteria.AllowUserToResizeRows = False
        Me.GridCriteria.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridCriteria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridCriteria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCriteria.ColumnHeadersVisible = False
        Me.GridCriteria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Field, Me.FieldName, Me.FieldValue})
        Me.GridCriteria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCriteria.GridColor = System.Drawing.SystemColors.Control
        Me.GridCriteria.Location = New System.Drawing.Point(0, 253)
        Me.GridCriteria.Name = "GridCriteria"
        Me.GridCriteria.RowHeadersVisible = False
        Me.GridCriteria.RowTemplate.ContextMenuStrip = Me.FilterMenu
        Me.GridCriteria.RowTemplate.DividerHeight = 5
        Me.GridCriteria.RowTemplate.Height = 30
        Me.GridCriteria.RowTemplate.ReadOnly = True
        Me.GridCriteria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCriteria.Size = New System.Drawing.Size(258, 243)
        Me.GridCriteria.TabIndex = 19
        '
        'Field
        '
        Me.Field.HeaderText = "Field"
        Me.Field.Name = "Field"
        Me.Field.Visible = False
        Me.Field.Width = 5
        '
        'FieldName
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.FieldName.DefaultCellStyle = DataGridViewCellStyle1
        Me.FieldName.DividerWidth = 5
        Me.FieldName.HeaderText = "CONDICION"
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FieldName.Width = 175
        '
        'FieldValue
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldValue.DefaultCellStyle = DataGridViewCellStyle2
        Me.FieldValue.HeaderText = "VALOR"
        Me.FieldValue.Name = "FieldValue"
        Me.FieldValue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FieldValue.Width = 80
        '
        'FilterMenu
        '
        Me.FilterMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterMenuRemoveFilter, Me.FilterMenuRemoveAll})
        Me.FilterMenu.Name = "FilterMenu"
        Me.FilterMenu.Size = New System.Drawing.Size(152, 48)
        '
        'FilterMenuRemoveFilter
        '
        Me.FilterMenuRemoveFilter.Name = "FilterMenuRemoveFilter"
        Me.FilterMenuRemoveFilter.Size = New System.Drawing.Size(151, 22)
        Me.FilterMenuRemoveFilter.Text = "Eliminar filtro"
        '
        'FilterMenuRemoveAll
        '
        Me.FilterMenuRemoveAll.Name = "FilterMenuRemoveAll"
        Me.FilterMenuRemoveAll.Size = New System.Drawing.Size(151, 22)
        Me.FilterMenuRemoveAll.Text = "Eliminar todos"
        '
        'lblFilters
        '
        Me.lblFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFilters.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilters.Location = New System.Drawing.Point(0, 215)
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Size = New System.Drawing.Size(258, 38)
        Me.lblFilters.TabIndex = 18
        Me.lblFilters.Text = "FILTROS"
        Me.lblFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlCriteria
        '
        Me.pnlCriteria.Controls.Add(Me.cmdAddFilter)
        Me.pnlCriteria.Controls.Add(Me.txtCriteria)
        Me.pnlCriteria.Controls.Add(Me.lblCriteria)
        Me.pnlCriteria.Controls.Add(Me.lblField)
        Me.pnlCriteria.Controls.Add(Me.cmbField)
        Me.pnlCriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCriteria.Location = New System.Drawing.Point(0, 0)
        Me.pnlCriteria.Name = "pnlCriteria"
        Me.pnlCriteria.Size = New System.Drawing.Size(258, 215)
        Me.pnlCriteria.TabIndex = 15
        '
        'cmdAddFilter
        '
        Me.cmdAddFilter.Location = New System.Drawing.Point(164, 167)
        Me.cmdAddFilter.Name = "cmdAddFilter"
        Me.cmdAddFilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddFilter.TabIndex = 13
        Me.cmdAddFilter.Text = "Añadir filtro"
        Me.cmdAddFilter.UseVisualStyleBackColor = True
        '
        'txtCriteria
        '
        Me.txtCriteria.Location = New System.Drawing.Point(12, 70)
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.Size = New System.Drawing.Size(228, 20)
        Me.txtCriteria.TabIndex = 11
        '
        'lblCriteria
        '
        Me.lblCriteria.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria.Location = New System.Drawing.Point(9, 47)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(231, 16)
        Me.lblCriteria.TabIndex = 12
        Me.lblCriteria.Text = "Buscar "
        '
        'lblField
        '
        Me.lblField.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblField.Location = New System.Drawing.Point(9, 105)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(231, 16)
        Me.lblField.TabIndex = 10
        Me.lblField.Text = "En"
        '
        'cmbField
        '
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.Location = New System.Drawing.Point(9, 125)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(231, 21)
        Me.cmbField.TabIndex = 9
        '
        'lvRows
        '
        Me.lvRows.AllowDrop = True
        Me.lvRows.CheckBoxes = True
        Me.lvRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRows.FullRowSelect = True
        Me.lvRows.HideSelection = False
        Me.lvRows.Location = New System.Drawing.Point(0, 77)
        Me.lvRows.Name = "lvRows"
        Me.lvRows.Size = New System.Drawing.Size(735, 419)
        Me.lvRows.TabIndex = 15
        Me.lvRows.UseCompatibleStateImageBehavior = False
        Me.lvRows.View = System.Windows.Forms.View.Details
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.cmdUnSelectAll)
        Me.pnlButtons.Controls.Add(Me.cmdSelectAll)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 38)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(735, 39)
        Me.pnlButtons.TabIndex = 14
        '
        'cmdUnSelectAll
        '
        Me.cmdUnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUnSelectAll.Location = New System.Drawing.Point(608, 9)
        Me.cmdUnSelectAll.Name = "cmdUnSelectAll"
        Me.cmdUnSelectAll.Size = New System.Drawing.Size(115, 23)
        Me.cmdUnSelectAll.TabIndex = 1
        Me.cmdUnSelectAll.Text = "Desmarcar todos"
        Me.cmdUnSelectAll.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSelectAll.Location = New System.Drawing.Point(486, 9)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(115, 23)
        Me.cmdSelectAll.TabIndex = 0
        Me.cmdSelectAll.Text = "Marcar todos"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(735, 38)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Usuario SUPERVISOR"
        '
        'frmDomain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 496)
        Me.Controls.Add(Me.mainSplit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmDomain"
        Me.Text = "Usuario SUPERVISOR"
        Me.mainSplit.Panel1.ResumeLayout(False)
        Me.mainSplit.Panel2.ResumeLayout(False)
        Me.mainSplit.ResumeLayout(False)
        CType(Me.GridCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FilterMenu.ResumeLayout(False)
        Me.pnlCriteria.ResumeLayout(False)
        Me.pnlCriteria.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlCriteria As System.Windows.Forms.Panel
    Friend WithEvents txtCriteria As System.Windows.Forms.TextBox
    Friend WithEvents lblField As System.Windows.Forms.Label
    Friend WithEvents cmbField As System.Windows.Forms.ComboBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents lblFilters As System.Windows.Forms.Label
    Friend WithEvents GridCriteria As System.Windows.Forms.DataGridView
    Friend WithEvents Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FieldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FieldValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCriteria As System.Windows.Forms.Label
    Friend WithEvents cmdAddFilter As System.Windows.Forms.Button
    Friend WithEvents lvRows As System.Windows.Forms.ListView
    Friend WithEvents cmdUnSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents FilterMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FilterMenuRemoveFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterMenuRemoveAll As System.Windows.Forms.ToolStripMenuItem
End Class
