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
    public partial class Item_Journal : Form
    {
        public Item_Journal()
        {
            InitializeComponent();
        }

        private void Item_Journal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Item_Journal_Header' table. You can move, or remove it, as needed.
            this.item_Journal_HeaderTableAdapter.Fill(this.dataSet.Item_Journal_Header);

        }
    }
}
