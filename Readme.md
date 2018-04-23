# How to copy items into the SchedulerStorage datasource via drag and drop


<p>The SchedulerControl manually handles the drag and drop operation and inserts a new object into the collection in addition to the object that will be inserted later.</p><br />
<p>This example demonstrates how to create a custom SchedulerStorage component that can address this problem. This component allows you to specify which object to insert into the datasource when a new appointment is added. The new object can be specified via the ObjectForInsert property of a custom Appointment.</p>

<br/>


