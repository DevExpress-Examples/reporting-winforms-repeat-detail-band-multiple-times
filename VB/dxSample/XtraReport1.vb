Imports DevExpress.XtraReports.UI

Namespace dxSample

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private currentDetail As Integer = 1

        Private Sub xrLabel5_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            CType(sender, XRLabel).Text = currentDetail.ToString() & "/" & DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource.ToString()
            currentDetail += 1
        End Sub

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            currentDetail = 1
            DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource = CInt(GetCurrentColumnValue("CategoryID"))
        End Sub
    End Class
End Namespace
