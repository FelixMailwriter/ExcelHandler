using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ExcelHandler.ItmComparator;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler
{
    public partial class AddRule : Form
    {
        public Rule rule;
        private Dictionary<string, Operation> commonOperationList;
        private Dictionary<string, Action> commonActionsList;
        private List<string> criteriaDescriptionList;

        public AddRule(Rule rule)
        {
            this.rule = rule;
            InitializeComponent();
            prepareForm();
            fillForm();
        }

        private void prepareForm()
        {
            commonOperationList = getCommonOperationList();
            cmbx_MainCondition.DataSource = commonOperationList.Keys.ToList();
            cmbx_Conditions1.DataSource = commonOperationList.Keys.ToList();
            cmbx_Conditions2.DataSource= commonOperationList.Keys.ToList();
            commonActionsList = getCommonActionsList();
            cmbx_Actions.DataSource = commonActionsList.Keys.ToList();
            criteriaDescriptionList = getCriteriaDescriptionList();
            lsbx_Criterias.DataSource = criteriaDescriptionList;

            //gb_mainCondition.Enabled = (additionRulesDescriptionList.Count == 0) ? true : false;

        }

        private void fillForm()
        {
            if (rule == null) { return; }
            txbx_RuleName.Text = rule.Name;
            txbx_TargetColumn.Text = rule.TargetColumn.ToString();
            txbx_MainParameter.Text = rule.MainCondition.Param1;
            if (rule.Action != null)
            {
                string ActionName = rule.Action.GetType().GetField("description").GetValue(null).ToString();
                cmbx_Actions.SelectedItem = ActionName;
            }
            string opAlias = "";
            if (rule.MainCondition.CondOperation != null)
            {
                opAlias = rule.MainCondition.CondOperation.GetType().GetField("description").GetValue(null).ToString();
                if (commonOperationList.Keys.Contains(opAlias))
                {
                    cmbx_MainCondition.SelectedItem = opAlias;
                }
            }
        }

        private Dictionary<string, Operation> getCommonOperationList()
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
                FieldInfo fi = TestType.GetField("description");
                if (fi == null) { continue; }
                string opDescription = fi.GetValue(null).ToString();
                opDescriptionList.Add(opDescription, (Operation)Activator.CreateInstance(TestType));//(Operation)TestType);
            }
            return opDescriptionList;
        }

        private Dictionary<string, Action> getCommonActionsList()
        {
            var t = typeof(Action);
            Dictionary<string, Action> actDescriptionList = new Dictionary<string, Action>();
            var typesIEnum = AppDomain
             .CurrentDomain
             .GetAssemblies()
             .SelectMany(x => x.GetTypes())
             .Where(x => t.IsAssignableFrom(x));

            foreach (var types in typesIEnum)
            {
                Type TestType = Type.GetType(types.FullName);
                FieldInfo fi = TestType.GetField("description");
                if (fi == null) { continue; }
                string opDescription = fi.GetValue(null).ToString();
                actDescriptionList.Add(opDescription, (Action)Activator.CreateInstance(TestType));
            }
            return actDescriptionList;
        }

        private List<string> getCriteriaDescriptionList()
        {
            return rule.getCriteriaDescriptionsList();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //List<Criteria> tempCriteriaList = rule.CriteriaList;
            string Name = txbx_RuleName.Text;
            string param1 = txbx_MainParameter.Text;
            string ConditionName = cmbx_MainCondition.Text;
            Operation op = null;
            commonOperationList.TryGetValue(ConditionName, out op);
            int valueColumn = getValueColumn(txbx_TargetColumn.Text);
            Condition MainCondition = new Condition(param1, null, op, valueColumn);
            string ActionName = cmbx_Actions.Text;
            Action act = null;
            commonActionsList.TryGetValue(ActionName, out act);
            int TargetColumn = getValueColumn(txbx_TargetColumn.Text);
            Rule NewRule = new Rule(Name, MainCondition, TargetColumn, act);
            NewRule.CriteriaList = rule.CriteriaList;
            rule = (NewRule == null) ? rule : NewRule;
            NewRule = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            if (cmbx_Conditions1.SelectedItem.Equals("Между"))
            {
                txbx_Param1_2.Enabled = true;
            }
            else
            {
                txbx_Param1_2.Enabled = false;
            }
        }

        private void cmbx_Conditions2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_Conditions2.SelectedItem.Equals("Между"))
            {
                txbx_Param2_2.Enabled = true;
            }
            else
            {
                txbx_Param2_2.Enabled = false;
            }
        }

        private void lsbx_AdditionalRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addCondition_Click(object sender, EventArgs e)
        {
            string colum1 = txbx_column1.Text;
            if (colum1.Equals(""))
            {
                MessageBox.Show("Не задан целевой столбец для условия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Criteria crit = new Criteria();
            string param1 = txbx_Param1_1.Text;
            string param2 = txbx_Param1_2.Text;
            int valueColumn = getValueColumn(txbx_column1.Text);
            string ConditionName = cmbx_Conditions1.Text;
            Operation op = null;
            commonOperationList.TryGetValue(ConditionName, out op);
            crit.addCondition(param1, param2, op, valueColumn);

            string column2 = txbx_column2.Text;
            if (!column2.Equals(""))
            {
                param1 = txbx_Param2_1.Text;
                param2 = txbx_Param2_2.Text;
                valueColumn = getValueColumn(txbx_column2.Text);
                ConditionName = cmbx_Conditions2.Text;
                op = null;
                commonOperationList.TryGetValue(ConditionName, out op);
                crit.addCondition(param1, param2, op, valueColumn);
            }
            crit.Suffix = txbx_Suffix.Text;
            rule.addCriteria(crit);

            lsbx_Criterias.DataSource = null;
            criteriaDescriptionList = getCriteriaDescriptionList();
            lsbx_Criterias.DataSource = criteriaDescriptionList;
            clearAdditionFormElements();
        }

        private void btn_RemoveCondition_Click(object sender, EventArgs e)
        {
            string CriteriaDescription = lsbx_Criterias.SelectedItem.ToString();
            rule.removeCriteria(CriteriaDescription);
            lsbx_Criterias.DataSource = getCriteriaDescriptionList();
            clearAdditionFormElements();
        }

        private void clearAdditionFormElements()
        {
            txbx_column1.Clear();
            txbx_column2.Clear();
            txbx_Param1_1.Clear();
            txbx_Param1_2.Clear();
            txbx_Param2_1.Clear();
            txbx_Param2_2.Clear();
            txbx_Suffix.Clear();
        }

        private int getValueColumn(string column)
        {
            int ActCol = 0;
            if (int.TryParse(column, out ActCol))
            {
                return ActCol;
            }
            else
            {
                throw new ActionException("Неверно задан целевой столбец");
            }
        }


    }
}
