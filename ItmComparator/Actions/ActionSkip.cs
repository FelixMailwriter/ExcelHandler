using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionSkip : Action
    {
        public static string description = "Пропустить";
        public void doAction(ref Item Item, int column, string suffix)
        {
            Item = null;
        }
    }
}
