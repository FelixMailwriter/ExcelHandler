namespace ExcelHandler
{
    using static main;

    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbx_path = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.lsbx_Type = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.btn_addRuleType = new System.Windows.Forms.Button();
            this.lsbx_Alias = new System.Windows.Forms.ListBox();
            this.btn_removeRuleType = new System.Windows.Forms.Button();
            this.btn_addAlias = new System.Windows.Forms.Button();
            this.btn_removeAlias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbx_Rule = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addRule = new System.Windows.Forms.Button();
            this.btn_removeRule = new System.Windows.Forms.Button();
            this.txbx_NewRuleType = new System.Windows.Forms.TextBox();
            this.txbx_Alias = new System.Windows.Forms.TextBox();
            this.btn_EditRule = new System.Windows.Forms.Button();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.SourceData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ParsedData = new System.Windows.Forms.TabPage();
            this.btn_exec = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.RulesSettings = new System.Windows.Forms.TabPage();
            this.btn_saveRules = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_main.SuspendLayout();
            this.SourceData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ParsedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.RulesSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_path
            // 
            this.txbx_path.Location = new System.Drawing.Point(18, 24);
            this.txbx_path.Name = "txbx_path";
            this.txbx_path.Size = new System.Drawing.Size(683, 20);
            this.txbx_path.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(707, 24);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lsbx_Type
            // 
            this.lsbx_Type.DisplayMember = "Name";
            this.lsbx_Type.FormattingEnabled = true;
            this.lsbx_Type.Location = new System.Drawing.Point(36, 29);
            this.lsbx_Type.Name = "lsbx_Type";
            this.lsbx_Type.Size = new System.Drawing.Size(146, 95);
            this.lsbx_Type.TabIndex = 2;
            this.lsbx_Type.ValueMember = "Name";
            this.lsbx_Type.SelectedIndexChanged += new System.EventHandler(this.lsbx_Type_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(93, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Тип";
            // 
            // btn_addRuleType
            // 
            this.btn_addRuleType.Location = new System.Drawing.Point(39, 156);
            this.btn_addRuleType.Name = "btn_addRuleType";
            this.btn_addRuleType.Size = new System.Drawing.Size(60, 23);
            this.btn_addRuleType.TabIndex = 4;
            this.btn_addRuleType.Text = "+";
            this.btn_addRuleType.UseVisualStyleBackColor = true;
            this.btn_addRuleType.Click += new System.EventHandler(this.btn_addRuleType_Click);
            // 
            // lsbx_Alias
            // 
            this.lsbx_Alias.FormattingEnabled = true;
            this.lsbx_Alias.Location = new System.Drawing.Point(233, 29);
            this.lsbx_Alias.Name = "lsbx_Alias";
            this.lsbx_Alias.Size = new System.Drawing.Size(145, 95);
            this.lsbx_Alias.TabIndex = 2;
            // 
            // btn_removeRuleType
            // 
            this.btn_removeRuleType.Location = new System.Drawing.Point(122, 156);
            this.btn_removeRuleType.Name = "btn_removeRuleType";
            this.btn_removeRuleType.Size = new System.Drawing.Size(60, 23);
            this.btn_removeRuleType.TabIndex = 4;
            this.btn_removeRuleType.Text = "-";
            this.btn_removeRuleType.UseVisualStyleBackColor = true;
            this.btn_removeRuleType.Click += new System.EventHandler(this.btn_removeRuleType_Click);
            // 
            // btn_addAlias
            // 
            this.btn_addAlias.Location = new System.Drawing.Point(233, 156);
            this.btn_addAlias.Name = "btn_addAlias";
            this.btn_addAlias.Size = new System.Drawing.Size(60, 23);
            this.btn_addAlias.TabIndex = 4;
            this.btn_addAlias.Text = "+";
            this.btn_addAlias.UseVisualStyleBackColor = true;
            this.btn_addAlias.Click += new System.EventHandler(this.btn_addAlias_Click);
            // 
            // btn_removeAlias
            // 
            this.btn_removeAlias.Location = new System.Drawing.Point(318, 156);
            this.btn_removeAlias.Name = "btn_removeAlias";
            this.btn_removeAlias.Size = new System.Drawing.Size(60, 23);
            this.btn_removeAlias.TabIndex = 4;
            this.btn_removeAlias.Text = "-";
            this.btn_removeAlias.UseVisualStyleBackColor = true;
            this.btn_removeAlias.Click += new System.EventHandler(this.btn_removeAlias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Псевдонимы";
            // 
            // lsbx_Rule
            // 
            this.lsbx_Rule.FormattingEnabled = true;
            this.lsbx_Rule.Location = new System.Drawing.Point(471, 29);
            this.lsbx_Rule.Name = "lsbx_Rule";
            this.lsbx_Rule.Size = new System.Drawing.Size(263, 95);
            this.lsbx_Rule.TabIndex = 5;
            this.lsbx_Rule.DoubleClick += new System.EventHandler(this.lsbx_Rule_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правила";
            // 
            // btn_addRule
            // 
            this.btn_addRule.Location = new System.Drawing.Point(471, 156);
            this.btn_addRule.Name = "btn_addRule";
            this.btn_addRule.Size = new System.Drawing.Size(60, 23);
            this.btn_addRule.TabIndex = 4;
            this.btn_addRule.Text = "+";
            this.btn_addRule.UseVisualStyleBackColor = true;
            this.btn_addRule.Click += new System.EventHandler(this.btn_addRule_Click);
            // 
            // btn_removeRule
            // 
            this.btn_removeRule.Location = new System.Drawing.Point(570, 156);
            this.btn_removeRule.Name = "btn_removeRule";
            this.btn_removeRule.Size = new System.Drawing.Size(60, 23);
            this.btn_removeRule.TabIndex = 4;
            this.btn_removeRule.Text = "-";
            this.btn_removeRule.UseVisualStyleBackColor = true;
            // 
            // txbx_NewRuleType
            // 
            this.txbx_NewRuleType.Location = new System.Drawing.Point(39, 130);
            this.txbx_NewRuleType.Name = "txbx_NewRuleType";
            this.txbx_NewRuleType.Size = new System.Drawing.Size(143, 20);
            this.txbx_NewRuleType.TabIndex = 10;
            // 
            // txbx_Alias
            // 
            this.txbx_Alias.Location = new System.Drawing.Point(233, 130);
            this.txbx_Alias.Name = "txbx_Alias";
            this.txbx_Alias.Size = new System.Drawing.Size(145, 20);
            this.txbx_Alias.TabIndex = 10;
            // 
            // btn_EditRule
            // 
            this.btn_EditRule.Location = new System.Drawing.Point(674, 156);
            this.btn_EditRule.Name = "btn_EditRule";
            this.btn_EditRule.Size = new System.Drawing.Size(60, 23);
            this.btn_EditRule.TabIndex = 12;
            this.btn_EditRule.Text = "Edit";
            this.btn_EditRule.UseVisualStyleBackColor = true;
            this.btn_EditRule.Click += new System.EventHandler(this.btn_EditRule_Click);
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.SourceData);
            this.tab_main.Controls.Add(this.ParsedData);
            this.tab_main.Controls.Add(this.RulesSettings);
            this.tab_main.Location = new System.Drawing.Point(12, 12);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(809, 534);
            this.tab_main.TabIndex = 13;
            // 
            // SourceData
            // 
            this.SourceData.Controls.Add(this.dataGridView1);
            this.SourceData.Controls.Add(this.txbx_path);
            this.SourceData.Controls.Add(this.btn_open);
            this.SourceData.Location = new System.Drawing.Point(4, 22);
            this.SourceData.Name = "SourceData";
            this.SourceData.Padding = new System.Windows.Forms.Padding(3);
            this.SourceData.Size = new System.Drawing.Size(801, 508);
            this.SourceData.TabIndex = 0;
            this.SourceData.Text = "Исходные данные";
            this.SourceData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lengthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(18, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 411);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ParsedData
            // 
            this.ParsedData.Controls.Add(this.btn_exec);
            this.ParsedData.Controls.Add(this.dataGridView2);
            this.ParsedData.Controls.Add(this.btn_save);
            this.ParsedData.Location = new System.Drawing.Point(4, 22);
            this.ParsedData.Name = "ParsedData";
            this.ParsedData.Padding = new System.Windows.Forms.Padding(3);
            this.ParsedData.Size = new System.Drawing.Size(801, 508);
            this.ParsedData.TabIndex = 2;
            this.ParsedData.Text = "Выходные данные";
            this.ParsedData.UseVisualStyleBackColor = true;
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(19, 24);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(108, 20);
            this.btn_exec.TabIndex = 12;
            this.btn_exec.Text = "Выполнить";
            this.btn_exec.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(765, 430);
            this.dataGridView2.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(709, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // RulesSettings
            // 
            this.RulesSettings.Controls.Add(this.btn_saveRules);
            this.RulesSettings.Controls.Add(this.lsbx_Type);
            this.RulesSettings.Controls.Add(this.btn_EditRule);
            this.RulesSettings.Controls.Add(this.lsbx_Alias);
            this.RulesSettings.Controls.Add(this.label);
            this.RulesSettings.Controls.Add(this.txbx_Alias);
            this.RulesSettings.Controls.Add(this.label1);
            this.RulesSettings.Controls.Add(this.txbx_NewRuleType);
            this.RulesSettings.Controls.Add(this.label2);
            this.RulesSettings.Controls.Add(this.lsbx_Rule);
            this.RulesSettings.Controls.Add(this.btn_addRuleType);
            this.RulesSettings.Controls.Add(this.btn_removeRule);
            this.RulesSettings.Controls.Add(this.btn_addAlias);
            this.RulesSettings.Controls.Add(this.btn_removeAlias);
            this.RulesSettings.Controls.Add(this.btn_addRule);
            this.RulesSettings.Controls.Add(this.btn_removeRuleType);
            this.RulesSettings.Location = new System.Drawing.Point(4, 22);
            this.RulesSettings.Name = "RulesSettings";
            this.RulesSettings.Padding = new System.Windows.Forms.Padding(3);
            this.RulesSettings.Size = new System.Drawing.Size(801, 508);
            this.RulesSettings.TabIndex = 1;
            this.RulesSettings.Text = "Настройка правил";
            this.RulesSettings.UseVisualStyleBackColor = true;
            // 
            // btn_saveRules
            // 
            this.btn_saveRules.Location = new System.Drawing.Point(659, 206);
            this.btn_saveRules.Name = "btn_saveRules";
            this.btn_saveRules.Size = new System.Drawing.Size(75, 23);
            this.btn_saveRules.TabIndex = 13;
            this.btn_saveRules.Text = "Сохранить";
            this.btn_saveRules.UseVisualStyleBackColor = true;
            this.btn_saveRules.Click += new System.EventHandler(this.btn_saveRules_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SourceItemsList";
            this.bindingSource1.DataSource = typeof(ExcelHandler.main);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.itemPropertiesBindingSource;
            // 
            // itemPropertiesBindingSource
            // 
            this.itemPropertiesBindingSource.DataMember = "ItemProperties";
            this.itemPropertiesBindingSource.DataSource = this.bindingSource1;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 558);
            this.Controls.Add(this.tab_main);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tab_main.ResumeLayout(false);
            this.SourceData.ResumeLayout(false);
            this.SourceData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ParsedData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.RulesSettings.ResumeLayout(false);
            this.RulesSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_path;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ListBox lsbx_Type;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_addRuleType;
        private System.Windows.Forms.ListBox lsbx_Alias;
        private System.Windows.Forms.Button btn_removeRuleType;
        private System.Windows.Forms.Button btn_addAlias;
        private System.Windows.Forms.Button btn_removeAlias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbx_Rule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addRule;
        private System.Windows.Forms.Button btn_removeRule;
        private System.Windows.Forms.TextBox txbx_NewRuleType;
        private System.Windows.Forms.TextBox txbx_Alias;
        private System.Windows.Forms.Button btn_EditRule;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage SourceData;
        private System.Windows.Forms.TabPage RulesSettings;
        private System.Windows.Forms.TabPage ParsedData;
        private System.Windows.Forms.Button btn_saveRules;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource itemPropertiesBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

