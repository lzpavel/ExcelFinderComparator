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
using System.Threading;


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


            //excel2.Do(1);
            //ThreadStart threadStart = new ThreadStart();
            Thread thread = new Thread(new ThreadStart(ExcelHandler));
            thread.Start();


            /*Excel2 excel2 = new Excel2();
            excel2.Init();
            excel2.Do(1);
            excel2.Close();*/

            /*Excel2 excel2_2 = new Excel2();
            excel2_2.Init();
            excel2_2.Do(2);
            excel2_2.Close();

            Excel2 excel2_3 = new Excel2();
            excel2_3.Init();
            excel2_3.Do(3);
            excel2_3.Close();*/



            /*Application app = new Application();
            app.Workbooks.Open(@"C:\Users\Pafa\Desktop\temp\Test.xlsx");
            Worksheet worksheet = app.Workbooks[1].Worksheets[1];
            for (int i = 1; i <= 10; i++)
            {
                worksheet.Cells[i, 1].Value2 = i.ToString();
            }
            app.Workbooks[1].Save();
            app.Workbooks[1].Close();
            app.Quit();*/



        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button_debug_start_Click(object sender, EventArgs e)
        {

        }

        private void button_debug_stop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        void ExcelHandler()
        {
            Excel2 excel2 = new Excel2();
            excel2.Init();
            excel2.Do(1);
            excel2.Do(2);
            excel2.Do(3);
            excel2.Close();
        }

        class Excel2
        {
            public Application app = null;
            public Worksheet worksheet = null;

            public void Init()
            {
                app = new Application();
                app.Workbooks.Open(@"C:\Users\Pafa\Desktop\temp\Test.xlsx");
                worksheet = app.Workbooks[1].Worksheets[1];
            }

            public void Do(int col)
            {
                for (int i = 1; i <= 3; i++)
                {
                    worksheet.Cells[i, col].Value2 = i.ToString();
                }
            }

            public void Close()
            {
                app.Workbooks[1].Save();
                app.Workbooks[1].Close();
                app.Quit();
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
        }
    }
}
