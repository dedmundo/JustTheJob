Public Class clsJobListManager
    Private colJobs As New Collection

    Public Sub addJob(ByVal projectName As String, ByVal client As String, ByVal location As String, ByVal startDate As String,
                    ByVal Deadline As String, ByVal Description As String, ByVal projectLead As String, ByVal employee1 As String,
                    ByVal employee2 As String, ByVal employee3 As String, ByVal leadTitle As String, ByVal title1 As String,
                    ByVal title2 As String, ByVal title3 As String)
        Dim objJob As New clsJob

        objJob.projectName = projectName
        objJob.client = client
        objJob.location = location
        objJob.startDate = startDate
        objJob.Deadline = Deadline
        objJob.Description = Description
        objJob.projectLead = projectLead
        objJob.employee1 = employee1
        objJob.employee2 = employee2
        objJob.employee3 = employee3
        objJob.leadTitle = leadTitle
        objJob.title1 = title1
        objJob.title2 = title2
        objJob.title3 = title3



        colJobs.Add(objJob)
    End Sub

End Class
