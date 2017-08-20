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
            this.txbx_TargetColumn = new System.Windows.Forms.TextBox();
            this.lsbx_AdditionalRules = new System.Windows.Forms.ListBox();
            this.btn_RemoveCondition = new System.Windows.Forms.Button();
            this.btn_addCondition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_mainCondition = new System.Windows.Forms.GroupBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_Param2 = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txbx_column = new System.Windows.Forms.TextBox();
            this.gb_mainCondition.SuspendLayout();
            this.gb_additionCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbx_Conditions
            // 
            this.cmbx_Conditions.FormattingEnabled = true;
            this.cmbx_Conditions.Location = new System.Drawing.Point(137, 23);
            this.cmbx_Conditions.Name = "cmbx_Conditions";
            this.cmbx_Conditions.Size = new System.Drawing.Size(101, 21);
            this.cmbx_Conditions.TabIndex = 5;
            this.cmbx_Conditions.SelectedIndexChanged += new System.EventHandler(this.cmbx_Conditions_SelectedIndexChanged);
            // 
            // txbx_Param1
            // 
            this.txbx_Param1.Location = new System.Drawing.Point(244, 24);
            this.txbx_Param1.Name = "txbx_Param1";
            this.txbx_Param1.Size = new System.Drawing.Size(74, 20);
            this.txbx_Param1.TabIndex = 6;
            // 
            // txbx_TargetColumn
            // 
            this.txbx_TargetColumn.Location = new System.Drawing.Point(117, 28);
            this.txbx_TargetColumn.Name = "txbx_TargetColumn";
            this.txbx_TargetColumn.Size = new System.Drawing.Size(39, 20);
            this.txbx_TargetColumn.TabIndex = 1;
            // 
            // lsbx_AdditionalRules
            // 
            this.lsbx_AdditionalRules.FormattingEnabled = true;
            this.lsbx_AdditionalRules.Location = new System.Drawing.Point(419, 19);
            this.lsbx_AdditionalRules.Name = "lsbx_AdditionalRules";
            this.lsbx_AdditionalRules.Size = new System.Drawing.Size(235, 69);
            this.lsbx_AdditionalRules.TabIndex = 100;
            this.lsbx_AdditionalRules.SelectedIndexChanged += new System.EventHandler(this.lsbx_AdditionalRules_SelectedIndexChanged);
            // 
            // btn_RemoveCondition
            // 
            this.btn_RemoveCondition.Location = new System.Drawing.Point(346, 57);
            this.btn_RemoveCondition.Name = "btn_RemoveCondition";
            this.btn_RemoveCondition.Size = new System.Drawing.Size(50, 23);
            this.btn_RemoveCondition.TabIndex = 10;
            this.btn_RemoveCondition.Text = "-";
            this.btn_RemoveCondition.UseVisualStyleBackColor = true;
            this.btn_RemoveCondition.Click += new System.EventHandler(this.btn_RemoveCondition_Click);
            // 
            // btn_addCondition
            // 
            this.btn_addCondition.Location = new System.Drawing.Point(289, 57);
            this.btn_addCondition.Name = "btn_addCondition";
            this.btn_addCondition.Size = new System.Drawing.Size(50, 23);
            this.btn_addCondition.TabIndex = 9;
            this.btn_addCondition.Text = "+";
            this.btn_addCondition.UseVisualStyleBackColor = true;
            this.btn_addCondition.Click += new System.EventHandler(this.btn_addCondition_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Целевой столбец";
            // 
            // gb_mainCondition
            // 
            this.gb_mainCondition.Controls.Add(this.cmbx_Actions);
            this.gb_mainCondition.Controls.Add(this.txbx_MainParameter);
            this.gb_mainCondition.Controls.Add(this.cmbx_MainCondition);
            this.gb_mainCondition.Controls.Add(this.label1);
            this.gb_mainCondition.Controls.Add(this.label3);
            this.gb_mainCondition.Controls.Add(this.txbx_TargetColumn);
            this.gb_mainCondition.Location = new System.Drawing.Point(21, 21);
            this.gb_mainCondition.Name = "gb_mainCondition";
            this.gb_mainCondition.Size = new System.Drawing.Size(728, 73);
            this.gb_mainCondition.TabIndex = 18;
            this.gb_mainCondition.TabStop = false;
            this.gb_mainCondition.Text = "Главное условие";
            // 
            // cmbx_Actions
            // 
            this.cmbx_Actions.FormattingEnabled = true;
            this.cmbx_Actions.Location = new System.Drawing.Point(523, 28);
            this.cmbx_Actions.Name = "cmbx_Actions";
            this.cmbx_Actions.Size = new System.Drawing.Size(191, 21);
            this.cmbx_Actions.TabIndex = 4;
            this.cmbx_Actions.SelectedIndexChanged += new System.EventHandler(this.cmbx_Actions_SelectedIndexChanged);
            // 
            // txbx_MainParameter
            // 
            this.txbx_MainParameter.Location = new System.Drawing.Point(288, 27);
            this.txbx_MainParameter.Name = "txbx_MainParameter";
            this.txbx_MainParameter.Size = new System.Drawing.Size(156, 20);
            this.txbx_MainParameter.TabIndex = 3;
            // 
            // cmbx_MainCondition
            // 
            this.cmbx_MainCondition.FormattingEnabled = true;
            this.cmbx_MainCondition.Location = new System.Drawing.Point(171, 27);
            this.cmbx_MainCondition.Name = "cmbx_MainCondition";
            this.cmbx_MainCondition.Size = new System.Drawing.Size(100, 21);
            this.cmbx_MainCondition.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Действие";
            // 
            // txbx_Suffix
            // 
            this.txbx_Suffix.Location = new System.Drawing.Point(137, 57);
            this.txbx_Suffix.Name = "txbx_Suffix";
            this.txbx_Suffix.Size = new System.Drawing.Size(107, 20);
            this.txbx_Suffix.TabIndex = 8;
            // 
            // lbl_sekComdReturn
            // 
            this.lbl_sekComdReturn.AutoSize = true;
            this.lbl_sekComdReturn.Location = new System.Drawing.Point(10, 60);
            this.lbl_sekComdReturn.Name = "lbl_sekComdReturn";
            this.lbl_sekComdReturn.Size = new System.Drawing.Size(80, 13);
            this.lbl_sekComdReturn.TabIndex = 0;
            this.lbl_sekComdReturn.Text = "Тогда вернуть";
            // 
            // btn_DownCondition
            // 
            this.btn_DownCondition.Location = new System.Drawing.Point(660, 65);
            this.btn_DownCondition.Name = "btn_DownCondition";
            this.btn_DownCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_DownCondition.TabIndex = 14;
            this.btn_DownCondition.Text = "Вниз";
            this.btn_DownCondition.UseVisualStyleBackColor = true;
            // 
            // btn_UpCondition
            // 
            this.btn_UpCondition.Location = new System.Drawing.Point(660, 19);
            this.btn_UpCondition.Name = "btn_UpCondition";
            this.btn_UpCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_UpCondition.TabIndex = 13;
            this.btn_UpCondition.Text = "Вверх";
            this.btn_UpCondition.UseVisualStyleBackColor = true;
            // 
            // gb_additionCondition
            // 
            this.gb_additionCondition.Controls.Add(this.txbx_column);
            this.gb_additionCondition.Controls.Add(this.label2);
            this.gb_additionCondition.Controls.Add(this.btn_DownCondition);
            this.gb_additionCondition.Controls.Add(this.btn_addCondition);
            this.gb_additionCondition.Controls.Add(this.btn_UpCondition);
            this.gb_additionCondition.Controls.Add(this.label4);
            this.gb_additionCondition.Controls.Add(this.btn_RemoveCondition);
            this.gb_additionCondition.Controls.Add(this.txbx_Suffix);
            this.gb_additionCondition.Controls.Add(this.lsbx_AdditionalRules);
            this.gb_additionCondition.Controls.Add(this.lbl_sekComdReturn);
            this.gb_additionCondition.Controls.Add(this.txbx_Param2);
            this.gb_additionCondition.Controls.Add(this.txbx_Param1);
            this.gb_additionCondition.Controls.Add(this.cmbx_Conditions);
            this.gb_additionCondition.Enabled = false;
            this.gb_additionCondition.Location = new System.Drawing.Point(21, 100);
            this.gb_additionCondition.Name = "gb_additionCondition";
            this.gb_additionCondition.Size = new System.Drawing.Size(728, 103);
            this.gb_additionCondition.TabIndex = 0;
            this.gb_additionCondition.TabStop = false;
            this.gb_additionCondition.Text = "Дополнительные условия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "И";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Если столбец";
            // 
            // txbx_Param2
            // 
            this.txbx_Param2.Enabled = false;
            this.txbx_Param2.Location = new System.Drawing.Point(345, 24);
            this.txbx_Param2.Name = "txbx_Param2";
            this.txbx_Param2.Size = new System.Drawing.Size(50, 20);
            this.txbx_Param2.TabIndex = 7;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(579, 221);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "ОК";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(660, 221);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txbx_column
            // 
            this.txbx_column.Location = new System.Drawing.Point(92, 22);
            this.txbx_column.Name = "txbx_column";
            this.txbx_column.Size = new System.Drawing.Size(39, 20);
            this.txbx_column.TabIndex = 101;
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 265);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.gb_additionCondition);
            this.Controls.Add(this.gb_mainCondition);
            this.Name = "AddRule";
            this.Text = "AddRule";
            this.gb_mainCondition.ResumeLayout(false);
            this.gb_mainCondition.PerformLayout();
            this.gb_additionCondition.ResumeLayout(false);
            this.gb_additionCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_Conditions;
        private System.Windows.Forms.TextBox txbx_Param1;
        private System.Windows.Forms.TextBox txbx_TargetColumn;
        private System.Windows.Forms.ListBox lsbx_AdditionalRules;
        private System.Windows.Forms.Button btn_RemoveCondition;
        private System.Windows.Forms.Button btn_addCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_mainCondition;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_column;
    }
}