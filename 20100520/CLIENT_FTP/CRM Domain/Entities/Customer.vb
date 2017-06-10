<Serializable()> Public Class Customer

    Private mId As Integer
    Private mCompanyId As Integer
    Private mCode As String
    Private mTgcode As String
    Private mName As String
    Private mLegalName As String
    Private mAdress As String
    Private mDeliveryAdress As String
    Private mZipCode As String
    Private mCity As String
    Private mHours As String
    Private mPhone As String
    Private mFax As String
    Private mMail As String
    Private mWeb As String
    Private mBirthDay As Date
    Private mRegistrationDate As Date
    Private mTgDate As Date
    Private mUnRegistrationDate As Date
    Private mClause As Boolean
    Private mCredit As Double
    Private mDiscountPercent As Double
    Private mCuit As String
    Private mIBNumber As String
    Private mIVACategory As String
    Private mIVACalc As Boolean
    Private mIVADetail As Boolean
    Private mIVAFree As Boolean
    Private mIVAFreePercent As Double
    Private mIVAPlus As Boolean
    Private mIVAExclusionPercent As Double
    Private mIBCalc As Boolean
    Private mIBBCalc As Boolean
    Private mIBBInternalTax As Boolean
    Private mInternalTaxCalc As Boolean
    Private mInternalTaxDetail As Boolean
    Private mInternalTaxPlus As Boolean
    Private mExport As Boolean
    Private mNotes As String

    Private mIBTax As Tax
    Private mIBTaxAditional As Tax
    Private mIBBTax As Tax
    Private mNCTax As Tax
    Private mGroup As CustomerGroup
    Private mState As State
    Private mZone As Zone
    Private mTransport As Transport
    Private mCurrency As Currency
    Private mSalesTerm As SalesTerm
    Private mEmployee As Employee

    Private mAttachments As List(Of Attachment)
    Private mContacts As List(Of Contact)

    Private mPotential As Boolean

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
            Return mCompanyID
        End Get
        Set(ByVal value As Integer)
            mCompanyID = value
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

    Public Property TGCode() As String
        Get
            Return mTgcode
        End Get
        Set(ByVal value As String)
            mTgcode = value
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

    Public Property LegalName() As String
        Get
            Return mLegalName
        End Get
        Set(ByVal value As String)
            mLegalName = value
        End Set
    End Property

    Public Property Adress() As String
        Get
            Return mAdress
        End Get
        Set(ByVal value As String)
            mAdress = value
        End Set
    End Property

    Public Property DeliveryAdress() As String
        Get
            Return mDeliveryAdress
        End Get
        Set(ByVal value As String)
            mDeliveryAdress = value
        End Set
    End Property

    Public Property ZipCode() As String
        Get
            Return mZipCode
        End Get
        Set(ByVal value As String)
            mZipCode = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = value
        End Set
    End Property

    Public Property Hours() As String
        Get
            Return mHours
        End Get
        Set(ByVal value As String)
            mHours = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return mPhone
        End Get
        Set(ByVal value As String)
            mPhone = value
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

    Public Property Mail() As String
        Get
            Return mMail
        End Get
        Set(ByVal value As String)
            mMail = value
        End Set
    End Property

    Public Property Web() As String
        Get
            Return mWeb
        End Get
        Set(ByVal value As String)
            mWeb = value
        End Set
    End Property

    Public Property BirthDay() As Date
        Get
            Return mBirthDay
        End Get
        Set(ByVal value As Date)
            mBirthDay = value
        End Set
    End Property

    Public Property RegistrationDate() As Date
        Get
            Return mRegistrationDate
        End Get
        Set(ByVal value As Date)
            mRegistrationDate = value
        End Set
    End Property

    Public Property TgDate() As Date
        Get
            Return mTgDate
        End Get
        Set(ByVal value As Date)
            mTgDate = value
        End Set
    End Property

    Public Property UnRegistrationDate() As Date
        Get
            Return mUnRegistrationDate
        End Get
        Set(ByVal value As Date)
            mUnRegistrationDate = value
        End Set
    End Property

    Public Property Clause() As Boolean
        Get
            Return mClause
        End Get
        Set(ByVal value As Boolean)
            mClause = value
        End Set
    End Property

    Public Property Credit() As Double
        Get
            Return mCredit
        End Get
        Set(ByVal value As Double)
            mCredit = value
        End Set
    End Property

    Public Property DiscountPercent() As Double
        Get
            Return mDiscountPercent
        End Get
        Set(ByVal value As Double)
            mDiscountPercent = value
        End Set
    End Property

    Public Property CUIT() As String
        Get
            Return mCuit
        End Get
        Set(ByVal value As String)
            mCuit = value
        End Set
    End Property

    Public Property IBNumber() As String
        Get
            Return mIBNumber
        End Get
        Set(ByVal value As String)
            mIBNumber = value
        End Set
    End Property

    Public Property IVACategory() As String
        Get
            Return mIVACategory
        End Get
        Set(ByVal value As String)
            mIVACategory = value
        End Set
    End Property

    Public Property IVACalc() As Boolean
        Get
            Return mIVACalc
        End Get
        Set(ByVal value As Boolean)
            mIVACalc = value
        End Set
    End Property

    Public Property IVADetail() As Boolean
        Get
            Return mIVADetail
        End Get
        Set(ByVal value As Boolean)
            mIVADetail = value
        End Set
    End Property

    Public Property IVAFree() As Boolean
        Get
            Return mIVAFree
        End Get
        Set(ByVal value As Boolean)
            mIVAFree = value
        End Set
    End Property

    Public Property IVAFreePercent() As Double
        Get
            Return mIVAFreePercent
        End Get
        Set(ByVal value As Double)
            mIVAFreePercent = value
        End Set
    End Property

    Public Property IVAPlus() As Boolean
        Get
            Return mIVAPlus
        End Get
        Set(ByVal value As Boolean)
            mIVAPlus = value
        End Set
    End Property

    Public Property IVAExclusionPercent() As Double
        Get
            Return mIVAExclusionPercent
        End Get
        Set(ByVal value As Double)
            mIVAExclusionPercent = value
        End Set
    End Property

    Public Property IBCalc() As Boolean
        Get
            Return mIBCalc
        End Get
        Set(ByVal value As Boolean)
            mIBCalc = value
        End Set
    End Property

    Public Property IBBCalc() As Boolean
        Get
            Return mIBBCalc
        End Get
        Set(ByVal value As Boolean)
            mIBBCalc = value
        End Set
    End Property


    Public Property IBBInternalTax() As Boolean
        Get
            Return mIBBInternalTax
        End Get
        Set(ByVal value As Boolean)
            mIBBInternalTax = value
        End Set
    End Property

    Public Property InternalTaxCalc() As Boolean
        Get
            Return mInternalTaxCalc
        End Get
        Set(ByVal value As Boolean)
            mInternalTaxCalc = value
        End Set
    End Property

    Public Property InternalTaxDetail() As Boolean
        Get
            Return mInternalTaxDetail
        End Get
        Set(ByVal value As Boolean)
            mInternalTaxDetail = value
        End Set
    End Property

    Public Property InternalTaxPlus() As Boolean
        Get
            Return mInternalTaxPlus
        End Get
        Set(ByVal value As Boolean)
            mInternalTaxPlus = value
        End Set
    End Property

    Public Property Export() As Boolean
        Get
            Return mExport
        End Get
        Set(ByVal value As Boolean)
            mExport = value
        End Set
    End Property

    Public Property Notes() As String
        Get
            Return mNotes
        End Get
        Set(ByVal value As String)
            mNotes = value
        End Set
    End Property

    Public Property IBTax() As Tax
        Get
            Return mIBTax
        End Get
        Set(ByVal value As Tax)
            mIBTax = value
        End Set
    End Property

    Public Property IBTaxAditional() As Tax
        Get
            Return mIBTaxAditional
        End Get
        Set(ByVal value As Tax)
            mIBTaxAditional = value
        End Set
    End Property

    Public Property IBBTax() As Tax
        Get
            Return mIBBTax
        End Get
        Set(ByVal value As Tax)
            mIBBTax = value
        End Set
    End Property

    Public Property NCTax() As Tax
        Get
            Return mNCTax
        End Get
        Set(ByVal value As Tax)
            mNCTax = value
        End Set
    End Property

    Public Property Group() As CustomerGroup
        Get
            Return mGroup
        End Get
        Set(ByVal value As CustomerGroup)
            mGroup = value
        End Set
    End Property

    Public Property State() As State
        Get
            Return mState
        End Get
        Set(ByVal value As State)
            mState = value
        End Set
    End Property

    Public Property Zone() As Zone
        Get
            Return mZone
        End Get
        Set(ByVal value As Zone)
            mZone = value
        End Set
    End Property

    Public Property Transport() As Transport
        Get
            Return mTransport
        End Get
        Set(ByVal value As Transport)
            mTransport = value
        End Set
    End Property

    Public Property Currency() As Currency
        Get
            Return mCurrency
        End Get
        Set(ByVal value As Currency)
            mCurrency = value
        End Set
    End Property

    Public Property SalesTerm() As SalesTerm
        Get
            Return mSalesTerm
        End Get
        Set(ByVal value As SalesTerm)
            mSalesTerm = value
        End Set
    End Property

    Public Property Employee() As Employee
        Get
            Return mEmployee
        End Get
        Set(ByVal value As Employee)
            mEmployee = value
        End Set
    End Property

    Public Property Attachments() As List(Of Attachment)
        Get
            Return mAttachments
        End Get
        Set(ByVal value As List(Of Attachment))
            mAttachments = value
        End Set
    End Property

    Public Property Contacts() As List(Of Contact)
        Get
            Return mContacts
        End Get
        Set(ByVal value As List(Of Contact))
            mContacts = value
        End Set
    End Property

    Public Property Potential() As Boolean
        Get
            Return mPotential
        End Get
        Set(ByVal value As Boolean)
            mPotential = value
        End Set
    End Property

    Public Sub New()
        Try
            mIBTax = New Tax
            mIBTaxAditional = New Tax
            mIBBTax = New Tax
            mNCTax = New Tax
            mGroup = New CustomerGroup
            mState = New State
            mZone = New Zone
            mTransport = New Transport
            mCurrency = New Currency
            mSalesTerm = New SalesTerm
            mEmployee = New Employee
            mBirthDay = "01/01/1800"
            mRegistrationDate = "01/01/1800"
            mTgDate = "01/01/1800"
            mUnRegistrationDate = "01/01/1800"
            mCurrency = CurrencyRepository.GetByCode("1")
            mAttachments = New List(Of Attachment)
            mContacts = New List(Of Contact)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub



    Public Class CustomerDeleteReasson

        Private mId As Integer
        Private mName As String
        Private mDescription As String

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
