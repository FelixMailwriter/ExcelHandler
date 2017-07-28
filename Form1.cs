using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHandler
{
    public partial class Form1 : Form
    {
        Excel.Application excellApp = new Excel.Application();

        public Form1()
        {
            //excellApp.Visible = true;

            InitializeComponent();
            btn_open.Click += Btn_open_Click;
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txbx_path.Text = fd.FileName;
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(txbx_path.Text))
                    {
                        excellApp.Workbooks.Open(txbx_path.Text);
                    }
                }
                catch (Exception eee)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(eee.Message);
                }

                for (int row = 1; row < 10; row++)
                {
                    List<List<string>> maping = new List<List<string>>();
                    Excel.Worksheet currentSheet = (Excel.Worksheet)excellApp.Workbooks[1].Worksheets[1];
                    List<string> tempList = new List<string>();
                    for (int column = 1; column < 3; column++)
                    {
                        string cellValue = "";

                        Excel.Range cellRange = (Excel.Range)currentSheet.Cells[row, column];
                        if (cellRange != null)
                        {
                            cellValue = cellRange.Text;
                            //Console.Write("["+row+","+column+"]= "+ cellValue+" ");
                            Console.Write("[{0},{1}]={2}; ", row, column, cellValue);
                        }
                    }
                    Console.WriteLine();
                    maping.Add(tempList);
                }

                excellApp.Quit();
            }
        }
    }
}
