Public Class EntityHandler

    Public Shared Function Serialize(ByVal Entity As Object) As String
        Dim Serializer As Xml.Serialization.XmlSerializer
        Dim EntityClass As Type
        Dim xName As String
        Dim xDoc As String = ""
        Dim fileInfo As System.IO.FileInfo
        Dim Writer As Xml.XmlWriter
        Dim Reader As System.IO.StreamReader

        Try

            xName = Entity.GetHashCode.ToString & ".tmp"

            fileInfo = New System.IO.FileInfo(xName)

            If fileInfo.Exists Then fileInfo.Delete()

            Writer = Xml.XmlWriter.Create(xName)

            EntityClass = Entity.GetType

            Serializer = New Xml.Serialization.XmlSerializer(EntityClass)

            Serializer.Serialize(Writer, Entity)

            EntityClass = Nothing

            If Writer.WriteState <> Xml.WriteState.Closed Then Writer.Close()

            Writer = Nothing

            Serializer = Nothing

            fileInfo = New System.IO.FileInfo(xName)

            If Not fileInfo.Exists Then Return xDoc

            Reader = New System.IO.StreamReader(xName)

            xDoc = Reader.ReadToEnd

            Reader.Close()

            Reader = Nothing

            If fileInfo.Exists Then fileInfo.Delete()

            fileInfo = Nothing

            Return xDoc

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Shared Function Deserialize(ByVal EntityClass As String, ByVal xDoc As String) As Object
        Dim MyAssembly As System.Reflection.Assembly
        Dim EntityType As Type
        Dim Serializer As Xml.Serialization.XmlSerializer
        Dim xName As String
        Dim fileInfo As System.IO.FileInfo
        Dim Writer As System.IO.StreamWriter
        Dim Reader As Xml.XmlReader
        Dim Entity As Object

        Try

            MyAssembly = System.Reflection.Assembly.GetExecutingAssembly

            EntityType = MyAssembly.GetType("Crm.Domain." & EntityClass)

            MyAssembly = Nothing

            If EntityType Is Nothing Then Return Nothing

            xName = "Entity.tmp"

            fileInfo = New System.IO.FileInfo(xName)

            If fileInfo.Exists Then fileInfo.Delete()

            Writer = New System.IO.StreamWriter(xName)

            Writer.Write(xDoc)

            Writer.Close()

            Writer = Nothing

            Reader = Xml.XmlReader.Create(xName)

            Serializer = New Xml.Serialization.XmlSerializer(EntityType)

            Entity = Serializer.Deserialize(Reader)

            EntityType = Nothing

            If Reader.ReadState <> Xml.ReadState.Closed Then Reader.Close()

            Reader = Nothing

            Serializer = Nothing

            fileInfo = New System.IO.FileInfo(xName)

            If fileInfo.Exists Then
                Try

                    fileInfo.Delete()

                Catch ex As Exception
                    ex = Nothing
                End Try

            End If

            fileInfo = Nothing

            Return Entity

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
