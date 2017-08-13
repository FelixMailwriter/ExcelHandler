using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler

{
    public class Rule
    {
        public List<Condition> MainCondition { get; private set; }
        public List<Condition> ConditionList { get; private set; }
        public string ActionColumn { get; set; }
        public Action Action { get; set; }
        public string Suffix { get; set; }

        public Rule(List<Condition> mainCondition, List<Condition> conditionList, 
                    string actionColumn, Action action, string suffix)
        {
            MainCondition = mainCondition;
            ConditionList = conditionList;
            ActionColumn = actionColumn;
            Action = action;
            Suffix = suffix;
        }

        public void addMainCondition(Condition condition)
        {
            MainCondition.Add(condition);
        }

        public void removeMainCondition(Condition condition)
        {
            Condition RemovedCondition = MainCondition.Find(p => p == condition);
            if (RemovedCondition != null)
            {
                MainCondition.Remove(RemovedCondition);
            }
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
                    Action.doAction(ref Item, condition);
                    return Item;
                }
            }
            return Item;
        }

    }
}