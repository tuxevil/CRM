<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmException
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmException))
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.cmdDetail = New System.Windows.Forms.Button
        Me.txtDetail = New System.Windows.Forms.TextBox
        Me.cmdSendError = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMessage.Location = New System.Drawing.Point(12, 12)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(603, 43)
        Me.txtMessage.TabIndex = 0
        '
        'cmdDetail
        '
        Me.cmdDetail.Location = New System.Drawing.Point(12, 61)
        Me.cmdDetail.Name = "cmdDetail"
        Me.cmdDetail.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetail.TabIndex = 1
        Me.cmdDetail.Text = "Detalles >>>"
        Me.cmdDetail.UseVisualStyleBackColor = True
        '
        'txtDetail
        '
        Me.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetail.Location = New System.Drawing.Point(12, 90)
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.ReadOnly = True
        Me.txtDetail.Size = New System.Drawing.Size(603, 189)
        Me.txtDetail.TabIndex = 2
        Me.txtDetail.Visible = False
        '
        'cmdSendError
        '
        Me.cmdSendError.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSendError.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSendError.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSendError.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSendError.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSendError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendError.ForeColor = System.Drawing.Color.Blue
        Me.cmdSendError.Location = New System.Drawing.Point(458, 61)
        Me.cmdSendError.Name = "cmdSendError"
        Me.cmdSendError.Size = New System.Drawing.Size(157, 23)
        Me.cmdSendError.TabIndex = 3
        Me.cmdSendError.Text = "Enviar informe de errores"
        Me.cmdSendError.UseVisualStyleBackColor = True
        '
        'frmException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(635, 121)
        Me.Controls.Add(Me.cmdSendError)
        Me.Controls.Add(Me.txtDetail)
        Me.Controls.Add(Me.cmdDetail)
        Me.Controls.Add(Me.txtMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmException"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de errores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents cmdDetail As System.Windows.Forms.Button
    Friend WithEvents txtDetail As System.Windows.Forms.TextBox
    Friend WithEvents cmdSendError As System.Windows.Forms.Button
End Class
