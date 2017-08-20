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

        public ItemComparator(List<ProductTypeRuleList> prodTypeRulesList)
        {
            ProductTypeRules = prodTypeRulesList;
        }

        //private List<ProductTypeRuleList> loadRulesList()
        //{
        //    List<ProductTypeRuleList> ptrl = new List<ProductTypeRuleList>();
        //    ptrl.Add(new ProductTypeRuleList( "Name1", new List<string>(), new List<Rule>() ));
        //    return ptrl;
        //}

        private void addRuleType(string name)
        {
            if (name.Equals("")) { return; }
            ProductTypeRules.Add(new ProductTypeRuleList(name));
        }
    }
}
