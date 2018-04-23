Imports DevExpress.XtraScheduler

Namespace DxSample.Scheduler
    Public Class CustomAppointmentFactory
        Implements IAppointmentFactory

        #Region "IAppointmentFactory"
        Private Function IAppointmentFactory_CreateAppointment(ByVal type As AppointmentType) As Appointment Implements IAppointmentFactory.CreateAppointment
            Return New CustomAppointment(type)
        End Function
        #End Region
    End Class
End Namespace
