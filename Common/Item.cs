using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.Common
{
    public class Item
    {
         //public Dictionary<int, string> ItemProperties { get; private set; }
        //public bool Changed { get; set; }

        // public Item(List<string> properties)
        // {
        //     Changed = false;
        //     ItemProperties = new Dictionary<int, string>();
        //     for (int i=1; i< properties.Count; i++)
        //     {
        //         ItemProperties.Add(i, properties[i - 1]);
        //     }
        // }

        // public Item (Dictionary<int, string> properties)
        // {
        //     Changed = false;
        //     ItemProperties = properties;
        // }
        public List<string> ItemProperties { get; private set; }
        public bool Changed { get; set; }

        public Item(List<string> properties)
        {
            Changed = false;
            ItemProperties = properties;
        }

        public Item(DataRow dr)
        {
            ItemProperties = new List<string>();
            object [] values = dr.ItemArray;
            foreach (object value in values)
            {
                ItemProperties.Add(value.ToString());
            }
            Changed = false;
        }

        public string this [int pos]
        {
            get
            {
                if ((pos > ItemProperties.Count - 1) || (pos<1))
                {
                    return "";
                }
                else
                {
                    return ItemProperties.ElementAt(pos-1);
                }
            }
            set{
                if (pos < 1)
                {
                    return;
                }
                try
                {
                    ItemProperties.RemoveAt(pos - 1);
                }
                catch (ArgumentOutOfRangeException) { }
                ItemProperties.Insert(pos-1, value);
                }
        }
    }
}
