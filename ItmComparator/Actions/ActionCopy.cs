using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionCopy : Action
    {
        public static string description = "Копировать строку";
        public void doAction(ref Item item, int column, string suffix, int sourceValueColumn)
        {
            item.Changed = true;
        }
    }
}
