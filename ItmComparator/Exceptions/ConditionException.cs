using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Exceptions
{
    [Serializable]
    class ConditionException : ApplicationException
    {
        public ConditionException(string message) : base(message)
        {

        }
    }
}
