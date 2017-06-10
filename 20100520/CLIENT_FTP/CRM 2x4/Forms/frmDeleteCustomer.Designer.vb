<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteCustomer))
        Me.Browser = New System.Windows.Forms.ToolStrip
        Me.BrowserAccept = New System.Windows.Forms.ToolStripButton
        Me.BrowserCancel = New System.Windows.Forms.ToolStripButton
        Me.BrowserAdd = New System.Windows.Forms.ToolStripButton
        Me.BrowserDelete = New System.Windows.Forms.ToolStripButton
        Me.BrowserEdit = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserFirst = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.BrowserPrevious = New System.Windows.Forms.ToolStripButton
        Me.BrowserNext = New System.Windows.Forms.ToolStripButton
        Me.BrowserLast = New System.Windows.Forms.ToolStripButton
        Me.BrowserSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowserSearch = New System.Windows.Forms.ToolStripButton
        Me.BrowserList = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuProcess = New System.Windows.Forms.ToolStripMenuItem
        Me.lblReasson = New System.Windows.Forms.Label
        Me.CancelDate = New System.Windows.Forms.DateTimePicker
        Me.lblCancelDate = New System.Windows.Forms.Label
        Me.txtLegalName = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.cmbReasson = New System.Windows.Forms.ComboBox
        Me.Browser.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserAccept, Me.BrowserCancel, Me.BrowserAdd, Me.BrowserDelete, Me.BrowserEdit, Me.BrowserSeparator1, Me.BrowserFirst, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton1, Me.BrowserPrevious, Me.BrowserNext, Me.BrowserLast, Me.BrowserSeparator2, Me.BrowserSearch, Me.BrowserList})
        Me.Browser.Location = New System.Drawing.Point(0, 24)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(662, 31)
        Me.Browser.TabIndex = 51
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
        'BrowserAdd
        '
        Me.BrowserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserAdd.Image = Global.Crm.UI.My.Resources.Resources.add
        Me.BrowserAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BrowserAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserAdd.Name = "BrowserAdd"
        Me.BrowserAdd.Size = New System.Drawing.Size(28, 28)
        Me.BrowserAdd.Text = "Añadir registro"
        Me.BrowserAdd.Visible = False
        '
        'BrowserDelete
        '
        Me.BrowserDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserDelete.Enabled = False
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
        Me.BrowserEdit.Visible = False
        '
        'BrowserSeparator1
        '
        Me.BrowserSeparator1.Name = "BrowserSeparator1"
        Me.BrowserSeparator1.Size = New System.Drawing.Size(6, 31)
        Me.BrowserSeparator1.Visible = False
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
        Me.BrowserFirst.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Crm.UI.My.Resources.Resources.previous
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton4.Text = "Registro anterior"
        Me.ToolStripButton4.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Crm.UI.My.Resources.Resources.First
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton3.Text = "Primer registro"
        Me.ToolStripButton3.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Crm.UI.My.Resources.Resources.up
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton2.Text = "Modifica el registro"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Crm.UI.My.Resources.Resources.add
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "Añadir registro"
        Me.ToolStripButton1.Visible = False
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
        Me.BrowserPrevious.Visible = False
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
        Me.BrowserNext.Visible = False
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
        Me.BrowserLast.Visible = False
        '
        'BrowserSeparator2
        '
        Me.BrowserSeparator2.Name = "BrowserSeparator2"
        Me.BrowserSeparator2.Size = New System.Drawing.Size(6, 31)
        Me.BrowserSeparator2.Visible = False
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuProcess})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'MenuProcess
        '
        Me.MenuProcess.Name = "MenuProcess"
        Me.MenuProcess.Size = New System.Drawing.Size(61, 20)
        Me.MenuProcess.Text = "Procesar"
        '
        'lblReasson
        '
        Me.lblReasson.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReasson.Location = New System.Drawing.Point(10, 123)
        Me.lblReasson.Name = "lblReasson"
        Me.lblReasson.Size = New System.Drawing.Size(121, 23)
        Me.lblReasson.TabIndex = 59
        Me.lblReasson.Tag = ""
        Me.lblReasson.Text = "MOTIVO DE BAJA"
        Me.lblReasson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelDate
        '
        Me.CancelDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CancelDate.Location = New System.Drawing.Point(137, 93)
        Me.CancelDate.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.CancelDate.Name = "CancelDate"
        Me.CancelDate.Size = New System.Drawing.Size(96, 20)
        Me.CancelDate.TabIndex = 58
        '
        'lblCancelDate
        '
        Me.lblCancelDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelDate.Location = New System.Drawing.Point(10, 93)
        Me.lblCancelDate.Name = "lblCancelDate"
        Me.lblCancelDate.Size = New System.Drawing.Size(121, 23)
        Me.lblCancelDate.TabIndex = 57
        Me.lblCancelDate.Tag = ""
        Me.lblCancelDate.Text = "FECHA"
        Me.lblCancelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLegalName
        '
        Me.txtLegalName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLegalName.Location = New System.Drawing.Point(239, 65)
        Me.txtLegalName.Name = "txtLegalName"
        Me.txtLegalName.ReadOnly = True
        Me.txtLegalName.Size = New System.Drawing.Size(414, 23)
        Me.txtLegalName.TabIndex = 55
        Me.txtLegalName.Tag = "CUSTOMER/LEGALNAME"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(137, 64)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(96, 23)
        Me.txtCode.TabIndex = 53
        Me.txtCode.Tag = "CUSTOMER/CODE"
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(10, 64)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(121, 23)
        Me.lblCode.TabIndex = 54
        Me.lblCode.Tag = ""
        Me.lblCode.Text = "CLIENTE"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbReasson
        '
        Me.cmbReasson.FormattingEnabled = True
        Me.cmbReasson.Location = New System.Drawing.Point(138, 123)
        Me.cmbReasson.Name = "cmbReasson"
        Me.cmbReasson.Size = New System.Drawing.Size(512, 21)
        Me.cmbReasson.TabIndex = 60
        '
        'frmDeleteCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 154)
        Me.Controls.Add(Me.cmbReasson)
        Me.Controls.Add(Me.lblReasson)
        Me.Controls.Add(Me.CancelDate)
        Me.Controls.Add(Me.lblCancelDate)
        Me.Controls.Add(Me.txtLegalName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmDeleteCustomer"
        Me.Text = "Eliminación de clientes"
        Me.Browser.ResumeLayout(False)
        Me.Browser.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Browser As System.Windows.Forms.ToolStrip
    Friend WithEvents BrowserAccept As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserList As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblReasson As System.Windows.Forms.Label
    Friend WithEvents CancelDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCancelDate As System.Windows.Forms.Label
    Friend WithEvents txtLegalName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cmbReasson As System.Windows.Forms.ComboBox
End Class
