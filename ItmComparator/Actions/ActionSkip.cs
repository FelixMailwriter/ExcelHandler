using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator.Actions
{
    public class ActionSkip : Action
    {
        public void doAction(ref Item Item, Condition condition, string column)
        {
            Item = null;
        }
    }
}
