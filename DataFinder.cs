using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace ExcelFinderComparator
{
    class DataFinder
    {

        private Excel.Config[] excelConfigs = null;
        private Worksheet[] sheets = null;
        
        public DataFinder(Worksheet[] wSheets, Excel.Config[] excelCfg)
        {
            excelConfigs = excelCfg;
            sheets = wSheets;
        }

        public void Find()
        {
            Excel.Progress.Init(excelConfigs);

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
                    Excel.Progress.now++;
                }

            }


        }


        public dynamic GetData(int row, dynamic dataColumn)
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

        public void SetData(int row, dynamic dataColumn, dynamic data)
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
