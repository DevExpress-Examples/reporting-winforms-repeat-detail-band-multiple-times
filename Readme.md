<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603106/14.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T210911)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/dxSample/Form1.cs) (VB: [Form1.vb](./VB/dxSample/Form1.vb))
* [Program.cs](./CS/dxSample/Program.cs) (VB: [Program.vb](./VB/dxSample/Program.vb))
* **[XtraReport1.cs](./CS/dxSample/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/dxSample/XtraReport1.vb))**
<!-- default file list end -->
# How to repeat the Detail report band multiple times (a data-bound report)


If your report's data source is empty or not defined, you can <strong>specify</strong> how many times the Detail band content is printed through the <strong><a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIReportPrintOptions_DetailCountOnEmptyDataSourcetopic">XtraReport.PrintOptions.DetailCountOnEmptyDataSource</a></strong> property.<br><br>If a report is<strong> data bound</strong>, you can <strong>limit </strong>the number of times the Detail band is printed by using the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIReportPrintOptions_DetailCounttopic.aspx">DetailCount</a> property.<br><br>Please note that the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIReportPrintOptions_DetailCounttopic.aspx">DetailCount</a> property is designed to specify the maximum number (i.e., the limit) of times the Detail band is printed. In other words, if a data source contains one record, we cannot print it more than one time by using the <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIReportPrintOptions_DetailCounttopic.aspx">DetailCount</a> property. <br>We need to use the solution illustrated by this example. It demonstrates how to repeat a data source record depending on a value taken from another field. To achieve this, add an unbound <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIDetailReportBandtopic">DetailReportBand</a> and control the number of copies using its <strong><a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIReportPrintOptions_DetailCountOnEmptyDataSourcetopic">ReportPrintOptions.DetailCountOnEmptyDataSource</a></strong> property.<br><br>See also: <br><strong><a href="https://www.devexpress.com/Support/Center/p/E3740">How to print DetailBand a particular amount of times irregardless of the number of records in a report datasource</a></strong>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-repeat-detail-band-multiple-times&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-repeat-detail-band-multiple-times&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
