'Entity Class
Public Class clsEmployee
    Private strName As String
    Private strAddress As String
    Private strHomePhone As String
    Private strCellPhone As String
    Private strEmail As String
    Private strEmergencyName As String
    Private strEmergencyPhone As String
    Private strPosition As String
    Private strPaytype As String
    Private dblWages As Double

    Public Sub New(ByVal name, ByVal address, ByVal homePhone, ByVal cellPhone, ByVal email,
                   ByVal emergencyName, ByVal emergencyPhone, ByVal position, ByVal paytype, ByVal wages)
        strName = name
        strAddress = address
        strHomePhone = homePhone
        strCellPhone = cellPhone
        strEmail = email
        strEmergencyName = emergencyName
        strEmergencyPhone = emergencyPhone
        strPosition = position
        strPaytype = paytype
        dblWages = wages

    End Sub

    Sub New()
        ' TODO: Complete member initialization 
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

    Public Property homePhone As String
        Get
            Return strHomePhone
        End Get
        Set(ByVal value As String)
            strHomePhone = value
        End Set
    End Property

    Public Property cellPhone As String
        Get
            Return strCellPhone
        End Get
        Set(ByVal value As String)
            strCellPhone = value
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

    Public Property emergencyName As String
        Get
            Return strEmergencyName
        End Get
        Set(ByVal value As String)
            strEmergencyName = value
        End Set
    End Property

    Public Property emergencyPhone As String
        Get
            Return strEmergencyPhone
        End Get
        Set(ByVal value As String)
            strEmergencyPhone = value
        End Set
    End Property

    Public Property position As String
        Get
            Return strPosition
        End Get
        Set(ByVal value As String)
            strPosition = value
        End Set
    End Property

    Public Property paytype As String
        Get
            Return strPaytype
        End Get
        Set(ByVal value As String)
            strPaytype = value
        End Set
    End Property

    Public Property wages As Double
        Get
            Return dblWages
        End Get
        Set(ByVal value As Double)
            dblWages = value
        End Set
    End Property
End Class
