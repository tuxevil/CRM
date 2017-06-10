Imports System.Xml

Public Class XmlData


    Private Reader As XmlReader
    Private Writer As XmlWriter
    Private XDoc As XmlDocument
    Private xUrl As String

    Public Sub New(ByVal Url As String)
        Try
            XDoc = New XmlDocument
            XDoc.Load(Url)
            xUrl = Url
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ReadData() As DataSet

        Dim ds As DataSet

        Try
            ds = New DataSet
            ds.ReadXml(xUrl)

            Return ds

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Public Function WriteData(ByVal Url As String, ByVal ds As DataSet) As Boolean

        Try
            ds.WriteXml(Url)
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

End Class
