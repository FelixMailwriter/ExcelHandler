using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
        public string SourceFileName { get; set; }
        private string settingsFileName;
        public Boolean AlwaysAskSavingPath { get; set; }

        private SettingsKeeper()
        {
            settingsFileName = "settings.dat";
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
            using (FileStream fs = new FileStream(settingsFileName, FileMode.OpenOrCreate))
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
                    Environment.Exit(0);
                }
            }
        }

        public void saveSettings(object sender, System.EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(settingsFileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
    }
}
