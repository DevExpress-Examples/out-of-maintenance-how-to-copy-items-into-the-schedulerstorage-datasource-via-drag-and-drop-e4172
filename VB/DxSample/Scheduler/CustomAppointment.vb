Imports Microsoft.VisualBasic
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
		Public Sub New(ByVal start As DateTime, ByVal [end] As DateTime)
			MyBase.New(start, [end])
		End Sub
		Public Sub New(ByVal start As DateTime, ByVal duration As TimeSpan)
			MyBase.New(start, duration)
		End Sub
		Public Sub New(ByVal type As AppointmentType, ByVal start As DateTime, ByVal [end] As DateTime)
			MyBase.New(type, start, [end])
		End Sub
		Public Sub New(ByVal type As AppointmentType, ByVal start As DateTime, ByVal duration As TimeSpan)
			MyBase.New(type, start, duration)
		End Sub
		Public Sub New(ByVal start As DateTime, ByVal [end] As DateTime, ByVal subject As String)
			MyBase.New(start, [end], subject)
		End Sub
		Public Sub New(ByVal start As DateTime, ByVal duration As TimeSpan, ByVal subject As String)
			MyBase.New(start, duration, subject)
		End Sub
		Public Sub New(ByVal type As AppointmentType, ByVal start As DateTime, ByVal [end] As DateTime, ByVal subject As String)
			MyBase.New(type, start, [end], subject)
		End Sub
		Public Sub New(ByVal type As AppointmentType, ByVal start As DateTime, ByVal duration As TimeSpan, ByVal subject As String)
			MyBase.New(type, start, duration, subject)
		End Sub
		Public Sub New(ByVal type As AppointmentType, ByVal start As DateTime, ByVal duration As TimeSpan, ByVal subject As String, ByVal id As Object)
			MyBase.New(type, start, duration, subject, id)
		End Sub

		Friend Sub SetRowHandleInternal(ByVal handle As Object)
			RowHandle = handle
		End Sub

		Private privateObjectForInsert As Object
		Public Property ObjectForInsert() As Object
			Get
				Return privateObjectForInsert
			End Get
			Set(ByVal value As Object)
				privateObjectForInsert = value
			End Set
		End Property

		Protected Overrides Sub Assign(ByVal src As Appointment)
			MyBase.Assign(src)
			ObjectForInsert = (CType(src, CustomAppointment)).ObjectForInsert
		End Sub
	End Class
End Namespace
