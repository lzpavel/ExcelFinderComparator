using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using Sys = System.Windows.Forms;

using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;


namespace ExcelFinderComparator
{
    public partial class FormDebug : Sys.Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Application app = new Application();

            
            app.Workbooks.Open(@"C:\Users\Pafa\Desktop\temp\Test1.xlsx");
            app.Workbooks.Open(@"C:\Users\Pafa\Desktop\temp\Test2.xlsx");

            app.Workbooks[1].Worksheets[1].Cells[1, 2].Value = "1";
            app.Workbooks[2].Worksheets[1].Cells[2, 2].Value = "2";

            app.Workbooks[1].Save();
            app.Workbooks[2].Save();
            //app.ActiveWorkbook.Save();
            app.Workbooks.Close();
            app.Quit();






        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
