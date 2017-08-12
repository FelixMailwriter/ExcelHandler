using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler
{
    public class ProductTypeRuleList
    {
        public string Name { get; set; }
        public List<string> Aliases { get; private set; }
        public List<Rule> Rules { get; set; }

        public ProductTypeRuleList(string name, List<string> aliases, List<Rule> rules)
        {
            Name = name;
            Aliases = aliases;
            Rules = rules;
        }




        public Item checkRules(Item item)
        {
            throw new NotImplementedException();
        }
    }
}