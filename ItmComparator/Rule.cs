﻿using System;
using System.Collections.Generic;
using System.Reflection;
using ExcelHandler.Common;
using ExcelHandler.ItmComparator;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler

{
    [Serializable]
    public class Rule:IComparable
    {
        public string Name { get; set; }
        public string Description;
        public Condition MainCondition { get; set; }
        public List<Criteria> CriteriaList { get; set; }
        public int CheckedColumn { get; set; }
        public int TargetColumn { get; private set; }
        public int SourceValueColumn { get; set; }
        public string DefaultValue { get; set; }
        public Action ActionInstance { get; set; }
        public bool SwapLengthWidth { get; set; }
        public int ChangedColumn { get; set; }
        public string ChangedValue { get; set; }

        public Rule()
        {
            Name = "NewRule";
            MainCondition = new Condition();
            CriteriaList = new List<Criteria>();
            CheckedColumn = 0;
            TargetColumn = 0;
            SourceValueColumn = 0;
            DefaultValue = "";
            ActionInstance = null;
            ChangedColumn = 0;
            ChangedValue = "";
            //Description = getDescription();
        }

        public Rule(string name, Condition mainCondition, int checkedColumn,
                            int targetColumn, int sourceValueColumn, Action action, string defaultValue,
                            int changedColumn, string changedValue)
        {
            Name = name;
            CheckedColumn = checkedColumn;
            TargetColumn = targetColumn;
            MainCondition = mainCondition;
            DefaultValue = defaultValue;
            SourceValueColumn = sourceValueColumn;
            CriteriaList = new List<Criteria>();
            ActionInstance = action;
            ChangedColumn = changedColumn;
            ChangedValue = changedValue;
        }

        public Rule(Rule oldRule)
        {
            Name = oldRule.Name;
            MainCondition = new Condition(oldRule.MainCondition);
            CriteriaList = new List<Criteria>();
            foreach (Criteria crit in oldRule.CriteriaList)
            {
                CriteriaList.Add(new Criteria(crit));
            }
            CheckedColumn = oldRule.CheckedColumn;
            TargetColumn = oldRule.TargetColumn;
            SourceValueColumn = oldRule.SourceValueColumn;
            DefaultValue = oldRule.DefaultValue;
            ActionInstance = oldRule.ActionInstance;
            Description = oldRule.Description;
            ChangedColumn = oldRule.ChangedColumn;
            ChangedValue = oldRule.ChangedValue;
        }

        public List<string> getCriteriaDescriptionsList()
        {
            List<string> descrList = new List<string>();
            foreach (Criteria crit in CriteriaList)
            {
                descrList.Add(crit.ToString());
            }
            return descrList;
        }

        public void addCriteria(Criteria crit)
        {
            CriteriaList.Add(crit);
        }

        public void removeCriteria(Criteria crit)
        {
            Criteria RemovedCriteria = CriteriaList.Find(p => p == crit);
            if (RemovedCriteria != null)
            {
                CriteriaList.Remove(RemovedCriteria);
            }
        }

        public void removeCriteria(string CriteriaDescription)
        {
            Criteria RemovedCriteria = CriteriaList.Find(p => p.ToString().Equals(CriteriaDescription));
            if (RemovedCriteria != null)
            {
                CriteriaList.Remove(RemovedCriteria);
            }
        }

        public Item checkRule(Item item)
        {
            if (MainCondition.checkCondition(item))      //Если условие правила выполняется...
            {
                //если флаг SwapLengthWidth установлен, меняем ширину и длину местами
                if (SwapLengthWidth)
                {
                    string width = item[2];
                    item[2] = item[3];
                    item[3] = width;
                }
                if (CriteriaList.Count == 0)                                  //Если список критериев пуст, сразу делаем действие
                {
                    ActionInstance.doAction(ref item, TargetColumn, null, SourceValueColumn, ChangedColumn, ChangedValue);
                    return item;
                }
                else                                                                    // иначе обрабатываем список критериев
                {                                                                         // и возвращаем обработанный новый Item
                    return handleCriteria(item);
                }
            }
            else                                                                        //если условие правила не выполняется
            {                                                                             // возвращаем неизмененный Item
                return item;
            }
        }

        private Item handleCriteria(Item item)
        {
            foreach (Criteria crit in CriteriaList)                         // проходим по списку критериев
            {
                if (crit.checkCriteria(item))                                   // если критерий выполняется
                {
                    // выполняем действие //и возвращаем Item
                    ActionInstance.doAction(ref item, TargetColumn, crit.Suffix, SourceValueColumn, ChangedColumn, ChangedValue);   
                    return item;                                                                                                                
                }
            }
            item[TargetColumn] = DefaultValue;   //Если ни один критерий не выполнился, 
            item.Changed = true;                                                    // записываем значение по умолчанию
            return item;                                                                    // и возвращаем Item
        }

        public override string ToString()
        {
            Type TestType = ActionInstance.GetType();
            FieldInfo fi = TestType.GetField("description");
            string opDescription = fi.GetValue(null).ToString();

            string description = Name + ") " + CheckedColumn.ToString() + " " + MainCondition.CondOperation + " "
                + MainCondition.Param1 + " => ";
            if (TargetColumn != 0)
            {
                description += "Столбец " + TargetColumn.ToString() + " ";
            }
            description += opDescription;
            if (SourceValueColumn != 0)
            {
                description += " " + SourceValueColumn;
            }
            if (ChangedColumn != 0)
            {
                description += " И " + ChangedColumn.ToString() + "-->" + ChangedValue;
            }
            if (SwapLengthWidth)
            {
                description += " <=>";
            }

            
            return description;
        }

        internal void UpCriteria(string criteriaDescription)
        {
            Criteria MovedCriteria = CriteriaList.Find(p => p.ToString().Equals(criteriaDescription));
            int index = CriteriaList.IndexOf(MovedCriteria);
            if (index == 0) { return; }
            Criteria NeibourCriteria = CriteriaList[index - 1];
            CriteriaList.RemoveAt(index);
            CriteriaList.RemoveAt(index - 1);
            CriteriaList.Insert(index - 1, MovedCriteria);
            CriteriaList.Insert(index, NeibourCriteria);
        }

        internal void DownCriteria(string criteriaDescription)
        {
            Criteria MovedCriteria = CriteriaList.Find(p => p.ToString().Equals(criteriaDescription));
            int index = CriteriaList.IndexOf(MovedCriteria);
            if (index >= CriteriaList.Count - 1) { return; }
            Criteria NeibourCriteria = CriteriaList[index + 1];
            CriteriaList.RemoveAt(index + 1);
            CriteriaList.RemoveAt(index);
            CriteriaList.Insert(index, NeibourCriteria);
            CriteriaList.Insert(index + 1, MovedCriteria);
        }

        public override bool Equals(object obj)
        {
            Rule CompareObj = obj as Rule;
            if (CompareObj == null) { return false; }
            return Name.Equals(CompareObj.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Rule CompareObj = obj as Rule;
            if (CompareObj == null) { throw new ArgumentException("Объекты не сравнимы"); }
            return Name.CompareTo(CompareObj.Name);
        }
    }
}