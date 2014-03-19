Public Class NewCustomerForm
    Dim customerList As New clsCustomerListManager
    Dim objFileManager As New clsFileManager
    'Closes NewCustomerForm
    Private Sub btnNCBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCBack.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Submits customer into database
    Private Sub btnNCSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCSubmit.Click
        Dim phoneCorrect As Boolean = False
        Dim nameCorrect As Boolean = False
        Dim fieldsFilled As Boolean = False
        Dim phoneNum As String = txtNCPhone.Text

        Dim objCheck As New clsCheck

        phoneNum = objCheck.editPhone(phoneNum)
        phoneCorrect = objCheck.checkPhone(phoneNum)
        nameCorrect = objCheck.checkName(txtNCName.Text)
        fieldsFilled = checkFieldsFilled()

        If phoneCorrect = True And nameCorrect = True And fieldsFilled = True Then
            customerList.addCustomer(txtNCName.Text, txtNCAddress.Text, phoneNum, txtNCEmail.Text)

            objFileManager.SaveCustomer(txtNCName.Text, txtNCAddress.Text, phoneNum, txtNCEmail.Text)

            MessageBox.Show("A new customer has been added to the database.", "Confirmation", MessageBoxButtons.OK)
            txtNCName.Clear()
            txtNCAddress.Clear()
            txtNCPhone.Clear()
            txtNCEmail.Clear()
        End If
    End Sub

  
    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtNCName.Text.Length = 0 Or txtNCAddress.Text.Length = 0 Or txtNCPhone.Text.Length = 0 Or txtNCEmail.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


End Class
