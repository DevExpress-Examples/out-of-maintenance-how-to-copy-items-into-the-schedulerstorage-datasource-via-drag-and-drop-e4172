Imports System
Imports DevExpress.XtraScheduler

Namespace DxSample.Scheduler
    <Serializable> _
    Public Class CustomAppointment
        Inherits Appointment

        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal type As AppointmentType)
            MyBase.New(type)
        End Sub
        Public Sub New(ByVal start As Date, ByVal [end] As Date)
            MyBase.New(start, [end])
        End Sub
        Public Sub New(ByVal start As Date, ByVal duration As TimeSpan)
            MyBase.New(start, duration)
        End Sub
        Public Sub New(ByVal type As AppointmentType, ByVal start As Date, ByVal [end] As Date)
            MyBase.New(type, start, [end])
        End Sub
        Public Sub New(ByVal type As AppointmentType, ByVal start As Date, ByVal duration As TimeSpan)
            MyBase.New(type, start, duration)
        End Sub
        Public Sub New(ByVal start As Date, ByVal [end] As Date, ByVal subject As String)
            MyBase.New(start, [end], subject)
        End Sub
        Public Sub New(ByVal start As Date, ByVal duration As TimeSpan, ByVal subject As String)
            MyBase.New(start, duration, subject)
        End Sub
        Public Sub New(ByVal type As AppointmentType, ByVal start As Date, ByVal [end] As Date, ByVal subject As String)
            MyBase.New(type, start, [end], subject)
        End Sub
        Public Sub New(ByVal type As AppointmentType, ByVal start As Date, ByVal duration As TimeSpan, ByVal subject As String)
            MyBase.New(type, start, duration, subject)
        End Sub
        Public Sub New(ByVal type As AppointmentType, ByVal start As Date, ByVal duration As TimeSpan, ByVal subject As String, ByVal id As Object)
            MyBase.New(type, start, duration, subject, id)
        End Sub

        Friend Sub SetRowHandleInternal(ByVal handle As Object)
            RowHandle = handle
        End Sub

        Public Property ObjectForInsert() As Object

        Protected Overrides Sub Assign(ByVal src As Appointment)
            MyBase.Assign(src)
            ObjectForInsert = DirectCast(src, CustomAppointment).ObjectForInsert
        End Sub
    End Class
End Namespace
