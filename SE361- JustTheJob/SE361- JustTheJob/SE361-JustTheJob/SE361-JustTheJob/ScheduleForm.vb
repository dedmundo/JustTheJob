Public Class ScheduleForm

    'Display dialog box to input name of appointment, then show a form that contains that appointment's information along
    'with an option to cancel it
    Private Sub btnSchedChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ScheduleChangeForm.Show()
    End Sub

    'Display the new appointment form
    Private Sub btnNewApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewApp.Click
        NewAppointment.Show()
    End Sub

    'save all changed info
    Private Sub btnSchedSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    'close schedule form
    Private Sub btnSchedBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedBack.Click
        Me.Close()
    End Sub
    'Open form containing the weekly schedule
    Private Sub btnSchedShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedShow.Click
        ViewScheduleForm.Show()
    End Sub
    'Saves Info
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class