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
    public partial class BinCard : Form
    {
        public string Bin_ID;
        public BinCard()
        {
            InitializeComponent();
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);


            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radPanel1));
            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(lbl_Title));
        }

        private void BinCard_Load(object sender, EventArgs e)
        {
            Build.LoadComboBoxes(ref cmb_Location_ID, Queries.Locations);
            LoadData();
        }

        /// <summary>
        /// Зарежда данните
        /// </summary>
        private void LoadData()
        {
            if (!String.IsNullOrEmpty(Bin_ID))
            {

                WhereClause where = new WhereClause();

                if (Bin_ID == "-1")
                {

                    where.Add(Bin_table.Bin_ID, -1);
                }
                else
                {

                    txt_Bin_ID.Text = Bin_ID;

                    where.Add(Bin_table.Bin_ID, Bin_ID);
                }



                DataTable dt = DbUtil.getDataTableForTableName(Bin_table.db_name, null, 0, where);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];


                    txt_Description.Text = dr[Bin_table.Description].MakeString();
                    txt_Lenght.Text = dr[Bin_table.Length].MakeString();
                    txt_Height.Text = dr[Bin_table.Height].MakeString();
                    txt_Width.Text = dr[Bin_table.Width].MakeString();
                    txt_Max_Weight.Text = dr[Bin_table.Max_Weight].MakeString();
                    if (cmb_Location_ID.Items.Count > 0)
                    {
                        cmb_Location_ID.SelectedValue = dr[Bin_table.Location_ID].MakeLong();
                    }
                   


                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            NavBar.Navigate(new Bin(), this.Parent.Parent.Parent.Parent, this);
            this.Close();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
            NavBar.Navigate(new Bin(), this.Parent.Parent.Parent.Parent, this);

            this.Close();
        }




        /// <summary>
        /// Променя или инсъртва ред
        /// </summary>
        private void Save()
        {
            DataTable dt = new DataTable();
            WhereClause where = new WhereClause();

            if (!String.IsNullOrEmpty(Bin_ID))
            {
                where.Add(Bin_table.Bin_ID, Bin_ID);
            }
            else
            {
                where.Add(Bin_table.Bin_ID, -1);
            }

            dt = DbUtil.getDataTableForTableName(Bin_table.db_name, null, 0, where);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                row[Bin_table.Location_ID] = cmb_Location_ID.SelectedValue;
                row[Bin_table.Length] = txt_Lenght.Text;
                row[Bin_table.Description] = txt_Description.Text;
                row[Bin_table.Width] = txt_Width.Text;
                row[Bin_table.Height] = txt_Height.Text;
                row[Bin_table.Length] = txt_Lenght.Text;
                row[Bin_table.Max_Weight] = txt_Max_Weight.Text;
            }
            else
            {
                DataRow row = dt.NewRow();

                row[Bin_table.Location_ID] = cmb_Location_ID.SelectedValue;
                row[Bin_table.Length] = txt_Lenght.Text;
                row[Bin_table.Description] = txt_Description.Text;
                row[Bin_table.Width] = txt_Width.Text;
                row[Bin_table.Height] = txt_Height.Text;
                row[Bin_table.Length] = txt_Lenght.Text;
                row[Bin_table.Max_Weight] = txt_Max_Weight.Text;

                dt.Rows.Add(row);
            }



            int result = DbUtil.saveChanges(Bin_table.db_name, dt);

            if (result != 0)
            {
                MessageBox.Show("Записът беше запаметен!");
            }



        }

       
    }
}
