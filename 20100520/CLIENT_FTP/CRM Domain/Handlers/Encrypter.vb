Public Class Encrypter

    Private Const SearchPattern As String = "abABONZ356X29Y7ELcDdRmCu01vwx4TPjklyWUefF8MGopSqrHInstQVJKghiz"
    Private Const EncryptPattern As String = "abA356X2opSqrPjOklyWUe9Y7ELwx4BZTfF8MGHIcDdNRmCu01vnstQVJKghiz"


    Public Shared Function EncryptString(ByVal text As String) As String
        Dim result As String = ""

        Try
            If text.Length = 0 Then Return ""

            For idx = 0 To text.Length - 1
                result = result & EncryptChar(text.Substring(idx, 1), text.Length, idx)
            Next

            Return result

        Catch ex As Exception
            Return text

        End Try

    End Function


    Private Shared Function EncryptChar(ByVal Chr As String, ByVal var As Integer, ByVal idx As Integer) As String
        Dim Index As Integer

        Try

            If SearchPattern.IndexOf(Chr) <> -1 Then
                Index = (SearchPattern.IndexOf(Chr) + var + idx) Mod SearchPattern.Length
                Return EncryptPattern.Substring(Index, 1)
            End If

            Return Chr

        Catch ex As Exception
            Return Chr

        End Try
    End Function

    Public Shared Function DecryptString(ByVal text As String) As String
        Dim result As String = ""

        Try
            For idx = 0 To text.Length - 1

                result = result & DecryptChar(text.Substring(idx, 1), text.Length, idx)

            Next

            ' MsgBox("Decrypting:" & vbNewLine & result, MsgBoxStyle.Information)
            Return result

        Catch ex As Exception
            Return text

        End Try

    End Function


    Private Shared Function DecryptChar(ByVal chr As String, ByVal var As Integer, ByVal idx As Integer) As String
        Dim index As Integer

        If EncryptPattern.IndexOf(chr) <> -1 Then

            If (EncryptPattern.IndexOf(chr) - var - idx) > 0 Then

                index = (EncryptPattern.IndexOf(chr) - var - idx) Mod EncryptPattern.Length

            Else

                index = (SearchPattern.Length) + ((EncryptPattern.IndexOf(chr) - var - idx) Mod EncryptPattern.Length)

            End If

            index = index Mod EncryptPattern.Length

            Return SearchPattern.Substring(index, 1)

        Else
            Return chr

        End If

    End Function

End Class
