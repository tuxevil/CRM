<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditionTask
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditionTask))
        Me.Browser = New System.Windows.Forms.ToolStrip
        Me.BrowserAccept = New System.Windows.Forms.ToolStripButton
        Me.BrowserCancel = New System.Windows.Forms.ToolStripButton
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbPriority = New System.Windows.Forms.ComboBox
        Me.lblPriority = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.InitDate = New System.Windows.Forms.DateTimePicker
        Me.InitTime = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbUser = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOwnerDetail = New System.Windows.Forms.TextBox
        Me.lblOwnerDetail = New System.Windows.Forms.Label
        Me.txtDetail = New System.Windows.Forms.TextBox
        Me.lblDetail = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.pnlEntities = New System.Windows.Forms.Panel
        Me.GridEntities = New Crm.UI.GridView
        Me.EntitySystemType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntityType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntityCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblAddCustomer = New System.Windows.Forms.Label
        Me.lblAddTask = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkPersonal = New System.Windows.Forms.CheckBox
        Me.chkAlert = New System.Windows.Forms.CheckBox
        Me.Browser.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.pnlEntities.SuspendLayout()
        CType(Me.GridEntities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAccept, Me.BrowserCancel})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(678, 31)
        Me.Browser.TabIndex = 45
        Me.Browser.Text = "ToolStrip1"
        '
        'BrowserAccept
        '
        Me.BrowserAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAccept.Image = Global.Crm.UI.My.Resources.Resources.accept
        Me.BrowserAccept.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAccept.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAccept.Name = "BrowserAccept"
        Me.BrowserAccept.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAccept.Text = "Guardar cambios"
        '
        'BrowserCancel
        '
        Me.BrowserCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserCancel.Image = Global.Crm.UI.My.Resources.Resources.Cancel
        Me.BrowserCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserCancel.Name = "BrowserCancel"
        Me.BrowserCancel.Size = New System.Drawing.Size(28, 28)
        Me.BrowserCancel.Text = "Deshacer cambios"
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(678, 24)
        Me.MainMenu.TabIndex = 44
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
        'cmbPriority
        '
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.Location = New System.Drawing.Point(118, 123)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Size = New System.Drawing.Size(204, 21)
        Me.cmbPriority.TabIndex = 2
        '
        'lblPriority
        '
        Me.lblPriority.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.Location = New System.Drawing.Point(12, 123)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(100, 21)
        Me.lblPriority.TabIndex = 47
        Me.lblPriority.Tag = "CUSTOMER/SALESTERM/CODE"
        Me.lblPriority.Text = "PRIORIDAD"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Tag = ""
        Me.Label1.Text = "FECHA DE INICIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InitDate
        '
        Me.InitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InitDate.Location = New System.Drawing.Point(462, 68)
        Me.InitDate.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.InitDate.Name = "InitDate"
        Me.InitDate.Size = New System.Drawing.Size(87, 20)
        Me.InitDate.TabIndex = 3
        '
        'InitTime
        '
        Me.InitTime.CustomFormat = "hh:mm"
        Me.InitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InitTime.Location = New System.Drawing.Point(606, 68)
        Me.InitTime.Name = "InitTime"
        Me.InitTime.ShowUpDown = True
        Me.InitTime.Size = New System.Drawing.Size(51, 20)
        Me.InitTime.TabIndex = 4
        Me.InitTime.Value = New Date(2009, 7, 6, 0, 27, 0, 0)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Tag = ""
        Me.Label2.Text = "HORA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(118, 69)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(204, 21)
        Me.cmbUser.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Tag = ""
        Me.Label3.Text = "RESPONSABLE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOwnerDetail
        '
        Me.txtOwnerDetail.Location = New System.Drawing.Point(15, 308)
        Me.txtOwnerDetail.Multiline = True
        Me.txtOwnerDetail.Name = "txtOwnerDetail"
        Me.txtOwnerDetail.ReadOnly = True
        Me.txtOwnerDetail.Size = New System.Drawing.Size(645, 68)
        Me.txtOwnerDetail.TabIndex = 8
        '
        'lblOwnerDetail
        '
        Me.lblOwnerDetail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerDetail.Location = New System.Drawing.Point(15, 282)
        Me.lblOwnerDetail.Name = "lblOwnerDetail"
        Me.lblOwnerDetail.Size = New System.Drawing.Size(645, 23)
        Me.lblOwnerDetail.TabIndex = 56
        Me.lblOwnerDetail.Text = "DETALLE INICIAL"
        Me.lblOwnerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDetail
        '
        Me.txtDetail.Location = New System.Drawing.Point(15, 188)
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.ReadOnly = True
        Me.txtDetail.Size = New System.Drawing.Size(645, 91)
        Me.txtDetail.TabIndex = 7
        '
        'lblDetail
        '
        Me.lblDetail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(15, 164)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(645, 23)
        Me.lblDetail.TabIndex = 54
        Me.lblDetail.Text = "DETALLE"
        Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 59
        Me.Label4.Tag = ""
        Me.Label4.Text = "TIPO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(118, 96)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(204, 21)
        Me.cmbType.TabIndex = 1
        '
        'pnlEntities
        '
        Me.pnlEntities.Controls.Add(Me.GridEntities)
        Me.pnlEntities.Controls.Add(Me.lblAddCustomer)
        Me.pnlEntities.Controls.Add(Me.lblAddTask)
        Me.pnlEntities.Controls.Add(Me.Label5)
        Me.pnlEntities.Location = New System.Drawing.Point(15, 382)
        Me.pnlEntities.Name = "pnlEntities"
        Me.pnlEntities.Size = New System.Drawing.Size(645, 159)
        Me.pnlEntities.TabIndex = 60
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridEntities.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridEntities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEntities.GridColor = System.Drawing.SystemColors.Control
        Me.GridEntities.Location = New System.Drawing.Point(0, 21)
        Me.GridEntities.Name = "GridEntities"
        Me.GridEntities.ReadOnly = True
        Me.GridEntities.RowHeadersVisible = False
        Me.GridEntities.RowTemplate.DividerHeight = 5
        Me.GridEntities.RowTemplate.Height = 30
        Me.GridEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEntities.Size = New System.Drawing.Size(645, 96)
        Me.GridEntities.TabIndex = 9
        '
        'EntitySystemType
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon
        Me.EntitySystemType.DefaultCellStyle = DataGridViewCellStyle1
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
        'lblAddCustomer
        '
        Me.lblAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddCustomer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAddCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddCustomer.ForeColor = System.Drawing.Color.Blue
        Me.lblAddCustomer.Location = New System.Drawing.Point(0, 117)
        Me.lblAddCustomer.Name = "lblAddCustomer"
        Me.lblAddCustomer.Size = New System.Drawing.Size(645, 21)
        Me.lblAddCustomer.TabIndex = 10
        Me.lblAddCustomer.Tag = ""
        Me.lblAddCustomer.Text = "Añadir cliente"
        Me.lblAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddTask
        '
        Me.lblAddTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddTask.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAddTask.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTask.ForeColor = System.Drawing.Color.Blue
        Me.lblAddTask.Location = New System.Drawing.Point(0, 138)
        Me.lblAddTask.Name = "lblAddTask"
        Me.lblAddTask.Size = New System.Drawing.Size(645, 21)
        Me.lblAddTask.TabIndex = 11
        Me.lblAddTask.Tag = ""
        Me.lblAddTask.Text = "Añadir tarea"
        Me.lblAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(645, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Tag = ""
        Me.Label5.Text = "ENTIDADES RELACIONADAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPersonal
        '
        Me.chkPersonal.AutoSize = True
        Me.chkPersonal.Location = New System.Drawing.Point(564, 125)
        Me.chkPersonal.Name = "chkPersonal"
        Me.chkPersonal.Size = New System.Drawing.Size(62, 17)
        Me.chkPersonal.TabIndex = 6
        Me.chkPersonal.Text = "Privado"
        Me.chkPersonal.UseVisualStyleBackColor = True
        '
        'chkAlert
        '
        Me.chkAlert.AutoSize = True
        Me.chkAlert.Location = New System.Drawing.Point(564, 104)
        Me.chkAlert.Name = "chkAlert"
        Me.chkAlert.Size = New System.Drawing.Size(93, 17)
        Me.chkAlert.TabIndex = 5
        Me.chkAlert.Text = "Generar alerta"
        Me.chkAlert.UseVisualStyleBackColor = True
        '
        'frmEditionTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 557)
        Me.Controls.Add(Me.chkAlert)
        Me.Controls.Add(Me.chkPersonal)
        Me.Controls.Add(Me.pnlEntities)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtOwnerDetail)
        Me.Controls.Add(Me.lblOwnerDetail)
        Me.Controls.Add(Me.txtDetail)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InitTime)
        Me.Controls.Add(Me.InitDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.cmbPriority)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(686, 564)
        Me.Name = "frmEditionTask"
        Me.Text = "Tareas"
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.pnlEntities.ResumeLayout(False)
        CType(Me.GridEntities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Browser As System.Windows.Forms.ToolStrip
    Friend WithEvents BrowserAccept As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents InitTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOwnerDetail As System.Windows.Forms.TextBox
    Friend WithEvents lblOwnerDetail As System.Windows.Forms.Label
    Friend WithEvents txtDetail As System.Windows.Forms.TextBox
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents pnlEntities As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAddTask As System.Windows.Forms.Label
    Friend WithEvents GridEntities As Crm.UI.GridView
    Friend WithEvents lblAddCustomer As System.Windows.Forms.Label
    Friend WithEvents chkPersonal As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlert As System.Windows.Forms.CheckBox
    Friend WithEvents EntitySystemType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntityType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntityCode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
