using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BasicThreading_Laureto
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int LoopCount = 0; LoopCount <6; LoopCount++)
            {
                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + LoopCount);
            }
        }
    }
}
