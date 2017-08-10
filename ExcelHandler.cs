using System;
using System.Collections.Generic;
using ExcelHandler.Common;
using ExcelHandler.FParser;
using ExcelHandler.ItmComparator;

namespace ExcelHandler
{
    public class ExcelHandler
    {
        private FileParser fp;
        public List<Item> SourceItemsList { get; private set; }
        public List<Item> ProductItemsList { get; private set; }
        private ItemComparator ic;
        private MainForm form;

    public ExcelHandler(MainForm form)
    {
            this.form =  form;
            this.form.Visible = true;
            this.SourceItemsList = new List<Item>();
            this.ProductItemsList = new List<Item>();
            this.ic = new ItemComparator();
            form.FileSelected += parseFile;
    }

        private void parseFile(string filename)
        {
            this.fp = new FileParser();
            SourceItemsList = fp.parseFile(filename);
        }
    }


}
