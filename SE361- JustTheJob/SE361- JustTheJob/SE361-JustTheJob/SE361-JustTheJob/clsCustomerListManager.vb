'Control Class
Public Class clsCustomerListManager
    Private colCustomers As New Collection

    Public Sub addCustomer(ByVal name As String, ByVal address As String, ByVal phone As String, ByVal email As String)
        Dim objCustomer As New clsCustomer

        objCustomer.name = name
        objCustomer.address = address
        objCustomer.phone = phone
        objCustomer.email = email

        colCustomers.Add(objCustomer)
    End Sub

    Public Sub viewCustomerName(ByRef guiDisplay As ListBox)
        Dim cust As clsCustomer

        For Each cust In colCustomers
            guiDisplay.Items.Add(cust.name)
        Next
    End Sub

    Public Sub viewCustomerAddress(ByRef guiDisplay As ListBox)
        Dim cust As clsCustomer

        For Each cust In colCustomers
            guiDisplay.Items.Add(cust.address)
        Next
    End Sub

    Public Sub viewCustomerPhone(ByRef guiDisplay As ListBox)
        Dim cust As clsCustomer

        For Each cust In colCustomers
            guiDisplay.Items.Add(cust.phone)
        Next
    End Sub

    Public Sub viewCustomerEmail(ByRef guiDisplay As ListBox)
        Dim cust As clsCustomer

        For Each cust In colCustomers
            guiDisplay.Items.Add(cust.email)
        Next
    End Sub
End Class
