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
    public partial class ModelCard : Form
    {

        public string Model_ID;

        public ModelCard()
        {
            InitializeComponent();
        }

       
        private void ModelCard_Load(object sender, EventArgs e)
        {
            LoadComboBoxes(cmb_Manufacturer, Queries.ManufacturerList);
            LoadData();
         
        }


        /// <summary>
        /// Зарежда combo_box с дадена заявка
        /// </summary>
        /// <param name="combo_Box"></param>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        private void LoadComboBoxes(RadDropDownList combo_Box, string query, params Object[] parameter)
        {

            DataTable dt = DbUtil.getDataTable(query, parameter);

            combo_Box.ValueMember = dt.Columns[0].MakeString();
            combo_Box.DisplayMember = dt.Columns[1].MakeString();
            combo_Box.Width = 200;
            combo_Box.DataSource = dt;
           // combo_Box.Rebind();

        }

        /// <summary>
        /// Зарежда данните
        /// </summary>
        private void LoadData()
        {
            if (!String.IsNullOrEmpty(Model_ID))
            {

                WhereClause where = new WhereClause();

                if (Model_ID == "-1")
                {
                    
                    where.Add(Model_table.Model_ID, -1);
                }
                else
                {

                    txt_Model_ID.Text = Model_ID;

                    where.Add(Model_table.Model_ID, Model_ID);
                }



                DataTable dt = DbUtil.getDataTableForTableName(Model_table.db_name, null, 0, where);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];


                    txt_Model_Name.Text = dr[Model_table.Name].MakeString();
                    if (cmb_Manufacturer.Items.Count>0)
                    {
                        cmb_Manufacturer.SelectedValue = dr[Model_table.Manufacturer_ID].MakeLong();
                    }
                    if (!String.IsNullOrEmpty(dr[Model_table.Production_Date].MakeString()))
                    {
                        date_picker_Prod_Date.Value = Convert.ToDateTime(dr[Model_table.Production_Date].MakeString());
                    }
                  
                  
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            NavBar.Navigate(new Models(), this.Parent);
            this.Close();
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
            NavBar.Navigate(new Models(), this.Parent);
            
            this.Close();
        }


        

        /// <summary>
        /// Променя или инсъртва ред
        /// </summary>
        private void Save()
        {
            DataTable dt = new DataTable();
            WhereClause where = new WhereClause();

            if (!String.IsNullOrEmpty(Model_ID) )
            {
                where.Add(Model_table.Model_ID, Model_ID);
            }
            else
            {
                where.Add(Model_table.Model_ID, -1);
            }

            dt = DbUtil.getDataTableForTableName(Model_table.db_name, null, 0, where);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];


                row[Model_table.Manufacturer_ID] = cmb_Manufacturer.SelectedValue;
                row[Model_table.Name] = txt_Model_Name.Text;
                row[Model_table.Production_Date] = date_picker_Prod_Date.Value;


            }
            else
            {
                DataRow row = dt.NewRow();
                row[Model_table.Manufacturer_ID] = cmb_Manufacturer.SelectedValue;
                row[Model_table.Name] = txt_Model_Name.Text;
                row[Model_table.Production_Date] = date_picker_Prod_Date.Value;
                dt.Rows.Add(row);
            }



            int result = DbUtil.saveChanges(Model_table.db_name, dt);

            if (result != 0)
            {
                MessageBox.Show("Записът беше запаметен!");
            }



        }
    }
}
