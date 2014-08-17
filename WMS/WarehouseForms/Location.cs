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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.dataSet.Location);

        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Изберете ред!");
                return;
            }
            LocationCard mc = new LocationCard();

            mc.Location_ID = radGridView1.SelectedRows[0].Cells[Location_table.Location_ID].Value.MakeString();

            NavBar.Navigate(mc, GetParent(this.Parent));
            Close();

        }

        private void btn_New_Click(object sender, EventArgs e)
        {

            LocationCard mc = new LocationCard();
            mc.Location_ID = "-1";
            NavBar.Navigate(mc, GetParent(this.Parent));

            Close();

        }


        /// <summary>
        /// Рекурсивно взима родителя докато намери Панела на главната страница.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private Control GetParent(Control obj)
        {

            if (obj.Parent.GetType().BaseType.Name == "RadForm")
            {
                return obj;
            }
            else
            {
                return GetParent(obj.Parent);
            }

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
                list.Add(radGridView1.SelectedRows[0].Cells[Location_table.Location_ID].Value.MakeString());
                WhereClause where = new WhereClause();
                where.Add(Location_table.Location_ID, list.ToArray());
                int res = DbUtil.delete(Location_table.db_name, where);
                if (res > 0)
                {
                    MessageBox.Show("Записът беше изтрит!");
                    this.locationTableAdapter.Fill(this.dataSet.Location);
                }
            }



        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);


            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radPanel1));
            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(lbl_Title));

        }
    }
}
