using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectCanvas
{
    class AsyncTrial
    {
        public static async Task ForgeWeaponAsync()
        {
            Console.WriteLine("weapon forged");
            await Task.Delay(4000);
        }

        public static async Task BuildWallAsync()
        {
            Console.WriteLine("Wall Building");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Stuck in current method");
            }
            await Task.Run(() => CalculateDamageDone());
            //var Damage =  await CalculateDamageDone();
            //await Task.Delay(4000);
            Console.WriteLine("Wall Complete");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Stuck in current method");
            }
        }

        public static int CalculateDamageDone()
        {
            for(int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Calculated step at {0}", i);
            }
            Console.WriteLine("Calculation done");
            return 0;
        }

        public static async Task GatherTroopsAsync()
        {
            Console.WriteLine("gathering troops");
            await Task.Delay(5000);
        }

        public static async Task StartAssult()
        {
            await ForgeWeaponAsync();
            await BuildWallAsync();
            await GatherTroopsAsync();
            Console.WriteLine("Ready for battle");
        }

        public static async void RunClass()
        {
            await StartAssult();
        }
    }
}
