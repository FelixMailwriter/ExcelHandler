using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Exceptions
{
    public class ActionException : ApplicationException
    {
        public ActionException(string message) : base(message)
        {
        }
    }
}
