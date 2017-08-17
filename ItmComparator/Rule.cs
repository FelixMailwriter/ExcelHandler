﻿using System;
using System.Collections.Generic;
using ExcelHandler.Common;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler

{
    public class Rule
    {
        private string Description;
        public Condition MainCondition { get; private set; }
        public List<Condition> ConditionList { get; private set; }
        public int ActionColumn { get; private set; }
        public Action Action { get; set; }
        //public string Suffix { get; private set; }

        public Rule()
        {
            MainCondition = new Condition();
            ConditionList = new List<Condition>();
            ActionColumn = 0;
            Action = null;
            //Suffix = "";
            Description = getDescription();
        }

        public Rule(Condition mainCondition, List<Condition> conditionList, 
                    string actionColumn, Action action)//, string suffix)
        { 
            MainCondition = mainCondition;
            ConditionList = conditionList;
            ActionColumn = getActionColumn(actionColumn);
            Action = action;
            //Suffix = suffix;
            Description = getDescription();
        }

        private string getDescription()
        {
            string description = "";
            description += MainCondition.Param1 + " " + MainCondition.CondOperation + " " + MainCondition.Param2;
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
                if (condition.makeCompare(Item[ActionColumn]))
                {
                    Action.doAction(ref Item, condition, ActionColumn);
                    return Item;
                }
            }
            return Item;
        }

        public int  getActionColumn(string column)
        {
            int ActCol = 0;
            if (int.TryParse(column, out ActCol))
            {
                return ActCol;
            }
            else
            {
                throw new ActionException("Неверно задан целевой столбец");
            }
        }

         public override string ToString()
        {
            return getDescription();
        }

    }
}