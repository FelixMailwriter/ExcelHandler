using System;
using System.Collections.Generic;
using System.Reflection;
using ExcelHandler.Common;
using ExcelHandler.ItmComparator;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler

{
    [Serializable]
    public class Rule
    {
        public string Name { get; set; }
        public string Description;
        public Condition MainCondition { get; set; }
        public List<Criteria> CriteriaList { get; set; }
        public int CheckedColumn { get; set; }
        public int TargetColumn { get; private set; }
        public int SourceValueColumn { get; set; }
        public Action ActionInstance { get; set; }

        public Rule()
        {
            Name = "NewRule";
            MainCondition = new Condition();
            CriteriaList = new List<Criteria>();
            CheckedColumn = 0;
            TargetColumn = 0;
            SourceValueColumn = 0;
            ActionInstance = null;
            //Description = getDescription();
        }

        public Rule(string name, Condition mainCondition, int checkedColumn, 
                            int targetColumn, int sourceValueColumn, Action action)
        {
            Name = name;
            CheckedColumn = checkedColumn;
            TargetColumn = targetColumn;
            MainCondition = mainCondition;
            SourceValueColumn = sourceValueColumn;
            CriteriaList = new List<Criteria>();
            ActionInstance = action;
        }

        public Rule(Rule oldRule)
        {
            Name = oldRule.Name;
            MainCondition = new Condition(oldRule.MainCondition);
            CriteriaList = new List<Criteria>();
            foreach (Criteria crit in oldRule.CriteriaList)
            {
                CriteriaList.Add(new Criteria(crit));
            }
            CheckedColumn = oldRule.CheckedColumn;
            TargetColumn = oldRule.TargetColumn;
            SourceValueColumn = oldRule.SourceValueColumn;
            ActionInstance = oldRule.ActionInstance;
            Description = oldRule.Description;
        }

        public List<string> getCriteriaDescriptionsList()
        {
            List<string> descrList = new List<string>();
            foreach (Criteria crit in CriteriaList)
            {
                descrList.Add(crit.ToString());
            }
            return descrList;
        }

        public void addCriteria(Criteria crit)
        {
            CriteriaList.Add(crit);
        }

        public void removeCriteria(Criteria crit)
        {
            Criteria RemovedCriteria = CriteriaList.Find(p => p == crit);
            if (RemovedCriteria != null)
            {
                CriteriaList.Remove(RemovedCriteria);
            }
        }

        public void removeCriteria(string CriteriaDescription)
        {
            Criteria RemovedCriteria = CriteriaList.Find(p => p.ToString().Equals(CriteriaDescription));
            if (RemovedCriteria != null)
            {
                CriteriaList.Remove(RemovedCriteria);
            }
        }

        private Item checkRule(Item item)
        {
            if (!MainCondition.checkCondition(item)) { return item; }
            foreach (Criteria crit in CriteriaList)
            {
                if (crit.checkCriteria(item))
                {
                    ActionInstance.doAction(ref item, TargetColumn, crit.Suffix, SourceValueColumn);
                }
            }
            return item;
        }

        public override string ToString()
        {
            Type TestType = ActionInstance.GetType();
            FieldInfo fi = TestType.GetField("description");
            string opDescription = fi.GetValue(null).ToString();

            string description = Name + ") " + CheckedColumn.ToString() + " " + MainCondition.CondOperation + " "
                + MainCondition.Param1 + " => ";
            if (TargetColumn != 0)
            {
                description += "Столбец " + TargetColumn.ToString() + " ";
            }
            description +=opDescription;
            if (SourceValueColumn != 0)
            {
                description +="+"+ SourceValueColumn;
            }
            return description;
        }

    }
}