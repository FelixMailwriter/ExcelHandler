using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler
{
    [Serializable]
    public class ProductTypeRuleList
    {
        public string Name { get; set; }
        public List<string> Aliases { get; private set; }
        public List<Rule> Rules { get; private set; }

        public ProductTypeRuleList(string name)
        {
            Name = name;
            Aliases = new List<string>();
            Rules = new List<Rule>();
        }

        public ProductTypeRuleList(string name, List<string> aliases, List<Rule> rules)
        {
            Name = name;
            Aliases = aliases;
            Rules = rules;
        }

        public void addAlias(string alias)
        {
            if (alias.Equals("")) { return; }
            Aliases.Add(alias);
            Aliases.Sort();
        }

        public Rule getRuleByDescription(string ruleDescription)
        {
            return Rules.Find(p => p.Description.Equals(ruleDescription));
        }

        public void addRule(Rule rule)
        {
            if (rule != null)
            {
                Rules.Add(rule);
            }
        }

        public void removeRule(Rule rule)
        {
            Rule RemovedRule = Rules.Find(p => p == rule);
            if (RemovedRule != null)
            {
                Rules.Remove(rule);
            }
        }

        public Item checkRules(Item item)
        {
            throw new NotImplementedException();
        }

        public  List<string> getRulesDescriptionList()
        {
            List<string> RulesDescriptions = new List<string>();
            foreach(Rule rule in Rules)
            {
                RulesDescriptions.Add(rule.Description);
            }
            return RulesDescriptions;
        }
    }
}