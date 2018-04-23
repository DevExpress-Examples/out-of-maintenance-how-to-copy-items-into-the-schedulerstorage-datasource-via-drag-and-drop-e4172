using DevExpress.XtraScheduler;

namespace DxSample.Scheduler {
    public class CustomAppointmentFactory :IAppointmentFactory {
        #region IAppointmentFactory
        Appointment IAppointmentFactory.CreateAppointment(AppointmentType type) {
            return new CustomAppointment(type);
        }
        #endregion
    }
}
