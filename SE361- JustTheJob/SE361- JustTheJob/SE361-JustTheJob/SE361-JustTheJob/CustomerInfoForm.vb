Public Class CustomerInfoForm
    Dim objFileManager As New clsFileManager
    Dim customerList As New Collection
   
    'Closes form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCIBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCIBack.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        CustomerEditForm.txtName.Text = lblCIName.Text
        CustomerEditForm.txtAddress.Text = lblCIAddress.Text
        CustomerEditForm.txtPhone.Text = lblCIPhone.Text
        CustomerEditForm.txtEmail.Text = lblCIEmail.Text

        CustomerEditForm.Show()
    End Sub
    'Deletes Customer from database. Manager action only. (prompt verification)
    Private Sub btnCIDelete_Click_1(sender As Object, e As EventArgs) Handles btnCIDelete.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer
        counter = 1

        objFileManager.LoadCustomer(customerList)

        For Each cust In customerList
            temp = cust
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName = lblCIName.Text) Then
                customerList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(customerList, "Customers.txt")
        MessageBox.Show("Customer Deleted", "Remove Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class