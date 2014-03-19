Public Class EmployeeInfo
    Dim objFileManager As New clsFileManager
    Dim employeeList As New Collection

    'Opens The Modify Employee Form
    Private Sub btnEIEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEIEdit.Click
        'need a form here or something.
        EmployeeEditForm.txtName.Text = lblEIName.Text
        EmployeeEditForm.txtAddress.Text = lblEIAddress.Text
        EmployeeEditForm.txtHome.Text = lblEIHome.Text
        EmployeeEditForm.txtMobile.Text = lblEIMobile.Text
        EmployeeEditForm.txtEmail.Text = lblEIEmail.Text
        EmployeeEditForm.txtNameEM.Text = lblEINameEM.Text
        EmployeeEditForm.txtPhoneEM.Text = lblEIPhoneEM.Text
        EmployeeEditForm.txtPosition.Text = lblEIPosition.Text
        EmployeeEditForm.lblPay.Text = lblEIWages.Text
        EmployeeEditForm.lblHead.Text = "Edit Info for: " + lblEIName.Text

        If lblEIPayType.Text = "Salary" Then
            EmployeeEditForm.radSalary.Checked = True
            EmployeeEditForm.txtSalary.Text = lblEIWages.Text
        ElseIf lblEIPayType.Text = "Commission" Then
            EmployeeEditForm.radCommission.Checked = True
            EmployeeEditForm.txtCommWages.Text = lblEIWages.Text
        ElseIf lblEIPayType.Text = "Hourly" Then
            EmployeeEditForm.radHourly.Checked = True
            EmployeeEditForm.txtHourly.Text = lblEIWages.Text
        End If

        EmployeeEditForm.Show()

    End Sub
    'Close Form
    Private Sub btnEIBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEIBack.Click
        Me.Close()
    End Sub
    'Close Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Deletes the Employee from database. Manager action only
    Private Sub btnRemove_Click_1(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer
        counter = 1

        objFileManager.LoadEmployee(employeeList)

        For Each empl In employeeList
            temp = empl
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName = lblEIName.Text) Then
                employeeList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(employeeList, "Employees.txt")
        MessageBox.Show("Employee deleted", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class