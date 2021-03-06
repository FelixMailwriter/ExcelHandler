﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    [Serializable]
    public class OperationBetween : Operation
    {
        public static string description = "Между";
        public bool doCompare(string param1, string param2, string testValue)
        { 
             if ((param1 == null) || (param2==null)||(testValue == null))
            {
                return false;
            }

            double p1 = Double.MaxValue;
            double p2 = Double.MinValue;
            double value=0;
            try
            {
                p1 = Double.Parse(param1);
                p2 = Double.Parse(param2);
                value = Double.Parse(testValue);
            }
            catch (ArgumentException )  {  }

            return ((p1 <= value) && (value<=p2));
        }

        public string getDescription()
        {
            return GetType().GetField("description").GetValue(null).ToString();

        }

        public override string ToString()
        {
            return getDescription();
        }
    }
}
