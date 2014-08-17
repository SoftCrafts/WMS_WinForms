using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace WMS
{
    /// <summary>
    /// Клас за зареждане и промяна на контроли
    /// </summary>
    public static class Build
    {

        /// <summary>
        /// Зарежда combo_box с дадена заявка
        /// </summary>
        /// <param name="combo_Box"></param>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        public static void LoadComboBoxes(ref RadDropDownList combo_Box, string query, params Object[] parameter)
        {
            DataTable dt = DbUtil.getDataTable(query, parameter);

            combo_Box.ValueMember = dt.Columns[0].MakeString();
            combo_Box.DisplayMember = dt.Columns[1].MakeString();
            combo_Box.DataSource = dt;        
        }
    }
}
