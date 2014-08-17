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
    public static class Test
    {
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
