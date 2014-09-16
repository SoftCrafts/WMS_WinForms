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

namespace WMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btn_Login.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Authentificate();
        }
        private void Authentificate()
        {
            WhereClause where = new WhereClause();
            where.Add(Users_Table.Username, cmb_User.SelectedValue.MakeString());
            string endPass = encr.Encrypt(txt_Password.Text, cmb_User.SelectedValue.MakeString(), "salt", "SHA1", 2, "16CHARSLONG12345", 256); //енкриптва паролата
            where.Add(Users_Table.Password, endPass);
           
            DataTable dt = DbUtil.getDataTableForTableName(Users_Table.db_name, null, 0, where);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Globals.UserName = dr[Users_Table.Username].MakeString();
                Globals.FullName = dr[Users_Table.Full_Name].MakeString();
                

               // lbl_name.Text = Globals.FullName;
              
              

                Form parent = (Form)this.Parent.Parent;
                RadMenu menu = (RadMenu)parent.Controls["RadMenu1"];
                RadPanel sidepanel = (RadPanel)parent.Controls["radPanel2"];
                LinkLabel lbl_fullname = (LinkLabel)sidepanel.Controls["lbl_fullname"];
                lbl_fullname.Text = Globals.FullName;
                menu.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Грешен потребил или парола!");
                txt_Password.Text = String.Empty;
            }
          
        }

        private void OnEnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Authentificate();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Build.LoadComboBoxes(ref cmb_User, Queries.UserIds_Login);
        }
    }
}
