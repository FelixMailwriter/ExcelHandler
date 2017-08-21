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
            this.cmbx_Actions = new System.Windows.Forms.ComboBox();
            this.txbx_MainParameter = new System.Windows.Forms.TextBox();
            this.cmbx_MainCondition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Suffix = new System.Windows.Forms.TextBox();
            this.lbl_sekComdReturn = new System.Windows.Forms.Label();
            this.btn_DownCondition = new System.Windows.Forms.Button();
            this.btn_UpCondition = new System.Windows.Forms.Button();
            this.gb_additionCondition = new System.Windows.Forms.GroupBox();
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
            this.cbx_swap = new System.Windows.Forms.CheckBox();
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
            this.cmbx_Conditions1.TabIndex = 5;
            this.cmbx_Conditions1.SelectedIndexChanged += new System.EventHandler(this.cmbx_Conditions_SelectedIndexChanged);
            // 
            // txbx_Param1_1
            // 
            this.txbx_Param1_1.Location = new System.Drawing.Point(244, 24);
            this.txbx_Param1_1.Name = "txbx_Param1_1";
            this.txbx_Param1_1.Size = new System.Drawing.Size(74, 20);
            this.txbx_Param1_1.TabIndex = 6;
            // 
            // txbx_TargetColumn
            // 
            this.txbx_TargetColumn.Location = new System.Drawing.Point(137, 28);
            this.txbx_TargetColumn.Name = "txbx_TargetColumn";
            this.txbx_TargetColumn.Size = new System.Drawing.Size(39, 20);
            this.txbx_TargetColumn.TabIndex = 1;
            // 
            // lsbx_Criterias
            // 
            this.lsbx_Criterias.FormattingEnabled = true;
            this.lsbx_Criterias.Location = new System.Drawing.Point(419, 19);
            this.lsbx_Criterias.Name = "lsbx_Criterias";
            this.lsbx_Criterias.Size = new System.Drawing.Size(408, 134);
            this.lsbx_Criterias.TabIndex = 100;
            this.lsbx_Criterias.SelectedIndexChanged += new System.EventHandler(this.lsbx_AdditionalRules_SelectedIndexChanged);
            // 
            // btn_RemoveCondition
            // 
            this.btn_RemoveCondition.Location = new System.Drawing.Point(346, 131);
            this.btn_RemoveCondition.Name = "btn_RemoveCondition";
            this.btn_RemoveCondition.Size = new System.Drawing.Size(50, 23);
            this.btn_RemoveCondition.TabIndex = 10;
            this.btn_RemoveCondition.Text = "-";
            this.btn_RemoveCondition.UseVisualStyleBackColor = true;
            this.btn_RemoveCondition.Click += new System.EventHandler(this.btn_RemoveCondition_Click);
            // 
            // btn_addCondition
            // 
            this.btn_addCondition.Location = new System.Drawing.Point(289, 131);
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
            this.gb_mainCondition.Size = new System.Drawing.Size(923, 73);
            this.gb_mainCondition.TabIndex = 18;
            this.gb_mainCondition.TabStop = false;
            this.gb_mainCondition.Text = "Главное условие";
            // 
            // cmbx_Actions
            // 
            this.cmbx_Actions.FormattingEnabled = true;
            this.cmbx_Actions.Location = new System.Drawing.Point(636, 28);
            this.cmbx_Actions.Name = "cmbx_Actions";
            this.cmbx_Actions.Size = new System.Drawing.Size(191, 21);
            this.cmbx_Actions.TabIndex = 4;
            this.cmbx_Actions.SelectedIndexChanged += new System.EventHandler(this.cmbx_Actions_SelectedIndexChanged);
            // 
            // txbx_MainParameter
            // 
            this.txbx_MainParameter.Location = new System.Drawing.Point(392, 28);
            this.txbx_MainParameter.Name = "txbx_MainParameter";
            this.txbx_MainParameter.Size = new System.Drawing.Size(156, 20);
            this.txbx_MainParameter.TabIndex = 3;
            // 
            // cmbx_MainCondition
            // 
            this.cmbx_MainCondition.FormattingEnabled = true;
            this.cmbx_MainCondition.Location = new System.Drawing.Point(182, 28);
            this.cmbx_MainCondition.Name = "cmbx_MainCondition";
            this.cmbx_MainCondition.Size = new System.Drawing.Size(192, 21);
            this.cmbx_MainCondition.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Действие";
            // 
            // txbx_Suffix
            // 
            this.txbx_Suffix.Location = new System.Drawing.Point(92, 133);
            this.txbx_Suffix.Name = "txbx_Suffix";
            this.txbx_Suffix.Size = new System.Drawing.Size(146, 20);
            this.txbx_Suffix.TabIndex = 8;
            // 
            // lbl_sekComdReturn
            // 
            this.lbl_sekComdReturn.AutoSize = true;
            this.lbl_sekComdReturn.Location = new System.Drawing.Point(10, 134);
            this.lbl_sekComdReturn.Name = "lbl_sekComdReturn";
            this.lbl_sekComdReturn.Size = new System.Drawing.Size(80, 13);
            this.lbl_sekComdReturn.TabIndex = 0;
            this.lbl_sekComdReturn.Text = "Тогда вернуть";
            // 
            // btn_DownCondition
            // 
            this.btn_DownCondition.Location = new System.Drawing.Point(846, 95);
            this.btn_DownCondition.Name = "btn_DownCondition";
            this.btn_DownCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_DownCondition.TabIndex = 14;
            this.btn_DownCondition.Text = "Вниз";
            this.btn_DownCondition.UseVisualStyleBackColor = true;
            // 
            // btn_UpCondition
            // 
            this.btn_UpCondition.Location = new System.Drawing.Point(846, 53);
            this.btn_UpCondition.Name = "btn_UpCondition";
            this.btn_UpCondition.Size = new System.Drawing.Size(54, 23);
            this.btn_UpCondition.TabIndex = 13;
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
            this.gb_additionCondition.Location = new System.Drawing.Point(21, 100);
            this.gb_additionCondition.Name = "gb_additionCondition";
            this.gb_additionCondition.Size = new System.Drawing.Size(923, 183);
            this.gb_additionCondition.TabIndex = 0;
            this.gb_additionCondition.TabStop = false;
            this.gb_additionCondition.Text = "Дополнительные условия";
            // 
            // txbx_Param2_2
            // 
            this.txbx_Param2_2.Location = new System.Drawing.Point(348, 92);
            this.txbx_Param2_2.Name = "txbx_Param2_2";
            this.txbx_Param2_2.Size = new System.Drawing.Size(50, 20);
            this.txbx_Param2_2.TabIndex = 103;
            // 
            // txbx_Param2_1
            // 
            this.txbx_Param2_1.Location = new System.Drawing.Point(244, 92);
            this.txbx_Param2_1.Name = "txbx_Param2_1";
            this.txbx_Param2_1.Size = new System.Drawing.Size(74, 20);
            this.txbx_Param2_1.TabIndex = 103;
            // 
            // txbx_column2
            // 
            this.txbx_column2.Location = new System.Drawing.Point(92, 92);
            this.txbx_column2.Name = "txbx_column2";
            this.txbx_column2.Size = new System.Drawing.Size(39, 20);
            this.txbx_column2.TabIndex = 103;
            // 
            // cmbx_Conditions2
            // 
            this.cmbx_Conditions2.FormattingEnabled = true;
            this.cmbx_Conditions2.Location = new System.Drawing.Point(137, 92);
            this.cmbx_Conditions2.Name = "cmbx_Conditions2";
            this.cmbx_Conditions2.Size = new System.Drawing.Size(101, 21);
            this.cmbx_Conditions2.TabIndex = 102;
            this.cmbx_Conditions2.SelectedIndexChanged += new System.EventHandler(this.cmbx_Conditions2_SelectedIndexChanged);
            // 
            // txbx_column1
            // 
            this.txbx_column1.Location = new System.Drawing.Point(92, 22);
            this.txbx_column1.Name = "txbx_column1";
            this.txbx_column1.Size = new System.Drawing.Size(39, 20);
            this.txbx_column1.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(324, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "И";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(324, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "И";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "И";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "столбец";
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
            // txbx_Param1_2
            // 
            this.txbx_Param1_2.Enabled = false;
            this.txbx_Param1_2.Location = new System.Drawing.Point(348, 24);
            this.txbx_Param1_2.Name = "txbx_Param1_2";
            this.txbx_Param1_2.Size = new System.Drawing.Size(50, 20);
            this.txbx_Param1_2.TabIndex = 7;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(788, 301);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "ОК";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(869, 301);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cbx_swap
            // 
            this.cbx_swap.AutoSize = true;
            this.cbx_swap.Location = new System.Drawing.Point(92, 160);
            this.cbx_swap.Name = "cbx_swap";
            this.cbx_swap.Size = new System.Drawing.Size(113, 17);
            this.cbx_swap.TabIndex = 104;
            this.cbx_swap.Text = "Ширина>-<Длина";
            this.cbx_swap.UseVisualStyleBackColor = true;
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 341);
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
        private System.Windows.Forms.Label label1;
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
    }
}