using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator

{
    public class Rule
    {
        public List<Condition> MainCondition { get; private set; }
        public List<Condition> ConditionList { get; private set; }
        public string ActionColumn { get; private set; }
        public Action Action { get; private set; }
        public string Suffix { get; private set; }



        public Item makeAction(Item Item)
        {
            throw new NotImplementedException();
        }

        private Item checkCondition (Item Item)
        {
            throw new NotImplementedException();
        }

    }
}