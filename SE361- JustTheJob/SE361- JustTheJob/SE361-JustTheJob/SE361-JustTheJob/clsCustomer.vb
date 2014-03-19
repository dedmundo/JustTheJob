'Entity Class
Public Class clsCustomer
    Private strName As String
    Private strAddress As String
    Private strPhone As String
    Private strEmail As String

    Public Sub New()
        strName = ""
        strAddress = ""
        strPhone = ""
        strEmail = ""
    End Sub

    Public Sub New(ByVal name, ByVal address, ByVal phone, ByVal email)
        strName = name
        strAddress = address
        strPhone = phone
        strEmail = email
    End Sub

    Public Property name As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)

            strName = value

        End Set
    End Property

    Public Property address As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)

            strAddress = value
        End Set
    End Property

    Public Property phone As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
                strPhone = value
        End Set
    End Property

    Public Property email As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)

            strEmail = value
        End Set
    End Property
End Class
