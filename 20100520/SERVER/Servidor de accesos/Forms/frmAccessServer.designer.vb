<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccessServer))
        Me.IconTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ServerMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ServerMenuNewWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.ServerMenuWindows = New System.Windows.Forms.ToolStripMenuItem
        Me.ServerMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ServerMenuConfig = New System.Windows.Forms.ToolStripMenuItem
        Me.ServerMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ServerMenuCloseWindows = New System.Windows.Forms.ToolStripMenuItem
        Me.ServerMenuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.ServerMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconTray
        '
        Me.IconTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.IconTray.BalloonTipTitle = "Servidor de accesos"
        Me.IconTray.ContextMenuStrip = Me.ServerMenu
        Me.IconTray.Icon = CType(resources.GetObject("IconTray.Icon"), System.Drawing.Icon)
        Me.IconTray.Text = "Servidor de accesos"
        Me.IconTray.Visible = True
        '
        'ServerMenu
        '
        Me.ServerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerMenuNewWindow, Me.ServerMenuWindows, Me.ServerMenuSeparator1, Me.ServerMenuConfig, Me.ServerMenuSeparator2, Me.ServerMenuCloseWindows, Me.ServerMenuExit})
        Me.ServerMenu.Name = "ServerMenu"
        Me.ServerMenu.Size = New System.Drawing.Size(156, 148)
        '
        'ServerMenuNewWindow
        '
        Me.ServerMenuNewWindow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerMenuNewWindow.Name = "ServerMenuNewWindow"
        Me.ServerMenuNewWindow.Size = New System.Drawing.Size(155, 22)
        Me.ServerMenuNewWindow.Text = "Nuevo menú"
        '
        'ServerMenuWindows
        '
        Me.ServerMenuWindows.Name = "ServerMenuWindows"
        Me.ServerMenuWindows.Size = New System.Drawing.Size(155, 22)
        Me.ServerMenuWindows.Text = "Ventanas"
        Me.ServerMenuWindows.Visible = False
        '
        'ServerMenuSeparator1
        '
        Me.ServerMenuSeparator1.Name = "ServerMenuSeparator1"
        Me.ServerMenuSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'ServerMenuConfig
        '
        Me.ServerMenuConfig.Name = "ServerMenuConfig"
        Me.ServerMenuConfig.Size = New System.Drawing.Size(155, 22)
        Me.ServerMenuConfig.Text = "Configurar"
        '
        'ServerMenuSeparator2
        '
        Me.ServerMenuSeparator2.Name = "ServerMenuSeparator2"
        Me.ServerMenuSeparator2.Size = New System.Drawing.Size(152, 6)
        '
        'ServerMenuCloseWindows
        '
        Me.ServerMenuCloseWindows.Name = "ServerMenuCloseWindows"
        Me.ServerMenuCloseWindows.Size = New System.Drawing.Size(155, 22)
        Me.ServerMenuCloseWindows.Text = "Cerrar todo"
        '
        'ServerMenuExit
        '
        Me.ServerMenuExit.Name = "ServerMenuExit"
        Me.ServerMenuExit.Size = New System.Drawing.Size(155, 22)
        Me.ServerMenuExit.Text = "Salir"
        '
        'frmAccessServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AccessServer.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(400, 251)
        Me.ContextMenuStrip = Me.ServerMenu
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccessServer"
        Me.Text = "Servidor de accesos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ServerMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ServerMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ServerMenuNewWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ServerMenuConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerMenuSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ServerMenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerMenuWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerMenuCloseWindows As System.Windows.Forms.ToolStripMenuItem
End Class
