Public Class PaymentForm
    'Credits a payment. Prompts verification that user is manager before proceeding
    Private Sub btnPayCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayCredit.Click
        CreditAccountForm.Show()
    End Sub
    'Opens a dialog box to search for invoice. Returns an error message if the invoice doesn't exist Otherwise, it removes the payment from the invoice
    '. Manager action only
    Private Sub btnPayCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayCancel.Click
        CancelPaymentForm.Show()
    End Sub
    'opens form to record payment. Form will contain information on the invoice as well as the payment amount
    Private Sub btnPayRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayRecord.Click
        RecordPaymentForm.Show()
    End Sub
    'Prints payment receipt

    Private Sub btnPayBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayBack.Click
        Me.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class