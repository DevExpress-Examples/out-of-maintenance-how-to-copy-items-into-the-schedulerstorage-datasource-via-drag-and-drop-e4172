using DevExpress.XtraScheduler.Data;
using DevExpress.XtraScheduler;

namespace DxSample.Scheduler {
    public class CustomAppointmentStorage :AppointmentStorage {
        public CustomAppointmentStorage(SchedulerStorage storage) : base(storage) {
            SetAppointmentFactory(new CustomAppointmentFactory());
        }

        protected override DataManager<Appointment> CreateDataManager() {
            return new CustomAppointmentDataManager();
        }
    }
}
