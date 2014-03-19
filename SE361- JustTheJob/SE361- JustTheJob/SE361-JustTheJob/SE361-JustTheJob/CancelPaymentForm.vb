Public Class CancelPaymentForm
    Dim strType As String
    Dim colOneTimeInvoice As New Collection
    Dim colRegularInvoice As New Collection
    Dim payments As New Collection
    Dim objFileManager As New clsFileManager

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strId As String
        Dim strInvoiceId As String
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String

        objFileManager.LoadInvoice(colOneTimeInvoice, colRegularInvoice)
        objFileManager.loadPayments(payments)

        strInvoiceId = InputBox("Enter the Invoice ID you want to search for.", "Invoice ID")

        lstPayments.Items.Clear()
        For Each inv In colOneTimeInvoice
            inv = inv.subString(4)
            strId = inv.subString(0, inv.indexOf("<")).Trim
            inv = inv.subString(inv.indexof("<"))
            inv = inv.substring(6)
            If (strInvoiceId.Trim = strId.Trim) Then
                lblInvoice.Text = strInvoiceId
                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID.Trim = strInvoiceId.Trim Then
                        lstPayments.Items.Add(tempPaid)
                    End If
                Next
            End If
        Next
        For Each inv In colRegularInvoice
            inv = inv.subString(4)
            strId = inv.subString(0, inv.indexOf("<")).Trim
            inv = inv.subString(inv.indexof("<"))
            inv = inv.substring(6)
            If (strInvoiceId.Trim = strId.Trim) Then
                lblInvoice.Text = strInvoiceId
                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID.Trim = strInvoiceId.Trim Then
                        lstPayments.Items.Add(tempPaid)
                    End If
                Next
            End If
        Next
        btnSearch.Enabled = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String
        Dim counter As Integer
        Dim gotIt As Boolean
        gotIt = False
        counter = 1

        If lblInvoice.Text <> "" Then
            If lstPayments.SelectedIndex <> -1 Then
                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempPaid.Trim = lstPayments.SelectedItem.Trim And tempInvID.Trim = lblInvoice.Text.Trim And gotIt = False Then
                        payments.Remove(counter)
                        gotIt = True
                        objFileManager.deleteItem(payments, "Payments.txt")
                        MessageBox.Show("The payment for account # " + lblInvoice.Text.Trim + " has been cancelled.", "Payment Cancelled", MessageBoxButtons.OK)
                        Me.Close()
                    End If
                    counter = counter + 1
                Next
            Else
                MessageBox.Show("Please select a Payment", "No Payment Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select an invoice", "No Invoice Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class