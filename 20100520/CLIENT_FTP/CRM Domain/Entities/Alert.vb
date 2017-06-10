Public Class Alert

    Private mId As Integer
    Private mCompanyId As Integer
    Private mUser As User
    Private mProfile As Profile
    Private mSubject As String
    Private mDetail As String
    Private mInitdate As Date
    Private mExecuteDate As Date
    Private mActive As Boolean
    Private mWaitMinutes As Integer
    Private mTimeType As TimeType


    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property CompanyId() As Integer
        Get
            Return mCompanyId
        End Get
        Set(ByVal value As Integer)
            mCompanyId = value
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

    Public Property User() As User
        Get
            Return mUser
        End Get
        Set(ByVal value As User)
            mUser = value
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return mSubject
        End Get
        Set(ByVal value As String)
            mSubject = value
        End Set
    End Property

    Public Property Detail() As String
        Get
            Return mDetail
        End Get
        Set(ByVal value As String)
            mDetail = value
        End Set
    End Property

    Public Property Initdate() As Date
        Get
            Return mInitdate
        End Get
        Set(ByVal value As Date)
            mInitdate = value
        End Set
    End Property

    Public Property ExecuteDate() As Date
        Get
            Return Format(mExecuteDate, "dd/MM/yyyy")
        End Get
        Set(ByVal value As Date)
            mExecuteDate = value
        End Set
    End Property

    Public Property Active() As Boolean
        Get
            Return mActive
        End Get
        Set(ByVal value As Boolean)
            mActive = value
        End Set
    End Property

    Public Property WaitMinutes() As Boolean
        Get
            Return mWaitMinutes
        End Get
        Set(ByVal value As Boolean)
            mWaitMinutes = value
        End Set
    End Property


    Public Sub New()
        mInitdate = "01/01/1800"
    End Sub




    Public Class TimeType
        Private mId As Integer
        Private mName As String
        Private mMinutes As Integer

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

        Public Property Minutes() As Integer
            Get
                Return mMinutes
            End Get
            Set(ByVal value As Integer)
                mMinutes = value
            End Set
        End Property

    End Class

End Class
