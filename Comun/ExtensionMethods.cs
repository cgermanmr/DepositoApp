using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class ExtensionMethods
    {
        public static decimal? ZeroIfNull(this decimal? value)
        {
            return value ??  0;
        }

        public static DateTime SafeToDateTime(this DateTime? value)
        {
            if (value == null)
                return DateTime.MinValue;
            //
            DateTime.TryParse(value.ToString(), out var dt);
            //
            return dt;
        }
        public static DateTime SafeToDateTime(this object value)
        {
            if (value == null)
                return DateTime.MinValue;
            //
            DateTime.TryParse(value.ToString(), out var dt);
            //
            return dt;
        }

        public static long SafeToLong(this object value)
        {
            
            long.TryParse(value?.ToString(), out long v);
            //
            return v;
        }

        public static double SafeToDouble(this object value)
        {
            if(value == null)
                return 0;

            double.TryParse(value.ToString(), out var v);
            //
            return v;
        }

        public static int SafeToInt(this object value)
        {

            int.TryParse(value.ToString(), out var v);
            //
            return v;
        }

        public static string BlankIfDbNull(this object value)
        {
            var result = Convert.IsDBNull(value) ? string.Empty : value.ToString();
            return result;
        }

        public static int ZeroIfDbNull(this object value)
        {
            var result = Convert.IsDBNull(value) ? 0 : value;

            return result.SafeToInt();
        }
        public static string SafeShortDateString(this object value)
        {
            var s = value.BlankIfDbNull();
            
            if(s.Length == 0) 
                return string.Empty;

            return Convert.ToDateTime(s).ToShortDateString();
        }




    }
}
