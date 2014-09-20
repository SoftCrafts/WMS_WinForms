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

            if (cmb_Manufacturer.Items.Count>0)
	        {
		         cmb_Manufacturer.SelectedValue=0;
	        }

            Build.LoadComboBoxes(ref cmb_Model, Queries.Models, cmb_Manufacturer.SelectedValue);
            Build.LoadComboBoxes(ref cmb_UoM, Queries.UnitsOfMeasure);
            Build.LoadComboBoxes(ref cmb_Location, Queries.Locations);
             if (cmb_Location.Items.Count>0)
	        {
		         cmb_Location.SelectedValue=0;
	        }
            Build.LoadComboBoxes(ref cmb_Bin, Queries.Bins,cmb_Location.SelectedValue);
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
                    txt_No.Text = dr[Item_table.Item_ID].MakeString();
                    txt_Purch_Price.Text = dr[Item_table.Purchase_Price].MakeString();
                    txt_Sales_Price.Text = dr[Item_table.Sales_Price].MakeString();
                    txt_Length.Text = dr[Item_table.Length].MakeString();
                    txt_Height.Text = dr[Item_table.Height].MakeString();
                    txt_Weight.Text = dr[Item_table.Weight].MakeString();
                    txt_Width.Text = dr[Item_table.Width].MakeString();
                   

                    if (cmb_Item_Type.Items.Count > 0)
                    {
                        cmb_Item_Type.SelectedValue = dr[Item_table.Item_Type].MakeString();
                    }

                    if (cmb_Bin.Items.Count > 0)
                    {
                        cmb_Bin.SelectedValue = dr[Item_table.Bin_ID].MakeString();
                    }

                    if (cmb_Location.Items.Count > 0)
                    {
                        cmb_Location.SelectedValue = dr[Item_table.Location_ID].MakeString();
                    }

                    if (cmb_Manufacturer.Items.Count > 0)
                    {
                        cmb_Manufacturer.SelectedValue = dr[Item_table.Manufacturer_ID].MakeString();
                    }

                    if (cmb_Model.Items.Count > 0)
                    {
                        cmb_Model.SelectedValue = dr[Item_table.Model_ID].MakeString();
                    }

                    if (cmb_UoM.Items.Count > 0)
                    {
                        cmb_UoM.SelectedValue = dr[Item_table.Unit_of_Measure].MakeString();
                    }

                    if (cmb_Purch_Price_Currency.Items.Count > 0)
                    {
                        cmb_Purch_Price_Currency.SelectedValue = dr[Item_table.Purchase_Price_Currency_Code].MakeString();
                    }

                    if (cmb_Sales_Price_Currency.Items.Count > 0)
                    {
                        cmb_Sales_Price_Currency.SelectedValue = dr[Item_table.Sales_Price_Currency_Code].MakeString();
                    }

                    
                }
            }
        }

       

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            NavBar.Navigate(new Items(), this.Parent.Parent.Parent.Parent, this);
            this.Close();
        }

        private void cmb_Manufacturer_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmb_Manufacturer.Items.Count > 0)
            {
                cmb_Manufacturer.SelectedValue = 0;
            }

            Build.LoadComboBoxes(ref cmb_Model, Queries.Models, cmb_Manufacturer.SelectedValue);
        }

        private void cmb_Location_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmb_Location.Items.Count > 0)
            {
                cmb_Location.SelectedValue = 0;
            }
            Build.LoadComboBoxes(ref cmb_Bin, Queries.Bins, cmb_Location.SelectedValue);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Save();
        }

        
        /// <summary>
        /// Променя или инсъртва ред
        /// </summary>
        private void Save()
        {
            DataTable dt = new DataTable();
            WhereClause where = new WhereClause();

            if (!String.IsNullOrEmpty(Item_ID))
            {
                where.Add(Item_table.Item_ID, Item_ID);
            }
            else
            {
                where.Add(Item_table.Item_ID, -1);
            }

            dt = DbUtil.getDataTableForTableName(Item_table.db_name, null, 0, where);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                row[Item_table.Item_Type] = cmb_Item_Type.SelectedValue.MakeLong();
                row[Item_table.Description] = txt_Description.Text;
                row[Item_table.Manufacturer_ID] = cmb_Manufacturer.SelectedValue.MakeLong();
                row[Item_table.Model_ID] = cmb_Model.SelectedValue.MakeLong();
                row[Item_table.Unit_of_Measure] = cmb_UoM.SelectedValue;
                row[Item_table.Purchase_Price] = txt_Purch_Price.Text.MakeDecimal();
                row[Item_table.Sales_Price] = txt_Sales_Price.Text.MakeDecimal();
                row[Item_table.Purchase_Price_Currency_Code] = cmb_Purch_Price_Currency.SelectedValue;
                row[Item_table.Sales_Price_Currency_Code] = cmb_Sales_Price_Currency.SelectedValue;
                row[Item_table.Location_ID] = cmb_Location.SelectedValue.MakeLong();
                row[Item_table.Bin_ID] = cmb_Bin.SelectedValue.MakeLong();
                row[Item_table.Width] = txt_Width.Text.MakeDecimal();
                row[Item_table.Weight] = txt_Weight.Text.MakeDecimal();
                row[Item_table.Length] = txt_Length.Text.MakeDecimal();
                row[Item_table.Height] = txt_Height.Text.MakeDecimal(); 
           
            }
            else
            {
                DataRow row = dt.NewRow();

                row[Item_table.Item_Type] = cmb_Item_Type.SelectedValue.MakeLong();
                row[Item_table.Description] = txt_Description.Text;
                row[Item_table.Manufacturer_ID] = cmb_Manufacturer.SelectedValue.MakeLong();
                row[Item_table.Model_ID] = cmb_Model.SelectedValue.MakeLong();
                row[Item_table.Unit_of_Measure] = cmb_UoM.SelectedValue;
                row[Item_table.Purchase_Price] = txt_Purch_Price.Text.MakeDecimal();
                row[Item_table.Sales_Price] = txt_Sales_Price.Text.MakeDecimal();
                row[Item_table.Purchase_Price_Currency_Code] = cmb_Purch_Price_Currency.SelectedValue;
                row[Item_table.Sales_Price_Currency_Code] = cmb_Sales_Price_Currency.SelectedValue;
                row[Item_table.Location_ID] = cmb_Location.SelectedValue.MakeLong();
                row[Item_table.Bin_ID] = cmb_Bin.SelectedValue.MakeLong();
                row[Item_table.Width] = txt_Width.Text.MakeDecimal();
                row[Item_table.Weight] = txt_Weight.Text.MakeDecimal(); 
                row[Item_table.Length] = txt_Length.Text.MakeDecimal(); 
                row[Item_table.Height] = txt_Height.Text.MakeDecimal(); 

                dt.Rows.Add(row);
            }

            int result = DbUtil.saveChanges(Item_table.db_name, dt);
        }

       
        
    }
}
