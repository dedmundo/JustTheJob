Public Class CustomerEditForm
    Dim objFileManager As New clsFileManager
    Dim customerList As New Collection

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer = 1

        Dim phoneCorrect As Boolean = False
        Dim nameCorrect As Boolean = False
        Dim fieldsFilled As Boolean = False
        Dim phoneNum As String = txtPhone.Text

        Dim objCheck As New clsCheck

        phoneNum = objCheck.editPhone(phoneNum)
        phoneCorrect = objCheck.checkPhone(phoneNum)
        nameCorrect = objCheck.checkName(txtName.Text)
        fieldsFilled = checkFieldsFilled()

        If phoneCorrect = True And nameCorrect = True And fieldsFilled = True Then
            objFileManager.LoadCustomer(customerList)
            For Each cust In customerList
                temp = cust
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

                If (tempName = CustomerInfoForm.lblCIName.Text) Then
                    customerList.Remove(counter)
                End If
                counter = counter + 1
            Next
            customerList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <phone>" + phoneNum.Trim + " <email>" + txtEmail.Text.Trim)

            objFileManager.deleteItem(customerList, "Customers.txt")

            MessageBox.Show("Customer Info Changed", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CustomerInfoForm.Close()
            Me.Close()
        End If
    End Sub
    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtName.Text.Length = 0 Or txtAddress.Text.Length = 0 Or txtPhone.Text.Length = 0 Or txtEmail.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class