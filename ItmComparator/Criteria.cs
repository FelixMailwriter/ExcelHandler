using System;
using System.Collections.Generic;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator
{
    [Serializable]
    public class Criteria
    {
        public List<Condition> Conditions { get; set; }
        public string Suffix { get; set; }

        public Criteria()
        {
            Conditions = new List<Condition>();
            Suffix = "";
        }

        public Criteria (Condition condition, string suffix)
        {
            Conditions = new List<Condition>();
            Conditions.Add(condition);
            Suffix = suffix;
        }

        public Criteria (List<Condition>conditions, string suffix)
        {
            Conditions = conditions;
            Suffix = suffix;
        }

        public Criteria(Criteria crit)
        {
            Suffix = crit.Suffix;
            Conditions = new List<Condition>();
            foreach(Condition cond in crit.Conditions)
            {
                Conditions.Add(new Condition(cond));
            }
        }

        public void addCondition( Condition cond)
        {
            Conditions.Add(cond);
        }

        public void addCondition(string param1, string param2, Operation condOperation, int testValueColumn)
        {
            Condition cond = new Condition(param1, param2, condOperation, testValueColumn);
            Conditions.Add(cond);
        }

        public void removeCondition(Condition cond)
        {
            Condition c = Conditions.Find(p => p.GetHashCode() == cond.GetHashCode());
            Conditions.Remove(c);
        }

        public void replaceCondition(Condition oldCond, Condition newCond)
        {
            removeCondition(oldCond);
            Conditions.Add(newCond);
        }

        public void replaceCondition(string descriptionOldCond, Condition newCond)
        {
            Condition oldCondition = getCondition(descriptionOldCond);
            Conditions.Remove(oldCondition);
            Conditions.Add(newCond);
        }

        public Condition getCondition(string description)
        {
            Condition cond = Conditions.Find(p => p.Description.Equals(description));
            return cond;
        }

        public bool checkCriteria(Item item)
        {
            foreach(Condition cond in Conditions)
            {
                    return cond.checkCondition(item);
            }
            return false;
        }

        public override string ToString()
        {
            string result = "";
            if ((Conditions[0] != null))
            {
                result += Conditions[0].ToString();
            }
            try
            {
                if ((Conditions[1] != null))
                {
                    result += " И " + Conditions[1].ToString();
                }
            }
            catch (ArgumentOutOfRangeException) { }

            result += " вернуть " + Suffix;
            return result;
        }
    }
}
