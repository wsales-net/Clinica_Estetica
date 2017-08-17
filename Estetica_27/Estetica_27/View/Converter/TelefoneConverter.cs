using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Estetica_27.View.Converter
{
    class TelefoneConverter
    {

        public static String Unformat(String value)
        {
            Regex regexObj = new Regex(@"[^\d]");
            value = regexObj.Replace(value, "");
            return value;
        }

    }
}
