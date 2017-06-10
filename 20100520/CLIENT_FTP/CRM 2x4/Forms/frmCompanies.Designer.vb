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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanies))
        Me.ListCompanies = New System.Windows.Forms.ListBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListCompanies
        '
        Me.ListCompanies.FormattingEnabled = True
        Me.ListCompanies.Location = New System.Drawing.Point(138, 67)
        Me.ListCompanies.Name = "ListCompanies"
        Me.ListCompanies.Size = New System.Drawing.Size(351, 212)
        Me.ListCompanies.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(135, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(225, 23)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "USUARIO:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(333, 294)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdAccept
        '
        Me.cmdAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAccept.Enabled = False
        Me.cmdAccept.Location = New System.Drawing.Point(414, 294)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(75, 23)
        Me.cmdAccept.TabIndex = 11
        Me.cmdAccept.Text = "Siguiente"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Black
        Me.lblMessage.Location = New System.Drawing.Point(135, 41)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(250, 23)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "Seleccione la empresa"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCompanies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Crm.UI.My.Resources.Resources.BackLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(513, 354)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.ListCompanies)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompanies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompanies"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListCompanies As System.Windows.Forms.ListBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
