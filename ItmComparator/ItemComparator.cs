using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator
{
    public class ItemComparator
    {
        public List<ProductTypeRuleList> ProductTypeRule { get; private set; }
        public List<Item> NotHandledItem { get; private set; }
    }
}
