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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dataSet1.item);

        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Изберете ред!");
                return;
            }
            ItemCard ic = new ItemCard();

            ic.Item_ID = radGridView1.SelectedRows[0].Cells[Item_table.Item_ID].Value.MakeString();

            NavBar.Navigate(ic, Globals.GetParent(this.Parent));
            Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            ItemCard ic = new ItemCard();
            ic.Item_ID = "-1";
            NavBar.Navigate(ic, Globals.GetParent(this.Parent));

            Close();
        }
    }
}
