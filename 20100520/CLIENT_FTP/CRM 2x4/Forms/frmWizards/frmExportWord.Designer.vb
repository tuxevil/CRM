<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportWord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportWord))
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnl5 = New System.Windows.Forms.Panel
        Me.pnl5chkOpenFile = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnl5Title = New System.Windows.Forms.Panel
        Me.pnl5lblTitle2 = New System.Windows.Forms.Label
        Me.pnl5lblTitle1 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pnl4 = New System.Windows.Forms.Panel
        Me.pnl4chkSaveFile = New System.Windows.Forms.CheckBox
        Me.pnl4cmdBrowse = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl4txtFile = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnl4Title = New System.Windows.Forms.Panel
        Me.pnl4lblTitle2 = New System.Windows.Forms.Label
        Me.pnl4lblTitle1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictLogo = New System.Windows.Forms.PictureBox
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.pnlMain.SuspendLayout()
        Me.pnl5.SuspendLayout()
        Me.pnl5Title.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl4.SuspendLayout()
        Me.pnl4Title.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        CType(Me.PictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnl5)
        Me.pnlMain.Controls.Add(Me.pnl4)
        Me.pnlMain.Controls.Add(Me.pnl1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(557, 361)
        Me.pnlMain.TabIndex = 8
        '
        'pnl5
        '
        Me.pnl5.BackColor = System.Drawing.SystemColors.Control
        Me.pnl5.Controls.Add(Me.pnl5chkOpenFile)
        Me.pnl5.Controls.Add(Me.Label4)
        Me.pnl5.Controls.Add(Me.pnl5Title)
        Me.pnl5.Location = New System.Drawing.Point(329, 169)
        Me.pnl5.Name = "pnl5"
        Me.pnl5.Size = New System.Drawing.Size(200, 100)
        Me.pnl5.TabIndex = 12
        '
        'pnl5chkOpenFile
        '
        Me.pnl5chkOpenFile.AutoSize = True
        Me.pnl5chkOpenFile.Location = New System.Drawing.Point(16, 140)
        Me.pnl5chkOpenFile.Name = "pnl5chkOpenFile"
        Me.pnl5chkOpenFile.Size = New System.Drawing.Size(94, 17)
        Me.pnl5chkOpenFile.TabIndex = 0
        Me.pnl5chkOpenFile.Text = "Ejecutar Word"
        Me.pnl5chkOpenFile.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(529, 53)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Especifique si desea ejecutar Microsoft Word una vez generado el Libro."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl5Title
        '
        Me.pnl5Title.BackColor = System.Drawing.Color.White
        Me.pnl5Title.Controls.Add(Me.pnl5lblTitle2)
        Me.pnl5Title.Controls.Add(Me.pnl5lblTitle1)
        Me.pnl5Title.Controls.Add(Me.PictureBox3)
        Me.pnl5Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl5Title.Location = New System.Drawing.Point(0, 0)
        Me.pnl5Title.Name = "pnl5Title"
        Me.pnl5Title.Size = New System.Drawing.Size(200, 71)
        Me.pnl5Title.TabIndex = 17
        '
        'pnl5lblTitle2
        '
        Me.pnl5lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl5lblTitle2.Location = New System.Drawing.Point(13, 35)
        Me.pnl5lblTitle2.Name = "pnl5lblTitle2"
        Me.pnl5lblTitle2.Size = New System.Drawing.Size(456, 23)
        Me.pnl5lblTitle2.TabIndex = 2
        Me.pnl5lblTitle2.Text = "¿Consulta en este instante el libro generado?"
        Me.pnl5lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl5lblTitle1
        '
        Me.pnl5lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl5lblTitle1.Location = New System.Drawing.Point(13, 12)
        Me.pnl5lblTitle1.Name = "pnl5lblTitle1"
        Me.pnl5lblTitle1.Size = New System.Drawing.Size(456, 23)
        Me.pnl5lblTitle1.TabIndex = 1
        Me.pnl5lblTitle1.Text = "Microsoft Word"
        Me.pnl5lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Crm.UI.My.Resources.Resources.wWordLogo
        Me.PictureBox3.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'pnl4
        '
        Me.pnl4.BackColor = System.Drawing.SystemColors.Control
        Me.pnl4.Controls.Add(Me.pnl4chkSaveFile)
        Me.pnl4.Controls.Add(Me.pnl4cmdBrowse)
        Me.pnl4.Controls.Add(Me.Label2)
        Me.pnl4.Controls.Add(Me.pnl4txtFile)
        Me.pnl4.Controls.Add(Me.Label3)
        Me.pnl4.Controls.Add(Me.pnl4Title)
        Me.pnl4.Location = New System.Drawing.Point(329, 35)
        Me.pnl4.Name = "pnl4"
        Me.pnl4.Size = New System.Drawing.Size(207, 46)
        Me.pnl4.TabIndex = 11
        '
        'pnl4chkSaveFile
        '
        Me.pnl4chkSaveFile.AutoSize = True
        Me.pnl4chkSaveFile.Location = New System.Drawing.Point(22, 134)
        Me.pnl4chkSaveFile.Name = "pnl4chkSaveFile"
        Me.pnl4chkSaveFile.Size = New System.Drawing.Size(124, 17)
        Me.pnl4chkSaveFile.TabIndex = 0
        Me.pnl4chkSaveFile.Text = "Graba el Documento"
        Me.pnl4chkSaveFile.UseVisualStyleBackColor = True
        '
        'pnl4cmdBrowse
        '
        Me.pnl4cmdBrowse.Enabled = False
        Me.pnl4cmdBrowse.Location = New System.Drawing.Point(448, 204)
        Me.pnl4cmdBrowse.Name = "pnl4cmdBrowse"
        Me.pnl4cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.pnl4cmdBrowse.TabIndex = 2
        Me.pnl4cmdBrowse.Text = "&Examinar"
        Me.pnl4cmdBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre del Libro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl4txtFile
        '
        Me.pnl4txtFile.Enabled = False
        Me.pnl4txtFile.Location = New System.Drawing.Point(21, 204)
        Me.pnl4txtFile.Name = "pnl4txtFile"
        Me.pnl4txtFile.Size = New System.Drawing.Size(420, 20)
        Me.pnl4txtFile.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(529, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Si desea salvar el Documento, ingrese el nombre y la ubicación donde guardará la " & _
            "información. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o bien búsquelo haciendo click en el botón 'Examinar'"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl4Title
        '
        Me.pnl4Title.BackColor = System.Drawing.Color.White
        Me.pnl4Title.Controls.Add(Me.pnl4lblTitle2)
        Me.pnl4Title.Controls.Add(Me.pnl4lblTitle1)
        Me.pnl4Title.Controls.Add(Me.PictureBox2)
        Me.pnl4Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl4Title.Location = New System.Drawing.Point(0, 0)
        Me.pnl4Title.Name = "pnl4Title"
        Me.pnl4Title.Size = New System.Drawing.Size(207, 71)
        Me.pnl4Title.TabIndex = 11
        '
        'pnl4lblTitle2
        '
        Me.pnl4lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl4lblTitle2.Location = New System.Drawing.Point(13, 35)
        Me.pnl4lblTitle2.Name = "pnl4lblTitle2"
        Me.pnl4lblTitle2.Size = New System.Drawing.Size(456, 23)
        Me.pnl4lblTitle2.TabIndex = 2
        Me.pnl4lblTitle2.Text = "¿Grabará la información generada en el reporte?"
        Me.pnl4lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl4lblTitle1
        '
        Me.pnl4lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl4lblTitle1.Location = New System.Drawing.Point(13, 12)
        Me.pnl4lblTitle1.Name = "pnl4lblTitle1"
        Me.pnl4lblTitle1.Size = New System.Drawing.Size(456, 23)
        Me.pnl4lblTitle1.TabIndex = 1
        Me.pnl4lblTitle1.Text = "Tipo de Documento"
        Me.pnl4lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Crm.UI.My.Resources.Resources.wWordLogo
        Me.PictureBox2.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.lblMessage)
        Me.pnl1.Controls.Add(Me.lblTitle)
        Me.pnl1.Controls.Add(Me.PictLogo)
        Me.pnl1.Location = New System.Drawing.Point(33, 23)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(251, 69)
        Me.pnl1.TabIndex = 8
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(163, 41)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(377, 32)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.Text = "Este asistente lo ayudará a exportar un reporte del CRM 2x4 a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Microsoft Word"
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(163, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 41)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Bienvenido al asistente de exportación a Word"
        '
        'PictLogo
        '
        Me.PictLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictLogo.Image = Global.Crm.UI.My.Resources.Resources.wWord
        Me.PictLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictLogo.Name = "PictLogo"
        Me.PictLogo.Size = New System.Drawing.Size(163, 69)
        Me.PictLogo.TabIndex = 7
        Me.PictLogo.TabStop = False
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.SystemColors.Control
        Me.pnlButtons.Controls.Add(Me.cmdCancel)
        Me.pnlButtons.Controls.Add(Me.cmdNext)
        Me.pnlButtons.Controls.Add(Me.cmdPrevious)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 311)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(557, 50)
        Me.pnlButtons.TabIndex = 9
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(472, 15)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "&Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(373, 15)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "&Siguiente >"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Enabled = False
        Me.cmdPrevious.Location = New System.Drawing.Point(299, 15)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrevious.TabIndex = 0
        Me.cmdPrevious.Text = "< &Atras"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'frmExportWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 361)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExportWord"
        Me.Text = "Asistente de exportación a Microsoft Word"
        Me.pnlMain.ResumeLayout(False)
        Me.pnl5.ResumeLayout(False)
        Me.pnl5.PerformLayout()
        Me.pnl5Title.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl4.ResumeLayout(False)
        Me.pnl4.PerformLayout()
        Me.pnl4Title.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.PictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnl4 As System.Windows.Forms.Panel
    Friend WithEvents pnl4chkSaveFile As System.Windows.Forms.CheckBox
    Friend WithEvents pnl4cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl4txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnl4Title As System.Windows.Forms.Panel
    Friend WithEvents pnl4lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents pnl4lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl5 As System.Windows.Forms.Panel
    Friend WithEvents pnl5chkOpenFile As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnl5Title As System.Windows.Forms.Panel
    Friend WithEvents pnl5lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents pnl5lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
End Class
