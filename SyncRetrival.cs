using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectCanvas
{
    class SyncRetrival
    {

        public void runThread()
        {
            Console.WriteLine("Main thread: Start a second thread.");
            Thread t = new(new ThreadStart(ProcThread));

            t.Start();
            Thread.Sleep(100);


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
            t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
            Console.ReadLine();
        }

        public static void ProcThread()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(100);
            }
        }

    }
}
