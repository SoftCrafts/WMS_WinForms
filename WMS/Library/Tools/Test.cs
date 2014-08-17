using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
