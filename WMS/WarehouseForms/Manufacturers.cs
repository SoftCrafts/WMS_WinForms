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
    public partial class Manufacturers : Form
    {
        public Manufacturers()
        {
            InitializeComponent();
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            ManufacturerCard mc = new ManufacturerCard();
            mc.TopLevel = false;
            mc.Dock = DockStyle.Fill;
            mc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mc.Parent = this;
            mc.WindowState = FormWindowState.Maximized;
            mc.Show();
        }
    }
}
