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
            this.btn_save = new System.Windows.Forms.Button();
            this.txbx_save = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_NewRuleType = new System.Windows.Forms.TextBox();
            this.txbx_Alias = new System.Windows.Forms.TextBox();
            this.btn_exec = new System.Windows.Forms.Button();
            this.btn_EditRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_path
            // 
            this.txbx_path.Location = new System.Drawing.Point(25, 32);
            this.txbx_path.Name = "txbx_path";
            this.txbx_path.Size = new System.Drawing.Size(334, 20);
            this.txbx_path.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(365, 29);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // lsbx_Type
            // 
            this.lsbx_Type.DisplayMember = "Name";
            this.lsbx_Type.FormattingEnabled = true;
            this.lsbx_Type.Location = new System.Drawing.Point(25, 135);
            this.lsbx_Type.Name = "lsbx_Type";
            this.lsbx_Type.Size = new System.Drawing.Size(146, 95);
            this.lsbx_Type.TabIndex = 2;
            this.lsbx_Type.ValueMember = "Name";
            this.lsbx_Type.SelectedIndexChanged += new System.EventHandler(this.lsbx_Type_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Тип";
            // 
            // btn_addRuleType
            // 
            this.btn_addRuleType.Location = new System.Drawing.Point(38, 276);
            this.btn_addRuleType.Name = "btn_addRuleType";
            this.btn_addRuleType.Size = new System.Drawing.Size(32, 23);
            this.btn_addRuleType.TabIndex = 4;
            this.btn_addRuleType.Text = "+";
            this.btn_addRuleType.UseVisualStyleBackColor = true;
            this.btn_addRuleType.Click += new System.EventHandler(this.btn_addRuleType_Click);
            // 
            // lsbx_Alias
            // 
            this.lsbx_Alias.FormattingEnabled = true;
            this.lsbx_Alias.Location = new System.Drawing.Point(222, 135);
            this.lsbx_Alias.Name = "lsbx_Alias";
            this.lsbx_Alias.Size = new System.Drawing.Size(145, 95);
            this.lsbx_Alias.TabIndex = 2;
            // 
            // btn_removeRuleType
            // 
            this.btn_removeRuleType.Location = new System.Drawing.Point(76, 277);
            this.btn_removeRuleType.Name = "btn_removeRuleType";
            this.btn_removeRuleType.Size = new System.Drawing.Size(32, 23);
            this.btn_removeRuleType.TabIndex = 4;
            this.btn_removeRuleType.Text = "-";
            this.btn_removeRuleType.UseVisualStyleBackColor = true;
            this.btn_removeRuleType.Click += new System.EventHandler(this.btn_removeRuleType_Click);
            // 
            // btn_addAlias
            // 
            this.btn_addAlias.Location = new System.Drawing.Point(232, 277);
            this.btn_addAlias.Name = "btn_addAlias";
            this.btn_addAlias.Size = new System.Drawing.Size(32, 23);
            this.btn_addAlias.TabIndex = 4;
            this.btn_addAlias.Text = "+";
            this.btn_addAlias.UseVisualStyleBackColor = true;
            this.btn_addAlias.Click += new System.EventHandler(this.btn_addAlias_Click);
            // 
            // btn_removeAlias
            // 
            this.btn_removeAlias.Location = new System.Drawing.Point(270, 278);
            this.btn_removeAlias.Name = "btn_removeAlias";
            this.btn_removeAlias.Size = new System.Drawing.Size(32, 23);
            this.btn_removeAlias.TabIndex = 4;
            this.btn_removeAlias.Text = "-";
            this.btn_removeAlias.UseVisualStyleBackColor = true;
            this.btn_removeAlias.Click += new System.EventHandler(this.btn_removeAlias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Псевдонимы";
            // 
            // lsbx_Rule
            // 
            this.lsbx_Rule.FormattingEnabled = true;
            this.lsbx_Rule.Location = new System.Drawing.Point(460, 135);
            this.lsbx_Rule.Name = "lsbx_Rule";
            this.lsbx_Rule.Size = new System.Drawing.Size(120, 95);
            this.lsbx_Rule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правила";
            // 
            // btn_addRule
            // 
            this.btn_addRule.Location = new System.Drawing.Point(460, 276);
            this.btn_addRule.Name = "btn_addRule";
            this.btn_addRule.Size = new System.Drawing.Size(28, 23);
            this.btn_addRule.TabIndex = 4;
            this.btn_addRule.Text = "+";
            this.btn_addRule.UseVisualStyleBackColor = true;
            this.btn_addRule.Click += new System.EventHandler(this.btn_addRule_Click);
            // 
            // btn_removeRule
            // 
            this.btn_removeRule.Location = new System.Drawing.Point(498, 277);
            this.btn_removeRule.Name = "btn_removeRule";
            this.btn_removeRule.Size = new System.Drawing.Size(28, 23);
            this.btn_removeRule.TabIndex = 4;
            this.btn_removeRule.Text = "-";
            this.btn_removeRule.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(365, 66);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txbx_save
            // 
            this.txbx_save.Location = new System.Drawing.Point(25, 69);
            this.txbx_save.Name = "txbx_save";
            this.txbx_save.Size = new System.Drawing.Size(334, 20);
            this.txbx_save.TabIndex = 6;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(25, 374);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(397, 95);
            this.listBox4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Содержание правила";
            // 
            // txbx_NewRuleType
            // 
            this.txbx_NewRuleType.Location = new System.Drawing.Point(28, 236);
            this.txbx_NewRuleType.Name = "txbx_NewRuleType";
            this.txbx_NewRuleType.Size = new System.Drawing.Size(143, 20);
            this.txbx_NewRuleType.TabIndex = 10;
            // 
            // txbx_Alias
            // 
            this.txbx_Alias.Location = new System.Drawing.Point(222, 236);
            this.txbx_Alias.Name = "txbx_Alias";
            this.txbx_Alias.Size = new System.Drawing.Size(145, 20);
            this.txbx_Alias.TabIndex = 10;
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(615, 32);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(108, 39);
            this.btn_exec.TabIndex = 11;
            this.btn_exec.Text = "Выполнить";
            this.btn_exec.UseVisualStyleBackColor = true;
            // 
            // btn_EditRule
            // 
            this.btn_EditRule.Location = new System.Drawing.Point(536, 277);
            this.btn_EditRule.Name = "btn_EditRule";
            this.btn_EditRule.Size = new System.Drawing.Size(44, 23);
            this.btn_EditRule.TabIndex = 12;
            this.btn_EditRule.Text = "Edit";
            this.btn_EditRule.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 558);
            this.Controls.Add(this.btn_EditRule);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.txbx_Alias);
            this.Controls.Add(this.txbx_NewRuleType);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txbx_save);
            this.Controls.Add(this.lsbx_Rule);
            this.Controls.Add(this.btn_removeRule);
            this.Controls.Add(this.btn_removeAlias);
            this.Controls.Add(this.btn_removeRuleType);
            this.Controls.Add(this.btn_addRule);
            this.Controls.Add(this.btn_addAlias);
            this.Controls.Add(this.btn_addRuleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lsbx_Alias);
            this.Controls.Add(this.lsbx_Type);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txbx_path);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txbx_save;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_NewRuleType;
        private System.Windows.Forms.TextBox txbx_Alias;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.Button btn_EditRule;
    }
}

