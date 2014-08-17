using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace WMS
{
    public class Globals
    {

        /// <summary>
        /// пътя към root директорията на сайта
        /// </summary>
        public static string ServerRootPath { get; set; }

        public static Rectangle CreateBorderRect(Control control)
        {
            Rectangle rc = new Rectangle(control.Left - 1, control.Top - 1,
            control.Size.Width + 1, control.Size.Height + 1);
            return rc;
        }
    }
}