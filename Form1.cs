using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_open.Click += Btn_open_Click;
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fd.FileName);
                txbx_path.Text = fd.FileName;
                try
                {
                    if ((myStream = fd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
    }
}
