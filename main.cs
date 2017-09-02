using System;
using System.Collections.Generic;
using System.Data;
using ExcelHandler.Common;
using ExcelHandler.FParser;

namespace ExcelHandler
{
    public class main
    {
        private FileHandler fh;
        public RulesManager rm { get; set; }
        public DataTable SourceItemsTable { get; set; }
        public ItemComparator ic { get; set; }
        private MainForm form;

        public main(MainForm form)
    {
            this.form =  form;
            this.form.Visible = true;
            fh = new FileHandler();
            rm = new RulesManager("rules.dat");
            form.FileSelected += parseFile;
            ic = new ItemComparator(rm.ptrl);
        }

        private void parseFile(string filename)
        {
            SourceItemsTable = fh.parseFile(filename);
        }

        public void saveTable(string path, DataTable table, List<string> pElement)
        {
            fh.saveTable(path, table, pElement);
        }

        internal void SaveSourceData(DataTable sourceData, string path)
        {
            fh.SaveSourceData(sourceData, path);
        }
    }
}
