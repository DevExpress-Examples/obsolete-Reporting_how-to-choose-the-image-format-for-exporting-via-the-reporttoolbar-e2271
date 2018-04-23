Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.Web
' ...

Namespace ImageExportReportToolbar
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub ReportToolbar1_Init(ByVal sender As Object, ByVal e As EventArgs)

			Dim myItem As ReportToolbarComboBox = CType(Me.ReportToolbar1.Items(16), ReportToolbarComboBox)

			myItem.Elements(7).Text = "PNG Image"

			myItem.Elements.Add(New ListElement("bmp"))
			myItem.Elements(8).Text = "BMP Image"

			myItem.Elements.Add(New ListElement("gif"))
			myItem.Elements(9).Text = "GIF Image"

			myItem.Elements.Add(New ListElement("jpg"))
			myItem.Elements(10).Text = "JPG Image"

			myItem.Elements.Add(New ListElement("tiff"))
			myItem.Elements(11).Text = "TIFF Image"
		End Sub
	End Class
End Namespace
