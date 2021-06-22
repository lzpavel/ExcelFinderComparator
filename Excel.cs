using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace ExcelFinderComparator
{
    class Excel
    {

        public Application application { get; private set; } = null;
        public Worksheet[] sheets { get; private set; } = null;
        public Config[] configs { get; private set; } = null;

        public Excel(Config[] excelConfigs = null)
        {
            if(excelConfigs != null)
            {
                configs = excelConfigs;
                OpenDocuments();
            }
        }

        public void ConnectExcel()
        {
            if (application == null)
            {
                application = new Application();
            }
        }

        public void OpenDocuments()
        {
            try
            {
                ConnectExcel();
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

        public void Close()
        {

            for (int i = 0; i < application.Workbooks.Count; i++)
            {
                application.Workbooks[i + 1].Save();
            }
            application.Workbooks.Close();
            //application.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

        }

        public void DisconnectExcel()
        {
            if (application != null)
            {
                application.Quit();
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
