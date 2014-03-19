Public Class clsEmployeeListManager
    Private colEmployees As New Collection

    Public Sub addEmployee(ByVal name, ByVal address, ByVal homePhone, ByVal cellPhone, ByVal email,
                           ByVal emergencyName, ByVal emergencyPhone, ByVal position, ByVal paytype, ByVal wages)
        Dim objEmployee As New clsEmployee

        objEmployee.name = name
        objEmployee.address = address
        objEmployee.homePhone = homePhone
        objEmployee.cellPhone = cellPhone
        objEmployee.email = email
        objEmployee.emergencyName = emergencyName
        objEmployee.emergencyPhone = emergencyPhone
        objEmployee.position = position
        objEmployee.paytype = paytype
        objEmployee.wages = wages

        colEmployees.Add(objEmployee)
    End Sub

    Public Sub viewEmployeeName(ByRef guiDisplay As ListBox)
        Dim empl As clsEmployee

        For Each empl In colEmployees
            guiDisplay.Items.Add(empl.name)
        Next
    End Sub

    Public Sub viewEmployeecellPhone(ByRef guiDisplay As ListBox)
        Dim empl As clsEmployee

        For Each empl In colEmployees
            guiDisplay.Items.Add(empl.cellPhone)
        Next
    End Sub

    Public Sub viewEmployeeposition(ByRef guiDisplay As ListBox)
        Dim empl As clsEmployee

        For Each empl In colEmployees
            guiDisplay.Items.Add(empl.position)
        Next
    End Sub

    Public Sub viewEmployeewages(ByRef guiDisplay As ListBox)
        Dim empl As clsEmployee

        For Each empl In colEmployees
            guiDisplay.Items.Add(empl.wages)
        Next
    End Sub

End Class

