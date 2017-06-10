<Serializable()> Public Class Contact


    Private mCompanyID As Integer
    Private mCustomerCode As String
    Private mId As Integer
    Private mName As String
    Private mSurName As String
    Private mTel As String
    Private mFax As String
    Private mBirthDay As Date
    Private mEmail As String
    Private mAlterEmail As String
    Private mCUIT As String
    Private mHobbies As String
    Private mDetails As String

    Private mArea As ContactArea
    Private mCargo As ContactCargo

    Public Property Id() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property

    Public Property CompanyId() As Integer
        Get
            Return mCompanyID
        End Get
        Set(ByVal value As Integer)
            mCompanyID = value
        End Set
    End Property

    Public Property CustomerCode() As String
        Get
            Return mCustomerCode
        End Get
        Set(ByVal value As String)
            mCustomerCode = value
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

    Public Property Surname() As String
        Get
            Return mSurName
        End Get
        Set(ByVal value As String)
            mSurName = value
        End Set
    End Property

    Public Property Tel() As String
        Get
            Return mTel
        End Get
        Set(ByVal value As String)
            mTel = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return mFax
        End Get
        Set(ByVal value As String)
            mFax = value
        End Set
    End Property

    Public Property Birthday() As Date
        Get
            Return mBirthDay
        End Get
        Set(ByVal value As Date)
            mBirthDay = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
        End Set
    End Property

    Public Property AlterEmail() As String
        Get
            Return mAlterEmail
        End Get
        Set(ByVal value As String)
            mAlterEmail = value
        End Set
    End Property

    Public Property CUIT() As String
        Get
            Return mCUIT
        End Get
        Set(ByVal value As String)
            mCUIT = value
        End Set
    End Property

    Public Property Hobbies() As String
        Get
            Return mHobbies
        End Get
        Set(ByVal value As String)
            mHobbies = value
        End Set
    End Property

    Public Property Details() As String
        Get
            Return mDetails
        End Get
        Set(ByVal value As String)
            mDetails = value
        End Set
    End Property

    Public Property Area() As ContactArea
        Get
            Return mArea
        End Get
        Set(ByVal value As ContactArea)
            mArea = value
        End Set
    End Property

    Public Property Cargo() As ContactCargo
        Get
            Return mCargo
        End Get
        Set(ByVal value As ContactCargo)
            mCargo = value
        End Set
    End Property




    Public Sub New()
        mBirthDay = "01/01/1800"
    End Sub

    Public Sub New(ByVal Customer As String, ByVal Company As Integer)
        mCustomerCode = Customer
        mCompanyID = Company
        mBirthDay = "01/01/1800"
        mArea = New ContactArea
        mCargo = New ContactCargo
    End Sub



    Public Class ContactArea

        Private mID As Integer
        Private mName As String
        Private mDescription As String

        Public Property Id() As Integer
            Get
                Return mID
            End Get
            Set(ByVal value As Integer)
                mID = value
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

        Public Property Description() As String
            Get
                Return mDescription
            End Get
            Set(ByVal value As String)
                mDescription = value
            End Set
        End Property


    End Class



    Public Class ContactCargo

        Private mID As Integer
        Private mName As String
        Private mDescription As String

        Public Property Id() As Integer
            Get
                Return mID
            End Get
            Set(ByVal value As Integer)
                mID = value
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

        Public Property Description() As String
            Get
                Return mDescription
            End Get
            Set(ByVal value As String)
                mDescription = value
            End Set
        End Property


    End Class

End Class
