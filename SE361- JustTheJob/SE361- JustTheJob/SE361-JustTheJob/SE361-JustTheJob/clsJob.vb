'Entity Class
Public Class clsJob
    Private strProjectName As String
    Private strClient As String
    Private strLocation As String
    Private strStartDate As String
    Private strDeadline As String
    Private strDescription As String
    Private strProjectLead As String
    Private strEmployee1 As String = ""
    Private strEmployee2 As String = ""
    Private strEmployee3 As String = ""
    Private strLeadTitle As String
    Private strTitle1 As String = ""
    Private strTitle2 As String = ""
    Private strTitle3 As String = ""



    Public Sub New(ByVal projectName, ByVal client, ByVal location, ByVal startDate,
                    ByVal Deadline, ByVal Description, ByVal projectLead, ByVal employee1,
                    ByVal employee2, ByVal employee3, ByVal leadTitle, ByVal title1, ByVal title2, ByVal title3)
        strProjectName = projectName
        strClient = client
        strLocation = location
        strStartDate = startDate
        strDeadline = Deadline
        strDescription = Description
        strProjectLead = projectLead
        strEmployee1 = employee1
        strEmployee2 = employee2
        strEmployee3 = employee3
        strLeadTitle = leadTitle
        strTitle1 = title1
        strTitle2 = title2
        strTitle3 = title3
    End Sub

    Sub New()
        ' Needed this here because I was getting an error in clsJobListManager and visual studio needed this created. - Eric 
    End Sub

    Public Property projectName As String
        Get
            Return strProjectName
        End Get
        Set(ByVal value As String)
            strProjectName = value
        End Set
    End Property

    Public Property client As String
        Get
            Return strClient
        End Get
        Set(ByVal value As String)
            strClient = value
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

    Public Property startDate As String
        Get
            Return strStartDate
        End Get
        Set(ByVal value As String)
            strStartDate = value
        End Set
    End Property

    Public Property Deadline As String
        Get
            Return strDeadline
        End Get
        Set(ByVal value As String)
            strDeadline = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
        End Set
    End Property

    Public Property projectLead As String
        Get
            Return strProjectLead
        End Get
        Set(ByVal value As String)
            strProjectLead = value
        End Set
    End Property

    Public Property employee1 As String
        Get
            Return strEmployee1
        End Get
        Set(ByVal value As String)
            strEmployee1 = value
        End Set
    End Property
    Public Property employee2 As String
        Get
            Return strEmployee2
        End Get
        Set(ByVal value As String)
            strEmployee2 = value
        End Set
    End Property
    Public Property employee3 As String
        Get
            Return strEmployee3
        End Get
        Set(ByVal value As String)
            strEmployee3 = value
        End Set
    End Property
    Public Property leadTitle As String
        Get
            Return strLeadTitle
        End Get
        Set(ByVal value As String)
            strLeadTitle = value
        End Set
    End Property
    Public Property title1 As String
        Get
            Return strTitle1
        End Get
        Set(ByVal value As String)
            strTitle1 = value
        End Set
    End Property
    Public Property title2 As String
        Get
            Return strTitle2
        End Get
        Set(ByVal value As String)
            strTitle2 = value
        End Set
    End Property
    Public Property title3 As String
        Get
            Return strTitle3
        End Get
        Set(ByVal value As String)
            strTitle3 = value
        End Set
    End Property
End Class
