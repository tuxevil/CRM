<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServerConfig))
        Me.lblServer = New System.Windows.Forms.Label
        Me.LBLsQLsERVER = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblDictionary = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOwnerDatabase = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.chkBlankPassword = New System.Windows.Forms.CheckBox
        Me.cmdTestConnection = New System.Windows.Forms.Button
        Me.PanelGeneral = New System.Windows.Forms.Panel
        Me.cmdViewServicesSQL = New System.Windows.Forms.Button
        Me.txtSqlService = New System.Windows.Forms.TextBox
        Me.lblSqlService = New System.Windows.Forms.Label
        Me.cmdViewServicesTango = New System.Windows.Forms.Button
        Me.txtTangoService = New System.Windows.Forms.TextBox
        Me.lblTangoService = New System.Windows.Forms.Label
        Me.cmdChangeSqlPassword = New System.Windows.Forms.Button
        Me.cmdChangeSqlUser = New System.Windows.Forms.Button
        Me.cmdViewSqlInstances = New System.Windows.Forms.Button
        Me.txtSqlInstance = New System.Windows.Forms.TextBox
        Me.cmdViewServers = New System.Windows.Forms.Button
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.PanelDatabase = New System.Windows.Forms.Panel
        Me.cmdViewOwnerDatabase = New System.Windows.Forms.Button
        Me.txtOwnerDatabase = New System.Windows.Forms.TextBox
        Me.cmdViewMaincompanydatabase = New System.Windows.Forms.Button
        Me.txtMainCompany = New System.Windows.Forms.TextBox
        Me.cmdViewDictionaryDatabases = New System.Windows.Forms.Button
        Me.txtDictionary = New System.Windows.Forms.TextBox
        Me.PanelGeneral.SuspendLayout()
        Me.PanelDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblServer
        '
        Me.lblServer.Location = New System.Drawing.Point(8, 17)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(105, 21)
        Me.lblServer.TabIndex = 3
        Me.lblServer.Text = "Servidor"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLsQLsERVER
        '
        Me.LBLsQLsERVER.Location = New System.Drawing.Point(10, 99)
        Me.LBLsQLsERVER.Name = "LBLsQLsERVER"
        Me.LBLsQLsERVER.Size = New System.Drawing.Size(105, 21)
        Me.LBLsQLsERVER.TabIndex = 4
        Me.LBLsQLsERVER.Text = "Servidor SQL"
        Me.LBLsQLsERVER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(10, 125)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(105, 21)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Usuario"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(119, 126)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(301, 20)
        Me.txtUser.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(10, 152)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(105, 21)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Contraseña"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(119, 152)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(300, 20)
        Me.txtPassword.TabIndex = 8
        '
        'lblDictionary
        '
        Me.lblDictionary.Location = New System.Drawing.Point(9, 21)
        Me.lblDictionary.Name = "lblDictionary"
        Me.lblDictionary.Size = New System.Drawing.Size(105, 21)
        Me.lblDictionary.TabIndex = 10
        Me.lblDictionary.Text = "Diccionario"
        Me.lblDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Empresa por defecto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOwnerDatabase
        '
        Me.lblOwnerDatabase.Location = New System.Drawing.Point(8, 96)
        Me.lblOwnerDatabase.Name = "lblOwnerDatabase"
        Me.lblOwnerDatabase.Size = New System.Drawing.Size(105, 21)
        Me.lblOwnerDatabase.TabIndex = 14
        Me.lblOwnerDatabase.Text = "Base de datos CRM"
        Me.lblOwnerDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(372, 160)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 25)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "Finalizar"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'chkBlankPassword
        '
        Me.chkBlankPassword.AutoSize = True
        Me.chkBlankPassword.Location = New System.Drawing.Point(302, 178)
        Me.chkBlankPassword.Name = "chkBlankPassword"
        Me.chkBlankPassword.Size = New System.Drawing.Size(157, 17)
        Me.chkBlankPassword.TabIndex = 16
        Me.chkBlankPassword.Text = "Dejar contraseña en blanco"
        Me.chkBlankPassword.UseVisualStyleBackColor = True
        '
        'cmdTestConnection
        '
        Me.cmdTestConnection.Enabled = False
        Me.cmdTestConnection.Location = New System.Drawing.Point(374, 218)
        Me.cmdTestConnection.Name = "cmdTestConnection"
        Me.cmdTestConnection.Size = New System.Drawing.Size(85, 23)
        Me.cmdTestConnection.TabIndex = 17
        Me.cmdTestConnection.Text = "Siguiente >"
        Me.cmdTestConnection.UseVisualStyleBackColor = True
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Controls.Add(Me.cmdViewServicesSQL)
        Me.PanelGeneral.Controls.Add(Me.txtSqlService)
        Me.PanelGeneral.Controls.Add(Me.lblSqlService)
        Me.PanelGeneral.Controls.Add(Me.cmdViewServicesTango)
        Me.PanelGeneral.Controls.Add(Me.txtTangoService)
        Me.PanelGeneral.Controls.Add(Me.lblTangoService)
        Me.PanelGeneral.Controls.Add(Me.cmdChangeSqlPassword)
        Me.PanelGeneral.Controls.Add(Me.cmdChangeSqlUser)
        Me.PanelGeneral.Controls.Add(Me.cmdViewSqlInstances)
        Me.PanelGeneral.Controls.Add(Me.txtSqlInstance)
        Me.PanelGeneral.Controls.Add(Me.cmdViewServers)
        Me.PanelGeneral.Controls.Add(Me.txtServer)
        Me.PanelGeneral.Controls.Add(Me.cmdTestConnection)
        Me.PanelGeneral.Controls.Add(Me.chkBlankPassword)
        Me.PanelGeneral.Controls.Add(Me.lblServer)
        Me.PanelGeneral.Controls.Add(Me.LBLsQLsERVER)
        Me.PanelGeneral.Controls.Add(Me.lblUser)
        Me.PanelGeneral.Controls.Add(Me.txtUser)
        Me.PanelGeneral.Controls.Add(Me.lblPassword)
        Me.PanelGeneral.Controls.Add(Me.txtPassword)
        Me.PanelGeneral.Location = New System.Drawing.Point(12, 12)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(470, 266)
        Me.PanelGeneral.TabIndex = 18
        '
        'cmdViewServicesSQL
        '
        Me.cmdViewServicesSQL.Location = New System.Drawing.Point(427, 43)
        Me.cmdViewServicesSQL.Name = "cmdViewServicesSQL"
        Me.cmdViewServicesSQL.Size = New System.Drawing.Size(30, 21)
        Me.cmdViewServicesSQL.TabIndex = 29
        Me.cmdViewServicesSQL.Text = "..."
        Me.cmdViewServicesSQL.UseVisualStyleBackColor = True
        '
        'txtSqlService
        '
        Me.txtSqlService.Enabled = False
        Me.txtSqlService.Location = New System.Drawing.Point(119, 43)
        Me.txtSqlService.Name = "txtSqlService"
        Me.txtSqlService.ReadOnly = True
        Me.txtSqlService.Size = New System.Drawing.Size(301, 20)
        Me.txtSqlService.TabIndex = 28
        '
        'lblSqlService
        '
        Me.lblSqlService.Location = New System.Drawing.Point(8, 43)
        Me.lblSqlService.Name = "lblSqlService"
        Me.lblSqlService.Size = New System.Drawing.Size(105, 21)
        Me.lblSqlService.TabIndex = 27
        Me.lblSqlService.Text = "Servicio SQL"
        Me.lblSqlService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdViewServicesTango
        '
        Me.cmdViewServicesTango.Location = New System.Drawing.Point(427, 69)
        Me.cmdViewServicesTango.Name = "cmdViewServicesTango"
        Me.cmdViewServicesTango.Size = New System.Drawing.Size(30, 21)
        Me.cmdViewServicesTango.TabIndex = 26
        Me.cmdViewServicesTango.Text = "..."
        Me.cmdViewServicesTango.UseVisualStyleBackColor = True
        '
        'txtTangoService
        '
        Me.txtTangoService.Enabled = False
        Me.txtTangoService.Location = New System.Drawing.Point(119, 69)
        Me.txtTangoService.Name = "txtTangoService"
        Me.txtTangoService.ReadOnly = True
        Me.txtTangoService.Size = New System.Drawing.Size(301, 20)
        Me.txtTangoService.TabIndex = 25
        '
        'lblTangoService
        '
        Me.lblTangoService.Location = New System.Drawing.Point(8, 69)
        Me.lblTangoService.Name = "lblTangoService"
        Me.lblTangoService.Size = New System.Drawing.Size(105, 21)
        Me.lblTangoService.TabIndex = 24
        Me.lblTangoService.Text = "Servicio Tango"
        Me.lblTangoService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdChangeSqlPassword
        '
        Me.cmdChangeSqlPassword.Location = New System.Drawing.Point(427, 152)
        Me.cmdChangeSqlPassword.Name = "cmdChangeSqlPassword"
        Me.cmdChangeSqlPassword.Size = New System.Drawing.Size(30, 23)
        Me.cmdChangeSqlPassword.TabIndex = 23
        Me.cmdChangeSqlPassword.Text = "..."
        Me.cmdChangeSqlPassword.UseVisualStyleBackColor = True
        '
        'cmdChangeSqlUser
        '
        Me.cmdChangeSqlUser.Location = New System.Drawing.Point(426, 123)
        Me.cmdChangeSqlUser.Name = "cmdChangeSqlUser"
        Me.cmdChangeSqlUser.Size = New System.Drawing.Size(30, 23)
        Me.cmdChangeSqlUser.TabIndex = 22
        Me.cmdChangeSqlUser.Text = "..."
        Me.cmdChangeSqlUser.UseVisualStyleBackColor = True
        '
        'cmdViewSqlInstances
        '
        Me.cmdViewSqlInstances.Location = New System.Drawing.Point(426, 94)
        Me.cmdViewSqlInstances.Name = "cmdViewSqlInstances"
        Me.cmdViewSqlInstances.Size = New System.Drawing.Size(30, 23)
        Me.cmdViewSqlInstances.TabIndex = 21
        Me.cmdViewSqlInstances.Text = "..."
        Me.cmdViewSqlInstances.UseVisualStyleBackColor = True
        '
        'txtSqlInstance
        '
        Me.txtSqlInstance.Enabled = False
        Me.txtSqlInstance.Location = New System.Drawing.Point(119, 97)
        Me.txtSqlInstance.Name = "txtSqlInstance"
        Me.txtSqlInstance.ReadOnly = True
        Me.txtSqlInstance.Size = New System.Drawing.Size(301, 20)
        Me.txtSqlInstance.TabIndex = 20
        '
        'cmdViewServers
        '
        Me.cmdViewServers.Location = New System.Drawing.Point(427, 17)
        Me.cmdViewServers.Name = "cmdViewServers"
        Me.cmdViewServers.Size = New System.Drawing.Size(30, 21)
        Me.cmdViewServers.TabIndex = 19
        Me.cmdViewServers.Text = "..."
        Me.cmdViewServers.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Enabled = False
        Me.txtServer.Location = New System.Drawing.Point(119, 17)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.ReadOnly = True
        Me.txtServer.Size = New System.Drawing.Size(301, 20)
        Me.txtServer.TabIndex = 18
        '
        'PanelDatabase
        '
        Me.PanelDatabase.Controls.Add(Me.cmdViewOwnerDatabase)
        Me.PanelDatabase.Controls.Add(Me.txtOwnerDatabase)
        Me.PanelDatabase.Controls.Add(Me.cmdViewMaincompanydatabase)
        Me.PanelDatabase.Controls.Add(Me.txtMainCompany)
        Me.PanelDatabase.Controls.Add(Me.cmdViewDictionaryDatabases)
        Me.PanelDatabase.Controls.Add(Me.txtDictionary)
        Me.PanelDatabase.Controls.Add(Me.lblDictionary)
        Me.PanelDatabase.Controls.Add(Me.cmdSave)
        Me.PanelDatabase.Controls.Add(Me.lblOwnerDatabase)
        Me.PanelDatabase.Controls.Add(Me.Label1)
        Me.PanelDatabase.Location = New System.Drawing.Point(12, 12)
        Me.PanelDatabase.Name = "PanelDatabase"
        Me.PanelDatabase.Size = New System.Drawing.Size(470, 205)
        Me.PanelDatabase.TabIndex = 19
        Me.PanelDatabase.Visible = False
        '
        'cmdViewOwnerDatabase
        '
        Me.cmdViewOwnerDatabase.Location = New System.Drawing.Point(427, 96)
        Me.cmdViewOwnerDatabase.Name = "cmdViewOwnerDatabase"
        Me.cmdViewOwnerDatabase.Size = New System.Drawing.Size(30, 21)
        Me.cmdViewOwnerDatabase.TabIndex = 26
        Me.cmdViewOwnerDatabase.Text = "..."
        Me.cmdViewOwnerDatabase.UseVisualStyleBackColor = True
        '
        'txtOwnerDatabase
        '
        Me.txtOwnerDatabase.Enabled = False
        Me.txtOwnerDatabase.Location = New System.Drawing.Point(119, 96)
        Me.txtOwnerDatabase.Name = "txtOwnerDatabase"
        Me.txtOwnerDatabase.ReadOnly = True
        Me.txtOwnerDatabase.Size = New System.Drawing.Size(301, 20)
        Me.txtOwnerDatabase.TabIndex = 25
        '
        'cmdViewMaincompanydatabase
        '
        Me.cmdViewMaincompanydatabase.Location = New System.Drawing.Point(428, 54)
        Me.cmdViewMaincompanydatabase.Name = "cmdViewMaincompanydatabase"
        Me.cmdViewMaincompanydatabase.Size = New System.Drawing.Size(30, 21)
        Me.cmdViewMaincompanydatabase.TabIndex = 23
        Me.cmdViewMaincompanydatabase.Text = "..."
        Me.cmdViewMaincompanydatabase.UseVisualStyleBackColor = True
        '
        'txtMainCompany
        '
        Me.txtMainCompany.Enabled = False
        Me.txtMainCompany.Location = New System.Drawing.Point(120, 54)
        Me.txtMainCompany.Name = "txtMainCompany"
        Me.txtMainCompany.ReadOnly = True
        Me.txtMainCompany.Size = New System.Drawing.Size(301, 20)
        Me.txtMainCompany.TabIndex = 22
        '
        'cmdViewDictionaryDatabases
        '
        Me.cmdViewDictionaryDatabases.Location = New System.Drawing.Point(427, 17)
        Me.cmdViewDictionaryDatabases.Name = "cmdViewDictionaryDatabases"
        Me.cmdViewDictionaryDatabases.Size = New System.Drawing.Size(30, 21)
        Me.cmdViewDictionaryDatabases.TabIndex = 21
        Me.cmdViewDictionaryDatabases.Text = "..."
        Me.cmdViewDictionaryDatabases.UseVisualStyleBackColor = True
        '
        'txtDictionary
        '
        Me.txtDictionary.Enabled = False
        Me.txtDictionary.Location = New System.Drawing.Point(119, 17)
        Me.txtDictionary.Name = "txtDictionary"
        Me.txtDictionary.ReadOnly = True
        Me.txtDictionary.Size = New System.Drawing.Size(301, 20)
        Me.txtDictionary.TabIndex = 20
        '
        'frmServerConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 289)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Controls.Add(Me.PanelDatabase)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServerConfig"
        Me.Text = "Configuración"
        Me.PanelGeneral.ResumeLayout(False)
        Me.PanelGeneral.PerformLayout()
        Me.PanelDatabase.ResumeLayout(False)
        Me.PanelDatabase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents LBLsQLsERVER As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblDictionary As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOwnerDatabase As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents chkBlankPassword As System.Windows.Forms.CheckBox
    Friend WithEvents cmdTestConnection As System.Windows.Forms.Button
    Friend WithEvents PanelGeneral As System.Windows.Forms.Panel
    Friend WithEvents PanelDatabase As System.Windows.Forms.Panel
    Friend WithEvents cmdViewServers As System.Windows.Forms.Button
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents cmdViewSqlInstances As System.Windows.Forms.Button
    Friend WithEvents txtSqlInstance As System.Windows.Forms.TextBox
    Friend WithEvents cmdChangeSqlUser As System.Windows.Forms.Button
    Friend WithEvents cmdChangeSqlPassword As System.Windows.Forms.Button
    Friend WithEvents cmdViewOwnerDatabase As System.Windows.Forms.Button
    Friend WithEvents txtOwnerDatabase As System.Windows.Forms.TextBox
    Friend WithEvents cmdViewMaincompanydatabase As System.Windows.Forms.Button
    Friend WithEvents txtMainCompany As System.Windows.Forms.TextBox
    Friend WithEvents cmdViewDictionaryDatabases As System.Windows.Forms.Button
    Friend WithEvents txtDictionary As System.Windows.Forms.TextBox
    Friend WithEvents cmdViewServicesSQL As System.Windows.Forms.Button
    Friend WithEvents txtSqlService As System.Windows.Forms.TextBox
    Friend WithEvents lblSqlService As System.Windows.Forms.Label
    Friend WithEvents cmdViewServicesTango As System.Windows.Forms.Button
    Friend WithEvents txtTangoService As System.Windows.Forms.TextBox
    Friend WithEvents lblTangoService As System.Windows.Forms.Label
End Class
