using System;
using System.Collections.Generic;
using System.Linq;
namespace ExcelHandler
{
    public class RulesManager
    {
        public List<ProductTypeRuleList> ptrl { get; private set; }
        public string Filename { get; set; }

        public RulesManager(string filename)
        {
            this.ptrl = new List<ProductTypeRuleList>();
            Filename = filename;
        }

        public List<string> getListRulesType()
        {
            List<string> RulesType = new List<string>();
            foreach(ProductTypeRuleList RuleType in ptrl)
            {
                RulesType.Add(RuleType.Name);
            }
            return RulesType;
        }

        public List<string> getAliasesList(string typename)
        {
            return getType(typename).Aliases;
        }

        public ProductTypeRuleList getType(string name)
        {
            return ptrl.Find(p => p.Name == name);
        }

        internal void addRuleType(string newRuleTypeName)
        {
            ProductTypeRuleList a = ptrl.Find(p => p.Name.Equals(newRuleTypeName));
            if (a != null)
            {
                throw new ArgumentException("Тип с таким именем уже существует");
            }
            ptrl.Add(new ProductTypeRuleList(newRuleTypeName));
        }

        internal void removeType(string removedName)
        {
            ProductTypeRuleList RemovedItem = ptrl.Find(p => p.Name.Equals(removedName));
            if (RemovedItem != null)
            {
                ptrl.Remove(RemovedItem);
            }
        }

        internal void addAlias(string typeName, string aliasName)
        {
            ProductTypeRuleList Item = getType(typeName);
            Item.Aliases.Add(aliasName);
        }

        internal void removeAlias(string typeName, string aliasName)
        {
            ProductTypeRuleList Item = getType(typeName);
            string RemovedAlias = Item.Aliases.Find(p => p.Equals(aliasName));
            Item.Aliases.Remove(RemovedAlias);
        }

    }
}
