Public Class User

    Private mId As Integer
    Private mTangoId As Integer
    Private mNickName As String
    Private mFullName As String
    Private mMail As String

    Private mProfile As Profile

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

    Public Property Mail() As String
        Get
            Return mMail
        End Get
        Set(ByVal value As String)
            mMail = value
        End Set
    End Property

    Public Property NickName() As String
        Get
            Return mNickName
        End Get
        Set(ByVal value As String)
            mNickName = value
        End Set
    End Property

    Public Property FullName() As String
        Get
            Return mFullName
        End Get
        Set(ByVal value As String)
            mFullName = value
        End Set
    End Property

    Public Property Profile() As Profile
        Get
            Return mProfile
        End Get
        Set(ByVal value As Profile)
            mProfile = value
        End Set
    End Property

End Class
