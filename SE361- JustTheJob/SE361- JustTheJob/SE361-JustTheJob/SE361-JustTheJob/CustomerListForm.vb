'Contains list of Customers with info(don't know what). Don't know how we will implement it
Public Class CustomerListForm
    Dim objFileManager As New clsFileManager
    Dim customerList As New Collection
    'Closes ListForm
    Private Sub btnCLBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLBack.Click
        Me.Close()
    End Sub
    'Closes ListForm
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustomerListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objFileManager.LoadCustomer(customerList)

        Dim i As Integer
        Dim counter As Integer
        Dim temp As String
        i = 1
        counter = customerList.Count
        While counter > 0
            temp = customerList.Item(i)
            temp = temp.Substring(6)
            lstName.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(9)
            lstAddress.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(7)
            lstPhone.Items.Add(temp.Substring(0, temp.IndexOf("<")))
            temp = temp.Substring(temp.IndexOf("<"))
            temp = temp.Substring(7)
            lstEmail.Items.Add(temp.Substring(0))

            counter = counter - 1
            i = i + 1
        End While

    End Sub
End Class