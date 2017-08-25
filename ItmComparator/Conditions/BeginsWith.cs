using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    [Serializable]
    public class BeginsWith : Operation
    {
        public  static  string  description = "Начинается с";

        public bool doCompare(string param1, string param2, string testValue)
        {
            if ((param1 == null) || (testValue == null))
            {
                return false;
            }
            String Param1 = param1.ToUpper();
            String TestValue = testValue.ToUpper();
            return TestValue.StartsWith(Param1);
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
