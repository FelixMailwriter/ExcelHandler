using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelHandler
{
    public partial class MainForm : Form
    {
        private ParamElement pElements; 


        private void fillForm()
        {
            pElements = new ParamElement("pelements.dat");
            lsbx_AccCol.DataSource = pElements.AccesibleColumns;
            lsbx_SelCol.DataSource = pElements.SelectedColumns;
            cxbx_AlwaysAskPath.Checked = sk.AlwaysAskSavingPath;
            txbx_PathToSavedFiles.Text = sk.SaveResultsPath;
        }
    }
}
