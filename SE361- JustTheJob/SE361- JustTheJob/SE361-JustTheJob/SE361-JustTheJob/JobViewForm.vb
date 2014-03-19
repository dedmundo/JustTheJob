Public Class JobViewForm
    Dim objFileManager As New clsFileManager
    Dim jobPendingList As New Collection
    Dim jobCompleteList As New Collection
    Dim jobList As New clsJobListManager

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub JobViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblEmployee1.Text = " " Then
            lblEmployee1.Text = "N/A"
        End If
        If lblEmployee2.Text = " " Then
            lblEmployee2.Text = "N/A"
        End If
        If lblEmployee3.Text = " " Then
            lblEmployee3.Text = "N/A"
        End If
        If lblTitle1.Text = " " Then
            lblTitle1.Text = "N/A"
        End If
        If lblTitle2.Text = " " Then
            lblTitle2.Text = "N/A"
        End If
        If lblTitle3.Text = "" Then
            lblTitle3.Text = "N/A"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        JobEditForm.lblJEName.Text = lblName.Text
        JobEditForm.txtJEName.Text = lblName.Text
        JobEditForm.txtJEClient.Text = lblClient.Text
        JobEditForm.txtJELocation.Text = lblLocation.Text
        JobEditForm.txtJEStart.Text = lblStart.Text
        JobEditForm.txtDeadline.Text = lblDeadline.Text
        JobEditForm.txtJEDescription.Text = lblDescription.Text
        JobEditForm.txtJELead.Text = lblLeadName.Text
        JobEditForm.txtJETitleLead.Text = lblLeadTitle.Text

        If lblEmployee1.Text = "N/A" Then
            JobEditForm.txtJEEmployee1.Text = ""
        Else
            JobEditForm.txtJEEmployee1.Text = lblEmployee1.Text
        End If

        If lblEmployee2.Text = "N/A" Then
            JobEditForm.txtJEEmployee2.Text = ""
        Else
            JobEditForm.txtJEEmployee2.Text = lblEmployee2.Text
        End If

        If lblEmployee3.Text = "N/A" Then
            JobEditForm.txtJEEmployee3.Text = ""
        Else
            JobEditForm.txtJEEmployee3.Text = lblEmployee3.Text
        End If

        If lblTitle1.Text = "N/A" Then
            JobEditForm.txtJETitle1.Text = ""
        Else
            JobEditForm.txtJETitle1.Text = lblTitle1.Text
        End If

        If lblTitle2.Text = "N/A" Then
            JobEditForm.txtJETitle2.Text = ""
        Else
            JobEditForm.txtJETitle2.Text = lblTitle2.Text
        End If

        If lblTitle3.Text = "N/A" Then
            JobEditForm.txtJETitle3.Text = ""
        Else
            JobEditForm.txtJETitle3.Text = lblTitle3.Text
        End If

        'open form
        JobEditForm.Show()

    End Sub

    Private Sub btnChangeStatus_Click(sender As Object, e As EventArgs) Handles btnChangeStatus.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer

        Dim emp1 As String
        Dim emp2 As String
        Dim emp3 As String
        Dim title1 As String
        Dim title2 As String
        Dim title3 As String

        'set these variables to those labels
        emp1 = lblEmployee1.Text
        emp2 = lblEmployee2.Text
        emp3 = lblEmployee3.Text
        title1 = lblTitle1.Text
        title2 = lblTitle2.Text
        title3 = lblTitle3.Text

        'set variables to empty if nothing is entered
        If lblEmployee1.Text = "N/A" Then
            emp1 = ""
        End If
        If lblEmployee2.Text = "N/A" Then
            emp2 = ""
        End If
        If lblEmployee3.Text = "N/A" Then
            emp3 = ""
        End If
        If lblTitle1.Text = "N/A" Then
            title1 = ""
        End If
        If lblTitle2.Text = "N/A" Then
            title2 = ""
        End If
        If lblTitle3.Text = "N/A" Then
            title3 = ""
        End If

        counter = 1
        objFileManager.LoadJob(jobPendingList, jobCompleteList)
        If lblStatus.Text = "Pending" Then
            For Each job In jobPendingList
                temp = job
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))
                'MessageBox.Show(tempName)
                If (tempName = lblName.Text) Then
                    jobCompleteList.Add(jobPendingList.Item(counter))

                    'remove job from pending list
                    jobPendingList.Remove(counter)
                    'MessageBox.Show(jobPendingList.Item(counter))

                    lblStatus.Text = "Completed"
                    Exit For
                End If
                counter = counter + 1
            Next
            

            objFileManager.deleteItem(jobPendingList, "PendingJobs.txt")
            objFileManager.deleteItem(jobCompleteList, "CompletedJobs.txt")
            MessageBox.Show("Status changed to Completed", "Status Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf lblStatus.Text = "Completed" Then
            For Each job2 In jobCompleteList
                temp = job2
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

                If (tempName = lblName.Text) Then
                    jobPendingList.Add(jobCompleteList.Item(counter))

                    'remove job from pending list
                    jobCompleteList.Remove(counter)

                    lblStatus.Text = "Pending"
                    Exit For
                End If
                counter = counter + 1
            Next
            'MessageBox.Show(jobPendingList.Item(counter))
            objFileManager.deleteItem(jobCompleteList, "CompletedJobs.txt")
            objFileManager.deleteItem(jobPendingList, "PendingJobs.txt")
            MessageBox.Show("Status changed to Pending", "Status Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub

    Private Sub btnJEDelete_Click(sender As Object, e As EventArgs) Handles btnJEDelete.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer
        counter = 1

        objFileManager.LoadJob(jobPendingList, jobCompleteList)

        For Each pend In jobPendingList
            temp = pend
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName = lblName.Text) Then
                jobPendingList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(jobPendingList, "PendingJobs.txt")
        counter = 1
        For Each comp In jobCompleteList
            temp = comp
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName = lblName.Text) Then
                jobCompleteList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(jobCompleteList, "CompletedJobs.txt")

        MessageBox.Show("Job Deleted", "Remove Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class