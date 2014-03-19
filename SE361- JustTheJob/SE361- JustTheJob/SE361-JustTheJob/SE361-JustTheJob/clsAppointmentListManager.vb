Public Class clsAppointmentListManager
    Private colAppointment As New Collection

    Public Sub addAppointment(ByVal name As String, ByVal location As String, ByVal dateX As String, ByVal time As String, ByVal length As String, ByVal brief As String)
        Dim objAppointment As New clsAppointment

        objAppointment.name = name
        objAppointment.location = location
        objAppointment.dateX = dateX
        objAppointment.time = time
        objAppointment.length = length
        objAppointment.brief = brief

        colAppointment.Add(objAppointment)
    End Sub

    Public Sub viewAppointmentName(ByRef guiDisplay As ListBox)
        Dim apt As clsAppointment

        For Each apt In colAppointment
            guiDisplay.Items.Add(apt.name)
        Next
    End Sub

    Public Sub viewAppointmentLocation(ByRef guiDisplay As ListBox)
        Dim apt As clsAppointment

        For Each apt In colAppointment
            guiDisplay.Items.Add(apt.location)
        Next
    End Sub

    Public Sub viewAppointmentDate(ByRef guiDisplay As ListBox)
        Dim apt As clsAppointment

        For Each apt In colAppointment
            guiDisplay.Items.Add(apt.dateX)
        Next
    End Sub

    Public Sub viewAppointmentTime(ByRef guiDisplay As ListBox)
        Dim apt As clsAppointment

        For Each apt In colAppointment
            guiDisplay.Items.Add(apt.time)
        Next
    End Sub
    Public Sub viewAppointmentLength(ByRef guiDisplay As ListBox)
        Dim apt As clsAppointment

        For Each apt In colAppointment
            guiDisplay.Items.Add(apt.length)
        Next
    End Sub
    Public Sub viewAppointmentbrief(ByRef guiDisplay As ListBox)
        Dim apt As clsAppointment

        For Each apt In colAppointment
            guiDisplay.Items.Add(apt.brief)
        Next
    End Sub
    End Class
