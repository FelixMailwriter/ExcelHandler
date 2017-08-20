using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler
{
    public class ItemComparator
    {
        public List<ProductTypeRuleList> ProductTypeRules { get; private set; }
        public DataTable NotHandledItem { get; private set; }

        public ItemComparator(List<ProductTypeRuleList> prodTypeRulesList)
        {
            ProductTypeRules = prodTypeRulesList;
            NotHandledItem = new DataTable("NotHandledItems");
        }

        public DataTable compareItems (DataTable SourceTable)
        {
            List<Item> SourceItems = ToItems(SourceTable);
            List<Item> HandledItems = new List<Item>();
            foreach(Item item in SourceItems)
            {
                foreach(ProductTypeRuleList ptrl in ProductTypeRules)
                {
                    if (ptrl.Aliases.Contains(item.ItemProperties.ElementAt(10)))
                    {
                        Item NewItem=ptrl.checkRules(item);
                        HandledItems.Add(NewItem);
                        break;
                    }
                }
            }
            DataTable ResultTable = ToDataTable(HandledItems);
            return ResultTable;
         }

        private DataTable ToDataTable(List<Item> handledItems)
        {
            
            DataTable ResultTable = new DataTable("ResultTable");
            if (handledItems.Count == 0)
            {
                return ResultTable;
            }
            int columnCount = handledItems.ElementAt(0).ItemProperties.Count;
            for (int i=1; i==columnCount; i++)
            {
                ResultTable.Columns.Add(new DataColumn(i.ToString()));
            }

            foreach(Item item in handledItems)
            {
                DataRow dr = ResultTable.NewRow();
                for (int i =0; i<item.ItemProperties.Count; i++)
                {
                    dr[i + 1] = item.ItemProperties.ElementAt(i).ToString();
                }
                ResultTable.Rows.Add(dr);
            }
            return ResultTable;
        }

        private List<Item> ToItems(DataTable SourceItems)
        {
            List<Item> result = new List<Item>();
            foreach(DataRow dr in SourceItems.Rows)
            {
                result.Add(new Item(dr));
            }
            return result;
        }

    }
}
