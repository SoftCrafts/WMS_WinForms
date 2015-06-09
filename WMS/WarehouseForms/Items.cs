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
          //  this.itemTableAdapter.Fill(this.dataSet1.item);
            DataTable dt = DbUtil.getDataTableForTableName(Item_table.db_name, null, 0);
            itemBindingSource.DataSource = dt;
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

            NavBar.Navigate(ic, Globals.GetParent(this.Parent.Parent),this);
            Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            ItemCard ic = new ItemCard();
            ic.Item_ID = "-1";
            NavBar.Navigate(ic, Globals.GetParent(this.Parent.Parent),this);

            Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Изберете ред!");
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Сигурни ли сте,че искате да изтриете този запис?", "Съобщение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                List<string> list = new List<string>();
                list.Add(radGridView1.SelectedRows[0].Cells[Item_table.Item_ID].Value.MakeString());
                WhereClause where = new WhereClause();
                where.Add(Item_table.Item_ID, list.ToArray());
                int res = DbUtil.delete(Item_table.db_name, where);
                if (res != 0)
                {
                    MessageBox.Show("Записът беше изтрит!");
                 //   this.itemTableAdapter.Fill(this.dataSet1.item);
                }
            }

        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {

        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
           
            ReportViewer_FORM barcode_report = new ReportViewer_FORM();
            barcode_report.repName = "Item_Barcode";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(Item_table.Item_ID, radGridView1.SelectedRows[0].Cells[Item_table.Item_ID].Value.MakeString());
            barcode_report.rep_parameters = parameters;
            barcode_report.Text = "Справка - Баркод Артикул";
            NavBar.Navigate(barcode_report, Globals.GetParent(this.Parent.Parent), this,true);
        }
    }
}
