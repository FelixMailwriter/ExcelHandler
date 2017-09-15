using ExcelHandler.Common;

namespace ExcelHandler
{
    public interface Action
    {
        void doAction(ref Item Item, int column, string suffix, int sourceValueColumn);
    }
}