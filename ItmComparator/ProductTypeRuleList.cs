using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator
{
    public class ProductTypeRuleList
    {
        public string Name { get; private set; }
        public List<string> Aliases { get; private set; }
        public List<Rule> Rules { get; private set; }


        public Item checkRules(Item item)
        {
            throw new NotImplementedException();
        }
    }
}