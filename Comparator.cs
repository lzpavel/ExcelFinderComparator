﻿using System;
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

        private Excel.Config[] excelConfig = null;
        private Worksheet[] sheets = null;
        Config cmpConfig;


        

        public Comparator(Worksheet[] wSheets, Excel.Config[] excelCfg, Config comparatorCfg)
        {
            sheets = wSheets;
            excelConfig = excelCfg;
            cmpConfig = comparatorCfg;
        }



        public void CompareForEach1in2()
        {

            for (int i = excelConfig[0].rowStart; i <= excelConfig[0].rowEnd; i++)
            {
                int cmpCount = 0;
                for (int j = excelConfig[1].rowStart; j <= excelConfig[1].rowEnd; j++)
                {
                    string str1 = sheets[0].Cells[i, excelConfig[0].column].Value2.ToString();
                    string str2 = sheets[1].Cells[j, excelConfig[1].column].Value2.ToString();
                    int cmpResult = String.Compare(str1, str2);
                    if (cmpResult == 0)
                    {
                        cmpCount++;
                    }
                }
                if (cmpCount == 0)
                {
                    sheets[0].Cells[i, excelConfig[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                }
                else if (cmpCount > 1 && cmpConfig.isMore1matches)
                {
                    sheets[0].Cells[i, excelConfig[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                }
            }


        }

        public class Config
        {
            public bool isMore1matches { get; set; } = true;

        }

    }
}
