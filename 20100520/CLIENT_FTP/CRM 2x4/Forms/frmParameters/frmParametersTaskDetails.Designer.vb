<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametersTaskDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametersTaskDetails))
        Me.MenuReport = New System.Windows.Forms.MenuStrip
        Me.MenuReportList = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByUser = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByType = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByStatus = New System.Windows.Forms.ToolStripMenuItem
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
        Me.GroupType = New System.Windows.Forms.GroupBox
        Me.txtTypeNameTo = New System.Windows.Forms.TextBox
        Me.txtTypeNameFrom = New System.Windows.Forms.TextBox
        Me.txtTypeTo = New System.Windows.Forms.TextBox
        Me.txtTypeFrom = New System.Windows.Forms.TextBox
        Me.lblTypeTo = New System.Windows.Forms.Label
        Me.lblTypeFrom = New System.Windows.Forms.Label
        Me.GroupState = New System.Windows.Forms.GroupBox
        Me.txtStateNameTo = New System.Windows.Forms.TextBox
        Me.txtStateNameFrom = New System.Windows.Forms.TextBox
        Me.txtStateTo = New System.Windows.Forms.TextBox
        Me.txtStateFrom = New System.Windows.Forms.TextBox
        Me.lblStateTo = New System.Windows.Forms.Label
        Me.lblStateFrom = New System.Windows.Forms.Label
        Me.MenuReport.SuspendLayout()
        Me.GroupUser.SuspendLayout()
        Me.GroupDate.SuspendLayout()
        Me.GroupType.SuspendLayout()
        Me.GroupState.SuspendLayout()
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
        Me.MenuReportList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuReportListByUser, Me.MenuReportListByType, Me.MenuReportListByStatus, Me.MenuReportListByDate})
        Me.MenuReportList.Name = "MenuReportList"
        Me.MenuReportList.Size = New System.Drawing.Size(45, 20)
        Me.MenuReportList.Text = "Listar"
        '
        'MenuReportListByUser
        '
        Me.MenuReportListByUser.Name = "MenuReportListByUser"
        Me.MenuReportListByUser.Size = New System.Drawing.Size(152, 22)
        Me.MenuReportListByUser.Tag = "USERNAME"
        Me.MenuReportListByUser.Text = "Por usuario"
        '
        'MenuReportListByType
        '
        Me.MenuReportListByType.Name = "MenuReportListByType"
        Me.MenuReportListByType.Size = New System.Drawing.Size(152, 22)
        Me.MenuReportListByType.Tag = "TYPE"
        Me.MenuReportListByType.Text = "Por tipo"
        '
        'MenuReportListByStatus
        '
        Me.MenuReportListByStatus.Name = "MenuReportListByStatus"
        Me.MenuReportListByStatus.Size = New System.Drawing.Size(152, 22)
        Me.MenuReportListByStatus.Tag = "STATE"
        Me.MenuReportListByStatus.Text = "Por estado"
        '
        'MenuReportListByDate
        '
        Me.MenuReportListByDate.Name = "MenuReportListByDate"
        Me.MenuReportListByDate.Size = New System.Drawing.Size(152, 22)
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
        'GroupType
        '
        Me.GroupType.Controls.Add(Me.txtTypeNameTo)
        Me.GroupType.Controls.Add(Me.txtTypeNameFrom)
        Me.GroupType.Controls.Add(Me.txtTypeTo)
        Me.GroupType.Controls.Add(Me.txtTypeFrom)
        Me.GroupType.Controls.Add(Me.lblTypeTo)
        Me.GroupType.Controls.Add(Me.lblTypeFrom)
        Me.GroupType.Enabled = False
        Me.GroupType.Location = New System.Drawing.Point(12, 256)
        Me.GroupType.Name = "GroupType"
        Me.GroupType.Size = New System.Drawing.Size(426, 100)
        Me.GroupType.TabIndex = 8
        Me.GroupType.TabStop = False
        Me.GroupType.Text = "Tipo de tarea"
        '
        'txtTypeNameTo
        '
        Me.txtTypeNameTo.Enabled = False
        Me.txtTypeNameTo.Location = New System.Drawing.Point(115, 58)
        Me.txtTypeNameTo.Name = "txtTypeNameTo"
        Me.txtTypeNameTo.ReadOnly = True
        Me.txtTypeNameTo.Size = New System.Drawing.Size(305, 20)
        Me.txtTypeNameTo.TabIndex = 6
        '
        'txtTypeNameFrom
        '
        Me.txtTypeNameFrom.Enabled = False
        Me.txtTypeNameFrom.Location = New System.Drawing.Point(115, 32)
        Me.txtTypeNameFrom.Name = "txtTypeNameFrom"
        Me.txtTypeNameFrom.ReadOnly = True
        Me.txtTypeNameFrom.Size = New System.Drawing.Size(305, 20)
        Me.txtTypeNameFrom.TabIndex = 5
        '
        'txtTypeTo
        '
        Me.txtTypeTo.Location = New System.Drawing.Point(80, 58)
        Me.txtTypeTo.Name = "txtTypeTo"
        Me.txtTypeTo.Size = New System.Drawing.Size(28, 20)
        Me.txtTypeTo.TabIndex = 4
        '
        'txtTypeFrom
        '
        Me.txtTypeFrom.Location = New System.Drawing.Point(80, 32)
        Me.txtTypeFrom.Name = "txtTypeFrom"
        Me.txtTypeFrom.Size = New System.Drawing.Size(28, 20)
        Me.txtTypeFrom.TabIndex = 3
        '
        'lblTypeTo
        '
        Me.lblTypeTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeTo.Location = New System.Drawing.Point(18, 55)
        Me.lblTypeTo.Name = "lblTypeTo"
        Me.lblTypeTo.Size = New System.Drawing.Size(55, 23)
        Me.lblTypeTo.TabIndex = 2
        Me.lblTypeTo.Text = "Hasta"
        Me.lblTypeTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTypeFrom
        '
        Me.lblTypeFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeFrom.Location = New System.Drawing.Point(18, 32)
        Me.lblTypeFrom.Name = "lblTypeFrom"
        Me.lblTypeFrom.Size = New System.Drawing.Size(55, 23)
        Me.lblTypeFrom.TabIndex = 1
        Me.lblTypeFrom.Text = "Desde"
        Me.lblTypeFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupState
        '
        Me.GroupState.Controls.Add(Me.txtStateNameTo)
        Me.GroupState.Controls.Add(Me.txtStateNameFrom)
        Me.GroupState.Controls.Add(Me.txtStateTo)
        Me.GroupState.Controls.Add(Me.txtStateFrom)
        Me.GroupState.Controls.Add(Me.lblStateTo)
        Me.GroupState.Controls.Add(Me.lblStateFrom)
        Me.GroupState.Enabled = False
        Me.GroupState.Location = New System.Drawing.Point(12, 362)
        Me.GroupState.Name = "GroupState"
        Me.GroupState.Size = New System.Drawing.Size(426, 100)
        Me.GroupState.TabIndex = 9
        Me.GroupState.TabStop = False
        Me.GroupState.Text = "Estado"
        '
        'txtStateNameTo
        '
        Me.txtStateNameTo.Enabled = False
        Me.txtStateNameTo.Location = New System.Drawing.Point(115, 58)
        Me.txtStateNameTo.Name = "txtStateNameTo"
        Me.txtStateNameTo.ReadOnly = True
        Me.txtStateNameTo.Size = New System.Drawing.Size(305, 20)
        Me.txtStateNameTo.TabIndex = 6
        '
        'txtStateNameFrom
        '
        Me.txtStateNameFrom.Enabled = False
        Me.txtStateNameFrom.Location = New System.Drawing.Point(115, 32)
        Me.txtStateNameFrom.Name = "txtStateNameFrom"
        Me.txtStateNameFrom.ReadOnly = True
        Me.txtStateNameFrom.Size = New System.Drawing.Size(305, 20)
        Me.txtStateNameFrom.TabIndex = 5
        '
        'txtStateTo
        '
        Me.txtStateTo.Location = New System.Drawing.Point(80, 58)
        Me.txtStateTo.Name = "txtStateTo"
        Me.txtStateTo.Size = New System.Drawing.Size(28, 20)
        Me.txtStateTo.TabIndex = 4
        '
        'txtStateFrom
        '
        Me.txtStateFrom.Location = New System.Drawing.Point(80, 32)
        Me.txtStateFrom.Name = "txtStateFrom"
        Me.txtStateFrom.Size = New System.Drawing.Size(28, 20)
        Me.txtStateFrom.TabIndex = 3
        '
        'lblStateTo
        '
        Me.lblStateTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTo.Location = New System.Drawing.Point(18, 55)
        Me.lblStateTo.Name = "lblStateTo"
        Me.lblStateTo.Size = New System.Drawing.Size(55, 23)
        Me.lblStateTo.TabIndex = 2
        Me.lblStateTo.Text = "Hasta"
        Me.lblStateTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStateFrom
        '
        Me.lblStateFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateFrom.Location = New System.Drawing.Point(18, 32)
        Me.lblStateFrom.Name = "lblStateFrom"
        Me.lblStateFrom.Size = New System.Drawing.Size(55, 23)
        Me.lblStateFrom.TabIndex = 1
        Me.lblStateFrom.Text = "Desde"
        Me.lblStateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmParametersTaskSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 474)
        Me.Controls.Add(Me.GroupState)
        Me.Controls.Add(Me.GroupType)
        Me.Controls.Add(Me.GroupDate)
        Me.Controls.Add(Me.GroupUser)
        Me.Controls.Add(Me.MenuReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuReport
        Me.Name = "frmParametersTaskSummary"
        Me.Text = "Listado de tareas"
        Me.MenuReport.ResumeLayout(False)
        Me.MenuReport.PerformLayout()
        Me.GroupUser.ResumeLayout(False)
        Me.GroupUser.PerformLayout()
        Me.GroupDate.ResumeLayout(False)
        Me.GroupType.ResumeLayout(False)
        Me.GroupType.PerformLayout()
        Me.GroupState.ResumeLayout(False)
        Me.GroupState.PerformLayout()
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
    Friend WithEvents GroupType As System.Windows.Forms.GroupBox
    Friend WithEvents txtTypeNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeTo As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblTypeTo As System.Windows.Forms.Label
    Friend WithEvents lblTypeFrom As System.Windows.Forms.Label
    Friend WithEvents GroupState As System.Windows.Forms.GroupBox
    Friend WithEvents txtStateNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtStateNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtStateTo As System.Windows.Forms.TextBox
    Friend WithEvents txtStateFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblStateTo As System.Windows.Forms.Label
    Friend WithEvents lblStateFrom As System.Windows.Forms.Label
    Friend WithEvents MenuReportListByUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportListByType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportListByStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportListByDate As System.Windows.Forms.ToolStripMenuItem
End Class
