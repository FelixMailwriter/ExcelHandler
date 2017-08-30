using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHandler.FParser
{
    public class FileParser
    {
        string FileName;
        Excel.Application excellApp = new Excel.Application();
        public string OrderNumber { get; private set; }
        public string FileNamr { get; set; }

        internal DataTable parseFile(string filename)
        {
            FileName = filename;

            DataTable ItemTable = createTable();
            try
            {
                excellApp.Workbooks.Open(filename);
                int row = 12;
                bool isRows = true;
                Excel.Worksheet currentSheet = (Excel.Worksheet)excellApp.Workbooks[1].Worksheets[1];
                Excel.Range OrderNumberCellRange = (Excel.Range)currentSheet.Cells[2, 8];
                if (OrderNumberCellRange != null)
                {
                    OrderNumber = OrderNumberCellRange.Text;
                }
                else
                {
                    OrderNumber = "Отсутствует";
                }

                while (isRows)
                {

                    DataRow dr = ItemTable.NewRow();
                    for (int column = 1; column < 14; column++)
                    {
                        string cellValue = "";
                        Excel.Range cellRange = (Excel.Range)currentSheet.Cells[row, column];
                        if (cellRange != null)
                        {
                            cellValue = cellRange.Text;
                            if (cellValue.Equals("") && (column == 1)) { isRows = false; break; }
                            dr[column.ToString()] = cellValue.ToUpper();
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

        private DataTable createTable(string name = "")
        {
            DataTable table = new DataTable();
            for (int a = 1; a <= 13; a++)
            {
                table.Columns.Add(new DataColumn(a.ToString(), typeof(string)));
            }
            return table;
        }

        public void saveTable(string path, DataTable table, List<string> pElement)
        {
            string sortColumn = "13";
            List<DataTable> tables = getTables(table, sortColumn);
            //Подготавливаем список таблиц таблиц к выводу
            List<DataTable> PreparedTable = prepareTable(tables, pElement);

            foreach (DataTable CurrentTable in PreparedTable)
            {
                saveTableAsCSV(path, CurrentTable);
            }
        }

        private List<DataTable> prepareTable(List<DataTable> tables, List<string> pElement)
        {
            List<DataTable> ResultTables = new List<DataTable>();
            foreach (DataTable dt in tables)
            {
                DataTable resultTable = new DataTable(dt.Rows[0].ItemArray[12].ToString()); // имя таблицы - код материала из 13 колонки
                for (int i = 0; i < 14; i++)
                {
                    resultTable.Columns.Add((i + 1).ToString());
                }

                foreach (DataRow drSource in dt.Rows)
                {
                    DataRow resultRow = resultTable.NewRow();

                    //Записываем в первый столбез значение кол11+_+кол5
                    resultRow[0] = drSource[10]+ "_" + drSource[4];
                    resultRow[1] = drSource[1];
                    resultRow[2] = drSource[2];
                    resultRow[3] = "1";
                    resultRow[4] = "0";
                    resultRow[5] = drSource[8];
                    resultRow[6] = getElementDescription(drSource, pElement);
                    resultRow[7] = drSource[9];
                    resultRow[8] = "0";
                    resultRow[9] = OrderNumber;
                    resultRow[10] = "0";
                    resultRow[11] = "0";
                    resultRow[12] = "0";
                    resultRow[13] = "0";
                    resultTable.Rows.Add(resultRow);
                }
                ResultTables.Add(resultTable);
            }
            return ResultTables;
        }

        private string getElementDescription(DataRow drSource, List<string> pElement)
        {
            string res = "";
            foreach (string n in pElement)
            {
                int colNum = int.Parse(n);
                res += drSource[colNum - 1].ToString() + " = ";
            }
            res=res.Remove(res.Length-3);
            return res;
        }

        private void saveTableAsCSV(string path, DataTable currentTable)
        {
            string[] path_blocs = FileName.Split('\\');
            string loadedFilename = path_blocs[path_blocs.Length - 1];
            int extentionPos=loadedFilename.LastIndexOf('.');
            loadedFilename=loadedFilename.Remove(extentionPos);
            string filename = path+"\\"+loadedFilename + "_"+currentTable.TableName+".csv";
            try
            {
                StreamWriter sw = new StreamWriter(filename, false, Encoding.Unicode);
                foreach(DataRow dr in currentTable.Rows)
                {
                    string row = "";
                    object [] rowcells = dr.ItemArray;
                    foreach(object cell in rowcells)
                    {
                        row += cell.ToString() + ";";
                    }
                    sw.Write(row);
                    sw.Write(" \r\n");
                }
                sw.Close();
            }
            catch (Exception ex)  {     }


        }

            private List<DataTable> getTables(DataTable table, string sortColumn)
            {
                //Заполняем пустые ячейки знаком "-"
                fillEmptyCells(ref table);

                //Группируем таблицу по заданной колонке
                List<DataTable> tables = new List<DataTable>();
                trimColumnContext(ref table, sortColumn, 5); //в сортируемой колонке отбрасываем все, кроме заданного количество знаков
                table.DefaultView.Sort = sortColumn;            //сортируем таблицу по колонке
                                                                //Разделяем на разные таблицы, в зависимости от значений в группируемой колонке
                string selectCriteria = "";
                DataTable dt = createTable();
                DataRow dr;
                foreach (DataRow row in table.Rows)
                {
                    if (!row[sortColumn].Equals(selectCriteria))
                    {
                        tables.Add(dt);
                        dt = createTable(selectCriteria);
                        dr = dt.NewRow();
                        cloneRow(ref dr, row);
                        dt.Rows.Add(dr);
                        selectCriteria = row[sortColumn].ToString();
                    }
                    else
                    {
                        dr = dt.NewRow();
                        cloneRow(ref dr, row);
                        dt.Rows.Add(dr);
                    }
                }
                tables.Add(dt);
                if (tables.Count > 0)
                {
                    tables.RemoveAt(0);
                }
                return tables;
            }

            private void fillEmptyCells(ref DataTable table)
            {
                foreach (DataRow dr in table.Rows)
                {
                    for (int i = 0; i < dr.ItemArray.Length; i++)
                    {
                        if ((dr.ItemArray[i] == null) || (dr.ItemArray[i].ToString().Equals(""))) {
                        dr.ItemArray[i] = "-";
                    }
                    else
                    {
                        dr.ItemArray[i] = dr.ItemArray[i].ToString().Trim();
                    }
                    }
                }
            }

            private void cloneRow(ref DataRow dr, DataRow row)
            {
                object[] Cellvalues = row.ItemArray;
                for (int i = 0; i < Cellvalues.Length; i++)
                {
                    dr[i] = Cellvalues[i].ToString();
                }
            }

            private void trimColumnContext(ref DataTable table, string columnName, int symbolsCount)
            {
                foreach (DataRow dr in table.Rows)
                {
                    string CellValue = dr[columnName].ToString();
                    if (CellValue.Equals("") || (CellValue == null)) { continue; }
                    string NewCellValue = CellValue.Substring(0, symbolsCount);
                    dr[columnName] = NewCellValue;
                }
            }
        }
    }
