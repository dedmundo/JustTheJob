Public Class InvoiceEditForm

    Private Sub InvoiceEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblEIType.Equals("Regular") Then
            lblEIWeek.Visible = True
            txtEIWeek.Visible = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer = 1
        Dim objFileManager As New clsFileManager
        Dim OneTimeInvoiceList As New Collection
        Dim RegularInvoiceList As New Collection
        Dim tempID As String

        Dim fieldsFilled As Boolean = False
        Dim cNameCorrect As Boolean = False 'Customer Name
        Dim eNameCorrect As Boolean = False 'Employee Name
        Dim dateCorrect As Boolean = False
        Dim completeDateCorrect As Boolean = False
        Dim invCompleteDate As String
        Dim invDate As String
        Dim objCheck As New clsCheck

        invDate = objCheck.editDate(txtEIWeek.Text)
        dateCorrect = objCheck.checkDate(invDate)
        invCompleteDate = objCheck.editDate(txtEIComplete.Text)
        completeDateCorrect = objCheck.checkDate(invCompleteDate)
        cNameCorrect = objCheck.checkName(txtEIName.Text)
        eNameCorrect = objCheck.checkName(txtEIEmployee.Text)
        fieldsFilled = checkFieldsFilled()
        objFileManager.LoadInvoice(OneTimeInvoiceList, RegularInvoiceList)
        If cNameCorrect = True And eNameCorrect = True And dateCorrect = True And completeDateCorrect = True And fieldsFilled = True Then
            If InvoiceInfoForm.lblIIType.Text.Trim = "One" Then
                For Each inv In OneTimeInvoiceList
                    temp = inv
                    temp = temp.Substring(4)
                    tempID = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(6)                         'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))

                    If (tempID = InvoiceInfoForm.lblID.Text) Then
                        OneTimeInvoiceList.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                OneTimeInvoiceList.Add("<id>" + lblID.Text.Trim + " <name>" + txtEIName.Text.Trim + " <type>" + lblEIType.Text.Trim + " <employee>" + txtEIEmployee.Text.Trim + " <payment>" + txtEIPayment.Text.Trim +
                                         " <paymentMethod>" + cmbEIMethod.Text.Trim + " <complete>" + invCompleteDate.Trim + " <amountPaid>" + txtEIPaid.Text.Trim + " <week>" + invDate)

                objFileManager.deleteItem(OneTimeInvoiceList, "OneTimeInvoices.txt")
            ElseIf InvoiceInfoForm.lblIIType.Text.Trim = "Regular" Then
                For Each inv In RegularInvoiceList
                    temp = inv
                    temp = temp.Substring(4)
                    tempID = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(6)                         'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))

                    If (tempID = InvoiceInfoForm.lblID.Text) Then
                        RegularInvoiceList.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                RegularInvoiceList.Add("<id>" + lblID.Text.Trim + " <name>" + txtEIName.Text.Trim + " <type>" + lblEIType.Text.Trim + " <employee>" + txtEIEmployee.Text.Trim + " <payment>" + txtEIPayment.Text.Trim +
                                         " <paymentMethod>" + cmbEIMethod.Text.Trim + " <complete>" + invCompleteDate.Trim + " <amountPaid>" + txtEIPaid.Text.Trim + " <week>" + invDate.Trim)

                objFileManager.deleteItem(RegularInvoiceList, "RegularInvoices.txt")
            End If

            MessageBox.Show("Invoice Edited Successfully", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InvoiceInfoForm.Close()
            Me.Close()
        End If
    End Sub
    Private Function checkFieldsFilled() As Boolean
        If txtEIWeek.Text.Length = 0 Or txtEIComplete.Text.Length = 0 Or txtEIEmployee.Text.Length = 0 Or
            txtEIName.Text.Length = 0 Or txtEIPaid.Text.Length = 0 Or txtEIPayment.Text.Length = 0 Or
            cmbEIMethod.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class