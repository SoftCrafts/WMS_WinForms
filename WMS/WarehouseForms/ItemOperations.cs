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
    public partial class ItemOperations : Form
    {
        public ItemOperations()
        {
            InitializeComponent();
        }

        private void ItemOperations_Load(object sender, EventArgs e)
        {
            Build.LoadComboBoxes(ref cmb_Location, Queries.Locations);
            if (cmb_Location.Items.Count > 0)
            {
                cmb_Location.SelectedValue = 0;
            }
            Build.LoadComboBoxes(ref cmb_Bin, Queries.Bins, cmb_Location.SelectedValue);
            Build.LoadComboBoxes(ref cmb_Purch_Price_Currency, Queries.Currencies);
            Build.LoadComboBoxes(ref cmb_Sales_Price_Currency, Queries.Currencies);
        }
    }
}
