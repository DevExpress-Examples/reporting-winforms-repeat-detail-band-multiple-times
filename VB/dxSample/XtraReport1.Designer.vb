Namespace dxSample

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dxSample.XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 13F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            AddHandler Me.Detail.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.Detail_BeforePrint)
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind.mdb"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Categories.CategoryID]")})
            Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(178.9583F, 31.66667F)
            Me.xrLabel5.StyleName = "DataField"
            Me.xrLabel5.StylePriority.UseBorders = False
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.Text = "xrLabel5"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            AddHandler Me.xrLabel5.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrLabel5_BeforePrint)
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Categories.CategoryName]")})
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(178.9583F, 0F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(471.0417F, 31.66667F)
            Me.xrLabel6.StyleName = "DataField"
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            Me.xrLabel6.Text = "xrLabel6"
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportFooter})
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel6, Me.xrLabel5})
            Me.Detail1.HeightF = 32.29167F
            Me.Detail1.Name = "Detail1"
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1})
            Me.ReportFooter.HeightF = 3.000001F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 3.000001F)
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(264.5834F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(385.4167F, 24.04167F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "Categories repeated by the Category ID value"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2})
            Me.PageHeader.HeightF = 31.66667F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((208)))))), (CInt(((CByte((233)))))), (CInt(((CByte((238)))))))
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 14F)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(178.9583F, 31.66667F)
            Me.xrLabel3.StyleName = "DataField"
            Me.xrLabel3.StylePriority.UseBackColor = False
            Me.xrLabel3.StylePriority.UseBorders = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.Text = "Record number"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((208)))))), (CInt(((CByte((233)))))), (CInt(((CByte((238)))))))
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(178.9583F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(471.0417F, 31.66667F)
            Me.xrLabel2.StyleName = "DataField"
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "Category Name"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportHeader.HeightF = 25F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.PageHeader, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "18.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle

        Private DataField As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    End Class
End Namespace
