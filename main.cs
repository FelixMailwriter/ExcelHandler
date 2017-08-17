using System;
using System.Collections.Generic;
using ExcelHandler.Common;
using ExcelHandler.FParser;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace ExcelHandler
{
    [Serializable]
    public class main
    {
        [NonSerialized]
        private FileParser fp;
        public RulesManager rm { get; set; }
        public List<Item> SourceItemsList { get; private set; }
        public List<Item> ProductItemsList { get; private set; }
        public List<ProductTypeRuleList> ptrl { get; set; }
        public ItemComparator ic { get; set; }
        [NonSerialized]
        private MainForm form;

        public main(MainForm form)
    {
            this.form =  form;
            this.form.Visible = true;
            SourceItemsList = new List<Item>();
            ProductItemsList = new List<Item>();
            ic = new ItemComparator();
            rm = new RulesManager("");
            form.FileSelected += parseFile;

            ptrl = loadRules();// ic.ProductTypeRules;
            //ptrl = (ptrl == null) ? new List<ProductTypeRuleList>() : ptrl;
        }

        private void parseFile(string filename)
        {
            fp = new FileParser();
            SourceItemsList = fp.parseFile(filename);
        }

        public void saveRules()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("rules.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ptrl);
            }
        }

        public List<ProductTypeRuleList> loadRules()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("rules.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    List<ProductTypeRuleList> loadedRules = (List<ProductTypeRuleList>)formatter.Deserialize(fs);
                    return loadedRules;
                }
                catch (SerializationException)
                {
                    return new List<ProductTypeRuleList>();
                }
            }
        }
    }


}
