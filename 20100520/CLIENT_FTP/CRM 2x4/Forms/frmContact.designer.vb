<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContact))
        Me.Browser = New System.Windows.Forms.ToolStrip
        Me.BrowserAdd = New System.Windows.Forms.ToolStripButton
        Me.BrowserDelete = New System.Windows.Forms.ToolStripButton
        Me.BrowserEdit = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserFirst = New System.Windows.Forms.ToolStripButton
        Me.BrowserPrevious = New System.Windows.Forms.ToolStripButton
        Me.BrowserNext = New System.Windows.Forms.ToolStripButton
        Me.BrowserLast = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserSearch = New System.Windows.Forms.ToolStripButton
        Me.BrowserList = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditArea = New System.Windows.Forms.ToolStripMenuItem
        Me.MenueditCharge = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEditSave = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActions = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuActionSendMail = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dpFechaNacimiento = New System.Windows.Forms.DateTimePicker
        Me.lblNacimiento = New System.Windows.Forms.Label
        Me.txtCUIT = New System.Windows.Forms.TextBox
        Me.lblCUIT = New System.Windows.Forms.Label
        Me.txtFAX = New System.Windows.Forms.TextBox
        Me.lblFAX = New System.Windows.Forms.Label
        Me.lblAlterEmail = New System.Windows.Forms.Label
        Me.txtAlterMail = New System.Windows.Forms.TextBox
        Me.lblSurname = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.lblCargo = New System.Windows.Forms.Label
        Me.cmbCargo = New System.Windows.Forms.ComboBox
        Me.lblArea = New System.Windows.Forms.Label
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.lblDetails = New System.Windows.Forms.Label
        Me.lblTel = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Browser.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAdd, Me.BrowserDelete, Me.BrowserEdit, Me.BrowserSeparator1, Me.BrowserFirst, Me.BrowserPrevious, Me.BrowserNext, Me.BrowserLast, Me.BrowserSeparator2, Me.BrowserSearch, Me.BrowserList})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(676, 31)
        Me.Browser.TabIndex = 38
        Me.Browser.Text = "ToolStrip1"
        '
        'BrowserAdd
        '
        Me.BrowserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAdd.Image = Global.Crm.UI.My.Resources.Resources.add
        Me.BrowserAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAdd.Name = "BrowserAdd"
        Me.BrowserAdd.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAdd.Text = "Añadir registro"
        '
        'BrowserDelete
        '
        Me.BrowserDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserDelete.Image = Global.Crm.UI.My.Resources.Resources.delete
        Me.BrowserDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserDelete.Name = "BrowserDelete"
        Me.BrowserDelete.Size = New System.Drawing.Size(28, 28)
        Me.BrowserDelete.Text = "Eliminar registro"
        Me.BrowserDelete.Visible = False
        '
        'BrowserEdit
        '
        Me.BrowserEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserEdit.Image = Global.Crm.UI.My.Resources.Resources.up
        Me.BrowserEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserEdit.Name = "BrowserEdit"
        Me.BrowserEdit.Size = New System.Drawing.Size(28, 28)
        Me.BrowserEdit.Text = "Modifica el registro"
        '
        'BrowserSeparator1
        '
        Me.BrowserSeparator1.Name = "BrowserSeparator1"
        Me.BrowserSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BrowserFirst
        '
        Me.BrowserFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserFirst.Image = Global.Crm.UI.My.Resources.Resources.First
        Me.BrowserFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserFirst.Name = "BrowserFirst"
        Me.BrowserFirst.Size = New System.Drawing.Size(28, 28)
        Me.BrowserFirst.Text = "Primer registro"
        '
        'BrowserPrevious
        '
        Me.BrowserPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserPrevious.Image = Global.Crm.UI.My.Resources.Resources.previous
        Me.BrowserPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserPrevious.Name = "BrowserPrevious"
        Me.BrowserPrevious.Size = New System.Drawing.Size(28, 28)
        Me.BrowserPrevious.Text = "Registro anterior"
        '
        'BrowserNext
        '
        Me.BrowserNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserNext.Image = Global.Crm.UI.My.Resources.Resources._next
        Me.BrowserNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserNext.Name = "BrowserNext"
        Me.BrowserNext.Size = New System.Drawing.Size(28, 28)
        Me.BrowserNext.Text = "Próximo registro"
        '
        'BrowserLast
        '
        Me.BrowserLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserLast.Image = Global.Crm.UI.My.Resources.Resources.Last
        Me.BrowserLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserLast.Name = "BrowserLast"
        Me.BrowserLast.Size = New System.Drawing.Size(28, 28)
        Me.BrowserLast.Text = "Último registro"
        '
        'BrowserSeparator2
        '
        Me.BrowserSeparator2.Name = "BrowserSeparator2"
        Me.BrowserSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BrowserSearch
        '
        Me.BrowserSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserSearch.Image = Global.Crm.UI.My.Resources.Resources.search
        Me.BrowserSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserSearch.Name = "BrowserSearch"
        Me.BrowserSearch.Size = New System.Drawing.Size(28, 28)
        Me.BrowserSearch.Text = "Buscar registro"
        Me.BrowserSearch.Visible = False
        '
        'BrowserList
        '
        Me.BrowserList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserList.Image = Global.Crm.UI.My.Resources.Resources.List
        Me.BrowserList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserList.Name = "BrowserList"
        Me.BrowserList.Size = New System.Drawing.Size(28, 28)
        Me.BrowserList.Text = "Listar"
        Me.BrowserList.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuEdit, Me.MenuActions})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 62
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileAdd, Me.MenuFileEdit, Me.MenuFileDelete, Me.MenuFileExit})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(55, 20)
        Me.MenuFile.Text = "Archivo"
        '
        'MenuFileAdd
        '
        Me.MenuFileAdd.Name = "MenuFileAdd"
        Me.MenuFileAdd.Size = New System.Drawing.Size(152, 22)
        Me.MenuFileAdd.Text = "Agregar"
        '
        'MenuFileEdit
        '
        Me.MenuFileEdit.Name = "MenuFileEdit"
        Me.MenuFileEdit.Size = New System.Drawing.Size(152, 22)
        Me.MenuFileEdit.Text = "Editar"
        '
        'MenuFileDelete
        '
        Me.MenuFileDelete.Name = "MenuFileDelete"
        Me.MenuFileDelete.Size = New System.Drawing.Size(152, 22)
        Me.MenuFileDelete.Text = "Eliminar"
        Me.MenuFileDelete.Visible = False
        '
        'MenuFileExit
        '
        Me.MenuFileExit.Name = "MenuFileExit"
        Me.MenuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.MenuFileExit.Text = "Salir"
        '
        'MenuEdit
        '
        Me.MenuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEditArea, Me.MenueditCharge, Me.MenuEditCancel, Me.MenuEditSave})
        Me.MenuEdit.Name = "MenuEdit"
        Me.MenuEdit.Size = New System.Drawing.Size(52, 20)
        Me.MenuEdit.Text = "Edición"
        '
        'MenuEditArea
        '
        Me.MenuEditArea.Name = "MenuEditArea"
        Me.MenuEditArea.Size = New System.Drawing.Size(152, 22)
        Me.MenuEditArea.Text = "Areas"
        '
        'MenueditCharge
        '
        Me.MenueditCharge.Name = "MenueditCharge"
        Me.MenueditCharge.Size = New System.Drawing.Size(152, 22)
        Me.MenueditCharge.Text = "Cargos"
        '
        'MenuEditCancel
        '
        Me.MenuEditCancel.Name = "MenuEditCancel"
        Me.MenuEditCancel.Size = New System.Drawing.Size(152, 22)
        Me.MenuEditCancel.Text = "Cancelar"
        Me.MenuEditCancel.Visible = False
        '
        'MenuEditSave
        '
        Me.MenuEditSave.Name = "MenuEditSave"
        Me.MenuEditSave.Size = New System.Drawing.Size(152, 22)
        Me.MenuEditSave.Text = "Guardar"
        Me.MenuEditSave.Visible = False
        '
        'MenuActions
        '
        Me.MenuActions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuActionSendMail})
        Me.MenuActions.Name = "MenuActions"
        Me.MenuActions.Size = New System.Drawing.Size(61, 20)
        Me.MenuActions.Text = "Acciones"
        '
        'MenuActionSendMail
        '
        Me.MenuActionSendMail.Name = "MenuActionSendMail"
        Me.MenuActionSendMail.Size = New System.Drawing.Size(152, 22)
        Me.MenuActionSendMail.Text = "Enviar mail"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 61)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.Crm.UI.My.Resources.Resources.save_16x16
        Me.cmdSave.Location = New System.Drawing.Point(571, 13)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(66, 42)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dpFechaNacimiento)
        Me.GroupBox2.Controls.Add(Me.lblNacimiento)
        Me.GroupBox2.Controls.Add(Me.txtCUIT)
        Me.GroupBox2.Controls.Add(Me.lblCUIT)
        Me.GroupBox2.Controls.Add(Me.txtFAX)
        Me.GroupBox2.Controls.Add(Me.lblFAX)
        Me.GroupBox2.Controls.Add(Me.lblAlterEmail)
        Me.GroupBox2.Controls.Add(Me.txtAlterMail)
        Me.GroupBox2.Controls.Add(Me.lblSurname)
        Me.GroupBox2.Controls.Add(Me.txtSurname)
        Me.GroupBox2.Controls.Add(Me.lblCargo)
        Me.GroupBox2.Controls.Add(Me.cmbCargo)
        Me.GroupBox2.Controls.Add(Me.lblArea)
        Me.GroupBox2.Controls.Add(Me.cmbArea)
        Me.GroupBox2.Controls.Add(Me.lblDetails)
        Me.GroupBox2.Controls.Add(Me.lblTel)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.txtNotes)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 228)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        '
        'dpFechaNacimiento
        '
        Me.dpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaNacimiento.Location = New System.Drawing.Point(152, 169)
        Me.dpFechaNacimiento.Name = "dpFechaNacimiento"
        Me.dpFechaNacimiento.Size = New System.Drawing.Size(121, 20)
        Me.dpFechaNacimiento.TabIndex = 8
        Me.dpFechaNacimiento.Value = New Date(1903, 4, 28, 0, 0, 0, 0)
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(2, 167)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(104, 15)
        Me.lblNacimiento.TabIndex = 82
        Me.lblNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCUIT
        '
        Me.txtCUIT.Location = New System.Drawing.Point(152, 195)
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(121, 20)
        Me.txtCUIT.TabIndex = 9
        '
        'lblCUIT
        '
        Me.lblCUIT.AutoSize = True
        Me.lblCUIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCUIT.Location = New System.Drawing.Point(2, 195)
        Me.lblCUIT.Name = "lblCUIT"
        Me.lblCUIT.Size = New System.Drawing.Size(31, 15)
        Me.lblCUIT.TabIndex = 80
        Me.lblCUIT.Text = "CUIT"
        '
        'txtFAX
        '
        Me.txtFAX.Location = New System.Drawing.Point(456, 124)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(192, 20)
        Me.txtFAX.TabIndex = 7
        '
        'lblFAX
        '
        Me.lblFAX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFAX.Location = New System.Drawing.Point(345, 124)
        Me.lblFAX.Name = "lblFAX"
        Me.lblFAX.Size = New System.Drawing.Size(105, 18)
        Me.lblFAX.TabIndex = 78
        Me.lblFAX.Text = "FAX"
        Me.lblFAX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAlterEmail
        '
        Me.lblAlterEmail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlterEmail.Location = New System.Drawing.Point(345, 97)
        Me.lblAlterEmail.Name = "lblAlterEmail"
        Me.lblAlterEmail.Size = New System.Drawing.Size(105, 18)
        Me.lblAlterEmail.TabIndex = 77
        Me.lblAlterEmail.Text = "Email Alternativo"
        Me.lblAlterEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAlterMail
        '
        Me.txtAlterMail.Location = New System.Drawing.Point(456, 97)
        Me.txtAlterMail.Name = "txtAlterMail"
        Me.txtAlterMail.Size = New System.Drawing.Size(192, 20)
        Me.txtAlterMail.TabIndex = 5
        '
        'lblSurname
        '
        Me.lblSurname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(344, 52)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(96, 18)
        Me.lblSurname.TabIndex = 75
        Me.lblSurname.Text = "Apellido"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(456, 50)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(192, 20)
        Me.txtSurname.TabIndex = 3
        '
        'lblCargo
        '
        Me.lblCargo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.Location = New System.Drawing.Point(345, 18)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(96, 18)
        Me.lblCargo.TabIndex = 73
        Me.lblCargo.Text = "Cargo"
        Me.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCargo
        '
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.Location = New System.Drawing.Point(456, 18)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(192, 21)
        Me.cmbCargo.TabIndex = 1
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(2, 18)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(144, 18)
        Me.lblArea.TabIndex = 71
        Me.lblArea.Text = "Area"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(154, 18)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(168, 21)
        Me.cmbArea.TabIndex = 0
        '
        'lblDetails
        '
        Me.lblDetails.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(345, 169)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(105, 18)
        Me.lblDetails.TabIndex = 69
        Me.lblDetails.Text = "Otros datos"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(2, 122)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(144, 18)
        Me.lblTel.TabIndex = 68
        Me.lblTel.Text = "Teléfono"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(2, 98)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(117, 18)
        Me.lblEmail.TabIndex = 67
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(2, 52)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(144, 18)
        Me.lblName.TabIndex = 66
        Me.lblName.Text = "Nombre"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(152, 122)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(170, 20)
        Me.txtTel.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(455, 169)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNotes.Size = New System.Drawing.Size(193, 46)
        Me.txtNotes.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(152, 96)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(170, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(170, 20)
        Me.txtName.TabIndex = 2
        '
        'frmContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 349)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmContact"
        Me.Text = "Contactos"
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Browser As System.Windows.Forms.ToolStrip
    Friend WithEvents BrowserAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserList As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtCUIT As System.Windows.Forms.TextBox
    Friend WithEvents lblCUIT As System.Windows.Forms.Label
    Friend WithEvents txtFAX As System.Windows.Forms.TextBox
    Friend WithEvents lblFAX As System.Windows.Forms.Label
    Friend WithEvents lblAlterEmail As System.Windows.Forms.Label
    Friend WithEvents txtAlterMail As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents cmbCargo As System.Windows.Forms.ComboBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents MenuEditArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenueditCharge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuActionSendMail As System.Windows.Forms.ToolStripMenuItem
End Class
