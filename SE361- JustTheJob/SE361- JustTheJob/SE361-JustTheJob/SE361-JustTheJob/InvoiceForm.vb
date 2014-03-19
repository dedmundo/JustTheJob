Public Class InvoiceForm
    'Opens AddNew 1-Time Invoice Form
    Private Sub btnNew1TInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew1TInvoice.Click
        NewInvoiceForm.Show()
        NewInvoiceForm.radNIOneTime.Checked = True
        lblStatus.Visible = False
        lblOTShow.Visible = False
    End Sub
    'create input box to search for invoice name
    Private Sub btnInv1TShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv1TShow.Click
        Dim objInvoiceFile As New clsFileManager
        Dim OneTimeInvoiceList As New Collection
        Dim RegularInvoiceList As New Collection
        Dim payments As New Collection
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String
        Dim totalPaid As Double
        Dim temp As String          'temporary string
        Dim tempID As String
        Dim tempName As String 'Hold the testing customer name for search function
        Dim strInvoiceID As String
        objInvoiceFile.LoadInvoice(OneTimeInvoiceList, RegularInvoiceList)
        objInvoiceFile.loadPayments(payments)
        totalPaid = 0

        strInvoiceID = InputBox("Enter the Invoice ID you want to search for.", "Invoice ID")

        For Each inv In OneTimeInvoiceList
            temp = inv

            temp = temp.Substring(4)                    'Removes beginning <name> tags
            tempID = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempID.Trim = strInvoiceID.Trim) Then
                'Set contents
                InvoiceInfoForm.lblIIHeading.Text = tempName
                InvoiceInfoForm.lblIIName.Text = tempName
                InvoiceInfoForm.lblID.Text = tempID

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                InvoiceInfoForm.lblIIType.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                InvoiceInfoForm.lblIIEmployee.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                InvoiceInfoForm.lblIIPayment.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(15)

                InvoiceInfoForm.lblIIMethod.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                InvoiceInfoForm.lblIICompleteDate.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(12)

                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID = tempID Then
                        totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                    End If
                Next

                InvoiceInfoForm.lblIIAmountPaid.Text = totalPaid

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                InvoiceInfoForm.lblIIWeek.Text = temp
                InvoiceInfoForm.Show()
                Exit Sub
            End If
        Next
        For Each inv In RegularInvoiceList
            temp = inv
            temp = temp.Substring(4)

            tempID = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)                    'Removes beginning <name> tags

            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempID.Trim = strInvoiceID.Trim) Then
                'Set contents
                InvoiceInfoForm.lblIIHeading.Text = tempName
                InvoiceInfoForm.lblIIName.Text = tempName
                InvoiceInfoForm.lblID.Text = tempID

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                InvoiceInfoForm.lblIIType.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                InvoiceInfoForm.lblIIEmployee.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                InvoiceInfoForm.lblIIPayment.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(15)

                InvoiceInfoForm.lblIIMethod.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                InvoiceInfoForm.lblIICompleteDate.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(12)

                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID = tempID Then
                        totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                    End If
                Next

                InvoiceInfoForm.lblIIAmountPaid.Text = totalPaid

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                InvoiceInfoForm.lblIIWeek.Text = temp
                InvoiceInfoForm.Show()
                Exit Sub
            End If
        Next
        MessageBox.Show("There is no invoice by that name in the database.", "Invoice Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    'search database based on info entered in input box
    Private Sub btnInv1TStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv1TStatus.Click
        Dim objInvoiceFile As New clsFileManager
        Dim OneTimeInvoiceList As New Collection
        Dim RegularInvoiceList As New Collection
        Dim payments As New Collection
        Dim temp As String          'temporary string
        Dim tempName As String      'Hold the testing customer name for search function
        Dim dblAmountPaid As Double
        Dim dblPayment As Double
        Dim strInvoiceID As String
        Dim tempID As String
        Dim totalPaid As Double
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String

        objInvoiceFile.LoadInvoice(OneTimeInvoiceList, RegularInvoiceList)
        objInvoiceFile.loadPayments(payments)

        strInvoiceID = InputBox("Enter the Invoice ID number you want to search for.", "Invoice ID")

        lblStatus.Visible = True
        lblOTShow.Visible = True

        For Each inv In OneTimeInvoiceList
            temp = inv
            temp = temp.Substring(4)
            tempID = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempID.ToLower().Trim = strInvoiceID.Trim) Then

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                dblPayment = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(15)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(12)

                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID = tempID Then
                        totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                    End If
                Next
                dblAmountPaid = totalPaid

                If dblPayment - dblAmountPaid <= 0 Then
                    lblOTShow.Text = "Paid"
                Else
                    lblOTShow.Text = "Not Paid"
                End If

                Exit Sub
            End If
        Next
        For Each inv In RegularInvoiceList
            temp = inv
            temp = temp.Substring(4)
            tempID = temp.Substring(0, temp.IndexOf("<"))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempID.Trim = strInvoiceID.Trim) Then

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                dblPayment = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(15)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(12)

                For Each pay In payments
                    tempPay = pay
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempInvID = tempPay.Substring(0, tempPay.IndexOf("<"))
                    tempPay = tempPay.Substring(tempPay.IndexOf(">") + 1)
                    tempPaid = tempPay.Substring(0).Trim
                    If tempInvID = tempID Then
                        totalPaid = CDbl(totalPaid) + CDbl(tempPaid)
                    End If
                Next
                dblAmountPaid = totalPaid

                If dblPayment - dblAmountPaid = 0 Then
                    lblOTShow.Text = "Paid"
                Else
                    lblOTShow.Text = "Not Paid"
                End If

                Exit Sub
            End If
        Next
        MessageBox.Show("There is no invoice by that ID in the database.", "Invoice Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Closes InvoiceForm
    Private Sub btnInvBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvBack.Click
        Me.Close()
    End Sub

    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnInvShowAll_Click(sender As Object, e As EventArgs) Handles btnInvShowAll.Click
        InvoiceListForm.Show()
    End Sub
End Class