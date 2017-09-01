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
    public class ParamElement
    {
        public event EventHandler SettingsChanged;
        private SettingsKeeper sk;
        public List<string> AccesibleColumns { get; private set; }
        public List<string> SelectedColumns { get; private set; }
        public string FileName { get; set; }

        public ParamElement()
        {
            sk = SettingsKeeper.getInstance();
            SettingsChanged += sk.saveSettings;
            AccesibleColumns = new List<string>() { "6","7","8","9","10","11","12","13" };
            SelectedColumns = new List<string>();
        }

        public ParamElement(string filename):this()
        {
            FileName = filename;
            if (!filename.Equals(""))
            {
                //loadParams(filename);
                AccesibleColumns = sk.AccesibleColumns;
                SelectedColumns = sk.SelectedColumns;
            }
        }

        public void setAccesinleColumns(List<string> newColumns)
        {
            AccesibleColumns = newColumns;
        }

        public void addAccesibleColumns(string newElement)
        {
            AccesibleColumns.Add(newElement);
        }

        public void removeAccesibleColumns(string removedElement)
        {
            AccesibleColumns.Remove(removedElement);
        }

        public void setSelectedColumns(List<string> newColumns)
        {
            SelectedColumns = newColumns;
        }

        public void addSelectedColumns(string newElement)
        {
            SelectedColumns.Add(newElement);
        }

        public void removeSelectedColumns(string removedElement)
        {
            SelectedColumns.Remove(removedElement);
        }

        // убрать
        public void loadParams(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                try
                {
                    ParamElement loadedParams = (ParamElement)formatter.Deserialize(fs);
                    AccesibleColumns = loadedParams.AccesibleColumns;
                    SelectedColumns = loadedParams.SelectedColumns;
                }
                catch (SerializationException)
                {
                    //AccesibleColumns = new List<string>();
                    //SelectedColumns = new List<string>();
                }
            }
        }

        public void saveParams()
        {
            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, this);
            //}
            //sk.AccesibleColumns = AccesibleColumns;
            //sk.SelectedColumns = SelectedColumns;
            SettingsChanged(this, null);
        }
    }
}
