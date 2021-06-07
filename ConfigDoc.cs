using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExcelFinderComparator
{
    class ConfigDoc
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

        public ConfigDoc(string range, string sheet = null, string path = null)
        {
            state = true;
            Tools.ParsedRange parsedRange = new Tools.ParsedRange(range);
            if (parsedRange.resultState)
            {
                column = parsedRange.column;
                rowStart = parsedRange.rowStart;
                rowEnd = parsedRange.rowEnd;
            }
            else
            {
                state = false;
            }

            if(sheet != null && sheet != "")
            {
                if (sheet.StartsWith("\"") && sheet.EndsWith("\""))
                {
                    
                    string tmp = sheet.Remove(0, 1);
                    string tmpRes = tmp.Remove(tmp.Length - 1);
                    sheetStr = tmpRes;
                    sheetDyn = tmpRes;
                    sheetIsString = true;
                    
                }
                else if(int.TryParse(sheet, out int tmpInt))
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
