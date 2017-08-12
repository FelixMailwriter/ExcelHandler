using System;

namespace ExcelHandler
{
    public class Condition
    {
        private string targetColumn;

        public string TargetColumn { get; private set; }
        public string Param { get; private set; }
        public Operation Operation { get; private set; }
        public string Suffix { get; private set; }


        public bool makeCompare()
        {
            throw new NotImplementedException();
        }
    }
}