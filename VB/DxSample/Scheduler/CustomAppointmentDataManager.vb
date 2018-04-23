Imports Microsoft.VisualBasic
Imports DevExpress.XtraScheduler.Data
Imports System
Imports DevExpress.XtraScheduler

Namespace DxSample.Scheduler
	Public Class CustomAppointmentDataManager
		Inherits AppointmentDataManager
		Private DataController As SchedulerDataController

		Protected Overrides Sub BeginInsertNewObjectRow(ByVal obj As Appointment)
			Dim appointment As CustomAppointment = CType(obj, CustomAppointment)
			If appointment.ObjectForInsert Is Nothing Then
				MyBase.BeginInsertNewObjectRow(obj)
			Else
				CType(obj, CustomAppointment).SetRowHandleInternal(DataController.GetControllerRow(DataController.ListSource.Add(appointment.ObjectForInsert)))
			End If
		End Sub

		Protected Overrides Function CreateDataController() As SchedulerDataController
			DataController = MyBase.CreateDataController()
			Return DataController
		End Function
	End Class
End Namespace
