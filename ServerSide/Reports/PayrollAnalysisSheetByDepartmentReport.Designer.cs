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
    
    public partial class PayrollAnalysisSheetByDepartmentReport : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "ServerSide.Reports.PayrollAnalysisSheetByDepartmentReport.repx");

            // Controls
            this.topMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("topMarginBand1");
            this.detailBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("detailBand1");
            this.bottomMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("bottomMarginBand1");
            this.GroupFooter1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.GroupFooterBand>("GroupFooter1");
            this.pictureBox2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPictureBox>("pictureBox2");
            this.line3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLine>("line3");
            this.label21 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label21");
            this.line1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLine>("line1");
            this.label19 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label19");
            this.label13 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label13");
            this.label9 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label9");
            this.label3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label3");
            this.label1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label1");
            this.label7 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label7");
            this.label15 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label15");
            this.label22 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label22");
            this.label23 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label23");
            this.label24 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label24");
            this.label16 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label16");
            this.label20 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label20");
            this.label12 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label12");
            this.label11 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label11");
            this.label4 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label4");
            this.label5 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label5");
            this.label6 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label6");
            this.label10 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label10");
            this.label2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label2");
            this.label17 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label17");
            this.label18 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label18");
            this.label45 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label45");
            this.label44 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label44");
            this.label43 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label43");
            this.label28 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label28");
            this.label27 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label27");
            this.label31 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label31");
            this.label32 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label32");
            this.label33 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label33");
            this.label35 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label35");
            this.label38 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label38");
            this.label42 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label42");
            this.pageInfo1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("pageInfo1");
            this.pageInfo3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("pageInfo3");
            this.label25 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label25");
            this.label26 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label26");
            this.label37 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label37");
            this.label36 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label36");
            this.label34 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label34");

            // Parameters
            this.period_param = reportInitializer.GetParameter("period_param");
            this.department_param = reportInitializer.GetParameter("department_param");
            this.salarygrade_parameter = reportInitializer.GetParameter("salarygrade_parameter");

            // Data Sources
            this.sqlDataSource2 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource2");
            this.sqlDataSource1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource1");
        }
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox2;
        private DevExpress.XtraReports.UI.XRLine line3;
        private DevExpress.XtraReports.UI.XRLabel label21;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.XRLabel label19;
        private DevExpress.XtraReports.UI.XRLabel label13;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRLabel label15;
        private DevExpress.XtraReports.UI.XRLabel label22;
        private DevExpress.XtraReports.UI.XRLabel label23;
        private DevExpress.XtraReports.UI.XRLabel label24;
        private DevExpress.XtraReports.UI.XRLabel label16;
        private DevExpress.XtraReports.UI.XRLabel label20;
        private DevExpress.XtraReports.UI.XRLabel label12;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel label17;
        private DevExpress.XtraReports.UI.XRLabel label18;
        private DevExpress.XtraReports.UI.XRLabel label45;
        private DevExpress.XtraReports.UI.XRLabel label44;
        private DevExpress.XtraReports.UI.XRLabel label43;
        private DevExpress.XtraReports.UI.XRLabel label28;
        private DevExpress.XtraReports.UI.XRLabel label27;
        private DevExpress.XtraReports.UI.XRLabel label31;
        private DevExpress.XtraReports.UI.XRLabel label32;
        private DevExpress.XtraReports.UI.XRLabel label33;
        private DevExpress.XtraReports.UI.XRLabel label35;
        private DevExpress.XtraReports.UI.XRLabel label38;
        private DevExpress.XtraReports.UI.XRLabel label42;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo3;
        private DevExpress.XtraReports.UI.XRLabel label25;
        private DevExpress.XtraReports.UI.XRLabel label26;
        private DevExpress.XtraReports.UI.XRLabel label37;
        private DevExpress.XtraReports.UI.XRLabel label36;
        private DevExpress.XtraReports.UI.XRLabel label34;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.Parameters.Parameter period_param;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter department_param;
        private DevExpress.XtraReports.Parameters.Parameter salarygrade_parameter;
    }
}
