Public Class Company

    Private mId As Integer
    Private mTangoId As Integer
    Private mName As String
    Private mDatabase As String
    Private mDBType As String
    Private mUser As String
    Private mPassword As String

    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property TangoId() As Integer
        Get
            Return mTangoId
        End Get
        Set(ByVal value As Integer)
            mTangoId = value
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

    Public Property Database() As String
        Get
            Return mDatabase
        End Get
        Set(ByVal value As String)
            mDatabase = value
        End Set
    End Property

    Public Property DBType() As String
        Get
            Return mDBType
        End Get
        Set(ByVal value As String)
            mDBType = value
        End Set
    End Property
    Public Property User() As String
        Get
            Return mUser
        End Get
        Set(ByVal value As String)
            mUser = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return mPassword
        End Get
        Set(ByVal value As String)
            mPassword = value
        End Set
    End Property


End Class
