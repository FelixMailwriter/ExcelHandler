using System;
using ExcelHandler.Common;


namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionChange : Action
    {
        public static string description= "Изменить";
        public void doAction(ref Item Item, int column, string suffix)
        {
            int ColumnNumber = column;
                Item[ColumnNumber] += suffix;
                Item.Changed = true;
        }
    }
}
