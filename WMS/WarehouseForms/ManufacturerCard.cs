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
    public partial class ManufacturerCard : Form
    {
        public string Manufacturer_ID;        
        private Dictionary<string, string> initialData = new Dictionary<string,string>();
        private Dictionary<string, string> closingData = new Dictionary<string,string>();

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
                    
                    initialData = Globals.FillDictionary(this.radPanel1);
                }
                    
            }
        }

        private void Save()
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
        }

        private bool CheckDataModified(Dictionary<string, string> initial, Dictionary<string, string> closing)
        {
            bool dataIsChanged = false;

            for (int i = 0; i < initial.Count; i++)
            {
                if (initial.ElementAt(i).ToString() != closing.ElementAt(i).ToString())
                {
                    dataIsChanged = true;
                    return (dataIsChanged);
                }
            }

            return(dataIsChanged);
        }

        private Dictionary<string, string> FillDictionary()
        {
             Dictionary<string, string> dict = new Dictionary<string,string>();

             foreach (Control c in radPanel1.Controls)
                    {
                        if (c is RadTextBox || c is TextBox)
                        {
                            dict.Add(c.Name, c.Text);
                        }

                        if (c is ComboBox)
                        {
                        }

                        if (c is RadioButton)
                        {

                        }
                    }
            return(dict);
        }        

        private void btn_Back_Click(object sender, EventArgs e)
        {
            closingData = Globals.FillDictionary(this.radPanel1);

            if (CheckDataModified(initialData, closingData) == true)
            {
                DialogResult dialogResult = MessageBox.Show("Записът е бил променен. Сигурни ли сте, че искате да запазите промените?", "Съобщение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Save();
                    MessageBox.Show("Записът беше запаметен!");

                    NavBar.Navigate(new Manufacturers(), this.Parent);
                    this.Close();
                    
                }
                else
                {                    
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
