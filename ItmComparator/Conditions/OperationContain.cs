using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    [Serializable]
    public class OperationContain : Operation
    {
        public static string description = "Содержит";
        public bool doCompare(string param1, string param2, string testValue)
        {
            if ((param1 == null) || (testValue == null))
            {
                return false;
            }
            return param1.Contains(testValue);
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
