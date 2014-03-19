Public Class NewJobForm
    Dim jobList As New clsJobListManager
    Dim objFileManager As New clsFileManager

    'Closes Form
    Private Sub btnNJBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNJBack.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Add the information to the database
    Private Sub btnNJSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNJSubmit.Click
        Dim objCheck As New clsCheck
        Dim dateStart As String
        Dim dateEnd As String

        Dim dateStartCorrect As Boolean = False
        Dim dateEndCorrect As Boolean = False
        Dim fieldsFilled As Boolean = False

        dateStart = objCheck.editDate(txtNJStart.Text)
        dateStartCorrect = objCheck.checkDate(dateStart)
        dateEnd = objCheck.editDate(txtNJDeadline.Text)
        dateEndCorrect = objCheck.checkDate(dateEnd)
        fieldsFilled = checkFieldsFilled()



        If dateStartCorrect = True And dateEndCorrect = True And fieldsFilled = True Then
            jobList.addJob(txtNJName.Text, txtNJClient.Text, txtNJLocation.Text, dateStart, dateEnd, txtNJDescription.Text,
                           txtNJLead.Text, txtNJEmployee1.Text, txtNJEmployee2.Text, txtNJEmployee3.Text, txtNJLeadTitle.Text, txtNJTitle1.Text,
                           txtNJTitle2.Text, txtNJTitle3.Text)

            objFileManager.SaveJob(txtNJName.Text, txtNJClient.Text, txtNJLocation.Text, dateStart, dateEnd, txtNJDescription.Text,
                                   txtNJLead.Text, txtNJEmployee1.Text, txtNJEmployee2.Text, txtNJEmployee3.Text, txtNJLeadTitle.Text, txtNJTitle1.Text,
                                   txtNJTitle2.Text, txtNJTitle3.Text)

            MessageBox.Show("A new job has been added to the database.", "Confirmation", MessageBoxButtons.OK)
            txtNJClient.Clear()
            txtNJDeadline.Clear()
            txtNJDescription.Clear()
            txtNJEmployee1.Clear()
            txtNJEmployee2.Clear()
            txtNJEmployee3.Clear()
            txtNJLead.Clear()
            txtNJLeadTitle.Clear()
            txtNJLocation.Clear()
            txtNJName.Clear()
            txtNJStart.Clear()
            txtNJTitle1.Clear()
            txtNJTitle2.Clear()
            txtNJTitle3.Clear()
        End If
    End Sub

    Private Function checkFieldsFilled() As Boolean
        If txtNJClient.Text = "" Or txtNJDeadline.Text = "" Or txtNJDescription.Text = "" Or txtNJLead.Text = "" Or
            txtNJLeadTitle.Text = "" Or txtNJLocation.Text = "" Or txtNJName.Text = "" Or txtNJStart.Text = "" Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class