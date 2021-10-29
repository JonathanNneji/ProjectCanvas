using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            await Task.Delay(7000);
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
