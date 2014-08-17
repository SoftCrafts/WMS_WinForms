using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WMS.WarehouseForms
{
    public partial class ItemCard : Form
    {
        public string Item_ID;

        public ItemCard()
        {
            InitializeComponent();
        }

        private void ItemCard_Load(object sender, EventArgs e)
        {            
            Build.LoadComboBoxes(ref cmb_Item_Type, Queries.ItemTypes);
            Build.LoadComboBoxes(ref cmb_Manufacturer, Queries.ManufacturerList);
            Build.LoadComboBoxes(ref cmb_Model, Queries.Models, Item_table.Manufacturer_ID);
            Build.LoadComboBoxes(ref cmb_UoM, Queries.UnitsOfMeasure);
            Build.LoadComboBoxes(ref cmb_Location, Queries.Locations);
            Build.LoadComboBoxes(ref cmb_Bin, Queries.Bins);
            Build.LoadComboBoxes(ref cmb_Purch_Price_Currency, Queries.Currencies);
            Build.LoadComboBoxes(ref cmb_Sales_Price_Currency, Queries.Currencies);
            LoadData();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radPanel1));
            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(lbl_Title));
        }


        /// <summary>
        /// Зарежда данните
        /// </summary>
        private void LoadData()
        {
            if (!String.IsNullOrEmpty(Item_ID))
            {
                WhereClause where = new WhereClause();

                if (Item_ID == "-1")
                {
                    where.Add(Item_table.Item_ID, -1);
                }
                else
                {                    
                    where.Add(Item_table.Item_ID, Item_ID);
                }

                DataTable dt = DbUtil.getDataTableForTableName(Item_table.db_name, null, 0, where);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    txt_Description.Text = dr[Item_table.Description].MakeString();
                    txt_No.Text = dr[Item_table.No].MakeString();
                    if (cmb_Item_Type.Items.Count > 0)
                    {
                        cmb_Item_Type.SelectedValue = dr[Item_table.Item_Type].MakeLong();
                    }                    
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            NavBar.Navigate(new Location(), this.Parent);
            this.Close();
        }

        /*
        /// <summary>
        /// Променя или инсъртва ред
        /// </summary>
        private void Save()
        {
            DataTable dt = new DataTable();
            WhereClause where = new WhereClause();

            if (!String.IsNullOrEmpty(Location_ID))
            {
                where.Add(Location_table.Location_ID, Location_ID);
            }
            else
            {
                where.Add(Location_table.Location_ID, -1);
            }

            dt = DbUtil.getDataTableForTableName(Location_table.db_name, null, 0, where);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                row[Location_table.User_ID] = cmb_Responsible_Person.SelectedValue;
                row[Location_table.Address] = txt_Address.Text;
                row[Location_table.Name] = txt_Name.Text;
                row[Location_table.Require_Bin] = chk_Req_Bin.Checked == true ? 1 : 0;
            }
            else
            {
                DataRow row = dt.NewRow();

                row[Location_table.User_ID] = cmb_Responsible_Person.SelectedValue;
                row[Location_table.Address] = txt_Address.Text;
                row[Location_table.Name] = txt_Name.Text;
                row[Location_table.Require_Bin] = chk_Req_Bin.Checked == true ? 1 : 0;

                dt.Rows.Add(row);
            }

            int result = DbUtil.saveChanges(Location_table.db_name, dt);
        }
        */
    }
}
