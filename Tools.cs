using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace ExcelFinderComparator
{
    class Tools
    {
        public class Range
        {
            public int column { get; private set; } = 0;
            public int rowStart { get; private set; } = 0;
            public int rowEnd { get; private set; } = 0;

            public bool resultState { get; private set; } = false;

            public Range(string rangeStr = null)
            {
                if(rangeStr != null)
                {
                    Parse(rangeStr);
                }
            }

            public void Parse(string range)
            {
                Regex regexFormatA1 = new Regex(@"[A-Z]+\d+:[A-Z]+\d+");
                Regex regexFormatRC = new Regex(@"R\d+C\d+:R\d+C\d+");

                if (regexFormatA1.IsMatch(range))
                {
                    Regex regex = new Regex(@"[A-Z]+");
                    MatchCollection matches = regex.Matches(range);
                    int colCnt = 0;
                    foreach(Match match in matches)
                    {
                        string strCol = match.Value;
                        byte[] bytes = Encoding.ASCII.GetBytes(strCol);
                        Array.Reverse(bytes);
                        //bytes.Reverse();
                        int col = 0;
                        for(int i = 0; i < bytes.Length; i++)
                        {
                            col += (bytes[i] - 64) * Convert.ToInt32(Math.Pow(26, i));
                        }
                        if(colCnt++ == 0)
                        {
                            column = col;
                        }
                        
                    }

                    regex = new Regex(@"\d+");
                    matches = regex.Matches(range);
                    rowStart = int.Parse(matches[0].Value);
                    rowEnd = int.Parse(matches[1].Value);

                    resultState = true;
                    
                }
                else if(regexFormatRC.IsMatch(range))
                {

                }
                else
                {
                    resultState = false;
                }

            }

            
        }
    }
}
