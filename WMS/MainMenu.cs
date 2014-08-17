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
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void menu_Manufacturers_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Manufacturers());
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

                if (frm!=null)
                {
                    
                }
                    frm.Close();
             
            }

           
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Parent = this;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            radPanel1.Controls.Add(form);
            form.Show();
          
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radPanel1));
            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radPanel2));

        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Location());
        }

        
    }
}
