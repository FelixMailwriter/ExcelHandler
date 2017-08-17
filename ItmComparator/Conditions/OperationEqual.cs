using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    [Serializable]
    public class OperationEqual : Operation
    {
        public static string description = "=";
        public bool doCompare(string param1, string param2, string testValue)
        {
            if ((param1 == null) || (testValue == null))
            {
                return false;
            }
            double p1 = 0;
            double param = 0;
            if ((Double.TryParse(param1, out p1)) && (Double.TryParse(testValue, out param))){
                return p1 == param;
            }
            return param1.Equals(testValue);
        }

        public string getDescription()
        {
            return GetType().GetField("description").GetValue(null).ToString();
        }

        public override string ToString()
        {
            return getDescription();
        }
    }
}
