using System;
using ExcelHandler.Common;


namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionChangeByCondition : Action
    {
        public static string description= "Заменить по условию";
        public void doAction(ref Item Item, int column, string suffix, int sourceValueColumn, int changedColumn, string changedValue)
        {
            Item[column] = suffix;
            Item.Changed = true;

        }
    }
}
