using System;
using DevExpress.XtraReports.UI;

namespace ServerSide.Reports
{
    public partial class EmployeeByGenderReport
    {
        public EmployeeByGenderReport()
        {
            Parameters["Gender"].Visible = false;
            InitializeComponent();
        }
    }
}
