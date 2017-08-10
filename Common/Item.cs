using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHandler.Common
{
    public class Item
    {
       public Dictionary<int, string> ItemProperties { get; private set; }
       public bool Changed { get; set; }

        public Item(List<string> tempList)
        {
            ItemProperties = new Dictionary<int, string>();
            for (int i=1; i<tempList.Count; i++)
            {
                ItemProperties.Add(i, tempList[i - 1]);
            }
        }


        string this [int pos]
        {
            get
            {
                if ((pos > ItemProperties.Count - 1) || (pos<1))
                {
                    return "";
                }
                else
                {
                    return ItemProperties[pos];
                }
            }
            set{
                if (pos < 1)
                {
                    return;
                }
                if (ItemProperties.ContainsKey(pos))
                {
                    ItemProperties.Remove(pos);
                }
                ItemProperties.Add(pos, value);
                }
        }
    }
}
