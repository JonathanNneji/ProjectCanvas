using System;
using System.Threading;

namespace ProjectCanvas
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = AsyncTrial.BuildWallAsync();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Im still here");
            }
        }
    }
}
