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
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fd.FileName);
                txbx_path.Text = fd.FileName;
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(txbx_path.Text))
                    {
                        // Read the stream to a string, and write the string to the console.
                        String line = sr.ReadToEnd();
                        Console.WriteLine(line);
                    }
                }
                catch (Exception eee)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(eee.Message);
                }

            }
        }
    }
}
