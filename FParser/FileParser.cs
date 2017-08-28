using System;
using System.Collections.Generic;
using System.Data;
using ExcelHandler.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHandler.FParser
{
    public class FileParser
    {

        Excel.Application excellApp = new Excel.Application();

        internal DataTable parseFile(string filename)
        {
            DataTable ItemTable = createTable();
            try
            {   
                excellApp.Workbooks.Open(filename);
                int row = 12;
                bool isRows = true;
                while (isRows)
                {
                    Excel.Worksheet currentSheet = (Excel.Worksheet)excellApp.Workbooks[1].Worksheets[1];
                    DataRow dr = ItemTable.NewRow();
                    for (int column = 1; column < 14; column++)
                    {
                        string cellValue = "";
                        Excel.Range cellRange = (Excel.Range)currentSheet.Cells[row, column];
                        if (cellRange != null)
                        {
                            cellValue = cellRange.Text;
                            if (cellValue.Equals("") && (column == 1)) { isRows = false; break;  }
                            //Console.Write("[{0},{1}]={2}; ", row, column, cellValue);
                            dr[column.ToString()] = cellValue;
                        }
                    }
                    ++row;
                    if (!dr["1"].ToString().Equals(""))
                    {
                        ItemTable.Rows.Add(dr);
                    }
                }
            excellApp.Quit();
            }
            catch (Exception eee)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(eee.Message);
            }
            return ItemTable;
        }

        private DataTable createTable()
        {
            DataTable table = new DataTable();
            for (int a=1; a<=13; a++)
            {
                table.Columns.Add(new DataColumn(a.ToString(), typeof(string)));
            }
            return table;
        }
    }
}
