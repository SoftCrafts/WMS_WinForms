using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS
{
    public static class Queries
    {
        /// <summary>
        /// Списък с марките
        /// </summary>
        public const string ManufacturerList= "SELECT [Manufacturer_ID]  ,[Name] FROM [Manufacturer] ORDER BY [Name]";
        public const string UserIds = "SELECT [User_ID],[Full_Name]  FROM [User] ORDER BY Full_Name";
    }
}
