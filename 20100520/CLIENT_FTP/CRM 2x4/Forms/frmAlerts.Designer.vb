<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlerts
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlerts))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.GridAlerts = New Crm.UI.GridView
        Me.AlertId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlertActive = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AlertInitDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlertExecDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlertSubject = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlertDetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GridAlerts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'GridAlerts
        '
        Me.GridAlerts.AllowUserToAddRows = False
        Me.GridAlerts.AllowUserToDeleteRows = False
        Me.GridAlerts.AllowUserToOrderColumns = True
        Me.GridAlerts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAlerts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlertId, Me.AlertActive, Me.AlertInitDate, Me.AlertExecDate, Me.AlertSubject, Me.AlertDetail})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridAlerts.DefaultCellStyle = DataGridViewCellStyle4
        Me.GridAlerts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAlerts.GridColor = System.Drawing.SystemColors.Control
        Me.GridAlerts.Location = New System.Drawing.Point(0, 24)
        Me.GridAlerts.Name = "GridAlerts"
        Me.GridAlerts.ReadOnly = True
        Me.GridAlerts.RowHeadersVisible = False
        Me.GridAlerts.RowTemplate.DividerHeight = 5
        Me.GridAlerts.RowTemplate.Height = 30
        Me.GridAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridAlerts.Size = New System.Drawing.Size(651, 474)
        Me.GridAlerts.TabIndex = 48
        '
        'AlertId
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.AlertId.DefaultCellStyle = DataGridViewCellStyle1
        Me.AlertId.HeaderText = "AlertId"
        Me.AlertId.Name = "AlertId"
        Me.AlertId.ReadOnly = True
        Me.AlertId.Visible = False
        '
        'AlertActive
        '
        Me.AlertActive.HeaderText = "Activa"
        Me.AlertActive.Name = "AlertActive"
        Me.AlertActive.ReadOnly = True
        Me.AlertActive.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AlertActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AlertActive.Width = 50
        '
        'AlertInitDate
        '
        DataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss tt"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.AlertInitDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.AlertInitDate.HeaderText = "Inicio"
        Me.AlertInitDate.Name = "AlertInitDate"
        Me.AlertInitDate.ReadOnly = True
        '
        'AlertExecDate
        '
        DataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm:ss tt"
        Me.AlertExecDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.AlertExecDate.HeaderText = "Ultimo aviso"
        Me.AlertExecDate.Name = "AlertExecDate"
        Me.AlertExecDate.ReadOnly = True
        '
        'AlertSubject
        '
        Me.AlertSubject.HeaderText = "Asunto"
        Me.AlertSubject.Name = "AlertSubject"
        Me.AlertSubject.ReadOnly = True
        Me.AlertSubject.Width = 150
        '
        'AlertDetail
        '
        Me.AlertDetail.HeaderText = "Detalle"
        Me.AlertDetail.Name = "AlertDetail"
        Me.AlertDetail.ReadOnly = True
        Me.AlertDetail.Width = 250
        '
        'frmAlerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 498)
        Me.Controls.Add(Me.GridAlerts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAlerts"
        Me.Text = "Mis alertas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GridAlerts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridAlerts As Crm.UI.GridView
    Friend WithEvents AlertId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlertActive As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AlertInitDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlertExecDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlertSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlertDetail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
