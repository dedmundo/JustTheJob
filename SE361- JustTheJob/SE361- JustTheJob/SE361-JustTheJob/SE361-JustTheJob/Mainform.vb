'USERNAME= "Manager" or "Receptionist"
'PASSWORD = "mpass" or "rpass" respectively

Public Class Mainform
    'Closes Program
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'Opens CustomerForm
    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        CustomerForm.Show()
    End Sub
    'Opens ScheduleForm
    Private Sub btnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.Click
        ScheduleForm.Show()
    End Sub
    'Opens EmployeeForm
    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        EmployeesForm.Show()
    End Sub
    'Opens InvoiceForm
    Private Sub btnInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoices.Click
        InvoiceForm.Show()
    End Sub
    'Opens JobForm
    Private Sub btnJobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobs.Click
        JobForm.Show()
    End Sub
    'Opens PaymentForm
    Private Sub btnPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        PaymentForm.Show()
    End Sub
    'Closes Program
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpMainForm.Enabled = False
        grpLogin.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "Manager" And txtPassword.Text = "mpass") Then
            grpMainForm.Enabled = True
            grpLogin.Visible = False
        ElseIf (txtUsername.Text = "Receptionist" And txtPassword.Text = "rpass") Then
            grpMainForm.Enabled = True
            grpLogin.Visible = False
            CustomerInfoForm.btnCIDelete.Visible = False
            EmployeeInfo.btnRemove.Visible = False
            JobViewForm.btnJEDelete.Visible = False
            InvoiceInfoForm.btnIIDelete.Visible = False
            PaymentForm.btnPayCredit.Visible = False
            PaymentForm.btnPayCancel.Visible = False
        Else
            MessageBox.Show("Username/Password combination is invalid. Please try again.", "Invalid Credentials", MessageBoxButtons.OK)
            txtUsername.Clear()
            txtPassword.Clear()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        'if user presses enter, it will automatically login without having to press button

        If (e.KeyCode = Keys.Enter) Then
            If (txtUsername.Text = "Manager" And txtPassword.Text = "mpass") Then
                grpMainForm.Enabled = True
                grpLogin.Visible = False
            ElseIf (txtUsername.Text = "Receptionist" And txtPassword.Text = "rpass") Then
                grpMainForm.Enabled = True
                grpLogin.Visible = False
                CustomerInfoForm.btnCIDelete.Visible = False
                EmployeeInfo.btnRemove.Visible = False
                JobViewForm.btnJEDelete.Visible = False
                InvoiceInfoForm.btnIIDelete.Visible = False
                PaymentForm.btnPayCredit.Visible = False
                PaymentForm.btnPayCancel.Visible = False
            Else
                MessageBox.Show("Username/Password combination is invalid. Please try again.", "Invalid Credentials", MessageBoxButtons.OK)
                txtUsername.Clear()
                txtPassword.Clear()
            End If
        End If
    End Sub
End Class
