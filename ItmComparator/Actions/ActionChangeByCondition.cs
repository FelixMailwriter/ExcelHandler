using System;
using ExcelHandler.Common;


namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionChangeByCondition : Action
    {
        public static string description= "Заменить по условию";
        public void doAction(ref Item Item, int column, string suffix, int sourceValueColumn)
        {
            int ColumnNumber = column;
                Item[ColumnNumber] = suffix.ToUpper();
                Item.Changed = true;
        }
    }
}
