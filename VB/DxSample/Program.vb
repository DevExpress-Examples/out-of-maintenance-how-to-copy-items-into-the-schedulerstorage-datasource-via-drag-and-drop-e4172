Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.IO

Namespace DxSample
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			Dim provider As New InMemoryDataStore()
			If File.Exists("data.xml") Then
				provider.ReadXml("data.xml")
			End If
			XpoDefault.DataLayer = New SimpleDataLayer(provider)
			Application.Run(New MainForm())
			provider.WriteXml("data.xml")
		End Sub
	End Class
End Namespace
