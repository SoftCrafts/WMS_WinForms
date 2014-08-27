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
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Authentificate();
        }
        private void Authentificate()
        {

            Globals.UserID = txt_Username.Text;
     
            Form parent = (Form)this.Parent.Parent;
            RadMenu menu = (RadMenu)parent.Controls["RadMenu1"];
            menu.Visible = true;
            this.Close();
        }
    }
}
