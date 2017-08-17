using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ExcelHandler.ItmComparator.Exceptions;

namespace ExcelHandler
{
    public partial class AddRule : Form
    {
        public Rule rule;
        private Dictionary<string, Operation> commonConditionList;
        private Dictionary<string, Action> commonActionsList;
        private List<string> additionRulesDescriptionList;

        public AddRule(Rule rule)
        {
            this.rule = rule;
            InitializeComponent();
            prepareForm();
            fillForm();
        }

        private void prepareForm()
        {
            commonConditionList = getCommonConditionList();
            cmbx_MainCondition.DataSource = commonConditionList.Keys.ToList();
            cmbx_Conditions.DataSource = commonConditionList.Keys.ToList();
            commonActionsList = getCommonActionsList();
            cmbx_Actions.DataSource = commonActionsList.Keys.ToList();
            additionRulesDescriptionList = getListAdditionalRulesDescription();
            lsbx_AdditionalRules.DataSource = additionRulesDescriptionList;

            gb_mainCondition.Enabled = (additionRulesDescriptionList.Count == 0) ? true : false;

        }

        private void fillForm()
        {
            if (rule == null) { return; }
            txbx_TargetColumn.Text = rule.ActionColumn.ToString();
            txbx_MainParameter.Text = rule.MainCondition.Param1;
            string opAlias = "";
            if (rule.MainCondition.CondOperation != null)
            {
                opAlias = rule.MainCondition.CondOperation.GetType().GetField("description").GetValue(null).ToString();
                if (commonConditionList.Keys.Contains(opAlias))
                {
                    cmbx_MainCondition.SelectedItem = opAlias;
                }
            }
        }

        private Dictionary<string, Operation> getCommonConditionList()
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

        private List<string> getListAdditionalRulesDescription()
        {
            List<string> rd = new List<string>();
            foreach (Condition cond in rule.ConditionList)
            {
                rd.Add(cond.ToString());
            }
            return rd;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            List<Condition> tempConditionList = rule.ConditionList;
            Rule NewRule = getNewRule(tempConditionList);
            rule = (NewRule == null) ? rule : NewRule;
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
            Condition newCond = getNewCondition();
            List<Condition> tempConditionList = rule.ConditionList;
            tempConditionList.Add(newCond);

            Rule NewRule = getNewRule(tempConditionList);
            rule = (NewRule==null)?rule: NewRule;

            lsbx_AdditionalRules.DataSource = null;
            additionRulesDescriptionList = getListAdditionalRulesDescription();
            lsbx_AdditionalRules.DataSource = additionRulesDescriptionList;
            clearAdditionFormElements();
        }

        private Condition getNewCondition()
        {
            string ConditionName = cmbx_Conditions.Text;
            string Param1 = txbx_Param1.Text;
            string Param2 = txbx_Param2.Text;
            string Suffix = txbx_Suffix.Text;
            Operation op = null;
            commonConditionList.TryGetValue(ConditionName, out op);
            Condition cond = new Condition(Param1, Param2, op, Suffix);
            Console.WriteLine(cond);
            return cond;
        }

        private Rule getNewRule(List<Condition> tempConditionList)
        {
            Action act = null;
            string ActionName = cmbx_Actions.Text;
            commonActionsList.TryGetValue(ActionName, out act);

            string TargetColumn = txbx_TargetColumn.Text;
            string MainParameter = txbx_MainParameter.Text;
            Operation MainOp = null;
            string MainConditionName = cmbx_MainCondition.Text;
            commonConditionList.TryGetValue(MainConditionName, out MainOp);
            Condition MainCond = new Condition(MainParameter, null, MainOp, null);
            try
            {
                Rule NewRule = new Rule(MainCond, tempConditionList, TargetColumn, act);
                return NewRule;
            }
            catch (ActionException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btn_RemoveCondition_Click(object sender, EventArgs e)
        {
            string AdditionalRulesDescription = lsbx_AdditionalRules.SelectedItem.ToString();
            rule.removeCondition(AdditionalRulesDescription);
            additionRulesDescriptionList = getListAdditionalRulesDescription();
            lsbx_AdditionalRules.DataSource = additionRulesDescriptionList;
            clearAdditionFormElements();
        }

        private void clearAdditionFormElements()
        {
            txbx_Param1.Clear();
            txbx_Param2.Clear();
            txbx_Suffix.Clear();
        }

    }
}
