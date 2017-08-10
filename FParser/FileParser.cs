using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHandler.FParser
{
    public class FileParser
    {
        Excel.Application excellApp = new Excel.Application();
        internal List<Item> parseFile(string filename)
        {
            List <Item> ItemsList= new List<Item>();
            try
            {   
                excellApp.Workbooks.Open(filename);
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
                            Console.Write("[{0},{1}]={2}; ", row, column, cellValue);
                            tempList.Add(cellValue);
                        }
                    }
                    ItemsList.Add(new Item(tempList));
                }
            excellApp.Quit();
            }
            
            catch (Exception eee)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(eee.Message);
            }
            return ItemsList;
        }
    }
}
