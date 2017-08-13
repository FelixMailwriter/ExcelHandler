using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    public class OperationEqual : Operation
    {
        public bool doCompare(string param1, string param2, string parameter)
        {
            if ((param1 == null) || (parameter == null))
            {
                return false;
            }
            double p1 = 0;
            double param = 0;
            if ((Double.TryParse(param1, out p1)) && (Double.TryParse(parameter, out param))){
                return p1 == param;
            }
            return param1.Equals(parameter);
        }

    }
}
