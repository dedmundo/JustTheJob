Public Class ScheduleChangeForm
    Dim objFileManager As New clsFileManager
    Dim appointmentList As New Collection
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub btnSCBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCBack.Click
        Me.Close()
    End Sub


    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtCAName.Text.Length = 0 Or txtCALocation.Text.Length = 0 Or txtCADate.Text.Length = 0 Or txtCATime.Text.Length = 0 Or txtCALength.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    'Submits the changes made to the appointment to the database

    Private Sub btnSCEdit_Click(sender As Object, e As EventArgs) Handles btnSCEdit.Click
        Dim objCheck As New clsCheck
        Dim fieldsFilled As Boolean = False
        Dim nameCorrect As Boolean = False
        Dim dateCorrect As Boolean = False

        Dim appDate As String
        Dim temp As String
        Dim tempName As String
        Dim tempDate As String
        Dim counter As Integer = 1


        nameCorrect = objCheck.checkName(txtCAName.Text)
        appDate = objCheck.editDate(txtCADate.Text)
        dateCorrect = objCheck.checkDate(appDate)

        fieldsFilled = checkFieldsFilled()
        If fieldsFilled = True And nameCorrect = True And dateCorrect = True Then
            objFileManager.LoadAppointment(appointmentList)

            For Each apt In appointmentList
                temp = apt
                temp = temp.Substring(6)        'Removes beginning <name> tags and gets the date
                tempName = temp.Substring(0, temp.IndexOf("<"))
                temp = temp.Substring(temp.IndexOf("<"))
                'remove <location> tags
                temp = temp.Substring(10)
                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6) 'removes <date> tags and gets the name
                tempDate = temp.Substring(0, temp.IndexOf("<"))
                If (tempName = AppointmentViewForm.lblName.Text) And (tempDate = AppointmentViewForm.lblDate.Text) Then
                    appointmentList.Remove(counter)
                End If
                counter = counter + 1
            Next
            appointmentList.Add("<name>" + txtCAName.Text.Trim + " <location>" + txtCALocation.Text.Trim + " <date>" + appDate.Trim + " <time>" + txtCATime.Text.Trim +
                                     " <length>" + txtCALength.Text.Trim + " <brief>" + txtCABrief.Text.Trim)

            objFileManager.deleteItem(appointmentList, "Appointments.txt")
            ViewScheduleForm.lsvSchedule.Items.Clear()
            ViewScheduleForm.searchDates()

            AppointmentViewForm.Close()
            Me.Close()

        End If
    End Sub
End Class