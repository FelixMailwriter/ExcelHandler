using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler
{
    public class ItemComparator
    {
        public List<ProductTypeRuleList> ProductTypeRules { get; private set; }
        public List<Item> NotHandledItem { get; private set; }

        public ItemComparator()
        {
            ProductTypeRules=loadRulesList();
        }

        private List<ProductTypeRuleList> loadRulesList()
        {
            List<ProductTypeRuleList> ptrl = new List<ProductTypeRuleList>();
            ptrl.Add(new ProductTypeRuleList( "Name1", new List<string>(), new List<Rule>() ));
            return ptrl;
        }
    }
}
