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
    public partial class ItemJournalHeader : Form
    {
        public ItemJournalHeader()
        {
            InitializeComponent();
        }

        private void ItemJournalHeader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.item_journal_header' table. You can move, or remove it, as needed.
            this.item_journal_headerTableAdapter.Fill(this.dataSet1.item_journal_header);

        }
    }
}
