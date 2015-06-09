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
         //   this.item_journal_headerTableAdapter.Fill(this.dataSet1.item_journal_header);

        }

        private void MasterTemplate_RowsChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
            MessageBox.Show(e.Action.MakeString());
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Add)
            {
                WhereClause where = new WhereClause();
                where.Add(Item_Journal_Header_Table.Item_Journal_Header_ID, -1);
                DataTable dt = DbUtil.getDataTableForTableName(Item_Journal_Header_Table.db_name, null, 0, where);
                if (dt.Rows.Count > 0)
                {
                    return;
                }
                DataRow dr = dt.NewRow();

                dr[Item_Journal_Header_Table.Item_Journal_Header_Name] = e.GridViewTemplate.Rows[0].Cells[Item_Journal_Header_Table.Item_Journal_Header_Name].Value;
                dr[Item_Journal_Header_Table.User_ID] = Globals.UserName;



            }

        }

        private void MasterTemplate_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            MessageBox.Show(e.Row.Cells[1].Value.MakeString());
        }

        private void MasterTemplate_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            MessageBox.Show("krai");
        }
    }
}
