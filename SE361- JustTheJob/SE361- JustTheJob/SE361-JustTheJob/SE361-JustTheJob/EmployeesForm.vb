Public Class EmployeesForm
    'Opens Add new Employee Form
    Private Sub btnNewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewEmployee.Click
        NewEmployee.Show()
        NewEmployee.txtNEName.Focus()
    End Sub
    'Displays a form containing a list of employees
    Private Sub btnEmpList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpList.Click
        EmployeeListForm.Show()
    End Sub
    'create input box for employee name to search for
    Private Sub btnEmpShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpShow.Click
        Dim objEmployeeFile As New clsFileManager
        Dim employeeList As New Collection
        Dim temp As String          'temporary string
        Dim tempName As String      'Hold the testing customer name for search function
        Dim strEmployeeName As String
        objEmployeeFile.LoadEmployee(employeeList)
        strEmployeeName = InputBox("Enter the Employee Name you want to search for.", "EmployeeName")
            For Each empl In employeeList
                temp = empl
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName.ToLower().Trim = strEmployeeName.ToLower().Trim) Then
                'Set contents
                EmployeeInfo.lblEIHeading.Text = tempName
                EmployeeInfo.lblEIName.Text = tempName

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                EmployeeInfo.lblEIAddress.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(6)

                EmployeeInfo.lblEIHome.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)

                EmployeeInfo.lblEIMobile.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(7)

                EmployeeInfo.lblEIEmail.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(8)

                EmployeeInfo.lblEINameEM.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(7)

                EmployeeInfo.lblEIPhoneEM.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(10)

                EmployeeInfo.lblEIPosition.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(9)

                EmployeeInfo.lblEIPayType.Text = temp.Substring(0, temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf("<"))
                temp = temp.Substring(5)

                EmployeeInfo.lblEIWages.Text = temp

                EmployeeInfo.Show()
                Exit Sub
            End If
            Next
            MessageBox.Show("There is no employee by that name in the database.", "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    'Opens form containing employee information. This form will contain option for editing & printing info, as well as giving option to delete
    'the employee if the user is a Manager

    
    'Closes EmployeeForm
    Private Sub btnEmpBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpBack.Click
        Me.Close()
    End Sub

    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class