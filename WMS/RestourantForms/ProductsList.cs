using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Library.DB;

namespace WMS.RestourantForms
{
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            DataTable dt = DbUtil.getDataTable(Queries_Lists.ProductsList);

            // radGridView2.DataSource = dt;
            ProductsBindingSource.DataSource = dt;
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {

            if (MasterTemplate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Изберете ред!");
                return;
            }
            ProductCard ic = new ProductCard();

           // ic.Item_ID = radGridView1.SelectedRows[0].Cells[Item_table.Item_ID].Value.MakeString();

            NavBar.Navigate(ic, Globals.GetParent(this.Parent.Parent), this);
            Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
