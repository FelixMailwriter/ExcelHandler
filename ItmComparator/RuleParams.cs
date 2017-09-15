using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelHandler.Common;

namespace ExcelHandler.ItmComparator.Actions
{
    [Serializable]
    public class RuleParams
    {
        public Item ItemInstance { get; set; }
        public int TargetColumn { get; set; }
        public string suffix { get; set; }
        public int sourceValueColumn { get; set; }
        public int ChangadColumn { get; set; }
        public string ChangadColumnValue { get; set; }
    }
}
