using System;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler
{
    [Serializable]
    public class Condition
    {
        public string Param1 { get; private set; }
        public string Param2 { get; private set; }
        public Operation CondOperation { get; private set; }
        public string Suffix { get; private set; }

        public Condition()
        {
            Param1 = "";
            Param2 = "";
            CondOperation = null;
            Suffix = "";
        }

        public Condition(string param1, string param2, Operation condOperation, string suffix)
        {
            Param1 = param1;
            Param2 = param2;
            CondOperation = condOperation;
            Suffix = suffix;
        }

        public Condition (Condition oldCondition)
        {
            Param1 = oldCondition.Param1;
            Param2 = oldCondition.Param2;
            CondOperation = oldCondition.CondOperation;
            Suffix = oldCondition.Suffix;
        }

        public bool makeCompare(string testValue)
        {
            bool result = false;
            try
            {
                result=CondOperation.doCompare(Param1, Param2, testValue);
            }catch (ArgumentException )
            {
                throw new ConditionException("Неверный аргумент в условии");
            }
            return result;
        }

        public override string ToString()
        {
            string opDescription = CondOperation.getDescription();
            string result = "";
            result += opDescription + " " + Param1 + " ";
            if (!String.IsNullOrEmpty(Param2))
            {
                result += " И " + Param2;
            }
            result += " вернуть " + Suffix;
            return result;
        }
    }

}