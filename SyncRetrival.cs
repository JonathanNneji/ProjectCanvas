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



        public static void MultiThreadTesting()
        {
            var thread1 = new Thread(TypeThread1);
            thread1.Start();
            //GetInputFromUser();

            Thread thread2 = new Thread(TypeThread2);
            thread2.Start();

            //Thread.Sleep(1000);

            thread1.Join();
           // thread2.Join();

            
        }

        public static void TypeThread1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread 1: {0}", i);
                Thread.Sleep(100);
            }
        }


        public static void GetInputFromUser()
        {
            string greetingText;
            Console.WriteLine("Enter a number");
            greetingText = Console.ReadLine();

            //TypeThread1();

            Thread.Sleep(1000);
            Console.WriteLine("This person wrote: " + greetingText);
        }

        public static void TypeThread2()
        {
            for (int i = 100; i < 200; i++)
            {
                Console.WriteLine("Thread 2: {0}", i);
                Thread.Sleep(100);
            }
        }
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
