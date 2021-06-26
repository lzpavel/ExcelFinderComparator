using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFinderComparator
{
    public static class Progress
    {
        public static int total { get; set; } = 0;
        public static int now { get; set; } = 0;

        public static bool isReady { get; set;} = false;
        public static bool isRunning { get; set; } = false;
        public static bool isCompleted { get; set;} = false;
        
        //public static States state { get; set; } = States.INIT_EXPECTED;

        /*public enum States
        {
            INIT_EXPECTED,
            INIT_READY,
            RUNNING,
            COMPLETED,
            ERROR
        }*/

        public static void Init(int totalVal)
        {
            total = totalVal;
            now = 0;
            isReady = true;
        }

        public static void Update()
        {
            now++;
            if (now == total)
            {
                isCompleted = true;

            } else if (now > total)
            {
                Log.Write("Progress now > total");
            }
        }

    }
}
