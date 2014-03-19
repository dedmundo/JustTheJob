Imports System.IO
Public Class CustomerForm

    'Display form containing list of Customers. Inside form give option to print list
    Private Sub btnCustList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustList.Click
        CustomerListForm.Show()
    End Sub

    'Open Add New Customer Form
    Private Sub btnCustAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustAdd.Click
        NewCustomerForm.Show()
        NewCustomerForm.txtNCName.Focus()
    End Sub

    'create input box for customer name to search for
    Private Sub btnCustShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustShow.Click
        Dim strCustomerName As String

        Dim objCustomerFile As New clsFileManager
        Dim customerList As New Collection
        Dim temp As String          'temporary string
        Dim tempName As String      'Hold the testing customer name for search function
        objCustomerFile.LoadCustomer(customerList)

        strCustomerName = InputBox("Enter the Customer Name you want to search for.", "Customer Name")

            For Each cust In customerList
                temp = cust
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName.ToLower().Trim = strCustomerName.ToLower().Trim) Then
                'Set contents
                CustomerInfoForm.lblCIHeading.Text = tempName
                CustomerInfoForm.lblCIName.Text = tempName

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                CustomerInfoForm.lblCIAddress.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(7)

                CustomerInfoForm.lblCIPhone.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(7)

                CustomerInfoForm.lblCIEmail.Text = temp.Substring(0)
                CustomerInfoForm.Show()
                Exit Sub
            End If
            Next
            MessageBox.Show("There is no customer by that name in the database.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCustBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustBack.Click
        Me.Close()
    End Sub
End Class