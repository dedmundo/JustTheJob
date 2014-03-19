Public Class JobListForm
    Dim objJobManager As New clsFileManager
    Dim pendingJobList As New Collection
    Dim completedJobList As New Collection
    'Prints list of jobs

    'Closes JobListForm
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    'Toggle Completed Jobs Visibility
    Private Sub CompletedJobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletedJobsToolStripMenuItem.Click
        gbJLCompleted.Visible = True
        gbJLPending.Visible = False
        Me.Height = 427
        btnJLBack.SetBounds(704, 355, 103, 23)

    End Sub
    'Toggle Pending Jobs Visibility
    Private Sub PendingJobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingJobsToolStripMenuItem.Click
        gbJLCompleted.Visible = False
        gbJLPending.Visible = True
        gbJLPending.SetBounds(13, 65, 809, 269)
        Me.Height = 427
        btnJLBack.SetBounds(704, 355, 103, 23)
    End Sub
    'Close Form
    Private Sub btnJLBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJLBack.Click
        Me.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub JobListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objJobManager.LoadJob(pendingJobList, completedJobList)

        Dim i As Integer
        Dim counter As Integer
        Dim temp As String
        i = 1
        counter = pendingJobList.Count
        While counter > 0
            temp = pendingJobList.Item(i)
            'pulls name
            temp = temp.Substring(6)
            lstPendingName.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'pulls client
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(8)
            lstPendingClient.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trash
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls start date
            temp = temp.Substring(7)
            lstPendingStart.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'pulls deadline
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)
            lstPendingDeadline.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trash
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(13)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls lead
            temp = temp.Substring(6)
            lstPendingLead.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            counter = counter - 1
            i = i + 1
        End While

        i = 1
        counter = completedJobList.Count
        While counter > 0
            temp = completedJobList.Item(i)
            'pulls name
            temp = temp.Substring(6)
            lstCompletedName.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'pulls client
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(8)
            lstCompletedClient.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trash
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls start date
            temp = temp.Substring(7)
            lstCompletedStart.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'pulls deadline
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)
            lstCompletedDeadline.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trash
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(13)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls lead
            temp = temp.Substring(6)
            lstCompletedLead.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            counter = counter - 1
            i = i + 1
        End While
    End Sub

    Private Sub AllJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllJobsToolStripMenuItem.Click
        gbJLCompleted.Visible = True
        gbJLPending.Visible = True
        gbJLPending.SetBounds(13, 340, 809, 269)
        Me.Height = 707
        btnJLBack.SetBounds(704, 624, 103, 23)
    End Sub
End Class