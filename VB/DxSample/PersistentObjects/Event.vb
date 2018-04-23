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

        Private fStartTime As Date
        Public Property StartTime() As Date
            Get
                Return fStartTime
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("StartTime", fStartTime, value)
            End Set
        End Property

        Private fEndTime As Date
        Public Property EndTime() As Date
            Get
                Return fEndTime
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("EndTime", fEndTime, value)
            End Set
        End Property
    End Class
End Namespace
