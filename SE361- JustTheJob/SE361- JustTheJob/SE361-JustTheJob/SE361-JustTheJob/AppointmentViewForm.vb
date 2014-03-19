Public Class AppointmentViewForm
    Dim objFileManager As New clsFileManager
    Dim appointmentList As New Collection


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim temp As String
        Dim tempName As String
        Dim tempDate As String
        Dim counter As Integer
        counter = 1

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

            If (tempName = lblName.Text) And (tempDate = lblDate.Text) Then

                appointmentList.Remove(counter)
            End If
            counter = counter + 1
        Next

        objFileManager.deleteItem(appointmentList, "Appointments.txt")
        MessageBox.Show("Appointment Deleted", "Remove Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ViewScheduleForm.lsvSchedule.Items.Clear()
        ViewScheduleForm.searchDates()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ScheduleChangeForm.txtCABrief.Text = lblBrief.Text
        ScheduleChangeForm.txtCADate.Text = lblDate.Text
        ScheduleChangeForm.txtCALength.Text = lblLength.Text
        ScheduleChangeForm.txtCALocation.Text = lblLocation.Text
        ScheduleChangeForm.txtCAName.Text = lblName.Text
        ScheduleChangeForm.txtCATime.Text = lblTime.Text
        ScheduleChangeForm.Show()
    End Sub

    Private Sub btnNABack_Click(sender As Object, e As EventArgs) Handles btnNABack.Click
        Me.Close()
    End Sub
End Class