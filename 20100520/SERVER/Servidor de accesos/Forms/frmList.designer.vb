<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList))
        Me.chkOther = New System.Windows.Forms.CheckBox
        Me.List = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'chkOther
        '
        Me.chkOther.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkOther.Location = New System.Drawing.Point(0, 271)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(292, 24)
        Me.chkOther.TabIndex = 1
        Me.chkOther.Text = "Seleccionar un servidor que no está en la lista"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'List
        '
        Me.List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.List.FormattingEnabled = True
        Me.List.Location = New System.Drawing.Point(0, 0)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(292, 264)
        Me.List.TabIndex = 2
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 295)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.chkOther)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents List As System.Windows.Forms.ListBox
End Class
