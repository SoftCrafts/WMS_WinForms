using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;



/// <summary>
/// Автор:iFD|Д.Делчев
/// Помощни функции за конвертиране на типове.
/// </summary>
namespace WMS
{
    public static class Get
    {

        /// <summary>
        /// Взима цифрова стойност от обект
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static int MakeInt(this Object row)
        {
            int res = int.MinValue;

            if (row != null)
            {
                if (!int.TryParse(row.ToString(), out res))
                {
                    // Log.Trace("MakeInt:" + row);
                    throw new Exception("MakeInt:" + row);
                }

            }

            return res;
        }

        /// <summary>
        /// Конвертира обект към стринг
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static String MakeString(this object row)
        {
            return row == null ? "" : row.ToString();
        }

        /// <summary>
        /// Конвертира към long
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static long MakeLong(this Object row)
        {
            long res = long.MinValue;

            if (row != null)
            {
                if (!long.TryParse(row.ToString(), out res))
                {
                  //  MessageBox.Show("MakeLong exception!");
                }

            }

            return res;
        }

        /// <summary>
        /// Конвертира към decimal
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static decimal MakeDecimal(this Object row)
        {
            decimal res = decimal.MinValue;

            if (row != null&& row!=String.Empty)
            {
                if (!decimal.TryParse(row.ToString(), out res))
                {
                    throw new Exception("MakeDecimal:" + row);
                }

            }

            return res;
        }

        /// <summary>
        /// конвертира към болеан
        /// </summary>
        /// <param name="inObject"></param>
        /// <returns></returns>
        public static bool MakeBool(this Object inObject)
        {
            bool boolRes;
            if (!bool.TryParse(inObject.MakeString().Replace("1", "true"), out boolRes))
            {
                throw new Exception("MakeBool");
            }
            return boolRes;
        }

        /// <summary>
        /// Проверява дали е нечетно едно число.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Проверява дали е четно едно число.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

    }
}