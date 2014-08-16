using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.WarehouseForms
{
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();
        }

        private void Models_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.dataSet.Model);
            // TODO: This line of code loads data into the 'dataSet1.Model' table. You can move, or remove it, as needed.
      

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ModelCard mc = new ModelCard();
            mc.TopLevel = false;
            mc.Dock = DockStyle.Fill;
            mc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mc.Parent = this;
            mc.WindowState = FormWindowState.Maximized;
            mc.Show();
           
        }
    }
}
