Public Class NewInvoiceForm
    Private strType As String
    Dim invoiceList As New clsInvoiceListManager
    Dim objFileManager As New clsFileManager
    'Closes the form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes the form
    Private Sub btnNIBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNIBack.Click
        Me.Close()
    End Sub
    'Add the invoice to the appropriate database depending on the radio button selection
    Private Sub btnNISubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNISubmit.Click
        Dim fieldsFilled As Boolean = False
        Dim cNameCorrect As Boolean = False 'Customer Name
        Dim eNameCorrect As Boolean = False 'Employee Name
        Dim dateCorrect As Boolean = False
        Dim completeDateCorrect As Boolean = False
        Dim invCompleteDate As String
        Dim invDate As String
        Dim objCheck As New clsCheck

        If radNIRegular.Checked = True Then
            strType = "Regular"
        Else
            strType = "One" 'one time
        End If
        invDate = objCheck.editDate(txtNIWeek.Text)
        dateCorrect = objCheck.checkDate(invDate)
        invCompleteDate = objCheck.editDate(txtNIComplete.Text)
        completeDateCorrect = objCheck.checkDate(invCompleteDate)
        cNameCorrect = objCheck.checkName(txtNIName.Text)
        eNameCorrect = objCheck.checkName(txtNIEmployee.Text)
        fieldsFilled = checkFieldsFilled()

        If cNameCorrect = True And eNameCorrect = True And dateCorrect = True And completeDateCorrect = True And fieldsFilled = True Then
            invoiceList.addInvoice(txtID.Text, strType, txtNIName.Text, txtNIEmployee.Text, CDbl(txtNIPay.Text),
                                   cmbPaymentMethod.Text, invCompleteDate, CDbl(txtNIPaid.Text), invDate)
            objFileManager.SaveInvoice(txtID.Text, strType, txtNIName.Text, txtNIEmployee.Text, txtNIPay.Text,
                                   cmbPaymentMethod.Text, invCompleteDate, txtNIPaid.Text, invDate)

            MessageBox.Show("Invoice Added", "Invoice Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Function checkFieldsFilled() As Boolean
        If txtNIWeek.Text.Length = 0 Or txtNIComplete.Text.Length = 0 Or txtNIEmployee.Text.Length = 0 Or
            txtNIName.Text.Length = 0 Or txtNIPaid.Text.Length = 0 Or txtNIPay.Text.Length = 0 Or
            cmbPaymentMethod.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class