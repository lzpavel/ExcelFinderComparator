using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace ExcelFinderComparator
{
    public static class Finder
    {

        public static Excel.Config[] excelConfigs { get; set; } = null;
        public static Worksheet[] sheets { get; set; } = null;
        
        /*public Finder(Worksheet[] wSheets, Excel.Config[] excelCfg)
        {
            excelConfigs = excelCfg;
            sheets = wSheets;
        }*/

        public static void Find()
        {
            Progress.Init((excelConfigs[0].rowEnd - excelConfigs[0].rowStart + 1) * (excelConfigs[1].rowEnd - excelConfigs[1].rowStart + 1));

            for (int i = excelConfigs[0].rowStart; i <= excelConfigs[0].rowEnd; i++)
            {
                
                for (int j = excelConfigs[1].rowStart; j <= excelConfigs[1].rowEnd; j++)
                {
                    string str1 = sheets[0].Cells[i, excelConfigs[0].column].Value2.ToString();
                    string str2 = sheets[1].Cells[j, excelConfigs[1].column].Value2.ToString();
                    int cmpResult = String.Compare(str1, str2);
                    if (cmpResult == 0)
                    {
                        SetData(i, Config.setDataColumn, GetData(j, Config.getDataColumn));
                    }
                    Progress.Update();
                }

            }


        }


        private static dynamic GetData(int row, dynamic dataColumn)
        {
            dynamic data;
            if (Config.isGetDataFrom1)
            {
                data = sheets[0].Cells[row, dataColumn].Value2;
            }
            else
            {
                data = sheets[1].Cells[row, dataColumn].Value2;
            }
            return data;
        }

        private static void SetData(int row, dynamic dataColumn, dynamic data)
        {
            
            if (Config.isSetDataTo1)
            {
                sheets[0].Cells[row, dataColumn].Value2 = data;
            }
            else
            {
                sheets[1].Cells[row, dataColumn].Value2 = data;
            }
            
        }

        public static class Config
        {
            public static bool isGetDataFrom1 { get; set; } = false;
            public static bool isSetDataTo1 { get; set; } = true;

            public static dynamic getDataColumn { get; set; } = null;
            public static dynamic setDataColumn { get; set; } = null;
            
        }
    }
}
