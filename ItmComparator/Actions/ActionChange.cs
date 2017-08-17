using System;
using ExcelHandler.Common;


namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionChange : Action
    {
        public static string description= "Изменить";
        public void doAction(ref Item Item, Condition condition, int column)
        {
            int ColumnNumber = column;
                Item[ColumnNumber] += condition.Suffix;
                Item.Changed = true;
        }
    }
}
