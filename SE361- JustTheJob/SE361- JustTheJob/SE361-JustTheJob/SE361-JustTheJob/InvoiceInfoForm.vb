Public Class InvoiceInfoForm
    Dim objFileManager As New clsFileManager
    Dim OneTimeInvoiceList As New Collection
    Dim RegularInvoiceList As New Collection
    'Closes the form
    Private Sub btnSIBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIIBack.Click
        Me.Close()
    End Sub
    'Closes the form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnSIDelete_Click(sender As Object, e As EventArgs) Handles btnIIDelete.Click
        Dim temp As String
        Dim tempName As String
        Dim tempID As String
        Dim counter As Integer
        counter = 1

        objFileManager.LoadInvoice(OneTimeInvoiceList, RegularInvoiceList)

        For Each inv In OneTimeInvoiceList
            temp = inv
            temp = temp.Substring(4)

            tempID = temp.Substring(0, temp.IndexOf("<"))
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempID = lblID.Text) Then
                OneTimeInvoiceList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(OneTimeInvoiceList, "OneTimeInvoices.txt")
        counter = 1

        For Each inv In RegularInvoiceList
            temp = inv
            temp = temp.Substring(4)

            tempID = temp.Substring(0, temp.IndexOf("<"))
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempID = lblID.Text) Then
                RegularInvoiceList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(RegularInvoiceList, "RegularInvoices.txt")
        MessageBox.Show("Invoice Deleted Successfully", "Invoice Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnSIEdit_Click(sender As Object, e As EventArgs) Handles btnIIEdit.Click
        InvoiceEditForm.lblID.Text = lblID.Text
        InvoiceEditForm.lblEIType.Text = lblIIType.Text
        InvoiceEditForm.txtEIWeek.Text = lblIIWeek.Text
        InvoiceEditForm.txtEIName.Text = lblIIName.Text
        InvoiceEditForm.txtEIEmployee.Text = lblIIEmployee.Text
        InvoiceEditForm.txtEIPayment.Text = lblIIPayment.Text
        InvoiceEditForm.txtEIPaid.Text = lblIIAmountPaid.Text
        InvoiceEditForm.cmbEIMethod.Text = lblIIMethod.Text
        InvoiceEditForm.txtEIComplete.Text = lblIICompleteDate.Text

        InvoiceEditForm.Show()
    End Sub
End Class