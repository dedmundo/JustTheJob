Public Class ViewScheduleForm
    Dim objAppointmentManager As New clsFileManager

    'close the form
    Private Sub btnVSBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVSBack.Click
        Me.Close()
    End Sub
    'Prints the week's schedule
    Private Sub btnNAPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Close the form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Opens AppointmentView form
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            AppointmentViewForm.lblDate.Text = lsvSchedule.SelectedItems(0).SubItems(0).Text
            AppointmentViewForm.lblName.Text = lsvSchedule.SelectedItems(0).SubItems(1).Text
            AppointmentViewForm.lblLocation.Text = lsvSchedule.SelectedItems(0).SubItems(2).Text
            AppointmentViewForm.lblTime.Text = lsvSchedule.SelectedItems(0).SubItems(3).Text
            AppointmentViewForm.lblLength.Text = lsvSchedule.SelectedItems(0).SubItems(4).Text
            AppointmentViewForm.lblBrief.Text = lsvSchedule.SelectedItems(0).SubItems(5).Text
            AppointmentViewForm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select an appointment from the list to view", "No Appointment Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim strStart As String
        Dim strEnd As String
        strStart = DateTimePicker1.Value
        strStart = strStart.Substring(0, strStart.LastIndexOf("/") + 5)
        lblVSStart.Text = strStart

        strEnd = DateTimePicker1.Value.AddDays(6)
        strEnd = strEnd.Substring(0, strEnd.LastIndexOf("/") + 5)
        lblVSEnd.Text = strEnd
        searchDates()
    End Sub
    Public Function searchDates()
        Dim AppointmentList As New Collection
        Dim objCheck As New clsCheck
        objAppointmentManager.LoadAppointment(AppointmentList)
        Dim i As Integer
        Dim x As Integer = 0
        Dim counter As Integer
        Dim temp As String
        Dim name As String
        Dim loc As String
        Dim appDate As String
        Dim time As String
        Dim length As String
        Dim brief As String
        Dim tempDate As String

        lsvSchedule.Items.Clear()

        i = 1

        counter = AppointmentList.Count
        While counter > 0
            temp = AppointmentList.Item(i)
            temp = temp.Substring(6)
            name = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)
            loc = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)
            appDate = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)
            time = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(8)
            length = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(7)

            brief = temp.Substring(0)
            x = 0
            While x <= 7
                tempDate = DateTimePicker1.Value.AddDays(x)
                tempDate = tempDate.Substring(0, tempDate.LastIndexOf("/") + 5)
                tempDate = objCheck.editDate(tempDate)
                If appDate.Contains(tempDate) Then
                   
                    Dim item = lsvSchedule.Items.Add(appDate)
                    item.SubItems.Add(name)
                    item.SubItems.Add(loc)
                    item.SubItems.Add(time)
                    item.SubItems.Add(length)
                    item.SubItems.Add(brief)

                    Exit While
                End If
                x = x + 1
            End While
            counter = counter - 1
            i = i + 1
        End While
        Return 0
    End Function
End Class