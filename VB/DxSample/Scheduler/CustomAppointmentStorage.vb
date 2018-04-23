Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Data
Imports DevExpress.XtraScheduler

Namespace DxSample.Scheduler
	Public Class CustomAppointmentStorage
		Inherits AppointmentStorage
		Public Sub New(ByVal storage As SchedulerStorage)
			MyBase.New(storage)
			SetAppointmentFactory(New CustomAppointmentFactory())
		End Sub

		Protected Overrides Function CreateDataManager() As DataManager(Of Appointment)
			Return New CustomAppointmentDataManager()
		End Function
	End Class
End Namespace
