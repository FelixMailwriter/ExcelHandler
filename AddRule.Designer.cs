namespace ExcelHandler
{
    partial class AddRule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbx_Conditions = new System.Windows.Forms.ComboBox();
            this.txbx_Param1 = new System.Windows.Forms.TextBox();
            this.txbx_Column = new System.Windows.Forms.TextBox();
            this.txbx_TargetColumn = new System.Windows.Forms.TextBox();
            this.lsbx_AdditionalRules = new System.Windows.Forms.ListBox();
            this.btn_RemoveCondition = new System.Windows.Forms.Button();
            this.btn_addCondition = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbx_Actions = new System.Windows.Forms.ComboBox();
            this.txbx_MainParameter = new System.Windows.Forms.TextBox();
            this.cmbx_MainCondition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Suffix = new System.Windows.Forms.TextBox();
            this.lbl_sekComdReturn = new System.Windows.Forms.Label();
            this.btn_DownCondition = new System.Windows.Forms.Button();
            this.btn_UpCondition = new System.Windows.Forms.Button();
            this.gb_additionCondition = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Param2 = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_additionCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbx_Conditions
            // 
            this.cmbx_Conditions.FormattingEnabled = true;
            this.cmbx_Conditions.Location = new System.Drawing.Point(315, 18);
            this.cmbx_Conditions.Name = "cmbx_Conditions";
            this.cmbx_Conditions.Size = new System.Drawing.Size(101, 21);
            this.cmbx_Conditions.TabIndex = 17;
            this.cmbx_Conditions.SelectedIndexChanged += new System.EventHandler(this.cmbx_Conditions_SelectedIndexChanged);
            // 
            // txbx_Param1
            // 
            this.txbx_Param1.Location = new System.Drawing.Point(422, 19);
            this.txbx_Param1.Name = "txbx_Param1";
            this.txbx_Param1.Size = new System.Drawing.Size(51, 20);
            this.txbx_Param1.TabIndex = 14;
            // 
            // txbx_Column
            // 
            this.txbx_Column.Location = new System.Drawing.Point(278, 18);
            this.txbx_Column.Name = "txbx_Column";
            this.txbx_Column.Size = new System.Drawing.Size(31, 20);
            this.txbx_Column.TabIndex = 15;
            // 
            // txbx_TargetColumn
            // 
            this.txbx_TargetColumn.Location = new System.Drawing.Point(117, 28);
            this.txbx_TargetColumn.Name = "txbx_TargetColumn";
            this.txbx_TargetColumn.Size = new System.Drawing.Size(39, 20);
            this.txbx_TargetColumn.TabIndex = 16;
            // 
            // lsbx_AdditionalRules
            // 
            this.lsbx_AdditionalRules.FormattingEnabled = true;
            this.lsbx_AdditionalRules.Location = new System.Drawing.Point(15, 19);
            this.lsbx_AdditionalRules.Name = "lsbx_AdditionalRules";
            this.lsbx_AdditionalRules.Size = new System.Drawing.Size(202, 95);
            this.lsbx_AdditionalRules.TabIndex = 13;
            this.lsbx_AdditionalRules.SelectedIndexChanged += new System.EventHandler(this.lsbx_AdditionalRules_SelectedIndexChanged);
            // 
            // btn_RemoveCondition
            // 
            this.btn_RemoveCondition.Location = new System.Drawing.Point(479, 46);
            this.btn_RemoveCondition.Name = "btn_RemoveCondition";
            this.btn_RemoveCondition.Size = new System.Drawing.Size(32, 23);
            this.btn_RemoveCondition.TabIndex = 11;
            this.btn_RemoveCondition.Text = "-";
            this.btn_RemoveCondition.UseVisualStyleBackColor = true;
            this.btn_RemoveCondition.Click += new System.EventHandler(this.btn_RemoveCondition_Click);
            // 
            // btn_addCondition
            // 
            this.btn_addCondition.Location = new System.Drawing.Point(441, 45);
            this.btn_addCondition.Name = "btn_addCondition";
            this.btn_addCondition.Size = new System.Drawing.Size(32, 23);
            this.btn_addCondition.TabIndex = 12;
            this.btn_addCondition.Text = "+";
            this.btn_addCondition.UseVisualStyleBackColor = true;
            this.btn_addCondition.Click += new System.EventHandler(this.btn_addCondition_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Столбец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Целевой столбец";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbx_Actions);
            this.groupBox1.Controls.Add(this.txbx_MainParameter);
            this.groupBox1.Controls.Add(this.cmbx_MainCondition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_TargetColumn);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Главное условие";
            // 
            // cmbx_Actions
            // 
            this.cmbx_Actions.FormattingEnabled = true;
            this.cmbx_Actions.Location = new System.Drawing.Point(117, 65);
            this.cmbx_Actions.Name = "cmbx_Actions";
            this.cmbx_Actions.Size = new System.Drawing.Size(154, 21);
            this.cmbx_Actions.TabIndex = 21;
            this.cmbx_Actions.SelectedIndexChanged += new System.EventHandler(this.cmbx_Actions_SelectedIndexChanged);
            // 
            // txbx_MainParameter
            // 
            this.txbx_MainParameter.Location = new System.Drawing.Point(288, 27);
            this.txbx_MainParameter.Name = "txbx_MainParameter";
            this.txbx_MainParameter.Size = new System.Drawing.Size(156, 20);
            this.txbx_MainParameter.TabIndex = 20;
            // 
            // cmbx_MainCondition
            // 
            this.cmbx_MainCondition.FormattingEnabled = true;
            this.cmbx_MainCondition.Location = new System.Drawing.Point(171, 27);
            this.cmbx_MainCondition.Name = "cmbx_MainCondition";
            this.cmbx_MainCondition.Size = new System.Drawing.Size(100, 21);
            this.cmbx_MainCondition.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Действие";
            // 
            // txbx_Suffix
            // 
            this.txbx_Suffix.Location = new System.Drawing.Point(278, 49);
            this.txbx_Suffix.Name = "txbx_Suffix";
            this.txbx_Suffix.Size = new System.Drawing.Size(138, 20);
            this.txbx_Suffix.TabIndex = 20;
            // 
            // lbl_sekComdReturn
            // 
            this.lbl_sekComdReturn.AutoSize = true;
            this.lbl_sekComdReturn.Location = new System.Drawing.Point(223, 56);
            this.lbl_sekComdReturn.Name = "lbl_sekComdReturn";
            this.lbl_sekComdReturn.Size = new System.Drawing.Size(48, 13);
            this.lbl_sekComdReturn.TabIndex = 19;
            this.lbl_sekComdReturn.Text = "Вернуть";
            // 
            // btn_DownCondition
            // 
            this.btn_DownCondition.Location = new System.Drawing.Point(145, 120);
            this.btn_DownCondition.Name = "btn_DownCondition";
            this.btn_DownCondition.Size = new System.Drawing.Size(46, 23);
            this.btn_DownCondition.TabIndex = 21;
            this.btn_DownCondition.Text = "Вниз";
            this.btn_DownCondition.UseVisualStyleBackColor = true;
            // 
            // btn_UpCondition
            // 
            this.btn_UpCondition.Location = new System.Drawing.Point(51, 120);
            this.btn_UpCondition.Name = "btn_UpCondition";
            this.btn_UpCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_UpCondition.TabIndex = 22;
            this.btn_UpCondition.Text = "Вверх";
            this.btn_UpCondition.UseVisualStyleBackColor = true;
            // 
            // gb_additionCondition
            // 
            this.gb_additionCondition.Controls.Add(this.label2);
            this.gb_additionCondition.Controls.Add(this.label5);
            this.gb_additionCondition.Controls.Add(this.btn_DownCondition);
            this.gb_additionCondition.Controls.Add(this.btn_addCondition);
            this.gb_additionCondition.Controls.Add(this.btn_UpCondition);
            this.gb_additionCondition.Controls.Add(this.btn_RemoveCondition);
            this.gb_additionCondition.Controls.Add(this.txbx_Suffix);
            this.gb_additionCondition.Controls.Add(this.lsbx_AdditionalRules);
            this.gb_additionCondition.Controls.Add(this.txbx_Column);
            this.gb_additionCondition.Controls.Add(this.lbl_sekComdReturn);
            this.gb_additionCondition.Controls.Add(this.txbx_Param2);
            this.gb_additionCondition.Controls.Add(this.txbx_Param1);
            this.gb_additionCondition.Controls.Add(this.cmbx_Conditions);
            this.gb_additionCondition.Enabled = false;
            this.gb_additionCondition.Location = new System.Drawing.Point(27, 132);
            this.gb_additionCondition.Name = "gb_additionCondition";
            this.gb_additionCondition.Size = new System.Drawing.Size(558, 161);
            this.gb_additionCondition.TabIndex = 23;
            this.gb_additionCondition.TabStop = false;
            this.gb_additionCondition.Text = "Дополнительные условия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "И";
            // 
            // txbx_Param2
            // 
            this.txbx_Param2.Enabled = false;
            this.txbx_Param2.Location = new System.Drawing.Point(501, 18);
            this.txbx_Param2.Name = "txbx_Param2";
            this.txbx_Param2.Size = new System.Drawing.Size(51, 20);
            this.txbx_Param2.TabIndex = 14;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(298, 293);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 24;
            this.btn_Ok.Text = "ОК";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(388, 293);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.gb_additionCondition);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRule";
            this.Text = "AddRule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_additionCondition.ResumeLayout(false);
            this.gb_additionCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_Conditions;
        private System.Windows.Forms.TextBox txbx_Param1;
        private System.Windows.Forms.TextBox txbx_Column;
        private System.Windows.Forms.TextBox txbx_TargetColumn;
        private System.Windows.Forms.ListBox lsbx_AdditionalRules;
        private System.Windows.Forms.Button btn_RemoveCondition;
        private System.Windows.Forms.Button btn_addCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbx_MainParameter;
        private System.Windows.Forms.ComboBox cmbx_MainCondition;
        private System.Windows.Forms.ComboBox cmbx_Actions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Suffix;
        private System.Windows.Forms.Label lbl_sekComdReturn;
        private System.Windows.Forms.Button btn_DownCondition;
        private System.Windows.Forms.Button btn_UpCondition;
        private System.Windows.Forms.GroupBox gb_additionCondition;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txbx_Param2;
        private System.Windows.Forms.Label label2;
    }
}