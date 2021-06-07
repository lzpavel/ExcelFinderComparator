using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using System.IO;

namespace ExcelFinderComparator
{
    class Comparator
    {

        private ConfigDoc[] configDocs;

        private Application application;
        private Worksheet[] sheets = new Worksheet[2];



        public Comparator(ConfigDoc[] inConfigDocs)
        {
            configDocs = inConfigDocs;
        }

        public void OpenDocuments()
        {
            try
            {
                application = new Application();



                if(string.Compare(configDocs[0].pathStr, configDocs[1].pathStr) == 0)
                {

                    application.Workbooks.Open(configDocs[0].pathStr);

                    sheets[0] = application.Workbooks[1].Worksheets[configDocs[0].sheetDyn];
                    sheets[1] = application.Workbooks[1].Worksheets[configDocs[1].sheetDyn];
                    

                }
                else
                {
                    for(int i = 0; i < configDocs.Length; i++)
                    {

                        application.Workbooks.Open(configDocs[i].pathStr);

                        sheets[i] = application.Workbooks[i + 1].Worksheets[configDocs[i].sheetDyn];

                    }
                }


            }
            catch(Exception ex)
            {
                Log.Write(ex.Message);
            }

        }

        public void CompareForEach1in2()
        {

            for (int i = configDocs[0].rowStart; i <= configDocs[0].rowEnd; i++)
            {
                int cmpCount = 0;
                for (int j = configDocs[1].rowStart; j <= configDocs[1].rowEnd; j++)
                {
                    string str1 = sheets[0].Cells[i, configDocs[0].column].Value2.ToString();
                    string str2 = sheets[1].Cells[j, configDocs[1].column].Value2.ToString();
                    int cmpResult = String.Compare(str1, str2);
                    if (cmpResult == 0)
                    {
                        cmpCount++;
                    }
                }
                if (cmpCount == 0)
                {
                    sheets[0].Cells[i, configDocs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                }
                else if (cmpCount > 1)
                {
                    sheets[0].Cells[i, configDocs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                }
            }


        }

        public void Close()
        {

            for(int i = 0; i < application.Workbooks.Count; i++)
            {
                application.Workbooks[i + 1].Save();
            }
            application.Workbooks.Close();
            application.Quit();
            
        }

        


    }
}
