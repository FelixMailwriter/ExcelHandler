﻿using System;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler
{
    public class Condition
    {
        public string Param1 { get; private set; }
        public string Param2 { get; private set; }
        //public string Parameter { get; private set; }
        public Operation CondOperation { get; private set; }
        public string Suffix { get; private set; }

        public Condition()
        {
            Param1 = "";
            Param2 = "";
            //Parameter = "";
            CondOperation = null;
            Suffix = "";
        }

        public Condition(string param1, string param2, Operation condOperation, string suffix)
        {
            Param1 = param1;
            Param2 = param2;
            //Parameter = parameter;
            CondOperation = condOperation;
            Suffix = suffix;
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
            return "Если "+ Param1+" "+" "+ Param2+" "+ opDescription+ " "+ Suffix;
        }
    }

}