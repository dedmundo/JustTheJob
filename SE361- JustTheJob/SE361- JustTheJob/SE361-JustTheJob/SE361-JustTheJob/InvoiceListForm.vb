Public Class InvoiceListForm
    Dim objFileManager As New clsFileManager
    Dim OneTimeInvoiceList As New Collection
    Dim RegularInvoiceList As New Collection

    Private Sub radOne_CheckedChanged(sender As Object, e As EventArgs) Handles radOne.CheckedChanged
        objFileManager.LoadInvoice(OneTimeInvoiceList, RegularInvoiceList)

        lstComplete.Items.Clear()
        lstCustomerName.Items.Clear()
        lstID.Items.Clear()
        lstMethod.Items.Clear()
        lstPaid.Items.Clear()
        lstPayment.Items.Clear()

        Dim i As Integer
        Dim counter As Integer
        Dim temp As String
        Dim tempType As String
        Dim tempName As String
        Dim totalPaid As Double
        Dim tempID As String
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String
        Dim payments As New Collection

        objFileManager.loadPayments(payments)

        i = 1
        counter = OneTimeInvoiceList.Count
        While counter > 0
            tempType = OneTimeInvoiceList.Item(i)
            tempType = tempType.Substring(6)                    'Removes beginning <name> tags
            tempName = tempType.Substring(0, tempType.IndexOf("<"))

            tempType = tempType.Substring(tempType.IndexOf("<"))
            tempType = tempType.Substring(6) 'removes <type> tags
            tempType = tempType.Substring(0, tempType.IndexOf("<"))

            'Set contents
            temp = OneTimeInvoiceList.Item(i)

            temp = temp.Substring(4)
            tempID = temp.Substring(0, temp.IndexOf("<"))
            lstID.Items.Add(tempID)

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)
            lstCustomerName.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)

            'Do nothing for type

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)
            'not pulling employees into list anymore
            'lstEmployee.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(9)

            lstPayment.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(15)

            lstMethod.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)

            lstComplete.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(12)

            totalPaid = 0
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

            lstPaid.Items.Add(totalPaid)

            counter = counter - 1
            i = i + 1
        End While
    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged
        objFileManager.LoadInvoice(OneTimeInvoiceList, RegularInvoiceList)

        lstComplete.Items.Clear()
        lstCustomerName.Items.Clear()
        lstID.Items.Clear()
        lstMethod.Items.Clear()
        lstPaid.Items.Clear()
        lstPayment.Items.Clear()

        Dim i As Integer
        Dim counter As Integer
        Dim temp As String
        Dim tempType As String
        Dim tempID As String
        Dim tempName As String
        Dim tempWeek As String
        Dim totalPaid As Double
        Dim tempPay As String
        Dim tempInvID As String
        Dim tempPaid As String
        Dim payments As New Collection

        objFileManager.loadPayments(payments)

            i = 1
        counter = RegularInvoiceList.Count
            While counter > 0
            tempWeek = RegularInvoiceList.Item(i)
            tempWeek = tempWeek.Substring(4)
            tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))

            tempWeek = tempWeek.Substring(6)                    'Removes beginning <name> tags
                tempName = tempWeek.Substring(0, tempWeek.IndexOf("<"))

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(6) 'removes <type> tags
                tempType = tempWeek.Substring(0, tempWeek.IndexOf("<"))

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(10) 'removes <Employee> tags

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(9) 'removes <Payment> tags

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(15) 'removes <paymentMethod> tags

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(10) 'removes <complete> tags

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(12) 'removes <AmountPaid> tags

                tempWeek = tempWeek.Substring(tempWeek.IndexOf("<"))
                tempWeek = tempWeek.Substring(6) 'removes <week> tags
                tempWeek = tempWeek.Substring(0)

            'Set contents
            temp = RegularInvoiceList.Item(i)

            temp = temp.Substring(4)
            tempID = temp.Substring(0, temp.IndexOf("<"))
            lstID.Items.Add(tempID)

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)
            lstCustomerName.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)

            'Do nothing for type

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)

            'not pulling employee anymore
            'lstEmployee.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(9)

            lstPayment.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(15)

            lstMethod.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(10)

            lstComplete.Items.Add(temp.Substring(0, temp.IndexOf("<")))

            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(12)


            totalPaid = 0
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

            lstPaid.Items.Add(totalPaid)

            counter = counter - 1
            i = i + 1
        End While
    End Sub

    Private Sub btnCLBack_Click(sender As Object, e As EventArgs) Handles btnCLBack.Click
        Me.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class