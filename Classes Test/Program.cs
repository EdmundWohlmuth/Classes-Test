using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class Program
    {       
        static void Main(string[] args)
        {
            bool isRunning = true;

            HUD HUD = new HUD();
            Player Player = new Player();

            while (isRunning)
            {
                HUD.DrawHUD();
                Console.ReadKey(true);
            }

            Console.ReadKey(true);
        }
    }
}
