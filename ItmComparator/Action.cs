using ExcelHandler.Common;

namespace ExcelHandler
{
    public interface Action
    {
        void doAction(ref Item Item, Condition condition, string column);
    }
}