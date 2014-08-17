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
    public partial class ManufacturerCard : Form
    {
        public string Manufacturer_ID;
        private object[] initialData;
        private object[] closingData;        

        public ManufacturerCard()
        {
            InitializeComponent();
        }

        private void LoadData(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Manufacturer_ID))
            {

                WhereClause where = new WhereClause();

                if (Manufacturer_ID == "-1")
                {
                    where.Add(Manufacturer_table.Manufacturer_ID, -1);
                }
                else
                {                  
                    where.Add(Manufacturer_table.Manufacturer_ID, Manufacturer_ID);
                }

                DataTable dt = DbUtil.getDataTableForTableName(Manufacturer_table.db_name, null, 0, where);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    txt_Name.Text = dr[Manufacturer_table.Name].MakeString();
                    txt_Country_Code.Text = dr[Manufacturer_table.Country_Code].MakeString();
                    txt_Website.Text = dr[Manufacturer_table.Website].MakeString();

                    initialData = dr.ItemArray; //Записват се стойностите на реда при отваряне на формата.              
                }
                    
            }
        }

        private void Save(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            WhereClause where = new WhereClause();

            if (!String.IsNullOrEmpty(Manufacturer_ID))
            {
                where.Add(Manufacturer_table.Manufacturer_ID, Manufacturer_ID);
            }
            else
            {
                where.Add(Manufacturer_table.Manufacturer_ID, -1);
            }

            dt = DbUtil.getDataTableForTableName(Manufacturer_table.db_name, null, 0, where);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];                
                row[Manufacturer_table.Name] = txt_Name.Text;
                row[Manufacturer_table.Country_Code] = txt_Country_Code.Text;
                row[Manufacturer_table.Website] = txt_Website.Text;
            }
            else
            {
                DataRow row = dt.NewRow();                
                row[Manufacturer_table.Name] = txt_Name.Text;
                row[Manufacturer_table.Country_Code] = txt_Country_Code.Text;
                row[Manufacturer_table.Website] = txt_Website.Text;
                dt.Rows.Add(row);
            }

            DbUtil.saveChanges(Manufacturer_table.db_name, dt);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                closingData = dr.ItemArray;  //Записват се стойностите на реда при всяка промяна.
            }
        }

        private bool CheckDataModified(object[] initial, object[] closing)
        {
            bool dataIsChanged = false;

            for (int i = 0; i < initial.Length; i++)
            {
                if (initial[i].ToString() != closing[i].ToString())
                {
                    dataIsChanged = true;
                    return (dataIsChanged);
                }
            }

            return(dataIsChanged);
        }

        private void RollbackChanges()
        {
            WhereClause where = new WhereClause();
            DataTable dt = new DataTable();            

            if (Manufacturer_ID == "-1")
            {
                where.Add(Manufacturer_table.Manufacturer_ID, -1);
            }
            else
            {
                where.Add(Manufacturer_table.Manufacturer_ID, Manufacturer_ID);
            }

            dt = DbUtil.getDataTableForTableName(Manufacturer_table.db_name, null, 0, where);
            DataRow dr = dt.Rows[0];
            dr.ItemArray = initialData;                                        
            //for (int i = 1; i <= closingData.Length; i++)
            //{
            //    dr.ItemArray[i] = closingData[i];                
            //}                            
            DbUtil.saveChanges(Manufacturer_table.db_name, dt);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {                        
            if (CheckDataModified(initialData, closingData) == true)
            {
                DialogResult dialogResult = MessageBox.Show("Записът е бил променен. Сигурни ли сте, че искате да запазите промените?", "Съобщение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Записът беше запаметен!");

                    NavBar.Navigate(new Manufacturers(), this.Parent);
                    this.Close();
                    
                }
                else
                {
                    RollbackChanges();

                    MessageBox.Show("Записът не беше запаметен!");

                    NavBar.Navigate(new Manufacturers(), this.Parent);
                    this.Close();
                }
            }
            else
            {
                NavBar.Navigate(new Manufacturers(), this.Parent);
                this.Close();
            }            
        }

    }
}
