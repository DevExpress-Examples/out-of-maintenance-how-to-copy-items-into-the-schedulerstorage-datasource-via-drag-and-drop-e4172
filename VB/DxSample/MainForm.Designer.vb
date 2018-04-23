Namespace DxSample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler4 As New DevExpress.XtraScheduler.TimeRuler()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.Session = New DevExpress.Xpo.UnitOfWork(Me.components)
            Me.Storage = New DxSample.Scheduler.CustomSchedulerStorage(Me.components)
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.Grid = New DevExpress.XtraGrid.GridControl()
            Me.xpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            DirectCast(Me.Session, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.Storage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010"
            ' 
            ' Storage
            ' 
            Me.Storage.Appointments.DataSource = Me.xpCollection1
            Me.Storage.Appointments.Mappings.End = "EndTime"
            Me.Storage.Appointments.Mappings.Start = "StartTime"
            Me.Storage.Appointments.Mappings.Subject = "Subject"
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.DisplayableProperties = "Subject;StartTime;EndTime"
            Me.xpCollection1.LoadingEnabled = False
            Me.xpCollection1.ObjectType = GetType(DxSample.PersistentObjects.Event)
            Me.xpCollection1.Session = Me.Session
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.Grid)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.schedulerControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(492, 568)
            Me.splitContainerControl1.SplitterPosition = 234
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' Grid
            ' 
            Me.Grid.DataSource = Me.xpCollection2
            Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Grid.Location = New System.Drawing.Point(0, 0)
            Me.Grid.MainView = Me.View
            Me.Grid.Name = "Grid"
            Me.Grid.Size = New System.Drawing.Size(492, 234)
            Me.Grid.TabIndex = 0
            Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.View})
            ' 
            ' xpCollection2
            ' 
            Me.xpCollection2.DisplayableProperties = "Subject;StartTime;EndTime"
            Me.xpCollection2.ObjectType = GetType(DxSample.PersistentObjects.Event)
            Me.xpCollection2.Session = Me.Session
            ' 
            ' View
            ' 
            Me.View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSubject, Me.colStartTime, Me.colEndTime})
            Me.View.GridControl = Me.Grid
            Me.View.Name = "View"
            Me.View.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            ' 
            ' colSubject
            ' 
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 0
            ' 
            ' colStartTime
            ' 
            Me.colStartTime.FieldName = "StartTime"
            Me.colStartTime.Name = "colStartTime"
            Me.colStartTime.Visible = True
            Me.colStartTime.VisibleIndex = 1
            ' 
            ' colEndTime
            ' 
            Me.colEndTime.FieldName = "EndTime"
            Me.colEndTime.Name = "colEndTime"
            Me.colEndTime.Visible = True
            Me.colEndTime.VisibleIndex = 2
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(492, 328)
            Me.schedulerControl1.Start = New Date(2012, 8, 15, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.Storage
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            timeRuler3.TimeZoneId = "Pacific Standard Time"
            timeRuler3.UseClientTimeZone = False
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler3)
            timeRuler4.TimeZoneId = "Pacific Standard Time"
            timeRuler4.UseClientTimeZone = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(492, 568)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "MainForm"
            Me.Text = "Dx Sample"
            DirectCast(Me.Session, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.Storage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private Storage As Scheduler.CustomSchedulerStorage
        Private xpCollection1 As DevExpress.Xpo.XPCollection
        Private Session As DevExpress.Xpo.UnitOfWork
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private Grid As DevExpress.XtraGrid.GridControl
        Private WithEvents View As DevExpress.XtraGrid.Views.Grid.GridView
        Private xpCollection2 As DevExpress.Xpo.XPCollection
        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
        Private colStartTime As DevExpress.XtraGrid.Columns.GridColumn
        Private colEndTime As DevExpress.XtraGrid.Columns.GridColumn
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    End Class
End Namespace

