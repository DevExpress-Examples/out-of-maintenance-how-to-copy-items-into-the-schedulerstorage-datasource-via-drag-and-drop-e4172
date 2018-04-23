Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraScheduler
Imports DxSample.Scheduler
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraGrid

Namespace DxSample
	Partial Public Class MainForm
		Inherits XtraForm
		Private DragStartArea As Rectangle

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Overloads Sub OnFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			Session.CommitChanges()
		End Sub

		Private Sub OnGridMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles View.MouseDown
			If e.Button = MouseButtons.Left Then
				DragStartArea = New Rectangle(New Point(e.X - SystemInformation.DragSize.Width, e.Y - SystemInformation.DragSize.Height), SystemInformation.DragSize)
			End If
		End Sub

		Private Sub OnGridMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles View.MouseMove
			If e.Button <> MouseButtons.Left OrElse DragStartArea.Contains(e.Location) Then
				Return
			End If
			Dim hitInfo As GridHitInfo = View.CalcHitInfo(e.X + DragStartArea.Width \ 2, e.Y + DragStartArea.Height \ 2)
			DragStartArea = Rectangle.Empty
			If (Not hitInfo.InRow) Then
				Return
			End If
			Dim appointment As CustomAppointment = CType(Storage.CreateAppointment(AppointmentType.Normal), CustomAppointment)
			appointment.ObjectForInsert = View.GetRow(hitInfo.RowHandle)
			appointment.Subject = View.GetRowCellDisplayText(hitInfo.RowHandle, colSubject)
			Grid.DoDragDrop(New SchedulerDragData(appointment), DragDropEffects.All)
		End Sub

		Private Sub OnGridMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles View.MouseUp
			DragStartArea = Rectangle.Empty
		End Sub

		Private Sub OnGridShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs) Handles View.ShowingEditor
			e.Cancel = View.FocusedRowHandle <> GridControl.NewItemRowHandle
		End Sub
	End Class
End Namespace
