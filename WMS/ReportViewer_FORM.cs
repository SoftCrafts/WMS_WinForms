using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class ReportViewer_FORM : Form
    {
        public ReportViewer_FORM()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Telerik.Reporting.InstanceReportSource reportSource = new
    Telerik.Reporting.InstanceReportSource();
            reportSource.ReportDocument = new ArtikelList();

           // reportSource.Parameters.Add(new Telerik.Reporting.Parameter("OrderNumber", "123456789"));

            reportViewer1.ReportSource = reportSource;

            reportViewer1.RefreshReport();
        }
    }
}
