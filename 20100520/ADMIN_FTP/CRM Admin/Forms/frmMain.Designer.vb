<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdMail = New System.Windows.Forms.Button
        Me.cmdCompanies = New System.Windows.Forms.Button
        Me.cmdProfiles = New System.Windows.Forms.Button
        Me.btUsers = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdMail
        '
        Me.cmdMail.BackColor = System.Drawing.Color.Transparent
        Me.cmdMail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMail.FlatAppearance.BorderSize = 0
        Me.cmdMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMail.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMail.Image = Global.Admin.My.Resources.Resources.mail_info
        Me.cmdMail.Location = New System.Drawing.Point(350, 328)
        Me.cmdMail.Name = "cmdMail"
        Me.cmdMail.Size = New System.Drawing.Size(207, 91)
        Me.cmdMail.TabIndex = 4
        Me.cmdMail.Text = "Correo electrónico"
        Me.cmdMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdMail.UseVisualStyleBackColor = False
        Me.cmdMail.Visible = False
        '
        'cmdCompanies
        '
        Me.cmdCompanies.BackColor = System.Drawing.Color.Transparent
        Me.cmdCompanies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCompanies.FlatAppearance.BorderSize = 0
        Me.cmdCompanies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCompanies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompanies.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompanies.Image = Global.Admin.My.Resources.Resources.database
        Me.cmdCompanies.Location = New System.Drawing.Point(350, 37)
        Me.cmdCompanies.Name = "cmdCompanies"
        Me.cmdCompanies.Size = New System.Drawing.Size(207, 91)
        Me.cmdCompanies.TabIndex = 3
        Me.cmdCompanies.Text = "Empresas"
        Me.cmdCompanies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompanies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCompanies.UseVisualStyleBackColor = False
        '
        'cmdProfiles
        '
        Me.cmdProfiles.BackColor = System.Drawing.Color.Transparent
        Me.cmdProfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProfiles.FlatAppearance.BorderSize = 0
        Me.cmdProfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdProfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProfiles.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProfiles.Image = Global.Admin.My.Resources.Resources.lock
        Me.cmdProfiles.Location = New System.Drawing.Point(339, 134)
        Me.cmdProfiles.Name = "cmdProfiles"
        Me.cmdProfiles.Size = New System.Drawing.Size(207, 91)
        Me.cmdProfiles.TabIndex = 1
        Me.cmdProfiles.Text = "Perfiles"
        Me.cmdProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdProfiles.UseVisualStyleBackColor = False
        '
        'btUsers
        '
        Me.btUsers.BackColor = System.Drawing.Color.Transparent
        Me.btUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btUsers.FlatAppearance.BorderSize = 0
        Me.btUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUsers.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUsers.Image = Global.Admin.My.Resources.Resources.permissions
        Me.btUsers.Location = New System.Drawing.Point(350, 231)
        Me.btUsers.Name = "btUsers"
        Me.btUsers.Size = New System.Drawing.Size(207, 91)
        Me.btUsers.TabIndex = 0
        Me.btUsers.Text = "Usuarios y permisos"
        Me.btUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btUsers.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.Admin.My.Resources.Resources.Back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 528)
        Me.Controls.Add(Me.cmdMail)
        Me.Controls.Add(Me.cmdCompanies)
        Me.Controls.Add(Me.cmdProfiles)
        Me.Controls.Add(Me.btUsers)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(674, 562)
        Me.MinimumSize = New System.Drawing.Size(674, 562)
        Me.Name = "frmMain"
        Me.Text = "CRM 2x4 Administrador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btUsers As System.Windows.Forms.Button
    Friend WithEvents cmdProfiles As System.Windows.Forms.Button
    Friend WithEvents cmdCompanies As System.Windows.Forms.Button
    Friend WithEvents cmdMail As System.Windows.Forms.Button

End Class
