using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraScheduler;
using DxSample.Scheduler;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.ComponentModel;
using DevExpress.XtraGrid;

namespace DxSample {
    public partial class MainForm :XtraForm {
        Rectangle DragStartArea;

        public MainForm() {
            InitializeComponent();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            Session.CommitChanges();
        }

        private void OnGridMouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                DragStartArea = new Rectangle(new Point(e.X - SystemInformation.DragSize.Width,
                    e.Y - SystemInformation.DragSize.Height), SystemInformation.DragSize);
        }

        private void OnGridMouseMove(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left || DragStartArea.Contains(e.Location)) return;
            GridHitInfo hitInfo = View.CalcHitInfo(e.X + DragStartArea.Width / 2,
                e.Y + DragStartArea.Height / 2);
            DragStartArea = Rectangle.Empty;
            if (!hitInfo.InRow) return;
            CustomAppointment appointment = (CustomAppointment)Storage.CreateAppointment(AppointmentType.Normal);
            appointment.ObjectForInsert = View.GetRow(hitInfo.RowHandle);
            appointment.Subject = View.GetRowCellDisplayText(hitInfo.RowHandle, colSubject) ;
            Grid.DoDragDrop(new SchedulerDragData(appointment), DragDropEffects.All);
        }

        private void OnGridMouseUp(object sender, MouseEventArgs e) {
            DragStartArea = Rectangle.Empty;
        }

        private void OnGridShowingEditor(object sender, CancelEventArgs e) {
            e.Cancel = View.FocusedRowHandle != GridControl.NewItemRowHandle;
        }
    }
}
