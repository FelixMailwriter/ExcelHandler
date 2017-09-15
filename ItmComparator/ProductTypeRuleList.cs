using System;
using System.Collections.Generic;
using System.Data;
using ExcelHandler.Common;

namespace ExcelHandler
{
    [Serializable]
    public class ProductTypeRuleList
    {
        public int StartCounter;
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
            Rule rule=Rules.Find(p => p.ToString().Equals(ruleDescription));
            return rule;
        }

        public void addRule(Rule rule)
        {
            if (rule != null)
            {
                Rules.Add(rule);
                Rules.Sort();
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

        public  List<string> getRulesDescriptionList()
        {
            List<string> RulesDescriptions = new List<string>();
            foreach(Rule rule in Rules)
            {
                RulesDescriptions.Add(rule.ToString());
            }
            return RulesDescriptions;
        }

        public Item checkRules(Item item)
        {
            foreach(Rule rule in Rules)
            {
                //Console.WriteLine(rule);
                item = rule.checkRule(item);
                if (item.Changed)
                {
                    return item;
                }
            }
            return item;
        }

        internal void changeRule(Rule rule, Rule newRule)
        {
            Rules.Remove(rule);
            Rules.Add(newRule);
        }

        internal void moveRuleUp(string ruleName)
        {
            Rule MovedRule = getRuleByDescription(ruleName);
            int index=Rules.IndexOf(MovedRule);
            if (index == 0) { return; }
            Rule NeighbourRule = Rules[index - 1];
            Rules.RemoveAt(index);
            Rules.RemoveAt(index - 1);
            Rules.Insert(index - 1, MovedRule);
            Rules.Insert(index, NeighbourRule);
        }

        internal void moveRuleDown(string ruleName)
        {
            Rule MovedRule = getRuleByDescription(ruleName);
            int index = Rules.IndexOf(MovedRule);
            if (index >= (Rules.Count-2)) { return; }
            Rule NeighbourRule = Rules[index +1];
            Rules.RemoveAt(index + 1);
            Rules.RemoveAt(index);
            Rules.Insert(index, NeighbourRule);
            Rules.Insert(index + 1, MovedRule);
        }
    }

}