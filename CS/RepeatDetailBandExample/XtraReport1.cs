using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace RepeatDetailBandExample
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        private int currentDetail = 1;
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void xrLabel5_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ((XRLabel)sender).Text += currentDetail.ToString();
            ((XRLabel)sender).Text += @"/";
            ((XRLabel)sender).Text += DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource.ToString();
            currentDetail++;
        }

        private void Detail_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            currentDetail = 1;
            DetailReport.ReportPrintOptions.DetailCountOnEmptyDataSource = 
                Convert.ToInt32(GetCurrentColumnValue("CategoryID"));
        }
    }
}
