using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WMS
{
    public class Globals
    {

        public static string UserName;
        public static string FullName;
        public static string Role;

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


        /// <summary>
        /// Рекурсивно взима родителя докато намери Панела на главната страница.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Control GetParent(Control obj)
        {

            if (obj.Parent.GetType().BaseType.Name == "RadForm")
            {
                return obj;
            }
            else
            {
                return GetParent(obj.Parent);
            }

        }

        // Вика се при отваряне и затваряне на Card формите, като се пълнят 2 различни променливи и се сравнява дали данните са променени.
        public static Dictionary<string, string> FillDictionary(Control obj)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            foreach (Control c in obj.Controls)
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
            return (dict);
        }

    }
}