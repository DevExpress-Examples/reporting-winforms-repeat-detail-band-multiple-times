using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            ShowReportPreview();
        }
        private static void ShowReportPreview() {
            new ReportPrintTool(new XtraReport1()).ShowPreview();
        }
    }
}
