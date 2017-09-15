using System;
using ExcelHandler.Common;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler
{
    [Serializable]
    public class Condition
    {
        public string Param1 { get; private set; }
        public string Param2 { get; private set; }
        public Operation CondOperation { get; private set; }
        public int TestValueColumn { get; private set; }
        public string Description { get; set; }

        public Condition()
        {
            Param1 = "";
            Param2 = "";
            CondOperation = null;
            TestValueColumn = 0;
            Description = this.ToString();
        }

        public Condition(string param1, string param2, Operation condOperation, int testValueColumn)
        {
            Param1 = param1;
            Param2 = param2;
            CondOperation = condOperation;
            TestValueColumn = testValueColumn;
            Description = this.ToString();
        }

        public Condition (Condition oldCondition)
        {
            Param1 = oldCondition.Param1;
            Param2 = oldCondition.Param2;
            CondOperation = oldCondition.CondOperation;
            TestValueColumn = oldCondition.TestValueColumn;
            Description = this.ToString();
        }

        public bool checkCondition(Item item)
        {
            string TestValue = item[TestValueColumn];
            bool result = false;
            try
            {
                result=CondOperation.doCompare(Param1, Param2, TestValue);
            }catch (ArgumentException )
            {
                throw new ConditionException("Неверный аргумент в условии");
            }
            return result;
        }

        public override string ToString()
        {
            string opDescription = (CondOperation==null)?" не задано": CondOperation.getDescription();
            string result = TestValueColumn.ToString() +" "+ opDescription + " " + Param1 + " ";
            if (!String.IsNullOrEmpty(Param2))
            {
                result += " И " + Param2;
            }
            return result;
        }
    }

}