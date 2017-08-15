using ExcelHandler.Common;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler.ItmComparator.Actions
{
    public class ActionChange : Action
    {
        const string NAME= "Изменить";
        public void doAction(ref Item Item, Condition condition, string column)
        {
            int ColumnNumber = 0;
            if (int.TryParse(column, out ColumnNumber))
            {
                Item[ColumnNumber] += condition.Suffix;
                Item.Changed = true;
            }
            else
            {
                throw new ActionException("Неверно задан целевой столбец действия");
            }
        }
    }
}
