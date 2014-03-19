Public Class clsInvoice

    Private strType As String
    Private strName As String
    Private strEmployee As String
    Private dblTotalPayment As Double
    Private strPaymentMethod As String
    Private strCompletionDate As String
    Private dblAmountPaid As Double
    Private strWeek As String
    Private strIdNumber As String


    Public Sub New(ByVal idNumber, ByVal type, ByVal name, ByVal employee, ByVal totalPayment,
                    ByVal paymentMethod, ByVal completionDate, ByVal amountPaid)

        strIdNumber = idNumber
        strType = type
        strName = name
        strEmployee = employee
        dblTotalPayment = totalPayment
        strPaymentMethod = paymentMethod
        strCompletionDate = completionDate
        dblAmountPaid = amountPaid

    End Sub

    Sub New()

    End Sub

    Public Property type As String
        Get
            Return strType
        End Get
        Set(ByVal value As String)
            strType = value
        End Set
    End Property

    Public Property name As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    Public Property employee As String
        Get
            Return strEmployee
        End Get
        Set(ByVal value As String)
            strEmployee = value
        End Set
    End Property

    Public Property totalPayment As Double
        Get
            Return dblTotalPayment
        End Get
        Set(ByVal value As Double)
            dblTotalPayment = value
        End Set
    End Property

    Public Property paymentMethod As String
        Get
            Return strPaymentMethod
        End Get
        Set(ByVal value As String)
            strPaymentMethod = value
        End Set
    End Property

    Public Property completionDate As String
        Get
            Return strCompletionDate
        End Get
        Set(ByVal value As String)
            strCompletionDate = value
        End Set
    End Property

    Public Property amountPaid As Double
        Get
            Return dblAmountPaid
        End Get
        Set(ByVal value As Double)
            dblAmountPaid = value
        End Set
    End Property
    Public Property week As String
        Get
            Return strWeek
        End Get
        Set(ByVal value As String)
            strWeek = value
        End Set
    End Property

    Public Property idNumber As String
        Get
            Return strIdNumber
        End Get
        Set(ByVal value As String)
            strIdNumber = value
        End Set
    End Property
End Class

