using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace ExcelFinderComparator
{
    class Comparator
    {
        //private Application application;
        //private Worksheet sheet;

        public Comparator()
        {
            /*Application application;
            Worksheet sheet;

            application = new Application();
            application.Workbooks.Open(filePath);
            sheet = (Worksheet)application.Worksheets.get_Item(1);
            
            sheet.Activate();
            

            for(int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 1].Value = i.ToString();
                sheet.Cells[i, "B"].Value = i.ToString();
            }
            
            application.ActiveWorkbook.Save();
            
            //application.ActiveWorkbook.Close();
            application.Workbooks.Close();
            application.Quit();

            //dststr = sheet.Cells[i, 1].Value2.ToString();
            */
        }

        public void Compare(string path1, string range1, string range2, string path2 = "", string sheet1 = "", string sheet2 = "")
        {
            Application application;
            Worksheet sheet;

            application = new Application();
            application.Workbooks.Open(path1);
            sheet = (Worksheet)application.Worksheets.get_Item(1);

            sheet.Activate();

            Tools.ParsedRange parsedRange1 = new Tools.ParsedRange(range1);
            //parsedRange1.Parse(range1);
            Tools.ParsedRange parsedRange2 = new Tools.ParsedRange();
            parsedRange2.Parse(range2);

            int column1 = 0;
            int rowStart1 = 0;
            int rowEnd1 = 0;
            int column2 = 0;
            int rowStart2 = 0;
            int rowEnd2 = 0;
            /*int column1 = parsedRange1.getColumn();
            int rowStart1 = parsedRange1.getRowStart();
            int rowEnd1 = parsedRange1.getRowEnd();
            int column2 = parsedRange2.getColumn();
            int rowStart2 = parsedRange2.getRowStart();
            int rowEnd2 = parsedRange2.getRowEnd();*/

            if (parsedRange1.resultState)
            {
                column1 = parsedRange1.column;
                rowStart1 = parsedRange1.rowStart;
                rowEnd1 = parsedRange1.rowEnd;
            }
            if (parsedRange2.resultState)
            {
                column2 = parsedRange2.column;
                rowStart2 = parsedRange2.rowStart;
                rowEnd2 = parsedRange2.rowEnd;
            }

            
            
            for (int i = rowStart1; i <= rowEnd1; i++)
            {
                int cmpCount = 0;
                for(int j = rowStart2; j <= rowEnd2; j++)
                {
                    string str1 = sheet.Cells[i, column1].Value2.ToString();
                    string str2 = sheet.Cells[j, column2].Value2.ToString();
                    int cmpResult = String.Compare(str1, str2);
                    if(cmpResult == 0)
                    {
                        cmpCount++;
                    }
                }
                if(cmpCount == 0)
                {
                    sheet.Cells[i, column1].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                }
                else if(cmpCount > 1)
                {
                    sheet.Cells[i, column1].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                }
            }

            application.ActiveWorkbook.Save();
            application.Workbooks.Close();
            application.Quit();

            //application.ActiveWorkbook.Close();
            //sheet.Cells[i, 1].Value = i.ToString();
            //sheet.Cells[i, "B"].Value = i.ToString();
        }

        


    }
}
