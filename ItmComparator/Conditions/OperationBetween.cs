using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    public class OperationBetween : Operation
    {
        public static string description = "Между";
        public bool doCompare(string param1, string param2, string parameter)
        { 
             if ((param1 == null) || (param2==null)||(parameter == null))
            {
                return false;
            }

            double p1 = Double.MaxValue;
            double p2 = Double.MinValue;
            double param=0;
            try
            {
                p1 = Double.Parse(param1);
                p2 = Double.Parse(param2);
                param= Double.Parse(parameter);
            }
            catch (ArgumentException )  {  }

            return ((p1 <= param) && (p2 >= param));
        }

        public string getDescription()
        {
            return GetType().GetField("description").GetValue(null).ToString();

        }
    }
}
