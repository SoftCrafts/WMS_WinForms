using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WMS.WarehouseForms;

namespace WMS
{
    public partial class MainMenu : Telerik.WinControls.UI.RadForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

      

        private void radMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {

            ShowChildForm(new Models());
        }


       /// <summary>
       /// Показва подчинени прозорци
       /// </summary>
       /// <param name="form"></param>
        private void ShowChildForm(Form form)
        {
            foreach (Form frm in radPanel1.Controls)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Close();
                }
            }

           
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            radPanel1.Controls.Add(form);
            form.Show();
  
        
        }
    }
}
