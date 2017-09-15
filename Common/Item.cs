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

        public List<string> ItemProperties { get; private set; }
        public bool Changed { get; set; }

        public Item()
        {
            Changed = false;
            ItemProperties = new List<string>();
        }
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

        public Item(Item item)
        {
            Changed = item.Changed;
            ItemProperties = item.ItemProperties;
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
