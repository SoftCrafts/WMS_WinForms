using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;

namespace WMS
{
    /// <summary>
    /// Клас за навигация
    /// </summary>
    public static class NavBar
    {
        /// <summary>
        /// Навигира към подчинена форма
        /// </summary>
        /// <param name="form"></param>
        /// <param name="parent"></param>
        public static void Navigate(Form form,Control parent,Control fromForm=null)
        {

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Parent = parent.Parent;
            
            form.WindowState = FormWindowState.Maximized;
            Form parent_form = (Form)parent.Parent;
            RadDock radDock1 = (RadDock)parent_form.Controls["RadDock1"];
            HostWindow host = radDock1.GetHostWindow(fromForm);
            foreach (HostWindow item in radDock1.GetWindows<HostWindow>())
            {
                if (item.Text ==form.Text || item.Text==fromForm.Text)
                {
                    item.Close();
                }
            }
            host.Close();
            radDock1.DockControl(form, DockPosition.Fill, DockType.Document);
            form.Show();

        
        }
    }
}
