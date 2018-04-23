using System;
using DevExpress.XtraScheduler;

namespace DxSample.Scheduler {
    [Serializable]
    public class CustomAppointment :Appointment {
        public CustomAppointment() : base() { }
        public CustomAppointment(AppointmentType type) : base(type) { }
        public CustomAppointment(DateTime start, DateTime end) : base(start, end) { }
        public CustomAppointment(DateTime start, TimeSpan duration) : base(start, duration) { }
        public CustomAppointment(AppointmentType type, DateTime start, DateTime end) : base(type, start, end) { }
        public CustomAppointment(AppointmentType type, DateTime start, TimeSpan duration) : base(type, start, duration) { }
        public CustomAppointment(DateTime start, DateTime end, string subject) : base(start, end, subject) { }
        public CustomAppointment(DateTime start, TimeSpan duration, string subject) : base(start, duration, subject) { }
        public CustomAppointment(AppointmentType type, DateTime start, DateTime end, string subject) : base(type, start, end, subject) { }
        public CustomAppointment(AppointmentType type, DateTime start, TimeSpan duration, string subject) : base(type, start, duration, subject) { }
        public CustomAppointment(AppointmentType type, DateTime start, TimeSpan duration, string subject, object id) : base(type, start, duration, subject, id) { }

        internal void SetRowHandleInternal(object handle) {
            RowHandle = handle;
        }

        public object ObjectForInsert { get; set; }

        protected override void Assign(Appointment src) {
            base.Assign(src);
            ObjectForInsert = ((CustomAppointment)src).ObjectForInsert;
        }
    }
}
