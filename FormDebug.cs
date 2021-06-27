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
                int wbcnt = app.Workbooks.Count;
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
                try
                {
                    //app.Workbooks[1].SaveAs();
                    app.Workbooks[1].SaveAs(Filename: @"C:\Users\Pafa\Desktop\temp\Test.xlsx");

                } catch (Exception ex)
                {
                    try
                    {
                        app.Workbooks[1].SaveAs(Filename: @"C:\Users\Pafa\Desktop\temp\Test_new.xlsx");

                    }
                    catch (Exception ex2)
                    {
                        Log.Write(ex2.Message);
                    }
                    Log.Write(ex.Message);
                }
                
                app.Workbooks[1].Close();
                app.Quit();
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
        }
        
    }
}
