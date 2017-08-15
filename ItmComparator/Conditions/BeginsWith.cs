using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    public class BeginsWith : Operation
    {
        public static string description = "Начинается с";
        public bool doCompare(string param1, string param2, string parameter)
        {
            if ((param1 == null) || (parameter == null))
            {
                return false;
            }
            return param1.StartsWith(parameter);
        }
    }
}
