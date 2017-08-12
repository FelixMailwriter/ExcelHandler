using ExcelHandler.Common;

namespace ExcelHandler
{
    public interface Action
    {
        Item doAction(ItemComparator Item);
    }
}