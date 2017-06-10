Public Class SystemEntity

    Private mId As Integer
    Private mName As String
    Private mClassName As String
    Private mUserName As String

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

    Public Property ClassName() As String
        Get
            Return mClassName
        End Get
        Set(ByVal value As String)
            mClassName = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return mUserName
        End Get
        Set(ByVal value As String)
            mUserName = value
        End Set
    End Property


End Class
