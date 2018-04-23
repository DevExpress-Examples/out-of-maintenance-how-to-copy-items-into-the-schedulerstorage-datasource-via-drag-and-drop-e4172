namespace DxSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.Session = new DevExpress.Xpo.UnitOfWork(this.components);
            this.Storage = new DxSample.Scheduler.CustomSchedulerStorage(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.xpCollection2 = new DevExpress.Xpo.XPCollection(this.components);
            this.View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)(this.Session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
            // 
            // Storage
            // 
            this.Storage.Appointments.DataSource = this.xpCollection1;
            this.Storage.Appointments.Mappings.End = "EndTime";
            this.Storage.Appointments.Mappings.Start = "StartTime";
            this.Storage.Appointments.Mappings.Subject = "Subject";
            // 
            // xpCollection1
            // 
            this.xpCollection1.DisplayableProperties = "Subject;StartTime;EndTime";
            this.xpCollection1.LoadingEnabled = false;
            this.xpCollection1.ObjectType = typeof(DxSample.PersistentObjects.Event);
            this.xpCollection1.Session = this.Session;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.Grid);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(492, 568);
            this.splitContainerControl1.SplitterPosition = 234;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Grid
            // 
            this.Grid.DataSource = this.xpCollection2;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.View;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(492, 234);
            this.Grid.TabIndex = 0;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.View});
            // 
            // xpCollection2
            // 
            this.xpCollection2.DisplayableProperties = "Subject;StartTime;EndTime";
            this.xpCollection2.ObjectType = typeof(DxSample.PersistentObjects.Event);
            this.xpCollection2.Session = this.Session;
            // 
            // View
            // 
            this.View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubject,
            this.colStartTime,
            this.colEndTime});
            this.View.GridControl = this.Grid;
            this.View.Name = "View";
            this.View.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.View.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.OnGridShowingEditor);
            this.View.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnGridMouseDown);
            this.View.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnGridMouseUp);
            this.View.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnGridMouseMove);
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 0;
            // 
            // colStartTime
            // 
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 1;
            // 
            // colEndTime
            // 
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 2;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(492, 328);
            this.schedulerControl1.Start = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.Storage;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            timeRuler3.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00");
            timeRuler3.TimeZone.DaylightDate = new System.DateTime(1, 3, 2, 2, 0, 0, 0);
            timeRuler3.TimeZone.DaylightZoneName = "Pacific Daylight Time";
            timeRuler3.TimeZone.DisplayName = "(UTC-08:00) Pacific Time (US & Canada)";
            timeRuler3.TimeZone.StandardDate = new System.DateTime(1, 11, 1, 2, 0, 0, 0);
            timeRuler3.TimeZone.StandardZoneName = "Pacific Standard Time";
            timeRuler3.TimeZone.UtcOffset = System.TimeSpan.Parse("-08:00:00");
            timeRuler3.UseClientTimeZone = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler3);
            timeRuler4.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00");
            timeRuler4.TimeZone.DaylightDate = new System.DateTime(1, 3, 2, 2, 0, 0, 0);
            timeRuler4.TimeZone.DaylightZoneName = "Pacific Daylight Time";
            timeRuler4.TimeZone.DisplayName = "(UTC-08:00) Pacific Time (US & Canada)";
            timeRuler4.TimeZone.StandardDate = new System.DateTime(1, 11, 1, 2, 0, 0, 0);
            timeRuler4.TimeZone.StandardZoneName = "Pacific Standard Time";
            timeRuler4.TimeZone.UtcOffset = System.TimeSpan.Parse("-08:00:00");
            timeRuler4.UseClientTimeZone = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MainForm";
            this.Text = "Dx Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private Scheduler.CustomSchedulerStorage Storage;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.UnitOfWork Session;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView View;
        private DevExpress.Xpo.XPCollection xpCollection2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}

