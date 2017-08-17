using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelHandler
{
    public partial class MainForm : Form
    {
        public delegate void FileSelectedHandler(String filename);
        public event FileSelectedHandler FileSelected;
        private RulesManager rm;
        private main eh;

        public MainForm()
        {
            InitializeComponent();
            btn_open.Click += Btn_open_Click;
            eh = new main(this);
            rm = eh.rm;
            updateTypeRulesList();

        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txbx_path.Text = fd.FileName;
                FileSelected(fd.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Microsoft Excel (*.xlsx)|*.xlsx";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                //txbx_save.Text = sd.FileName;
            }
        }

        private void btn_addRuleType_Click(object sender, EventArgs e)
        {
            string NewRuleTypeName = txbx_NewRuleType.Text.Trim();
            if (NewRuleTypeName.Equals("")) { return; }
            try
            {
                rm.addRuleType(NewRuleTypeName);
            }
            catch (ArgumentException ex)
            {
                showMessage(ex.Message);
            }
            txbx_NewRuleType.Clear();
            updateTypeRulesList();
        }

        private void showMessage(string message)
        {
            MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateTypeRulesList()
        {
            lsbx_Type.DataSource = null;
            List<string> ListTypes = rm.getListRulesType();
            lsbx_Type.DataSource = ListTypes;
            if (ListTypes.Count <= 0) { return; }
        }

        private void updateAliasesList(string CurrentType)
        {
            lsbx_Alias.DataSource = null;
            if (lsbx_Type.SelectedItem == null) { return; }
            ProductTypeRuleList pt = rm.getType(CurrentType);
            List<string> Aliases = pt.Aliases;// rm.getAliasesList(CurrentType);
            if (Aliases.Count <= 0) { return; }
            lsbx_Alias.DataSource = Aliases;
        }

        private void updateRulesList(ProductTypeRuleList pt)
        {
            List<string> rulesDescriptionList = pt.getRulesDescriptionList();
            lsbx_Rule.DataSource = null;
            lsbx_Rule.DataSource = rulesDescriptionList;
        }

        private void updateDescriptionList(string CurrentType)
        {
            ProductTypeRuleList pt = rm.getType(CurrentType);
            List<string> rulesDescriptionList = pt.getRulesDescriptionList();
            lsbx_Rule.DataSource = null;
            lsbx_Rule.DataSource = rulesDescriptionList;
        }

        private void btn_removeRuleType_Click(object sender, EventArgs e)
        {
            if (lsbx_Type.SelectedIndex < 0) { return; }
            string RemovedName = lsbx_Type.SelectedValue.ToString();
            rm.removeType(RemovedName);
            updateTypeRulesList();
        }

        private void btn_addAlias_Click(object sender, EventArgs e)
        {
            string AliasName = txbx_Alias.Text;
            if ((lsbx_Type.SelectedIndex < 0) || (AliasName.Equals(""))) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            rm.addAlias(TypeName, AliasName);
            txbx_Alias.Clear();
            updateTypeRulesList();
        }

        private void btn_removeAlias_Click(object sender, EventArgs e)
        {
            if ((lsbx_Type.SelectedIndex < 0) || (lsbx_Alias.SelectedIndex < 0)) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            string AliasName = lsbx_Alias.SelectedItem.ToString();
            rm.removeAlias(TypeName, AliasName);
            updateTypeRulesList();
        }

        private void lsbx_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbx_Type.SelectedIndex < 0) { return; }
            updateAliasesList(lsbx_Type.SelectedItem.ToString());
            updateDescriptionList(lsbx_Type.SelectedItem.ToString());
        }

        private void btn_addRule_Click(object sender, EventArgs e)
        {
            if (lsbx_Type.SelectedIndex < 0)
            {
                MessageBox.Show("Не указан тип", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            ProductTypeRuleList pt = rm.getType(TypeName);
            Rule rule = new Rule();
            AddRule ARForm = new AddRule(rule);
            if (ARForm.ShowDialog() == DialogResult.OK)
            {
                rule = ARForm.rule;
                pt.addRule(rule);
                eh.rm.ptrl.Add(pt);
            }
            updateRulesList(pt);
        }

        private void btn_EditRule_Click(object sender, EventArgs e)
        {
            if (lsbx_Rule.SelectedIndex < 0) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            ProductTypeRuleList pt = rm.getType(TypeName);
            string RuleDescription = "";
            RuleDescription = lsbx_Rule.SelectedItem.ToString();
            Rule rule = pt.getRuleByDescription(RuleDescription);
            if (rule == null) { return; }
            AddRule ARForm = new AddRule(rule);
            if (ARForm.ShowDialog() == DialogResult.OK)
            {
                rule = ARForm.rule;
                //pt.addRule(rule);
            }
            updateRulesList(pt);
        }

        private void btn_saveRules_Click(object sender, EventArgs e)
        {
            eh.rm.saveRules();
        }
    }

}
