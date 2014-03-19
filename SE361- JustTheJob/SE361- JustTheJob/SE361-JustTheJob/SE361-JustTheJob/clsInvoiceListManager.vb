Public Class clsInvoiceListManager
    Private colInvoices As New Collection

    Public Sub addInvoice(ByVal idNumber As String, ByVal type As String, ByVal name As String, ByVal employee As String, ByVal totalPayment As Double,
                ByVal paymentMethod As String, ByVal completionDate As String, ByVal amountPaid As Double, ByVal week As String)
        Dim objInvoice As New clsInvoice

        objInvoice.idNumber = idNumber
        objInvoice.type = type
        objInvoice.name = name
        objInvoice.employee = employee
        objInvoice.totalPayment = totalPayment
        objInvoice.paymentMethod = paymentMethod
        objInvoice.completionDate = completionDate
        objInvoice.amountPaid = amountPaid
        objInvoice.week = week

        colInvoices.Add(objInvoice)
    End Sub

    Public Sub viewType(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.type)
        Next
    End Sub

    Public Sub viewName(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.name)
        Next
    End Sub
    Public Sub viewEmployee(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.employee)
        Next
    End Sub
    Public Sub viewTotalPayment(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.totalPayment)
        Next
    End Sub
    Public Sub viewPaymentMethod(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.paymentMethod)
        Next
    End Sub
    Public Sub viewCompletionDate(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.completionDate)
        Next
    End Sub
    Public Sub viewAmountPaid(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.amountPaid)
        Next
    End Sub
    Public Sub viewWeek(ByRef guiDisplay As ListBox)
        Dim invoice As clsInvoice

        For Each invoice In colInvoices
            guiDisplay.Items.Add(invoice.week)
        Next
    End Sub
End Class

