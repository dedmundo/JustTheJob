Public Class CreditAccountForm
    Dim strType As String
    Dim colOneTimeInvoice As New Collection
    Dim colRegularInvoice As New Collection
    Dim objFileOpener As New clsFileManager
    Dim objFileCloser As New clsFileManager
    Dim strInvoiceId As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strId As String

        objFileOpener.LoadInvoice(colOneTimeInvoice, colRegularInvoice)

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
                lblAmount.Text = inv.subString(0, inv.indexof("<"))
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
                lblAmount.Text = inv.subString(0, inv.indexof("<"))
                lblInvoice.Text = strId
            End If
        Next
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim temp As String
        Dim tempID As String
        Dim tempName As String
        Dim strInvoiceID As String
        Dim payments As New Collection
        Dim tempPay As String
        Dim tempPaid As String
        Dim totalPaid As Double
        Dim tempInvId As String
        Dim counter As Integer

        Dim id As String
        Dim name As String
        Dim type As String
        Dim employee As String
        Dim payment As String
        Dim paymentMethod As String
        Dim complete As String
        Dim amountPaid As String
        Dim week As String

        strInvoiceID = lblInvoice.Text
        totalPaid = 0
        counter = 1
        objFileOpener.loadPayments(payments)
        objFileOpener.LoadInvoice(colOneTimeInvoice, colRegularInvoice)

        If txtCredit.Text <> "" Then
            For Each inv In colOneTimeInvoice
                temp = inv

                temp = temp.Substring(4)                    'Removes beginning <name> tags
                tempID = temp.Substring(0, temp.IndexOf("<"))
                id = tempID

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)
                tempName = temp.Substring(0, temp.IndexOf("<"))
                name = tempName

                If (tempID.Trim = strInvoiceID.Trim) Then
                    'Set contents
                    InvoiceInfoForm.lblIIHeading.Text = tempName
                    InvoiceInfoForm.lblIIName.Text = tempName
                    InvoiceInfoForm.lblID.Text = tempID

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(6)

                    type = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(10)

                    employee = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(9)

                    payment = (CDbl(temp.Substring(0, temp.IndexOf("<"))) - txtCredit.Text)

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(15)

                    paymentMethod = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(10)

                    complete = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(12)

                    For Each pay In payments
                        tempPay = pay
                        tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                        tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                        tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                        tempPaid = tempPay.Substring(0).Trim
                        If tempInvId.Trim = tempID.Trim Then
                            totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                        End If
                    Next

                    amountPaid = totalPaid

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(6)

                    week = temp

                    For Each invoice In colOneTimeInvoice
                        temp = invoice
                        temp = temp.Substring(4)
                        tempID = temp.Substring(0, temp.IndexOf("<"))

                        temp = temp.Substring(temp.IndexOf("<"))
                        temp = temp.Substring(6)                         'Removes beginning <name> tags
                        tempName = temp.Substring(0, temp.IndexOf("<"))

                        If (tempID = InvoiceInfoForm.lblID.Text) Then
                            colOneTimeInvoice.Remove(counter)
                        End If
                        counter = counter + 1
                    Next
                    colOneTimeInvoice.Add("<id>" + id.Trim + " <name>" + name.Trim + " <type>" + type.Trim + " <employee>" + employee.Trim + " <payment>" + payment.Trim +
                                         " <paymentMethod>" + paymentMethod.Trim + " <complete>" + complete.Trim + " <amountPaid>" + amountPaid.Trim + " <week>" + week.Trim)

                    objFileCloser.deleteItem(colOneTimeInvoice, "OneTimeInvoices.txt")
                    MessageBox.Show("The payment for account # " + lblInvoice.Text.Trim + " has been credited", "Account Credited", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Exit Sub
                End If
            Next
            counter = 1
            For Each inv In colRegularInvoice
                temp = inv
                temp = temp.Substring(4)

                tempID = temp.Substring(0, temp.IndexOf("<"))
                id = tempID

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)                    'Removes beginning <name> tags

                tempName = temp.Substring(0, temp.IndexOf("<"))
                name = tempName

                If (tempID.Trim = strInvoiceID.Trim) Then
                    'Set contents
                    InvoiceInfoForm.lblIIHeading.Text = tempName
                    InvoiceInfoForm.lblIIName.Text = tempName
                    InvoiceInfoForm.lblID.Text = tempID

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(6)

                    type = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(10)

                    employee = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(9)

                    payment = (CDbl(temp.Substring(0, temp.IndexOf("<"))) - txtCredit.Text)

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(15)

                    paymentMethod = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(10)

                    complete = temp.Substring(0, temp.IndexOf("<"))

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(12)

                    For Each pay In payments
                        tempPay = pay
                        tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                        tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                        tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                        tempPaid = tempPay.Substring(0).Trim
                        If tempInvId.Trim = tempID.Trim Then
                            totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                        End If
                    Next

                    amountPaid = totalPaid

                    temp = temp.Substring(temp.IndexOf("<"))
                    temp = temp.Substring(6)

                    week = temp

                    For Each invoice In colRegularInvoice
                        temp = invoice
                        temp = temp.Substring(4)
                        tempID = temp.Substring(0, temp.IndexOf("<"))

                        temp = temp.Substring(temp.IndexOf("<"))
                        temp = temp.Substring(6)                         'Removes beginning <name> tags
                        tempName = temp.Substring(0, temp.IndexOf("<"))

                        If (tempID = InvoiceInfoForm.lblID.Text) Then
                            colRegularInvoice.Remove(counter)
                        End If
                        counter = counter + 1
                    Next
                    colRegularInvoice.Add("<id>" + id.Trim + " <name>" + name.Trim + " <type>" + type.Trim + " <employee>" + employee.Trim + " <payment>" + payment.Trim +
                                         " <paymentMethod>" + paymentMethod.Trim + " <complete>" + complete.Trim + " <amountPaid>" + amountPaid.Trim + " <week>" + week.Trim)
                    objFileCloser.deleteItem(colRegularInvoice, "RegularInvoices.txt")
                    MessageBox.Show("The payment for account # " + lblInvoice.Text.Trim + " has been credited", "Account Credited", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Exit Sub
                End If
            Next
            MessageBox.Show("There is no invoice by that name in the database.", "Invoice Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class