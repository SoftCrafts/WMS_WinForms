using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WMS.WarehouseForms
{
    public partial class Model : Telerik.WinControls.UI.RadForm
    {
        public Model()
        {
            InitializeComponent();
        }

        private void Model_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.dataSet1.Models);

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
