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
            this.button1 = new System.Windows.Forms.Button();
            this.lsbx_Alias = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbx_Rule = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_Type = new System.Windows.Forms.TextBox();
            this.txbx_Alias = new System.Windows.Forms.TextBox();
            this.btn_exec = new System.Windows.Forms.Button();
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
            this.lsbx_Type.FormattingEnabled = true;
            this.lsbx_Type.Location = new System.Drawing.Point(25, 135);
            this.lsbx_Type.Name = "lsbx_Type";
            this.lsbx_Type.Size = new System.Drawing.Size(277, 95);
            this.lsbx_Type.TabIndex = 2;
            this.lsbx_Type.ValueMember = "Name";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbx_Alias
            // 
            this.lsbx_Alias.FormattingEnabled = true;
            this.lsbx_Alias.Items.AddRange(new object[] {
            "NT_SHPON",
            "NT_PVC",
            "NT_COLOR"});
            this.lsbx_Alias.Location = new System.Drawing.Point(460, 161);
            this.lsbx_Alias.Name = "lsbx_Alias";
            this.lsbx_Alias.Size = new System.Drawing.Size(103, 95);
            this.lsbx_Alias.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Псевдонимы";
            // 
            // lsbx_Rule
            // 
            this.lsbx_Rule.FormattingEnabled = true;
            this.lsbx_Rule.Location = new System.Drawing.Point(615, 161);
            this.lsbx_Rule.Name = "lsbx_Rule";
            this.lsbx_Rule.Size = new System.Drawing.Size(120, 95);
            this.lsbx_Rule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правила";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(628, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(666, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(365, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 6;
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
            // txbx_Type
            // 
            this.txbx_Type.Location = new System.Drawing.Point(28, 236);
            this.txbx_Type.Name = "txbx_Type";
            this.txbx_Type.Size = new System.Drawing.Size(100, 20);
            this.txbx_Type.TabIndex = 10;
            // 
            // txbx_Alias
            // 
            this.txbx_Alias.Location = new System.Drawing.Point(460, 262);
            this.txbx_Alias.Name = "txbx_Alias";
            this.txbx_Alias.Size = new System.Drawing.Size(100, 20);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 558);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.txbx_Alias);
            this.Controls.Add(this.txbx_Type);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lsbx_Rule);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbx_Alias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbx_Rule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_Type;
        private System.Windows.Forms.TextBox txbx_Alias;
        private System.Windows.Forms.Button btn_exec;
    }
}

