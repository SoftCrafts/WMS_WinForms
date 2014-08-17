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

        // Списък видове артикули
        public const string ItemTypes = "SELECT [Item_Type_ID],[Description] FROM [Item_Type]";

        // Списък модели
        public const string Models = "SELECT [Model_ID],[Name] FROM [Model] WHERE [Manufacturer_ID] = ? ";        

        // Списък мерни единици
        public const string UnitsOfMeasure = "SELECT [Code],[Description] FROM [Unit_of_Measure]";

        // Списък складови места
        public const string Bins = "SELECT [Bin_ID],[Location_ID],[Description] FROM [Bin]";

        // Списък валути
        public const string Currencies = "SELECT [Code],[Description] FROM [Currency]";
    }
}
