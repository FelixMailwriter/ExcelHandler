﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class ActionSkip : Action
    {
        public static string description = "Пропустить строку";
        public void doAction(ref Item Item, int column, string suffix, int sourceValueColumn, int changedColumn, string changedValue)
        {
            Item = new Item();
            Item.Changed = true;
        }
    }
}
