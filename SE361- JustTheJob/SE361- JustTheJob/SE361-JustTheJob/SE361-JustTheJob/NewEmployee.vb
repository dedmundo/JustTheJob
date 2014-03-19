'Author: Devin Edmundowicz
Public Class NewEmployee
    Dim employeeList As New clsEmployeeListManager
    Dim objFileManager As New clsFileManager
    'Closes New Employee Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'set lblNEPay to "Hourly rate:" & set txtNECommWage, lblCommission, and txtNECommission to visible
    Private Sub radNECommission_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNECommission.CheckedChanged
        If radNECommission.Checked = True Then
            txtNECommWages.Visible = True
            lblNEPay.Text = "Commission:"
            lblCommWages.Visible = True
            lblSalaryWages.Visible = False
            lblHourlyWages.Visible = False
            txtNEHourly.Visible = False
            txtNESalary.Visible = False
        End If
    End Sub
    'set lblNEPay to "Hourly rate:" & set txtNEHourly to visible
    Private Sub radNEHourly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNEHourly.CheckedChanged
        If radNEHourly.Checked = True Then
            txtNECommWages.Visible = False
            txtNEHourly.Visible = True
            lblHourlyWages.Visible = True
            lblCommWages.Visible = False
            lblSalaryWages.Visible = False
            txtNEHourly.Focus()
            txtNESalary.Visible = False
            lblNEPay.Text = "Hourly rate:"
        End If
    End Sub

    Private Sub radNESalary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNESalary.CheckedChanged
        If radNESalary.Checked = True Then
            txtNECommWages.Visible = False
            lblCommWages.Visible = False
            lblHourlyWages.Visible = False
            lblSalaryWages.Visible = True
            txtNEHourly.Visible = False
            txtNESalary.Visible = True
            txtNESalary.Focus()
            lblNEPay.Text = "Salary:"
        End If

    End Sub

    Private Sub btnNEBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEBack.Click
        Me.Close()
    End Sub

    Private Sub btnNESubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNESubmit.Click
        'we also need to calculate commission, as it's using two data fields
        Dim payType As String = ""
        Dim pay As String = ""
        Dim employeeNameCorrect As Boolean = False 'Employee Name
        Dim homePhoneCorrect As Boolean = False 'Home Phone
        Dim cellPhoneCorrect As Boolean = False 'Cell Phone
        Dim emPhoneCorrect As Boolean = False 'Emergency Contact Phone Number
        Dim emNameCorrect As Boolean = False 'Emergency Contact Name
        Dim fieldsFilled As Boolean = False
        'Phone Numbers
        Dim emPhone As String
        Dim homePhone As String
        Dim cellPhone As String

        Dim objCheck As New clsCheck

        employeeNameCorrect = objCheck.checkName(txtNEName.Text)
        emNameCorrect = objCheck.checkName(txtNENameEM.Text)

        emPhone = objCheck.editPhone(txtNEPhoneEM.Text)
        emPhoneCorrect = objCheck.checkPhone(emPhone)
        homePhone = objCheck.editPhone(txtNEPhone.Text)
        homePhoneCorrect = objCheck.checkPhone(homePhone)
        cellPhone = objCheck.editPhone(txtNECell.Text)
        cellPhoneCorrect = objCheck.checkPhone(cellPhone)
        fieldsFilled = checkFieldsFilled()

        If employeeNameCorrect = True And homePhoneCorrect = True And cellPhoneCorrect = True And emPhoneCorrect = True And
            emNameCorrect = True And fieldsFilled = True Then
            If radNEHourly.Checked = True Then
                employeeList.addEmployee(txtNEName.Text, txtNEAddress.Text, homePhone, cellPhone, txtNEEmail.Text, txtNENameEM.Text,
                                     emPhone, txtNEPosition.Text, "Hourly", txtNEHourly.Text)
                payType = "Hourly"
                pay = txtNEHourly.Text
            ElseIf radNECommission.Checked = True Then
                employeeList.addEmployee(txtNEName.Text, txtNEAddress.Text, homePhone, cellPhone, txtNEEmail.Text, txtNENameEM.Text,
                                    emPhone, txtNEPosition.Text, "Commission", txtNECommWages.Text)
                payType = "Commission"


            ElseIf radNESalary.Checked = True Then
                employeeList.addEmployee(txtNEName.Text, txtNEAddress.Text, homePhone, cellPhone, txtNEEmail.Text, txtNENameEM.Text,
                                    emPhone, txtNEPosition.Text, "Salary", txtNESalary.Text)
                payType = "Salary"
                pay = txtNESalary.Text
            End If

            objFileManager.SaveEmployee(txtNEName.Text, txtNEAddress.Text, homePhone, cellPhone, txtNEEmail.Text, txtNENameEM.Text,
                                      emPhone, txtNEPosition.Text, payType, "$" + pay)

            MessageBox.Show("A new employee has been added to the database.", "Confirmation", MessageBoxButtons.OK)

            'Clear Fields
            txtNEAddress.Clear()
            txtNECommWages.Clear()
            txtNEEmail.Clear()
            txtNEPhone.Clear()
            txtNEHourly.Clear()
            txtNECell.Clear()
            txtNEName.Clear()
            txtNENameEM.Clear()
            txtNEPhoneEM.Clear()
            txtNEPosition.Clear()
            txtNESalary.Clear()
            lblCommWages.Hide()
            lblSalaryWages.Hide()
            lblHourlyWages.Hide()
            radNECommission.Checked = False
            radNEHourly.Checked = False
            radNESalary.Checked = False

            txtNECommWages.Visible = False
            txtNEHourly.Visible = False
            txtNESalary.Visible = False
            lblNEPay.Text = ""
        End If
    End Sub
    Private Function checkFieldsFilled() As Boolean
        If txtNEAddress.Text = "" Or txtNEName.Text = "" Or txtNEEmail.Text = "" Or txtNEPhone.Text = "" Or txtNECell.Text = "" Or txtNECell.Text = "" Or txtNENameEM.Text = "" Or txtNEPhoneEM.Text = "" Or txtNEPosition.Text = "" Then
            MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        ElseIf radNECommission.Checked = True Then
            If txtNECommWages.Text = "" Then
                MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        ElseIf radNEHourly.Checked = True Then
            If txtNEHourly.Text = "" Then
                MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        ElseIf radNESalary.Checked = True Then
            If txtNESalary.Text = "" Then
                MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        ElseIf radNECommission.Checked = False And radNEHourly.Checked = False And radNESalary.Checked = False Then
            MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class