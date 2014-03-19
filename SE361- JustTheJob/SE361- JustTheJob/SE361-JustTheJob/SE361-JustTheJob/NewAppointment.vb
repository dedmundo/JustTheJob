Public Class NewAppointment
    Dim appointmentList As New clsAppointmentListManager
    Dim objFileManager As New clsFileManager
    'Close Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Close Form
    Private Sub btnNABack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNABack.Click
        Me.Close()
    End Sub
    'Adds the Appointment to the Manager's Schedule
    Private Sub btnNASubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNASubmit.Click
        Dim objCheck As New clsCheck
        Dim fieldsFilled As Boolean = False
        Dim nameCorrect As Boolean = False
        Dim dateCorrect As Boolean = False

        Dim appDate As String

        nameCorrect = objCheck.checkName(txtNAName.Text)
        appDate = objCheck.editDate(txtNADate.Text)
        dateCorrect = objCheck.checkDate(appDate)

        fieldsFilled = checkFieldsFilled()
        If fieldsFilled = True And nameCorrect = True And dateCorrect = True Then
            appointmentList.addAppointment(txtNAName.Text, txtNALocation.Text, appDate, txtNAStart.Text, txtNALength.Text, txtNABrief.Text)
            objFileManager.SaveAppointment(txtNAName.Text, txtNALocation.Text, appDate, txtNAStart.Text, txtNALength.Text, txtNABrief.Text)
            Me.Close()
        End If

    End Sub

    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtNAName.Text.Length = 0 Or txtNALocation.Text.Length = 0 Or txtNADate.Text.Length = 0 Or txtNAStart.Text.Length = 0 Or txtNALength.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

End Class