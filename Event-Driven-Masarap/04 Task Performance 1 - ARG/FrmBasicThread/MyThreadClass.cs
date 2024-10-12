using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraBasicThread
{

    // Paala, James P.
    // BSIT - 501
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                System.Diagnostics.Debug.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500); // Suspend the thread for 1.5 seconds
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                System.Diagnostics.Debug.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500); // Suspend the thread for 1.5 seconds
            }
        }
    }
}
