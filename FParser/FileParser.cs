using System;
using System.Collections.Generic;
using System.Data;
using ExcelHandler.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHandler.FParser
{
    public class FileParser
    {
        string FileName;
        Excel.Application excellApp = new Excel.Application();

        internal DataTable parseFile(string filename)
        {
            FileName = filename;
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

        public void saveTable(string path, DataTable table)
        {
            string sortColumn = "13";
            //string selectColumn = "3";
            List<DataTable> tables = getTables(table, sortColumn);
            table.DefaultView.Sort = "5";
            //foreach (DataRow dr in table.Rows)
            //{
            //    object[] RowValues = dr.ItemArray;
            //    int column = 1;
            //    foreach (object v in RowValues)
            //    {
            //        ExcelApp.Cells[row, column] = v.ToString();
            //        ++column;
            //    }
            //    ++row;
            //}
            //ExcelApp.Visible = true;
            //ExcelApp.Quit();
        }

        private List<DataTable> getTables(DataTable table, string sortColumn)
        {
            List<DataTable> tables = new List<DataTable>();
            trimColumnContext(ref table, sortColumn, 5); //в сортируемой колонке отбрасываем все, кроме заданного количество знаков
            table.DefaultView.Sort = sortColumn;            //сортируем таблицу по колонке
            string selectCriteria = "";
            DataTable dt = createTable();
            foreach (DataRow row in table.Rows)
            {
                if (!row[sortColumn].Equals(selectCriteria))
                {
                    tables.Add(dt);
                    dt = createTable();
                    DataRow dr = dt.NewRow();
                    cloneRow(ref dr, row);
                    dt.Rows.Add(dr);
                    selectCriteria = row[sortColumn].ToString();
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    cloneRow(ref dr, row);
                    dt.Rows.Add(dr);
                }
            }
            if (tables.Count > 0)
            {
                tables.RemoveAt(0);
            }
            return tables;
        }

        private void cloneRow(ref DataRow dr, DataRow row)
        {
            object[] Cellvalues = row.ItemArray;
            for (int i=0; i<Cellvalues.Length; i++)
            {
                dr[i] = Cellvalues[i].ToString();
            }
        }

        private void trimColumnContext(ref DataTable table, string columnName, int symbolsCount)
        {
            foreach(DataRow dr in table.Rows)
            {
                string CellValue = dr[columnName].ToString();
                if (CellValue.Equals("") || (CellValue == null)) { continue; }
                string NewCellValue = CellValue.Substring(0, symbolsCount);
                dr[columnName] = NewCellValue;
            }
        }
    }
}
