Public Class clsPaymentListManager
    Private colPayments As New Collection

    Public Sub addPayment(ByVal due As String, ByVal paid As String, ByVal change As String)
        Dim objPayment As New clsPayment

        objPayment.due = due
        objPayment.paid = paid
        objPayment.change = change

        colPayments.Add(objPayment)
    End Sub
End Class