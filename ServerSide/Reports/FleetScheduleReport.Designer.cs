//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerSide.Reports {
    
    public partial class FleetScheduleReport : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "ServerSide.Reports.FleetScheduleReport.repx");

            // Controls
            this.topMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("topMarginBand1");
            this.detailBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("detailBand1");
            this.bottomMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("bottomMarginBand1");
            this.PageHeader = reportInitializer.GetControl<DevExpress.XtraReports.UI.PageHeaderBand>("PageHeader");
            this.ReportHeader = reportInitializer.GetControl<DevExpress.XtraReports.UI.ReportHeaderBand>("ReportHeader");
            this.label21 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label21");
            this.logo = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPictureBox>("logo");
            this.label12 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label12");
            this.label11 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label11");
            this.label9 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label9");
            this.label6 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label6");
            this.label7 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label7");
            this.label1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label1");
            this.label10 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label10");
            this.pageInfo2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("pageInfo2");
            this.pageInfo1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("pageInfo1");
            this.label5 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label5");
            this.label4 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label4");
            this.label3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label3");
            this.label2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label2");
            this.label23 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label23");
            this.label22 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label22");
            this.label28 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label28");
            this.label17 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label17");
            this.label16 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label16");
            this.label15 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label15");
            this.label13 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label13");
            this.label14 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label14");
            this.label8 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label8");

            // Parameters
            this.location = reportInitializer.GetParameter("location");
            this.custudian = reportInitializer.GetParameter("custudian");
            this.time = reportInitializer.GetParameter("time");

            // Data Sources
            this.sqlDataSource1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource1");
            this.sqlDataSource2 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource2");
            this.sqlDataSource3 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource3");
        }
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label21;
        private DevExpress.XtraReports.UI.XRPictureBox logo;
        private DevExpress.XtraReports.UI.XRLabel label12;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel label23;
        private DevExpress.XtraReports.UI.XRLabel label22;
        private DevExpress.XtraReports.UI.XRLabel label28;
        private DevExpress.XtraReports.UI.XRLabel label17;
        private DevExpress.XtraReports.UI.XRLabel label16;
        private DevExpress.XtraReports.UI.XRLabel label15;
        private DevExpress.XtraReports.UI.XRLabel label13;
        private DevExpress.XtraReports.UI.XRLabel label14;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter location;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.Parameters.Parameter custudian;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraReports.Parameters.Parameter time;
    }
}
