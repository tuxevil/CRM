Public Class frmReportViewer

    Private ReportFormat As Integer
    Private BrowserFilter As String
    Private Table As DataTable

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal RptSource As Object, ByVal rptDataSource As DataTable, ByVal Title As String)
        InitializeComponent()

        CRViewer.ReportSource = RptSource

        Table = rptDataSource

        Me.Text = Title

    End Sub


    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.Hide()

            If SelectFormat() = Windows.Forms.DialogResult.Cancel Then
                Me.Close()
                Exit Sub
            Else
                FormatReport()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function SelectFormat() As DialogResult
        Dim frm As frmReportFormat
        Dim Result As DialogResult

        Try

            frm = New frmReportFormat

            Result = frm.ShowDialog()

            If Result <> Windows.Forms.DialogResult.Cancel Then

                ReportFormat = frm.selectedFormat

                BrowserFilter = frm.SelectedFileType

            End If

            Return Result

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Sub FormatReport()
        Try
            Select Case ReportFormat

                Case 0 : Me.Show()

                Case 1 : FormatReportToPdf()

                Case 2 : FormatReportToExcel()

                Case 3 : FormatReportToWord()

                Case 4

                Case 5 : FormatReportToPrinter()

            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub FormatReportToExcel()
        Dim UserAction As DialogResult
        Dim Wizard As frmExportExcel

        Dim DestinationFile As String

        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim RptOptions As CrystalDecisions.Shared.ExportOptions
        Dim FileOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim ExcelOptions As CrystalDecisions.Shared.ExcelFormatOptions

        Dim fileInfo As System.IO.FileInfo

        Try

            Rpt = CRViewer.ReportSource

            Wizard = New frmExportExcel

            UserAction = Wizard.ShowDialog()

            If UserAction <> Windows.Forms.DialogResult.OK Then
                Me.Close()
                Exit Sub
            End If


            If Wizard.SaveAsFile <> "" Then
                DestinationFile = Wizard.SaveAsFile
            Else
                DestinationFile = System.IO.Path.GetTempPath() & Me.Text & ".xls"
            End If

            If Wizard.SaveInFile <> "" Then
                If Wizard.SaveAsFile <> DestinationFile Then
                    fileInfo = New System.IO.FileInfo(Wizard.SaveInFile)
                    fileInfo.CopyTo(DestinationFile, True)
                End If
            End If

            ExcelOptions = New CrystalDecisions.Shared.ExcelFormatOptions
            ExcelOptions.ExcelAreaType = CrystalDecisions.Shared.AreaSectionKind.Detail
            ExcelOptions.ExcelTabHasColumnHeadings = True
            ExcelOptions.ExcelUseConstantColumnWidth = False

            RptOptions = New CrystalDecisions.Shared.ExportOptions
            RptOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.Excel
            RptOptions.ExportFormatOptions = ExcelOptions

            FileOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
            FileOptions.DiskFileName = DestinationFile

            RptOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            RptOptions.ExportDestinationOptions = FileOptions

            Rpt.Export(RptOptions)

            If Wizard.RunApplication Then Process.Start(DestinationFile)

            Me.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub FormatReportToWord()

        Dim UserAction As DialogResult
        Dim Wizard As frmExportWord

        Dim DestinationFile As String

        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim RptOptions As CrystalDecisions.Shared.ExportOptions
        Dim FileOptions As CrystalDecisions.Shared.DiskFileDestinationOptions

        Try

            Rpt = CRViewer.ReportSource

            Wizard = New frmExportWord

            UserAction = Wizard.ShowDialog()

            If UserAction <> Windows.Forms.DialogResult.OK Then
                Me.Close()
                Exit Sub
            End If


            If Wizard.SaveAsFile <> "" Then
                DestinationFile = Wizard.SaveAsFile
            Else
                DestinationFile = System.IO.Path.GetTempPath() & Me.Text & ".doc"
            End If

            RptOptions = New CrystalDecisions.Shared.ExportOptions
            RptOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows

            FileOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
            FileOptions.DiskFileName = DestinationFile

            RptOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            RptOptions.ExportDestinationOptions = FileOptions

            Rpt.Export(RptOptions)

            If Wizard.RunApplication Then Process.Start(DestinationFile)

            Me.Close()

        Catch ex As Exception
            Throw ex
        End Try

        'Dim UserAction As DialogResult
        'Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'Dim RptOptions As CrystalDecisions.Shared.ExportOptions

        ''Dim FileOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        ''Dim Browser As SaveFileDialog

        'Try

        '    If ReportFormat = 0 Then
        '        Me.Show()
        '        Exit Sub
        '    End If

        '    Rpt = CRViewer.ReportSource

        '    'FileOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions

        '    'Browser = New SaveFileDialog
        '    'Browser.Filter = BrowserFilter

        '    'If Browser.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    '    FileOptions.DiskFileName = Browser.FileName
        '    'Else
        '    '    Me.Close()
        '    '    Exit Sub
        '    'End If

        '    RptOptions = New CrystalDecisions.Shared.ExportOptions

        '    Select Case ReportFormat
        '        Case 1
        '            Dim PdfOptions As CrystalDecisions.Shared.PdfRtfWordFormatOptions

        '            PdfOptions = New CrystalDecisions.Shared.PdfRtfWordFormatOptions

        '            RptOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
        '            RptOptions.ExportFormatOptions = PdfOptions

        '        Case 2
        '            Dim frm As frmExportExcel
        '            frm = New frmExportExcel

        '            UserAction = frm.ShowDialog()

        '            If UserAction = Windows.Forms.DialogResult.OK Then
        '                'Dim ExcelOptions As CrystalDecisions.Shared.ExcelFormatOptions

        '                'ExcelOptions = New CrystalDecisions.Shared.ExcelFormatOptions
        '                'ExcelOptions.ExcelAreaType = CrystalDecisions.Shared.AreaSectionKind.Detail

        '                'RptOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.Excel
        '                'RptOptions.ExportFormatOptions = ExcelOptions
        '            End If

        '        Case 3
        '            Dim WordOptions As CrystalDecisions.Shared.PdfRtfWordFormatOptions

        '            WordOptions = New CrystalDecisions.Shared.PdfRtfWordFormatOptions

        '            RptOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows
        '            RptOptions.ExportFormatOptions = WordOptions

        '        Case 4

        '            'Dim msAccess As Microsoft.Office.Interop.Access.Application

        '            'Dim xDoc As String

        '            'Dim fileInfo As System.IO.FileInfo

        '            'xDoc = Application.StartupPath & "\" & table.GetHashCode & ".xml"

        '            'table.WriteXml(xDoc)

        '            'table.Dispose()

        '            'table = Nothing

        '            'msAccess = New Microsoft.Office.Interop.Access.Application()

        '            'fileInfo = New System.IO.FileInfo(FileOptions.DiskFileName)

        '            'If fileInfo.Exists Then

        '            '    msAccess.OpenAccessProject(FileOptions.DiskFileName, False)

        '            'Else

        '            '    msAccess.CreateAccessProject(FileOptions.DiskFileName)

        '            'End If

        '            'fileInfo = Nothing

        '            'msAccess.ImportXML(xDoc, Microsoft.Office.Interop.Access.AcImportXMLOption.acAppendData)

        '            'msAccess.CloseCurrentDatabase()

        '            'msAccess = Nothing


        '    End Select

        '    'RptOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        '    ''RptOptions.ExportDestinationOptions = FileOptions

        '    'Rpt.Export(RptOptions)

        '    'Me.Close()

        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub FormatReportToPrinter()
        Dim PrinterSetup As PrintDialog
        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument

        'Dim nFirstPage As Integer
        'Dim nLastPage As Integer

        Try

            PrinterSetup = New PrintDialog

            If PrinterSetup.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Try

            Rpt = CRViewer.ReportSource

            Rpt.PrintOptions.PrinterName = PrinterSetup.PrinterSettings.PrinterName

            Rpt.PrintToPrinter(PrinterSetup.PrinterSettings.Copies, PrinterSetup.PrinterSettings.Collate, 0, 0)

        Catch ex As Exception
            Throw ex
        Finally

            Me.Close()
            PrinterSetup = Nothing

        End Try
    End Sub


    Private Sub FormatReportToPdf()


        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim RptOptions As CrystalDecisions.Shared.ExportOptions
        Dim PdfOptions As CrystalDecisions.Shared.PdfRtfWordFormatOptions
        Dim fileInfo As System.IO.FileInfo
        Dim FileOptions As CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim DestinationFile As String

        Try

            DestinationFile = System.IO.Path.GetTempPath() & Me.Text & ".pdf"

            fileInfo = New System.IO.FileInfo(DestinationFile)

            If fileInfo.Exists Then fileInfo.Delete()

            Rpt = CRViewer.ReportSource

            PdfOptions = New CrystalDecisions.Shared.PdfRtfWordFormatOptions

            RptOptions = New CrystalDecisions.Shared.ExportOptions
            RptOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            RptOptions.ExportFormatOptions = PdfOptions

            FileOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
            FileOptions.DiskFileName = DestinationFile

            RptOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            RptOptions.ExportDestinationOptions = FileOptions

            Rpt.Export(RptOptions)

            Process.Start(DestinationFile)

            Me.Close()

        Catch ex As Exception
            Throw ex
        Finally
            fileInfo = Nothing
        End Try

    End Sub
End Class