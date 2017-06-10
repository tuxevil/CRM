<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportExcel))
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.pnlMain = New System.Windows.Forms.Panel
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
        Me.pnl5 = New System.Windows.Forms.Panel
        Me.pnl5chkOpenFile = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnl5Title = New System.Windows.Forms.Panel
        Me.pnl5lblTitle2 = New System.Windows.Forms.Label
        Me.pnl5lblTitle1 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pnl3 = New System.Windows.Forms.Panel
        Me.pnl3cmdBrowse = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl3txtFile = New System.Windows.Forms.TextBox
        Me.pnl3lblMesagge = New System.Windows.Forms.Label
        Me.pnl3Title = New System.Windows.Forms.Panel
        Me.pnl3lblTitle2 = New System.Windows.Forms.Label
        Me.pnl3lblTitle1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.pnl2lblMessage = New System.Windows.Forms.Label
        Me.OptExistingFile = New System.Windows.Forms.RadioButton
        Me.OptNewFile = New System.Windows.Forms.RadioButton
        Me.pnl2Title = New System.Windows.Forms.Panel
        Me.pnl2lblTitle2 = New System.Windows.Forms.Label
        Me.pnl2lblTitle1 = New System.Windows.Forms.Label
        Me.pnl2Picture = New System.Windows.Forms.PictureBox
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictLogo = New System.Windows.Forms.PictureBox
        Me.pnlButtons.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnl4.SuspendLayout()
        Me.pnl4Title.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl5.SuspendLayout()
        Me.pnl5Title.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl3.SuspendLayout()
        Me.pnl3Title.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl2.SuspendLayout()
        Me.pnl2Title.SuspendLayout()
        CType(Me.pnl2Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        CType(Me.PictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlButtons.TabIndex = 3
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
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnl4)
        Me.pnlMain.Controls.Add(Me.pnl5)
        Me.pnlMain.Controls.Add(Me.pnl3)
        Me.pnlMain.Controls.Add(Me.pnl2)
        Me.pnlMain.Controls.Add(Me.pnl1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(557, 311)
        Me.pnlMain.TabIndex = 7
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
        Me.pnl4chkSaveFile.Size = New System.Drawing.Size(92, 17)
        Me.pnl4chkSaveFile.TabIndex = 0
        Me.pnl4chkSaveFile.Text = "Graba el Libro"
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
        Me.Label3.Text = "Si desea salvar el Libro, ingrese el nombre y la ubicación donde guardará la info" & _
            "rmación. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o bien búsquelo haciendo click en el botón 'Examinar'"
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
        Me.pnl4lblTitle2.Text = "¿Grabará la información generada en el Libro?"
        Me.pnl4lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl4lblTitle1
        '
        Me.pnl4lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl4lblTitle1.Location = New System.Drawing.Point(13, 12)
        Me.pnl4lblTitle1.Name = "pnl4lblTitle1"
        Me.pnl4lblTitle1.Size = New System.Drawing.Size(456, 23)
        Me.pnl4lblTitle1.TabIndex = 1
        Me.pnl4lblTitle1.Text = "Tipo de Libro"
        Me.pnl4lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Crm.UI.My.Resources.Resources.wExcelLogo
        Me.PictureBox2.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'pnl5
        '
        Me.pnl5.BackColor = System.Drawing.SystemColors.Control
        Me.pnl5.Controls.Add(Me.pnl5chkOpenFile)
        Me.pnl5.Controls.Add(Me.Label4)
        Me.pnl5.Controls.Add(Me.pnl5Title)
        Me.pnl5.Location = New System.Drawing.Point(357, 184)
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
        Me.pnl5chkOpenFile.Text = "Ejecutar Excel"
        Me.pnl5chkOpenFile.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(529, 53)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Especifique si desea ejecutar Microsoft Excel una vez generado el Libro."
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
        Me.pnl5lblTitle1.Text = "Microsoft Excel"
        Me.pnl5lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Crm.UI.My.Resources.Resources.wExcelLogo
        Me.PictureBox3.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'pnl3
        '
        Me.pnl3.BackColor = System.Drawing.SystemColors.Control
        Me.pnl3.Controls.Add(Me.pnl3cmdBrowse)
        Me.pnl3.Controls.Add(Me.Label1)
        Me.pnl3.Controls.Add(Me.pnl3txtFile)
        Me.pnl3.Controls.Add(Me.pnl3lblMesagge)
        Me.pnl3.Controls.Add(Me.pnl3Title)
        Me.pnl3.Location = New System.Drawing.Point(33, 204)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(200, 100)
        Me.pnl3.TabIndex = 10
        '
        'pnl3cmdBrowse
        '
        Me.pnl3cmdBrowse.Location = New System.Drawing.Point(443, 166)
        Me.pnl3cmdBrowse.Name = "pnl3cmdBrowse"
        Me.pnl3cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.pnl3cmdBrowse.TabIndex = 1
        Me.pnl3cmdBrowse.Text = "&Examinar"
        Me.pnl3cmdBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre del Libro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl3txtFile
        '
        Me.pnl3txtFile.Location = New System.Drawing.Point(16, 166)
        Me.pnl3txtFile.Name = "pnl3txtFile"
        Me.pnl3txtFile.Size = New System.Drawing.Size(420, 20)
        Me.pnl3txtFile.TabIndex = 0
        '
        'pnl3lblMesagge
        '
        Me.pnl3lblMesagge.Location = New System.Drawing.Point(12, 93)
        Me.pnl3lblMesagge.Name = "pnl3lblMesagge"
        Me.pnl3lblMesagge.Size = New System.Drawing.Size(529, 41)
        Me.pnl3lblMesagge.TabIndex = 7
        Me.pnl3lblMesagge.Text = "Ingrese el nombre y la ubicación del Libro de Microsoft Excel donde guardará la i" & _
            "nformación, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o bien busque el libro haciendo click en el botón 'Examinar'"
        Me.pnl3lblMesagge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl3Title
        '
        Me.pnl3Title.BackColor = System.Drawing.Color.White
        Me.pnl3Title.Controls.Add(Me.pnl3lblTitle2)
        Me.pnl3Title.Controls.Add(Me.pnl3lblTitle1)
        Me.pnl3Title.Controls.Add(Me.PictureBox1)
        Me.pnl3Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl3Title.Location = New System.Drawing.Point(0, 0)
        Me.pnl3Title.Name = "pnl3Title"
        Me.pnl3Title.Size = New System.Drawing.Size(200, 71)
        Me.pnl3Title.TabIndex = 4
        '
        'pnl3lblTitle2
        '
        Me.pnl3lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl3lblTitle2.Location = New System.Drawing.Point(13, 35)
        Me.pnl3lblTitle2.Name = "pnl3lblTitle2"
        Me.pnl3lblTitle2.Size = New System.Drawing.Size(456, 23)
        Me.pnl3lblTitle2.TabIndex = 2
        Me.pnl3lblTitle2.Text = "Especifique el nombre y la ubicación del libro de Microsoft Excel"
        Me.pnl3lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl3lblTitle1
        '
        Me.pnl3lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl3lblTitle1.Location = New System.Drawing.Point(13, 12)
        Me.pnl3lblTitle1.Name = "pnl3lblTitle1"
        Me.pnl3lblTitle1.Size = New System.Drawing.Size(456, 23)
        Me.pnl3lblTitle1.TabIndex = 1
        Me.pnl3lblTitle1.Text = "Tipo de Libro"
        Me.pnl3lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Crm.UI.My.Resources.Resources.wExcelLogo
        Me.PictureBox1.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.SystemColors.Control
        Me.pnl2.Controls.Add(Me.pnl2lblMessage)
        Me.pnl2.Controls.Add(Me.OptExistingFile)
        Me.pnl2.Controls.Add(Me.OptNewFile)
        Me.pnl2.Controls.Add(Me.pnl2Title)
        Me.pnl2.Location = New System.Drawing.Point(33, 99)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(301, 99)
        Me.pnl2.TabIndex = 9
        '
        'pnl2lblMessage
        '
        Me.pnl2lblMessage.Location = New System.Drawing.Point(16, 95)
        Me.pnl2lblMessage.Name = "pnl2lblMessage"
        Me.pnl2lblMessage.Size = New System.Drawing.Size(529, 23)
        Me.pnl2lblMessage.TabIndex = 3
        Me.pnl2lblMessage.Text = "Seleccione en que libro guardará la información"
        Me.pnl2lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OptExistingFile
        '
        Me.OptExistingFile.AutoSize = True
        Me.OptExistingFile.Location = New System.Drawing.Point(33, 157)
        Me.OptExistingFile.Name = "OptExistingFile"
        Me.OptExistingFile.Size = New System.Drawing.Size(93, 17)
        Me.OptExistingFile.TabIndex = 1
        Me.OptExistingFile.Text = "Libro existente"
        Me.OptExistingFile.UseVisualStyleBackColor = True
        '
        'OptNewFile
        '
        Me.OptNewFile.AutoSize = True
        Me.OptNewFile.Checked = True
        Me.OptNewFile.Location = New System.Drawing.Point(33, 134)
        Me.OptNewFile.Name = "OptNewFile"
        Me.OptNewFile.Size = New System.Drawing.Size(81, 17)
        Me.OptNewFile.TabIndex = 0
        Me.OptNewFile.TabStop = True
        Me.OptNewFile.Text = "Libro nuevo"
        Me.OptNewFile.UseVisualStyleBackColor = True
        '
        'pnl2Title
        '
        Me.pnl2Title.BackColor = System.Drawing.Color.White
        Me.pnl2Title.Controls.Add(Me.pnl2lblTitle2)
        Me.pnl2Title.Controls.Add(Me.pnl2lblTitle1)
        Me.pnl2Title.Controls.Add(Me.pnl2Picture)
        Me.pnl2Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl2Title.Location = New System.Drawing.Point(0, 0)
        Me.pnl2Title.Name = "pnl2Title"
        Me.pnl2Title.Size = New System.Drawing.Size(301, 71)
        Me.pnl2Title.TabIndex = 0
        '
        'pnl2lblTitle2
        '
        Me.pnl2lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2lblTitle2.Location = New System.Drawing.Point(13, 35)
        Me.pnl2lblTitle2.Name = "pnl2lblTitle2"
        Me.pnl2lblTitle2.Size = New System.Drawing.Size(456, 23)
        Me.pnl2lblTitle2.TabIndex = 2
        Me.pnl2lblTitle2.Text = "En que libro guardará la información?"
        Me.pnl2lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl2lblTitle1
        '
        Me.pnl2lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2lblTitle1.Location = New System.Drawing.Point(13, 12)
        Me.pnl2lblTitle1.Name = "pnl2lblTitle1"
        Me.pnl2lblTitle1.Size = New System.Drawing.Size(456, 23)
        Me.pnl2lblTitle1.TabIndex = 1
        Me.pnl2lblTitle1.Text = "Tipo de Libro"
        Me.pnl2lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl2Picture
        '
        Me.pnl2Picture.Image = Global.Crm.UI.My.Resources.Resources.wExcelLogo
        Me.pnl2Picture.Location = New System.Drawing.Point(495, 12)
        Me.pnl2Picture.Name = "pnl2Picture"
        Me.pnl2Picture.Size = New System.Drawing.Size(50, 50)
        Me.pnl2Picture.TabIndex = 0
        Me.pnl2Picture.TabStop = False
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
        Me.lblMessage.Text = "Este asistente lo ayudará a exportar un reporte del CRM 2x4 a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Microsoft Excel"
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(163, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 41)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Bienvenido al asistente de exportación a Excel"
        '
        'PictLogo
        '
        Me.PictLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictLogo.Image = Global.Crm.UI.My.Resources.Resources.wExcel
        Me.PictLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictLogo.Name = "PictLogo"
        Me.PictLogo.Size = New System.Drawing.Size(163, 69)
        Me.PictLogo.TabIndex = 7
        Me.PictLogo.TabStop = False
        '
        'frmExportExcel
        '
        Me.AcceptButton = Me.cmdNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(557, 361)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlButtons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(565, 393)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(565, 393)
        Me.Name = "frmExportExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente de exportación a Microsoft Excel"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnl4.ResumeLayout(False)
        Me.pnl4.PerformLayout()
        Me.pnl4Title.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl5.ResumeLayout(False)
        Me.pnl5.PerformLayout()
        Me.pnl5Title.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl3.ResumeLayout(False)
        Me.pnl3.PerformLayout()
        Me.pnl3Title.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.pnl2Title.ResumeLayout(False)
        CType(Me.pnl2Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.PictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl2Title As System.Windows.Forms.Panel
    Friend WithEvents pnl2Picture As System.Windows.Forms.PictureBox
    Friend WithEvents pnl2lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents OptExistingFile As System.Windows.Forms.RadioButton
    Friend WithEvents OptNewFile As System.Windows.Forms.RadioButton
    Friend WithEvents pnl2lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents pnl2lblMessage As System.Windows.Forms.Label
    Friend WithEvents pnl3 As System.Windows.Forms.Panel
    Friend WithEvents pnl3lblMesagge As System.Windows.Forms.Label
    Friend WithEvents pnl3Title As System.Windows.Forms.Panel
    Friend WithEvents pnl3lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents pnl3lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl3cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl3txtFile As System.Windows.Forms.TextBox
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
End Class
