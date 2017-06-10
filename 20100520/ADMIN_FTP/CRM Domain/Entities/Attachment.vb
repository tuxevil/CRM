Public Class Attachment

    Private mId As Integer
    Private mName As String
    Private mExtension As String


    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Public Property Extension() As String
        Get
            Return mExtension
        End Get
        Set(ByVal value As String)
            mExtension = value
        End Set
    End Property


End Class
