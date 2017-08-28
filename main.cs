using System.Collections.Generic;
using System.Data;
using ExcelHandler.Common;
using ExcelHandler.FParser;

namespace ExcelHandler
{
    public class main
    {
        private FileParser fp;
        public RulesManager rm { get; set; }
        public DataTable SourceItemsTable { get; set; }
        public ItemComparator ic { get; set; }
        private MainForm form;

        public main(MainForm form)
    {
            this.form =  form;
            this.form.Visible = true;
            fp = new FileParser();
            rm = new RulesManager("rules.dat");
            form.FileSelected += parseFile;
            ic = new ItemComparator(rm.ptrl);
        }

        private void parseFile(string filename)
        {
            SourceItemsTable = fp.parseFile(filename);
        }

        public void saveTable(string path, DataTable table)
        {
            fp.saveTable(path, table);
        }
    }
}
