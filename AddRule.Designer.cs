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
            this.cmbx_Conditions1 = new System.Windows.Forms.ComboBox();
            this.txbx_Param1_1 = new System.Windows.Forms.TextBox();
            this.txbx_TargetColumn = new System.Windows.Forms.TextBox();
            this.lsbx_Criterias = new System.Windows.Forms.ListBox();
            this.btn_RemoveCondition = new System.Windows.Forms.Button();
            this.btn_addCondition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_mainCondition = new System.Windows.Forms.GroupBox();
            this.txbx_RuleName = new System.Windows.Forms.TextBox();
            this.cmbx_Actions = new System.Windows.Forms.ComboBox();
            this.txbx_MainParameter = new System.Windows.Forms.TextBox();
            this.cmbx_MainCondition = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_Suffix = new System.Windows.Forms.TextBox();
            this.lbl_sekComdReturn = new System.Windows.Forms.Label();
            this.btn_DownCondition = new System.Windows.Forms.Button();
            this.btn_UpCondition = new System.Windows.Forms.Button();
            this.gb_additionCondition = new System.Windows.Forms.GroupBox();
            this.cbx_swap = new System.Windows.Forms.CheckBox();
            this.txbx_Param2_2 = new System.Windows.Forms.TextBox();
            this.txbx_Param2_1 = new System.Windows.Forms.TextBox();
            this.txbx_column2 = new System.Windows.Forms.TextBox();
            this.cmbx_Conditions2 = new System.Windows.Forms.ComboBox();
            this.txbx_column1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_Param1_2 = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbx_CheckedColumn = new System.Windows.Forms.TextBox();
            this.txbx_SourceValueColumn = new System.Windows.Forms.TextBox();
            this.gb_mainCondition.SuspendLayout();
            this.gb_additionCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbx_Conditions1
            // 
            this.cmbx_Conditions1.FormattingEnabled = true;
            this.cmbx_Conditions1.Location = new System.Drawing.Point(137, 23);
            this.cmbx_Conditions1.Name = "cmbx_Conditions1";
            this.cmbx_Conditions1.Size = new System.Drawing.Size(101, 21);
            this.cmbx_Conditions1.TabIndex = 7;
            this.cmbx_Conditions1.SelectedIndexChanged += new System.EventHandler(this.cmbx_Conditions_SelectedIndexChanged);
            // 
            // txbx_Param1_1
            // 
            this.txbx_Param1_1.Location = new System.Drawing.Point(244, 24);
            this.txbx_Param1_1.Name = "txbx_Param1_1";
            this.txbx_Param1_1.Size = new System.Drawing.Size(74, 20);
            this.txbx_Param1_1.TabIndex = 8;
            // 
            // txbx_TargetColumn
            // 
            this.txbx_TargetColumn.Location = new System.Drawing.Point(315, 71);
            this.txbx_TargetColumn.Name = "txbx_TargetColumn";
            this.txbx_TargetColumn.Size = new System.Drawing.Size(39, 20);
            this.txbx_TargetColumn.TabIndex = 2;
            // 
            // lsbx_Criterias
            // 
            this.lsbx_Criterias.FormattingEnabled = true;
            this.lsbx_Criterias.Location = new System.Drawing.Point(419, 19);
            this.lsbx_Criterias.Name = "lsbx_Criterias";
            this.lsbx_Criterias.Size = new System.Drawing.Size(275, 134);
            this.lsbx_Criterias.TabIndex = 100;
            this.lsbx_Criterias.TabStop = false;
            this.lsbx_Criterias.SelectedIndexChanged += new System.EventHandler(this.lsbx_AdditionalRules_SelectedIndexChanged);
            // 
            // btn_RemoveCondition
            // 
            this.btn_RemoveCondition.Location = new System.Drawing.Point(346, 131);
            this.btn_RemoveCondition.Name = "btn_RemoveCondition";
            this.btn_RemoveCondition.Size = new System.Drawing.Size(50, 23);
            this.btn_RemoveCondition.TabIndex = 17;
            this.btn_RemoveCondition.Text = "-";
            this.btn_RemoveCondition.UseVisualStyleBackColor = true;
            this.btn_RemoveCondition.Click += new System.EventHandler(this.btn_RemoveCondition_Click);
            // 
            // btn_addCondition
            // 
            this.btn_addCondition.Location = new System.Drawing.Point(289, 131);
            this.btn_addCondition.Name = "btn_addCondition";
            this.btn_addCondition.Size = new System.Drawing.Size(50, 23);
            this.btn_addCondition.TabIndex = 16;
            this.btn_addCondition.Text = "+";
            this.btn_addCondition.UseVisualStyleBackColor = true;
            this.btn_addCondition.Click += new System.EventHandler(this.btn_addCondition_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Значение столбца";
            // 
            // gb_mainCondition
            // 
            this.gb_mainCondition.Controls.Add(this.txbx_SourceValueColumn);
            this.gb_mainCondition.Controls.Add(this.txbx_CheckedColumn);
            this.gb_mainCondition.Controls.Add(this.txbx_RuleName);
            this.gb_mainCondition.Controls.Add(this.cmbx_Actions);
            this.gb_mainCondition.Controls.Add(this.txbx_MainParameter);
            this.gb_mainCondition.Controls.Add(this.cmbx_MainCondition);
            this.gb_mainCondition.Controls.Add(this.label8);
            this.gb_mainCondition.Controls.Add(this.label9);
            this.gb_mainCondition.Controls.Add(this.label3);
            this.gb_mainCondition.Controls.Add(this.txbx_TargetColumn);
            this.gb_mainCondition.Location = new System.Drawing.Point(21, 21);
            this.gb_mainCondition.Name = "gb_mainCondition";
            this.gb_mainCondition.Size = new System.Drawing.Size(768, 112);
            this.gb_mainCondition.TabIndex = 0;
            this.gb_mainCondition.TabStop = false;
            this.gb_mainCondition.Text = "Правило";
            // 
            // txbx_RuleName
            // 
            this.txbx_RuleName.Location = new System.Drawing.Point(45, 26);
            this.txbx_RuleName.Name = "txbx_RuleName";
            this.txbx_RuleName.Size = new System.Drawing.Size(103, 20);
            this.txbx_RuleName.TabIndex = 1;
            // 
            // cmbx_Actions
            // 
            this.cmbx_Actions.FormattingEnabled = true;
            this.cmbx_Actions.Location = new System.Drawing.Point(362, 71);
            this.cmbx_Actions.Name = "cmbx_Actions";
            this.cmbx_Actions.Size = new System.Drawing.Size(178, 21);
            this.cmbx_Actions.TabIndex = 5;
            this.cmbx_Actions.SelectedIndexChanged += new System.EventHandler(this.cmbx_Actions_SelectedIndexChanged);
            // 
            // txbx_MainParameter
            // 
            this.txbx_MainParameter.Location = new System.Drawing.Point(546, 26);
            this.txbx_MainParameter.Name = "txbx_MainParameter";
            this.txbx_MainParameter.Size = new System.Drawing.Size(89, 20);
            this.txbx_MainParameter.TabIndex = 4;
            // 
            // cmbx_MainCondition
            // 
            this.cmbx_MainCondition.FormattingEnabled = true;
            this.cmbx_MainCondition.Location = new System.Drawing.Point(362, 26);
            this.cmbx_MainCondition.Name = "cmbx_MainCondition";
            this.cmbx_MainCondition.Size = new System.Drawing.Size(178, 21);
            this.cmbx_MainCondition.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Имя";
            // 
            // txbx_Suffix
            // 
            this.txbx_Suffix.Location = new System.Drawing.Point(92, 133);
            this.txbx_Suffix.Name = "txbx_Suffix";
            this.txbx_Suffix.Size = new System.Drawing.Size(146, 20);
            this.txbx_Suffix.TabIndex = 14;
            // 
            // lbl_sekComdReturn
            // 
            this.lbl_sekComdReturn.AutoSize = true;
            this.lbl_sekComdReturn.Location = new System.Drawing.Point(10, 134);
            this.lbl_sekComdReturn.Name = "lbl_sekComdReturn";
            this.lbl_sekComdReturn.Size = new System.Drawing.Size(80, 13);
            this.lbl_sekComdReturn.TabIndex = 117;
            this.lbl_sekComdReturn.Text = "Тогда вернуть";
            // 
            // btn_DownCondition
            // 
            this.btn_DownCondition.Location = new System.Drawing.Point(700, 95);
            this.btn_DownCondition.Name = "btn_DownCondition";
            this.btn_DownCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_DownCondition.TabIndex = 19;
            this.btn_DownCondition.Text = "Вниз";
            this.btn_DownCondition.UseVisualStyleBackColor = true;
            // 
            // btn_UpCondition
            // 
            this.btn_UpCondition.Location = new System.Drawing.Point(700, 53);
            this.btn_UpCondition.Name = "btn_UpCondition";
            this.btn_UpCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_UpCondition.TabIndex = 18;
            this.btn_UpCondition.Text = "Вверх";
            this.btn_UpCondition.UseVisualStyleBackColor = true;
            // 
            // gb_additionCondition
            // 
            this.gb_additionCondition.Controls.Add(this.cbx_swap);
            this.gb_additionCondition.Controls.Add(this.txbx_Param2_2);
            this.gb_additionCondition.Controls.Add(this.txbx_Param2_1);
            this.gb_additionCondition.Controls.Add(this.txbx_column2);
            this.gb_additionCondition.Controls.Add(this.cmbx_Conditions2);
            this.gb_additionCondition.Controls.Add(this.txbx_column1);
            this.gb_additionCondition.Controls.Add(this.label7);
            this.gb_additionCondition.Controls.Add(this.label6);
            this.gb_additionCondition.Controls.Add(this.label2);
            this.gb_additionCondition.Controls.Add(this.btn_DownCondition);
            this.gb_additionCondition.Controls.Add(this.btn_addCondition);
            this.gb_additionCondition.Controls.Add(this.btn_UpCondition);
            this.gb_additionCondition.Controls.Add(this.label5);
            this.gb_additionCondition.Controls.Add(this.label4);
            this.gb_additionCondition.Controls.Add(this.btn_RemoveCondition);
            this.gb_additionCondition.Controls.Add(this.txbx_Suffix);
            this.gb_additionCondition.Controls.Add(this.lsbx_Criterias);
            this.gb_additionCondition.Controls.Add(this.lbl_sekComdReturn);
            this.gb_additionCondition.Controls.Add(this.txbx_Param1_2);
            this.gb_additionCondition.Controls.Add(this.txbx_Param1_1);
            this.gb_additionCondition.Controls.Add(this.cmbx_Conditions1);
            this.gb_additionCondition.Enabled = false;
            this.gb_additionCondition.Location = new System.Drawing.Point(21, 141);
            this.gb_additionCondition.Name = "gb_additionCondition";
            this.gb_additionCondition.Size = new System.Drawing.Size(768, 183);
            this.gb_additionCondition.TabIndex = 6;
            this.gb_additionCondition.TabStop = false;
            this.gb_additionCondition.Text = "Условия";
            // 
            // cbx_swap
            // 
            this.cbx_swap.AutoSize = true;
            this.cbx_swap.Location = new System.Drawing.Point(92, 160);
            this.cbx_swap.Name = "cbx_swap";
            this.cbx_swap.Size = new System.Drawing.Size(113, 17);
            this.cbx_swap.TabIndex = 15;
            this.cbx_swap.Text = "Ширина>-<Длина";
            this.cbx_swap.UseVisualStyleBackColor = true;
            // 
            // txbx_Param2_2
            // 
            this.txbx_Param2_2.Location = new System.Drawing.Point(348, 92);
            this.txbx_Param2_2.Name = "txbx_Param2_2";
            this.txbx_Param2_2.Size = new System.Drawing.Size(50, 20);
            this.txbx_Param2_2.TabIndex = 13;
            // 
            // txbx_Param2_1
            // 
            this.txbx_Param2_1.Location = new System.Drawing.Point(244, 92);
            this.txbx_Param2_1.Name = "txbx_Param2_1";
            this.txbx_Param2_1.Size = new System.Drawing.Size(74, 20);
            this.txbx_Param2_1.TabIndex = 12;
            // 
            // txbx_column2
            // 
            this.txbx_column2.Location = new System.Drawing.Point(92, 92);
            this.txbx_column2.Name = "txbx_column2";
            this.txbx_column2.Size = new System.Drawing.Size(39, 20);
            this.txbx_column2.TabIndex = 10;
            // 
            // cmbx_Conditions2
            // 
            this.cmbx_Conditions2.FormattingEnabled = true;
            this.cmbx_Conditions2.Location = new System.Drawing.Point(137, 92);
            this.cmbx_Conditions2.Name = "cmbx_Conditions2";
            this.cmbx_Conditions2.Size = new System.Drawing.Size(101, 21);
            this.cmbx_Conditions2.TabIndex = 11;
            this.cmbx_Conditions2.SelectedIndexChanged += new System.EventHandler(this.cmbx_Conditions2_SelectedIndexChanged);
            // 
            // txbx_column1
            // 
            this.txbx_column1.Location = new System.Drawing.Point(92, 22);
            this.txbx_column1.Name = "txbx_column1";
            this.txbx_column1.Size = new System.Drawing.Size(39, 20);
            this.txbx_column1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(324, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 202;
            this.label7.Text = "И";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(324, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 201;
            this.label6.Text = "И";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 200;
            this.label2.Text = "И";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "столбец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Если столбец";
            // 
            // txbx_Param1_2
            // 
            this.txbx_Param1_2.Enabled = false;
            this.txbx_Param1_2.Location = new System.Drawing.Point(348, 24);
            this.txbx_Param1_2.Name = "txbx_Param1_2";
            this.txbx_Param1_2.Size = new System.Drawing.Size(50, 20);
            this.txbx_Param1_2.TabIndex = 9;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(621, 330);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 20;
            this.btn_Ok.Text = "ОК";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(700, 330);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Проверяемый столбец";
            // 
            // txbx_CheckedColumn
            // 
            this.txbx_CheckedColumn.Location = new System.Drawing.Point(315, 26);
            this.txbx_CheckedColumn.Name = "txbx_CheckedColumn";
            this.txbx_CheckedColumn.Size = new System.Drawing.Size(41, 20);
            this.txbx_CheckedColumn.TabIndex = 6;
            // 
            // txbx_SourceValueColumn
            // 
            this.txbx_SourceValueColumn.Location = new System.Drawing.Point(546, 72);
            this.txbx_SourceValueColumn.Name = "txbx_SourceValueColumn";
            this.txbx_SourceValueColumn.Size = new System.Drawing.Size(89, 20);
            this.txbx_SourceValueColumn.TabIndex = 7;
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 377);
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

        private System.Windows.Forms.ComboBox cmbx_Conditions1;
        private System.Windows.Forms.TextBox txbx_Param1_1;
        private System.Windows.Forms.TextBox txbx_TargetColumn;
        private System.Windows.Forms.ListBox lsbx_Criterias;
        private System.Windows.Forms.Button btn_RemoveCondition;
        private System.Windows.Forms.Button btn_addCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_mainCondition;
        private System.Windows.Forms.TextBox txbx_MainParameter;
        private System.Windows.Forms.ComboBox cmbx_MainCondition;
        private System.Windows.Forms.ComboBox cmbx_Actions;
        private System.Windows.Forms.TextBox txbx_Suffix;
        private System.Windows.Forms.Label lbl_sekComdReturn;
        private System.Windows.Forms.Button btn_DownCondition;
        private System.Windows.Forms.Button btn_UpCondition;
        private System.Windows.Forms.GroupBox gb_additionCondition;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txbx_Param1_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_column1;
        private System.Windows.Forms.TextBox txbx_Param2_2;
        private System.Windows.Forms.TextBox txbx_Param2_1;
        private System.Windows.Forms.TextBox txbx_column2;
        private System.Windows.Forms.ComboBox cmbx_Conditions2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbx_swap;
        private System.Windows.Forms.TextBox txbx_RuleName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_CheckedColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbx_SourceValueColumn;
    }
}