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
        private void Manufacturers_Load(object sender, EventArgs e)
        {
         
          //  this.manufacturerTableAdapter.Fill(this.dataSet1.manufacturer);
            // TODO: This line of code loads data into the 'dataSet1.Model' table. You can move, or remove it, as needed.
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            if (radGridView2.SelectedRows.Count < 1)
            {
                MessageBox.Show("Изберете ред!!");
                return;
            }
            ManufacturerCard mc = new ManufacturerCard();

            mc.Manufacturer_ID = radGridView2.SelectedRows[0].Cells[Manufacturer_table.Manufacturer_ID].Value.MakeString();

            NavBar.Navigate(mc, Globals.GetParent(this.Parent.Parent),this);
            Close();            
        }        

        private void Manufacturers_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.manufacturer' table. You can move, or remove it, as needed.
          // this.manufacturerTableAdapter.Fill(this.dataSet1.manufacturer);
               DataTable dt = DbUtil.getDataTableForTableName(Manufacturer_table.db_name,null,0);

            radGridView2.DataSource = dt;
            manufacturerBindingSource.DataSource = dt;
          
        }

        private void manufacturerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
