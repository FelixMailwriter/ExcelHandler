using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ExcelHandler.Common;

namespace ExcelHandler
{
    public partial class MainForm : Form
    {
        public delegate void FileSelectedHandler(String filename);
        public event FileSelectedHandler FileSelected;
        private RulesManager rm;
        private main eh;
        private SettingsKeeper sk;

        public MainForm()
        {
            InitializeComponent();
            eh = new main(this);
            rm = eh.rm;
            sk = SettingsKeeper.getInstance();
            updateTypeRulesList();
            fillForm();
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
            lsbx_Type.SelectedItem = NewRuleTypeName;
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
            List<string> Aliases = pt.Aliases;
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
            DialogResult dr = MessageBox.Show("Вы уверены?", "Подтверждение удаления", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr != DialogResult.OK) { return; }
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
            lsbx_Type.SelectedItem = TypeName;
        }

        private void btn_removeAlias_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены?", "Подтверждение удаления", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr != DialogResult.OK) { return; }
            if ((lsbx_Type.SelectedIndex < 0) || (lsbx_Alias.SelectedIndex < 0)) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            string AliasName = lsbx_Alias.SelectedItem.ToString();
            rm.removeAlias(TypeName, AliasName);
            updateTypeRulesList();
            lsbx_Type.SelectedItem = TypeName;
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
                Rule NewRule = ARForm.rule;
                pt.changeRule(rule, NewRule);
            }
            updateRulesList(pt);
        }

        private void btn_saveRules_Click(object sender, EventArgs e)
        {
            eh.rm.saveRules();
        }

        private void lsbx_Rule_DoubleClick(object sender, EventArgs e)
        {
            btn_EditRule_Click(sender, e);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Microsoft Excel (*.xlsm)|*.xlsm|Microsoft Excel (*.xls)|*.xls";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txbx_path.Text = fd.FileName;
                FileSelected(fd.FileName);
            }
            fillSourceItemTable();
        }

        private void fillSourceItemTable()
        {
            dataGridView1.DataSource = eh.SourceItemsTable;
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            DataTable [] HandledItems = new DataTable[2];
            HandledItems = eh.ic.compareItems(eh.SourceItemsTable);
            dgv_Result.DataSource = HandledItems[0];
            dgv_Result.Refresh();
            dgv_NotHandledItems.DataSource = HandledItems[1];
            //dgv_Result.DataSource = HandledItems[0];
        }

        private void btn_CopyRule_Click(object sender, EventArgs e)
        {
            if (lsbx_Rule.SelectedIndex < 0) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            ProductTypeRuleList pt = rm.getType(TypeName);
            string RuleDescription = "";
            RuleDescription = lsbx_Rule.SelectedItem.ToString();
            Rule rule = pt.getRuleByDescription(RuleDescription);
            Rule NewRule = new Rule(rule);
            NewRule.Name = "NewRule";
            pt.addRule(NewRule);
            updateRulesList(pt);
        }

        private void btn_removeRule_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены?", "Подтверждение удаления", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr!=DialogResult.OK) { return; }
            if (lsbx_Rule.SelectedIndex < 0) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            ProductTypeRuleList pt = rm.getType(TypeName);
            string RuleDescription = "";
            RuleDescription = lsbx_Rule.SelectedItem.ToString();
            Rule rule = pt.getRuleByDescription(RuleDescription);
            pt.Rules.Remove(rule);
            updateRulesList(pt);
        }

        private void btn_CopyType_Click(object sender, EventArgs e)
        {
            string NewRuleTypeName = txbx_NewRuleType.Text.Trim();
            if (NewRuleTypeName.Equals(""))
            {
                showMessage("Не указано имя нового типа");
                return;
            }
            string SourceRuleTypeName = lsbx_Type.SelectedItem.ToString();
            try
            {
                rm.addRuleType(NewRuleTypeName);
            }
            catch (ArgumentException ex)
            {
                showMessage(ex.Message);
            }
            txbx_NewRuleType.Clear();
            rm.copyType(SourceRuleTypeName, NewRuleTypeName);
            updateTypeRulesList();
        }

        private void btn_RuleUp_Click(object sender, EventArgs e)
        {
            if (lsbx_Rule.SelectedIndex < 0) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            ProductTypeRuleList pt = rm.getType(TypeName);
            string RuleName = lsbx_Rule.SelectedItem.ToString();
            pt.moveRuleUp(RuleName);
            updateRulesList(pt);
            lsbx_Rule.SelectedItem = RuleName;
        }

        private void btn_RuleDown_Click(object sender, EventArgs e)
        {
            if (lsbx_Rule.SelectedIndex < 0) { return; }
            string TypeName = lsbx_Type.SelectedItem.ToString();
            ProductTypeRuleList pt = rm.getType(TypeName);
            string RuleName = lsbx_Rule.SelectedItem.ToString();
            pt.moveRuleDown(RuleName);
            updateRulesList(pt);
            lsbx_Rule.SelectedItem = RuleName;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable SavedItems = (DataTable)dgv_Result.DataSource;
            List<string> pElement = (List<string>)lsbx_SelCol.DataSource;
            if (SavedItems == null)
            {
                MessageBox.Show("Таблица результатов пуста", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string path = (sk.SaveResultsPath.Equals("")) ? "C:\\" : sk.SaveResultsPath;

            if (sk.AlwaysAskSavingPath)
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.SelectedPath = path;
                DialogResult dr = fd.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    path = fd.SelectedPath;
                }
                else
                {
                    return;
                }
            }
            //else
            //{
            //    path = (sk.SaveResultsPath.Equals("")) ? "C:\\" : sk.SaveResultsPath;
            //}
                eh.saveTable(path, SavedItems, pElement);
                MessageBox.Show("Файл сохранен", "Статус операции", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_AddCol_Click(object sender, EventArgs e)
        {
            pElements.addSelectedColumns(lsbx_AccCol.SelectedItem.ToString());
            lsbx_SelCol.DataSource = null;
            lsbx_SelCol.DataSource = pElements.SelectedColumns;
            pElements.saveParams();
        }

        private void btn_DelCol_Click(object sender, EventArgs e)
        {
            pElements.removeSelectedColumns(lsbx_SelCol.SelectedItem.ToString());
            lsbx_SelCol.DataSource = null;
            lsbx_SelCol.DataSource = pElements.SelectedColumns;
            pElements.saveParams();
        }

        private void cxbx_AlwaysAskPath_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbx_AlwaysAskPath.Checked)
            {
                txbx_PathToSavedFiles.Enabled = false;
                btn_browsePath.Enabled = false;
                sk.AlwaysAskSavingPath = true;
                sk.saveSettings(this, null);
            }
            else
            {
                sk.AlwaysAskSavingPath = false;
                txbx_PathToSavedFiles.Enabled = true;
                btn_browsePath.Enabled = true;
                txbx_PathToSavedFiles.Text = sk.SaveResultsPath;
                sk.saveSettings(this, null);
            }
        }

        private void btn_browsePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog(this);
            string path = "";
            if (dr == DialogResult.OK)
            {
                sk.SaveResultsPath = fd.SelectedPath;
                txbx_PathToSavedFiles.Text = sk.SaveResultsPath;
                sk.saveSettings(this, null);
            }
        }

        private void btn_SaveSourceData_Click(object sender, EventArgs e)
        {
            DataTable SourceData = (DataTable)dataGridView1.DataSource;
            eh.SaveSourceData(SourceData);
            MessageBox.Show("Исходные данные сохранены", "Результат операции", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }

}
