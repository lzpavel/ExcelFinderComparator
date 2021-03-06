using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace ExcelFinderComparator
{
    public static class Excel
    {

        public static Application application { get; set; } = null;
        public static Worksheet[] sheets { get; set; } = null;
        public static Config[] configs { get; set; } = null;

        /*public Excel(Config[] excelConfigs = null)
        {
            if (excelConfigs != null)
            {
                configs = excelConfigs;
                OpenDocuments();
            }
        }*/

        public static void OpenExcel()
        {
            if (application == null)
            {
                try
                {
                    application = new Application();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message);
                }
                
            }
        }

        public static void OpenDocuments()
        {
            try
            {
                //ConnectExcel();
                sheets = new Worksheet[2];


                if (string.Compare(configs[0].pathStr, configs[1].pathStr) == 0)
                {

                    application.Workbooks.Open(configs[0].pathStr);

                    sheets[0] = application.Workbooks[1].Worksheets[configs[0].sheetDyn];
                    sheets[1] = application.Workbooks[1].Worksheets[configs[1].sheetDyn];


                }
                else
                {
                    for (int i = 0; i < configs.Length; i++)
                    {

                        application.Workbooks.Open(configs[i].pathStr);

                        sheets[i] = application.Workbooks[i + 1].Worksheets[configs[i].sheetDyn];

                    }
                }


            }
            catch (Exception ex)
            {
                Log.Write(ex.Message);
            }

        }

        public static void Save()
        {
            try
            {
                if (!application.Workbooks[1].ReadOnly)
                {
                    application.Workbooks[1].Save();

                }
                else
                {
                    string path = configs[0].pathStr;
                    string fname = path.Remove(path.LastIndexOf('.'));
                    fname = fname + "_new.xlsx";
                    application.Workbooks[1].SaveAs(Filename: fname);
                }
            } catch (Exception ex)
            {
                Log.Write(ex.Message);
            }
            


            /*try
            {
                application.Workbooks[1].SaveAs(Filename: @path);

            }
            catch (Exception ex)
            {
                try
                {
                    string fname = path.Remove(path.LastIndexOf('.'));
                    fname = fname + "_new.xlsx";
                    application.Workbooks[1].SaveAs(Filename: @fname);

                }
                catch (Exception ex2)
                {
                    Log.Write(ex2.Message);
                }
                Log.Write(ex.Message);
            }*/
            
        }

        public static void CloseDocuments()
        {

            try
            {
                application.Workbooks.Close();
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message);
            }
            
            //application.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

        }

        public static void CloseExcel()
        {

            try
            {
                if (application != null)
                {
                    application.Quit();
                    application = null;
                }
                
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message);
            }


        }

        public class Config
        {
            public string pathStr { get; private set; } = null;

            public string sheetStr { get; private set; } = null;
            public int sheetId { get; private set; } = 1;
            public bool sheetIsString { get; private set; } = false;

            public dynamic sheetDyn { get; private set; }



            public int column { get; private set; } = 0;
            public int rowStart { get; private set; } = 0;
            public int rowEnd { get; private set; } = 0;

            public bool state { get; private set; } = false;

            public Config(string rangeStr, string sheet, string path)
            {
                state = true;
                Tools.Range range = new Tools.Range(rangeStr);
                if (range.resultState)
                {
                    column = range.column;
                    rowStart = range.rowStart;
                    rowEnd = range.rowEnd;
                }
                else
                {
                    state = false;
                }

                if (sheet != null && sheet != "")
                {
                    if (sheet.StartsWith("\"") && sheet.EndsWith("\""))
                    {

                        string tmp = sheet.Remove(0, 1);
                        string tmpRes = tmp.Remove(tmp.Length - 1);
                        sheetStr = tmpRes;
                        sheetDyn = tmpRes;
                        sheetIsString = true;

                    }
                    else if (int.TryParse(sheet, out int tmpInt))
                    {
                        sheetId = tmpInt;
                        sheetDyn = tmpInt;

                        sheetIsString = false;
                    }
                    else
                    {
                        state = false;
                    }
                }
                else
                {
                    sheetIsString = false;
                    sheetId = 1;
                }

                if (path != null && path != "" && System.IO.File.Exists(path))
                {
                    pathStr = path;
                    state = true;
                }
            }


        }

    }

}
