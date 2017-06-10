Imports System

Public Class XlsData

    Private xUrl As String
    Private xApp As Object
    Private xDoc As Object

    Public Sub New(ByVal Url As String)

        Try
            If Dir(Url, vbArchive) = "" Then Throw New Exception("El archivo especificado no existe o está dañado")

            xApp = CreateObject("Excel.Application")

            xDoc = xApp.Workbooks.Open(Url)

        Catch ex As Exception
            Throw New Exception("El archivo especificado no existe o está dañado")

        End Try


    End Sub

    Public Sub New()

        Try
            xApp = CreateObject("Excel.Application")

            xDoc = xApp.Workbooks.add("Hoja 1")

        Catch ex As Exception
            Throw New Exception("El archivo especificado no existe o está dañado")

        End Try


    End Sub

End Class
