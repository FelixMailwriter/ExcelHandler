using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler
{
    [Serializable]
    public class SettingsKeeper
    {
        public static SettingsKeeper instance;
        public List<ProductTypeRuleList> RulesList { get; set; }
        public List<string> AccesibleColumns { get; set; }
        public List<string> SelectedColumns { get;  set; }
        public string SaveResultsPath { get;  set; }
        private string FileName;
        public Boolean AlwaysAskSavingPath { get; set; }

        private SettingsKeeper()
        {
            FileName = "settings.dat";
            RulesList = new List<ProductTypeRuleList>();
            AccesibleColumns = new List<string>();
            SelectedColumns = new List<string>();
            SaveResultsPath = "";
            loadSettings();
        }

        public static SettingsKeeper getInstance()
        {
            if (SettingsKeeper.instance == null)
            {
                SettingsKeeper.instance = new SettingsKeeper();
            }
            return SettingsKeeper.instance;
        }

        public void loadSettings()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                try
                {
                    SettingsKeeper sKeeper = (SettingsKeeper)formatter.Deserialize(fs);
                    RulesList = sKeeper.RulesList;
                    AccesibleColumns = sKeeper.AccesibleColumns;
                    SelectedColumns = sKeeper.SelectedColumns;
                    SaveResultsPath = sKeeper.SaveResultsPath;
                    AlwaysAskSavingPath = sKeeper.AlwaysAskSavingPath;
                }
                catch (SerializationException)
                {
                    //return new List<ProductTypeRuleList>();
                    //Environment.Exit(0);
                }
            }
        }

        //public void saveSettings(object sender, System.EventArgs e)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fs, this);
        //    }
        //}

        public void saveSettings(object sender, System.EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
    }
}
