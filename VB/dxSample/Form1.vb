Imports System
Imports DevExpress.XtraReports.UI

Namespace dxSample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Call ShowReportPreview()
        End Sub

        Private Shared Sub ShowReportPreview()
            Call New ReportPrintTool(New XtraReport1()).ShowPreview()
        End Sub
    End Class
End Namespace
