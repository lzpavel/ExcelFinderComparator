using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFinderComparator
{
    

    public static class Log
    {
        public static List<string> listMessages { get; set; } = new List<string>();
        //public static Queue<string> queue = new Queue<string>();

        public static void Write(string message)
        {
            listMessages.Add(message + "\r\n\r\n");
            //queue.Enqueue(message + "\r\n\r\n");
        }

        /*public static string GetLog()
        {
            listMessages

            string outStr = "";

            while(queue.Count > 0)
            {
                outStr += queue.Dequeue();
            }

            return outStr;
        }*/
        
    }
}
