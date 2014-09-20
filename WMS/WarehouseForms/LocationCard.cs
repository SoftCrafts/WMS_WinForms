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
    public partial class LocationCard : Form
    {

        public string Location_ID;
        public LocationCard()
        {
            InitializeComponent();
        }

        private void LocationCard_Load(object sender, EventArgs e)
        {
            Build.LoadComboBoxes(ref cmb_Responsible_Person, Queries.UserIds);
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
            if (!String.IsNullOrEmpty(Location_ID))
            {

                WhereClause where = new WhereClause();

                if (Location_ID == "-1")
                {

                    where.Add(Location_table.Location_ID, -1);
                }
                else
                {

                    txt_Location_ID.Text = Location_ID;

                    where.Add(Location_table.Location_ID, Location_ID);
                }



                DataTable dt = DbUtil.getDataTableForTableName(Location_table.db_name, null, 0, where);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];


                    txt_Address.Text = dr[Location_table.Address].MakeString();
                    txt_Name.Text = dr[Location_table.Name].MakeString();
                    if (cmb_Responsible_Person.Items.Count > 0)
                    {
                        cmb_Responsible_Person.SelectedValue = dr[Location_table.User_ID].MakeLong();
                    }
                    if (!String.IsNullOrEmpty(dr[Location_table.Require_Bin].MakeString()))
                    {
                        chk_Req_Bin.Checked = dr[Location_table.Require_Bin].MakeString() == "1" ? true : false;
                            
                         
                    }


                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            NavBar.Navigate(new Location(), this.Parent.Parent.Parent.Parent, this);
            this.Close();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
            NavBar.Navigate(new Location(), this.Parent.Parent.Parent.Parent, this);

            this.Close();
        }




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

                if (cmb_Responsible_Person.SelectedValue != null)
                {
                    row[Location_table.User_ID] = cmb_Responsible_Person.SelectedValue;
                }
              
                row[Location_table.Address] = txt_Address.Text;
                row[Location_table.Name] = txt_Name.Text;
                row[Location_table.Require_Bin] = chk_Req_Bin.Checked == true ? 1 : 0;
            }
            else
            {
                DataRow row = dt.NewRow();

                if (cmb_Responsible_Person.SelectedValue != null)
                {
                      row[Location_table.User_ID] = cmb_Responsible_Person.SelectedValue;
                }
              
                row[Location_table.Address] = txt_Address.Text;
                row[Location_table.Name] = txt_Name.Text;
                row[Location_table.Require_Bin] = chk_Req_Bin.Checked == true ? 1 : 0;
                
                dt.Rows.Add(row);
            }



            int result = DbUtil.saveChanges(Location_table.db_name, dt);

            if (result != 0)
            {
                MessageBox.Show("Записът беше запаметен!");
            }



        }

    
    }
}
