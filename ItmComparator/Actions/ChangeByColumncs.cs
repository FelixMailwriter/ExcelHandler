using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    class ChangeByColumncs : Action
    {
        public static string description = "Заменить значением столбца";
        public void doAction(ref Item Item, int column, string suffix, int sourceValueColumn)
        {
            string SourceValue = Item[sourceValueColumn];
            Item[column] = SourceValue;
            Item.Changed = true;
        }
    }
}
