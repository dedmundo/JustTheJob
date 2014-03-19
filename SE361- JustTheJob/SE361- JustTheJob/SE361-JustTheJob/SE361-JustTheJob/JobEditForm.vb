Public Class JobEditForm

    Dim objFileManager As New clsFileManager
    Dim jobPendingList As New Collection
    Dim jobCompletedList As New Collection
    'Prints Job information form
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Closes form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub btnJEBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJEBack.Click
        Me.Close()
    End Sub
    'Deletes the job from the database. Manager action only
    Private Sub btnJEDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer

        Dim objCheck As New clsCheck
        Dim dateStart As String
        Dim dateEnd As String

        Dim dateStartCorrect As Boolean = False
        Dim dateEndCorrect As Boolean = False
        Dim fieldsFilled As Boolean = False

        dateStart = objCheck.editDate(txtJEStart.Text)
        dateStartCorrect = objCheck.checkDate(dateStart)
        dateEnd = objCheck.editDate(txtDeadline.Text)
        dateEndCorrect = objCheck.checkDate(dateEnd)
        fieldsFilled = checkFieldsFilled()
        counter = 1

        If dateStartCorrect = True And dateEndCorrect = True And fieldsFilled = True Then
            objFileManager.LoadJob(jobPendingList, jobCompletedList)
            If JobViewForm.lblStatus.Text = "Pending" Then
                For Each job In jobPendingList
                    temp = job
                    temp = temp.Substring(6)                    'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))

                    If (tempName = JobViewForm.lblName.Text) Then
                        jobPendingList.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                jobPendingList.Add("<name>" + txtJEName.Text.Trim + " <client>" + txtJEClient.Text.Trim + " <location>" + txtJELocation.Text.Trim + " <start>" + dateStart.Trim + " <deadLine>" + dateEnd.Trim + " <description>" + txtJEDescription.Text.Trim + " <lead>" + txtJELead.Text.Trim +
                                   " <employee1>" + txtJEEmployee1.Text.Trim + " <employee2>" + txtJEEmployee2.Text.Trim + " <employee3>" + txtJEEmployee3.Text.Trim + "<leadTitle>" + txtJETitleLead.Text.Trim + " <title1>" + txtJETitle1.Text.Trim + " <title2>" + txtJETitle2.Text.Trim + " <title3>" + txtJETitle3.Text.Trim)

                objFileManager.deleteItem(jobPendingList, "PendingJobs.txt")

                MessageBox.Show("The Job has been edited successfully", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                JobViewForm.Close()
                Me.Close()
            ElseIf JobViewForm.lblStatus.Text = "Completed" Then
                For Each job2 In jobCompletedList
                    temp = job2
                    temp = temp.Substring(6)                    'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))

                    If (tempName = JobViewForm.lblName.Text) Then
                        jobCompletedList.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                jobCompletedList.Add("<name>" + txtJEName.Text.Trim + " <client>" + txtJEClient.Text.Trim + " <location>" + txtJELocation.Text.Trim + " <start>" + dateStart.Trim + " <deadLine>" + dateEnd.Trim + " <description>" + txtJEDescription.Text.Trim + " <lead>" + txtJELead.Text.Trim +
                                   " <employee1>" + txtJEEmployee1.Text.Trim + " <employee2>" + txtJEEmployee2.Text.Trim + " <employee3>" + txtJEEmployee3.Text.Trim + "<leadTitle>" + txtJETitleLead.Text.Trim + " <title1>" + txtJETitle1.Text.Trim + " <title2>" + txtJETitle2.Text.Trim + " <title3>" + txtJETitle3.Text.Trim)

                objFileManager.deleteItem(jobCompletedList, "CompletedJobs.txt")

                MessageBox.Show("The Job has been edited successfully", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                JobViewForm.Close()
                Me.Close()
            End If
        End If
    End Sub
    Private Function checkFieldsFilled() As Boolean
        If txtJEClient.Text = "" Or txtDeadline.Text = "" Or txtJEDescription.Text = "" Or txtJELead.Text = "" Or
            txtJETitleLead.Text = "" Or txtJELocation.Text = "" Or txtJEName.Text = "" Or txtJEStart.Text = "" Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class