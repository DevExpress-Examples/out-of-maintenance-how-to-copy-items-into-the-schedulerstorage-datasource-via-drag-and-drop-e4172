using System.ComponentModel;
using System;
using DevExpress.XtraScheduler;

namespace DxSample.Scheduler {
    [ToolboxItem(true)]
    public class CustomSchedulerStorage :SchedulerStorage {
        public CustomSchedulerStorage() : base() { }
        public CustomSchedulerStorage(IContainer components) : base(components) { }

        protected override AppointmentStorageBase CreateAppointmentStorage() {
            return new CustomAppointmentStorage(this);
        }
    }
}
