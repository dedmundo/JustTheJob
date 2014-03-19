Imports System.IO

Public Class clsFileManager
    Private strFileName As String

    'Used to save a Customer in the database
    Public Sub SaveCustomer(ByVal name As String, ByVal address As String, ByVal phone As String, ByVal email As String)
        Dim objContactsFile As StreamWriter
        strFileName = "Customers.txt"

        objContactsFile = File.AppendText(strFileName)

        objContactsFile.WriteLine("<name>" + name + " <address>" + address + " <phone>" + phone + " <email>" + email)


        objContactsFile.Close()
    End Sub

    'Used to save a Customer in the database
    Public Sub SaveEmployee(ByVal name As String, ByVal address As String, ByVal home As String, ByVal mobile As String,
                            ByVal email As String, ByVal nameEM As String, ByVal phone As String, ByVal position As String,
                            ByVal payType As String, ByVal pay As String)
        Dim objContactsFile As StreamWriter
        strFileName = "Employees.txt"

        objContactsFile = File.AppendText(strFileName)

        objContactsFile.WriteLine("<name>" + name + " <address>" + address + " <home>" + home + " <mobile>" + mobile +
                                  " <email>" + email + " <nameEM>" + nameEM + " <phone>" + phone + " <position>" + position +
                                  " <payType>" + payType + "<pay>" + pay)
        objContactsFile.Close()
    End Sub

    'Used to save a Customer in the database
    Public Sub SaveJob(ByVal name As String, ByVal client As String, ByVal location As String, ByVal start As String, ByVal deadLine As String, ByVal description As String,
                       ByVal lead As String, ByVal employee1 As String, ByVal employee2 As String, ByVal employee3 As String, ByVal leadTitle As String, ByVal title1 As String,
                       ByVal title2 As String, ByVal title3 As String)
        Dim objContactsFile As StreamWriter

        'put in pending jobs list
        strFileName = "PendingJobs.txt"

        objContactsFile = File.AppendText(strFileName)

        objContactsFile.WriteLine("<name>" + name + " <client>" + client + " <location>" + location + " <start>" + start +
                                  " <deadLine>" + deadLine + " <description>" + description + " <lead>" + lead + " <employee1>" + employee1 +
                                  " <employee2>" + employee2 + " <employee3>" + employee3 + " <leadTitle>" + leadTitle + " <title1>" + title1 +
                                  " <title2>" + title2 + " <title3>" + title3)
        objContactsFile.Close()

        'put in allJobs list
        strFileName = "Jobs.txt"
        objContactsFile = File.AppendText(strFileName)

        objContactsFile.WriteLine("<name>" + name + " <client>" + client + " <location>" + location + " <start>" + start +
                                  " <deadLine>" + deadLine + " <description>" + description + " <lead>" + lead + " <employee1>" + employee1 +
                                  " <employee2>" + employee2 + " <employee3>" + employee3 + " <leadTitle>" + leadTitle + " <title1>" + title1 +
                                  " <title2>" + title2 + " <title3>" + title3)
        objContactsFile.Close()
    End Sub

    Public Sub SaveAppointment(ByVal name As String, ByVal location As String, ByVal dateX As String, ByVal time As String, ByVal length As String, ByVal brief As String)
        Dim objContactsFile As StreamWriter
        Try
            strFileName = "Appointments.txt"

            objContactsFile = File.AppendText(strFileName)

            objContactsFile.WriteLine("<name>" + name + " <location>" + location + " <date>" + dateX + " <time>" + time +
                                     " <length>" + length + " <brief>" + brief)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objContactsFile.Close()
    End Sub

    Public Sub SaveInvoice(ByVal idNumber As String, ByVal type As String, ByVal name As String, ByVal employee As String, ByVal payment As String, ByVal paymentMethod As String,
                       ByVal complete As String, ByVal amountPaid As String, ByVal week As String)
        Dim objContactsFile As StreamWriter
        If type = "One" Then
            strFileName = "OneTimeInvoices.txt"

            objContactsFile = File.AppendText(strFileName)

            objContactsFile.WriteLine("<id>" + idNumber + " <name>" + name + " <type>" + type + " <employee>" + employee + " <payment>" + payment +
                                     " <paymentMethod>" + paymentMethod + " <complete>" + complete + " <amountPaid>" + amountPaid + " <date>" + week)
            objContactsFile.Close()
        ElseIf type = "Regular" Then
            strFileName = "RegularInvoices.txt"

            objContactsFile = File.AppendText(strFileName)

            objContactsFile.WriteLine("<id>" + idNumber + " <name>" + name + " <type>" + type + " <employee>" + employee + " <payment>" + payment +
                                     " <paymentMethod>" + paymentMethod + " <complete>" + complete + " <amountPaid>" + amountPaid + " <date>" + week)
            objContactsFile.Close()
        End If
    End Sub

    Public Sub SavePayment(ByVal invoiceID As String, ByVal amountPaid As String)
        Dim objContactsFile As StreamWriter
        Try
            strFileName = "Payments.txt"

            objContactsFile = File.AppendText(strFileName)

            objContactsFile.WriteLine("<invoiceID>" + invoiceID + " <amountPaid>" + amountPaid)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objContactsFile.Close()
    End Sub

    Public Sub LoadPayments(ByRef payments As Collection)
        Dim objLoadPaymentsFile As StreamReader
        Try
            objLoadPaymentsFile = File.OpenText("Payments.txt")
            Dim i As Integer
            i = 1
            While objLoadPaymentsFile.Peek <> -1
                payments.Add(objLoadPaymentsFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objLoadPaymentsFile.Close()
    End Sub

    Public Sub LoadInvoice(ByRef oneTimeInvoiceList As Collection, ByRef regularInvoiceList As Collection)
        Dim objOneTimeInvoiceFile As StreamReader
        Dim objRegularInvoiceFile As StreamReader
        Try
            objOneTimeInvoiceFile = File.OpenText("OneTimeInvoices.txt")

            Dim i As Integer
            i = 1
            While objOneTimeInvoiceFile.Peek <> -1
                oneTimeInvoiceList.Add(objOneTimeInvoiceFile.ReadLine(), i)
                i = i + 1
            End While
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error")
        End Try
        objOneTimeInvoiceFile.Close()
        Try
            objRegularInvoiceFile = File.OpenText("RegularInvoices.txt")

            Dim i As Integer
            i = 1
            While objRegularInvoiceFile.Peek <> -1
                regularInvoiceList.Add(objRegularInvoiceFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error")
        End Try
        objRegularInvoiceFile.Close()
    End Sub
    Public Sub LoadCustomer(ByRef customerList As Collection)
        Dim objCustomerFile As StreamReader
        Try
            objCustomerFile = File.OpenText("Customers.txt")

            Dim i As Integer
            i = 1
            While objCustomerFile.Peek <> -1
                customerList.Add(objCustomerFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objCustomerFile.Close()
    End Sub

    Public Sub LoadEmployee(ByRef employeeList As Collection)
        Dim objEmployeeFile As StreamReader
        Try
            objEmployeeFile = File.OpenText("Employees.txt")
            Dim i As Integer
            i = 1
            While objEmployeeFile.Peek <> -1
                employeeList.Add(objEmployeeFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objEmployeeFile.Close()
    End Sub

    Public Sub LoadJob(ByRef pendingJobList As Collection, ByRef completedJobList As Collection)
        Dim objJobFile As StreamReader
        Try
            objJobFile = File.OpenText("PendingJobs.txt")
            Dim i As Integer
            i = 1
            While objJobFile.Peek <> -1
                pendingJobList.Add(objJobFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objJobFile.Close()
        Try
            objJobFile = File.OpenText("CompletedJobs.txt")
            Dim i As Integer
            i = 1
            While objJobFile.Peek <> -1
                completedJobList.Add(objJobFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objJobFile.Close()
    End Sub

    Public Sub LoadAppointment(ByRef appointmentList As Collection)
        Dim objAppointmentFile As StreamReader
        Try
            objAppointmentFile = File.OpenText("Appointments.txt")

            Dim i As Integer
            i = 1
            While objAppointmentFile.Peek <> -1
                appointmentList.Add(objAppointmentFile.ReadLine(), i)
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        objAppointmentFile.Close()
    End Sub

    Public Sub deleteItem(ByRef list As Collection, ByRef fileName As String)
        Dim objReplaceFile As StreamWriter
        File.Replace(fileName, "Clear.txt", "Dumpster.txt")
        Try
            objReplaceFile = File.AppendText(fileName)

            For Each item In list
                objReplaceFile.WriteLine(item)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
        objReplaceFile.Close()
    End Sub
End Class
