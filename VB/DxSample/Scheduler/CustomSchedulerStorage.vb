Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System
Imports DevExpress.XtraScheduler

Namespace DxSample.Scheduler
	<ToolboxItem(True)> _
	Public Class CustomSchedulerStorage
		Inherits SchedulerStorage
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal components As IContainer)
			MyBase.New(components)
		End Sub

		Protected Overrides Function CreateAppointmentStorage() As AppointmentStorageBase
			Return New CustomAppointmentStorage(Me)
		End Function
	End Class
End Namespace
