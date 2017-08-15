using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler

{
    public class Rule
    {
        private string Description;
        public Condition MainCondition { get; private set; }
        public List<Condition> ConditionList { get; private set; }
        public string ActionColumn { get; set; }
        public Action Action { get; set; }
        public string Suffix { get; set; }

        public Rule(Condition mainCondition, List<Condition> conditionList, 
                    string actionColumn, Action action, string suffix)
        {
            Description = getDescription();
            MainCondition = mainCondition;
            ConditionList = conditionList;
            ActionColumn = actionColumn;
            Action = action;
            Suffix = suffix;
        }

        private string getDescription()
        {
            string description = "";
            description += MainCondition.Param1 + " " + MainCondition.CondOperation + " " + MainCondition.Param2;
            if (!Suffix.Equals(""))
            {
                description += " = " + Suffix;
            }
            return description;
        }

        public void addCondition(Condition condition)
        {
            ConditionList.Add(condition);
        }

        public void removeCondition(Condition condition)
        {
            Condition RemovedCondition = ConditionList.Find(p => p == condition);
            if (RemovedCondition != null)
            {
                ConditionList.Remove(RemovedCondition);
            }
        }

        private Item checkCondition (Item Item)
        {
            foreach(Condition condition in ConditionList)
            {
                if (condition.makeCompare())
                {
                    Action.doAction(ref Item, condition, ActionColumn);
                    return Item;
                }
            }
            return Item;
        }

        public override string ToString()
        {
            return getDescription();
        }

    }
}