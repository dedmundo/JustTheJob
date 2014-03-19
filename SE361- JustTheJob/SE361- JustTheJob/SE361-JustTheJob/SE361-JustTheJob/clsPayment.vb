Public Class clsPayment
    Private strAmountDue As String
    Private strAmountPaid As String
    Private strChange As String

    Public Sub New()
        strAmountDue = ""
        strAmountPaid = ""
        strChange = ""
    End Sub

    Public Sub New(ByVal due, ByVal paid, ByVal change)
        strAmountDue = due
        strAmountPaid = paid
        strChange = change
    End Sub

    Public Property due As String
        Get
            Return strAmountDue
        End Get
        Set(value As String)
            strAmountDue = value
        End Set
    End Property

    Public Property paid As String
        Get
            Return strAmountPaid
        End Get
        Set(value As String)
            strAmountPaid = value
        End Set
    End Property

    Public Property change As String
        Get
            Return strChange
        End Get
        Set(value As String)
            strChange = value
        End Set
    End Property
End Class
