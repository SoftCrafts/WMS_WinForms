using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS
{
    public static class Queries
    {
        /// <summary>
        /// Заявка за листа на моделите
        /// </summary>
        public const string models_Select_List= "SELECT [ID] ,[MarkID]  ,(SELECT m.MarkName FROM Marks m WHERE models.MarkID=m.ID) as [MarkName]  ,[ModelName] FROM [dbo].[Models] models";
    }
}
