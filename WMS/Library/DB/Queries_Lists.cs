using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Library.DB
{
    public static class Queries_Lists
    {
        public const string ProductsList = "SELECT p.Product_ID, p.PRODUCT_NAME, pt.PRODUCT_TYPE_NAME, uom.Description, "
            +" p.SALES_PRICE, "
            +" p.PRUCHASE_PRICE, "
            +" p.BOM_ITEM, "
            +" rh.RECIPE_HEADER_NAME "
            +" FROM PRODUCTS p "
            +" INNER JOIN product_type pt on pt.PRODUCT_TYPE_ID=p.PROCUCT_TYPE_ID "
            +" INNER JOIN unit_of_measure uom on uom.UNIT_OF_MEASURE_ID=p.UNIT_OF_MEASURE_ID "
            +" LEFT JOIN recipe_header rh on p.Product_ID = rh.PRODUCT_ID "

            +" ORDER BY  p.Product_ID ASC";
    }
}
