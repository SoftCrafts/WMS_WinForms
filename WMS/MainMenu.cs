using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WMS.WarehouseForms;

namespace WMS
{
    public partial class MainMenu : Telerik.WinControls.UI.RadForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

      

        private void radMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.MdiParent = this;
            model.Show();
        }
    }
}
