Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Namespace RepeatDetailBandExample
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Private currentDetail As Integer = 1
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel5_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel5.BeforePrint
			DirectCast(sender, XRLabel).Text &= currentDetail.ToString()
			DirectCast(sender, XRLabel).Text &= "/"
			DirectCast(sender, XRLabel).Text &= DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource.ToString()
			currentDetail += 1
		End Sub

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
			currentDetail = 1
			DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
		End Sub
	End Class
End Namespace
