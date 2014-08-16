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

            this.modelTableAdapter.Fill(this.dataSet.Model);
            // TODO: This line of code loads data into the 'dataSet1.Model' table. You can move, or remove it, as needed.


        }



        private void btn_Card_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Изберете ред!");
                return;
            }
            ModelCard mc = new ModelCard();

            mc.Model_ID = radGridView1.SelectedRows[0].Cells[Model_table.Model_ID].Value.MakeString();

            NavBar.Navigate(mc, GetParent(this.Parent));
            Close();

        }

        private void btn_New_Click(object sender, EventArgs e)
        {

            ModelCard mc = new ModelCard();
            mc.Model_ID = "-1";
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
    }
}
