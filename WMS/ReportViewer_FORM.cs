using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Reports;

namespace WMS
{
    public partial class ReportViewer_FORM : Form
    {
        public string repName;
        public Dictionary<string, string> rep_parameters;

        public ReportViewer_FORM()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            switch (repName)
            {
                case "Item_List":
                    {
                        Telerik.Reporting.InstanceReportSource reportSource = new
                            Telerik.Reporting.InstanceReportSource();
                        reportSource.ReportDocument = new ArtikelList();

                        

                        reportViewer1.ReportSource = reportSource;

                        reportViewer1.RefreshReport();
                        break;
                    }
                case "Item_Barcode":
                    {
                        Telerik.Reporting.InstanceReportSource reportSource = new
    Telerik.Reporting.InstanceReportSource();
                        reportSource.ReportDocument = new ItemBarcode();
                        foreach (var row in rep_parameters)
                        {
                            reportSource.Parameters.Add(new Telerik.Reporting.Parameter(row.Key,row.Value));
                        }
                       

                        reportViewer1.ReportSource = reportSource;
                        

                        reportViewer1.RefreshReport();

                        break;
                    }

                default:
                    break;
            }


        }
    }
}
