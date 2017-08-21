using System;
using System.Collections.Generic;
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
        public int TargetColumn { get; private set; }
        public Action Action { get; set; }

        public Rule()
        {
            Name = "NewRule";
            MainCondition = new Condition();
            CriteriaList = new List<Criteria>();
            TargetColumn = 0;
            Action = null;
            //Description = getDescription();
        }

        public Rule(string name, Condition mainCondition, int targetColumn, Action action)
        {
            Name = name;
            TargetColumn = targetColumn;
            MainCondition = mainCondition;
            CriteriaList = new List<Criteria>();
            Action = action;
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
            TargetColumn = oldRule.TargetColumn;
            Action = oldRule.Action;
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
                    Action.doAction(ref item, TargetColumn, crit.Suffix);
                }
            }
            return item;
        }

        public override string ToString()
        {
            string description = Name + ": " + TargetColumn.ToString() + " " + MainCondition.CondOperation + " "
                + MainCondition.Param1;
            return description;
        }

    }
}