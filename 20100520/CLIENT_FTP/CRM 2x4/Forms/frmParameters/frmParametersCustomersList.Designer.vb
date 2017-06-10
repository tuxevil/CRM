<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametersCustomersList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametersCustomersList))
        Me.MenuReport = New System.Windows.Forms.MenuStrip
        Me.MenuReportList = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByState = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByZone = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportListByEmployee = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.lblZoneFrom = New System.Windows.Forms.Label
        Me.GroupZone = New System.Windows.Forms.GroupBox
        Me.txtZoneNameTo = New System.Windows.Forms.TextBox
        Me.txtZoneNameFrom = New System.Windows.Forms.TextBox
        Me.txtZoneTo = New System.Windows.Forms.TextBox
        Me.txtZoneFrom = New System.Windows.Forms.TextBox
        Me.lblZoneTo = New System.Windows.Forms.Label
        Me.GroupCustomer = New System.Windows.Forms.GroupBox
        Me.txtCustomerNameTo = New System.Windows.Forms.TextBox
        Me.txtCustomerNameFrom = New System.Windows.Forms.TextBox
        Me.txtCustomerTo = New System.Windows.Forms.TextBox
        Me.txtCustomerFrom = New System.Windows.Forms.TextBox
        Me.lblCustomerTo = New System.Windows.Forms.Label
        Me.lblCustomerFrom = New System.Windows.Forms.Label
        Me.GroupState = New System.Windows.Forms.GroupBox
        Me.txtStateNameTo = New System.Windows.Forms.TextBox
        Me.txtStateNameFrom = New System.Windows.Forms.TextBox
        Me.txtStateTo = New System.Windows.Forms.TextBox
        Me.txtStateFrom = New System.Windows.Forms.TextBox
        Me.lblStateTo = New System.Windows.Forms.Label
        Me.lblStatefrom = New System.Windows.Forms.Label
        Me.GroupCustomerType = New System.Windows.Forms.GroupBox
        Me.optPotentialCustomer = New System.Windows.Forms.RadioButton
        Me.optRealCustomer = New System.Windows.Forms.RadioButton
        Me.GroupEmployee = New System.Windows.Forms.GroupBox
        Me.txtEmployeeNameTo = New System.Windows.Forms.TextBox
        Me.txtEmployeeNameFrom = New System.Windows.Forms.TextBox
        Me.txtEmployeeTo = New System.Windows.Forms.TextBox
        Me.txtEmployeeFrom = New System.Windows.Forms.TextBox
        Me.lblEmployeeTo = New System.Windows.Forms.Label
        Me.lblEmployeeFrom = New System.Windows.Forms.Label
        Me.MenuReport.SuspendLayout()
        Me.GroupZone.SuspendLayout()
        Me.GroupCustomer.SuspendLayout()
        Me.GroupState.SuspendLayout()
        Me.GroupCustomerType.SuspendLayout()
        Me.GroupEmployee.SuspendLayout()
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
        Me.MenuReportList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuReportListByState, Me.MenuReportListByZone, Me.MenuReportListByEmployee})
        Me.MenuReportList.Name = "MenuReportList"
        Me.MenuReportList.Size = New System.Drawing.Size(45, 20)
        Me.MenuReportList.Text = "Listar"
        '
        'MenuReportListByState
        '
        Me.MenuReportListByState.Name = "MenuReportListByState"
        Me.MenuReportListByState.Size = New System.Drawing.Size(150, 22)
        Me.MenuReportListByState.Tag = "STATENAME"
        Me.MenuReportListByState.Text = "Por provincia"
        '
        'MenuReportListByZone
        '
        Me.MenuReportListByZone.Name = "MenuReportListByZone"
        Me.MenuReportListByZone.Size = New System.Drawing.Size(150, 22)
        Me.MenuReportListByZone.Tag = "ZONENAME"
        Me.MenuReportListByZone.Text = "Por zona"
        '
        'MenuReportListByEmployee
        '
        Me.MenuReportListByEmployee.Name = "MenuReportListByEmployee"
        Me.MenuReportListByEmployee.Size = New System.Drawing.Size(150, 22)
        Me.MenuReportListByEmployee.Tag = "EMPLOYEENAME"
        Me.MenuReportListByEmployee.Text = "Por vendedor"
        '
        'MenuReportCancel
        '
        Me.MenuReportCancel.Name = "MenuReportCancel"
        Me.MenuReportCancel.Size = New System.Drawing.Size(61, 20)
        Me.MenuReportCancel.Text = "Cancelar"
        '
        'lblZoneFrom
        '
        Me.lblZoneFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZoneFrom.Location = New System.Drawing.Point(18, 32)
        Me.lblZoneFrom.Name = "lblZoneFrom"
        Me.lblZoneFrom.Size = New System.Drawing.Size(55, 23)
        Me.lblZoneFrom.TabIndex = 1
        Me.lblZoneFrom.Text = "Desde"
        Me.lblZoneFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupZone
        '
        Me.GroupZone.Controls.Add(Me.txtZoneNameTo)
        Me.GroupZone.Controls.Add(Me.txtZoneNameFrom)
        Me.GroupZone.Controls.Add(Me.txtZoneTo)
        Me.GroupZone.Controls.Add(Me.txtZoneFrom)
        Me.GroupZone.Controls.Add(Me.lblZoneTo)
        Me.GroupZone.Controls.Add(Me.lblZoneFrom)
        Me.GroupZone.Enabled = False
        Me.GroupZone.Location = New System.Drawing.Point(12, 201)
        Me.GroupZone.Name = "GroupZone"
        Me.GroupZone.Size = New System.Drawing.Size(426, 100)
        Me.GroupZone.TabIndex = 2
        Me.GroupZone.TabStop = False
        Me.GroupZone.Text = "Zona"
        '
        'txtZoneNameTo
        '
        Me.txtZoneNameTo.Enabled = False
        Me.txtZoneNameTo.Location = New System.Drawing.Point(115, 58)
        Me.txtZoneNameTo.Name = "txtZoneNameTo"
        Me.txtZoneNameTo.ReadOnly = True
        Me.txtZoneNameTo.Size = New System.Drawing.Size(305, 20)
        Me.txtZoneNameTo.TabIndex = 6
        '
        'txtZoneNameFrom
        '
        Me.txtZoneNameFrom.Enabled = False
        Me.txtZoneNameFrom.Location = New System.Drawing.Point(115, 32)
        Me.txtZoneNameFrom.Name = "txtZoneNameFrom"
        Me.txtZoneNameFrom.ReadOnly = True
        Me.txtZoneNameFrom.Size = New System.Drawing.Size(305, 20)
        Me.txtZoneNameFrom.TabIndex = 5
        '
        'txtZoneTo
        '
        Me.txtZoneTo.Location = New System.Drawing.Point(80, 58)
        Me.txtZoneTo.Name = "txtZoneTo"
        Me.txtZoneTo.Size = New System.Drawing.Size(28, 20)
        Me.txtZoneTo.TabIndex = 4
        '
        'txtZoneFrom
        '
        Me.txtZoneFrom.Location = New System.Drawing.Point(80, 32)
        Me.txtZoneFrom.Name = "txtZoneFrom"
        Me.txtZoneFrom.Size = New System.Drawing.Size(28, 20)
        Me.txtZoneFrom.TabIndex = 3
        '
        'lblZoneTo
        '
        Me.lblZoneTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZoneTo.Location = New System.Drawing.Point(18, 55)
        Me.lblZoneTo.Name = "lblZoneTo"
        Me.lblZoneTo.Size = New System.Drawing.Size(55, 23)
        Me.lblZoneTo.TabIndex = 2
        Me.lblZoneTo.Text = "Hasta"
        Me.lblZoneTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupCustomer.Location = New System.Drawing.Point(12, 95)
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
        'GroupState
        '
        Me.GroupState.Controls.Add(Me.txtStateNameTo)
        Me.GroupState.Controls.Add(Me.txtStateNameFrom)
        Me.GroupState.Controls.Add(Me.txtStateTo)
        Me.GroupState.Controls.Add(Me.txtStateFrom)
        Me.GroupState.Controls.Add(Me.lblStateTo)
        Me.GroupState.Controls.Add(Me.lblStatefrom)
        Me.GroupState.Enabled = False
        Me.GroupState.Location = New System.Drawing.Point(12, 307)
        Me.GroupState.Name = "GroupState"
        Me.GroupState.Size = New System.Drawing.Size(426, 100)
        Me.GroupState.TabIndex = 9
        Me.GroupState.TabStop = False
        Me.GroupState.Text = "Provincia"
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
        'lblStatefrom
        '
        Me.lblStatefrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatefrom.Location = New System.Drawing.Point(18, 32)
        Me.lblStatefrom.Name = "lblStatefrom"
        Me.lblStatefrom.Size = New System.Drawing.Size(55, 23)
        Me.lblStatefrom.TabIndex = 1
        Me.lblStatefrom.Text = "Desde"
        Me.lblStatefrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupCustomerType
        '
        Me.GroupCustomerType.Controls.Add(Me.optPotentialCustomer)
        Me.GroupCustomerType.Controls.Add(Me.optRealCustomer)
        Me.GroupCustomerType.Enabled = False
        Me.GroupCustomerType.Location = New System.Drawing.Point(12, 37)
        Me.GroupCustomerType.Name = "GroupCustomerType"
        Me.GroupCustomerType.Size = New System.Drawing.Size(426, 52)
        Me.GroupCustomerType.TabIndex = 0
        Me.GroupCustomerType.TabStop = False
        Me.GroupCustomerType.Text = "Tipo de cliente"
        '
        'optPotentialCustomer
        '
        Me.optPotentialCustomer.AutoSize = True
        Me.optPotentialCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPotentialCustomer.Location = New System.Drawing.Point(115, 19)
        Me.optPotentialCustomer.Name = "optPotentialCustomer"
        Me.optPotentialCustomer.Size = New System.Drawing.Size(75, 19)
        Me.optPotentialCustomer.TabIndex = 1
        Me.optPotentialCustomer.Text = "Potencial"
        Me.optPotentialCustomer.UseVisualStyleBackColor = True
        '
        'optRealCustomer
        '
        Me.optRealCustomer.AutoSize = True
        Me.optRealCustomer.Checked = True
        Me.optRealCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRealCustomer.Location = New System.Drawing.Point(30, 20)
        Me.optRealCustomer.Name = "optRealCustomer"
        Me.optRealCustomer.Size = New System.Drawing.Size(48, 19)
        Me.optRealCustomer.TabIndex = 0
        Me.optRealCustomer.TabStop = True
        Me.optRealCustomer.Text = "Real"
        Me.optRealCustomer.UseVisualStyleBackColor = True
        '
        'GroupEmployee
        '
        Me.GroupEmployee.Controls.Add(Me.txtEmployeeNameTo)
        Me.GroupEmployee.Controls.Add(Me.txtEmployeeNameFrom)
        Me.GroupEmployee.Controls.Add(Me.txtEmployeeTo)
        Me.GroupEmployee.Controls.Add(Me.txtEmployeeFrom)
        Me.GroupEmployee.Controls.Add(Me.lblEmployeeTo)
        Me.GroupEmployee.Controls.Add(Me.lblEmployeeFrom)
        Me.GroupEmployee.Enabled = False
        Me.GroupEmployee.Location = New System.Drawing.Point(12, 413)
        Me.GroupEmployee.Name = "GroupEmployee"
        Me.GroupEmployee.Size = New System.Drawing.Size(426, 100)
        Me.GroupEmployee.TabIndex = 10
        Me.GroupEmployee.TabStop = False
        Me.GroupEmployee.Text = "Vendedor"
        '
        'txtEmployeeNameTo
        '
        Me.txtEmployeeNameTo.Enabled = False
        Me.txtEmployeeNameTo.Location = New System.Drawing.Point(115, 58)
        Me.txtEmployeeNameTo.Name = "txtEmployeeNameTo"
        Me.txtEmployeeNameTo.ReadOnly = True
        Me.txtEmployeeNameTo.Size = New System.Drawing.Size(305, 20)
        Me.txtEmployeeNameTo.TabIndex = 6
        '
        'txtEmployeeNameFrom
        '
        Me.txtEmployeeNameFrom.Enabled = False
        Me.txtEmployeeNameFrom.Location = New System.Drawing.Point(115, 32)
        Me.txtEmployeeNameFrom.Name = "txtEmployeeNameFrom"
        Me.txtEmployeeNameFrom.ReadOnly = True
        Me.txtEmployeeNameFrom.Size = New System.Drawing.Size(305, 20)
        Me.txtEmployeeNameFrom.TabIndex = 5
        '
        'txtEmployeeTo
        '
        Me.txtEmployeeTo.Location = New System.Drawing.Point(80, 58)
        Me.txtEmployeeTo.Name = "txtEmployeeTo"
        Me.txtEmployeeTo.Size = New System.Drawing.Size(28, 20)
        Me.txtEmployeeTo.TabIndex = 4
        '
        'txtEmployeeFrom
        '
        Me.txtEmployeeFrom.Location = New System.Drawing.Point(80, 32)
        Me.txtEmployeeFrom.Name = "txtEmployeeFrom"
        Me.txtEmployeeFrom.Size = New System.Drawing.Size(28, 20)
        Me.txtEmployeeFrom.TabIndex = 3
        '
        'lblEmployeeTo
        '
        Me.lblEmployeeTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeTo.Location = New System.Drawing.Point(18, 55)
        Me.lblEmployeeTo.Name = "lblEmployeeTo"
        Me.lblEmployeeTo.Size = New System.Drawing.Size(55, 23)
        Me.lblEmployeeTo.TabIndex = 2
        Me.lblEmployeeTo.Text = "Hasta"
        Me.lblEmployeeTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeFrom
        '
        Me.lblEmployeeFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeFrom.Location = New System.Drawing.Point(18, 32)
        Me.lblEmployeeFrom.Name = "lblEmployeeFrom"
        Me.lblEmployeeFrom.Size = New System.Drawing.Size(55, 23)
        Me.lblEmployeeFrom.TabIndex = 1
        Me.lblEmployeeFrom.Text = "Desde"
        Me.lblEmployeeFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmParametersCustomersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 528)
        Me.Controls.Add(Me.GroupEmployee)
        Me.Controls.Add(Me.GroupCustomerType)
        Me.Controls.Add(Me.GroupState)
        Me.Controls.Add(Me.GroupCustomer)
        Me.Controls.Add(Me.GroupZone)
        Me.Controls.Add(Me.MenuReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuReport
        Me.Name = "frmParametersCustomersList"
        Me.Text = "Nómina de clientes"
        Me.MenuReport.ResumeLayout(False)
        Me.MenuReport.PerformLayout()
        Me.GroupZone.ResumeLayout(False)
        Me.GroupZone.PerformLayout()
        Me.GroupCustomer.ResumeLayout(False)
        Me.GroupCustomer.PerformLayout()
        Me.GroupState.ResumeLayout(False)
        Me.GroupState.PerformLayout()
        Me.GroupCustomerType.ResumeLayout(False)
        Me.GroupCustomerType.PerformLayout()
        Me.GroupEmployee.ResumeLayout(False)
        Me.GroupEmployee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuReport As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuReportList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblZoneFrom As System.Windows.Forms.Label
    Friend WithEvents GroupZone As System.Windows.Forms.GroupBox
    Friend WithEvents lblZoneTo As System.Windows.Forms.Label
    Friend WithEvents txtZoneTo As System.Windows.Forms.TextBox
    Friend WithEvents txtZoneFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtZoneNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtZoneNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents GroupCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerTo As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerTo As System.Windows.Forms.Label
    Friend WithEvents lblCustomerFrom As System.Windows.Forms.Label
    Friend WithEvents GroupState As System.Windows.Forms.GroupBox
    Friend WithEvents txtStateNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtStateNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtStateTo As System.Windows.Forms.TextBox
    Friend WithEvents txtStateFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblStateTo As System.Windows.Forms.Label
    Friend WithEvents lblStatefrom As System.Windows.Forms.Label
    Friend WithEvents GroupCustomerType As System.Windows.Forms.GroupBox
    Friend WithEvents optPotentialCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents optRealCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents MenuReportListByState As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportListByZone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportListByEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupEmployee As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmployeeNameTo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeTo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeTo As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeFrom As System.Windows.Forms.Label
End Class
