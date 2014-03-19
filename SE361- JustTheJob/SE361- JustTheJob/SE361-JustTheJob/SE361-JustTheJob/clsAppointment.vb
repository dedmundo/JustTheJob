Public Class clsAppointment
    Private strName As String
    Private strLocation As String
    Private strDate As String
    Private strTime As String
    Private strLength As String
    Private strBrief As String

    Public Sub New()
        strName = ""
        strLocation = ""
        strDate = ""
        strTime = ""
        strLength = ""
        strBrief = ""
    End Sub

    Public Sub New(ByVal name As String, ByVal location As String, ByVal dateX As String, ByVal time As String, ByVal length As String, ByVal brief As String)
        strName = name
        strLocation = location
        strDate = dateX
        strTime = time
        strLength = length
        strBrief = brief
    End Sub

    Public Property name As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)

            strName = value

        End Set
    End Property

    Public Property location As String
        Get
            Return strLocation
        End Get
        Set(ByVal value As String)

            strLocation = value
        End Set
    End Property

    Public Property dateX As String
        Get
            Return strDate
        End Get
        Set(ByVal value As String)
            strDate = value
        End Set
    End Property

    Public Property time As String
        Get
            Return strTime
        End Get
        Set(ByVal value As String)

            strTime = value
        End Set
    End Property
    Public Property length As String
        Get
            Return strLength
        End Get
        Set(ByVal value As String)

            strLength = value
        End Set
    End Property
    Public Property brief As String
        Get
            Return strBrief
        End Get
        Set(ByVal value As String)

            strBrief = value
        End Set
    End Property
End Class
