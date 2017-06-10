<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametersPotentialCustomersEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametersPotentialCustomersEntry))
        Me.MenuReport = New System.Windows.Forms.MenuStrip
        Me.MenuReportList = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByUser = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByDate = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.lblUserFrom = New System.Windows.Forms.Label
        Me.GroupUser = New System.Windows.Forms.GroupBox
        Me.txtUserNameTo = New System.Windows.Forms.TextBox
        Me.txtUserNameFrom = New System.Windows.Forms.TextBox
        Me.txtUserTo = New System.Windows.Forms.TextBox
        Me.txtUserFrom = New System.Windows.Forms.TextBox
        Me.lblUserTo = New System.Windows.Forms.Label
        Me.GroupDate = New System.Windows.Forms.GroupBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblDateTo = New System.Windows.Forms.Label
        Me.lblDatefrom = New System.Windows.Forms.Label
        Me.GroupCustomer = New System.Windows.Forms.GroupBox
        Me.txtCustomerNameTo = New System.Windows.Forms.TextBox
        Me.txtCustomerNameFrom = New System.Windows.Forms.TextBox
        Me.txtCustomerTo = New System.Windows.Forms.TextBox
        Me.txtCustomerFrom = New System.Windows.Forms.TextBox
        Me.lblCustomerTo = New System.Windows.Forms.Label
        Me.lblCustomerFrom = New System.Windows.Forms.Label
        Me.MenuReport.SuspendLayout()
        Me.GroupUser.SuspendLayout()
        Me.GroupDate.SuspendLayout()
        Me.GroupCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuReport
        '
        Me.MenuReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuReportList, Me.MenuReportCancel})
        Me.MenuReport.Location = New System.Drawing.Point(0, 0)
        Me.MenuReport.Name = "MenuReport"
        Me.MenuReport.Size = New System.Drawing.Size(450, 24)
        Me.MenuReport.TabIndex = 0
        Me.MenuReport.Text = "MenuStrip1"
        '
        'MenuReportList
        '
        Me.MenuReportList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuReportListByUser, Me.MenuReportListByDate})
        Me.MenuReportList.Name = "MenuReportList"
        Me.MenuReportList.Size = New System.Drawing.Size(45, 20)
        Me.MenuReportList.Text = "Listar"
        '
        'MenuReportListByUser
        '
        Me.MenuReportListByUser.Name = "MenuReportListByUser"
        Me.MenuReportListByUser.Size = New System.Drawing.Size(139, 22)
        Me.MenuReportListByUser.Tag = "USERNAME"
        Me.MenuReportListByUser.Text = "Por usuario"
        '
        'MenuReportListByDate
        '
        Me.MenuReportListByDate.Name = "MenuReportListByDate"
        Me.MenuReportListByDate.Size = New System.Drawing.Size(139, 22)
        Me.MenuReportListByDate.Tag = "INITDATE"
        Me.MenuReportListByDate.Text = "Por fecha"
        '
        'MenuReportCancel
        '
        Me.MenuReportCancel.Name = "MenuReportCancel"
        Me.MenuReportCancel.Size = New System.Drawing.Size(61, 20)
        Me.MenuReportCancel.Text = "Cancelar"
        '
        'lblUserFrom
        '
        Me.lblUserFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserFrom.Location = New System.Drawing.Point(18, 32)
        Me.lblUserFrom.Name = "lblUserFrom"
        Me.lblUserFrom.Size = New System.Drawing.Size(55, 23)
        Me.lblUserFrom.TabIndex = 1
        Me.lblUserFrom.Text = "Desde"
        Me.lblUserFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupUser
        '
        Me.GroupUser.Controls.Add(Me.txtUserNameTo)
        Me.GroupUser.Controls.Add(Me.txtUserNameFrom)
        Me.GroupUser.Controls.Add(Me.txtUserTo)
        Me.GroupUser.Controls.Add(Me.txtUserFrom)
        Me.GroupUser.Controls.Add(Me.lblUserTo)
        Me.GroupUser.Controls.Add(Me.lblUserFrom)
        Me.GroupUser.Enabled = False
        Me.GroupUser.Location = New System.Drawing.Point(12, 44)
        Me.GroupUser.Name = "GroupUser"
        Me.GroupUser.Size = New System.Drawing.Size(426, 100)
        Me.GroupUser.TabIndex = 2
        Me.GroupUser.TabStop = False
        Me.GroupUser.Text = "Usuario"
        '
        'txtUserNameTo
        '
        Me.txtUserNameTo.Enabled = False
        Me.txtUserNameTo.Location = New System.Drawing.Point(115, 58)
        Me.txtUserNameTo.Name = "txtUserNameTo"
        Me.txtUserNameTo.ReadOnly = True
        Me.txtUserNameTo.Size = New System.Drawing.Size(305, 20)
        Me.txtUserNameTo.TabIndex = 6
        '
        'txtUserNameFrom
        '
        Me.txtUserNameFrom.Enabled = False
        Me.txtUserNameFrom.Location = New System.Drawing.Point(115, 32)
        Me.txtUserNameFrom.Name = "txtUserNameFrom"
        Me.txtUserNameFrom.ReadOnly = True
        Me.txtUserNameFrom.Size = New System.Drawing.Size(305, 20)
        Me.txtUserNameFrom.TabIndex = 5
        '
        'txtUserTo
        '
        Me.txtUserTo.Location = New System.Drawing.Point(80, 58)
        Me.txtUserTo.Name = "txtUserTo"
        Me.txtUserTo.Size = New System.Drawing.Size(28, 20)
        Me.txtUserTo.TabIndex = 4
        '
        'txtUserFrom
        '
        Me.txtUserFrom.Location = New System.Drawing.Point(80, 32)
        Me.txtUserFrom.Name = "txtUserFrom"
        Me.txtUserFrom.Size = New System.Drawing.Size(28, 20)
        Me.txtUserFrom.TabIndex = 3
        '
        'lblUserTo
        '
        Me.lblUserTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserTo.Location = New System.Drawing.Point(18, 55)
        Me.lblUserTo.Name = "lblUserTo"
        Me.lblUserTo.Size = New System.Drawing.Size(55, 23)
        Me.lblUserTo.TabIndex = 2
        Me.lblUserTo.Text = "Hasta"
        Me.lblUserTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupDate
        '
        Me.GroupDate.Controls.Add(Me.DateTo)
        Me.GroupDate.Controls.Add(Me.DateFrom)
        Me.GroupDate.Controls.Add(Me.lblDateTo)
        Me.GroupDate.Controls.Add(Me.lblDatefrom)
        Me.GroupDate.Enabled = False
        Me.GroupDate.Location = New System.Drawing.Point(12, 150)
        Me.GroupDate.Name = "GroupDate"
        Me.GroupDate.Size = New System.Drawing.Size(426, 100)
        Me.GroupDate.TabIndex = 7
        Me.GroupDate.TabStop = False
        Me.GroupDate.Text = "Fecha"
        '
        'DateTo
        '
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTo.Location = New System.Drawing.Point(80, 60)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(87, 20)
        Me.DateTo.TabIndex = 4
        '
        'DateFrom
        '
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFrom.Location = New System.Drawing.Point(80, 34)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(87, 20)
        Me.DateFrom.TabIndex = 3
        '
        'lblDateTo
        '
        Me.lblDateTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTo.Location = New System.Drawing.Point(18, 55)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(55, 23)
        Me.lblDateTo.TabIndex = 2
        Me.lblDateTo.Text = "Hasta"
        Me.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDatefrom
        '
        Me.lblDatefrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatefrom.Location = New System.Drawing.Point(18, 32)
        Me.lblDatefrom.Name = "lblDatefrom"
        Me.lblDatefrom.Size = New System.Drawing.Size(55, 23)
        Me.lblDatefrom.TabIndex = 1
        Me.lblDatefrom.Text = "Desde"
        Me.lblDatefrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupCustomer
        '
        Me.GroupCustomer.Controls.Add(Me.txtCustomerNameTo)
        Me.GroupCustomer.Controls.Add(Me.txtCustomerNameFrom)
        Me.GroupCustomer.Controls.Add(Me.txtCustomerTo)
        Me.GroupCustomer.Controls.Add(Me.txtCustomerFrom)
        Me.GroupCustomer.Controls.Add(Me.lblCustomerTo)
        Me.GroupCustomer.Controls.Add(Me.lblCustomerFrom)
        Me.GroupCustomer.Enabled = False
        Me.GroupCustomer.Location = New System.Drawing.Point(12, 256)
        Me.GroupCustomer.Name = "GroupCustomer"
        Me.GroupCustomer.Size = New System.Drawing.Size(426, 100)
        Me.GroupCustomer.TabIndex = 8
        Me.GroupCustomer.TabStop = False
        Me.GroupCustomer.Text = "Cliente"
        '
        'txtCustomerNameTo
        '
        Me.txtCustomerNameTo.Enabled = False
        Me.txtCustomerNameTo.Location = New System.Drawing.Point(147, 58)
        Me.txtCustomerNameTo.Name = "txtCustomerNameTo"
        Me.txtCustomerNameTo.ReadOnly = True
        Me.txtCustomerNameTo.Size = New System.Drawing.Size(273, 20)
        Me.txtCustomerNameTo.TabIndex = 6
        '
        'txtCustomerNameFrom
        '
        Me.txtCustomerNameFrom.Enabled = False
        Me.txtCustomerNameFrom.Location = New System.Drawing.Point(147, 32)
        Me.txtCustomerNameFrom.Name = "txtCustomerNameFrom"
        Me.txtCustomerNameFrom.ReadOnly = True
        Me.txtCustomerNameFrom.Size = New System.Drawing.Size(273, 20)
        Me.txtCustomerNameFrom.TabIndex = 5
        '
        'txtCustomerTo
        '
        Me.txtCustomerTo.Location = New System.Drawing.Point(80, 58)
        Me.txtCustomerTo.Name = "txtCustomerTo"
        Me.txtCustomerTo.Size = New System.Drawing.Size(61, 20)
        Me.txtCustomerTo.TabIndex = 4
        '
        'txtCustomerFrom
        '
        Me.txtCustomerFrom.Location = New System.Drawing.Point(80, 32)
        Me.txtCustomerFrom.Name = "txtCustomerFrom"
        Me.txtCustomerFrom.Size = New System.Drawing.Size(61, 20)
        Me.txtCustomerFrom.TabIndex = 3
        '
        'lblCustomerTo
        '
        Me.lblCustomerTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerTo.Location = New System.Drawing.Point(18, 55)
        Me.lblCustomerTo.Name = "lblCustomerTo"
        Me.lblCustomerTo.Size = New System.Drawing.Size(55, 23)
        Me.lblCustomerTo.TabIndex = 2
        Me.lblCustomerTo.Text = "Hasta"
        Me.lblCustomerTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomerFrom
        '
        Me.lblCustomerFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerFrom.Location = New System.Drawing.Point(18, 32)
        Me.lblCustomerFrom.Name = "lblCustomerFrom"
        Me.lblCustomerFrom.Size = New System.Drawing.Size(55, 23)
        Me.lblCustomerFrom.TabIndex = 1
        Me.lblCustomerFrom.Text = "Desde"
        Me.lblCustomerFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmParametersPotentialCustomersEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 371)
        Me.Controls.Add(Me.GroupCustomer)
        Me.Controls.Add(Me.GroupDate)
        Me.Controls.Add(Me.GroupUser)
        Me.Controls.Add(Me.MenuReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuReport
        Me.Name = "frmParametersPotentialCustomersEntry"
        Me.Text = "Alta de clientes potenciales"
        Me.MenuReport.ResumeLayout(False)
        Me.MenuReport.PerformLayout()
        Me.GroupUser.ResumeLayout(False)
        Me.GroupUser.PerformLayout()
        Me.GroupDate.ResumeLayout(False)
        Me.GroupCustomer.ResumeLayout(False)
        Me.GroupCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuReport As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuReportList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserFrom As System.Windows.Forms.Label
    Friend WithEvents GroupUser As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserTo As System.Windows.Forms.Label
    Friend WithEvents txtUserTo As System.Windows.Forms.TextBox
    Friend WithEvents txtUserFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtUserNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtUserNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents GroupDate As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateTo As System.Windows.Forms.Label
    Friend WithEvents lblDatefrom As System.Windows.Forms.Label
    Friend WithEvents GroupCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerTo As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerTo As System.Windows.Forms.Label
    Friend WithEvents lblCustomerFrom As System.Windows.Forms.Label
    Friend WithEvents MenuReportListByUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportListByDate As System.Windows.Forms.ToolStripMenuItem
End Class
