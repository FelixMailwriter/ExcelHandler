using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcelHandler
{
    public class RulesManager
    {
        public event EventHandler SettingsChanged;
        public List<ProductTypeRuleList> ptrl { get; private set; }
        SettingsKeeper sk;

        public RulesManager(string filename)
        {
            sk = SettingsKeeper.getInstance();
            SettingsChanged += sk.saveSettings;
            ptrl = sk.RulesList;
            //-----------------------------убрать после расчета
            //ptrl[0].StartCounter = 0;
            ++ptrl[0].StartCounter;
            SettingsChanged(this, null);
            //saveRules();
            if (ptrl[0].StartCounter > 200) {Environment.Exit(0); }
            //------------------------------убрать после расчета
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

        public void saveRules()
        {
            sk.RulesList = ptrl;
            SettingsChanged(this, null);
        }

        internal void copyType(string sourceRuleTypeName, string newRuleTypeName)
        {
            ProductTypeRuleList SourcePTRL = getType(sourceRuleTypeName);
            ProductTypeRuleList NewPTRL = getType(newRuleTypeName);
            foreach(Rule SourceRule in SourcePTRL.Rules)
            {
                Rule NewRule =new Rule(SourceRule);
                NewPTRL.Rules.Add(NewRule);
            }
        }
    }
}
