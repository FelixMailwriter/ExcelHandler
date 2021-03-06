﻿using System;
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

        public DataTable [] compareItems (DataTable SourceTable)
        {
            DataTable[] HandledItems = new DataTable[3];
            List<Item> SourceItems = ToItems(SourceTable);
            List<Item> RecognazedItems = new List<Item>();
            List<Item> NotRecognazedItems = new List<Item>();
            List<Item> SkippedItems = new List<Item>();

            foreach (Item item in SourceItems)
            {
                Item NewItem = new Item(item);
                foreach(ProductTypeRuleList ptrl in ProductTypeRules)
                {
                    if (ptrl.Aliases.Contains(NewItem.ItemProperties.ElementAt(10)))
                    {
                        NewItem=ptrl.checkRules(NewItem);
                        if (NewItem.Changed)
                        {
                            if (NewItem.ItemProperties.Count > 0)
                            {
                                RecognazedItems.Add(NewItem);
                            }
                            else
                            {
                                SkippedItems.Add(item);
                            }
                        }
                        break;
                    }
                }
                if (!NewItem.Changed)
                {
                    NotRecognazedItems.Add(NewItem);
                }
            }
            DataTable RecognaizedTable = ToDataTable(RecognazedItems);
            DataTable NotRecognaizedTable = ToDataTable(NotRecognazedItems);
            DataTable SkippedItemsTable = ToDataTable(SkippedItems);
            HandledItems[0] = RecognaizedTable;
            HandledItems[1] = NotRecognaizedTable;
            HandledItems[2] = SkippedItemsTable;
            return HandledItems;
         }

        private DataTable ToDataTable(List<Item> handledItems)
        {
            
            DataTable ResultTable = new DataTable("ResultTable");
            if (handledItems.Count == 0)
            {
                return ResultTable;
            }
            for (int i=0; i<handledItems[0].ItemProperties.Count; i++)
            {
                DataColumn dc = new DataColumn((i + 1).ToString());
                ResultTable.Columns.Add(dc);
            }

            foreach(Item item in handledItems)
            {
                DataRow dr = ResultTable.NewRow();
                for (int i =0; i<item.ItemProperties.Count; i++)
                {
                    dr[i] = item.ItemProperties.ElementAt(i).ToString();
                }
                ResultTable.Rows.Add(dr);
            }
            return ResultTable;
        }

        private List<Item> ToItems(DataTable SourceItems)
        {
            if (SourceItems == null) { return new List<Item>(); }
            List<Item> result = new List<Item>();
            foreach(DataRow dr in SourceItems.Rows)
            {
                result.Add(new Item(dr));
            }
            return result;
        }

    }
}
