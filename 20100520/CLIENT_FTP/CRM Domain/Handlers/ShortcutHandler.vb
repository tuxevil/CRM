Imports System.Runtime.InteropServices

Public Class ShortcutHandler

    Public Shared Sub Add(ByVal filename As String, ByVal folder As String)
        Dim file As System.IO.FileInfo
        Dim WShell As Object
        Dim ShortCut As Object

        Try
            If Not folder.EndsWith("\") Then folder = folder & "\"

            file = New System.IO.FileInfo(filename)

            If file.Extension.ToUpper = ".LNK" Then

                Try
                    file.CopyTo(folder & file.Name)

                Catch ex As Exception
                    Throw ex

                End Try

            Else

                Try
                    WShell = CreateObject("wscript.Shell")

                    ShortCut = WShell.CreateShortcut(folder & DisplayName(file) & ".lnk")

                    With ShortCut
                        .TargetPath = file.FullName
                        .Save()
                    End With

                Catch ex As Exception
                    Throw ex

                End Try

            End If

        Catch ex As Exception
            Throw ex

        Finally
            file = Nothing
            WShell = Nothing
            ShortCut = Nothing

        End Try

    End Sub

    Public Shared Sub Delete(ByVal displayname As String, ByVal folder As String)
        Dim file As System.IO.FileInfo
        Dim filename As String

        Try
            If Not folder.EndsWith("\") Then folder = folder & "\"

            If Not displayname.ToLower.EndsWith(".lnk") Then
                filename = displayname & ".lnk"
            Else
                filename = displayname
            End If

            file = New System.IO.FileInfo(folder & filename)

            If file.Exists Then file.Delete()

        Catch ex As Exception
            Throw ex

        Finally
            file = Nothing
            filename = Nothing

        End Try

    End Sub

    Public Shared Sub Execute(ByVal displayname As String, ByVal folder As String)
        Dim file As System.IO.FileInfo
        Dim filename As String

        Try
            If Not folder.EndsWith("\") Then folder = folder & "\"

            If Not displayname.ToLower.EndsWith(".lnk") Then
                filename = displayname & ".lnk"
            Else
                filename = displayname
            End If

            file = New System.IO.FileInfo(folder & filename)

            If file.Exists Then
                System.Diagnostics.Process.Start(file.FullName)
            End If

        Catch ex As Exception
            Throw ex

        Finally
            file = Nothing
            filename = Nothing

        End Try

    End Sub

    Public Shared Function DisplayName(ByVal file As System.IO.FileInfo) As String

        Try
            If file Is Nothing Then Return ""

            If file.Extension <> "" Then Return Mid(file.Name, 1, Len(file.Name) - Len(file.Extension))

            Return file.Name

        Catch ex As Exception
            Return file.Name

        End Try

    End Function


    Public Shared Function GetIcon(ByVal filename As String) As Object

        Dim hImgSmall As IntPtr
        Dim fName As String
        Dim shinfo As SHFILEINFO

        Try
            shinfo = New SHFILEINFO

            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)
            fName = filename.ToString
            hImgSmall = SHGetFileInfo(fName, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)

            Return System.Drawing.Icon.FromHandle(shinfo.hIcon)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure

    Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" _
            (ByVal pszPath As String, _
             ByVal dwFileAttributes As Integer, _
             ByRef psfi As SHFILEINFO, _
             ByVal cbFileInfo As Integer, _
             ByVal uFlags As Integer) As IntPtr

    Private Const SHGFI_ICON = &H100
    Private Const SHGFI_SMALLICON = &H1
    Private Const SHGFI_LARGEICON = &H0    ' Large icon
    Private nIndex = 0

End Class
