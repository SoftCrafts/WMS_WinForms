using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void Navigate(Form form,Control parent)
        {

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Parent = parent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        
        }
    }
}
