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
            criteriaDescriptionList = GetCriteriaDescriptionList();
            lsbx_Criterias.DataSource = criteriaDescriptionList;

            //gb_mainCondition.Enabled = (additionRulesDescriptionList.Count == 0) ? true : false;

        }

        private void fillForm()
        {
            if (rule == null) { return; }
            txbx_RuleName.Text = rule.Name;
            txbx_CheckedColumn.Text = rule.CheckedColumn.ToString();
            txbx_TargetColumn.Text = rule.TargetColumn.ToString();
            txbx_SourceValueColumn.Text = rule.SourceValueColumn.ToString();
            txbx_MainParameter.Text = rule.MainCondition.Param1;
            txbx_DefaultValue.Text = rule.DefaultValue;
            txbx_ChangedColumn.Text = rule.ChangedColumn.ToString();
            txbx_ChangedValue.Text = (rule.ChangedValue==null)?"":rule.ChangedValue.ToString();
            cbx_swap.Checked = rule.SwapLengthWidth;
            if (rule.ActionInstance != null)
            {
                string ActionName = rule.ActionInstance.GetType().GetField("description").GetValue(null).ToString();
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
                opDescriptionList.Add(opDescription, (Operation)Activator.CreateInstance(TestType));
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

        private List<string> GetCriteriaDescriptionList()
        {
            return rule.getCriteriaDescriptionsList();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!txbx_column1.Text.Equals("")) { btn_addCondition_Click(null, null); }
            string Name = txbx_RuleName.Text;
            string ConditionName = cmbx_MainCondition.Text;
            Operation op = null;
            commonOperationList.TryGetValue(ConditionName, out op);
            Condition MainCondition = new Condition(txbx_MainParameter.Text, null, 
                                                                                op, getValueColumn(txbx_CheckedColumn.Text));
            Action act = null;
            commonActionsList.TryGetValue(cmbx_Actions.Text, out act);
            try
            {
                int CheckedColumn = getValueColumn(txbx_CheckedColumn.Text);
                int TargetColumn = getValueColumn(txbx_TargetColumn.Text);

                int SourceValueColumn= (txbx_SourceValueColumn.Text.Equals(""))?
                                                        0: getValueColumn(txbx_SourceValueColumn.Text);
                int ChangedColumn = (txbx_ChangedColumn.Text.Equals("")) ?
                                        0 : getValueColumn(txbx_ChangedColumn.Text);

                Rule NewRule = new Rule(Name, MainCondition, CheckedColumn, TargetColumn, 
                                                    SourceValueColumn, act, txbx_DefaultValue.Text,
                                                    ChangedColumn, txbx_ChangedValue.Text);
            NewRule.CriteriaList = rule.CriteriaList;
            NewRule.SwapLengthWidth = cbx_swap.Checked;
            rule = (NewRule == null) ? rule : NewRule;
            NewRule = null;
            DialogResult = DialogResult.OK;
            Close();
            }
            catch (ActionException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbx_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_Actions.SelectedItem.Equals("Заменить по условию"))
            {
                gb_additionCondition.Enabled = true;
                txbx_DefaultValue.Enabled = true;
            }
            else
            {
                gb_additionCondition.Enabled = false;
                txbx_DefaultValue.Enabled = false;
            }

            if (cmbx_Actions.SelectedItem.Equals("Заменить значением столбца"))
            {
                txbx_SourceValueColumn.Enabled = true;
                txbx_SourceValueColumn.Text = "0";
                txbx_ChangedColumn.Enabled = true;
                txbx_ChangedColumn.Text = "0";
                txbx_ChangedValue.Enabled = true;
            }
            else
            {
                txbx_SourceValueColumn.Enabled = false;
                txbx_SourceValueColumn.Clear();
                txbx_ChangedColumn.Enabled = false;
                txbx_ChangedValue.Enabled = false;
                txbx_ChangedColumn.Clear();
                txbx_ChangedValue.Clear();
            }
            if ((cmbx_Actions.SelectedItem.Equals("Копировать строку")) ||
                    (cmbx_Actions.SelectedItem.Equals("Пропустить строку")))
            {
                txbx_TargetColumn.Enabled = false;
            }
            else
            {
                txbx_TargetColumn.Enabled = true;
                txbx_TargetColumn.Text = (rule.TargetColumn == 0) ? txbx_TargetColumn.Text = "0" : rule.TargetColumn.ToString();
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

        private void btn_addCondition_Click(object sender, EventArgs e)
        {
            string colum1 = txbx_column1.Text;
            if (colum1.Equals(""))
            {
                MessageBox.Show("Не задан целевой столбец для условия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Criteria NewCriteria = CreateCriteria();
            rule.addCriteria(NewCriteria);

            lsbx_Criterias.DataSource = null;
            criteriaDescriptionList = GetCriteriaDescriptionList();
            lsbx_Criterias.DataSource = criteriaDescriptionList;
            clearAdditionFormElements();
        }

        private Criteria CreateCriteria()
        {
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
            return crit;
        }

        private void btn_RemoveCondition_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены?", "Подтверждение удаления", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr != DialogResult.OK) { return; }
            string CriteriaDescription = lsbx_Criterias.SelectedItem.ToString();
            rule.removeCriteria(CriteriaDescription);
            lsbx_Criterias.DataSource = GetCriteriaDescriptionList();
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
                throw new ActionException("Неверно задан столбец");
            }
        }

        private void btn_UpCondition_Click(object sender, EventArgs e)
        {
            string CriteriaDescription = lsbx_Criterias.SelectedItem.ToString();
            rule.UpCriteria(CriteriaDescription);
            lsbx_Criterias.DataSource = GetCriteriaDescriptionList();
            lsbx_Criterias.SelectedItem = CriteriaDescription;
        }

        private void btn_DownCondition_Click(object sender, EventArgs e)
        {
            string CriteriaDescription = lsbx_Criterias.SelectedItem.ToString();
            rule.DownCriteria(CriteriaDescription);
            lsbx_Criterias.DataSource = GetCriteriaDescriptionList();
            lsbx_Criterias.SelectedItem = CriteriaDescription;
        }

        private void cmbx_Actions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbx_Actions.SelectedItem.Equals("Заменить по условию"))
            {
                gb_additionCondition.Enabled = true;
                txbx_DefaultValue.Enabled = true;
            }
            else
            {
                gb_additionCondition.Enabled = false;
                txbx_DefaultValue.Enabled = false;
            }

            if (cmbx_Actions.SelectedItem.Equals("Заменить значением столбца"))
            {
                txbx_SourceValueColumn.Enabled = true;
                txbx_SourceValueColumn.Text = "0";
                rule.CriteriaList = new List<Criteria>();
                lsbx_Criterias.DataSource = GetCriteriaDescriptionList();
            }
            else
            {
                txbx_SourceValueColumn.Enabled = false;
                txbx_SourceValueColumn.Clear();
            }
            if ((cmbx_Actions.SelectedItem.Equals("Копировать строку")) ||
                    (cmbx_Actions.SelectedItem.Equals("Пропустить строку")))
            {
                txbx_TargetColumn.Enabled = false;
                rule.CriteriaList = new List<Criteria>();
                lsbx_Criterias.DataSource = GetCriteriaDescriptionList();
            }
            else
            {
                txbx_TargetColumn.Enabled = true;
                txbx_TargetColumn.Text = (rule.TargetColumn == 0) ? txbx_TargetColumn.Text = "0" : rule.TargetColumn.ToString();
            }
        }


        private void lsbx_Criterias_DoubleClick(object sender, EventArgs e)
        {
            int CriteriaIndex = lsbx_Criterias.SelectedIndex;
            if (CriteriaIndex >= 0)
            {
                FillCriteriaFields(CriteriaIndex);
            }
        }

        private void FillCriteriaFields(int criteriaIndex)
        {
            Criteria CurrentCriteria = rule.CriteriaList.ElementAt(criteriaIndex);
            txbx_column1.Text = CurrentCriteria.Conditions[0].TestValueColumn.ToString();
            cmbx_Conditions1.SelectedIndex= cmbx_Conditions1.FindString(CurrentCriteria.Conditions[0].CondOperation.ToString());
            txbx_Param1_1.Text=CurrentCriteria.Conditions[0].Param1;
            txbx_Param1_2.Text = CurrentCriteria.Conditions[0].Param2;
            txbx_Suffix.Text = CurrentCriteria.Suffix;
            if (CurrentCriteria.Conditions.Count > 1)
            {
                txbx_column2.Text = CurrentCriteria.Conditions[1].TestValueColumn.ToString();
                cmbx_Conditions2.SelectedItem = CurrentCriteria.Conditions[1].CondOperation;
                txbx_Param2_1.Text = CurrentCriteria.Conditions[1].Param1;
                txbx_Param2_2.Text = CurrentCriteria.Conditions[1].Param2;
            }
        }

        private void btn_WriteCriteria_Click(object sender, EventArgs e)
        {
            Criteria NewCriteria = CreateCriteria();
            int CriteriaIndex = lsbx_Criterias.SelectedIndex;
            rule.CriteriaList.RemoveAt(CriteriaIndex);
            rule.CriteriaList.Insert(CriteriaIndex, NewCriteria);
            lsbx_Criterias.DataSource = GetCriteriaDescriptionList();
        }
    }
}
