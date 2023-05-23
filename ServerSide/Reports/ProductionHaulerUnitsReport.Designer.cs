
namespace ServerSide.Reports
{
    partial class ProductionHaulerUnitsReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionHaulerUnitsReport));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.logo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label14 = new DevExpress.XtraReports.UI.XRLabel();
            this.label15 = new DevExpress.XtraReports.UI.XRLabel();
            this.label27 = new DevExpress.XtraReports.UI.XRLabel();
            this.label26 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.label11 = new DevExpress.XtraReports.UI.XRLabel();
            this.label13 = new DevExpress.XtraReports.UI.XRLabel();
            this.label12 = new DevExpress.XtraReports.UI.XRLabel();
            this.label18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.logo,
            this.label1,
            this.label14,
            this.label15,
            this.label27,
            this.label26});
            this.TopMargin.HeightF = 171.1667F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // logo
            // 
            this.logo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("logo.ImageSource"));
            this.logo.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.logo.Name = "logo";
            this.logo.SizeF = new System.Drawing.SizeF(175.3857F, 101.875F);
            this.logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(503.5883F, 10.00001F);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(295.7179F, 34.45834F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Hauler Units Report";
            // 
            // label14
            // 
            this.label14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 146.3747F);
            this.label14.Multiline = true;
            this.label14.Name = "label14";
            this.label14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label14.SizeF = new System.Drawing.SizeF(124.1544F, 24.79197F);
            this.label14.StylePriority.UseBorders = false;
            this.label14.StylePriority.UseFont = false;
            this.label14.StylePriority.UsePadding = false;
            this.label14.StylePriority.UseTextAlignment = false;
            this.label14.Text = "Hauler Unit:";
            this.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[equipmentId]")});
            this.label15.LocationFloat = new DevExpress.Utils.PointFloat(134.1544F, 146.3747F);
            this.label15.Multiline = true;
            this.label15.Name = "label15";
            this.label15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label15.SizeF = new System.Drawing.SizeF(175F, 24.79198F);
            this.label15.StylePriority.UseTextAlignment = false;
            this.label15.Text = "label6";
            this.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?tenantid")});
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.LocationFloat = new DevExpress.Utils.PointFloat(577.9412F, 44.45836F);
            this.label27.Multiline = true;
            this.label27.Name = "label27";
            this.label27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.label27.SizeF = new System.Drawing.SizeF(221.3651F, 21.08336F);
            this.label27.StylePriority.UseFont = false;
            this.label27.StylePriority.UsePadding = false;
            this.label27.StylePriority.UseTextAlignment = false;
            this.label27.Text = "Paygroup";
            this.label27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.LocationFloat = new DevExpress.Utils.PointFloat(503.5883F, 44.45836F);
            this.label26.Multiline = true;
            this.label26.Name = "label26";
            this.label26.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label26.SizeF = new System.Drawing.SizeF(74.35289F, 21.08334F);
            this.label26.StylePriority.UseFont = false;
            this.label26.StylePriority.UsePadding = false;
            this.label26.StylePriority.UseTextAlignment = false;
            this.label26.Text = "COMPANY:";
            this.label26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.label10,
            this.label4,
            this.xrLabel2,
            this.label11,
            this.label13,
            this.label12,
            this.label18});
            this.GroupHeader1.HeightF = 38.20828F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // label10
            // 
            this.label10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(314.7632F, 9.536743E-05F);
            this.label10.Multiline = true;
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label10.SizeF = new System.Drawing.SizeF(140.4074F, 36.12529F);
            this.label10.StylePriority.UseBorders = false;
            this.label10.StylePriority.UseFont = false;
            this.label10.StylePriority.UsePadding = false;
            this.label10.StylePriority.UseTextAlignment = false;
            this.label10.Text = "DESCRIPTION";
            this.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(234.375F, 9.536743E-05F);
            this.label4.Multiline = true;
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label4.SizeF = new System.Drawing.SizeF(80.38818F, 36.12528F);
            this.label4.StylePriority.UseBorders = false;
            this.label4.StylePriority.UseFont = false;
            this.label4.StylePriority.UsePadding = false;
            this.label4.StylePriority.UseTextAlignment = false;
            this.label4.Text = "EQUIPMENT \r\n        ID";
            this.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(201.0416F, 9.536743E-05F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(33.33339F, 36.12527F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "#";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.LocationFloat = new DevExpress.Utils.PointFloat(455.1706F, 0F);
            this.label11.Multiline = true;
            this.label11.Name = "label11";
            this.label11.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label11.SizeF = new System.Drawing.SizeF(186.5304F, 36.12529F);
            this.label11.StylePriority.UseBorders = false;
            this.label11.StylePriority.UseFont = false;
            this.label11.StylePriority.UsePadding = false;
            this.label11.StylePriority.UseTextAlignment = false;
            this.label11.Text = "SERIAL NUMBER";
            this.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label13
            // 
            this.label13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.LocationFloat = new DevExpress.Utils.PointFloat(641.701F, 0F);
            this.label13.Multiline = true;
            this.label13.Name = "label13";
            this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label13.SizeF = new System.Drawing.SizeF(114.5429F, 36.1253F);
            this.label13.StylePriority.UseBorders = false;
            this.label13.StylePriority.UseFont = false;
            this.label13.StylePriority.UsePadding = false;
            this.label13.StylePriority.UseTextAlignment = false;
            this.label13.Text = "MANUFACTURE \r\n       DATE";
            this.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.LocationFloat = new DevExpress.Utils.PointFloat(756.2439F, 0F);
            this.label12.Multiline = true;
            this.label12.Name = "label12";
            this.label12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label12.SizeF = new System.Drawing.SizeF(93.7561F, 36.12529F);
            this.label12.StylePriority.UseBorders = false;
            this.label12.StylePriority.UseFont = false;
            this.label12.StylePriority.UsePadding = false;
            this.label12.StylePriority.UseTextAlignment = false;
            this.label12.Text = "PURCHASE\r\n    DATE";
            this.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.label18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label18.Multiline = true;
            this.label18.Name = "label18";
            this.label18.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label18.SizeF = new System.Drawing.SizeF(201.0416F, 36.12529F);
            this.label18.StylePriority.UseBorders = false;
            this.label18.StylePriority.UseFont = false;
            this.label18.StylePriority.UsePadding = false;
            this.label18.StylePriority.UseTextAlignment = false;
            this.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.082999F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(149.1381F, 34.04229F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Bactch ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ProductionHaulerUnitsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 171, 100);
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPictureBox logo;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRLabel label14;
        private DevExpress.XtraReports.UI.XRLabel label15;
        private DevExpress.XtraReports.UI.XRLabel label27;
        private DevExpress.XtraReports.UI.XRLabel label26;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label13;
        private DevExpress.XtraReports.UI.XRLabel label12;
        private DevExpress.XtraReports.UI.XRLabel label18;
    }
}
