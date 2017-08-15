using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelHandler
{
    public partial class AddRule : Form
    {
        private Rule rule;
        private List<string> mainConditionList;
        private List<string> conditionList;
        private List<string> actionList;

        public AddRule()
        {
            InitializeComponent();
            prepareForm();
            fillForm();
        }

        public AddRule(Rule rule)
        {
            InitializeComponent();
            prepareForm();
            fillForm();
            this.rule = rule;
        }

        private void prepareForm()
        {
            mainConditionList = getListOperationsDescriptions();
            conditionList = getListOperationsDescriptions();
            cmbx_MainCondition.DataSource = mainConditionList;
            cmbx_Conditions.DataSource = conditionList;
            actionList = getListActionsDescriptions();
            cmbx_Actions.DataSource = actionList;
        }

        private List<string> getListOperationsDescriptions()
        {
            var t = typeof(Operation);
            List<string> opDescriptionList = new List<string>();
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
                    opDescriptionList.Add(opDescription);
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
        private void fillForm()
        {
            if(rule==null) { return; }
            txbx_TargetColumn.Text = rule.ActionColumn;
            txbx_MainParameter.Text = rule.MainCondition.Parameter;
            string opAlias=rule.MainCondition.CondOperation.GetType().GetField("description").GetValue(null).ToString();
            if (mainConditionList.Contains(opAlias)){
                cmbx_MainCondition.SelectedItem = opAlias;
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
    }
}
