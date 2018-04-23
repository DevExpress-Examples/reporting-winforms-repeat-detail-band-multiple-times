using System;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }
        private int currentDetail = 1;
        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Text = currentDetail.ToString() + @"/" + DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource.ToString();
            currentDetail++;
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            currentDetail = 1;
            DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource = (int)GetCurrentColumnValue("CategoryID");
        }
    }
}
