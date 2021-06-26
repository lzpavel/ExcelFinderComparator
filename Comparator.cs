using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using System.IO;

namespace ExcelFinderComparator
{
    public static class Comparator
    {

        public static Excel.Config[] excelConfigs { get; set; } = null;
        public static Worksheet[] sheets { get; set; } = null;
        //public static Config cmpConfig;


        

        /*public Comparator(Worksheet[] wSheets, Excel.Config[] excelCfg, Config comparatorCfg)
        {
            sheets = wSheets;
            excelConfigs = excelCfg;
            cmpConfig = comparatorCfg;
        }*/



        public static void CompareForEach1in2()
        {

            Progress.Init((excelConfigs[0].rowEnd - excelConfigs[0].rowStart + 1) * (excelConfigs[1].rowEnd - excelConfigs[1].rowStart + 1));

            for (int i = excelConfigs[0].rowStart; i <= excelConfigs[0].rowEnd; i++)
            {
                int cmpCount = 0;
                for (int j = excelConfigs[1].rowStart; j <= excelConfigs[1].rowEnd; j++)
                {
                    string str1 = sheets[0].Cells[i, excelConfigs[0].column].Value2.ToString();
                    string str2 = sheets[1].Cells[j, excelConfigs[1].column].Value2.ToString();
                    int cmpResult = String.Compare(str1, str2);
                    if (cmpResult == 0)
                    {
                        cmpCount++;
                    }
                    Progress.Update();
                }
                if (cmpCount == 0)
                {
                    sheets[0].Cells[i, excelConfigs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                }
                else if (cmpCount > 1 && Config.isMore1matches)
                {
                    sheets[0].Cells[i, excelConfigs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                }
            }


        }

        public static class Config
        {
            public static bool isMore1matches { get; set; } = true;

        }

    }
}
