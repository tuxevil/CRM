<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFormat
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Pantalla", "Muestra el reporte en pantalla", ""}, "Screen.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Impresora", "Imprime el reporte", ""}, "Printer.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 12.0!))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PDF", "Archivo de Adobe Acrobat", "*.pdf"}, "PDF.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 12.0!))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Microsoft Excel", "Planilla de Microsoft Excel", "*.xls"}, "Excel.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 12.0!))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Microsoft Word", "Documento de Microsoft Word", "*.doc"}, "Word.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 12.0!))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Microsoft Access", "Base de datos de Microsoft Access", "*.mdb"}, "Access.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Calibri", 12.0!))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportFormat))
        Me.PictureLog = New System.Windows.Forms.PictureBox
        Me.ListFormats = New System.Windows.Forms.ListView
        Me.FormatName = New System.Windows.Forms.ColumnHeader
        Me.FormatDescription = New System.Windows.Forms.ColumnHeader
        Me.FormatExtension = New System.Windows.Forms.ColumnHeader
        Me.IList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        CType(Me.PictureLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureLog
        '
        Me.PictureLog.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureLog.Image = Global.Crm.UI.My.Resources.Resources.BackLogin
        Me.PictureLog.Location = New System.Drawing.Point(0, 0)
        Me.PictureLog.Name = "PictureLog"
        Me.PictureLog.Size = New System.Drawing.Size(173, 320)
        Me.PictureLog.TabIndex = 0
        Me.PictureLog.TabStop = False
        '
        'ListFormats
        '
        Me.ListFormats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListFormats.BackColor = System.Drawing.SystemColors.Control
        Me.ListFormats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FormatName, Me.FormatDescription, Me.FormatExtension})
        Me.ListFormats.FullRowSelect = True
        Me.ListFormats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListFormats.HideSelection = False
        ListViewItem1.Tag = "0"
        ListViewItem2.Tag = "5"
        ListViewItem3.Tag = "1"
        ListViewItem4.Tag = "2"
        ListViewItem5.Tag = "3"
        ListViewItem6.Tag = "4"
        Me.ListFormats.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ListFormats.LargeImageList = Me.IList
        Me.ListFormats.Location = New System.Drawing.Point(179, 12)
        Me.ListFormats.Name = "ListFormats"
        Me.ListFormats.Size = New System.Drawing.Size(604, 241)
        Me.ListFormats.SmallImageList = Me.IList
        Me.ListFormats.TabIndex = 1
        Me.ListFormats.UseCompatibleStateImageBehavior = False
        Me.ListFormats.View = System.Windows.Forms.View.Details
        '
        'FormatName
        '
        Me.FormatName.Width = 175
        '
        'FormatDescription
        '
        Me.FormatDescription.Width = 371
        '
        'FormatExtension
        '
        Me.FormatExtension.Width = 0
        '
        'IList
        '
        Me.IList.ImageStream = CType(resources.GetObject("IList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IList.TransparentColor = System.Drawing.Color.Transparent
        Me.IList.Images.SetKeyName(0, "Access.png")
        Me.IList.Images.SetKeyName(1, "Excel.png")
        Me.IList.Images.SetKeyName(2, "PDF.png")
        Me.IList.Images.SetKeyName(3, "Screen.png")
        Me.IList.Images.SetKeyName(4, "Word.png")
        Me.IList.Images.SetKeyName(5, "Printer.png")
        '
        'cmdAccept
        '
        Me.cmdAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAccept.Enabled = False
        Me.cmdAccept.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.Location = New System.Drawing.Point(578, 251)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(94, 33)
        Me.cmdAccept.TabIndex = 2
        Me.cmdAccept.Text = "Aceptar"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(678, 251)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 33)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmReportFormat
        '
        Me.AcceptButton = Me.cmdAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(784, 320)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.ListFormats)
        Me.Controls.Add(Me.PictureLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportFormat"
        Me.Text = "Seleccione el destino del reporte"
        CType(Me.PictureLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureLog As System.Windows.Forms.PictureBox
    Friend WithEvents ListFormats As System.Windows.Forms.ListView
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents IList As System.Windows.Forms.ImageList
    Friend WithEvents FormatName As System.Windows.Forms.ColumnHeader
    Friend WithEvents FormatDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents FormatExtension As System.Windows.Forms.ColumnHeader
End Class
