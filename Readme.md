<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128634085/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4172)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))**
* [Event.cs](./CS/DxSample/PersistentObjects/Event.cs) (VB: [Event.vb](./VB/DxSample/PersistentObjects/Event.vb))
* [CustomAppointment.cs](./CS/DxSample/Scheduler/CustomAppointment.cs) (VB: [CustomAppointmentFactory.vb](./VB/DxSample/Scheduler/CustomAppointmentFactory.vb))
* [CustomAppointmentDataManager.cs](./CS/DxSample/Scheduler/CustomAppointmentDataManager.cs) (VB: [CustomAppointmentDataManager.vb](./VB/DxSample/Scheduler/CustomAppointmentDataManager.vb))
* [CustomAppointmentFactory.cs](./CS/DxSample/Scheduler/CustomAppointmentFactory.cs) (VB: [CustomAppointmentFactory.vb](./VB/DxSample/Scheduler/CustomAppointmentFactory.vb))
* [CustomAppointmentStorage.cs](./CS/DxSample/Scheduler/CustomAppointmentStorage.cs) (VB: [CustomAppointmentStorage.vb](./VB/DxSample/Scheduler/CustomAppointmentStorage.vb))
* [CustomSchedulerStorage.cs](./CS/DxSample/Scheduler/CustomSchedulerStorage.cs) (VB: [CustomSchedulerStorage.vb](./VB/DxSample/Scheduler/CustomSchedulerStorage.vb))
<!-- default file list end -->
# How to copy items into the SchedulerStorage datasource via drag and drop


<p>The SchedulerControl manually handles the drag and drop operation and inserts a new object into the collection in addition to the object that will be inserted later.</p><br />
<p>This example demonstrates how to create a custom SchedulerStorage component that can address this problem. This component allows you to specify which object to insert into the datasource when a new appointment is added. The new object can be specified via the ObjectForInsert property of a custom Appointment.</p>

<br/>


