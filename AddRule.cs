﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExcelHandler
{
    public partial class AddRule : Form
    {
        private Rule rule;
        //private List<string> mainConditionList;
        private Dictionary<string, Operation> conditionList;
        private List<string> actionList;
        private List<string> additionRulesDescriptionLsit;

        public AddRule()
        {
            InitializeComponent();
            prepareForm();
            fillForm();
        }

        public AddRule(Rule rule)
        {
            this.rule = rule;
            InitializeComponent();
            prepareForm();
            fillForm();
            
        }

        private void prepareForm()
        {
            //mainConditionList = getListOperationsDescriptions();
            conditionList = getListOperationsDescriptions();
            cmbx_MainCondition.DataSource = conditionList.Keys.ToList();
            cmbx_Conditions.DataSource = conditionList.Keys.ToList();
            actionList = getListActionsDescriptions();
            cmbx_Actions.DataSource = actionList;
            additionRulesDescriptionLsit = getListAdditionalRulesDescription();
            lsbx_AdditionalRules.DataSource = additionRulesDescriptionLsit;
        }

        private Dictionary<string, Operation> getListOperationsDescriptions()
        {
            var t = typeof(Operation);
            Dictionary<string, Operation> opDescriptionList = new Dictionary<string, Operation>();
            var typesIEnum = AppDomain
             .CurrentDomain
             .GetAssemblies()
             .SelectMany(x => x.GetTypes())
             .Where(x => t.IsAssignableFrom(x));

            foreach (var types in typesIEnum)
            {
                Type TestType = Type.GetType(types.FullName);
                try
                {
                    string opDescription = TestType.GetField("description").GetValue(null).ToString();
                    opDescriptionList.Add(opDescription, (Operation)Activator.CreateInstance(TestType));//(Operation)TestType);
                }
                catch (NullReferenceException) { }
            }
            return opDescriptionList;
        }

        private List<string> getListActionsDescriptions()
        {
            var t = typeof(Action);
            List<string> actDescriptionList = new List<string>();
            var typesIEnum = AppDomain
             .CurrentDomain
             .GetAssemblies()
             .SelectMany(x => x.GetTypes())
             .Where(x => t.IsAssignableFrom(x));

            foreach (var types in typesIEnum)
            {
                Type TestType = Type.GetType(types.FullName);
                try
                {
                    string opDescription = TestType.GetField("description").GetValue(null).ToString();
                    actDescriptionList.Add(opDescription);
                }
                catch (NullReferenceException) { }
            }
            return actDescriptionList;
        }

        private List<string> getListAdditionalRulesDescription()
        {
            List<string> rd = new List<string>();
            foreach (Condition cond in rule.ConditionList)
            {
                rd.Add(cond.ToString() + " -> " + rule.ActionColumn);
            }
            return rd;
        }

        private void fillForm()
        {
            if(rule==null) { return; }
            txbx_TargetColumn.Text = rule.ActionColumn;
            txbx_MainParameter.Text = rule.MainCondition.Parameter;
            string opAlias = "";
            if (rule.MainCondition.CondOperation != null) { 
                opAlias=rule.MainCondition.CondOperation.GetType().GetField("description").GetValue(null).ToString();
                //if (mainConditionList.Contains(opAlias))
                if (conditionList.Keys.Contains(opAlias))
                {
                    cmbx_MainCondition.SelectedItem = opAlias;
                }
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbx_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_Actions.SelectedItem.Equals("Изменить"))
            {
                gb_additionCondition.Enabled = true;
            }
            else
            {
                gb_additionCondition.Enabled = false;
            }
        }

        private void cmbx_Conditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_Conditions.SelectedItem.Equals("Между"))
            {
                txbx_Param2.Enabled = true;
            }
            else
            {
                txbx_Param2.Enabled = false;
            }
        }

        private void lsbx_AdditionalRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addCondition_Click(object sender, EventArgs e)
        {

        }

        private void btn_RemoveCondition_Click(object sender, EventArgs e)
        {
            string TargetColumn = txbx_Column.Text;
            string ConditionName = cmbx_Conditions.Text;
            string Param1 = txbx_Param1.Text;
            string Param2 = txbx_Param2.Text;
            string Parameter = txbx_Value.Text;
            
        }
    }
}
