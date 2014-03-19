Public Class RecordPaymentForm
    Dim strType As String
    Dim colOneTimeInvoice As New Collection
    Dim colRegularInvoice As New Collection
    Dim payments As New Collection
    Dim objFileManager As New clsFileManager

    'Opens dialog box to allow searching database for invoice. If entered invoice doesn't exist, it returns an error message. Otherwise, it 
    'sets all attribute Labels to visible and pulls in the information needed
    'Closes the form
    Private Sub btnRPBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    'Submit payment into invoice
    Private Sub btnRPSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtPaid.Text <> "" Then
            objFileManager.SavePayment(lblInvoice.Text, txtPaid.Text)
            MessageBox.Show("Payment made to invoice #" + lblInvoice.Text, "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please enter an amount paid.", "Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strId As String
        Dim strInvoiceId As String
        Dim amount As Double
        Dim paid As Double
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String
        Dim tempID As String
        Dim totalPaid As Double

        amount = 0
        paid = 0
        totalPaid = 0

        objFileManager.LoadPayments(payments)
        objFileManager.LoadInvoice(colOneTimeInvoice, colRegularInvoice)

        strInvoiceId = InputBox("Enter the Invoice ID you want to search for.", "Invoice ID")
        For Each inv In colOneTimeInvoice
            inv = inv.subString(4)
            strId = inv.subString(0, inv.indexOf("<")).Trim
            inv = inv.subString(inv.indexof("<"))
            inv = inv.substring(6)
            If (strInvoiceId.Trim = strId.Trim) Then
                lblCustomer.Text = inv.substring(0, inv.indexof("<")).Trim
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(6)
                strType = inv.substring(0, inv.indexof("<"))
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(10)
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(9)
                'lblAmount.Text = inv.subString(0, inv.indexof("<"))
                amount = inv.subString(0, inv.indexof("<"))
                inv = inv.subString(inv.indexof(">") + 1)
                inv = inv.subString(inv.indexof(">") + 1)
                inv = inv.subString(inv.indexof(">") + 1)
                paid = inv.subString(0, inv.indexof("<"))
                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID.Trim = strId.Trim Then
                        totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                    End If
                Next
                lblAmount.Text = (amount - totalPaid)
                lblInvoice.Text = strId
            End If
        Next
        For Each inv In colRegularInvoice
            inv = inv.subString(4)
            strId = inv.subString(0, inv.indexOf("<")).Trim
            inv = inv.subString(inv.indexof("<"))
            inv = inv.substring(6)
            If (strInvoiceId.Trim = strId.Trim) Then
                lblCustomer.Text = inv.substring(0, inv.indexof("<")).Trim
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(6)
                strType = inv.substring(0, inv.indexof("<"))
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(10)
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(9)
                'lblAmount.Text = inv.subString(0, inv.indexof("<"))
                amount = inv.subString(0, inv.indexof("<"))
                inv = inv.subString(inv.indexof(">") + 1)
                inv = inv.subString(inv.indexof(">") + 1)
                inv = inv.subString(inv.indexof(">") + 1)
                paid = inv.subString(0, inv.indexof("<"))
                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID.Trim = strId.Trim Then
                        totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                    End If
                Next
                lblAmount.Text = (amount - totalPaid)
                lblInvoice.Text = strId
            End If
        Next
        btnSearch.Enabled = False
    End Sub

    Private Sub txtPaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaid.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If txtPaid.Text <> "" Then
                objFileManager.SavePayment(lblInvoice.Text, txtPaid.Text)
                MessageBox.Show("Payment made to invoice #" + lblInvoice.Text, "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Please enter an amount paid.", "Error", MessageBoxButtons.OK)
            End If
        End If
    End Sub
End Class