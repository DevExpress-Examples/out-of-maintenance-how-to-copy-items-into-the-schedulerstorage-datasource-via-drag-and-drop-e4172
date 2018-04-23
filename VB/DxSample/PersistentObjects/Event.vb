Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports System

Namespace DxSample.PersistentObjects
	Public Class [Event]
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private fSubject As String
		Public Property Subject() As String
			Get
				Return fSubject
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Subject", fSubject, value)
			End Set
		End Property

		Private fStartTime As DateTime
		Public Property StartTime() As DateTime
			Get
				Return fStartTime
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue(Of DateTime)("StartTime", fStartTime, value)
			End Set
		End Property

		Private fEndTime As DateTime
		Public Property EndTime() As DateTime
			Get
				Return fEndTime
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue(Of DateTime)("EndTime", fEndTime, value)
			End Set
		End Property
	End Class
End Namespace
