using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelHandler
{
    public partial class AddRule : Form
    {
        private RulesManager rm;
        private string typeName;
        private string ruleDescription;

        public AddRule(RulesManager rm, string typeName, string ruleDescription)
        {
            this.rm = rm;
            this.typeName = typeName;
            this.ruleDescription = ruleDescription;
            if (!ruleDescription.Equals(""))
            {
                fillForm();
            }
        }

        private void fillForm()
        {
            ProductTypeRuleList Type = rm.getType(typeName);
            Rule rule = ProductTypeRuleList.getRuleByDescription(ruleDescription);
        }
    }
}
