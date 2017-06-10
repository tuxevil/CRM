<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomersDeleted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomersDeleted))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.GridCustomers = New Crm.UI.GridView
        Me.ConfirmDel = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CustomerType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CancelDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reasson = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CancelUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GridCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(927, 24)
        Me.MenuStrip1.TabIndex = 49
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
        Me.MenuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.MenuFileExit.Text = "Salir"
        '
        'GridCustomers
        '
        Me.GridCustomers.AllowUserToAddRows = False
        Me.GridCustomers.AllowUserToDeleteRows = False
        Me.GridCustomers.AllowUserToOrderColumns = True
        Me.GridCustomers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConfirmDel, Me.CustomerType, Me.CustomerCode, Me.CustomerName, Me.CancelDate, Me.Reasson, Me.CancelUser})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridCustomers.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCustomers.GridColor = System.Drawing.SystemColors.Control
        Me.GridCustomers.Location = New System.Drawing.Point(0, 24)
        Me.GridCustomers.Name = "GridCustomers"
        Me.GridCustomers.ReadOnly = True
        Me.GridCustomers.RowHeadersVisible = False
        Me.GridCustomers.RowTemplate.DividerHeight = 5
        Me.GridCustomers.RowTemplate.Height = 30
        Me.GridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCustomers.Size = New System.Drawing.Size(927, 459)
        Me.GridCustomers.TabIndex = 50
        '
        'ConfirmDel
        '
        Me.ConfirmDel.HeaderText = "Confirmar"
        Me.ConfirmDel.Name = "ConfirmDel"
        Me.ConfirmDel.ReadOnly = True
        Me.ConfirmDel.Width = 75
        '
        'CustomerType
        '
        Me.CustomerType.HeaderText = "Tipo"
        Me.CustomerType.Name = "CustomerType"
        Me.CustomerType.ReadOnly = True
        '
        'CustomerCode
        '
        Me.CustomerCode.HeaderText = "Codigo"
        Me.CustomerCode.Name = "CustomerCode"
        Me.CustomerCode.ReadOnly = True
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Razón social"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.Width = 250
        '
        'CancelDate
        '
        Me.CancelDate.HeaderText = "Fecha"
        Me.CancelDate.Name = "CancelDate"
        Me.CancelDate.ReadOnly = True
        '
        'Reasson
        '
        Me.Reasson.HeaderText = "Motivo"
        Me.Reasson.Name = "Reasson"
        Me.Reasson.ReadOnly = True
        Me.Reasson.Width = 200
        '
        'CancelUser
        '
        Me.CancelUser.HeaderText = "Usuario"
        Me.CancelUser.Name = "CancelUser"
        Me.CancelUser.ReadOnly = True
        '
        'frmCustomersDeleted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 483)
        Me.Controls.Add(Me.GridCustomers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomersDeleted"
        Me.Text = "Confirmación de bajas de clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GridCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridCustomers As Crm.UI.GridView
    Friend WithEvents ConfirmDel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CustomerType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CancelDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reasson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CancelUser As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
