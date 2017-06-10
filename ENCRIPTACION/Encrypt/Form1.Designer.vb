<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextToEncrypt = New System.Windows.Forms.RichTextBox
        Me.TextToDecrypt = New System.Windows.Forms.RichTextBox
        Me.cmdEncrypt = New System.Windows.Forms.Button
        Me.cmdDecrypt = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextToEncrypt
        '
        Me.TextToEncrypt.Location = New System.Drawing.Point(12, 12)
        Me.TextToEncrypt.Name = "TextToEncrypt"
        Me.TextToEncrypt.Size = New System.Drawing.Size(652, 183)
        Me.TextToEncrypt.TabIndex = 0
        Me.TextToEncrypt.Text = ""
        '
        'TextToDecrypt
        '
        Me.TextToDecrypt.Location = New System.Drawing.Point(12, 231)
        Me.TextToDecrypt.Name = "TextToDecrypt"
        Me.TextToDecrypt.Size = New System.Drawing.Size(652, 183)
        Me.TextToDecrypt.TabIndex = 1
        Me.TextToDecrypt.Text = ""
        '
        'cmdEncrypt
        '
        Me.cmdEncrypt.Location = New System.Drawing.Point(589, 202)
        Me.cmdEncrypt.Name = "cmdEncrypt"
        Me.cmdEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.cmdEncrypt.TabIndex = 2
        Me.cmdEncrypt.Text = "Cifrar"
        Me.cmdEncrypt.UseVisualStyleBackColor = True
        '
        'cmdDecrypt
        '
        Me.cmdDecrypt.Location = New System.Drawing.Point(508, 202)
        Me.cmdDecrypt.Name = "cmdDecrypt"
        Me.cmdDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.cmdDecrypt.TabIndex = 3
        Me.cmdDecrypt.Text = "Decifrar"
        Me.cmdDecrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 418)
        Me.Controls.Add(Me.cmdDecrypt)
        Me.Controls.Add(Me.cmdEncrypt)
        Me.Controls.Add(Me.TextToDecrypt)
        Me.Controls.Add(Me.TextToEncrypt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextToEncrypt As System.Windows.Forms.RichTextBox
    Friend WithEvents TextToDecrypt As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdEncrypt As System.Windows.Forms.Button
    Friend WithEvents cmdDecrypt As System.Windows.Forms.Button

End Class
