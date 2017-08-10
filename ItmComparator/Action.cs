using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator
{
    public interface Action
    {
        Item doAction(ItemComparator Item);
    }
}