<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlert))
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.cmbMinutes = New System.Windows.Forms.ComboBox
        Me.cmdSuspend = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.GroupMsg = New System.Windows.Forms.GroupBox
        Me.lblDetail = New System.Windows.Forms.Label
        Me.lblInitDate = New System.Windows.Forms.Label
        Me.ShowTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupMsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(338, 185)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(75, 23)
        Me.cmdAccept.TabIndex = 0
        Me.cmdAccept.Text = "Descartar"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'cmbMinutes
        '
        Me.cmbMinutes.BackColor = System.Drawing.SystemColors.Control
        Me.cmbMinutes.FormattingEnabled = True
        Me.cmbMinutes.Location = New System.Drawing.Point(45, 216)
        Me.cmbMinutes.Name = "cmbMinutes"
        Me.cmbMinutes.Size = New System.Drawing.Size(235, 21)
        Me.cmbMinutes.TabIndex = 13
        '
        'cmdSuspend
        '
        Me.cmdSuspend.Location = New System.Drawing.Point(338, 214)
        Me.cmdSuspend.Name = "cmdSuspend"
        Me.cmdSuspend.Size = New System.Drawing.Size(75, 23)
        Me.cmdSuspend.TabIndex = 14
        Me.cmdSuspend.Text = "Posponer"
        Me.cmdSuspend.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(42, 194)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(283, 19)
        Me.lblMessage.TabIndex = 15
        Me.lblMessage.Text = "Haga click en posponer para repetir este aviso en"
        '
        'GroupMsg
        '
        Me.GroupMsg.Controls.Add(Me.lblDetail)
        Me.GroupMsg.Location = New System.Drawing.Point(12, 32)
        Me.GroupMsg.Name = "GroupMsg"
        Me.GroupMsg.Size = New System.Drawing.Size(405, 136)
        Me.GroupMsg.TabIndex = 19
        Me.GroupMsg.TabStop = False
        Me.GroupMsg.Text = "Nueva Alerta"
        '
        'lblDetail
        '
        Me.lblDetail.BackColor = System.Drawing.Color.Transparent
        Me.lblDetail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(6, 16)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(393, 110)
        Me.lblDetail.TabIndex = 18
        Me.lblDetail.Text = "Nueva alerta"
        '
        'lblInitDate
        '
        Me.lblInitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitDate.ForeColor = System.Drawing.Color.Blue
        Me.lblInitDate.Location = New System.Drawing.Point(189, 9)
        Me.lblInitDate.Name = "lblInitDate"
        Me.lblInitDate.Size = New System.Drawing.Size(227, 23)
        Me.lblInitDate.TabIndex = 20
        Me.lblInitDate.Text = "Inicio:"
        Me.lblInitDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShowTimer
        '
        '
        'frmAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(423, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInitDate)
        Me.Controls.Add(Me.GroupMsg)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.cmdSuspend)
        Me.Controls.Add(Me.cmbMinutes)
        Me.Controls.Add(Me.cmdAccept)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(429, 271)
        Me.Name = "frmAlert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alerta"
        Me.TransparencyKey = System.Drawing.SystemColors.HotTrack
        Me.GroupMsg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents cmbMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSuspend As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents GroupMsg As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents lblInitDate As System.Windows.Forms.Label
    Friend WithEvents ShowTimer As System.Windows.Forms.Timer
End Class
