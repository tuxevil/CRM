<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(107, 86)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(189, 23)
        Me.txtUser.TabIndex = 6
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(105, 68)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(205, 23)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Usuario"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(106, 119)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(204, 23)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Contraseña"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(107, 136)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(189, 23)
        Me.txtPassword.TabIndex = 8
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAccept.Enabled = False
        Me.cmdAccept.Location = New System.Drawing.Point(221, 177)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(75, 23)
        Me.cmdAccept.TabIndex = 9
        Me.cmdAccept.Text = "Siguiente"
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(140, 177)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Black
        Me.lblMessage.Location = New System.Drawing.Point(66, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(225, 54)
        Me.lblMessage.TabIndex = 11
        Me.lblMessage.Text = "Ingreso al Sistema CRM 2x4"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLogin
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Crm.UI.My.Resources.Resources.BackLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(322, 251)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        'Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
