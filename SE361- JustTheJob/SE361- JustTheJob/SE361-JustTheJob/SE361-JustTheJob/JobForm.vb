Public Class JobForm
    'Opens add new Job Form
    Private Sub btnNewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewJob.Click
        NewJobForm.Show()
        NewJobForm.txtNJName.Focus()
    End Sub
    'Opens form containing list of all jobs
    Private Sub btnJobAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobAll.Click
        JobListForm.Show()
        JobListForm.gbJLCompleted.Visible = True
        JobListForm.gbJLPending.Visible = True
    End Sub

    'create input box to search for Job
    Private Sub btnJobStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobStatus.Click
        Dim objJobFile As New clsFileManager
        Dim jobPendingList As New Collection
        Dim jobCompleteList As New Collection
        Dim temp As String          'temporary string
        Dim tempName As String      'Hold the testing customer name for search function
        Dim strJobName As String

        objJobFile.LoadJob(jobPendingList, jobCompleteList)

        strJobName = InputBox("Enter the Job Name you want to search for.", "Job Name")

            For Each job In jobPendingList
                temp = job
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName.ToLower().Trim = strJobName.ToLower().Trim) Then
                'Set Contents
                JobViewForm.lblHeading.Text = tempName
                JobViewForm.lblName.Text = tempName

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblClient.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)
                JobViewForm.lblLocation.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(7)
                JobViewForm.lblStart.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)
                JobViewForm.lblDeadline.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(13)
                JobViewForm.lblDescription.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)
                JobViewForm.lblLeadName.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblEmployee1.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblEmployee2.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblEmployee3.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblLeadTitle.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblTitle1.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblTitle2.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblTitle3.Text = temp.Substring(0)

                JobViewForm.lblStatus.Text = "Pending"

                'open form
                JobViewForm.Show()
                Exit Sub                'end sub, we found the match
            End If
        Next

        For Each job In jobCompleteList
            temp = job
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName.ToLower().Trim = strJobName.ToLower().Trim) Then
                'Set Contents
                JobViewForm.lblHeading.Text = tempName
                JobViewForm.lblName.Text = tempName

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblClient.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)
                JobViewForm.lblLocation.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(7)
                JobViewForm.lblStart.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)
                JobViewForm.lblDeadline.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(13)
                JobViewForm.lblDescription.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)
                JobViewForm.lblLeadName.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblEmployee1.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblEmployee2.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblEmployee3.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(11)
                JobViewForm.lblLeadTitle.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblTitle1.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblTitle2.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)
                JobViewForm.lblTitle3.Text = temp.Substring(0)

                JobViewForm.lblStatus.Text = "Completed"

                'open form
                JobViewForm.Show()
                Exit Sub                'end sub, we found the match
            End If
        Next
            MessageBox.Show("There is no job by that name in the database.", "Job Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Closes JobForm
    Private Sub btnJobBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobBack.Click
        Me.Close()
    End Sub

    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
End Class