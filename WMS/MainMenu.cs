using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
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

        private void menu_Items_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Items());
        }

       /// <summary>
       /// Показва подчинени прозорци
       /// </summary>
       /// <param name="form"></param>
        private void ShowChildForm(Form form)
        {
          

           
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Parent = this;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //radPanel1.Controls.Add(form);
        
            foreach (HostWindow item in radDock1.GetWindows<HostWindow>())
            {
                if (item.Text == form.Text )
                {
                    item.Close();
                }
            }
            this.radDock1.DockControl(form, DockPosition.Fill,DockType.Document);
        
            form.Show();
          
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radDock1));
         //   e.Graphics.DrawRectangle(Pens.GreenYellow, Globals.CreateBorderRect(radPanel2));

        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Location());
        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Bin());
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ItemOperations());
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

         
            if (String.IsNullOrEmpty(Globals.UserName))
            {
                radMenu1.Visible = false;
                ShowChildForm(new Login());
            }
        }

        public void SetLabels()
        {

        }

        private void lbl_fullname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowChildForm(new UserCard());
        }

      
        private void radPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

      

        private void ItemListReport_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ReportViewer_FORM());
        }

        
    }
}
