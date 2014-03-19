Public Class EmployeeListForm
    Dim objFileManager As New clsFileManager
    Dim employeeList As New Collection
    'Close Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Close Form
    Private Sub btnNLBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNLBack.Click
        Me.Close()
    End Sub

    Private Sub EmployeeListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objFileManager.LoadEmployee(employeeList)

        Dim i As Integer
        Dim counter As Integer
        Dim temp As String
        i = 1
        counter = employeeList.Count
        While counter > 0
            temp = employeeList.Item(i)
            'pulls name
            temp = temp.Substring(6)
            lstName.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trims unnecessary info
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(9)
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(6)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls phone
            temp = temp.Substring(8)
            lstPhone.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trims unnecessary info
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(7)
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(8)
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(7)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls position
            temp = temp.Substring(10)
            lstPosition.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            'trims unnecessary info
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(9)
            temp = temp.Substring(temp.IndexOf("<"))
            'pulls wages
            temp = temp.Substring(5)
            lstWages.Items.Add(temp.Substring(0))

            counter = counter - 1
            i = i + 1
        End While
    End Sub
End Class