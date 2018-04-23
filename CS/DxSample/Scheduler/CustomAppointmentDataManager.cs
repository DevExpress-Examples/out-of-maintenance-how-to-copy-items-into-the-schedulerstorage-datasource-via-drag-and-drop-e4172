using DevExpress.XtraScheduler.Data;
using System;
using DevExpress.XtraScheduler;

namespace DxSample.Scheduler {
    public class CustomAppointmentDataManager :AppointmentDataManager {
        SchedulerDataController DataController;

        protected override void BeginInsertNewObjectRow(Appointment obj) {
            CustomAppointment appointment = (CustomAppointment)obj;
            if (appointment.ObjectForInsert == null)
                base.BeginInsertNewObjectRow(obj);
            else ((CustomAppointment)obj).SetRowHandleInternal(DataController.GetControllerRow(DataController.ListSource.Add(appointment.ObjectForInsert)));
        }

        protected override SchedulerDataController CreateDataController() {
            DataController = base.CreateDataController();
            return DataController;
        }
    }
}
