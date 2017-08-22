﻿namespace ExcelHandler
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
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.RulesSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_saveRules = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CopyRule = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_main.SuspendLayout();
            this.SourceData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ParsedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.RulesSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.btn_open.Size = new System.Drawing.Size(89, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lsbx_Type
            // 
            this.lsbx_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbx_Type.DisplayMember = "Name";
            this.lsbx_Type.FormattingEnabled = true;
            this.lsbx_Type.Location = new System.Drawing.Point(3, 16);
            this.lsbx_Type.Name = "lsbx_Type";
            this.lsbx_Type.Size = new System.Drawing.Size(209, 342);
            this.lsbx_Type.TabIndex = 2;
            this.lsbx_Type.ValueMember = "Name";
            this.lsbx_Type.SelectedIndexChanged += new System.EventHandler(this.lsbx_Type_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(209, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Тип";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_addRuleType
            // 
            this.btn_addRuleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addRuleType.AutoSize = true;
            this.btn_addRuleType.Location = new System.Drawing.Point(3, 3);
            this.btn_addRuleType.Name = "btn_addRuleType";
            this.btn_addRuleType.Size = new System.Drawing.Size(98, 23);
            this.btn_addRuleType.TabIndex = 4;
            this.btn_addRuleType.Text = "+";
            this.btn_addRuleType.UseVisualStyleBackColor = true;
            this.btn_addRuleType.Click += new System.EventHandler(this.btn_addRuleType_Click);
            // 
            // lsbx_Alias
            // 
            this.lsbx_Alias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbx_Alias.FormattingEnabled = true;
            this.lsbx_Alias.Location = new System.Drawing.Point(218, 16);
            this.lsbx_Alias.Name = "lsbx_Alias";
            this.lsbx_Alias.Size = new System.Drawing.Size(209, 342);
            this.lsbx_Alias.TabIndex = 2;
            // 
            // btn_removeRuleType
            // 
            this.btn_removeRuleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removeRuleType.Location = new System.Drawing.Point(107, 3);
            this.btn_removeRuleType.Name = "btn_removeRuleType";
            this.btn_removeRuleType.Size = new System.Drawing.Size(99, 23);
            this.btn_removeRuleType.TabIndex = 4;
            this.btn_removeRuleType.Text = "-";
            this.btn_removeRuleType.UseVisualStyleBackColor = true;
            this.btn_removeRuleType.Click += new System.EventHandler(this.btn_removeRuleType_Click);
            // 
            // btn_addAlias
            // 
            this.btn_addAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addAlias.Location = new System.Drawing.Point(3, 3);
            this.btn_addAlias.Name = "btn_addAlias";
            this.btn_addAlias.Size = new System.Drawing.Size(98, 23);
            this.btn_addAlias.TabIndex = 4;
            this.btn_addAlias.Text = "+";
            this.btn_addAlias.UseVisualStyleBackColor = true;
            this.btn_addAlias.Click += new System.EventHandler(this.btn_addAlias_Click);
            // 
            // btn_removeAlias
            // 
            this.btn_removeAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removeAlias.Location = new System.Drawing.Point(107, 3);
            this.btn_removeAlias.Name = "btn_removeAlias";
            this.btn_removeAlias.Size = new System.Drawing.Size(99, 23);
            this.btn_removeAlias.TabIndex = 4;
            this.btn_removeAlias.Text = "-";
            this.btn_removeAlias.UseVisualStyleBackColor = true;
            this.btn_removeAlias.Click += new System.EventHandler(this.btn_removeAlias_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Псевдонимы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbx_Rule
            // 
            this.lsbx_Rule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbx_Rule.FormattingEnabled = true;
            this.lsbx_Rule.Location = new System.Drawing.Point(433, 16);
            this.lsbx_Rule.Name = "lsbx_Rule";
            this.lsbx_Rule.Size = new System.Drawing.Size(424, 342);
            this.lsbx_Rule.TabIndex = 5;
            this.lsbx_Rule.DoubleClick += new System.EventHandler(this.lsbx_Rule_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правила";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_addRule
            // 
            this.btn_addRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addRule.Location = new System.Drawing.Point(3, 3);
            this.btn_addRule.Name = "btn_addRule";
            this.btn_addRule.Size = new System.Drawing.Size(141, 23);
            this.btn_addRule.TabIndex = 4;
            this.btn_addRule.Text = "+";
            this.btn_addRule.UseVisualStyleBackColor = true;
            this.btn_addRule.Click += new System.EventHandler(this.btn_addRule_Click);
            // 
            // btn_removeRule
            // 
            this.btn_removeRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removeRule.Location = new System.Drawing.Point(150, 3);
            this.btn_removeRule.Name = "btn_removeRule";
            this.btn_removeRule.Size = new System.Drawing.Size(141, 23);
            this.btn_removeRule.TabIndex = 4;
            this.btn_removeRule.Text = "-";
            this.btn_removeRule.UseVisualStyleBackColor = true;
            this.btn_removeRule.Click += new System.EventHandler(this.btn_removeRule_Click);
            // 
            // txbx_NewRuleType
            // 
            this.txbx_NewRuleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_NewRuleType.Location = new System.Drawing.Point(57, 3);
            this.txbx_NewRuleType.Name = "txbx_NewRuleType";
            this.txbx_NewRuleType.Size = new System.Drawing.Size(149, 20);
            this.txbx_NewRuleType.TabIndex = 10;
            // 
            // txbx_Alias
            // 
            this.txbx_Alias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_Alias.Location = new System.Drawing.Point(80, 3);
            this.txbx_Alias.Name = "txbx_Alias";
            this.txbx_Alias.Size = new System.Drawing.Size(126, 20);
            this.txbx_Alias.TabIndex = 10;
            // 
            // btn_EditRule
            // 
            this.btn_EditRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditRule.Location = new System.Drawing.Point(297, 3);
            this.btn_EditRule.Name = "btn_EditRule";
            this.btn_EditRule.Size = new System.Drawing.Size(64, 23);
            this.btn_EditRule.TabIndex = 12;
            this.btn_EditRule.Text = "Edit";
            this.btn_EditRule.UseVisualStyleBackColor = true;
            this.btn_EditRule.Click += new System.EventHandler(this.btn_EditRule_Click);
            // 
            // tab_main
            // 
            this.tab_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_main.Controls.Add(this.SourceData);
            this.tab_main.Controls.Add(this.ParsedData);
            this.tab_main.Controls.Add(this.RulesSettings);
            this.tab_main.Location = new System.Drawing.Point(12, 12);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(904, 527);
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
            this.SourceData.Size = new System.Drawing.Size(955, 488);
            this.SourceData.TabIndex = 0;
            this.SourceData.Text = "Исходные данные";
            this.SourceData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 385);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ParsedData
            // 
            this.ParsedData.Controls.Add(this.btn_exec);
            this.ParsedData.Controls.Add(this.dgv_Result);
            this.ParsedData.Controls.Add(this.btn_save);
            this.ParsedData.Location = new System.Drawing.Point(4, 22);
            this.ParsedData.Name = "ParsedData";
            this.ParsedData.Padding = new System.Windows.Forms.Padding(3);
            this.ParsedData.Size = new System.Drawing.Size(955, 488);
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
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // dgv_Result
            // 
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Location = new System.Drawing.Point(19, 59);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.Size = new System.Drawing.Size(1096, 430);
            this.dgv_Result.TabIndex = 10;
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
            this.RulesSettings.Controls.Add(this.tableLayoutPanel1);
            this.RulesSettings.Location = new System.Drawing.Point(4, 22);
            this.RulesSettings.Name = "RulesSettings";
            this.RulesSettings.Padding = new System.Windows.Forms.Padding(3);
            this.RulesSettings.Size = new System.Drawing.Size(896, 501);
            this.RulesSettings.TabIndex = 1;
            this.RulesSettings.Text = "Настройка правил";
            this.RulesSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_saveRules, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lsbx_Alias, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lsbx_Type, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lsbx_Rule, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.535353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.46465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 476);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_removeRuleType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_addRuleType, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 407);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(209, 31);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_saveRules
            // 
            this.btn_saveRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveRules.Location = new System.Drawing.Point(782, 450);
            this.btn_saveRules.Name = "btn_saveRules";
            this.btn_saveRules.Size = new System.Drawing.Size(75, 23);
            this.btn_saveRules.TabIndex = 13;
            this.btn_saveRules.Text = "Сохранить";
            this.btn_saveRules.UseVisualStyleBackColor = true;
            this.btn_saveRules.Click += new System.EventHandler(this.btn_saveRules_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_addAlias, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_removeAlias, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(218, 407);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(209, 31);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Controls.Add(this.btn_removeRule, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_CopyRule, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_EditRule, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_addRule, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(433, 407);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(424, 31);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // btn_CopyRule
            // 
            this.btn_CopyRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CopyRule.Location = new System.Drawing.Point(367, 3);
            this.btn_CopyRule.Name = "btn_CopyRule";
            this.btn_CopyRule.Size = new System.Drawing.Size(54, 23);
            this.btn_CopyRule.TabIndex = 14;
            this.btn_CopyRule.Text = "Copy";
            this.btn_CopyRule.UseVisualStyleBackColor = true;
            this.btn_CopyRule.Click += new System.EventHandler(this.btn_CopyRule_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.91241F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.08759F));
            this.tableLayoutPanel5.Controls.Add(this.txbx_NewRuleType, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 374);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(209, 27);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Новый тип";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.16216F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.83784F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txbx_Alias, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(218, 374);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(209, 27);
            this.tableLayoutPanel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Новый псевдоним";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.tab_main);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tab_main.ResumeLayout(false);
            this.SourceData.ResumeLayout(false);
            this.SourceData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ParsedData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.RulesSettings.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_CopyRule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
    }
}

