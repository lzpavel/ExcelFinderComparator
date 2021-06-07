using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFinderComparator
{
    

    public static class Log
    {
        public static Queue<string> queue = new Queue<string>();

        public static void Write(string msg)
        {
            queue.Enqueue(msg + "\r\n\r\n");
        }

        public static string GetLog()
        {
            string outStr = "";

            while(queue.Count > 0)
            {
                outStr += queue.Dequeue();
            }

            return outStr;
        }
        
    }
}
