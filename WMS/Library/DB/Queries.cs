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

        /// <summary>
        /// Списък с Потребителите
        /// </summary>
        public const string UserIds = "SELECT [User_ID],[Full_Name]  FROM [User] ORDER BY Full_Name";


        /// <summary>
        /// Списък с Складовете
        /// </summary>
        public const string Locations = "SELECT  [Location_ID],[Name]  FROM [Location]";
    }
}
