<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridView
    Inherits System.Windows.Forms.DataGridView

    'Control overrides dispose to clean up the component list.
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

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GridViewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GridViewMenuFilter = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterEqual = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterEqualText = New System.Windows.Forms.ToolStripTextBox
        Me.GridViewMenuFilterNotEqual = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterNotEqualText = New System.Windows.Forms.ToolStripTextBox
        Me.GridViewMenuFilterContains = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterContainsText = New System.Windows.Forms.ToolStripTextBox
        Me.GridViewMenuFilterNotContains = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterNotContainsText = New System.Windows.Forms.ToolStripTextBox
        Me.GridViewMenuFilterGreater = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterGreaterText = New System.Windows.Forms.ToolStripTextBox
        Me.GridViewMenuFilterSmaller = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenuFilterSmallerText = New System.Windows.Forms.ToolStripTextBox
        Me.GridViewMenuUnFilter = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewMenu.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridViewMenu
        '
        Me.GridViewMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilter, Me.GridViewMenuUnFilter})
        Me.GridViewMenu.Name = "GridViewMenu"
        Me.GridViewMenu.Size = New System.Drawing.Size(141, 48)
        '
        'GridViewMenuFilter
        '
        Me.GridViewMenuFilter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterEqual, Me.GridViewMenuFilterNotEqual, Me.GridViewMenuFilterContains, Me.GridViewMenuFilterNotContains, Me.GridViewMenuFilterGreater, Me.GridViewMenuFilterSmaller})
        Me.GridViewMenuFilter.Name = "GridViewMenuFilter"
        Me.GridViewMenuFilter.Size = New System.Drawing.Size(140, 22)
        Me.GridViewMenuFilter.Text = "Filtrar"
        '
        'GridViewMenuFilterEqual
        '
        Me.GridViewMenuFilterEqual.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterEqualText})
        Me.GridViewMenuFilterEqual.Name = "GridViewMenuFilterEqual"
        Me.GridViewMenuFilterEqual.Size = New System.Drawing.Size(161, 22)
        Me.GridViewMenuFilterEqual.Text = "Es igual a .."
        '
        'GridViewMenuFilterEqualText
        '
        Me.GridViewMenuFilterEqualText.Name = "GridViewMenuFilterEqualText"
        Me.GridViewMenuFilterEqualText.Size = New System.Drawing.Size(100, 21)
        '
        'GridViewMenuFilterNotEqual
        '
        Me.GridViewMenuFilterNotEqual.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterNotEqualText})
        Me.GridViewMenuFilterNotEqual.Name = "GridViewMenuFilterNotEqual"
        Me.GridViewMenuFilterNotEqual.Size = New System.Drawing.Size(161, 22)
        Me.GridViewMenuFilterNotEqual.Text = "No es igual a ..."
        '
        'GridViewMenuFilterNotEqualText
        '
        Me.GridViewMenuFilterNotEqualText.Name = "GridViewMenuFilterNotEqualText"
        Me.GridViewMenuFilterNotEqualText.Size = New System.Drawing.Size(100, 21)
        '
        'GridViewMenuFilterContains
        '
        Me.GridViewMenuFilterContains.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterContainsText})
        Me.GridViewMenuFilterContains.Name = "GridViewMenuFilterContains"
        Me.GridViewMenuFilterContains.Size = New System.Drawing.Size(161, 22)
        Me.GridViewMenuFilterContains.Text = "Contiene ..."
        '
        'GridViewMenuFilterContainsText
        '
        Me.GridViewMenuFilterContainsText.Name = "GridViewMenuFilterContainsText"
        Me.GridViewMenuFilterContainsText.Size = New System.Drawing.Size(100, 21)
        '
        'GridViewMenuFilterNotContains
        '
        Me.GridViewMenuFilterNotContains.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterNotContainsText})
        Me.GridViewMenuFilterNotContains.Name = "GridViewMenuFilterNotContains"
        Me.GridViewMenuFilterNotContains.Size = New System.Drawing.Size(161, 22)
        Me.GridViewMenuFilterNotContains.Text = "No contiene ..."
        '
        'GridViewMenuFilterNotContainsText
        '
        Me.GridViewMenuFilterNotContainsText.Name = "GridViewMenuFilterNotContainsText"
        Me.GridViewMenuFilterNotContainsText.Size = New System.Drawing.Size(100, 21)
        '
        'GridViewMenuFilterGreater
        '
        Me.GridViewMenuFilterGreater.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterGreaterText})
        Me.GridViewMenuFilterGreater.Name = "GridViewMenuFilterGreater"
        Me.GridViewMenuFilterGreater.Size = New System.Drawing.Size(161, 22)
        Me.GridViewMenuFilterGreater.Text = "Mayor que ..."
        '
        'GridViewMenuFilterGreaterText
        '
        Me.GridViewMenuFilterGreaterText.Name = "GridViewMenuFilterGreaterText"
        Me.GridViewMenuFilterGreaterText.Size = New System.Drawing.Size(100, 21)
        '
        'GridViewMenuFilterSmaller
        '
        Me.GridViewMenuFilterSmaller.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridViewMenuFilterSmallerText})
        Me.GridViewMenuFilterSmaller.Name = "GridViewMenuFilterSmaller"
        Me.GridViewMenuFilterSmaller.Size = New System.Drawing.Size(161, 22)
        Me.GridViewMenuFilterSmaller.Text = "Menor que ..."
        '
        'GridViewMenuFilterSmallerText
        '
        Me.GridViewMenuFilterSmallerText.Name = "GridViewMenuFilterSmallerText"
        Me.GridViewMenuFilterSmallerText.Size = New System.Drawing.Size(100, 21)
        '
        'GridViewMenuUnFilter
        '
        Me.GridViewMenuUnFilter.Name = "GridViewMenuUnFilter"
        Me.GridViewMenuUnFilter.Size = New System.Drawing.Size(140, 22)
        Me.GridViewMenuUnFilter.Text = "Borrar filtro"
        Me.GridViewMenu.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridViewMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GridViewMenuFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterEqual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterNotEqual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuUnFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterContains As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterNotContains As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterGreater As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterSmaller As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewMenuFilterEqualText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GridViewMenuFilterNotEqualText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GridViewMenuFilterContainsText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GridViewMenuFilterNotContainsText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GridViewMenuFilterGreaterText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GridViewMenuFilterSmallerText As System.Windows.Forms.ToolStripTextBox

End Class

