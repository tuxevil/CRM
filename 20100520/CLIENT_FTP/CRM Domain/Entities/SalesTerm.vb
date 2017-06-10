Public Class SalesTerm


    Private mId As Integer
    Private mCode As String
    Private mName As String
    Private mTerms As List(Of Term)


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

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Public Property Terms() As List(Of Term)
        Get
            Return mTerms
        End Get
        Set(ByVal value As List(Of Term))
            mTerms = value
        End Set
    End Property


    Public Sub New()
        mTerms = New List(Of Term)
    End Sub
















    Public Class Term

        Private mToExpire As Integer
        Private mDays As Integer
        Private mQuotes As Integer
        Private mUnit As String
        Private mForm As String
        Private mPorcInt As Double
        Private mPorcAmount As Double

        Public Property ToExpire() As Integer
            Get
                Return mToExpire
            End Get
            Set(ByVal value As Integer)
                mToExpire = value
            End Set
        End Property

        Public Property Days() As Integer
            Get
                Return mDays
            End Get
            Set(ByVal value As Integer)
                mDays = value
            End Set
        End Property

        Public Property Quotes() As Integer
            Get
                Return mQuotes
            End Get
            Set(ByVal value As Integer)
                mQuotes = value
            End Set
        End Property

        Public Property Unit() As String
            Get
                Return mUnit
            End Get
            Set(ByVal value As String)
                mUnit = value
            End Set
        End Property

        Public Property Form() As String
            Get
                Return mForm
            End Get
            Set(ByVal value As String)
                mForm = value
            End Set
        End Property

        Public Property PorcInt() As Double
            Get
                Return mPorcInt
            End Get
            Set(ByVal value As Double)
                mPorcInt = value
            End Set
        End Property

        Public Property PorcAmount() As Double
            Get
                Return mPorcAmount
            End Get
            Set(ByVal value As Double)
                mPorcAmount = value
            End Set
        End Property

    End Class


End Class
