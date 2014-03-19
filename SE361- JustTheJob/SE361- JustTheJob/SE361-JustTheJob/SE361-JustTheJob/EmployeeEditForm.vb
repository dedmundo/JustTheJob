Public Class EmployeeEditForm
    Dim objFileManager As New clsFileManager
    Dim employeeList As New Collection
    'closes form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    'set lblPay to "Hourly rate:" & set txtCommWage, lblCommission, and txtCommission to visible
    Private Sub radNECommission_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCommission.CheckedChanged
        txtCommWages.Visible = True
        lblPay.Text = "Commission:"
        lblCommWages.Visible = True
        lblSalaryWages.Visible = False
        lblHourlyWages.Visible = False
        txtHourly.Visible = False
        txtSalary.Visible = False
    End Sub
    'set lblPay to "Hourly rate:" & set txtHourly to visible
    Private Sub radNEHourly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHourly.CheckedChanged
        txtCommWages.Visible = False
        txtHourly.Visible = True
        lblHourlyWages.Visible = True
        lblCommWages.Visible = False
        lblSalaryWages.Visible = False
        txtHourly.Focus()
        txtSalary.Visible = False
        lblPay.Text = "Hourly rate:"

    End Sub

    Private Sub radSalary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSalary.CheckedChanged
        txtCommWages.Visible = False
        lblCommWages.Visible = False
        lblHourlyWages.Visible = False
        lblSalaryWages.Visible = True
        txtHourly.Visible = False
        txtSalary.Visible = True
        txtSalary.Focus()
        lblPay.Text = "Salary:"

    End Sub
    'closes form
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Removes old item from collection and adds modified info to collection. updates textfile
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer
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

        employeeNameCorrect = objCheck.checkName(txtName.Text)
        emNameCorrect = objCheck.checkName(txtNameEM.Text)

        emPhone = objCheck.editPhone(txtPhoneEM.Text)
        emPhoneCorrect = objCheck.checkPhone(emPhone)
        homePhone = objCheck.editPhone(txtHome.Text)
        homePhoneCorrect = objCheck.checkPhone(homePhone)
        cellPhone = objCheck.editPhone(txtMobile.Text)
        cellPhoneCorrect = objCheck.checkPhone(cellPhone)
        fieldsFilled = checkFieldsFilled()


        counter = 1
        If employeeNameCorrect = True And homePhoneCorrect = True And cellPhoneCorrect = True And emPhoneCorrect = True And
    emNameCorrect = True And fieldsFilled = True Then
            objFileManager.LoadEmployee(employeeList)
            For Each empl In employeeList
                temp = empl
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

                If (tempName = EmployeeInfo.lblEIName.Text) Then
                    employeeList.Remove(counter)
                End If
                counter = counter + 1
            Next

            If radSalary.Checked = True Then
                employeeList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <home>" + txtHome.Text.Trim + " <mobile>" + txtMobile.Text.Trim +
                                  " <email>" + txtEmail.Text.Trim + " <nameEM>" + txtNameEM.Text.Trim + " <phone>" + txtPhoneEM.Text.Trim + " <position>" + txtPosition.Text.Trim +
                                  " <payType>" + "Salary" + " <pay>" + txtSalary.Text.Trim)
            ElseIf radCommission.Checked = True Then
                employeeList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <home>" + txtHome.Text.Trim + " <mobile>" + txtMobile.Text.Trim +
                                      " <email>" + txtEmail.Text.Trim + " <nameEM>" + txtNameEM.Text.Trim + " <phone>" + txtPhoneEM.Text.Trim + " <position>" + txtPosition.Text.Trim +
                                      " <payType>" + "Commission" + " <pay>" + txtCommWages.Text.Trim)
            ElseIf radHourly.Checked = True Then
                employeeList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <home>" + txtHome.Text.Trim + " <mobile>" + txtMobile.Text.Trim +
                                      " <email>" + txtEmail.Text.Trim + " <nameEM>" + txtNameEM.Text.Trim + " <phone>" + txtPhoneEM.Text.Trim + " <position>" + txtPosition.Text.Trim +
                                      " <payType>" + "Hourly" + " <pay>" + txtHourly.Text.Trim)
            End If

            objFileManager.deleteItem(employeeList, "Employees.txt")

            MessageBox.Show("Employee Information Changed", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EmployeeInfo.Close()
            Me.Close()

        End If
    End Sub

    Private Function checkFieldsFilled() As Boolean
        If txtAddress.Text = "" Or txtName.Text = "" Or txtEmail.Text = "" Or txtHome.Text = "" Or txtMobile.Text = "" Or txtNameEM.Text = "" Or txtPhoneEM.Text = "" Or txtPosition.Text = "" Then
            MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        ElseIf radCommission.Checked = True Then
            If txtCommWages.Text = "" Then
                MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        ElseIf radHourly.Checked = True Then
            If txtHourly.Text = "" Then
                MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        ElseIf radSalary.Checked = True Then
            If txtSalary.Text = "" Then
                MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        ElseIf radCommission.Checked = False And radHourly.Checked = False And radSalary.Checked = False Then
            MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

End Class