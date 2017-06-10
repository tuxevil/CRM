Public Class ObjectProperty

    Private mId As Integer
    Private mCode As String
    Private mSysObject As String
    Private mName As String
    Private mField As String
    Private mDisplayName As String
    Private mLen As Integer

    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public Property SysObject() As String
        Get
            Return mSysObject
        End Get
        Set(ByVal value As String)
            mSysObject = value
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

    Public Property Field() As String
        Get
            Return mField
        End Get
        Set(ByVal value As String)
            mField = value
        End Set
    End Property

    Public Property DisplayName() As String
        Get
            Return mDisplayName
        End Get
        Set(ByVal value As String)
            mDisplayName = value
        End Set
    End Property

    Public Property Len() As Integer
        Get
            Return mLen
        End Get
        Set(ByVal value As Integer)
            mLen = value
        End Set
    End Property


End Class
