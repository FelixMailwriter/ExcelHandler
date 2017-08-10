using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace ExcelHandler
{
    public partial class MainForm : Form
    {
        public delegate void FileSelectedHandler(String filename);
        public event FileSelectedHandler FileSelected;

        public MainForm()
        {
            InitializeComponent();
            btn_open.Click += Btn_open_Click;
            ExcelHandler eh = new ExcelHandler(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
