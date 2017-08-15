using System;
using System.Collections.Generic;
using ExcelHandler.Common;
using ExcelHandler.FParser;
using ExcelHandler.ItmComparator;

namespace ExcelHandler
{
    public class main
    {
        private FileParser fp;
        public RulesManager rm { get; set; }
        public List<Item> SourceItemsList { get; private set; }
        public List<Item> ProductItemsList { get; private set; }
        public List<ProductTypeRuleList> PrTypeRules { get; private set; }
        public ItemComparator ic { get; set; }
        private MainForm form;

        public List<ProductTypeRuleList> ptrl { get; set; }

        public main(MainForm form)
    {
            this.form =  form;
            this.form.Visible = true;
            SourceItemsList = new List<Item>();
            ProductItemsList = new List<Item>();
            ic = new ItemComparator();
            rm = new RulesManager("");
            form.FileSelected += parseFile;

            ptrl = ic.ProductTypeRules;
        }

        private void parseFile(string filename)
        {
            fp = new FileParser();
            SourceItemsList = fp.parseFile(filename);
        }
    }


}
