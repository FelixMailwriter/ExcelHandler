﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.ItmComparator.Conditions
{
    public class OperationMore : Operation
    {
        public static string description = ">";
        public bool doCompare(string param1, string param2, string parameter)
        {
            if ((param1 == null) || (parameter == null))
            {
                return false;
            }
            double p1 = Double.MaxValue;
            double param = 0;
            try
            {
                p1 = Double.Parse(param1);
                param = Double.Parse(parameter);
            }
            catch (ArgumentException) { }

            return ((p1 > param));
        }

        public string getDescription()
        {
            return GetType().GetField("description").GetValue(null).ToString();

        }
    }
 }

